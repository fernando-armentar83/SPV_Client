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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void btnProductosCatalogo_Click(object sender, EventArgs e)
        {
            using (FrmProductos frm = new FrmProductos())
            {
                frm.ShowDialog();
            }
        }

        private void btnHistorialVentasCatalogo_Click(object sender, EventArgs e)
        {
            using (FrmHistorialVentas frm = new FrmHistorialVentas())
            {
                frm.ShowDialog();
            }
        }
    }
}
