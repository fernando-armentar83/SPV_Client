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
    public partial class FrmAutorizacionStock : Form
    {
        public int IdUsuarioAutorizo { get; private set; }

        public FrmAutorizacionStock()
        {
            InitializeComponent();
        }

        // ============================================================================
        // LOAD
        // ============================================================================
        private void FrmAutorizacionStock_Load(object sender, EventArgs e)
        {
            CargarUsuariosAutorizados();
        }

        // ============================================================================
        // CARGAR USUARIOS AUTORIZADOS (ADMIN / SUPERVISOR)
        // ============================================================================
        private void CargarUsuariosAutorizados()
        {
            string sql = @"
                SELECT id_usuario, nombre
                FROM usuarios
                WHERE id_rol IN (1,2)
                  AND activo = 1
                ORDER BY nombre;
            ";

            try
            {
                using (var conn = DB.GetConnection())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    cboUsuarioAutoriza.DataSource = dt;
                    cboUsuarioAutoriza.DisplayMember = "nombre";
                    cboUsuarioAutoriza.ValueMember = "id_usuario";
                    cboUsuarioAutoriza.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar usuarios autorizados:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================================
        // AUTORIZAR
        // ============================================================================
        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (cboUsuarioAutoriza.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un usuario autorizador.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPasswordAuto.Text))
            {
                MessageBox.Show("Ingresa la contraseña.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Convert.ToInt32(cboUsuarioAutoriza.SelectedValue);
            string password = txtPasswordAuto.Text.Trim();

            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string contrasenaGuardada;

                    using (var cmd = new MySqlCommand(
                        "SELECT contrasena FROM usuarios WHERE id_usuario = @id AND activo = 1;", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idUsuario);

                        object resultado = cmd.ExecuteScalar();

                        contrasenaGuardada = (resultado == null || resultado == DBNull.Value)
                            ? null
                            : resultado.ToString();
                    }

                    bool valido = false;

                    if (contrasenaGuardada != null)
                    {
                        if (contrasenaGuardada.StartsWith("$2"))
                        {
                            valido = BCrypt.Net.BCrypt.Verify(password, contrasenaGuardada);
                        }
                        else
                        {
                            valido = contrasenaGuardada == password;

                            if (valido)
                            {
                                using (var cmdMigrar = new MySqlCommand(
                                    "UPDATE usuarios SET contrasena = @hash WHERE id_usuario = @id;", conn))
                                {
                                    cmdMigrar.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(password));
                                    cmdMigrar.Parameters.AddWithValue("@id", idUsuario);
                                    cmdMigrar.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    if (valido)
                    {
                        IdUsuarioAutorizo = idUsuario;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.",
                            "Acceso denegado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        txtPasswordAuto.Clear();
                        txtPasswordAuto.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al validar autorización:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================================
        // CANCELAR
        // ============================================================================
        private void btnCancelarStk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
