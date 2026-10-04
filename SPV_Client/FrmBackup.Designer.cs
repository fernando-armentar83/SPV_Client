namespace SPV_Client
{
    partial class FrmBackup
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRutaMysqldump = new System.Windows.Forms.TextBox();
            this.btnBuscarMysqldump = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtCarpetaDestino = new System.Windows.Forms.TextBox();
            this.btnBuscarCarpeta = new System.Windows.Forms.Button();
            this.lblInfoBackup = new System.Windows.Forms.Label();
            this.btnEjecutarBackup = new System.Windows.Forms.Button();
            this.btnCerrarBackup = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Honeydew;
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(579, 70);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(81, 15);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(394, 38);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "RESPALDAR BASE DE DATOS";
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.MintCream;
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.btnCerrarBackup);
            this.pnlControles.Controls.Add(this.btnEjecutarBackup);
            this.pnlControles.Controls.Add(this.lblInfoBackup);
            this.pnlControles.Controls.Add(this.btnBuscarCarpeta);
            this.pnlControles.Controls.Add(this.txtCarpetaDestino);
            this.pnlControles.Controls.Add(this.lblDestino);
            this.pnlControles.Controls.Add(this.btnBuscarMysqldump);
            this.pnlControles.Controls.Add(this.txtRutaMysqldump);
            this.pnlControles.Controls.Add(this.lblRuta);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControles.Location = new System.Drawing.Point(0, 70);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(579, 380);
            this.pnlControles.TabIndex = 1;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(20, 20);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(222, 25);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta de mysqldump.exe:";
            // 
            // txtRutaMysqldump
            // 
            this.txtRutaMysqldump.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaMysqldump.Location = new System.Drawing.Point(20, 50);
            this.txtRutaMysqldump.Name = "txtRutaMysqldump";
            this.txtRutaMysqldump.Size = new System.Drawing.Size(400, 29);
            this.txtRutaMysqldump.TabIndex = 1;
            // 
            // btnBuscarMysqldump
            // 
            this.btnBuscarMysqldump.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarMysqldump.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMysqldump.Location = new System.Drawing.Point(430, 50);
            this.btnBuscarMysqldump.Name = "btnBuscarMysqldump";
            this.btnBuscarMysqldump.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarMysqldump.TabIndex = 2;
            this.btnBuscarMysqldump.Text = ". . .";
            this.btnBuscarMysqldump.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarMysqldump.UseVisualStyleBackColor = false;
            this.btnBuscarMysqldump.Click += new System.EventHandler(this.btnBuscarMysqldump_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(20, 100);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(177, 25);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Carpeta de destino:";
            // 
            // txtCarpetaDestino
            // 
            this.txtCarpetaDestino.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarpetaDestino.Location = new System.Drawing.Point(20, 135);
            this.txtCarpetaDestino.Name = "txtCarpetaDestino";
            this.txtCarpetaDestino.Size = new System.Drawing.Size(400, 29);
            this.txtCarpetaDestino.TabIndex = 4;
            // 
            // btnBuscarCarpeta
            // 
            this.btnBuscarCarpeta.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarCarpeta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCarpeta.Location = new System.Drawing.Point(430, 135);
            this.btnBuscarCarpeta.Name = "btnBuscarCarpeta";
            this.btnBuscarCarpeta.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarCarpeta.TabIndex = 5;
            this.btnBuscarCarpeta.Text = ". . .";
            this.btnBuscarCarpeta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarCarpeta.UseVisualStyleBackColor = false;
            this.btnBuscarCarpeta.Click += new System.EventHandler(this.btnBuscarCarpeta_Click);
            // 
            // lblInfoBackup
            // 
            this.lblInfoBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoBackup.Location = new System.Drawing.Point(20, 180);
            this.lblInfoBackup.Name = "lblInfoBackup";
            this.lblInfoBackup.Size = new System.Drawing.Size(450, 23);
            this.lblInfoBackup.TabIndex = 6;
            // 
            // btnEjecutarBackup
            // 
            this.btnEjecutarBackup.BackColor = System.Drawing.Color.Cyan;
            this.btnEjecutarBackup.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutarBackup.Location = new System.Drawing.Point(85, 250);
            this.btnEjecutarBackup.Name = "btnEjecutarBackup";
            this.btnEjecutarBackup.Size = new System.Drawing.Size(160, 40);
            this.btnEjecutarBackup.TabIndex = 7;
            this.btnEjecutarBackup.Text = "Generar Respaldo";
            this.btnEjecutarBackup.UseVisualStyleBackColor = false;
            this.btnEjecutarBackup.Click += new System.EventHandler(this.btnEjecutarBackup_Click);
            // 
            // btnCerrarBackup
            // 
            this.btnCerrarBackup.BackColor = System.Drawing.Color.Cyan;
            this.btnCerrarBackup.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBackup.Location = new System.Drawing.Point(315, 250);
            this.btnCerrarBackup.Name = "btnCerrarBackup";
            this.btnCerrarBackup.Size = new System.Drawing.Size(90, 40);
            this.btnCerrarBackup.TabIndex = 8;
            this.btnCerrarBackup.Text = "Cerrar";
            this.btnCerrarBackup.UseVisualStyleBackColor = false;
            this.btnCerrarBackup.Click += new System.EventHandler(this.btnCerrarBackup_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlEncabezado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respaldar Base";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.TextBox txtRutaMysqldump;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnBuscarMysqldump;
        private System.Windows.Forms.TextBox txtCarpetaDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnBuscarCarpeta;
        private System.Windows.Forms.Button btnEjecutarBackup;
        private System.Windows.Forms.Label lblInfoBackup;
        private System.Windows.Forms.Button btnCerrarBackup;
    }
}