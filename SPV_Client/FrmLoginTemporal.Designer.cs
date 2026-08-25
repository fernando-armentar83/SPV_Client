namespace SPV_Client
{
    partial class FrmLoginTemporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginTemporal));
            this.lblUsuTem = new System.Windows.Forms.Label();
            this.txtUsuarioT = new System.Windows.Forms.TextBox();
            this.lblContraTem = new System.Windows.Forms.Label();
            this.txtPasswordT = new System.Windows.Forms.TextBox();
            this.btnAutorizarT = new System.Windows.Forms.Button();
            this.btnCancelarT = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblModulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuTem
            // 
            this.lblUsuTem.AutoSize = true;
            this.lblUsuTem.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuTem.Location = new System.Drawing.Point(96, 76);
            this.lblUsuTem.Name = "lblUsuTem";
            this.lblUsuTem.Size = new System.Drawing.Size(81, 19);
            this.lblUsuTem.TabIndex = 0;
            this.lblUsuTem.Text = "Usuario:";
            // 
            // txtUsuarioT
            // 
            this.txtUsuarioT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioT.Location = new System.Drawing.Point(196, 71);
            this.txtUsuarioT.Name = "txtUsuarioT";
            this.txtUsuarioT.Size = new System.Drawing.Size(170, 32);
            this.txtUsuarioT.TabIndex = 1;
            // 
            // lblContraTem
            // 
            this.lblContraTem.AutoSize = true;
            this.lblContraTem.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraTem.Location = new System.Drawing.Point(83, 122);
            this.lblContraTem.Name = "lblContraTem";
            this.lblContraTem.Size = new System.Drawing.Size(108, 19);
            this.lblContraTem.TabIndex = 2;
            this.lblContraTem.Text = "Contraseña:";
            // 
            // txtPasswordT
            // 
            this.txtPasswordT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordT.Location = new System.Drawing.Point(196, 114);
            this.txtPasswordT.Name = "txtPasswordT";
            this.txtPasswordT.PasswordChar = '*';
            this.txtPasswordT.Size = new System.Drawing.Size(170, 32);
            this.txtPasswordT.TabIndex = 3;
            // 
            // btnAutorizarT
            // 
            this.btnAutorizarT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutorizarT.BackgroundImage")));
            this.btnAutorizarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAutorizarT.Location = new System.Drawing.Point(164, 174);
            this.btnAutorizarT.Name = "btnAutorizarT";
            this.btnAutorizarT.Size = new System.Drawing.Size(64, 43);
            this.btnAutorizarT.TabIndex = 4;
            this.btnAutorizarT.UseVisualStyleBackColor = true;
            this.btnAutorizarT.Click += new System.EventHandler(this.btnAutorizarT_Click);
            // 
            // btnCancelarT
            // 
            this.btnCancelarT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarT.BackgroundImage")));
            this.btnCancelarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarT.Location = new System.Drawing.Point(282, 174);
            this.btnCancelarT.Name = "btnCancelarT";
            this.btnCancelarT.Size = new System.Drawing.Size(68, 43);
            this.btnCancelarT.TabIndex = 5;
            this.btnCancelarT.UseVisualStyleBackColor = true;
            this.btnCancelarT.Click += new System.EventHandler(this.btnCancelarT_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(385, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModulo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(19, 19);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(2, 26);
            this.lblModulo.TabIndex = 7;
            // 
            // FrmLoginTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(527, 236);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCancelarT);
            this.Controls.Add(this.btnAutorizarT);
            this.Controls.Add(this.txtPasswordT);
            this.Controls.Add(this.lblContraTem);
            this.Controls.Add(this.txtUsuarioT);
            this.Controls.Add(this.lblUsuTem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoginTemporal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN-TEMP";
            this.Load += new System.EventHandler(this.FrmLoginTemporal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuTem;
        private System.Windows.Forms.TextBox txtUsuarioT;
        private System.Windows.Forms.Label lblContraTem;
        private System.Windows.Forms.TextBox txtPasswordT;
        private System.Windows.Forms.Button btnAutorizarT;
        private System.Windows.Forms.Button btnCancelarT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblModulo;
    }
}