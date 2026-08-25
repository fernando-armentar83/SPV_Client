using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPV_Client.Models;

namespace SPV_Client
{
    

    public partial class FrmTicket : Form
    {
        private int _anchoTicket = 48; // 48 = 80mm | 32 = 55mm
        private bool _usarPreview = false; // ← por ahora sin preview
        private bool _guardarPdf = false;    // ⬅️ ACTIVAR / DESACTIVAR PDF
        private string _nombreImpresora = "Microsoft Print to PDF";
        private bool _imprimirTicket = false;   // impresión física
        public bool ImprimirTicket => _imprimirTicket;
        public bool GuardarPdf => _guardarPdf;




        public FrmTicket(string nombreNegocio,
            string linea2,
            string mensajeFinal,
            string folio,
            string cajero,
            List<TicketDetalleItem> detalle,
            decimal total)
        {
            InitializeComponent();
            printDocumentTicket.PrintPage += printDocumentTicket_PrintPage;

            txtNombreNegocio.Text = nombreNegocio;
            txtLinea2.Text = linea2;
            txtMensajeFinal.Text = mensajeFinal;

            lblFolioValor.Text = folio;
            lblCajeroValor.Text = cajero;
            lblFechaValor.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraValor.Text = DateTime.Now.ToString("HH:mm:ss");

            dgvDetalle.AutoGenerateColumns = true;
            dgvDetalle.DataSource = detalle;

            lblTotalTicket.Text = total.ToString("C2");
        }

        private void pnlDatosVenta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void btnCerrarTicket_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            _imprimirTicket = true;   // o false según configuración
            _guardarPdf = false;      // evita PDF por defecto

            this.DialogResult = DialogResult.OK;
            this.Close();

           

        }



        private void printDocumentTicket_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = GenerarTextoTicket();

            Font fuente = new Font("Consolas", 9);
            float x = 0;
            float y = 0;

            e.Graphics.DrawString(
                texto,
                fuente,
                Brushes.Black,
                x,
                y
            );
        }

        private void ConfigurarAnchoTicket(bool es80mm)
        {
            _anchoTicket = es80mm ? 48 : 32;
        }
        private string GenerarTextoTicket()
        {
            var sb = new StringBuilder();

            sb.AppendLine(txtNombreNegocio.Text);
            sb.AppendLine(txtLinea2.Text);
            sb.AppendLine(new string('-', _anchoTicket));

            sb.AppendLine($"Folio: {lblFolioValor.Text}");
            sb.AppendLine($"Fecha: {lblFechaValor.Text} {lblHoraValor.Text}");
            sb.AppendLine($"Cajero: {lblCajeroValor.Text}");
            sb.AppendLine(new string('-', _anchoTicket));

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.IsNewRow) continue;

                string prod = fila.Cells["Producto"].Value?.ToString();
                string cant = fila.Cells["Cantidad"].Value?.ToString();
                string sub = fila.Cells["Subtotal"].Value?.ToString();

                sb.AppendLine(prod);
                sb.AppendLine($"{cant} x {fila.Cells[2].Value} = {sub}");
            }

            sb.AppendLine(new string('-', _anchoTicket));
            sb.AppendLine($"TOTAL: {lblTotalTicket.Text}");
            sb.AppendLine(new string('-', _anchoTicket));

            sb.AppendLine(txtMensajeFinal.Text);

            return sb.ToString();
        }

        public string GenerarTextoParaImpresion()
        {
            return GenerarTextoTicket();
        }

    }
}
