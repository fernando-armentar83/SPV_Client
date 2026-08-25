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
    public partial class FrmMarcas : Form
    {
        private int idMarcaSeleccionada = 0;

        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            dgvMarcas.AutoGenerateColumns = false;

            CargarMarcas();

            btnEditarMarca.Enabled = false;
            btnDesactivarMarca.Enabled = false;

            chkActivo.Checked = true;

            LimpiarFormulario();
        }

        private void CargarMarcas()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_marca,
    nombre_marca,
    activo
FROM marcas
ORDER BY nombre_marca";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvMarcas.DataSource = dt;
                        ActualizarContadorMarcas();
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

        private void BuscarMarcas()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_marca,
    nombre_marca,
    activo
FROM marcas
WHERE nombre_marca LIKE @buscar
ORDER BY nombre_marca";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@buscar",
                            "%" + txtBuscarMarca.Text.Trim() + "%");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            dgvMarcas.DataSource = dt;

                            ActualizarContadorMarcas();
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

        private void ActualizarContadorMarcas()
        {
            lblTotalMarcas.Text =
                $"Total: {dgvMarcas.Rows.Count}";
        }

        private void LimpiarFormulario()
        {
            idMarcaSeleccionada = 0;

            txtMarca.Clear();
            txtBuscarMarca.Clear();

            chkActivo.Checked = true;

            btnGuardarMarca.Enabled = true;
            btnEditarMarca.Enabled = false;
            btnDesactivarMarca.Enabled = false;

            btnDesactivarMarca.Text = "Desactivar";

            dgvMarcas.ClearSelection();

            txtMarca.Focus();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                string marca = txtMarca.Text.Trim();

                if (marca == "")
                {
                    MessageBox.Show(
                        "Capture una marca.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMarca.Focus();
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sqlExiste = @"
SELECT COUNT(*)
FROM marcas
WHERE nombre_marca = @nombre";

                    using (var cmdExiste = new MySqlCommand(sqlExiste, conn))
                    {
                        cmdExiste.Parameters.AddWithValue(
                            "@nombre",
                            marca);

                        int existe =
                            Convert.ToInt32(
                                cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "La marca ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtMarca.Focus();
                            return;
                        }
                    }

                    string sqlInsert = @"
INSERT INTO marcas
(
    nombre_marca,
    activo
)
VALUES
(
    @nombre_marca,
    @activo
)";

                    using (var cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre_marca",
                            marca);

                        cmd.Parameters.AddWithValue(
                            "@activo",
                            chkActivo.Checked);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Marca guardada correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarMarcas();
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

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvMarcas.Rows[e.RowIndex];

            idMarcaSeleccionada =
                Convert.ToInt32(
                    fila.Cells["colIdMarca"].Value);

            txtMarca.Text =
                fila.Cells["colMarca"].Value.ToString();

            chkActivo.Checked =
                Convert.ToBoolean(
                    fila.Cells["colActivo"].Value);

            btnGuardarMarca.Enabled = false;
            btnEditarMarca.Enabled = true;
            btnDesactivarMarca.Enabled = true;

            btnDesactivarMarca.Text =
                chkActivo.Checked
                    ? "Desactivar"
                    : "Activar";
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMarcaSeleccionada == 0)
                {
                    MessageBox.Show(
                        "Seleccione una marca.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string marca = txtMarca.Text.Trim();

                if (marca == "")
                {
                    MessageBox.Show(
                        "Capture una marca.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMarca.Focus();
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sqlExiste = @"
SELECT COUNT(*)
FROM marcas
WHERE nombre_marca = @nombre
AND id_marca <> @id";

                    using (var cmdExiste = new MySqlCommand(sqlExiste, conn))
                    {
                        cmdExiste.Parameters.AddWithValue(
                            "@nombre",
                            marca);

                        cmdExiste.Parameters.AddWithValue(
                            "@id",
                            idMarcaSeleccionada);

                        int existe =
                            Convert.ToInt32(
                                cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "La marca ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtMarca.Focus();
                            return;
                        }
                    }

                    string sqlUpdate = @"
UPDATE marcas
SET
    nombre_marca = @nombre,
    activo = @activo
WHERE id_marca = @id";

                    using (var cmd = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            marca);

                        cmd.Parameters.AddWithValue(
                            "@activo",
                            chkActivo.Checked);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idMarcaSeleccionada);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Marca actualizada correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarMarcas();
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

        private void btnDesactivarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMarcaSeleccionada == 0)
                {
                    MessageBox.Show(
                        "Seleccione una marca.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool nuevoEstado = !chkActivo.Checked;

                string accion =
                    nuevoEstado
                    ? "activar"
                    : "desactivar";

                DialogResult r = MessageBox.Show(
                    $"¿Desea {accion} la marca seleccionada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.No)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE marcas
SET activo = @activo
WHERE id_marca = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@activo",
                            nuevoEstado);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idMarcaSeleccionada);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Registro actualizado correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarMarcas();
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

        private void btnNuevoMarca_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtBuscarMarca_TextChanged(object sender, EventArgs e)
        {
            BuscarMarcas();
        }

        private void btnCerrarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
