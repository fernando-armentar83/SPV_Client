using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV_Client.Helpers
{
    public static class FormManager
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;

        // Formularios con constructor sin parámetros
        public static void AbrirFormularioUnico<T>() where T : Form, new()
        {
            Form frmAbierto = Application.OpenForms
                                         .OfType<T>()
                                         .FirstOrDefault();

            if (frmAbierto != null)
            {
                RestaurarYActivar(frmAbierto);
                return;
            }

            T frm = new T();
            frm.Show();
        }

        // Formularios con constructor que recibe un parámetro
        public static void AbrirFormularioUnico<T>(int parametro) where T : Form
        {
            Form frmAbierto = Application.OpenForms
                                         .OfType<T>()
                                         .FirstOrDefault();

            if (frmAbierto != null)
            {
                RestaurarYActivar(frmAbierto);
                return;
            }

            ConstructorInfo constructor =
                typeof(T).GetConstructor(new Type[] { typeof(int) });

            if (constructor == null)
            {
                throw new InvalidOperationException(
                    $"El formulario {typeof(T).Name} no tiene un constructor que reciba un parámetro int.");
            }

            T frm = (T)constructor.Invoke(new object[] { parametro });
            frm.Show();
        }

        private static void RestaurarYActivar(Form formulario)
        {
            if (formulario.WindowState == FormWindowState.Minimized)
            {
                ShowWindow(formulario.Handle, SW_RESTORE);
            }

            formulario.BringToFront();
            formulario.Activate();
        }
    }
}
