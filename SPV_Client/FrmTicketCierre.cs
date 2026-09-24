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
    public partial class FrmTicketCierre : Form
    {
        private const int ANCHO_TICKET = 40;
        private const string MARGEN = " ";

        private CierreReimpresion _cierre;

        public bool ModoReimpresion { get; set; } = false;

        public FrmTicketCierre(CierreReimpresion cierre)
        {
            InitializeComponent();
            _cierre = cierre;
        }

        private void FrmTicketCierre_Load(object sender, EventArgs e)
        {
            if (_cierre == null)
            {
                MessageBox.Show(
                    "No existe información para mostrar.",
                    "Cierre de turno",
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
            AgregarDatosTurno();
            AgregarResumenArqueos();
            AgregarCierreFinal();
            AgregarPie();
        }

        private void AgregarEncabezado()
        {
            rtbTicket.AppendText(MARGEN + new string('=', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText(Environment.NewLine);
            AgregarTextoCentrado("CIERRE DE TURNO");
            rtbTicket.AppendText(MARGEN + new string('=', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText(Environment.NewLine);
            rtbTicket.AppendText(Environment.NewLine);
        }

        private void AgregarDatosTurno()
        {
            rtbTicket.AppendText(MARGEN + $"Turno       : #{_cierre.IdTurno}\n");
            rtbTicket.AppendText(MARGEN + $"Apertura    : {_cierre.FechaApertura:dd/MM/yyyy HH:mm:ss}\n");
            rtbTicket.AppendText(MARGEN + $"Cierre      : {_cierre.FechaCierre:dd/MM/yyyy HH:mm:ss}\n");
            rtbTicket.AppendText(MARGEN + $"Abrió       : {_cierre.UsuarioApertura}\n");
            rtbTicket.AppendText(MARGEN + $"Cerró       : {_cierre.UsuarioCierre}\n");
            rtbTicket.AppendText(MARGEN + $"Fondo inicial: {_cierre.MontoInicial:C2}\n\n");
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

        private void AgregarResumenArqueos()
        {
            rtbTicket.AppendText(MARGEN + new string('-', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText("\n");
            AgregarTextoCentrado("RESUMEN DE ARQUEOS DEL TURNO");

            rtbTicket.AppendText(MARGEN + $"Arqueos realizados : {_cierre.CantidadArqueos}\n\n");

            AgregarLinea("RETIRADO EN ARQUEOS", _cierre.TotalRetiradoArqueos);
            AgregarLinea("ELECTRONICO ARQUEADO", _cierre.TotalElectronicoArqueos);
            AgregarLinea("VENTAS EN ARQUEOS", _cierre.TotalVentasArqueos);

            rtbTicket.AppendText(Environment.NewLine);
        }

        private void AgregarCierreFinal()
        {
            rtbTicket.AppendText(MARGEN + new string('-', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText("\n");
            AgregarTextoCentrado("VERIFICACION FINAL DEL TRAMO");

            AgregarLinea("EFECTIVO ESPERADO", _cierre.EfectivoEsperado);
            AgregarLinea("EFECTIVO CONTADO", _cierre.EfectivoContado);
            AgregarLinea("DIF. EFECTIVO", _cierre.DiferenciaEfectivo);

            rtbTicket.AppendText(Environment.NewLine);

            AgregarLinea("ELECTRONICO ESPERADO", _cierre.ElectronicoEsperado);
            AgregarLinea("ELECTRONICO CONTADO", _cierre.ElectronicoContado);
            AgregarLinea("DIF. ELECTRONICO", _cierre.DiferenciaElectronico);

            rtbTicket.AppendText(Environment.NewLine);

            AgregarLinea("TOTAL VENTAS DEL TURNO", _cierre.TotalVentasHistorico);

            rtbTicket.AppendText(Environment.NewLine);

            rtbTicket.AppendText(MARGEN + "Observaciones:\n");
            rtbTicket.AppendText(MARGEN +
                (string.IsNullOrWhiteSpace(_cierre.Observaciones) ? "---" : _cierre.Observaciones) +
                Environment.NewLine);

            rtbTicket.AppendText(MARGEN + new string('-', ANCHO_TICKET - MARGEN.Length));
            rtbTicket.AppendText("\n");
        }

        private void AgregarPie()
        {
            rtbTicket.AppendText(Environment.NewLine);
            AgregarTextoCentrado("Documento interno de cierre");
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