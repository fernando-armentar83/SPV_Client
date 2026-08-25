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
    public partial class FrmProveedores : Form
    {

        private int idProveedorSeleccionado = 0;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void CargarEstados()
        {
            cmbEstadoPro.Items.Clear();

            cmbEstadoPro.Items.Add("ACTIVO");
            cmbEstadoPro.Items.Add("INACTIVO");

            cmbEstadoPro.SelectedIndex = 0;
        }

        private void LimpiarFormulario()
        {
            idProveedorSeleccionado = 0;

            txtProveedor.Clear();
            txtContactoPro.Clear();
            txtTelefonoPro.Clear();
            txtCorreoPro.Clear();
            txtRFCPro.Clear();
            txtDireccionPro.Clear();

            cmbEstadoPro.SelectedIndex = 0;

            btnGuardarProveedor.Enabled = true;
            btnEditarProveedor.Enabled = false;
            btnDesactivarProveedor.Enabled = false;

            btnDesactivarProveedor.Text = "Desactivar";

            dgvProveedores.ClearSelection();
            dgvProveedores.CurrentCell = null;

            txtProveedor.Focus();
        }

        private void CargarProveedores()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_proveedor,
    nombre,
    contacto,
    telefono,
    rfc,
    estado,
    fecha_registro
FROM proveedores
ORDER BY nombre";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvProveedores.DataSource = dt;

                        ActualizarContadorProveedores();
                    }
                }
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

        private void BuscarProveedores()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_proveedor,
    nombre,
    contacto,
    telefono,
    rfc,
    estado,
    fecha_registro
FROM proveedores
WHERE nombre LIKE @buscar
ORDER BY nombre";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@buscar",
                            "%" + txtBuscarProveedor.Text.Trim() + "%");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            dgvProveedores.DataSource = dt;

                            ActualizarContadorProveedores();
                        }
                    }
                }
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

        private void CargarDatosProveedorCompleto()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    email,
    direccion
FROM proveedores
WHERE id_proveedor = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            idProveedorSeleccionado);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtCorreoPro.Text =
                                    dr["email"]?.ToString() ?? "";

                                txtDireccionPro.Text =
                                    dr["direccion"]?.ToString() ?? "";
                            }
                        }
                    }
                }
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

        private void ActualizarContadorProveedores()
        {
            lblTotalProveedores.Text =
                $"Total: {dgvProveedores.Rows.Count}";
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.AutoGenerateColumns = false;

            CargarEstados();

            CargarProveedores();

            btnEditarProveedor.Enabled = false;
            btnDesactivarProveedor.Enabled = false;

            LimpiarFormulario();
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                string proveedor = txtProveedor.Text.Trim();

                if (proveedor == "")
                {
                    MessageBox.Show(
                        "Capture el nombre del proveedor.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtProveedor.Focus();
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sqlExiste = @"
SELECT COUNT(*)
FROM proveedores
WHERE nombre = @nombre";

                    using (var cmdExiste = new MySqlCommand(sqlExiste, conn))
                    {
                        cmdExiste.Parameters.AddWithValue(
                            "@nombre",
                            proveedor);

                        int existe =
                            Convert.ToInt32(
                                cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "El proveedor ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtProveedor.Focus();
                            return;
                        }
                    }

                    string sqlInsert = @"
INSERT INTO proveedores
(
    nombre,
    contacto,
    telefono,
    email,
    direccion,
    rfc,
    estado
)
VALUES
(
    @nombre,
    @contacto,
    @telefono,
    @email,
    @direccion,
    @rfc,
    @estado
)";

                    using (var cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            txtProveedor.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@contacto",
                            txtContactoPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@telefono",
                            txtTelefonoPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@email",
                            txtCorreoPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@direccion",
                            txtDireccionPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@rfc",
                            txtRFCPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@estado",
                            cmbEstadoPro.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Proveedor guardado correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarProveedores();
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

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvProveedores.Rows[e.RowIndex];

            idProveedorSeleccionado =
                Convert.ToInt32(
                    fila.Cells["colIdProveedor"].Value);

            txtProveedor.Text =
                fila.Cells["colProveedor"].Value?.ToString() ?? "";

            txtContactoPro.Text =
                fila.Cells["colContacto"].Value?.ToString() ?? "";

            txtTelefonoPro.Text =
                fila.Cells["colTelefono"].Value?.ToString() ?? "";

            txtRFCPro.Text =
                fila.Cells["colRFC"].Value?.ToString() ?? "";

            cmbEstadoPro.Text =
                fila.Cells["colEstado"].Value?.ToString() ?? "ACTIVO";

            CargarDatosProveedorCompleto();

            btnGuardarProveedor.Enabled = false;
            btnEditarProveedor.Enabled = true;
            btnDesactivarProveedor.Enabled = true;

            btnDesactivarProveedor.Text =
                cmbEstadoPro.Text == "ACTIVO"
                ? "Desactivar"
                : "Activar";
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProveedorSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un proveedor.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string proveedor = txtProveedor.Text.Trim();

                if (proveedor == "")
                {
                    MessageBox.Show(
                        "Capture el nombre del proveedor.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtProveedor.Focus();
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sqlExiste = @"
SELECT COUNT(*)
FROM proveedores
WHERE nombre = @nombre
AND id_proveedor <> @id";

                    using (var cmdExiste = new MySqlCommand(sqlExiste, conn))
                    {
                        cmdExiste.Parameters.AddWithValue(
                            "@nombre",
                            proveedor);

                        cmdExiste.Parameters.AddWithValue(
                            "@id",
                            idProveedorSeleccionado);

                        int existe =
                            Convert.ToInt32(
                                cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "El proveedor ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtProveedor.Focus();
                            return;
                        }
                    }

                    string sqlUpdate = @"
UPDATE proveedores
SET
    nombre = @nombre,
    contacto = @contacto,
    telefono = @telefono,
    email = @email,
    direccion = @direccion,
    rfc = @rfc,
    estado = @estado
WHERE id_proveedor = @id";

                    using (var cmd = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            txtProveedor.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@contacto",
                            txtContactoPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@telefono",
                            txtTelefonoPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@email",
                            txtCorreoPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@direccion",
                            txtDireccionPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@rfc",
                            txtRFCPro.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@estado",
                            cmbEstadoPro.Text);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idProveedorSeleccionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Proveedor actualizado correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarProveedores();
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

        private void btnDesactivarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProveedorSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un proveedor.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string nuevoEstado =
                    cmbEstadoPro.Text == "ACTIVO"
                    ? "INACTIVO"
                    : "ACTIVO";

                string accion =
                    nuevoEstado == "ACTIVO"
                    ? "activar"
                    : "desactivar";

                DialogResult r = MessageBox.Show(
                    $"¿Desea {accion} el proveedor seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.No)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE proveedores
SET estado = @estado
WHERE id_proveedor = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@estado",
                            nuevoEstado);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idProveedorSeleccionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Estado actualizado correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarProveedores();
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

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            BuscarProveedores();
        }

        private void btnCerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
