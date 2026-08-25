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
    public partial class FrmSocios : Form
    {

        private int idSocioSeleccionado = 0;
        public FrmSocios()
        {
            InitializeComponent();
        }

        private void CargarSocios()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_socio,
    nombre_socio,
    CASE
        WHEN activo = 1 THEN 'Activo'
        ELSE 'Inactivo'
    END AS activo
FROM socios
ORDER BY nombre_socio";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvSocios.DataSource = dt;

                        ActualizarContadorSocios();
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

        private void FrmSocios_Load(object sender, EventArgs e)
        {
            CargarSocios();

            chkActivoSocio.Checked = true;

            btnEditarSocio.Enabled = false;
            btnDesactivarSocio.Enabled = false;
        }

        private void ActualizarContadorSocios()
        {
            lblTotalSocios.Text =
                $"Socios :  {dgvSocios.Rows.Count}";
        }

        private void LimpiarFormulario()
        {
            idSocioSeleccionado = 0;

            txtSocio.Clear();

            chkActivoSocio.Checked = true;

            btnGuardarSocio.Enabled = true;
            btnEditarSocio.Enabled = false;
            btnDesactivarSocio.Enabled = false;

            btnDesactivarSocio.Text = "Desactivar";

            dgvSocios.ClearSelection();

            txtSocio.Focus();
        }

        private void btnGuardarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreSocio = txtSocio.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombreSocio))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del socio.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtSocio.Focus();
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string validar = @"
SELECT COUNT(*)
FROM socios
WHERE nombre_socio = @nombre";

                    using (var cmdValidar = new MySqlCommand(validar, conn))
                    {
                        cmdValidar.Parameters.AddWithValue("@nombre", nombreSocio);

                        int existe = Convert.ToInt32(cmdValidar.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "Ya existe un socio con ese nombre.",
                                "Duplicado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtSocio.Focus();
                            return;
                        }
                    }

                    string sql = @"
INSERT INTO socios
(
    nombre_socio,
    activo
)
VALUES
(
    @nombre,
    @activo
)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreSocio);
                        cmd.Parameters.AddWithValue("@activo", chkActivoSocio.Checked);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Socio guardado correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarSocios();
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

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila = dgvSocios.Rows[e.RowIndex];

                idSocioSeleccionado = Convert.ToInt32(
                    fila.Cells["colIdSocio"].Value);

                txtSocio.Text =
                    fila.Cells["colSocio"].Value.ToString();

                chkActivoSocio.Checked =
                    fila.Cells["colActivo"].Value.ToString() == "Activo";

                btnGuardarSocio.Enabled = false;

                btnEditarSocio.Enabled = true;

                btnDesactivarSocio.Enabled = true;

                if (chkActivoSocio.Checked)
                    btnDesactivarSocio.Text = "Desactivar";
                else
                    btnDesactivarSocio.Text = "Activar";
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

        private void btnEditarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSocioSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un socio.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string nombreSocio = txtSocio.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombreSocio))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del socio.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtSocio.Focus();
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string validar = @"
SELECT COUNT(*)
FROM socios
WHERE nombre_socio = @nombre
AND id_socio <> @id";

                    using (var cmdValidar = new MySqlCommand(validar, conn))
                    {
                        cmdValidar.Parameters.AddWithValue("@nombre", nombreSocio);
                        cmdValidar.Parameters.AddWithValue("@id", idSocioSeleccionado);

                        int existe = Convert.ToInt32(cmdValidar.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "Ya existe un socio con ese nombre.",
                                "Duplicado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtSocio.Focus();
                            return;
                        }
                    }

                    string sql = @"
UPDATE socios
SET
    nombre_socio = @nombre,
    activo = @activo
WHERE id_socio = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreSocio);
                        cmd.Parameters.AddWithValue("@activo", chkActivoSocio.Checked);
                        cmd.Parameters.AddWithValue("@id", idSocioSeleccionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Socio actualizado correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarSocios();
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

        private void btnDesactivarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSocioSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un socio.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                bool nuevoEstado = !chkActivoSocio.Checked;

                string mensaje = nuevoEstado
                    ? "¿Desea activar este socio?"
                    : "¿Desea desactivar este socio?";

                DialogResult resultado = MessageBox.Show(
                    mensaje,
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado != DialogResult.Yes)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE socios
SET activo = @activo
WHERE id_socio = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@activo", nuevoEstado);
                        cmd.Parameters.AddWithValue("@id", idSocioSeleccionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    nuevoEstado
                        ? "Socio activado correctamente."
                        : "Socio desactivado correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarSocios();
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

        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtBuscarSocio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_socio,
    nombre_socio,
    CASE
        WHEN activo = 1 THEN 'Activo'
        ELSE 'Inactivo'
    END AS activo
FROM socios
WHERE nombre_socio LIKE @buscar
ORDER BY nombre_socio";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@buscar",
                            "%" + txtBuscarSocio.Text.Trim() + "%");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            dgvSocios.DataSource = dt;
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

        private void btnCerrarSocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
