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
    public partial class FrmConteoEfectivo : Form
    {
        public decimal TotalContado { get; private set; }
        private decimal totalGeneral = 0m;

        public int B1000 { get; set; }
        public int B500 { get; set; }
        public int B200 { get; set; }
        public int B100 { get; set; }
        public int B50 { get; set; }
        public int B20 { get; set; }

        public int M20 { get; set; }
        public int M10 { get; set; }
        public int M5 { get; set; }
        public int M2 { get; set; }
        public int M1 { get; set; }

        public decimal M50 { get; set; }
        public FrmConteoEfectivo()
        {
            InitializeComponent();
        }

        private decimal ObtenerValor(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
                return 0;

            if (decimal.TryParse(txt.Text, out decimal valor))
                return valor;

            return 0;
        }

        private void CalcularTotal()
        {
            totalGeneral = 0;
            // Billetes
            totalGeneral += ObtenerValor(txt1000) * 1000;
            totalGeneral += ObtenerValor(txt500) * 500;
            totalGeneral += ObtenerValor(txt200) * 200;
            totalGeneral += ObtenerValor(txt100) * 100;
            totalGeneral += ObtenerValor(txt50) * 50;
            totalGeneral += ObtenerValor(txt20) * 20;

            // Monedas
            totalGeneral += ObtenerValor(txtM20) * 20;
            totalGeneral += ObtenerValor(txtM10) * 10;
            totalGeneral += ObtenerValor(txtM5) * 5;
            totalGeneral += ObtenerValor(txtM2) * 2;
            totalGeneral += ObtenerValor(txtM1) * 1;
            totalGeneral += ObtenerValor(txtM50) * 0.50m;

            lblTotalCalculado.Text = totalGeneral.ToString("C2");
            

            btnAceptar.Enabled = totalGeneral > 0;
        }

        private void FrmConteoEfectivo_Load(object sender, EventArgs e)
        {
            txt1000.Text = B1000.ToString();
            txt500.Text = B500.ToString();
            txt200.Text = B200.ToString();
            txt100.Text = B100.ToString();
            txt50.Text = B50.ToString();
            txt20.Text = B20.ToString();

            txtM20.Text = M20.ToString();
            txtM10.Text = M10.ToString();
            txtM5.Text = M5.ToString();
            txtM2.Text = M2.ToString();
            txtM1.Text = M1.ToString();
            txtM50.Text = M50.ToString();

            CalcularTotal();
            btnAceptar.Enabled = TotalContado > 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //
            
            B1000 = (int)ObtenerValor(txt1000);
            B500 = (int)ObtenerValor(txt500);
            B200 = (int)ObtenerValor(txt200);
            B100 = (int)ObtenerValor(txt100);
            B50 = (int)ObtenerValor(txt50);
            B20 = (int)ObtenerValor(txt20);

            M20 = (int)ObtenerValor(txtM20);
            M10 = (int)ObtenerValor(txtM10);
            M5 = (int)ObtenerValor(txtM5);
            M2 = (int)ObtenerValor(txtM2);
            M1 = (int)ObtenerValor(txtM1);

            M50 = ObtenerValor(txtM50);

            TotalContado = totalGeneral;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void Cantidad_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                if (txt.Text == "0")
                    txt.Clear();
            }
        }

        private void Cantidad_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                    txt.Text = "0";
            }
        }
    }
}
