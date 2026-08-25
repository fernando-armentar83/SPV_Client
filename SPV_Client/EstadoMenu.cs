using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SPV_Client
{
    public static class EstadoMenu
    {
        public static void Actualizar(FrmMenu menu)
        {
            bool sesionActiva = SesionActual.HaySesion;

            menu.CambiarEstadoSesion(sesionActiva);

            menu.UsuarioActivo = sesionActiva
                ? SesionActual.Usuario
                : "-----";

            menu.RolActivo = sesionActiva
                ? SesionActual.Rol
                : "-----";

            menu.TurnoActivo = sesionActiva
                ? SesionActual.IdTurno.ToString()
                : "-----";
        }
    }
}
