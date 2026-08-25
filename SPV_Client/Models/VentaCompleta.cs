using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SPV_Client.Models
{
    public class VentaCompleta
    {
        public int IdUsuario { get; set; }

        public int IdTurno { get; set; }

        

        public int? IdSocio { get; set; }

        public decimal Total { get; set; }

        public decimal DescuentoGeneral { get; set; }

        public List<VentaDetalle> Detalle { get; set; }

        public VentaPago Pago { get; set; }

        public VentaCompleta()
        {
            Detalle = new List<VentaDetalle>();

            Pago = new VentaPago();
        }
    }
}