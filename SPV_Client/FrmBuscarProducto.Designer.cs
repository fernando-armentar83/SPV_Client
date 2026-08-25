namespace SPV_Client
{
    partial class FrmBuscarProducto
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
            this.txtBuscarPopup = new System.Windows.Forms.TextBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionarBp = new System.Windows.Forms.Button();
            this.btnCancelarBp = new System.Windows.Forms.Button();
            this.pnlResultados = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.pnlResultados.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarPopup
            // 
            this.txtBuscarPopup.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPopup.Location = new System.Drawing.Point(9, 10);
            this.txtBuscarPopup.Name = "txtBuscarPopup";
            this.txtBuscarPopup.Size = new System.Drawing.Size(752, 30);
            this.txtBuscarPopup.TabIndex = 0;
            this.txtBuscarPopup.TextChanged += new System.EventHandler(this.txtBuscarPopup_TextChanged);
            // 
            // cboFiltro
            // 
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Modelo",
            "Marca",
            "Codigo",
            "Todos"});
            this.cboFiltro.Location = new System.Drawing.Point(9, 55);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(163, 28);
            this.cboFiltro.TabIndex = 1;
            // 
            // lblAyuda
            // 
            this.lblAyuda.BackColor = System.Drawing.Color.MintCream;
            this.lblAyuda.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(788, 10);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(169, 96);
            this.lblAyuda.TabIndex = 2;
            this.lblAyuda.Text = "\"Enter = seleccionar  DblClick = seleccionar  Esc = cerrar\"";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToResizeRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Nombre,
            this.Marca,
            this.Modelo,
            this.PrecioVenta,
            this.StockActual,
            this.CodigoBarras,
            this.precio_compra,
            this.CodigoCompra,
            this.proveedor});
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.GridColor = System.Drawing.Color.MintCream;
            this.dgvResultados.Location = new System.Drawing.Point(3, 3);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(957, 244);
            this.dgvResultados.TabIndex = 3;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
            this.dgvResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvResultados_KeyDown);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "IdProducto";
            this.idProducto.MinimumWidth = 8;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            this.idProducto.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 8;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 150;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.MinimumWidth = 8;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 150;
            // 
            // StockActual
            // 
            this.StockActual.HeaderText = "StockActual";
            this.StockActual.MinimumWidth = 8;
            this.StockActual.Name = "StockActual";
            this.StockActual.ReadOnly = true;
            this.StockActual.Width = 150;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.HeaderText = "CodigoBarras";
            this.CodigoBarras.MinimumWidth = 8;
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            this.CodigoBarras.Width = 150;
            // 
            // precio_compra
            // 
            this.precio_compra.HeaderText = "Precio Compra";
            this.precio_compra.MinimumWidth = 8;
            this.precio_compra.Name = "precio_compra";
            this.precio_compra.ReadOnly = true;
            this.precio_compra.Visible = false;
            this.precio_compra.Width = 150;
            // 
            // CodigoCompra
            // 
            this.CodigoCompra.HeaderText = "Codigo Compra";
            this.CodigoCompra.MinimumWidth = 8;
            this.CodigoCompra.Name = "CodigoCompra";
            this.CodigoCompra.ReadOnly = true;
            this.CodigoCompra.Width = 150;
            // 
            // proveedor
            // 
            this.proveedor.DataPropertyName = "proveedor";
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.MinimumWidth = 8;
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            this.proveedor.Width = 150;
            // 
            // btnSeleccionarBp
            // 
            this.btnSeleccionarBp.Location = new System.Drawing.Point(214, 11);
            this.btnSeleccionarBp.Name = "btnSeleccionarBp";
            this.btnSeleccionarBp.Size = new System.Drawing.Size(102, 37);
            this.btnSeleccionarBp.TabIndex = 4;
            this.btnSeleccionarBp.Text = "Seleccionar";
            this.btnSeleccionarBp.UseVisualStyleBackColor = true;
            this.btnSeleccionarBp.Click += new System.EventHandler(this.btnSeleccionarBp_Click);
            // 
            // btnCancelarBp
            // 
            this.btnCancelarBp.Location = new System.Drawing.Point(436, 11);
            this.btnCancelarBp.Name = "btnCancelarBp";
            this.btnCancelarBp.Size = new System.Drawing.Size(90, 34);
            this.btnCancelarBp.TabIndex = 5;
            this.btnCancelarBp.Text = "Cancelar";
            this.btnCancelarBp.UseVisualStyleBackColor = true;
            this.btnCancelarBp.Click += new System.EventHandler(this.btnCancelarBp_Click);
            // 
            // pnlResultados
            // 
            this.pnlResultados.ColumnCount = 1;
            this.pnlResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlResultados.Controls.Add(this.dgvResultados, 0, 0);
            this.pnlResultados.Location = new System.Drawing.Point(0, 131);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.RowCount = 1;
            this.pnlResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlResultados.Size = new System.Drawing.Size(963, 250);
            this.pnlResultados.TabIndex = 6;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.lblAyuda);
            this.pnlBusqueda.Controls.Add(this.txtBuscarPopup);
            this.pnlBusqueda.Controls.Add(this.cboFiltro);
            this.pnlBusqueda.Location = new System.Drawing.Point(3, 9);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(960, 116);
            this.pnlBusqueda.TabIndex = 7;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnSeleccionarBp);
            this.pnlBotones.Controls.Add(this.btnCancelarBp);
            this.pnlBotones.Location = new System.Drawing.Point(3, 384);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(957, 57);
            this.pnlBotones.TabIndex = 8;
            this.pnlBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBotones_Paint);
            // 
            // FrmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 444);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlResultados);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.FrmBuscarProducto_Load);
            this.Shown += new System.EventHandler(this.FrmBuscarProducto_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBuscarProducto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.pnlResultados.ResumeLayout(false);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarPopup;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnSeleccionarBp;
        private System.Windows.Forms.Button btnCancelarBp;
        private System.Windows.Forms.TableLayoutPanel pnlResultados;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
    }
}