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
    public partial class FrmEditarCantidad : Form
    {
        private decimal cantidadActual = 0m;

        private bool permiteDecimal = false;

        private int decimales = 0;

        public decimal NuevaCantidad { get; private set; }

        private void SoloNumerosDecimal(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                if (txt.Text.Contains("."))
                    e.Handled = true;

                return;
            }

            e.Handled = true;
        }

        

        public FrmEditarCantidad()
        {
            InitializeComponent();
        }
        public FrmEditarCantidad(string producto,decimal cantidad, bool permiteDecimalUnidad,
                                    int decimalesUnidad)
        {
            InitializeComponent();

            lblProducto.Text = producto;

            cantidadActual = cantidad;

            permiteDecimal = permiteDecimalUnidad;

            decimales = decimalesUnidad;

            txtCantidadEditar.Text = cantidadActual.ToString($"N{decimales}");

            txtCantidadEditar.SelectAll();
            txtCantidadEditar.Focus();
        }

        private void txtCantidadEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (permiteDecimal)
            {
                SoloNumerosDecimal(sender, e);

                if (e.Handled)
                    return;

                int punto = txt.Text.IndexOf('.');

                if (punto >= 0)
                {
                    if (txt.SelectionStart > punto)
                    {
                        int cantidadDecimales =
                            txt.Text.Substring(punto + 1).Length;

                        if (cantidadDecimales >= decimales &&
                            txt.SelectionLength == 0 &&
                            char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                    return;

                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        

        private void FrmEditarCantidad_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarCantidad_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCantidadEditar.Text.Trim(), out decimal cantidad))
            {
                MessageBox.Show(
                    "Cantidad inválida.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidadEditar.Focus();
                txtCantidadEditar.SelectAll();
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor que cero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidadEditar.Focus();
                txtCantidadEditar.SelectAll();
                return;
            }

            NuevaCantidad = cantidad;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
