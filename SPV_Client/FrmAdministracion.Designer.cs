namespace SPV_Client
{
    partial class FrmAdministracion
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
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.btnAbrirArqueo = new System.Windows.Forms.Button();
            this.pnlencabezado = new System.Windows.Forms.Panel();
            this.pnlOperacion = new System.Windows.Forms.Panel();
            this.pnlencabezado.SuspendLayout();
            this.pnlOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(166, 20);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(358, 32);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "PANEL DEL ADMINISTRADOR.";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.BackColor = System.Drawing.Color.MintCream;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Location = new System.Drawing.Point(656, 23);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(34, 22);
            this.lblUsuarioActivo.TabIndex = 1;
            this.lblUsuarioActivo.Text = "---";
            // 
            // btnAbrirArqueo
            // 
            this.btnAbrirArqueo.Location = new System.Drawing.Point(100, 53);
            this.btnAbrirArqueo.Name = "btnAbrirArqueo";
            this.btnAbrirArqueo.Size = new System.Drawing.Size(162, 64);
            this.btnAbrirArqueo.TabIndex = 2;
            this.btnAbrirArqueo.Text = "Arqueo de turno";
            this.btnAbrirArqueo.UseVisualStyleBackColor = true;
            this.btnAbrirArqueo.Click += new System.EventHandler(this.btnAbrirArqueo_Click);
            // 
            // pnlencabezado
            // 
            this.pnlencabezado.BackColor = System.Drawing.Color.LightCyan;
            this.pnlencabezado.Controls.Add(this.lblEncabezado);
            this.pnlencabezado.Controls.Add(this.lblUsuarioActivo);
            this.pnlencabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlencabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlencabezado.Name = "pnlencabezado";
            this.pnlencabezado.Size = new System.Drawing.Size(800, 70);
            this.pnlencabezado.TabIndex = 3;
            // 
            // pnlOperacion
            // 
            this.pnlOperacion.BackColor = System.Drawing.Color.Honeydew;
            this.pnlOperacion.Controls.Add(this.btnAbrirArqueo);
            this.pnlOperacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperacion.Location = new System.Drawing.Point(0, 70);
            this.pnlOperacion.Name = "pnlOperacion";
            this.pnlOperacion.Size = new System.Drawing.Size(800, 380);
            this.pnlOperacion.TabIndex = 4;
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOperacion);
            this.Controls.Add(this.pnlencabezado);
            this.Name = "FrmAdministracion";
            this.ShowIcon = false;
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.FrmAdministracion_Load);
            this.pnlencabezado.ResumeLayout(false);
            this.pnlencabezado.PerformLayout();
            this.pnlOperacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Button btnAbrirArqueo;
        private System.Windows.Forms.Panel pnlencabezado;
        private System.Windows.Forms.Panel pnlOperacion;
    }
}