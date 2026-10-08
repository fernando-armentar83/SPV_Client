using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV_Client
{
    public partial class FrmConexion : Form
    {
        public FrmConexion()
        {
            InitializeComponent();
        }

        private void FrmConexion_Load(object sender, EventArgs e)
        {
            txtServer.Text = DB.Server;
            txtPort.Text = DB.Port;
            txtDatabase.Text = DB.Database;
            txtUser.Text = DB.User;
            txtPassword.Text = DB.Password;
        }

        private ConfiguracionConexion LeerFormulario()
        {
            return new ConfiguracionConexion
            {
                Server = txtServer.Text.Trim(),
                Port = txtPort.Text.Trim(),
                Database = txtDatabase.Text.Trim(),
                User = txtUser.Text.Trim(),
                Password = txtPassword.Text
            };
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtServer.Text) ||
                string.IsNullOrWhiteSpace(txtPort.Text) ||
                string.IsNullOrWhiteSpace(txtDatabase.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show(
                    "Servidor, puerto, base de datos y usuario son obligatorios.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            lblEstadoConexion.Text = "Probando...";
            this.Cursor = Cursors.WaitCursor;

            var configPrueba = LeerFormulario();

            bool ok = DB.TestConnection(configPrueba, out string error);

            this.Cursor = Cursors.Default;

            if (ok)
            {
                lblEstadoConexion.ForeColor = System.Drawing.Color.Green;
                lblEstadoConexion.Text = "Conexión exitosa.";
            }
            else
            {
                lblEstadoConexion.ForeColor = System.Drawing.Color.Red;
                lblEstadoConexion.Text = "Error: " + error;
            }
        }

        private void btnGuardarConexion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var nuevaConfig = LeerFormulario();

            bool ok = DB.TestConnection(nuevaConfig, out string error);

            if (!ok)
            {
                DialogResult continuar = MessageBox.Show(
                    "No fue posible conectar con estos datos:\n" + error +
                    "\n\n¿Desea guardarlos de todas formas?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (continuar == DialogResult.No)
                    return;
            }

            DialogResult confirmar = MessageBox.Show(
                "Se reiniciará el sistema para aplicar los cambios.\n¿Desea continuar?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar == DialogResult.No)
                return;

            DB.GuardarConfiguracion(nuevaConfig);

            Application.Restart();
            Environment.Exit(0);
        }

        private void btnCerrarConexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
