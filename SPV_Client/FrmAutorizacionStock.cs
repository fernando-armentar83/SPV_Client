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
            string password = txtPasswordAuto.Text.Trim().Normalize();


            try
            {
                using (var conn = DB.GetConnection())
                using (var cmd = new MySqlCommand(@"
                    SELECT COUNT(*)
                    FROM usuarios
                    WHERE id_usuario = @id
                      AND contrasena = @pass
                      AND activo = 1
                ", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    cmd.Parameters.AddWithValue("@pass", password);

                    conn.Open();
                    int valido = Convert.ToInt32(cmd.ExecuteScalar());

                    if (valido == 1)
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
