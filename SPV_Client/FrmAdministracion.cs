using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPV_Client.Helpers;

namespace SPV_Client
{
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            lblUsuarioActivo.Text = "Usuario actual: " + Session.NombreUsuario;
        }

        private void btnAbrirArqueo_Click(object sender, EventArgs e)
        {
            if (!FrmArqueo.HayVentasSinArquear())
            {
                MessageBox.Show(
                    "No existen datos para realizar un arqueo.",
                    "Arqueo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            FormManager.AbrirFormularioUnico<FrmArqueo>();
        }
    }
}
