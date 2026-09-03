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
        private readonly string connString =
            "server=localhost;database=spv_tlapaleria;uid=fer;pwd=129112;";

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
                MessageBox.Show(
                    "Por favor ingrese usuario y contraseña.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(
                    "server=localhost;database=spv_tlapaleria;uid=fer;pwd=129112;"))
                {
                    conexion.Open();

                    // =====================================================
                    // 1) VALIDAR USUARIO
                    // =====================================================

                    string query = @"
SELECT 
    u.id_usuario,
    u.nombre,
    u.id_rol,
    r.nombre_rol
FROM usuarios u
INNER JOIN roles r 
    ON u.id_rol = r.id_rol
WHERE u.nombre = @usuario
  AND u.contrasena = @password
  AND u.activo = 1;";

                    int idUsuario;
                    string nombreUsuario;
                    int idRol;
                    string nombreRol;

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "Usuario o contraseña incorrectos o inactivo.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                return;
                            }

                            idUsuario = Convert.ToInt32(reader["id_usuario"]);
                            nombreUsuario = reader["nombre"].ToString();
                            idRol = Convert.ToInt32(reader["id_rol"]);
                            nombreRol = reader["nombre_rol"].ToString();
                        }
                    }

                    // =====================================================
                    // 2) GUARDAR USUARIO EN SESSION
                    // =====================================================

                    Session.IdUsuario = idUsuario;
                    Session.NombreUsuario = nombreUsuario;
                    Session.IdRol = idRol;
                    Session.NombreRol = nombreRol;

                    Session.IdTurno = 0;
                    Session.MontoInicial = 0;

                    // =====================================================
                    // 3) DETERMINAR GRUPO DE TURNO
                    //
                    // ROL 1 = ADMINISTRADOR
                    // ROL 2 = SUPERVISOR
                    // ROL 3 = CAJERO
                    //
                    // Administrador tiene su propio turno.
                    // Supervisor/Cajero comparten el grupo operativo,
                    // pero NO comparten el turno.
                    // =====================================================

                    bool esAdministrador = idRol == 1;

                    // =====================================================
                    // 4) BUSCAR SI ESTE MISMO USUARIO YA TIENE
                    //    UN TURNO ABIERTO
                    // =====================================================

                    string buscarTurnoUsuario = @"
SELECT 
    id_turno,
    monto_inicial
FROM cajas_turnos
WHERE id_usuario = @idUsuario
  AND fecha_cierre IS NULL
