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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.btnAbrirArqueo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANEL DE CONFIGURACION.";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.BackColor = System.Drawing.Color.MintCream;
            this.lblUsuarioActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Location = new System.Drawing.Point(597, 28);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(2, 24);
            this.lblUsuarioActivo.TabIndex = 1;
            // 
            // btnAbrirArqueo
            // 
            this.btnAbrirArqueo.Location = new System.Drawing.Point(68, 147);
            this.btnAbrirArqueo.Name = "btnAbrirArqueo";
            this.btnAbrirArqueo.Size = new System.Drawing.Size(162, 64);
            this.btnAbrirArqueo.TabIndex = 2;
            this.btnAbrirArqueo.Text = "Arqueo de turno";
            this.btnAbrirArqueo.UseVisualStyleBackColor = true;
            this.btnAbrirArqueo.Click += new System.EventHandler(this.btnAbrirArqueo_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirArqueo);
            this.Controls.Add(this.lblUsuarioActivo);
            this.Controls.Add(this.label1);
            this.Name = "FrmConfiguracion";
            this.ShowIcon = false;
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Button btnAbrirArqueo;
    }
}