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
    public partial class FrmSeleccionExportacion : Form
    {
        public enum TipoExportacion
        {
            HistorialCompras,
            DetalleCompra,
            HistorialVentas,
            DetalleVenta
        }

        public TipoExportacion ExportacionSeleccionada { get; private set; }

        public FrmSeleccionExportacion(bool esVentas)
        {
            InitializeComponent();

            if (esVentas)
            {
                btnHistorial.Text = "Historial de ventas";
                btnDetalle.Text = "Detalle de venta";

                ExportacionSeleccionada =
                    TipoExportacion.HistorialVentas;
            }
            else
            {
                btnHistorial.Text = "Historial de compras";
                btnDetalle.Text = "Detalle de compra";

                ExportacionSeleccionada =
                    TipoExportacion.HistorialCompras;
            }
        }

        private void btnHistorial_Click_1(object sender, EventArgs e)
        {
            if (btnHistorial.Text == "Historial de ventas")
            {
                ExportacionSeleccionada =
                    TipoExportacion.HistorialVentas;
            }
            else
            {
                ExportacionSeleccionada =
                    TipoExportacion.HistorialCompras;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDetalle_Click_1(object sender, EventArgs e)
        {
            if (btnDetalle.Text == "Detalle de venta")
            {
                ExportacionSeleccionada =
                    TipoExportacion.DetalleVenta;
            }
            else
            {
                ExportacionSeleccionada =
                    TipoExportacion.DetalleCompra;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
