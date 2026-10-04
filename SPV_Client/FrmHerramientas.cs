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
    public partial class FrmHerramientas : Form
    {
        public FrmHerramientas()
        {
            InitializeComponent();
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {                   
            FormManager.AbrirFormularioUnico<FrmBackup>();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {

        }
    }
}
