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
    public partial class FrmCompraGuardada : Form
    {

        public string Folio { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Usuario { get; set; }
        public string Autorizo { get; set; }
        public string Proveedor { get; set; }
        public string Total { get; set; }

        public FrmCompraGuardada()
        {
            InitializeComponent();
        }

        public FrmCompraGuardada(
            string folio,
            string usuario,
            string proveedor,
            decimal total
            )
        {
            InitializeComponent();

            lblFolioInfo.Text = folio;
            lblFechaInfo.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraInfo.Text = DateTime.Now.ToString("HH:mm:ss");

            lblUsuarioInfo.Text = usuario;
            lblProveedorInfo.Text = proveedor;

            lblTotalInfo.Text = total.ToString("C2");
        }

        private void btnAceptarInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCompraGuardada_Load(object sender, EventArgs e)
        {
            lblFolioInfo.Text = Folio;
            lblFechaInfo.Text = Fecha;
            lblHoraInfo.Text = Hora;
            lblUsuarioInfo.Text = Usuario;
            lblAutorizoInfo.Text = Autorizo;
            lblProveedorInfo.Text = Proveedor;
            lblTotalInfo.Text = Total;
        }
    }
}
