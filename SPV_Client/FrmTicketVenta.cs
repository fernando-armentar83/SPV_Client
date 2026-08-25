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
    public partial class FrmTicketVenta : Form
    {
        // ======================================
        // Configuración del ticket
        // ======================================

        private const int ANCHO_TICKET = 40;        //rollo 50mm imprime a 40 caracteres y 80mm a 48.

        // Margen izquierdo
        private const string MARGEN = "  ";

        private const int PUNTOS = 12;

        private VentaReimpresion _venta;

        public bool ModoReimpresion { get; set; } = false;

        public FrmTicketVenta(VentaReimpresion venta)
        {
            InitializeComponent();

            _venta = venta;
        }

        private void FrmTicketVenta_Load(object sender, EventArgs e)
        {
            if (_venta == null)
            {
                MessageBox.Show(
                    "No existe información para mostrar.",
                    "Ticket",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            ConstruirTicket();

            if (ModoReimpresion)
            {
                btnImprimirT.Text = "Reimprimir";
            }
            else
            {
                btnImprimirT.Text = "Imprimir";
            }

        }

        
        
            private void ConstruirTicket()
        {
            rtbTicket.Clear();

            AgregarEncabezado();

            AgregarDatosVenta();

            AgregarDetalle();

            AgregarTotales();

            AgregarPie();
        }


        private void AgregarEncabezado()
        {
            rtbTicket.AppendText(
                MARGEN +
                new string('=', ANCHO_TICKET - MARGEN.Length));

            rtbTicket.AppendText(Environment.NewLine);

            AgregarTextoCentrado("TLAPALERIA XXXXX");

            rtbTicket.AppendText(
                MARGEN +
                new string('=', ANCHO_TICKET - MARGEN.Length));

            rtbTicket.AppendText(Environment.NewLine);
            rtbTicket.AppendText(Environment.NewLine);
        }

        private void AgregarDatosVenta()
        {
            rtbTicket.AppendText(MARGEN +
                $"Folio   : {_venta.Folio}\n");

            rtbTicket.AppendText(MARGEN +
                $"Fecha   : {_venta.Fecha:dd/MM/yyyy HH:mm}\n");

            rtbTicket.AppendText(MARGEN +
                $"Cajero  : {_venta.Usuario}\n");

            rtbTicket.AppendText(MARGEN +
                $"Cliente : {_venta.Cliente}\n\n");
        }

        private void AgregarDetalle()
        {
            rtbTicket.AppendText(
                MARGEN +
                new string('-', ANCHO_TICKET - MARGEN.Length));

            rtbTicket.AppendText("\n");

            foreach (var item in _venta.Detalle)
            {
                string izquierda =
    $"{item.Cantidad:0.###} x {item.PrecioUnitario:C2}";

                string derecha =
                    item.Subtotal.ToString("C2");

                int espacios =
                    ANCHO_TICKET
                    - izquierda.Length
                    - derecha.Length;

                if (espacios < 1)
                    espacios = 1;

                rtbTicket.AppendText(
                    MARGEN +
                    izquierda +
                    new string(' ', espacios) +
                    derecha +
                    Environment.NewLine);

                rtbTicket.AppendText(
                    MARGEN +
                    item.Producto +
                    Environment.NewLine);

                // Descuento (si existe)
                if (item.Descuento > 0)
                {
                    rtbTicket.AppendText(
                        MARGEN +
                        $"Desc.: {item.Descuento:N2}%\n");
                }

                rtbTicket.AppendText(Environment.NewLine);
            }

            rtbTicket.AppendText(
                MARGEN +
                new string('-', ANCHO_TICKET - MARGEN.Length));

            rtbTicket.AppendText("\n");
        }

        private void AgregarLineaResumen(string titulo, decimal importe)
        {
            string valor = importe.ToString("C2");

            int puntos =
                ANCHO_TICKET
                - titulo.Length
                - valor.Length
                - MARGEN.Length;

            if (puntos < 2)
                puntos = 2;

            rtbTicket.AppendText(
                MARGEN +
                titulo +
                " " +
                new string('.', puntos) +
                " " +
                valor +
                Environment.NewLine);
        }

        private void AgregarTextoCentrado(string texto)
        {
            int espacios = (ANCHO_TICKET - texto.Length) / 2;

            if (espacios < 0)
                espacios = 0;

            rtbTicket.AppendText(
                new string(' ', espacios) +
                texto +
                Environment.NewLine);
        }

        private void AgregarTotales()
        {
            rtbTicket.AppendText(Environment.NewLine);

            decimal subtotal = _venta.Detalle.Sum(x => x.Subtotal);

            AgregarLineaResumen("SUBTOTAL", subtotal);

            if (_venta.DescuentoGeneral > 0)
            {
                AgregarLineaResumen(
                    "DESCUENTO",
                    _venta.DescuentoGeneral);
            }

            AgregarLineaResumen("TOTAL", _venta.Total);

            rtbTicket.AppendText(Environment.NewLine);
        }

        private void AgregarPie()
        {
            rtbTicket.AppendText(Environment.NewLine);

            rtbTicket.AppendText(
                MARGEN +
                new string('=', ANCHO_TICKET - MARGEN.Length));

            rtbTicket.AppendText(Environment.NewLine);
            rtbTicket.AppendText(Environment.NewLine);

            AgregarTextoCentrado("¡GRACIAS POR SU COMPRA!");

            rtbTicket.AppendText(Environment.NewLine);

            AgregarTextoCentrado("Conserve este ticket");

            AgregarTextoCentrado("para cualquier aclaración.");

            rtbTicket.AppendText(Environment.NewLine);

            AgregarTextoCentrado(
                "Impreso: " +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            rtbTicket.AppendText(Environment.NewLine);

            rtbTicket.AppendText(
                MARGEN +
                new string('=', ANCHO_TICKET - MARGEN.Length));
        }

        private void btnCerrarTicket_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimirT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "La impresión térmica será implementada cuando se configure la impresora.",
        "Imprimir",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        }
    }
}
