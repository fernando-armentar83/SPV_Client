namespace SPV_Client
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlEstadoSistema = new System.Windows.Forms.Panel();
            this.lblEstadoCirculo = new System.Windows.Forms.Label();
            this.lblEstadoSesion = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblTurnoActivo = new System.Windows.Forms.Label();
            this.lblTurnoTitulo = new System.Windows.Forms.Label();
            this.lblRolActivo = new System.Windows.Forms.Label();
            this.lblRolTitulo = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.lblUsuarioTitulo = new System.Windows.Forms.Label();
            this.lblTituloEstado = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnAdministración = new System.Windows.Forms.Button();
            this.btnAbrirSesion = new System.Windows.Forms.Button();
            this.pnlEstadoSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.MintCream;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(23, 157);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(2, 25);
            this.lblFecha.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.MintCream;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(23, 193);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(2, 25);
            this.lblHora.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlEstadoSistema
            // 
            this.pnlEstadoSistema.BackColor = System.Drawing.Color.MintCream;
            this.pnlEstadoSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstadoSistema.Controls.Add(this.lblEstadoCirculo);
            this.pnlEstadoSistema.Controls.Add(this.lblEstadoSesion);
            this.pnlEstadoSistema.Controls.Add(this.lblEstadoTitulo);
            this.pnlEstadoSistema.Controls.Add(this.lblTurnoActivo);
            this.pnlEstadoSistema.Controls.Add(this.lblTurnoTitulo);
            this.pnlEstadoSistema.Controls.Add(this.lblRolActivo);
            this.pnlEstadoSistema.Controls.Add(this.lblRolTitulo);
            this.pnlEstadoSistema.Controls.Add(this.lblUsuarioActivo);
            this.pnlEstadoSistema.Controls.Add(this.lblUsuarioTitulo);
            this.pnlEstadoSistema.Controls.Add(this.lblTituloEstado);
            this.pnlEstadoSistema.Controls.Add(this.lblFecha);
            this.pnlEstadoSistema.Controls.Add(this.lblHora);
            this.pnlEstadoSistema.Location = new System.Drawing.Point(848, 3);
            this.pnlEstadoSistema.Name = "pnlEstadoSistema";
            this.pnlEstadoSistema.Size = new System.Drawing.Size(428, 230);
            this.pnlEstadoSistema.TabIndex = 11;
            this.pnlEstadoSistema.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEstadoSistema_Paint);
            // 
            // lblEstadoCirculo
            // 
            this.lblEstadoCirculo.AutoSize = true;
            this.lblEstadoCirculo.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoCirculo.Font = new System.Drawing.Font("Segoe UI Symbol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCirculo.ForeColor = System.Drawing.Color.Red;
            this.lblEstadoCirculo.Location = new System.Drawing.Point(247, 122);
            this.lblEstadoCirculo.Name = "lblEstadoCirculo";
            this.lblEstadoCirculo.Size = new System.Drawing.Size(25, 21);
            this.lblEstadoCirculo.TabIndex = 15;
            this.lblEstadoCirculo.Text = "🔴";
            // 
            // lblEstadoSesion
            // 
            this.lblEstadoSesion.AutoSize = true;
            this.lblEstadoSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoSesion.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoSesion.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoSesion.Location = new System.Drawing.Point(94, 122);
            this.lblEstadoSesion.Name = "lblEstadoSesion";
            this.lblEstadoSesion.Size = new System.Drawing.Size(122, 25);
            this.lblEstadoSesion.TabIndex = 14;
            this.lblEstadoSesion.Text = "Sin sesión";
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTitulo.Location = new System.Drawing.Point(22, 124);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(72, 19);
            this.lblEstadoTitulo.TabIndex = 13;
            this.lblEstadoTitulo.Text = "Estado:";
            // 
            // lblTurnoActivo
            // 
            this.lblTurnoActivo.AutoSize = true;
            this.lblTurnoActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTurnoActivo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoActivo.Location = new System.Drawing.Point(95, 87);
            this.lblTurnoActivo.Name = "lblTurnoActivo";
            this.lblTurnoActivo.Size = new System.Drawing.Size(92, 30);
            this.lblTurnoActivo.TabIndex = 12;
            this.lblTurnoActivo.Text = "------";
            // 
            // lblTurnoTitulo
            // 
            this.lblTurnoTitulo.AutoSize = true;
            this.lblTurnoTitulo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoTitulo.Location = new System.Drawing.Point(31, 91);
            this.lblTurnoTitulo.Name = "lblTurnoTitulo";
            this.lblTurnoTitulo.Size = new System.Drawing.Size(63, 19);
            this.lblTurnoTitulo.TabIndex = 11;
            this.lblTurnoTitulo.Text = "Turno:";
            // 
            // lblRolActivo
            // 
            this.lblRolActivo.AutoSize = true;
            this.lblRolActivo.BackColor = System.Drawing.Color.Black;
            this.lblRolActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRolActivo.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolActivo.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblRolActivo.Location = new System.Drawing.Point(295, 42);
            this.lblRolActivo.Name = "lblRolActivo";
            this.lblRolActivo.Size = new System.Drawing.Size(122, 28);
            this.lblRolActivo.TabIndex = 10;
            this.lblRolActivo.Text = "---------";
            this.lblRolActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRolTitulo
            // 
            this.lblRolTitulo.AutoSize = true;
            this.lblRolTitulo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolTitulo.Location = new System.Drawing.Point(253, 47);
            this.lblRolTitulo.Name = "lblRolTitulo";
            this.lblRolTitulo.Size = new System.Drawing.Size(54, 19);
            this.lblRolTitulo.TabIndex = 9;
            this.lblRolTitulo.Text = "Rol :";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.BackColor = System.Drawing.Color.Black;
            this.lblUsuarioActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(99, 42);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(131, 30);
            this.lblUsuarioActivo.TabIndex = 8;
            this.lblUsuarioActivo.Text = "---------";
            // 
            // lblUsuarioTitulo
            // 
            this.lblUsuarioTitulo.AutoSize = true;
            this.lblUsuarioTitulo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioTitulo.Location = new System.Drawing.Point(16, 45);
            this.lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            this.lblUsuarioTitulo.Size = new System.Drawing.Size(90, 22);
            this.lblUsuarioTitulo.TabIndex = 7;
            this.lblUsuarioTitulo.Text = "Usuario:";
            // 
            // lblTituloEstado
            // 
            this.lblTituloEstado.AutoSize = true;
            this.lblTituloEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEstado.Location = new System.Drawing.Point(30, 8);
            this.lblTituloEstado.Name = "lblTituloEstado";
            this.lblTituloEstado.Size = new System.Drawing.Size(221, 28);
            this.lblTituloEstado.TabIndex = 6;
            this.lblTituloEstado.Text = "ESTADO DEL SISTEMA";
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.MintCream;
            this.btnVentas.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Image = global::SPV_Client.Properties.Resources.point_of_sale__2_;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.Location = new System.Drawing.Point(15, 207);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(160, 83);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.MintCream;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompras.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Image = global::SPV_Client.Properties.Resources.shopping_cart_32px1;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompras.Location = new System.Drawing.Point(15, 109);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(160, 72);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = global::SPV_Client.Properties.Resources.room__1_;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 320);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(160, 83);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.MintCream;
            this.lblBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBienvenida.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Image = global::SPV_Client.Properties.Resources.point_of_sale__1_;
            this.lblBienvenida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBienvenida.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblBienvenida.Location = new System.Drawing.Point(458, 28);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(237, 72);
            this.lblBienvenida.TabIndex = 10;
            this.lblBienvenida.Text = "MENÚ";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.MintCream;
            this.btnInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInformes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Image = global::SPV_Client.Properties.Resources.list;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformes.Location = new System.Drawing.Point(15, 562);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(168, 75);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "Informes de Ventas";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnAdministración
            // 
            this.btnAdministración.BackColor = System.Drawing.Color.MintCream;
            this.btnAdministración.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdministración.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministración.Image = global::SPV_Client.Properties.Resources.folder;
            this.btnAdministración.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdministración.Location = new System.Drawing.Point(12, 436);
            this.btnAdministración.Name = "btnAdministración";
            this.btnAdministración.Size = new System.Drawing.Size(160, 81);
            this.btnAdministración.TabIndex = 4;
            this.btnAdministración.Text = "Administración";
            this.btnAdministración.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministración.UseVisualStyleBackColor = false;
            this.btnAdministración.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnAbrirSesion
            // 
            this.btnAbrirSesion.BackColor = System.Drawing.Color.MintCream;
            this.btnAbrirSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbrirSesion.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirSesion.Image = global::SPV_Client.Properties.Resources.confirmation__1_;
            this.btnAbrirSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirSesion.Location = new System.Drawing.Point(12, 17);
            this.btnAbrirSesion.Name = "btnAbrirSesion";
            this.btnAbrirSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAbrirSesion.Size = new System.Drawing.Size(160, 72);
            this.btnAbrirSesion.TabIndex = 0;
            this.btnAbrirSesion.Text = "Abrir Sesión";
            this.btnAbrirSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirSesion.UseVisualStyleBackColor = false;
            this.btnAbrirSesion.Click += new System.EventHandler(this.btnAbrirSesion_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1288, 727);
            this.Controls.Add(this.pnlEstadoSistema);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnAdministración);
            this.Controls.Add(this.btnAbrirSesion);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlEstadoSistema.ResumeLayout(false);
            this.pnlEstadoSistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirSesion;
        private System.Windows.Forms.Button btnAdministración;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel pnlEstadoSistema;
        private System.Windows.Forms.Label lblTituloEstado;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioTitulo;
        private System.Windows.Forms.Label lblRolActivo;
        private System.Windows.Forms.Label lblRolTitulo;
        private System.Windows.Forms.Label lblTurnoActivo;
        private System.Windows.Forms.Label lblTurnoTitulo;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoSesion;
        private System.Windows.Forms.Label lblEstadoCirculo;
    }
}