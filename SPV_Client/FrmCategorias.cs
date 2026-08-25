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
    public partial class FrmCategorias : Form
    {

        private int idCategoriaSeleccionada = 0;
        public FrmCategorias()
        {
            InitializeComponent();
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
    nombre
FROM departamentos
WHERE activo = 1
ORDER BY nombre";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        cmbDepartamento.DataSource = dt;
                        cmbDepartamento.DisplayMember = "nombre";
                        cmbDepartamento.ValueMember = "id_departamento";
                        cmbDepartamento.SelectedIndex = -1;
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

        private void CargarCategorias()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
    c.id_categoria,
    c.id_departamento,
    d.nombre AS departamento,
    c.nombre AS categoria,
    c.activo
FROM categorias c
INNER JOIN departamentos d
    ON c.id_departamento = d.id_departamento
ORDER BY d.nombre, c.nombre";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dgvCategorias.DataSource = dt;
                        ActualizarContadorCategorias();
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

        private void BuscarCategorias()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    c.id_categoria,
    c.id_departamento,
    d.nombre AS departamento,
    c.nombre AS categoria,
    c.activo
FROM categorias c
INNER JOIN departamentos d
    ON c.id_departamento = d.id_departamento
WHERE
    c.nombre LIKE @buscar
    OR d.nombre LIKE @buscar
ORDER BY d.nombre, c.nombre";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@buscar",
                            "%" + txtBuscarCategoria.Text.Trim() + "%");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            dgvCategorias.DataSource = dt;

                            ActualizarContadorCategorias();
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

        private void ActualizarContadorCategorias()
        {
            lblTotalCategorias.Text =
                $"Total: {dgvCategorias.Rows.Count}";
        }

        private void LimpiarFormulario()
        {
            idCategoriaSeleccionada = 0;

            cmbDepartamento.SelectedIndex = -1;

            txtCategoria.Clear();

            chkActivo.Checked = true;

            btnGuardarCategoria.Enabled = true;
            btnEditarCategoria.Enabled = false;
            btnDesactivarCategoria.Enabled = false;

            btnDesactivarCategoria.Text = "Desactivar";

            dgvCategorias.ClearSelection();


            txtCategoria.Focus();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            dgvCategorias.AutoGenerateColumns = false;

            CargarDepartamentos();

            CargarCategorias();

            chkActivo.Checked = true;

            btnEditarCategoria.Enabled = false;
            btnDesactivarCategoria.Enabled = false;
        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartamento.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un departamento.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbDepartamento.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show(
                        "Capture la categoría.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCategoria.Focus();
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Guardar categoría?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r != DialogResult.Yes)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    string sqlExiste = @"
SELECT COUNT(*)
FROM categorias
WHERE id_departamento = @id_departamento
AND nombre = @nombre";

                    using (var cmdExiste = new MySqlCommand(sqlExiste, conn))
                    {
                        cmdExiste.Parameters.AddWithValue(
                            "@id_departamento",
                            cmbDepartamento.SelectedValue);

                        cmdExiste.Parameters.AddWithValue(
                            "@nombre",
                            txtCategoria.Text.Trim());

                        int existe = Convert.ToInt32(cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "La categoría ya existe en este departamento.",
                                "Duplicado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtCategoria.Focus();
                            return;
                        }
                    }

                    string sql = @"
INSERT INTO categorias
(
    id_departamento,
    nombre,
    activo
)
VALUES
(
    @id_departamento,
    @nombre,
    @activo
)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id_departamento",
                            cmbDepartamento.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            txtCategoria.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@activo",
                            chkActivo.Checked);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Categoría guardada correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarCategorias();
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

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

                idCategoriaSeleccionada =
                    Convert.ToInt32(fila.Cells["colIdCategoria"].Value);

                cmbDepartamento.SelectedValue =
                    Convert.ToInt32(fila.Cells["colIdDepartamento"].Value);

                txtCategoria.Text =
                    fila.Cells["colCategoria"].Value.ToString();

                chkActivo.Checked =
                    Convert.ToBoolean(fila.Cells["colActivo"].Value);

                btnDesactivarCategoria.Text =
    chkActivo.Checked
        ? "Desactivar"
        : "Activar";

                btnEditarCategoria.Enabled = true;
                btnDesactivarCategoria.Enabled = true;
                btnGuardarCategoria.Enabled = false;
            }
            catch
            {
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCategoriaSeleccionada == 0)
                {
                    MessageBox.Show(
                        "Seleccione una categoría.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (cmbDepartamento.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un departamento.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbDepartamento.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show(
                        "Capture la categoría.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCategoria.Focus();
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "¿Guardar cambios?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r != DialogResult.Yes)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    string sqlExiste = @"
SELECT COUNT(*)
FROM categorias
WHERE id_departamento = @id_departamento
AND nombre = @nombre
AND id_categoria <> @id_categoria";

                    using (var cmdExiste = new MySqlCommand(sqlExiste, conn))
                    {
                        cmdExiste.Parameters.AddWithValue(
                            "@id_departamento",
                            cmbDepartamento.SelectedValue);

                        cmdExiste.Parameters.AddWithValue(
                            "@nombre",
                            txtCategoria.Text.Trim());

                        cmdExiste.Parameters.AddWithValue(
                            "@id_categoria",
                            idCategoriaSeleccionada);

                        int existe = Convert.ToInt32(cmdExiste.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "La categoría ya existe en este departamento.",
                                "Duplicado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtCategoria.Focus();
                            return;
                        }
                    }

                    string sql = @"
UPDATE categorias
SET
    id_departamento = @id_departamento,
    nombre = @nombre,
    activo = @activo
WHERE id_categoria = @id_categoria";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id_departamento",
                            cmbDepartamento.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            txtCategoria.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@activo",
                            chkActivo.Checked);

                        cmd.Parameters.AddWithValue(
                            "@id_categoria",
                            idCategoriaSeleccionada);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Categoría actualizada correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarCategorias();
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

        private void btnDesactivarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCategoriaSeleccionada == 0)
                {
                    MessageBox.Show(
                        "Seleccione una categoría.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool nuevoEstado = !chkActivo.Checked;

                string accion = nuevoEstado
                    ? "activar"
                    : "desactivar";

                DialogResult r = MessageBox.Show(
                    $"¿Desea {accion} esta categoría?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r != DialogResult.Yes)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE categorias
SET activo = @activo
WHERE id_categoria = @id_categoria";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@activo",
                            nuevoEstado);

                        cmd.Parameters.AddWithValue(
                            "@id_categoria",
                            idCategoriaSeleccionada);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    $"Categoría {(nuevoEstado ? "activada" : "desactivada")} correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                CargarCategorias();
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

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            BuscarCategorias();
        }

        private void btnCerrarCategoria_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
        "¿Desea cerrar el catálogo de categorías?",
        "Confirmar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
