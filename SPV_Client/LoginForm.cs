using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 📌 Librería para MySQL
using MySql.Data.MySqlClient;

namespace SPV_Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Opcional
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (usuario == "" || password == "")
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;database=spv_tlapaleria;uid=fer;pwd=129112;"))
                {
                    conexion.Open();

                    // ==============================
                    // 1) VALIDAR LOGIN
                    // ==============================
                    string query = @"SELECT u.id_usuario, u.nombre, u.id_rol, r.nombre_rol
                                     FROM usuarios u
                                     INNER JOIN roles r ON u.id_rol = r.id_rol
                                     WHERE u.nombre = @usuario 
                                     AND u.contrasena = @password 
                                     AND u.activo = 1";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", password);

                    int idUsuario = 0;
                    string nombreUsuario = "";
                    int idRol = 0;
                    string nombreRol = "";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idUsuario = Convert.ToInt32(reader["id_usuario"]);
                            nombreUsuario = reader["nombre"].ToString();
                            idRol = Convert.ToInt32(reader["id_rol"]);
                            nombreRol = reader["nombre_rol"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos o inactivo.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Guardar session
                    Session.IdUsuario = idUsuario;
                    Session.NombreUsuario = nombreUsuario;
                    Session.IdRol = idRol;
                    Session.NombreRol = nombreRol;

                    // ==============================
                    // 2) BUSCAR TURNO ABIERTO
                    // ==============================
                    string checkTurno = @"SELECT id_turno, monto_inicial 
                                          FROM cajas_turnos 
                                          WHERE id_usuario = @idUsuario 
                                          AND fecha_cierre IS NULL
                                          LIMIT 1;";

                    MySqlCommand checkCmd = new MySqlCommand(checkTurno, conexion);
                    checkCmd.Parameters.AddWithValue("@idUsuario", Session.IdUsuario);

                    Session.IdTurno = 0;
                    Session.MontoInicial = 0;

                    using (MySqlDataReader turnoReader = checkCmd.ExecuteReader())
                    {
                        if (turnoReader.Read())
                        {
                            Session.IdTurno = Convert.ToInt32(turnoReader["id_turno"]);
                            Session.MontoInicial = Convert.ToDecimal(turnoReader["monto_inicial"]);
                        }
                    }

                    // ==============================
                    // 3) SI NO EXISTE → CREARLO
                    // ==============================
                    if (Session.IdTurno == 0)
                    {
                        string insertTurno = @"INSERT INTO cajas_turnos 
                            (id_usuario, fecha_apertura, monto_inicial) 
                            VALUES (@idUsuario, NOW(), 0);";

                        MySqlCommand insertCmd = new MySqlCommand(insertTurno, conexion);
                        insertCmd.Parameters.AddWithValue("@idUsuario", Session.IdUsuario);
                        insertCmd.ExecuteNonQuery();

                        MySqlCommand getIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conexion);
                        Session.IdTurno = Convert.ToInt32(getIdCmd.ExecuteScalar());

                        Session.MontoInicial = 0;
                    }

                    // ==============================
                    // 4) MENSAJE FINAL
                    // ==============================
                    MessageBox.Show(
                        $"Bienvenido {Session.NombreUsuario} ({Session.NombreRol})\n\n" +
                        $"Turno #{Session.IdTurno} activo.\n\n" +
                        $"Monto inicial: {Session.MontoInicial:C2}",
                        "Acceso concedido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // ==============================
                    // 5) ABRIR MÓDULO VENTAS |||| ya no abre modulo de ventas se modificó.
                    // ==============================
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
