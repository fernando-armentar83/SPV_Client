using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPV_Client.Helpers;

namespace SPV_Client
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // 🔹 BOTÓN ABRIR SESIÓN
        private void btnAbrirSesion_Click(object sender, EventArgs e)
        {
            using (var login = new LoginForm())
            {
                var result = login.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Bienvenido " + Session.NombreUsuario, "Sesión iniciada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EstadoMenu.Actualizar(this);
                    //ActualizarEstadoMenu();


                }
            }
        }

        // 🟢 BOTÓN CONFIGURACIÓN
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (!AccesoModulo(Modulos.Administracion))
                return;

            FormManager.AbrirFormularioUnico<FrmConfiguracion>();
        }

        // 🟡 BOTÓN INFORMES
        private void btnInformes_Click(object sender, EventArgs e)
        {
            if (!AccesoModulo(Modulos.Informes))
                return;

            FormManager.AbrirFormularioUnico<FrmInformes>();
        }

        

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCierreSesion())
            {
                var result = frm.ShowDialog(); // modal: no permite usar menú hasta cerrar corte

                // opcional: si el cierre confirmó y cerró sesión, puedes actuar aquí
                // if (result == DialogResult.OK) { ... }
            }
        }

        private void ActualizarEstadoMenu()
        {
            btnAbrirSesion.Enabled = !SesionActual.HaySesion;
            btnCerrarSesion.Enabled = SesionActual.HaySesion;

            btnVentas.Enabled = true;
            btnCompras.Enabled = true;
            btnAdministración.Enabled = true;
            btnInformes.Enabled = true;

            EstadoMenu.Actualizar(this);
        }

        private bool AccesoModulo(Modulos modulo)
        {
            return AccesoSistema.AccesoModulo(modulo);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            EstadoMenu.Actualizar(this);
            //ActualizarEstadoMenu();

        }



        /*private void button1_Click(object sender, EventArgs e)
        {
            // ADMIN entra directo
            if (Session.NombreRol == "Administrador")
            {
                FrmCompras frm = new FrmCompras();
                frm.ShowDialog();
                return;
            }

            // Otros usuarios requieren autorización
            using (FrmLoginTemporal frmAuth = new FrmLoginTemporal("COMPRAS"))
            {
                if (frmAuth.ShowDialog() == DialogResult.OK)
                {
                    FrmCompras frm = new FrmCompras();
                    frm.ShowDialog();
                }
            }

        }*/

        private void btnCompras_Click(object sender, EventArgs e)
        {

            if (!AccesoModulo(Modulos.Compras))
                return;

            FormManager.AbrirFormularioUnico<FrmCompras>();

        }

        private void pnlEstadoSistema_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (!AccesoModulo(Modulos.Ventas))
                return;


            FormManager.AbrirFormularioUnico<FrmVenta>();

        }

        public void CambiarEstadoSesion(bool sesionActiva)
        {
            lblEstadoSesion.Text = sesionActiva ? "Sesión abierta" : "Sin sesión";

            lblEstadoCirculo.Text = "●";
            lblEstadoCirculo.ForeColor = sesionActiva
                ? Color.LimeGreen
                : Color.Red;
        }
        public string EstadoSesion
        {
            get => lblEstadoSesion.Text;
            set => lblEstadoSesion.Text = value;
        }

        public string EstadoCirculo
        {
            get => lblEstadoCirculo.Text;
            set => lblEstadoCirculo.Text = value;
        }

        public string UsuarioActivo
        {
            get => lblUsuarioActivo.Text;
            set => lblUsuarioActivo.Text = value;
        }

        public string RolActivo
        {
            get => lblRolActivo.Text;
            set => lblRolActivo.Text = value;
        }

        public string TurnoActivo
        {
            get => lblTurnoActivo.Text;
            set => lblTurnoActivo.Text = value;
        }
    }

}

