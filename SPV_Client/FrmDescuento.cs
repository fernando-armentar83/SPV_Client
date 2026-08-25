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
    public partial class FrmDescuento : Form
    {
        private decimal subtotalOriginal;

        public DescuentoResultado Resultado { get; private set; }

        public FrmDescuento(
    string producto,
    decimal cantidad,
    decimal precio,
    decimal subtotal,
    string tipoDescuento,
    decimal porcentaje,
    decimal importeDescuento)
        {
            InitializeComponent();

            txtProductoDesc.Text = producto;
            if (tipoDescuento == "Porcentaje")
            {
                cboTipoDescuento.SelectedIndex = 0;
                txtValorDescuento.Text = porcentaje.ToString("0.###");
            }
            else if (tipoDescuento == "Importe")
            {
                cboTipoDescuento.SelectedIndex = 1;
                txtValorDescuento.Text = importeDescuento.ToString("0.##");
            }
            else
            {
                cboTipoDescuento.SelectedIndex = 0;
                txtValorDescuento.Text = "0";
            }

            subtotalOriginal = subtotal;

            lblVistaPrevia.Text =
                $"Subtotal: {subtotalOriginal:C2}";
        }

        private void FrmDescuento_Load(object sender, EventArgs e)
        {
            //cboTipoDescuento.SelectedIndex = 0;
            //txtValorDescuento.Text = "0";
        }

        private void CalcularVistaPrevia()
        {
            if (!decimal.TryParse(txtValorDescuento.Text.Trim(), out decimal valor))
                valor = 0;

            decimal importeDescuento = 0;

            if (cboTipoDescuento.SelectedIndex == 0) // Porcentaje
            {
                importeDescuento = subtotalOriginal * (valor / 100m);
            }
            else // Importe
            {
                importeDescuento = valor;
            }

            if (importeDescuento > subtotalOriginal)
                importeDescuento = subtotalOriginal;

            decimal nuevoSubtotal = subtotalOriginal - importeDescuento;

            lblVistaPrevia.Text =
                $"Subtotal original : {subtotalOriginal:C2}\n" +
                $"Descuento : {importeDescuento:C2}\n" +
                $"Nuevo subtotal : {nuevoSubtotal:C2}";
        }

        private void txtValorDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularVistaPrevia();
        }

        private void cboTipoDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularVistaPrevia();
        }

        private void btnAceptarDesc_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValorDescuento.Text.Trim(), out decimal valor))
                valor = 0;

            decimal importeDescuento = 0;

            if (cboTipoDescuento.SelectedIndex == 0)
                importeDescuento = subtotalOriginal * (valor / 100m);
            else
                importeDescuento = valor;

            if (importeDescuento > subtotalOriginal)
                importeDescuento = subtotalOriginal;

            Resultado = new DescuentoResultado
            {
                TipoDescuento = cboTipoDescuento.Text,
                Porcentaje = cboTipoDescuento.SelectedIndex == 0 ? valor : 0,
                ImporteDescuento = importeDescuento,
                NuevoSubtotal = subtotalOriginal - importeDescuento
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
