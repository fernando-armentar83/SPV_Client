using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV_Client.Models
{
    public class CobroResultado
    {
        public decimal Efectivo { get; set; }

        public decimal Tarjeta { get; set; }

        public decimal Transferencia { get; set; }

        public decimal Vale { get; set; }

        public decimal TotalRecibido { get; set; }

        public decimal Cambio { get; set; }

        public decimal TotalVenta { get; set; }
    }
}
