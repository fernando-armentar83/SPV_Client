using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SPV_Client
{
    public partial class FrmConversionStock : Form
    {
        private int idProductoOrigen = 0;
        private decimal stockOrigenActual = 0m;
        private DataTable dtConversiones;
        private bool origenFijo = false;

        public FrmConversionStock()
        {
            InitializeComponent();
        }

        public FrmConversionStock(int idProductoOrigenFijo)
        {
            InitializeComponent();
            origenFijo = true;
            idProductoOrigen = idProductoOrigenFijo;
        }

        private void FrmConversionStock_Load(object sender, EventArgs e)
        {
            if (origenFijo)
            {
                btnBuscarOrigen.Enabled = false;
                CargarProductoOrigen(idProductoOrigen);
            }
        }

        private void btnBuscarOrigen_Click(object sender, EventArgs e)
        {
            using (FrmBuscarProducto frm = new FrmBuscarProducto())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                if (frm.ProductoSeleccionado == null)
                    return;

                CargarProductoOrigen(frm.ProductoSeleccionado.IdProducto);
            }
        }

        private void CargarProductoOrigen(int idProducto)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT nombre, stock_actual
FROM productos
WHERE id_producto = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return;

                        txtProductoOrigen.Text = dr["nombre"].ToString();
                        stockOrigenActual = Convert.ToDecimal(dr["stock_actual"]);
                        lblStockOrigen.Text = $"Stock disponible: {stockOrigenActual:0.###}";
                    }
                }

                idProductoOrigen = idProducto;

                string sqlConv = @"
SELECT
    pc.factor,
    pd.id_producto AS id_producto_destino,
    pd.nombre AS destino
