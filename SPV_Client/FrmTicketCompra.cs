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
    public partial class FrmTicketCompra : Form
    {

        // ======================================
        // Configuración del ticket
        // ======================================

        private const int ANCHO_TICKET = 40;        //rollo 50mm imprime a 40 caracteres y 80mm a 48.

        // Margen izquierdo
        private const string MARGEN = "  ";

        private const int PUNTOS = 12;

        private CompraReimpresion _compra;

        public bool EsReimpresion { get; set; } = false;


        public FrmTicketCompra(CompraReimpresion compra)
        {
            InitializeComponent();

            _compra = compra;
        }

        private void FrmTicketCompra_Load(object sender, EventArgs e)
        {
            if (_compra == null)
            {
                MessageBox.Show(
                    "No existe información para mostrar.",
                    "Compra",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            ConstruirTicket();

            if (EsReimpresion)
                btnImprimirT.Text = "Reimprimir";
            else
                btnImprimirT.Text = "Imprimir";
        }

        private void ConstruirTicket()
        {
            rtbTicket.Clear();

            AgregarEncabezado();

            AgregarDatosCompra();

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

        private void AgregarDatosCompra()
        {
            rtbTicket.AppendText(MARGEN +
                $"Folio      : {_compra.Folio}\n");

            rtbTicket.AppendText(MARGEN +
                $"Fecha      : {_compra.Fecha:dd/MM/yyyy HH:mm}\n");

            rtbTicket.AppendText(MARGEN +
                $"Usuario    : {_compra.Usuario}\n");

            rtbTicket.AppendText(MARGEN +
                $"Autorizó   : {_compra.Autorizo}\n");

            rtbTicket.AppendText(MARGEN +
                $"Proveedor  : {_compra.Proveedor}\n\n");
        }

        private void AgregarDetalle()
        {
            rtbTicket.AppendText(
                MARGEN +
                new string('-', ANCHO_TICKET - MARGEN.Length));

            rtbTicket.AppendText("\n");

            foreach (var item in _compra.Detalle)
            {
                string izquierda =
                    $"{item.Cantidad:0.###} x {item.PrecioCompra:C2}";

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

                rtbTicket.AppendText(Environment.NewLine);
            }

            rtbTicket.AppendText(
                MARGEN +
                new string('-', ANCHO_TICKET - MARGEN.Length));

            rtbTicket.AppendText("\n");
        }

        private void AgregarTotales()
        {
            rtbTicket.AppendText(Environment.NewLine);

            AgregarLineaResumen("TOTAL", _compra.Total);

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

            AgregarTextoCentrado("COMPRA REGISTRADA");

            rtbTicket.AppendText(Environment.NewLine);

            AgregarTextoCentrado("Documento interno");

            AgregarTextoCentrado("de recepción de mercancía");

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
                "La impresión térmica se implementará posteriormente.",
                btnImprimirT.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
