using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV_Client.Models
{
    public class CierreReimpresion
    {
        public int IdTurno { get; set; }
        public string UsuarioApertura { get; set; }
        public string UsuarioCierre { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }

        public decimal MontoInicial { get; set; }

        public int CantidadArqueos { get; set; }
        public decimal TotalRetiradoArqueos { get; set; }
        public decimal TotalElectronicoArqueos { get; set; }
        public decimal TotalVentasArqueos { get; set; }

        public decimal EfectivoEsperado { get; set; }
        public decimal EfectivoContado { get; set; }
        public decimal DiferenciaEfectivo { get; set; }

        public decimal ElectronicoEsperado { get; set; }
        public decimal ElectronicoContado { get; set; }
        public decimal DiferenciaElectronico { get; set; }

        public decimal TotalVentasHistorico { get; set; }
        public string Observaciones { get; set; }
    }
}
