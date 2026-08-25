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
    public partial class FrmUnidadesMedida : Form
    {

        private int idMedidaSeleccionada = 0;
        public FrmUnidadesMedida()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            idMedidaSeleccionada = 0;

            txtNombreMedida.Clear();
            txtAbreviatura.Clear();
            txtBuscarUnidad.Clear();

            btnGuardarUnidad.Enabled = true;
            btnEditarUnidad.Enabled = false;
            btnEliminarUnidad.Enabled = false;

            btnEliminarUnidad.Text = "Desactivar";

            dgvUnidades.ClearSelection();

            txtNombreMedida.Focus();
        }

        private void ActualizarContador()
        {
            lblTotalUnidades.Text =
                $"Total: {dgvUnidades.Rows.Count}";
        }

        private void CargarUnidades()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_medida,
    nombre_medida,
    abreviatura,
    activo
FROM unidades_medida
ORDER BY nombre_medida";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvUnidades.DataSource = dt;

                        ActualizarContador();
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

        private void BuscarUnidades()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_medida,
    nombre_medida,
    abreviatura,
    activo
FROM unidades_medida
WHERE nombre_medida LIKE @buscar
   OR abreviatura LIKE @buscar
ORDER BY nombre_medida";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@buscar",
                            "%" + txtBuscarUnidad.Text.Trim() + "%");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            dgvUnidades.DataSource = dt;

                            ActualizarContador();
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

        private void FrmUnidadesMedida_Load(object sender, EventArgs e)
        {
            dgvUnidades.AutoGenerateColumns = false;

            CargarUnidades();

            btnEditarUnidad.Enabled = false;
            btnEliminarUnidad.Enabled = false;

            LimpiarFormulario();
        }

        private void btnGuardarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreMedida.Text.Trim();
                string abreviatura = txtAbreviatura.Text.Trim();

                if (nombre == "")
                {
                    MessageBox.Show(
                        "Capture el nombre de la unidad.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombreMedida.Focus();
                    return;
                }

                if (abreviatura == "")
                {
                    MessageBox.Show(
                        "Capture la abreviatura.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAbreviatura.Focus();
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sqlNombre = @"
SELECT COUNT(*)
FROM unidades_medida
WHERE nombre_medida = @nombre";

                    using (var cmdNombre = new MySqlCommand(sqlNombre, conn))
                    {
                        cmdNombre.Parameters.AddWithValue("@nombre", nombre);

                        int existeNombre =
                            Convert.ToInt32(cmdNombre.ExecuteScalar());

                        if (existeNombre > 0)
                        {
                            MessageBox.Show(
                                "La unidad ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtNombreMedida.Focus();
                            return;
                        }
                    }

                    string sqlAbreviatura = @"
SELECT COUNT(*)
FROM unidades_medida
WHERE abreviatura = @abreviatura";

                    using (var cmdAbrev = new MySqlCommand(sqlAbreviatura, conn))
                    {
                        cmdAbrev.Parameters.AddWithValue(
                            "@abreviatura",
                            abreviatura);

                        int existeAbrev =
                            Convert.ToInt32(cmdAbrev.ExecuteScalar());

                        if (existeAbrev > 0)
                        {
                            MessageBox.Show(
                                "La abreviatura ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtAbreviatura.Focus();
                            return;
                        }
                    }

                    string sqlInsert = @"
INSERT INTO unidades_medida
(
    nombre_medida,
    abreviatura
)
VALUES
(
    @nombre,
    @abreviatura
)";

                    using (var cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@abreviatura", abreviatura);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Unidad guardada correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarUnidades();
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

        private void dgvUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvUnidades.Rows[e.RowIndex];

            idMedidaSeleccionada =
                Convert.ToInt32(
                    fila.Cells["colIdMedida"].Value);

            txtNombreMedida.Text =
                fila.Cells["colNombreMedida"].Value?.ToString() ?? "";

            txtAbreviatura.Text =
                fila.Cells["colAbreviatura"].Value?.ToString() ?? "";

            bool activo =
                Convert.ToBoolean(
                    fila.Cells["colActivo"].Value);

            btnGuardarUnidad.Enabled = false;
            btnEditarUnidad.Enabled = true;
            btnEliminarUnidad.Enabled = true;

            btnEliminarUnidad.Text =
                activo
                ? "Desactivar"
                : "Activar";
        }

        private void btnEditarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMedidaSeleccionada == 0)
                {
                    MessageBox.Show(
                        "Seleccione una unidad.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string nombre = txtNombreMedida.Text.Trim();
                string abreviatura = txtAbreviatura.Text.Trim();

                if (nombre == "")
                {
                    MessageBox.Show(
                        "Capture el nombre de la unidad.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombreMedida.Focus();
                    return;
                }

                if (abreviatura == "")
                {
                    MessageBox.Show(
                        "Capture la abreviatura.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAbreviatura.Focus();
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sqlNombre = @"
SELECT COUNT(*)
FROM unidades_medida
WHERE nombre_medida = @nombre
AND id_medida <> @id";

                    using (var cmdNombre = new MySqlCommand(sqlNombre, conn))
                    {
                        cmdNombre.Parameters.AddWithValue("@nombre", nombre);
                        cmdNombre.Parameters.AddWithValue("@id", idMedidaSeleccionada);

                        int existeNombre =
                            Convert.ToInt32(cmdNombre.ExecuteScalar());

                        if (existeNombre > 0)
                        {
                            MessageBox.Show(
                                "La unidad ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtNombreMedida.Focus();
                            return;
                        }
                    }

                    string sqlAbrev = @"
SELECT COUNT(*)
FROM unidades_medida
WHERE abreviatura = @abreviatura
AND id_medida <> @id";

                    using (var cmdAbrev = new MySqlCommand(sqlAbrev, conn))
                    {
                        cmdAbrev.Parameters.AddWithValue(
                            "@abreviatura",
                            abreviatura);

                        cmdAbrev.Parameters.AddWithValue(
                            "@id",
                            idMedidaSeleccionada);

                        int existeAbrev =
                            Convert.ToInt32(cmdAbrev.ExecuteScalar());

                        if (existeAbrev > 0)
                        {
                            MessageBox.Show(
                                "La abreviatura ya existe.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtAbreviatura.Focus();
                            return;
                        }
                    }

                    string sqlUpdate = @"
UPDATE unidades_medida
SET
    nombre_medida = @nombre,
    abreviatura = @abreviatura
WHERE id_medida = @id";

                    using (var cmd = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@abreviatura", abreviatura);
                        cmd.Parameters.AddWithValue("@id", idMedidaSeleccionada);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Unidad actualizada correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarUnidades();
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

        private void btnEliminarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMedidaSeleccionada == 0)
                {
                    MessageBox.Show(
                        "Seleccione una unidad.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool activar =
                    btnEliminarUnidad.Text == "Activar";

                string accion =
                    activar
                    ? "activar"
                    : "desactivar";

                DialogResult r = MessageBox.Show(
                    $"¿Desea {accion} la unidad seleccionada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.No)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE unidades_medida
SET activo = @activo
WHERE id_medida = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@activo",
                            activar ? 1 : 0);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idMedidaSeleccionada);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Estado actualizado correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarUnidades();
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

        private void dgvUnidades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUnidades.Columns[e.ColumnIndex].Name == "colActivo")
            {
                if (e.Value != null)
                {
                    bool activo = Convert.ToBoolean(e.Value);

                    e.Value = activo
                        ? "ACTIVO"
                        : "INACTIVO";

                    e.FormattingApplied = true;
                }
            }
        }

        private void btnNuevoUnidad_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtBuscarUnidad_TextChanged(object sender, EventArgs e)
        {
            BuscarUnidades();
        }

        private void btnCerrarUnidad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
