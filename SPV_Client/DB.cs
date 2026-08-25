// DB.cs
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SPV_Client
{
    public static class DB
    {
        // --- EDITA ESTOS VALORES con tu servidor MySQL/MariaDB ---
        private static string server = "localhost";
        private static string port = "3306";
        private static string database = "spv_tlapaleria";
        private static string user = "fer";
        private static string password = "129112"; // si tienes contraseña, ponla aquí
        // --------------------------------------------------------

        public static string ConnectionString =>
            $"Server={server};Port={port};Database={database};Uid={user};Pwd={password};AllowPublicKeyRetrieval=True;SslMode=none;";

        // Devuelve la conexión (no abierta). El consumidor la abre con conn.Open()
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        // Método auxiliar para probar la conexión (opcional)
        public static bool TestConnection(out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
        // Método utilitario que muestra un MessageBox con el resultado (útil para pruebas rápidas)
        public static void ProbarConexion()
        {
            string err;
            if (TestConnection(out err))
            {
                MessageBox.Show("✅ Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ Error al conectar a la base de datos:" + Environment.NewLine + err,
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