ORDER BY id_turno DESC
LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(
                        buscarTurnoUsuario, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Session.IdTurno =
                                    Convert.ToInt32(reader["id_turno"]);

                                Session.MontoInicial =
                                    Convert.ToDecimal(reader["monto_inicial"]);
                            }
                        }
                    }

                    // =====================================================
                    // 5) SI EL USUARIO YA TIENE TURNO ABIERTO,
                    //    RECUPERARLO
                    // =====================================================

                    if (Session.IdTurno != 0)
                    {
                        MessageBox.Show(
                            $"Ya existe un turno abierto para el usuario " +
                            $"{Session.NombreUsuario}.\n\n" +
                            $"Se continuará con el turno #{Session.IdTurno}.",
                            "Turno recuperado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        MessageBox.Show(
                            $"Bienvenido {Session.NombreUsuario} " +
                            $"({Session.NombreRol})\n\n" +
                            $"Turno #{Session.IdTurno} activo.\n\n" +
                            $"Monto inicial: {Session.MontoInicial:C2}",
                            "Acceso concedido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                        return;
                    }

                    // =====================================================
                    // 6) SI ES ADMINISTRADOR
                    //    COMPROBAR SI YA EXISTE OTRO ADMINISTRADOR
                    //    CON TURNO ABIERTO
                    // =====================================================

                    if (esAdministrador)
                    {
                        string buscarOtroAdministrador = @"
SELECT 
    ct.id_turno,
    ct.id_usuario,
    u.nombre
FROM cajas_turnos ct
INNER JOIN usuarios u
    ON ct.id_usuario = u.id_usuario
WHERE ct.fecha_cierre IS NULL
  AND u.id_rol = 1
LIMIT 1;";

                        using (MySqlCommand cmd = new MySqlCommand(
                            buscarOtroAdministrador, conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string usuarioActivo =
                                        reader["nombre"].ToString();

                                    int turnoActivo =
                                        Convert.ToInt32(reader["id_turno"]);

                                    MessageBox.Show(
                                        $"Ya existe una sesión de " +
                                        $"Administrador abierta.\n\n" +
                                        $"Usuario: {usuarioActivo}\n" +
                                        $"Turno: #{turnoActivo}\n\n" +
                                        $"No es posible abrir otra sesión " +
                                        $"de Administrador.",
                                        "Sesión ya abierta",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                                    Session.IdUsuario = 0;
                                    Session.NombreUsuario = "";
                                    Session.IdRol = 0;
                                    Session.NombreRol = "";
                                    Session.IdTurno = 0;
                                    Session.MontoInicial = 0;

                                    return;
                                }
                            }
                        }
                    }

                    // =====================================================
                    // 7) SI ES SUPERVISOR O CAJERO
                    //    COMPROBAR SI YA EXISTE UN TURNO OPERATIVO
                    // =====================================================

                    if (idRol == 2 || idRol == 3)
                    {
                        string buscarOtroOperativo = @"
SELECT 
    ct.id_turno,
    ct.id_usuario,
    u.nombre,
    r.nombre_rol
FROM cajas_turnos ct
INNER JOIN usuarios u
    ON ct.id_usuario = u.id_usuario
INNER JOIN roles r
    ON u.id_rol = r.id_rol
WHERE ct.fecha_cierre IS NULL
  AND u.id_rol IN (2, 3)
LIMIT 1;";

                        using (MySqlCommand cmd = new MySqlCommand(
                            buscarOtroOperativo, conexion))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string usuarioActivo =
                                        reader["nombre"].ToString();

                                    string rolActivo =
                                        reader["nombre_rol"].ToString();

                                    int turnoActivo =
                                        Convert.ToInt32(reader["id_turno"]);

                                    MessageBox.Show(
                                        $"Ya existe un turno operativo abierto.\n\n" +
                                        $"Usuario: {usuarioActivo}\n" +
                                        $"Rol: {rolActivo}\n" +
                                        $"Turno: #{turnoActivo}\n\n" +
                                        $"No es posible abrir otro turno " +
                                        $"de Supervisor/Cajero.",
                                        "Turno ya abierto",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                                    Session.IdUsuario = 0;
                                    Session.NombreUsuario = "";
                                    Session.IdRol = 0;
                                    Session.NombreRol = "";
                                    Session.IdTurno = 0;
                                    Session.MontoInicial = 0;

                                    return;
                                }
                            }
                        }
                    }

                    // =====================================================
                    // 8) NO EXISTE TURNO PARA ESTE GRUPO
                    //    CREAR NUEVO TURNO
                    // =====================================================

                    string insertTurno = @"
INSERT INTO cajas_turnos
(
    id_usuario,
    fecha_apertura,
    monto_inicial
)
VALUES
(
    @idUsuario,
    NOW(),
    0
);";

                    using (MySqlCommand cmd = new MySqlCommand(
                        insertTurno, conexion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@idUsuario", idUsuario);

                        cmd.ExecuteNonQuery();

                        Session.IdTurno =
                            Convert.ToInt32(cmd.LastInsertedId);

                        Session.MontoInicial = 0;
                    }

                    // =====================================================
                    // 9) MENSAJE FINAL
                    // =====================================================

                    MessageBox.Show(
                        $"Bienvenido {Session.NombreUsuario} " +
                        $"({Session.NombreRol})\n\n" +
                        $"Turno #{Session.IdTurno} activo.\n\n" +
                        $"Monto inicial: {Session.MontoInicial:C2}",
                        "Acceso concedido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al conectar con la base de datos:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
