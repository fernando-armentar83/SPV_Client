namespace SPV_Client
{
    partial class FrmCatalogoCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.dgvCatalogoCompras = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltimoCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltimaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelpie = new System.Windows.Forms.Panel();
            this.btnHistorialProducto = new System.Windows.Forms.Button();
            this.cmbFiltroCatalogo = new System.Windows.Forms.ComboBox();
            this.btnBuscarCatalogo = new System.Windows.Forms.Button();
            this.btnLimpiarCatalogo = new System.Windows.Forms.Button();
            this.txtBuscarCatalogo = new System.Windows.Forms.TextBox();
            this.lblBuscarC = new System.Windows.Forms.Label();
            this.panelFiltros.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCompras)).BeginInit();
            this.panelpie.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFiltros.Controls.Add(this.lblBuscarC);
            this.panelFiltros.Controls.Add(this.txtBuscarCatalogo);
            this.panelFiltros.Controls.Add(this.btnLimpiarCatalogo);
            this.panelFiltros.Controls.Add(this.btnBuscarCatalogo);
            this.panelFiltros.Controls.Add(this.cmbFiltroCatalogo);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1056, 90);
            this.panelFiltros.TabIndex = 0;
            // 
            // panelDetalles
            // 
            this.panelDetalles.Controls.Add(this.dgvCatalogoCompras);
            this.panelDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalles.Location = new System.Drawing.Point(0, 90);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(1056, 360);
            this.panelDetalles.TabIndex = 1;
            // 
            // dgvCatalogoCompras
            // 
            this.dgvCatalogoCompras.AllowUserToAddRows = false;
            this.dgvCatalogoCompras.AllowUserToDeleteRows = false;
            this.dgvCatalogoCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCatalogoCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCatalogoCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogoCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogoCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colCodigoCompra,
            this.colCodigoBarras,
            this.colProducto,
            this.colMarca,
            this.colModelo,
            this.colProveedor,
            this.colUltimoCosto,
            this.colUltimaCompra});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogoCompras.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCatalogoCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatalogoCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvCatalogoCompras.MultiSelect = false;
            this.dgvCatalogoCompras.Name = "dgvCatalogoCompras";
            this.dgvCatalogoCompras.ReadOnly = true;
            this.dgvCatalogoCompras.RowHeadersVisible = false;
            this.dgvCatalogoCompras.RowHeadersWidth = 62;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            this.dgvCatalogoCompras.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCatalogoCompras.RowTemplate.Height = 28;
            this.dgvCatalogoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogoCompras.Size = new System.Drawing.Size(1056, 360);
            this.dgvCatalogoCompras.TabIndex = 0;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "ID";
            this.colIdProducto.MinimumWidth = 8;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            // 
            // colCodigoCompra
            // 
            this.colCodigoCompra.HeaderText = "Código Compra";
            this.colCodigoCompra.MinimumWidth = 8;
            this.colCodigoCompra.Name = "colCodigoCompra";
            this.colCodigoCompra.ReadOnly = true;
            // 
            // colCodigoBarras
            // 
            this.colCodigoBarras.HeaderText = "Código Barras";
            this.colCodigoBarras.MinimumWidth = 8;
            this.colCodigoBarras.Name = "colCodigoBarras";
            this.colCodigoBarras.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 8;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.MinimumWidth = 8;
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.MinimumWidth = 8;
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.MinimumWidth = 8;
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colUltimoCosto
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.colUltimoCosto.DefaultCellStyle = dataGridViewCellStyle12;
            this.colUltimoCosto.HeaderText = "Último Costo";
            this.colUltimoCosto.MinimumWidth = 8;
            this.colUltimoCosto.Name = "colUltimoCosto";
            this.colUltimoCosto.ReadOnly = true;
            // 
            // colUltimaCompra
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUltimaCompra.DefaultCellStyle = dataGridViewCellStyle13;
            this.colUltimaCompra.HeaderText = "Última Compra";
            this.colUltimaCompra.MinimumWidth = 8;
            this.colUltimaCompra.Name = "colUltimaCompra";
            this.colUltimaCompra.ReadOnly = true;
            // 
            // panelpie
            // 
            this.panelpie.Controls.Add(this.btnHistorialProducto);
            this.panelpie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelpie.Location = new System.Drawing.Point(0, 370);
            this.panelpie.Name = "panelpie";
            this.panelpie.Size = new System.Drawing.Size(1056, 80);
            this.panelpie.TabIndex = 2;
            // 
            // btnHistorialProducto
            // 
            this.btnHistorialProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorialProducto.BackColor = System.Drawing.Color.MintCream;
            this.btnHistorialProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialProducto.Location = new System.Drawing.Point(326, 20);
            this.btnHistorialProducto.Name = "btnHistorialProducto";
            this.btnHistorialProducto.Size = new System.Drawing.Size(120, 48);
            this.btnHistorialProducto.TabIndex = 0;
            this.btnHistorialProducto.Text = "Historial";
            this.btnHistorialProducto.UseVisualStyleBackColor = false;
            this.btnHistorialProducto.Click += new System.EventHandler(this.btnHistorialProducto_Click);
            // 
            // cmbFiltroCatalogo
            // 
            this.cmbFiltroCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroCatalogo.FormattingEnabled = true;
            this.cmbFiltroCatalogo.Items.AddRange(new object[] {
            "Nombre",
            "Código Compra",
            "Código Barras",
            "Marca",
            "Proveedor"});
            this.cmbFiltroCatalogo.Location = new System.Drawing.Point(493, 25);
            this.cmbFiltroCatalogo.Name = "cmbFiltroCatalogo";
            this.cmbFiltroCatalogo.Size = new System.Drawing.Size(150, 33);
            this.cmbFiltroCatalogo.TabIndex = 1;
            // 
            // btnBuscarCatalogo
            // 
            this.btnBuscarCatalogo.Location = new System.Drawing.Point(675, 25);
            this.btnBuscarCatalogo.Name = "btnBuscarCatalogo";
            this.btnBuscarCatalogo.Size = new System.Drawing.Size(100, 35);
            this.btnBuscarCatalogo.TabIndex = 2;
            this.btnBuscarCatalogo.Text = "Buscar";
            this.btnBuscarCatalogo.UseVisualStyleBackColor = true;
            this.btnBuscarCatalogo.Click += new System.EventHandler(this.btnBuscarCatalogo_Click);
            // 
            // btnLimpiarCatalogo
            // 
            this.btnLimpiarCatalogo.Location = new System.Drawing.Point(823, 25);
            this.btnLimpiarCatalogo.Name = "btnLimpiarCatalogo";
            this.btnLimpiarCatalogo.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiarCatalogo.TabIndex = 3;
            this.btnLimpiarCatalogo.Text = "Limpiar";
            this.btnLimpiarCatalogo.UseVisualStyleBackColor = true;
            this.btnLimpiarCatalogo.Click += new System.EventHandler(this.btnLimpiarCatalogo_Click);
            // 
            // txtBuscarCatalogo
            // 
            this.txtBuscarCatalogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCatalogo.Location = new System.Drawing.Point(117, 25);
            this.txtBuscarCatalogo.Name = "txtBuscarCatalogo";
            this.txtBuscarCatalogo.Size = new System.Drawing.Size(280, 31);
            this.txtBuscarCatalogo.TabIndex = 0;
            this.txtBuscarCatalogo.TextChanged += new System.EventHandler(this.txtBuscarCatalogo_TextChanged);
            this.txtBuscarCatalogo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCatalogo_KeyDown);
            // 
            // lblBuscarC
            // 
            this.lblBuscarC.AutoSize = true;
            this.lblBuscarC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarC.Location = new System.Drawing.Point(22, 25);
            this.lblBuscarC.Name = "lblBuscarC";
            this.lblBuscarC.Size = new System.Drawing.Size(81, 28);
            this.lblBuscarC.TabIndex = 4;
            this.lblBuscarC.Text = "Buscar:";
            // 
            // FrmCatalogoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.panelpie);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.panelFiltros);
            this.Name = "FrmCatalogoCompras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCatalogoCompras_Load);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCompras)).EndInit();
            this.panelpie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Panel panelpie;
        private System.Windows.Forms.DataGridView dgvCatalogoCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUltimoCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUltimaCompra;
        private System.Windows.Forms.Button btnHistorialProducto;
        private System.Windows.Forms.ComboBox cmbFiltroCatalogo;
        private System.Windows.Forms.Button btnBuscarCatalogo;
        private System.Windows.Forms.Button btnLimpiarCatalogo;
        private System.Windows.Forms.Label lblBuscarC;
        private System.Windows.Forms.TextBox txtBuscarCatalogo;
    }
}