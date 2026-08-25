using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV_Client.Models
{
    public class VentaReimpresion
    {
        public string Folio { get; set; }

        public DateTime Fecha { get; set; }

        public string Usuario { get; set; }

        public string Cliente { get; set; }

        public decimal Total { get; set; }

        public decimal DescuentoGeneral { get; set; }

        public List<VentaDetalleReimpresion> Detalle { get; set; }
            = new List<VentaDetalleReimpresion>();
    }

    public class VentaDetalleReimpresion
    {
        public string Producto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Descuento { get; set; }

        public decimal Subtotal { get; set; }
    }
}
