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
    public partial class FrmUsuarios : Form
    {
        private static readonly int[] IdsUsuariosProtegidos = { 1 };

        private int idUsuarioSeleccionado = 0;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarUsuarios();
            LimpiarFormulario();
        }

        private void CargarRoles()
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();

                string sql = "SELECT id_rol, nombre_rol FROM roles ORDER BY nombre_rol;";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbRol.DataSource = dt;
                    cmbRol.DisplayMember = "nombre_rol";
                    cmbRol.ValueMember = "id_rol";
                }
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    u.id_usuario,
    u.nombre,
    r.nombre_rol AS rol,
    CASE WHEN u.activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS activo
FROM usuarios u
INNER JOIN roles r ON u.id_rol = r.id_rol
ORDER BY u.nombre;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUsuarios.DataSource = dt;
                        lblTotalUsuarios.Text = $"Usuarios : {dgvUsuarios.Rows.Count}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtBuscarUsuario.Clear();
            idUsuarioSeleccionado = 0;
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            chkActivoUsuario.Checked = true;

            if (cmbRol.Items.Count > 0)
                cmbRol.SelectedIndex = 0;

            btnGuardarUsuario.Enabled = true;
            btnEditarUsuario.Enabled = false;
            btnDesactivarUsuario.Enabled = false;
            btnDesactivarUsuario.Text = "Desactivar";

            dgvUsuarios.ClearSelection();
            txtNombreUsuario.Focus();
        }

        private bool EsUsuarioProtegido(int idUsuario)
        {
            return Array.IndexOf(IdsUsuariosProtegidos, idUsuario) >= 0;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreUsuario.Text.Trim();
                string contrasena = txtContraseña.Text;

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Ingrese el nombre del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreUsuario.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Ingrese una contraseña para el nuevo usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                    return;
                }

                int idRolSeleccionado = Convert.ToInt32(cmbRol.SelectedValue);

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string validar = "SELECT COUNT(*) FROM usuarios WHERE nombre = @nombre;";
                    using (var cmdValidar = new MySqlCommand(validar, conn))
                    {
                        cmdValidar.Parameters.AddWithValue("@nombre", nombre);
                        int existe = Convert.ToInt32(cmdValidar.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("Ya existe un usuario con ese nombre.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNombreUsuario.Focus();
                            return;
                        }
                    }

                    string hash = BCrypt.Net.BCrypt.HashPassword(contrasena);

                    string sql = @"
INSERT INTO usuarios (nombre, contrasena, id_rol, activo)
VALUES (@nombre, @contrasena, @id_rol, @activo);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@contrasena", hash);
                        cmd.Parameters.AddWithValue("@id_rol", idRolSeleccionado);
                        cmd.Parameters.AddWithValue("@activo", chkActivoUsuario.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["colIdUsuario"].Value);

                txtNombreUsuario.Text = fila.Cells["colNombreUsuario"].Value.ToString();
                txtContraseña.Clear();

                bool activo = fila.Cells["colActivoUsuario"].Value.ToString() == "Activo";
                chkActivoUsuario.Checked = activo;

                string nombreRolFila = fila.Cells["colRolUsuario"].Value.ToString();
                cmbRol.SelectedValue = ObtenerIdRolPorNombre(nombreRolFila);

                btnGuardarUsuario.Enabled = false;
                btnEditarUsuario.Enabled = true;

                bool protegido = EsUsuarioProtegido(idUsuarioSeleccionado);
                btnDesactivarUsuario.Enabled = !protegido;
                btnDesactivarUsuario.Text = activo ? "Desactivar" : "Activar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdRolPorNombre(string nombreRol)
        {
            DataTable dt = (DataTable)cmbRol.DataSource;

            foreach (DataRow row in dt.Rows)
            {
                if (row["nombre_rol"].ToString() == nombreRol)
                    return Convert.ToInt32(row["id_rol"]);
            }

            return 0;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUsuarioSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombreUsuario.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Ingrese el nombre del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreUsuario.Focus();
                    return;
                }

                int idRolSeleccionado = Convert.ToInt32(cmbRol.SelectedValue);

                if (EsUsuarioProtegido(idUsuarioSeleccionado) && idRolSeleccionado != 1)
                {
                    MessageBox.Show(
                        "Este usuario no puede cambiar de rol.",
                        "Acción no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string validar = "SELECT COUNT(*) FROM usuarios WHERE nombre = @nombre AND id_usuario <> @id;";
                    using (var cmdValidar = new MySqlCommand(validar, conn))
                    {
                        cmdValidar.Parameters.AddWithValue("@nombre", nombre);
                        cmdValidar.Parameters.AddWithValue("@id", idUsuarioSeleccionado);
                        int existe = Convert.ToInt32(cmdValidar.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("Ya existe un usuario con ese nombre.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNombreUsuario.Focus();
                            return;
                        }
                    }

                    string contrasenaNueva = txtContraseña.Text;

                    string sql;
                    if (string.IsNullOrWhiteSpace(contrasenaNueva))
                    {
                        sql = @"
UPDATE usuarios
SET nombre = @nombre, id_rol = @id_rol, activo = @activo
WHERE id_usuario = @id;";
                    }
                    else
                    {
                        sql = @"
UPDATE usuarios
SET nombre = @nombre, id_rol = @id_rol, activo = @activo, contrasena = @contrasena
WHERE id_usuario = @id;";
                    }

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@id_rol", idRolSeleccionado);
                        cmd.Parameters.AddWithValue("@activo", chkActivoUsuario.Checked);
                        cmd.Parameters.AddWithValue("@id", idUsuarioSeleccionado);

                        if (!string.IsNullOrWhiteSpace(contrasenaNueva))
                            cmd.Parameters.AddWithValue("@contrasena", BCrypt.Net.BCrypt.HashPassword(contrasenaNueva));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUsuarioSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EsUsuarioProtegido(idUsuarioSeleccionado))
                {
                    MessageBox.Show(
                        "Este usuario no puede desactivarse.",
                        "Acción no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                bool nuevoEstado = !chkActivoUsuario.Checked;

                string mensaje = nuevoEstado ? "¿Desea activar este usuario?" : "¿Desea desactivar este usuario?";

                if (MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = "UPDATE usuarios SET activo = @activo WHERE id_usuario = @id;";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@activo", nuevoEstado);
                        cmd.Parameters.AddWithValue("@id", idUsuarioSeleccionado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    nuevoEstado ? "Usuario activado correctamente." : "Usuario desactivado correctamente.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    u.id_usuario,
    u.nombre,
    r.nombre_rol AS rol,
    CASE WHEN u.activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS activo
FROM usuarios u
INNER JOIN roles r ON u.id_rol = r.id_rol
WHERE u.nombre LIKE @buscar
ORDER BY u.nombre;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@buscar", "%" + txtBuscarUsuario.Text.Trim() + "%");

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvUsuarios.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
