using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPV_Client
{
    public static class SesionActual
    {
        public static bool HaySesion =>
            Session.IdUsuario != 0;

        public static bool EsAdministrador =>
            Session.NombreRol == "Administrador";

        public static bool EsSupervisor =>
            Session.NombreRol == "Supervisor";

        public static bool EsCajero =>
            Session.NombreRol == "Cajero";

        public static int IdUsuario =>
            Session.IdUsuario;

        public static int IdRol =>
            Session.IdRol;

        public static int IdTurno =>
            Session.IdTurno;

        public static string Usuario =>
            Session.NombreUsuario;

        public static string Rol =>
            Session.NombreRol;
    }
}
