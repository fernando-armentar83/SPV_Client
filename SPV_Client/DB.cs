// DB.cs
using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace SPV_Client
{
    public class ConfiguracionConexion
    {
        public string Server { get; set; } = "localhost";
        public string Port { get; set; } = "3306";
        public string Database { get; set; } = "spv_tlapaleria";
        public string User { get; set; } = "fer";
        public string Password { get; set; } = "129112";
    }

    public static class DB
    {
        private static readonly string rutaConfig =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "conexion.json");

        private static ConfiguracionConexion config;

        static DB()
        {
            CargarConfiguracion();
        }

        public static void CargarConfiguracion()
        {
            try
            {
                if (File.Exists(rutaConfig))
                {
                    string json = File.ReadAllText(rutaConfig);
                    config = JsonConvert.DeserializeObject<ConfiguracionConexion>(json) ?? new ConfiguracionConexion();
                }
                else
                {
                    config = new ConfiguracionConexion();
                    GuardarConfiguracion(config);
                }
            }
            catch
            {
                config = new ConfiguracionConexion();
            }
        }

        public static void GuardarConfiguracion(ConfiguracionConexion nuevaConfig)
        {
            config = nuevaConfig;
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(rutaConfig, json);
        }

        public static string Server => config.Server;
        public static string Port => config.Port;
        public static string Database => config.Database;
        public static string User => config.User;
        public static string Password => config.Password;

        public static string ConnectionString =>
    $"Server={config.Server};Port={config.Port};Database={config.Database};Uid={config.User};Pwd={config.Password};";


        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

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

        public static bool TestConnection(ConfiguracionConexion configPrueba, out string errorMessage)
        {
            errorMessage = string.Empty;
            string cs =
                $"Server={configPrueba.Server};Port={configPrueba.Port};Database={configPrueba.Database};" +
                $"Uid={configPrueba.User};Pwd={configPrueba.Password};";

            try
            {
                using (var conn = new MySqlConnection(cs))
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