using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV_Client
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            //Application.Run(new FrmMenu());
            //Application.Run(new FrmCatalogoCompras());
            //Application.Run(new FrmDescuento("Producto de prueba", 2, 100, 200));
            Application.Run(new FrmArqueo());
            
        }
    }
}
