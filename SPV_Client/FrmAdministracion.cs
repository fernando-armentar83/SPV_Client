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

        private void FrmAdministracion_Load(object sender, EventArgs e)
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

        private void btnCategorías_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmCategorias>();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmDepartamentos>();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmMarcas>();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmProductos>();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmProveedores>();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmSocios>();
        }

        private void btnUnidadesMedida_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmUnidadesMedida>();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Esta función todavía está en desarrollo.",
    "Usuarios",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);
        }
    }
}
