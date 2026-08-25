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
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            lblUsuarioActivo.Text = "Usuario actual: " + Session.NombreUsuario;
        }

        private void btnCatalogoProductos_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmCatalogoCompras>();
        }
    }
}