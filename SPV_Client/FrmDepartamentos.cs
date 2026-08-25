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
    public partial class FrmDepartamentos : Form
    {
        private int idDepartamentoSeleccionado = 0;
        private int _idDepartamento = 0;
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            dgvDepartamentos.AutoGenerateColumns = false;

            CargarDepartamentos();

            LimpiarFormulario();

        }

        private void LimpiarFormulario()
        {
            _idDepartamento = 0;

            txtDepartamento.Clear();

            chkActivo.Checked = true;

            btnGuardarDepto.Enabled = true;
            btnEditarDepto.Enabled = false;
            btnDesactivarDepto.Enabled = false;
            btnDesactivarDepto.Text = "Desactivar";

            txtDepartamento.Focus();
        }
        private void CargarDepartamentos()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
            SELECT
                id_departamento,
                nombre,
                activo
            FROM departamentos
            ORDER BY nombre";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvDepartamentos.DataSource = dt;

                        this.Text =
    $"Catálogo de Departamentos ({dt.Rows.Count})";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FiltrarDepartamentos()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_departamento,
    nombre,
    activo
FROM departamentos
WHERE nombre LIKE @buscar
ORDER BY nombre";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@buscar",
                            "%" + txtBuscarDepto.Text.Trim() + "%"
                        );

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            dgvDepartamentos.DataSource = dt;

                            this.Text =
                                $"Catálogo de Departamentos ({dt.Rows.Count})";
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
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnGuardarDepto_Click(object sender, EventArgs e)
        {
            string nombre = txtDepartamento.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Capture el nombre del departamento.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtDepartamento.Focus();
                return;
            }

            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sqlExiste = @"
SELECT COUNT(*)
FROM departamentos
WHERE nombre = @nombre";

                    using (var cmdExiste = new MySqlCommand(sqlExiste, conn))
                    {
                        cmdExiste.Parameters.AddWithValue("@nombre", nombre);

                        int existe = Convert.ToInt32(cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "Ese departamento ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            return;
                        }
                    }

                    string sqlInsert = @"
INSERT INTO departamentos
(
    nombre,
    activo
)
VALUES
(
    @nombre,
    @activo
)";

                    using (var cmdInsert = new MySqlCommand(sqlInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@nombre", nombre);
                        cmdInsert.Parameters.AddWithValue("@activo", chkActivo.Checked);

                        cmdInsert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Departamento guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtDepartamento.Clear();
                chkActivo.Checked = true;

                CargarDepartamentos();

                txtDepartamento.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvDepartamentos.Rows[e.RowIndex];

            _idDepartamento =
                Convert.ToInt32(
                    fila.Cells["colIdDepartamento"].Value
                );

            txtDepartamento.Text =
                fila.Cells["colDepartamento"].Value.ToString();

            chkActivo.Checked =
                Convert.ToBoolean(
                    fila.Cells["colActivo"].Value
                );

            btnEditarDepto.Enabled = true;
            btnDesactivarDepto.Enabled = true;
            btnGuardarDepto.Enabled = false;

            if (chkActivo.Checked)
            {
                btnDesactivarDepto.Text = "Desactivar";
            }
            else
            {
                btnDesactivarDepto.Text = "Activar";
            }
        }

        private void btnEditarDepto_Click(object sender, EventArgs e)
        {
            if (_idDepartamento == 0)
            {
                MessageBox.Show(
                    "Seleccione un departamento.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string nombre = txtDepartamento.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Capture el nombre del departamento.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDepartamento.Focus();
                return;
            }

            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sqlExiste = @"
SELECT COUNT(*)
FROM departamentos
WHERE nombre = @nombre
AND id_departamento <> @id";

                    using (var cmdExiste = new MySqlCommand(sqlExiste, conn))
                    {
                        cmdExiste.Parameters.AddWithValue("@nombre", nombre);
                        cmdExiste.Parameters.AddWithValue("@id", _idDepartamento);

                        int existe =
                            Convert.ToInt32(cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "Ya existe otro departamento con ese nombre.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            return;
                        }
                    }

                    string sql = @"
UPDATE departamentos
SET
    nombre = @nombre,
    activo = @activo
WHERE id_departamento = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@activo", chkActivo.Checked);
                        cmd.Parameters.AddWithValue("@id", _idDepartamento);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Departamento actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarDepartamentos();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnNuevoDepto_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnDesactivarDepto_Click(object sender, EventArgs e)
        {
            if (_idDepartamento == 0)
            {
                MessageBox.Show(
                    "Seleccione un departamento.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string accion = chkActivo.Checked
                ? "desactivar"
                : "activar";

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea {accion} este departamento?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE departamentos
SET activo = @activo
WHERE id_departamento = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@activo",
                            !chkActivo.Checked
                        );

                        cmd.Parameters.AddWithValue(
                            "@id",
                            _idDepartamento
                        );

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    $"Departamento {accion}do correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarDepartamentos();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCerrarDepto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarDepto_TextChanged(object sender, EventArgs e)
        {
            FiltrarDepartamentos();
        }
    }
}
