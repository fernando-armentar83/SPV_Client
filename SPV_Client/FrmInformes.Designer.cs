namespace SPV_Client
{
    partial class FrmInformes
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
            this.btnCatalogoProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANEL DE INFORMES DE VENTAS.";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.BackColor = System.Drawing.Color.MintCream;
            this.lblUsuarioActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Location = new System.Drawing.Point(538, 33);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(2, 24);
            this.lblUsuarioActivo.TabIndex = 1;
            // 
            // btnCatalogoProductos
            // 
            this.btnCatalogoProductos.BackColor = System.Drawing.Color.MintCream;
            this.btnCatalogoProductos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogoProductos.Location = new System.Drawing.Point(68, 129);
            this.btnCatalogoProductos.Name = "btnCatalogoProductos";
            this.btnCatalogoProductos.Size = new System.Drawing.Size(96, 87);
            this.btnCatalogoProductos.TabIndex = 2;
            this.btnCatalogoProductos.Text = "Catálogo de productos";
            this.btnCatalogoProductos.UseVisualStyleBackColor = false;
            this.btnCatalogoProductos.Click += new System.EventHandler(this.btnCatalogoProductos_Click);
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCatalogoProductos);
            this.Controls.Add(this.lblUsuarioActivo);
            this.Controls.Add(this.label1);
            this.Name = "FrmInformes";
            this.Text = "FrmInformes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Button btnCatalogoProductos;
    }
}