FROM producto_conversiones pc
INNER JOIN productos pd ON pd.id_producto = pc.id_producto_destino
WHERE pc.id_producto_origen = @id
  AND pc.activo = 1;";

                using (var cmd = new MySqlCommand(sqlConv, conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);

                    dtConversiones = new DataTable();
                    da.Fill(dtConversiones);
                }
            }

            if (dtConversiones.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Este producto no tiene ninguna conversión definida.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbDestino.DataSource = null;
                btnConvertir.Enabled = false;
                return;
            }

            cmbDestino.DataSource = dtConversiones;
            cmbDestino.DisplayMember = "destino";
            cmbDestino.ValueMember = "id_producto_destino";
            btnConvertir.Enabled = true;

            CalcularResultante();
        }

        private void txtCantidadOrigen_TextChanged(object sender, EventArgs e)
        {
            CalcularResultante();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularResultante();
        }

        private void CalcularResultante()
        {
            lblCantidadResultante.Text = "";

            if (cmbDestino.SelectedIndex < 0)
                return;

            if (!decimal.TryParse(txtCantidadOrigen.Text, out decimal cantidad))
                return;

            DataRowView fila = (DataRowView)cmbDestino.SelectedItem;
            decimal factor = Convert.ToDecimal(fila["factor"]);

            lblCantidadResultante.Text =
                $"Resultante: {(cantidad * factor):0.###}";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (Session.IdUsuario == 0 || Session.IdTurno == 0)
            {
                MessageBox.Show(
                    "No hay una sesión o turno activo. Abra un turno antes de realizar conversiones.",
                    "Sesión requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (idProductoOrigen == 0)
            {
                MessageBox.Show(
                    "Busque el producto de origen.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCantidadOrigen.Text, out decimal cantidadOrigen) ||
                cantidadOrigen <= 0)
            {
                MessageBox.Show(
                    "Capture una cantidad válida a convertir.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCantidadOrigen.Focus();
                return;
            }

            if (cantidadOrigen > stockOrigenActual)
            {
                MessageBox.Show(
                    $"No hay suficiente stock. Disponible: {stockOrigenActual:0.###}",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (FrmAutorizacionStock frmAuth = new FrmAutorizacionStock())
            {
                if (frmAuth.ShowDialog() != DialogResult.OK)
                    return;

                DataRowView fila = (DataRowView)cmbDestino.SelectedItem;
                decimal factor = Convert.ToDecimal(fila["factor"]);
                int idProductoDestino = Convert.ToInt32(fila["id_producto_destino"]);
                string nombreDestino = fila["destino"].ToString();
                decimal cantidadDestino = cantidadOrigen * factor;

                string descripcion =
                    $"Conversión de stock: {cantidadOrigen:0.###} de '{txtProductoOrigen.Text}' " +
                    $"a {cantidadDestino:0.###} de '{nombreDestino}'. " +
                    $"Autorizó: usuario {frmAuth.IdUsuarioAutorizo}. " +
                    txtObservacionesConversion.Text.Trim();

                try
                {
                    using (var conn = DB.GetConnection())
                    {
                        conn.Open();

                        using (var trans = conn.BeginTransaction())
                        {
                            try
                            {
                                string sqlSalida = @"
INSERT INTO movimientos_stock (id_producto, id_usuario, tipo_movimiento, cantidad, descripcion)
VALUES (@id_producto, @id_usuario, 'SALIDA', @cantidad, @descripcion);";

                                using (var cmd = new MySqlCommand(sqlSalida, conn, trans))
                                {
                                    cmd.Parameters.AddWithValue("@id_producto", idProductoOrigen);
                                    cmd.Parameters.AddWithValue("@id_usuario", Session.IdUsuario);
                                    cmd.Parameters.AddWithValue("@cantidad", cantidadOrigen);
                                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                                    cmd.ExecuteNonQuery();
                                }

                                string sqlEntrada = @"
INSERT INTO movimientos_stock (id_producto, id_usuario, tipo_movimiento, cantidad, descripcion)
VALUES (@id_producto, @id_usuario, 'ENTRADA', @cantidad, @descripcion);";

                                using (var cmd = new MySqlCommand(sqlEntrada, conn, trans))
                                {
                                    cmd.Parameters.AddWithValue("@id_producto", idProductoDestino);
                                    cmd.Parameters.AddWithValue("@id_usuario", Session.IdUsuario);
                                    cmd.Parameters.AddWithValue("@cantidad", cantidadDestino);
                                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                                    cmd.ExecuteNonQuery();
                                }

                                trans.Commit();
                            }
                            catch
                            {
                                trans.Rollback();
                                throw;
                            }
                        }
                    }

                    MessageBox.Show(
                        "Conversión realizada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProductoOrigen(idProductoOrigen);
                    txtCantidadOrigen.Clear();
                    txtObservacionesConversion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrarConversion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConversionStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && !origenFijo)
            {
                e.SuppressKeyPress = true;
                btnBuscarOrigen_Click(sender, e);
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        @"CONVERSIÓN DE STOCK
--->  Recuerda si no se ha convertido el producto hacerlo primero en Conversión <---

BUSCAR (Click en Botón o F2)
Elige el producto de origen (Caja, Bolsa, Kilo, Metro, Litro).
1.-Este puede ser usado desde Item y no será necesario realizar la busqueda.
2.-Si es abierto desde administrador, verificar si el producto ya se encuentra
en la lista de conversiones.

CONVERTIR A
Lista las conversiones ya definidas para el producto
origen (ver catálogo de Conversiones).

CANTIDAD A CONVERTIR (ORIGEN)
Cuánto del producto origen se va a descontar.
El movimiento depende de la cantidad del producto (caja con 100 pz, bolsa con 25 pz).
*Resultante ----> Indica la cantidad que se transfiere de unidad a piezas.

BOTÓN CONVERTIR
Pide autorización y ejecuta el movimiento: resta del
origen, suma al destino. Queda registrado en el
historial (Kardex) de ambos productos.

No se puede convertir más de lo que hay en existencia.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
