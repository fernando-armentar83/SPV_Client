using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SPV_Client
{
    public class VentaDetalle
    {
        public int IdProducto { get; set; }

        public int IdCategoria { get; set; }

        public string Categoria { get; set; }

        public string Producto { get; set; }

        public string Modelo { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Descuento { get; set; }

        public decimal ImporteDescuento { get; set; }

        public string TipoDescuento { get; set; }

        public decimal Subtotal { get; set; }

        public decimal SubtotalOriginal { get; set; }
    }
}
