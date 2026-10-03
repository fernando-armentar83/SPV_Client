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
    public partial class FrmAjusteStock : Form
    {
        private int idProductoAjuste = 0;
        private decimal stockSistema = 0m;

        public FrmAjusteStock()
        {
            InitializeComponent();
        }

        private void FrmAjusteStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                btnBuscarProductoAjuste_Click(sender, e);
            }
        }

        private void FrmAjusteStock_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarProductoAjuste_Click(object sender, EventArgs e)
        {
            using (FrmBuscarProducto frm = new FrmBuscarProducto())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                if (frm.ProductoSeleccionado == null)
                    return;

                CargarProducto(frm.ProductoSeleccionado.IdProducto);
            }
        }

        private void CargarProducto(int idProducto)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();

                string sql = "SELECT nombre, stock_actual FROM productos WHERE id_producto = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return;

                        txtProductoAjuste.Text = dr["nombre"].ToString();
                        stockSistema = Convert.ToDecimal(dr["stock_actual"]);
                        lblStockSistema.Text = $"Stock en sistema: {stockSistema:0.###}";
                    }
                }
            }

            idProductoAjuste = idProducto;
            CalcularResultante();
        }

        private void txtAjuste_TextChanged(object sender, EventArgs e)
        {
            CalcularResultante();
        }

        private void CalcularResultante()
        {
            lblStockResultante.Text = "Stock resultante: 0";

            if (idProductoAjuste == 0)
                return;

            if (!decimal.TryParse(txtAjuste.Text, out decimal ajuste))
                return;

            lblStockResultante.Text = $"Stock resultante: {(stockSistema + ajuste):0.###}";
        }

        private void btnGuardarAjuste_Click(object sender, EventArgs e)
        {
            if (Session.IdUsuario == 0 || Session.IdTurno == 0)
            {
                MessageBox.Show(
                    "No hay una sesión o turno activo.",
                    "Sesión requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (idProductoAjuste == 0)
            {
                MessageBox.Show(
                    "Busque el producto a ajustar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAjuste.Text, out decimal ajuste) || ajuste == 0)
            {
                MessageBox.Show(
                    "Capture un ajuste distinto de cero.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtAjuste.Focus();
                return;
            }

            if (stockSistema + ajuste < 0)
            {
                MessageBox.Show(
                    "El ajuste dejaría el stock en negativo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtObservacionesAjuste.Text))
            {
                MessageBox.Show(
                    "Debe capturar una observación que justifique el ajuste.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtObservacionesAjuste.Focus();
                return;
            }

            DialogResult r = MessageBox.Show(
                $"¿Confirma el ajuste de {ajuste:+0.###;-0.###} en '{txtProductoAjuste.Text}'?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No)
                return;

            using (FrmAutorizacionStock frmAuth = new FrmAutorizacionStock())
            {
                if (frmAuth.ShowDialog() != DialogResult.OK)
                    return;

                string descripcion =
                    $"Ajuste de inventario. Autorizó: usuario {frmAuth.IdUsuarioAutorizo}. " +
                    txtObservacionesAjuste.Text.Trim();

                try
                {
                    using (var conn = DB.GetConnection())
                    {
                        conn.Open();

                        string sql = @"
INSERT INTO movimientos_stock (id_producto, id_usuario, tipo_movimiento, cantidad, descripcion)
VALUES (@id_producto, @id_usuario, 'AJUSTE', @cantidad, @descripcion);";

                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_producto", idProductoAjuste);
                            cmd.Parameters.AddWithValue("@id_usuario", Session.IdUsuario);
                            cmd.Parameters.AddWithValue("@cantidad", ajuste);
                            cmd.Parameters.AddWithValue("@descripcion", descripcion);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show(
                        "Ajuste realizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarProducto(idProductoAjuste);
                    txtAjuste.Clear();
                    txtObservacionesAjuste.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"AJUSTE DE STOCK

BUSCAR (F2)
Busca el producto a ajustar.

AJUSTE
Captura directamente la diferencia: positivo para sumar
(sobrante), negativo para restar (faltante). Ejemplo:
si sobran 3 piezas, captura 3. Si faltan 2, captura -2.

El Stock Resultante es solo una vista previa, no se
guarda hasta dar clic en Guardar Ajuste.

OBSERVACIONES
Obligatorio: explica por qué se hizo el ajuste
(ej. 'conteo físico de fin de mes').

Todo ajuste queda registrado en el Kardex del producto
y requiere autorización para guardarse.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCerrarAjuste_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
