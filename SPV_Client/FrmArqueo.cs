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
    public partial class FrmArqueo : Form
    {
        public FrmArqueo()
        {
            InitializeComponent();
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnContarEfectivo_Click(object sender, EventArgs e)
        {
            using (FrmConteoEfectivo frmConteo = new FrmConteoEfectivo())
            {
                if (frmConteo.ShowDialog() == DialogResult.OK)
                {
                    lblEfectivoContado.Text =
                        frmConteo.TotalContado.ToString("C2");
                }
            }
        }

        private void FrmArqueo_Load(object sender, EventArgs e)
        {

        }
    }
}
