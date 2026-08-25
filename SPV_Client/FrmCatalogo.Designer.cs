namespace SPV_Client
{
    partial class FrmCatalogo
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
            this.btnProductosCatalogo = new System.Windows.Forms.Button();
            this.btnHistorialVentasCatalogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductosCatalogo
            // 
            this.btnProductosCatalogo.BackColor = System.Drawing.Color.MintCream;
            this.btnProductosCatalogo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosCatalogo.Location = new System.Drawing.Point(12, 35);
            this.btnProductosCatalogo.Name = "btnProductosCatalogo";
            this.btnProductosCatalogo.Size = new System.Drawing.Size(200, 45);
            this.btnProductosCatalogo.TabIndex = 0;
            this.btnProductosCatalogo.Text = "Productos";
            this.btnProductosCatalogo.UseVisualStyleBackColor = false;
            this.btnProductosCatalogo.Click += new System.EventHandler(this.btnProductosCatalogo_Click);
            // 
            // btnHistorialVentasCatalogo
            // 
            this.btnHistorialVentasCatalogo.BackColor = System.Drawing.Color.MintCream;
            this.btnHistorialVentasCatalogo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialVentasCatalogo.Location = new System.Drawing.Point(12, 135);
            this.btnHistorialVentasCatalogo.Name = "btnHistorialVentasCatalogo";
            this.btnHistorialVentasCatalogo.Size = new System.Drawing.Size(200, 45);
            this.btnHistorialVentasCatalogo.TabIndex = 1;
            this.btnHistorialVentasCatalogo.Text = "Historial de ventas";
            this.btnHistorialVentasCatalogo.UseVisualStyleBackColor = false;
            this.btnHistorialVentasCatalogo.Click += new System.EventHandler(this.btnHistorialVentasCatalogo_Click);
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 228);
            this.Controls.Add(this.btnHistorialVentasCatalogo);
            this.Controls.Add(this.btnProductosCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCatalogo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.FrmCatalogo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductosCatalogo;
        private System.Windows.Forms.Button btnHistorialVentasCatalogo;
    }
}