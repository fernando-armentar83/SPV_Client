using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SPV_Client.Models
{
    public class ProductoSeleccionado
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }

        public decimal StockActual { get; set; }

        public string CodigoBarras { get; set; }

        public string CodigoCompra { get; set; }

        public string Proveedor { get; set; }

        public int IdMedida { get; set; }

        public string Abreviatura { get; set; }

        public bool PermiteDecimal { get; set; }

        public bool PermiteImporte { get; set; }

        public int Decimales { get; set; }
    }
}
