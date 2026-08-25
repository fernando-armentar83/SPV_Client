using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPV_Client.Models;


namespace SPV_Client
{
    public partial class FrmCobro : Form
    {
        private decimal totalVenta = 0m;

        private decimal totalRecibido = 0m;

        private decimal cambio = 0m;

        private decimal falta = 0m;

        public CobroResultado Resultado { get; private set; }

        private void CalcularCobro()
        {
            decimal efectivo = 0;
            decimal tarjeta = 0;
            decimal transferencia = 0;
            decimal vale = 0;

            decimal.TryParse(txtEfectivo.Text, out efectivo);
            decimal.TryParse(txtTarjeta.Text, out tarjeta);
            decimal.TryParse(txtTransferencia.Text, out transferencia);
            decimal.TryParse(txtVale.Text, out vale);

            totalRecibido = efectivo + tarjeta + transferencia + vale;

            lblTotalRecibido.Text = totalRecibido.ToString("C2");

            if (totalRecibido >= totalVenta)
            {
                cambio = totalRecibido - totalVenta;

                lblEstadoCobro.Text = "CAMBIO";
                lblMontoEstado.Text = cambio.ToString("C2");
            }
            else
            {
                falta = totalVenta - totalRecibido;

                lblEstadoCobro.Text = "FALTA";
                lblMontoEstado.Text = falta.ToString("C2");
            }
        }

        public FrmCobro(decimal total)
        {
            InitializeComponent();

            totalVenta = total;

            lblTotalCobro.Text = totalVenta.ToString("C2");
        }

        private void FrmCobro_Load(object sender, EventArgs e)
        {

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularCobro();
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            CalcularCobro();
        }

        private void txtTransferencia_TextChanged(object sender, EventArgs e)
        {
            CalcularCobro();
        }

        private void txtVale_TextChanged(object sender, EventArgs e)
        {
            CalcularCobro();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (totalRecibido < totalVenta)
            {
                MessageBox.Show(
                    "El importe recibido es menor al total de la venta.",
                    "Pago insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEfectivo.Focus();
                txtEfectivo.SelectAll();

                return;
            }

            
            Resultado = new CobroResultado
            {
                Efectivo = decimal.TryParse(txtEfectivo.Text, out decimal efectivo) ? efectivo : 0,

                Tarjeta = decimal.TryParse(txtTarjeta.Text, out decimal tarjeta) ? tarjeta : 0,

                Transferencia = decimal.TryParse(txtTransferencia.Text, out decimal transferencia) ? transferencia : 0,

                Vale = decimal.TryParse(txtVale.Text, out decimal vale) ? vale : 0,

                TotalRecibido = totalRecibido,

                Cambio = cambio,

                TotalVenta = totalVenta
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarCobro_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
        "¿Desea cancelar el cobro y regresar a la venta?",
        "Cancelar cobro",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (r == DialogResult.No)
                return;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
