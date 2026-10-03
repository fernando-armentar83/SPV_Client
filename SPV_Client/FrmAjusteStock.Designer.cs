namespace SPV_Client
{
    partial class FrmAjusteStock
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
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblProductoAjuste = new System.Windows.Forms.Label();
            this.txtProductoAjuste = new System.Windows.Forms.TextBox();
            this.btnBuscarProductoAjuste = new System.Windows.Forms.Button();
            this.lblStockSistema = new System.Windows.Forms.Label();
            this.pnlAjuste = new System.Windows.Forms.Panel();
            this.lblAjuste = new System.Windows.Forms.Label();
            this.txtAjuste = new System.Windows.Forms.TextBox();
            this.lblStockResultante = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservacionesAjuste = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnGuardarAjuste = new System.Windows.Forms.Button();
            this.btnCerrarAjuste = new System.Windows.Forms.Button();
            this.pnlBusqueda.SuspendLayout();
            this.pnlAjuste.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.Honeydew;
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusqueda.Controls.Add(this.lblInfo);
            this.pnlBusqueda.Controls.Add(this.lblStockSistema);
            this.pnlBusqueda.Controls.Add(this.btnBuscarProductoAjuste);
            this.pnlBusqueda.Controls.Add(this.txtProductoAjuste);
            this.pnlBusqueda.Controls.Add(this.lblProductoAjuste);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 0);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(800, 123);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // lblProductoAjuste
            // 
            this.lblProductoAjuste.AutoSize = true;
            this.lblProductoAjuste.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoAjuste.Location = new System.Drawing.Point(30, 20);
            this.lblProductoAjuste.Name = "lblProductoAjuste";
            this.lblProductoAjuste.Size = new System.Drawing.Size(95, 25);
            this.lblProductoAjuste.TabIndex = 0;
            this.lblProductoAjuste.Text = "Producto:";
            // 
            // txtProductoAjuste
            // 
            this.txtProductoAjuste.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoAjuste.Location = new System.Drawing.Point(131, 20);
            this.txtProductoAjuste.Name = "txtProductoAjuste";
            this.txtProductoAjuste.ReadOnly = true;
            this.txtProductoAjuste.Size = new System.Drawing.Size(340, 29);
            this.txtProductoAjuste.TabIndex = 1;
            // 
            // btnBuscarProductoAjuste
            // 
            this.btnBuscarProductoAjuste.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarProductoAjuste.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoAjuste.Location = new System.Drawing.Point(480, 19);
            this.btnBuscarProductoAjuste.Name = "btnBuscarProductoAjuste";
            this.btnBuscarProductoAjuste.Size = new System.Drawing.Size(110, 35);
            this.btnBuscarProductoAjuste.TabIndex = 2;
            this.btnBuscarProductoAjuste.Text = "Buscar (F2)";
            this.btnBuscarProductoAjuste.UseVisualStyleBackColor = false;
            this.btnBuscarProductoAjuste.Click += new System.EventHandler(this.btnBuscarProductoAjuste_Click);
            // 
            // lblStockSistema
            // 
            this.lblStockSistema.AutoSize = true;
            this.lblStockSistema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockSistema.Location = new System.Drawing.Point(30, 78);
            this.lblStockSistema.Name = "lblStockSistema";
            this.lblStockSistema.Size = new System.Drawing.Size(161, 25);
            this.lblStockSistema.TabIndex = 3;
            this.lblStockSistema.Text = "Stock en Sistema:";
            // 
            // pnlAjuste
            // 
            this.pnlAjuste.BackColor = System.Drawing.Color.MintCream;
            this.pnlAjuste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAjuste.Controls.Add(this.txtObservacionesAjuste);
            this.pnlAjuste.Controls.Add(this.lblObservaciones);
            this.pnlAjuste.Controls.Add(this.lblStockResultante);
            this.pnlAjuste.Controls.Add(this.txtAjuste);
            this.pnlAjuste.Controls.Add(this.lblAjuste);
            this.pnlAjuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAjuste.Location = new System.Drawing.Point(0, 123);
            this.pnlAjuste.Name = "pnlAjuste";
            this.pnlAjuste.Size = new System.Drawing.Size(800, 356);
            this.pnlAjuste.TabIndex = 1;
            // 
            // lblAjuste
            // 
            this.lblAjuste.AutoSize = true;
            this.lblAjuste.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuste.Location = new System.Drawing.Point(30, 20);
            this.lblAjuste.Name = "lblAjuste";
            this.lblAjuste.Size = new System.Drawing.Size(316, 25);
            this.lblAjuste.TabIndex = 0;
            this.lblAjuste.Text = "Ajuste (+ para sumar, - para restar):";
            // 
            // txtAjuste
            // 
            this.txtAjuste.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAjuste.Location = new System.Drawing.Point(350, 20);
            this.txtAjuste.Name = "txtAjuste";
            this.txtAjuste.Size = new System.Drawing.Size(150, 29);
            this.txtAjuste.TabIndex = 1;
            this.txtAjuste.TextChanged += new System.EventHandler(this.txtAjuste_TextChanged);
            // 
            // lblStockResultante
            // 
            this.lblStockResultante.AutoSize = true;
            this.lblStockResultante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockResultante.Location = new System.Drawing.Point(30, 70);
            this.lblStockResultante.Name = "lblStockResultante";
            this.lblStockResultante.Size = new System.Drawing.Size(175, 25);
            this.lblStockResultante.TabIndex = 2;
            this.lblStockResultante.Text = "Stock Resultante: 0";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnCerrarAjuste);
            this.pnlBotones.Controls.Add(this.btnGuardarAjuste);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 387);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(800, 92);
            this.pnlBotones.TabIndex = 2;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(30, 120);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(365, 25);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones (obligatorio si hay ajuste):";
            // 
            // txtObservacionesAjuste
            // 
            this.txtObservacionesAjuste.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesAjuste.Location = new System.Drawing.Point(30, 160);
            this.txtObservacionesAjuste.Multiline = true;
            this.txtObservacionesAjuste.Name = "txtObservacionesAjuste";
            this.txtObservacionesAjuste.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtObservacionesAjuste.Size = new System.Drawing.Size(734, 80);
            this.txtObservacionesAjuste.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(669, 88);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(87, 25);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "InfoClick";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // btnGuardarAjuste
            // 
            this.btnGuardarAjuste.BackColor = System.Drawing.Color.Cyan;
            this.btnGuardarAjuste.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAjuste.Location = new System.Drawing.Point(155, 9);
            this.btnGuardarAjuste.Name = "btnGuardarAjuste";
            this.btnGuardarAjuste.Size = new System.Drawing.Size(125, 71);
            this.btnGuardarAjuste.TabIndex = 0;
            this.btnGuardarAjuste.Text = "Guardar Ajuste";
            this.btnGuardarAjuste.UseVisualStyleBackColor = false;
            this.btnGuardarAjuste.Click += new System.EventHandler(this.btnGuardarAjuste_Click);
            // 
            // btnCerrarAjuste
            // 
            this.btnCerrarAjuste.BackColor = System.Drawing.Color.Cyan;
            this.btnCerrarAjuste.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarAjuste.Location = new System.Drawing.Point(452, 9);
            this.btnCerrarAjuste.Name = "btnCerrarAjuste";
            this.btnCerrarAjuste.Size = new System.Drawing.Size(125, 71);
            this.btnCerrarAjuste.TabIndex = 1;
            this.btnCerrarAjuste.Text = "Cerrar";
            this.btnCerrarAjuste.UseVisualStyleBackColor = false;
            this.btnCerrarAjuste.Click += new System.EventHandler(this.btnCerrarAjuste_Click);
            // 
            // FrmAjusteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlAjuste);
            this.Controls.Add(this.pnlBusqueda);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAjusteStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Ajuste ";
            this.Load += new System.EventHandler(this.FrmAjusteStock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAjusteStock_KeyDown);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlAjuste.ResumeLayout(false);
            this.pnlAjuste.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txtProductoAjuste;
        private System.Windows.Forms.Label lblProductoAjuste;
        private System.Windows.Forms.Button btnBuscarProductoAjuste;
        private System.Windows.Forms.Label lblStockSistema;
        private System.Windows.Forms.Panel pnlAjuste;
        private System.Windows.Forms.TextBox txtAjuste;
        private System.Windows.Forms.Label lblAjuste;
        private System.Windows.Forms.Label lblStockResultante;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.TextBox txtObservacionesAjuste;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnGuardarAjuste;
        private System.Windows.Forms.Button btnCerrarAjuste;
    }
}