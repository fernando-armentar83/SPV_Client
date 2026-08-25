using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SPV_Client
{
    public static class AccesoSistema
    {
        public static bool AccesoModulo(Modulos modulo)
        {
            // ============================
            // MÓDULOS QUE REQUIEREN SESIÓN
            // ============================
            if ((modulo == Modulos.Ventas ||
                 modulo == Modulos.Compras)
                && SesionActual.IdUsuario == 0)
            {
                MessageBox.Show(
                    "Debes iniciar sesión para acceder a este módulo.",
                    "Sesión requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            switch (modulo)
            {
                // ============================
                // VENTAS
                // ============================
                case Modulos.Ventas:
                    return true;

                // ============================
                // COMPRAS
                // ============================
                case Modulos.Compras:

                    // Administrador entra directo
                    if (SesionActual.EsAdministrador)
                        return true;

                    // Otros usuarios requieren autorización
                    using (FrmLoginTemporal frm = new FrmLoginTemporal("COMPRAS"))
                    {
                        return frm.ShowDialog() == DialogResult.OK;
                    }

                // ============================
                // ADMINISTRACIÓN
                // ============================
                case Modulos.Administracion:

                    if (SesionActual.EsAdministrador)
                        return true;

                    using (FrmLoginTemporal frm = new FrmLoginTemporal("ADMINISTRACION"))
                    {
                        return frm.ShowDialog() == DialogResult.OK;
                    }

                // ============================
                // INFORMES
                // ============================
                case Modulos.Informes:

                    if (SesionActual.EsAdministrador ||
                        SesionActual.EsSupervisor)
                        return true;

                    using (FrmLoginTemporal frm = new FrmLoginTemporal("INFORMES"))
                    {
                        return frm.ShowDialog() == DialogResult.OK;
                    }

                default:
                    return true;
            }
        }
    }
}
