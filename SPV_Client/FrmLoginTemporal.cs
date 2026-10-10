using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SPV_Client
{
    public partial class FrmLoginTemporal : Form
    {
        private readonly string _modulo;

        

        public FrmLoginTemporal(string modulo)
        {
            InitializeComponent();
            _modulo = modulo;
        }

        // Asegúrate de que en el diseñador el evento Load esté asignado a este método,
        // o elimina la suscripción en el Designer si no lo usas.
        private void FrmLoginTemporal_Load(object sender, EventArgs e)
        {
            // lblModulo debe existir en el diseñador con exactamente ese Name
            if (lblModulo != null) lblModulo.Text = $"Autoriza: {_modulo}";
        }

        // Este método debe estar asignado al Click del botón autorizar (btnAutorizarT)
        private void btnAutorizarT_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioT.Text.Trim();
            string contraseña = txtPasswordT.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var cn = DB.GetConnection())
                {
                    cn.Open();

                    string sql = @"SELECT u.id_usuario, u.nombre, u.id_rol, u.contrasena
FROM usuarios u
INNER JOIN roles r ON u.id_rol = r.id_rol
WHERE u.nombre = @usuario AND u.activo = 1
LIMIT 1;";

                    int idUsuario;
                    string nombreUsuario;
                    int idRol;
                    string contrasenaGuardada;

                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Credenciales incorrectas o usuario inactivo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            idUsuario = Convert.ToInt32(reader["id_usuario"]);
                            nombreUsuario = reader["nombre"].ToString();
                            idRol = reader["id_rol"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id_rol"]);
                            contrasenaGuardada = reader["contrasena"].ToString();
                        }
                    }

                    bool contrasenaValida;

                    if (contrasenaGuardada.StartsWith("$2"))
                    {
                        contrasenaValida = BCrypt.Net.BCrypt.Verify(contraseña, contrasenaGuardada);
                    }
                    else
                    {
                        contrasenaValida = contrasenaGuardada == contraseña;

                        if (contrasenaValida)
                        {
                            using (var cmdMigrar = new MySqlCommand(
                                "UPDATE usuarios SET contrasena = @hash WHERE id_usuario = @id;", cn))
                            {
                                cmdMigrar.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(contraseña));
                                cmdMigrar.Parameters.AddWithValue("@id", idUsuario);
                                cmdMigrar.ExecuteNonQuery();
                            }
                        }
                    }

                    if (!contrasenaValida)
                    {
                        MessageBox.Show("Credenciales incorrectas o usuario inactivo.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Acciones que SOLO puede autorizar un Administrador
                    if (_modulo == "Catálogo" ||
                        _modulo == "Editar producto")
                    {
                        if (idRol != 1)
                        {
                            MessageBox.Show(
                                "Esta acción solo puede ser autorizada por un Administrador.",
                                "Acceso denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        // El resto de acciones pueden ser autorizadas por Administrador o Supervisor
                        if (idRol != 1 && idRol != 2)
                        {
                            MessageBox.Show(
                                "El usuario no tiene permisos para autorizar esta acción.",
                                "Acceso denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Autorización concedida
                    Session.IdUsuarioAutoriza = idUsuario;
                    Session.NombreUsuarioAutoriza = nombreUsuario;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Este método debe estar asignado al Click del botón cancelar (btnCancelarT)
        private void btnCancelarT_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}