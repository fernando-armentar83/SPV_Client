using System;
using System.Diagnostics;
using System.IO;
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
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.RutaMysqldump))
            {
                txtRutaMysqldump.Text = @"C:\wamp64\bin\mysql\mysql8.0.31\bin\mysqldump.exe";
            }
            else
            {
                txtRutaMysqldump.Text = Properties.Settings.Default.RutaMysqldump;
            }

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.CarpetaBackup))
            {
                txtCarpetaDestino.Text =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SPV_Backups";
            }
            else
            {
                txtCarpetaDestino.Text = Properties.Settings.Default.CarpetaBackup;
            }
        }

        private void btnBuscarMysqldump_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "mysqldump.exe|mysqldump.exe";
                ofd.Title = "Seleccione mysqldump.exe";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtRutaMysqldump.Text = ofd.FileName;
                }
            }
        }

        private void btnBuscarCarpeta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Seleccione la carpeta donde guardar los respaldos";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtCarpetaDestino.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnEjecutarBackup_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtRutaMysqldump.Text))
            {
                MessageBox.Show(
                    "No se encontró mysqldump.exe en la ruta indicada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCarpetaDestino.Text))
            {
                MessageBox.Show(
                    "Seleccione una carpeta de destino.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(txtCarpetaDestino.Text))
            {
                Directory.CreateDirectory(txtCarpetaDestino.Text);
            }

            Properties.Settings.Default.RutaMysqldump = txtRutaMysqldump.Text;
            Properties.Settings.Default.CarpetaBackup = txtCarpetaDestino.Text;
            Properties.Settings.Default.Save();

            string nombreArchivo =
                $"{DB.Database}_{DateTime.Now:yyyyMMdd_HHmmss}.sql";

            string rutaCompleta = Path.Combine(txtCarpetaDestino.Text, nombreArchivo);

            string argumentos =
                $"--host={DB.Server} --port={DB.Port} --user={DB.User} " +
                $"--password={DB.Password} --routines --triggers " +
                $"--result-file=\"{rutaCompleta}\" {DB.Database}";

            btnEjecutarBackup.Enabled = false;
            lblInfoBackup.Text = "Generando respaldo, espere...";
            this.Cursor = Cursors.WaitCursor;

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = txtRutaMysqldump.Text,
                    Arguments = argumentos,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true
                };

                using (Process proceso = Process.Start(psi))
                {
                    string error = proceso.StandardError.ReadToEnd();
                    proceso.WaitForExit();

                    if (proceso.ExitCode != 0)
                    {
                        throw new Exception(
                            string.IsNullOrWhiteSpace(error)
                                ? "mysqldump terminó con un error desconocido."
                                : error);
                    }
                }

                lblInfoBackup.Text = $"Respaldo generado: {nombreArchivo}";

                MessageBox.Show(
                    $"Respaldo generado correctamente:\n{rutaCompleta}",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblInfoBackup.Text = "El respaldo falló.";

                MessageBox.Show(
                    "No fue posible generar el respaldo:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnEjecutarBackup.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCerrarBackup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
