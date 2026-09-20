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
    public partial class FrmTicketArqueo : Form
    {
        private const int ANCHO_TICKET = 40;
        private const string MARGEN = " ";

        private ArqueoReimpresion _arqueo;

        public bool ModoReimpresion { get; set; } = false;

        public FrmTicketArqueo(ArqueoReimpresion arqueo)
        {
            InitializeComponent();
            _arqueo = arqueo;
        }

        private void FrmTicketArqueo_Load(object sender, EventArgs e)
        {
            if (_arqueo == null)
            {
                MessageBox.Show(
                    "No existe información para mostrar.",
                    "Arqueo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            ConstruirTicket();

            btnImprimirT.Text = ModoReimpresion ? "Reimprimir" : "Imprimir";
        }

        private void ConstruirTicket()
        {
            rtbTicket.Clear();

            AgregarEncabezado();
            AgregarDatosArqueo();
            AgregarMontos();
            AgregarPie();
        }

        private void AgregarEncabezado()
        {
            rtbTicket.AppendText(MARGEN + new string('=', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText(Environment.NewLine);
            AgregarTextoCentrado("ARQUEO DE CAJA");
            rtbTicket.AppendText(MARGEN + new string('=', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText(Environment.NewLine);
            rtbTicket.AppendText(Environment.NewLine);
        }

        private void AgregarDatosArqueo()
        {
            rtbTicket.AppendText(MARGEN + $"Folio      : {_arqueo.Folio}\n");
            rtbTicket.AppendText(MARGEN + $"Turno      : {_arqueo.IdTurno}\n");
            rtbTicket.AppendText(MARGEN + $"Usuario    : {_arqueo.Usuario}\n");
            rtbTicket.AppendText(MARGEN + $"Inicio     : {_arqueo.FechaInicio:dd/MM/yyyy HH:mm:ss}\n");
            rtbTicket.AppendText(MARGEN + $"Fin        : {_arqueo.FechaFin:dd/MM/yyyy HH:mm:ss}\n");
            rtbTicket.AppendText(MARGEN + $"Fecha reg. : {_arqueo.FechaArqueo:dd/MM/yyyy HH:mm:ss}\n\n");
        }

        private void AgregarLinea(string titulo, decimal importe)
        {
            string valor = importe.ToString("C2");
            int puntos = ANCHO_TICKET - titulo.Length - valor.Length - MARGEN.Length;

            if (puntos < 2)
                puntos = 2;

            rtbTicket.AppendText(
                MARGEN + titulo + " " + new string('.', puntos) + " " + valor + Environment.NewLine);
        }

        private void AgregarTextoCentrado(string texto)
        {
            int espacios = (ANCHO_TICKET - texto.Length) / 2;

            if (espacios < 0)
                espacios = 0;

            rtbTicket.AppendText(new string(' ', espacios) + texto + Environment.NewLine);
        }

        private void AgregarMontos()
        {
            rtbTicket.AppendText(MARGEN + new string('-', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText("\n");

            AgregarLinea("EFECTIVO ESPERADO", _arqueo.EfectivoEsperado);
            AgregarLinea("EFECTIVO CONTADO", _arqueo.EfectivoContado);
            AgregarLinea("DIF. EFECTIVO", _arqueo.DiferenciaEfectivo);

            rtbTicket.AppendText(Environment.NewLine);

            AgregarLinea("ELECTRONICO", _arqueo.Electronico);
            AgregarLinea("ELECT. COMPROBADO", _arqueo.ElectronicoComprobado);
            AgregarLinea("DIF. ELECTRONICO", _arqueo.DiferenciaElectronico);

            rtbTicket.AppendText(MARGEN +
                $"Verificado : {(_arqueo.ElectronicoVerificado ? "SI" : "NO")}\n\n");

            AgregarLinea("TOTAL VENTAS", _arqueo.TotalVentas);

            rtbTicket.AppendText(Environment.NewLine);

            rtbTicket.AppendText(MARGEN + $"Estado : {_arqueo.Estado}\n\n");

            rtbTicket.AppendText(MARGEN + "Observaciones:\n");
            rtbTicket.AppendText(MARGEN +
                (string.IsNullOrWhiteSpace(_arqueo.Observaciones) ? "---" : _arqueo.Observaciones) +
                Environment.NewLine);

            rtbTicket.AppendText(MARGEN + new string('-', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText("\n");
        }

        private void AgregarPie()
        {
            rtbTicket.AppendText(Environment.NewLine);
            AgregarTextoCentrado("Documento interno de auditoría");
            rtbTicket.AppendText(Environment.NewLine);
            AgregarTextoCentrado("Impreso: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            rtbTicket.AppendText(Environment.NewLine);
            rtbTicket.AppendText(MARGEN + new string('=', ANCHO_TICKET - MARGEN.Length));
        }

        private void btnCerrarTicket_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimirT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "La impresión térmica será implementada cuando se configure la impresora.",
                btnImprimirT.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}