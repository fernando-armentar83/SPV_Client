namespace SPV_Client
{
    partial class FrmConversionStock
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
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtObservacionesConversion = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblCantidadResultante = new System.Windows.Forms.Label();
            this.txtCantidadOrigen = new System.Windows.Forms.TextBox();
            this.lblConverion = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblConvertir = new System.Windows.Forms.Label();
            this.lblStockOrigen = new System.Windows.Forms.Label();
            this.btnBuscarOrigen = new System.Windows.Forms.Button();
            this.txtProductoOrigen = new System.Windows.Forms.TextBox();
            this.lblProductoOrigen = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCerrarConversion = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Honeydew;
            this.pnlEncabezado.Controls.Add(this.lblTitulo1);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(752, 70);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(179, 15);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(311, 38);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Convertidor de Stock";
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.Azure;
            this.pnlControles.Controls.Add(this.txtObservacionesConversion);
            this.pnlControles.Controls.Add(this.lblObservaciones);
            this.pnlControles.Controls.Add(this.lblCantidadResultante);
            this.pnlControles.Controls.Add(this.txtCantidadOrigen);
            this.pnlControles.Controls.Add(this.lblConverion);
            this.pnlControles.Controls.Add(this.cmbDestino);
            this.pnlControles.Controls.Add(this.lblConvertir);
            this.pnlControles.Controls.Add(this.lblStockOrigen);
            this.pnlControles.Controls.Add(this.btnBuscarOrigen);
            this.pnlControles.Controls.Add(this.txtProductoOrigen);
            this.pnlControles.Controls.Add(this.lblProductoOrigen);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControles.Location = new System.Drawing.Point(0, 70);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(752, 444);
            this.pnlControles.TabIndex = 1;
            // 
            // txtObservacionesConversion
            // 
            this.txtObservacionesConversion.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesConversion.Location = new System.Drawing.Point(181, 326);
            this.txtObservacionesConversion.Multiline = true;
            this.txtObservacionesConversion.Name = "txtObservacionesConversion";
            this.txtObservacionesConversion.Size = new System.Drawing.Size(543, 103);
            this.txtObservacionesConversion.TabIndex = 10;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(20, 361);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(155, 28);
            this.lblObservaciones.TabIndex = 9;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblCantidadResultante
            // 
            this.lblCantidadResultante.AutoSize = true;
            this.lblCantidadResultante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadResultante.Location = new System.Drawing.Point(20, 290);
            this.lblCantidadResultante.Name = "lblCantidadResultante";
            this.lblCantidadResultante.Size = new System.Drawing.Size(123, 25);
            this.lblCantidadResultante.TabIndex = 8;
            this.lblCantidadResultante.Text = "Resultante: 0";
            // 
            // txtCantidadOrigen
            // 
            this.txtCantidadOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadOrigen.Location = new System.Drawing.Point(20, 240);
            this.txtCantidadOrigen.Name = "txtCantidadOrigen";
            this.txtCantidadOrigen.Size = new System.Drawing.Size(150, 31);
            this.txtCantidadOrigen.TabIndex = 7;
            this.txtCantidadOrigen.TextChanged += new System.EventHandler(this.txtCantidadOrigen_TextChanged);
            // 
            // lblConverion
            // 
            this.lblConverion.AutoSize = true;
            this.lblConverion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverion.Location = new System.Drawing.Point(20, 210);
            this.lblConverion.Name = "lblConverion";
            this.lblConverion.Size = new System.Drawing.Size(265, 25);
            this.lblConverion.TabIndex = 6;
            this.lblConverion.Text = "Cantidad a convertir (origen):";
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(20, 155);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(340, 33);
            this.cmbDestino.TabIndex = 5;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // lblConvertir
            // 
            this.lblConvertir.AutoSize = true;
            this.lblConvertir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertir.Location = new System.Drawing.Point(20, 125);
            this.lblConvertir.Name = "lblConvertir";
            this.lblConvertir.Size = new System.Drawing.Size(112, 25);
            this.lblConvertir.TabIndex = 4;
            this.lblConvertir.Text = "Convertir a:";
            // 
            // lblStockOrigen
            // 
            this.lblStockOrigen.AutoSize = true;
            this.lblStockOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockOrigen.Location = new System.Drawing.Point(20, 80);
            this.lblStockOrigen.Name = "lblStockOrigen";
            this.lblStockOrigen.Size = new System.Drawing.Size(172, 25);
            this.lblStockOrigen.TabIndex = 3;
            this.lblStockOrigen.Text = "Stock disponible: 0";
            // 
            // btnBuscarOrigen
            // 
            this.btnBuscarOrigen.BackColor = System.Drawing.Color.MintCream;
            this.btnBuscarOrigen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOrigen.Location = new System.Drawing.Point(370, 44);
            this.btnBuscarOrigen.Name = "btnBuscarOrigen";
            this.btnBuscarOrigen.Size = new System.Drawing.Size(120, 30);
            this.btnBuscarOrigen.TabIndex = 2;
            this.btnBuscarOrigen.Text = "Buscar (F2)";
            this.btnBuscarOrigen.UseVisualStyleBackColor = false;
            this.btnBuscarOrigen.Click += new System.EventHandler(this.btnBuscarOrigen_Click);
            // 
            // txtProductoOrigen
            // 
            this.txtProductoOrigen.BackColor = System.Drawing.Color.White;
            this.txtProductoOrigen.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoOrigen.Location = new System.Drawing.Point(20, 45);
            this.txtProductoOrigen.Name = "txtProductoOrigen";
            this.txtProductoOrigen.ReadOnly = true;
            this.txtProductoOrigen.Size = new System.Drawing.Size(340, 29);
            this.txtProductoOrigen.TabIndex = 1;
            // 
            // lblProductoOrigen
            // 
            this.lblProductoOrigen.AutoSize = true;
            this.lblProductoOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoOrigen.Location = new System.Drawing.Point(20, 20);
            this.lblProductoOrigen.Name = "lblProductoOrigen";
            this.lblProductoOrigen.Size = new System.Drawing.Size(158, 25);
            this.lblProductoOrigen.TabIndex = 0;
            this.lblProductoOrigen.Text = "Producto Origen:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlBotones.Controls.Add(this.btnCerrarConversion);
            this.pnlBotones.Controls.Add(this.btnConvertir);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 518);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(752, 105);
            this.pnlBotones.TabIndex = 2;
            // 
            // btnCerrarConversion
            // 
            this.btnCerrarConversion.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarConversion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarConversion.Location = new System.Drawing.Point(400, 34);
            this.btnCerrarConversion.Name = "btnCerrarConversion";
            this.btnCerrarConversion.Size = new System.Drawing.Size(120, 32);
            this.btnCerrarConversion.TabIndex = 1;
            this.btnCerrarConversion.Text = "Cerrar";
            this.btnCerrarConversion.UseVisualStyleBackColor = false;
            this.btnCerrarConversion.Click += new System.EventHandler(this.btnCerrarConversion_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.MintCream;
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(161, 34);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(120, 32);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // FrmConversionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 623);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlEncabezado);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConversionStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversión Stock";
            this.Load += new System.EventHandler(this.FrmConversionStock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConversionStock_KeyDown);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblProductoOrigen;
        private System.Windows.Forms.Button btnBuscarOrigen;
        private System.Windows.Forms.TextBox txtProductoOrigen;
        private System.Windows.Forms.Label lblStockOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblConvertir;
        private System.Windows.Forms.TextBox txtCantidadOrigen;
        private System.Windows.Forms.Label lblConverion;
        private System.Windows.Forms.Label lblCantidadResultante;
        private System.Windows.Forms.TextBox txtObservacionesConversion;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnCerrarConversion;
    }
}