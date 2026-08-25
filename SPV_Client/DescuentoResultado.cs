using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV_Client
{
    public class DescuentoResultado
    {
        public decimal Porcentaje { get; set; }

        public decimal ImporteDescuento { get; set; }

        public string TipoDescuento { get; set; }

        public decimal NuevoSubtotal { get; set; }
    }
}
