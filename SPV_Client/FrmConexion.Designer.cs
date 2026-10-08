namespace SPV_Client
{
    partial class FrmConexion
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
            this.pnlControles = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.lblTituloServidor = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnGuardarConexion = new System.Windows.Forms.Button();
            this.btnCerrarConexion = new System.Windows.Forms.Button();
            this.pnlControles.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.lblEstadoConexion);
            this.pnlControles.Controls.Add(this.txtPassword);
            this.pnlControles.Controls.Add(this.lblContraseña);
            this.pnlControles.Controls.Add(this.txtUser);
            this.pnlControles.Controls.Add(this.lblUsuario);
            this.pnlControles.Controls.Add(this.txtDatabase);
            this.pnlControles.Controls.Add(this.lblBaseDatos);
            this.pnlControles.Controls.Add(this.txtPort);
            this.pnlControles.Controls.Add(this.lblPuerto);
            this.pnlControles.Controls.Add(this.txtServer);
            this.pnlControles.Controls.Add(this.lblTituloServidor);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(728, 502);
            this.pnlControles.TabIndex = 0;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCerrarConexion);
            this.pnlBotones.Controls.Add(this.btnGuardarConexion);
            this.pnlBotones.Controls.Add(this.btnProbarConexion);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 372);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(728, 130);
            this.pnlBotones.TabIndex = 1;
            // 
            // lblTituloServidor
            // 
            this.lblTituloServidor.AutoSize = true;
            this.lblTituloServidor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloServidor.Location = new System.Drawing.Point(20, 20);
            this.lblTituloServidor.Name = "lblTituloServidor";
            this.lblTituloServidor.Size = new System.Drawing.Size(220, 22);
            this.lblTituloServidor.TabIndex = 0;
            this.lblTituloServidor.Text = "Servidor (host o IP):";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(242, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(440, 29);
            this.txtServer.TabIndex = 1;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.Location = new System.Drawing.Point(160, 72);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(80, 22);
            this.lblPuerto.TabIndex = 2;
            this.lblPuerto.Text = "Puerto:";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(242, 69);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(150, 29);
            this.txtPort.TabIndex = 3;
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseDatos.Location = new System.Drawing.Point(90, 126);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(150, 22);
            this.lblBaseDatos.TabIndex = 4;
            this.lblBaseDatos.Text = "Base de datos:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(242, 124);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(440, 29);
            this.txtDatabase.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(150, 188);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 22);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(242, 187);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 29);
            this.txtUser.TabIndex = 7;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(120, 246);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(120, 22);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(242, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(300, 29);
            this.txtPassword.TabIndex = 9;
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConexion.Location = new System.Drawing.Point(32, 295);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(600, 74);
            this.lblEstadoConexion.TabIndex = 10;
            this.lblEstadoConexion.Text = "-";
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.BackColor = System.Drawing.Color.MintCream;
            this.btnProbarConexion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarConexion.Location = new System.Drawing.Point(76, 23);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(140, 74);
            this.btnProbarConexion.TabIndex = 0;
            this.btnProbarConexion.Text = "Probar Conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = false;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // btnGuardarConexion
            // 
            this.btnGuardarConexion.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardarConexion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConexion.Location = new System.Drawing.Point(260, 23);
            this.btnGuardarConexion.Name = "btnGuardarConexion";
            this.btnGuardarConexion.Size = new System.Drawing.Size(160, 74);
            this.btnGuardarConexion.TabIndex = 1;
            this.btnGuardarConexion.Text = "Guardar y Reiniciar";
            this.btnGuardarConexion.UseVisualStyleBackColor = false;
            this.btnGuardarConexion.Click += new System.EventHandler(this.btnGuardarConexion_Click);
            // 
            // btnCerrarConexion
            // 
            this.btnCerrarConexion.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarConexion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarConexion.Location = new System.Drawing.Point(460, 23);
            this.btnCerrarConexion.Name = "btnCerrarConexion";
            this.btnCerrarConexion.Size = new System.Drawing.Size(140, 74);
            this.btnCerrarConexion.TabIndex = 2;
            this.btnCerrarConexion.Text = "Cancelar";
            this.btnCerrarConexion.UseVisualStyleBackColor = false;
            this.btnCerrarConexion.Click += new System.EventHandler(this.btnCerrarConexion_Click);
            // 
            // FrmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlControles);
            this.Name = "FrmConexion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion BD";
            this.Load += new System.EventHandler(this.FrmConexion_Load);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblTituloServidor;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblEstadoConexion;
        private System.Windows.Forms.Button btnGuardarConexion;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnCerrarConexion;
    }
}