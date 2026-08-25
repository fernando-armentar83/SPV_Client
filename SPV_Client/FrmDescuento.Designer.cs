namespace SPV_Client
{
    partial class FrmDescuento
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
            this.lblProductoDesc = new System.Windows.Forms.Label();
            this.txtProductoDesc = new System.Windows.Forms.TextBox();
            this.lblTipoDesc = new System.Windows.Forms.Label();
            this.cboTipoDescuento = new System.Windows.Forms.ComboBox();
            this.lblValorDesc = new System.Windows.Forms.Label();
            this.txtValorDescuento = new System.Windows.Forms.TextBox();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.btnAceptarDesc = new System.Windows.Forms.Button();
            this.btnCancelarDesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductoDesc
            // 
            this.lblProductoDesc.AutoSize = true;
            this.lblProductoDesc.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoDesc.Location = new System.Drawing.Point(20, 20);
            this.lblProductoDesc.Name = "lblProductoDesc";
            this.lblProductoDesc.Size = new System.Drawing.Size(90, 19);
            this.lblProductoDesc.TabIndex = 0;
            this.lblProductoDesc.Text = "Producto:";
            // 
            // txtProductoDesc
            // 
            this.txtProductoDesc.Location = new System.Drawing.Point(20, 45);
            this.txtProductoDesc.Name = "txtProductoDesc";
            this.txtProductoDesc.ReadOnly = true;
            this.txtProductoDesc.Size = new System.Drawing.Size(330, 26);
            this.txtProductoDesc.TabIndex = 1;
            // 
            // lblTipoDesc
            // 
            this.lblTipoDesc.AutoSize = true;
            this.lblTipoDesc.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDesc.Location = new System.Drawing.Point(20, 88);
            this.lblTipoDesc.Name = "lblTipoDesc";
            this.lblTipoDesc.Size = new System.Drawing.Size(162, 19);
            this.lblTipoDesc.TabIndex = 2;
            this.lblTipoDesc.Text = "Tipo de descuento";
            // 
            // cboTipoDescuento
            // 
            this.cboTipoDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDescuento.FormattingEnabled = true;
            this.cboTipoDescuento.Items.AddRange(new object[] {
            "Porcentaje",
            "Importe"});
            this.cboTipoDescuento.Location = new System.Drawing.Point(188, 84);
            this.cboTipoDescuento.Name = "cboTipoDescuento";
            this.cboTipoDescuento.Size = new System.Drawing.Size(125, 28);
            this.cboTipoDescuento.TabIndex = 3;
            this.cboTipoDescuento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDescuento_SelectedIndexChanged);
            // 
            // lblValorDesc
            // 
            this.lblValorDesc.AutoSize = true;
            this.lblValorDesc.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDesc.Location = new System.Drawing.Point(20, 120);
            this.lblValorDesc.Name = "lblValorDesc";
            this.lblValorDesc.Size = new System.Drawing.Size(54, 19);
            this.lblValorDesc.TabIndex = 4;
            this.lblValorDesc.Text = "Valor";
            // 
            // txtValorDescuento
            // 
            this.txtValorDescuento.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDescuento.Location = new System.Drawing.Point(80, 120);
            this.txtValorDescuento.Name = "txtValorDescuento";
            this.txtValorDescuento.Size = new System.Drawing.Size(100, 26);
            this.txtValorDescuento.TabIndex = 5;
            this.txtValorDescuento.Text = "0";
            this.txtValorDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorDescuento.TextChanged += new System.EventHandler(this.txtValorDescuento_TextChanged);
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblVistaPrevia.Location = new System.Drawing.Point(6, 160);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(384, 32);
            this.lblVistaPrevia.TabIndex = 6;
            this.lblVistaPrevia.Text = "Subtotal después del descuento:";
            // 
            // btnAceptarDesc
            // 
            this.btnAceptarDesc.BackColor = System.Drawing.Color.MintCream;
            this.btnAceptarDesc.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarDesc.Location = new System.Drawing.Point(43, 291);
            this.btnAceptarDesc.Name = "btnAceptarDesc";
            this.btnAceptarDesc.Size = new System.Drawing.Size(100, 40);
            this.btnAceptarDesc.TabIndex = 7;
            this.btnAceptarDesc.Text = "Aceptar";
            this.btnAceptarDesc.UseVisualStyleBackColor = false;
            this.btnAceptarDesc.Click += new System.EventHandler(this.btnAceptarDesc_Click);
            // 
            // btnCancelarDesc
            // 
            this.btnCancelarDesc.BackColor = System.Drawing.Color.MintCream;
            this.btnCancelarDesc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarDesc.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDesc.Location = new System.Drawing.Point(178, 291);
            this.btnCancelarDesc.Name = "btnCancelarDesc";
            this.btnCancelarDesc.Size = new System.Drawing.Size(100, 40);
            this.btnCancelarDesc.TabIndex = 8;
            this.btnCancelarDesc.Text = "Cancelar";
            this.btnCancelarDesc.UseVisualStyleBackColor = false;
            // 
            // FrmDescuento
            // 
            this.AcceptButton = this.btnAceptarDesc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarDesc;
            this.ClientSize = new System.Drawing.Size(410, 360);
            this.Controls.Add(this.btnCancelarDesc);
            this.Controls.Add(this.btnAceptarDesc);
            this.Controls.Add(this.lblVistaPrevia);
            this.Controls.Add(this.txtValorDescuento);
            this.Controls.Add(this.lblValorDesc);
            this.Controls.Add(this.cboTipoDescuento);
            this.Controls.Add(this.lblTipoDesc);
            this.Controls.Add(this.txtProductoDesc);
            this.Controls.Add(this.lblProductoDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDescuento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicar descuento";
            this.Load += new System.EventHandler(this.FrmDescuento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductoDesc;
        private System.Windows.Forms.TextBox txtProductoDesc;
        private System.Windows.Forms.Label lblTipoDesc;
        private System.Windows.Forms.ComboBox cboTipoDescuento;
        private System.Windows.Forms.Label lblValorDesc;
        private System.Windows.Forms.TextBox txtValorDescuento;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.Button btnAceptarDesc;
        private System.Windows.Forms.Button btnCancelarDesc;
    }
}