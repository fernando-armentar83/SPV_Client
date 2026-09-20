using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV_Client.Models
{
    public class ArqueoReimpresion
    {
        public string Folio { get; set; }
        public DateTime FechaArqueo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Usuario { get; set; }
        public int IdTurno { get; set; }

        public decimal EfectivoEsperado { get; set; }
        public decimal EfectivoContado { get; set; }
        public decimal DiferenciaEfectivo { get; set; }

        public decimal Electronico { get; set; }
        public decimal ElectronicoComprobado { get; set; }
        public decimal DiferenciaElectronico { get; set; }
        public bool ElectronicoVerificado { get; set; }

        public decimal TotalVentas { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    }
}
