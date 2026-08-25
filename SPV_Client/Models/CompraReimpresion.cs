using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV_Client.Models
{
    public class CompraReimpresion
    {
        public string Folio { get; set; }

        public DateTime Fecha { get; set; }

        public string Usuario { get; set; }

        public string Autorizo { get; set; }

        public string Proveedor { get; set; }

        public decimal Total { get; set; }

        public List<CompraDetalleReimpresion> Detalle { get; set; }
            = new List<CompraDetalleReimpresion>();
    }

    public class CompraDetalleReimpresion
    {
        public string Producto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal Subtotal { get; set; }
    }
}
