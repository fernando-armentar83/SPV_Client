// Session.cs
namespace SPV_Client
{
    public static class Session
    {
        public static int IdUsuario { get; set; } = 0;
        public static string NombreUsuario { get; set; } = string.Empty;
        public static int IdRol { get; set; } = 0;
        public static string NombreRol { get; set; } = string.Empty;

        public static int IdUsuarioAutoriza { get; set; } = 0;

        public static string NombreUsuarioAutoriza { get; set; } = string.Empty;

        // 🔹 Nuevo campo: identificador del turno activo
        public static int IdTurno { get; set; } = 0;

        // 🔹 Nuevo: monto inicial del turno
        public static decimal MontoInicial { get; set; } = 0;


        // 🔹 Método para limpiar sesión completamente al cerrar
        public static void Clear()
        {
            IdUsuario = 0;
            NombreUsuario = string.Empty;
            IdRol = 0;
            NombreRol = string.Empty;
            IdTurno = 0;
            IdUsuarioAutoriza = 0;
            NombreUsuarioAutoriza = string.Empty;
        }
    }
}
