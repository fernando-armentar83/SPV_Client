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
    public partial class FrmConversiones : Form
    {
        private int idConversionSeleccionada = 0;
        private int idProductoOrigen = 0;
        private int idProductoDestino = 0;

        public FrmConversiones()
        {
            InitializeComponent();
        }

        private void FrmConversiones_Load(object sender, EventArgs e)
        {
            CargarConversiones();
            LimpiarFormulario();
        }

        private void FrmConversiones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                btnBuscarOrigenConv_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                e.SuppressKeyPress = true;
                btnBuscarDestinoConv_Click(sender, e);
            }
        }

        private void CargarConversiones()
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    pc.id_conversion,
    po.nombre AS origen,
    pd.nombre AS destino,
    pc.factor,
    CASE WHEN pc.activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS estado
FROM producto_conversiones pc
INNER JOIN productos po ON po.id_producto = pc.id_producto_origen
INNER JOIN productos pd ON pd.id_producto = pc.id_producto_destino
ORDER BY po.nombre;";

                using (var da = new MySqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvConversiones.DataSource = dt;
                }
            }
        }

        private void LimpiarFormulario()
        {
            idConversionSeleccionada = 0;
            idProductoOrigen = 0;
            idProductoDestino = 0;

            txtProductoOrigenConv.Clear();
            txtProductoDestinoConv.Clear();
            txtFactorConversion.Clear();
            chkActivoConversion.Checked = true;

            btnBuscarOrigenConv.Enabled = true;
            btnBuscarDestinoConv.Enabled = true;

            btnGuardarConversion.Enabled = true;
            btnEditarConversion.Enabled = false;
            btnDesactivarConversion.Enabled = false;
            btnDesactivarConversion.Text = "Desactivar";

            dgvConversiones.ClearSelection();
        }

        private void btnNuevoConversion_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private string ObtenerNombreProducto(int idProducto)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(
                    "SELECT nombre FROM productos WHERE id_producto = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    object resultado = cmd.ExecuteScalar();
                    return resultado?.ToString() ?? "";
                }
            }
        }

        private void btnBuscarOrigenConv_Click(object sender, EventArgs e)
        {
            using (FrmBuscarProducto frm = new FrmBuscarProducto())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                if (frm.ProductoSeleccionado == null)
                    return;

                idProductoOrigen = frm.ProductoSeleccionado.IdProducto;
                txtProductoOrigenConv.Text = ObtenerNombreProducto(idProductoOrigen);
            }
        }

        private void btnBuscarDestinoConv_Click(object sender, EventArgs e)
        {
            using (FrmBuscarProducto frm = new FrmBuscarProducto())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                if (frm.ProductoSeleccionado == null)
                    return;

                idProductoDestino = frm.ProductoSeleccionado.IdProducto;
                txtProductoDestinoConv.Text = ObtenerNombreProducto(idProductoDestino);
            }
        }

        private void btnGuardarConversion_Click(object sender, EventArgs e)
        {
            if (idProductoOrigen == 0 || idProductoDestino == 0)
            {
                MessageBox.Show(
                    "Busque el producto origen y el producto destino.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (idProductoOrigen == idProductoDestino)
            {
                MessageBox.Show(
                    "El producto origen y destino no pueden ser el mismo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFactorConversion.Text, out decimal factor) || factor <= 0)
            {
                MessageBox.Show(
                    "Capture un factor válido, mayor a cero.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtFactorConversion.Focus();
                return;
            }

            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
INSERT INTO producto_conversiones (id_producto_origen, id_producto_destino, factor, activo)
VALUES (@origen, @destino, @factor, @activo);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@origen", idProductoOrigen);
                        cmd.Parameters.AddWithValue("@destino", idProductoDestino);
                        cmd.Parameters.AddWithValue("@factor", factor);
                        cmd.Parameters.AddWithValue("@activo", chkActivoConversion.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Conversión guardada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarConversiones();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show(
                    "Ya existe una conversión definida entre estos dos productos.",
                    "Duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConversiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvConversiones.Rows[e.RowIndex];

            idConversionSeleccionada = Convert.ToInt32(fila.Cells["colIdConversion"].Value);
            txtProductoOrigenConv.Text = fila.Cells["colOrigen"].Value.ToString();
            txtProductoDestinoConv.Text = fila.Cells["colDestino"].Value.ToString();
            txtFactorConversion.Text = Convert.ToDecimal(fila.Cells["colFactor"].Value).ToString("0.###");

            bool activo = fila.Cells["colEstado"].Value.ToString() == "Activo";
            chkActivoConversion.Checked = activo;

            btnBuscarOrigenConv.Enabled = false;
            btnBuscarDestinoConv.Enabled = false;

            btnGuardarConversion.Enabled = false;
            btnEditarConversion.Enabled = true;
            btnDesactivarConversion.Enabled = true;
            btnDesactivarConversion.Text = activo ? "Desactivar" : "Activar";
        }

        private void btnEditarConversion_Click(object sender, EventArgs e)
        {
            if (idConversionSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una conversión.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFactorConversion.Text, out decimal factor) || factor <= 0)
            {
                MessageBox.Show(
                    "Capture un factor válido, mayor a cero.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtFactorConversion.Focus();
                return;
            }

            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = "UPDATE producto_conversiones SET factor = @factor WHERE id_conversion = @id;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@factor", factor);
                        cmd.Parameters.AddWithValue("@id", idConversionSeleccionada);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Factor actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarConversiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesactivarConversion_Click(object sender, EventArgs e)
        {
            if (idConversionSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una conversión.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool nuevoEstado = !chkActivoConversion.Checked;
            string accion = nuevoEstado ? "activar" : "desactivar";

            DialogResult r = MessageBox.Show(
                $"¿Desea {accion} esta conversión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No)
                return;

            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = "UPDATE producto_conversiones SET activo = @activo WHERE id_conversion = @id;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@activo", nuevoEstado);
                        cmd.Parameters.AddWithValue("@id", idConversionSeleccionada);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    $"Conversión {(nuevoEstado ? "activada" : "desactivada")} correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarConversiones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarConversiones_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        @"CATÁLOGO DE CONVERSIONES

Este Formulario enlaza los productos a  en
Conversión de Stock.

BUSCAR BOTÓN/(F2) ORIGEN ------> BUSCAR BOTÓN/(F3) DESTINO
Elige los dos productos de la conversión.

FACTOR
Cuánto del destino equivale a 1 unidad del origen.
Ejemplo: caja de 100 piezas → factor 100.
Ejemplo: tramo de 6 metros → factor 6.

ACTIVA
Si está desmarcada, esta conversión no aparece como
opción en Conversión de Stock. No se borra, solo se
oculta. Se puede volver a activar cuando se requiera.

En la Lista encontraras los Productos que ya están
con su conversión y no es necesario volverlo a hacer,
ya se puede realizar en Conversión de Stock.

No se puede editar el origen/destino de una conversión
ya guardada: hay que crear una nueva si eso cambia.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
