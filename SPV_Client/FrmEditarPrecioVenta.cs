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
    public partial class FrmEditarPrecioVenta : Form
    {

        public decimal PrecioActual
        {
            get;
            set;
        }

        public decimal NuevoPrecio
        {
            get;
            private set;
        }
        public FrmEditarPrecioVenta()
        {
            InitializeComponent();
        }

        private void FrmEditarPrecioVenta_Load(object sender, EventArgs e)
        {
            lblPrecioActualValor.Text = PrecioActual.ToString("C2");

            txtNuevoPrecio.Text =
                PrecioActual.ToString("0.00");

            txtNuevoPrecio.SelectAll();

            txtNuevoPrecio.Focus();
        }

        private void btnCancelarPrecio_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void btnAceptarPrecio_Click(object sender, EventArgs e)
        {
            decimal precio;

            if (!decimal.TryParse(txtNuevoPrecio.Text, out precio))
            {
                MessageBox.Show(
                    "Precio inválido.");

                txtNuevoPrecio.Focus();

                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show(
                    "El precio debe ser mayor a cero.");

                txtNuevoPrecio.Focus();

                return;
            }

            NuevoPrecio = precio;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void txtNuevoPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuevoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (txtNuevoPrecio.Text.Contains(".") ||
                    txtNuevoPrecio.Text.Contains(","))
                {
                    e.Handled = true;
                }

                return;
            }

            e.Handled = true;
        }
    }
}
