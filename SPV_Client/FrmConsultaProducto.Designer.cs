namespace SPV_Client
{
    partial class FrmConsultaProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.lblUltimaVenta = new System.Windows.Forms.Label();
            this.lblCantidadVendida = new System.Windows.Forms.Label();
            this.lblTituloUltimaVenta = new System.Windows.Forms.Label();
            this.lblTituloCantidadVendida = new System.Windows.Forms.Label();
            this.lblUltimaCompra = new System.Windows.Forms.Label();
            this.blTituloUltimaCompra = new System.Windows.Forms.Label();
            this.lblCantidadComprada = new System.Windows.Forms.Label();
            this.lblTituloCantidadComprada = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblTituloCompras = new System.Windows.Forms.Label();
            this.lblCostoPromedio = new System.Windows.Forms.Label();
            this.lblTituloCostoPromedio = new System.Windows.Forms.Label();
            this.lblUltimoCosto = new System.Windows.Forms.Label();
            this.lblTituloUltimoCosto = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTituloStock = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblTituloProveedor = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTituloModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTituloMarca = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblTituloProducto = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.dgvHistorialProducto = new System.Windows.Forms.DataGridView();
            this.colIdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.dgvHistorialVentas = new System.Windows.Forms.DataGridView();
            this.colIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuentoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.dgvHistorialInventario = new System.Windows.Forms.DataGridView();
            this.colFechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSuperior.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialProducto)).BeginInit();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.tabInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.btnActualizarProducto);
            this.panelSuperior.Controls.Add(this.lblUltimaVenta);
            this.panelSuperior.Controls.Add(this.lblCantidadVendida);
            this.panelSuperior.Controls.Add(this.lblTituloUltimaVenta);
            this.panelSuperior.Controls.Add(this.lblTituloCantidadVendida);
            this.panelSuperior.Controls.Add(this.lblUltimaCompra);
            this.panelSuperior.Controls.Add(this.blTituloUltimaCompra);
            this.panelSuperior.Controls.Add(this.lblCantidadComprada);
            this.panelSuperior.Controls.Add(this.lblTituloCantidadComprada);
            this.panelSuperior.Controls.Add(this.lblCompras);
            this.panelSuperior.Controls.Add(this.lblTituloCompras);
            this.panelSuperior.Controls.Add(this.lblCostoPromedio);
            this.panelSuperior.Controls.Add(this.lblTituloCostoPromedio);
            this.panelSuperior.Controls.Add(this.lblUltimoCosto);
            this.panelSuperior.Controls.Add(this.lblTituloUltimoCosto);
            this.panelSuperior.Controls.Add(this.lblStock);
            this.panelSuperior.Controls.Add(this.lblTituloStock);
            this.panelSuperior.Controls.Add(this.lblProveedor);
            this.panelSuperior.Controls.Add(this.lblTituloProveedor);
            this.panelSuperior.Controls.Add(this.lblModelo);
            this.panelSuperior.Controls.Add(this.lblTituloModelo);
            this.panelSuperior.Controls.Add(this.lblMarca);
            this.panelSuperior.Controls.Add(this.lblTituloMarca);
            this.panelSuperior.Controls.Add(this.lblProducto);
            this.panelSuperior.Controls.Add(this.lblTituloProducto);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1361, 179);
            this.panelSuperior.TabIndex = 0;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProducto.ForeColor = System.Drawing.Color.White;
            this.btnActualizarProducto.Location = new System.Drawing.Point(1250, 50);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(100, 35);
            this.btnActualizarProducto.TabIndex = 24;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = false;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // lblUltimaVenta
            // 
            this.lblUltimaVenta.AutoSize = true;
            this.lblUltimaVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaVenta.Location = new System.Drawing.Point(929, 110);
            this.lblUltimaVenta.Name = "lblUltimaVenta";
            this.lblUltimaVenta.Size = new System.Drawing.Size(20, 28);
            this.lblUltimaVenta.TabIndex = 23;
            this.lblUltimaVenta.Text = "-";
            // 
            // lblCantidadVendida
            // 
            this.lblCantidadVendida.AutoSize = true;
            this.lblCantidadVendida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVendida.Location = new System.Drawing.Point(972, 80);
            this.lblCantidadVendida.Name = "lblCantidadVendida";
            this.lblCantidadVendida.Size = new System.Drawing.Size(20, 28);
            this.lblCantidadVendida.TabIndex = 22;
            this.lblCantidadVendida.Text = "-";
            // 
            // lblTituloUltimaVenta
            // 
            this.lblTituloUltimaVenta.AutoSize = true;
            this.lblTituloUltimaVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUltimaVenta.Location = new System.Drawing.Point(783, 110);
            this.lblTituloUltimaVenta.Name = "lblTituloUltimaVenta";
            this.lblTituloUltimaVenta.Size = new System.Drawing.Size(140, 28);
            this.lblTituloUltimaVenta.TabIndex = 21;
            this.lblTituloUltimaVenta.Text = "Última Venta:";
            // 
            // lblTituloCantidadVendida
            // 
            this.lblTituloCantidadVendida.AutoSize = true;
            this.lblTituloCantidadVendida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCantidadVendida.Location = new System.Drawing.Point(783, 80);
            this.lblTituloCantidadVendida.Name = "lblTituloCantidadVendida";
            this.lblTituloCantidadVendida.Size = new System.Drawing.Size(183, 28);
            this.lblTituloCantidadVendida.TabIndex = 20;
            this.lblTituloCantidadVendida.Text = "Cantidad Vendida:";
            // 
            // lblUltimaCompra
            // 
            this.lblUltimaCompra.AutoSize = true;
            this.lblUltimaCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaCompra.Location = new System.Drawing.Point(964, 50);
            this.lblUltimaCompra.Name = "lblUltimaCompra";
            this.lblUltimaCompra.Size = new System.Drawing.Size(20, 28);
            this.lblUltimaCompra.TabIndex = 19;
            this.lblUltimaCompra.Text = "-";
            // 
            // blTituloUltimaCompra
            // 
            this.blTituloUltimaCompra.AutoSize = true;
            this.blTituloUltimaCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blTituloUltimaCompra.Location = new System.Drawing.Point(783, 50);
            this.blTituloUltimaCompra.Name = "blTituloUltimaCompra";
            this.blTituloUltimaCompra.Size = new System.Drawing.Size(159, 28);
            this.blTituloUltimaCompra.TabIndex = 18;
            this.blTituloUltimaCompra.Text = "Última Compra:";
            // 
            // lblCantidadComprada
            // 
            this.lblCantidadComprada.AutoSize = true;
            this.lblCantidadComprada.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadComprada.Location = new System.Drawing.Point(996, 20);
            this.lblCantidadComprada.Name = "lblCantidadComprada";
            this.lblCantidadComprada.Size = new System.Drawing.Size(20, 28);
            this.lblCantidadComprada.TabIndex = 17;
            this.lblCantidadComprada.Text = "-";
            // 
            // lblTituloCantidadComprada
            // 
            this.lblTituloCantidadComprada.AutoSize = true;
            this.lblTituloCantidadComprada.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCantidadComprada.Location = new System.Drawing.Point(783, 20);
            this.lblTituloCantidadComprada.Name = "lblTituloCantidadComprada";
            this.lblTituloCantidadComprada.Size = new System.Drawing.Size(201, 28);
            this.lblTituloCantidadComprada.TabIndex = 16;
            this.lblTituloCantidadComprada.Text = "Cantidad comprada:";
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.Location = new System.Drawing.Point(593, 110);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(20, 28);
            this.lblCompras.TabIndex = 15;
            this.lblCompras.Text = "-";
            // 
            // lblTituloCompras
            // 
            this.lblTituloCompras.AutoSize = true;
            this.lblTituloCompras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCompras.Location = new System.Drawing.Point(453, 110);
            this.lblTituloCompras.Name = "lblTituloCompras";
            this.lblTituloCompras.Size = new System.Drawing.Size(99, 28);
            this.lblTituloCompras.TabIndex = 14;
            this.lblTituloCompras.Text = "Compras:";
            // 
            // lblCostoPromedio
            // 
            this.lblCostoPromedio.AutoSize = true;
            this.lblCostoPromedio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoPromedio.Location = new System.Drawing.Point(623, 80);
            this.lblCostoPromedio.Name = "lblCostoPromedio";
            this.lblCostoPromedio.Size = new System.Drawing.Size(20, 28);
            this.lblCostoPromedio.TabIndex = 13;
            this.lblCostoPromedio.Text = "-";
            // 
            // lblTituloCostoPromedio
            // 
            this.lblTituloCostoPromedio.AutoSize = true;
            this.lblTituloCostoPromedio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCostoPromedio.Location = new System.Drawing.Point(453, 80);
            this.lblTituloCostoPromedio.Name = "lblTituloCostoPromedio";
            this.lblTituloCostoPromedio.Size = new System.Drawing.Size(167, 28);
            this.lblTituloCostoPromedio.TabIndex = 12;
            this.lblTituloCostoPromedio.Text = "Costo Promedio:";
            // 
            // lblUltimoCosto
            // 
            this.lblUltimoCosto.AutoSize = true;
            this.lblUltimoCosto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoCosto.Location = new System.Drawing.Point(593, 50);
            this.lblUltimoCosto.Name = "lblUltimoCosto";
            this.lblUltimoCosto.Size = new System.Drawing.Size(20, 28);
            this.lblUltimoCosto.TabIndex = 11;
            this.lblUltimoCosto.Text = "-";
            // 
            // lblTituloUltimoCosto
            // 
            this.lblTituloUltimoCosto.AutoSize = true;
            this.lblTituloUltimoCosto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUltimoCosto.Location = new System.Drawing.Point(453, 50);
            this.lblTituloUltimoCosto.Name = "lblTituloUltimoCosto";
            this.lblTituloUltimoCosto.Size = new System.Drawing.Size(140, 28);
            this.lblTituloUltimoCosto.TabIndex = 10;
            this.lblTituloUltimoCosto.Text = "Último Costo:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(593, 20);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(20, 28);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "-";
            // 
            // lblTituloStock
            // 
            this.lblTituloStock.AutoSize = true;
            this.lblTituloStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloStock.Location = new System.Drawing.Point(453, 20);
            this.lblTituloStock.Name = "lblTituloStock";
            this.lblTituloStock.Size = new System.Drawing.Size(136, 28);
            this.lblTituloStock.TabIndex = 8;
            this.lblTituloStock.Text = "Stock Actual:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(140, 110);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(20, 28);
            this.lblProveedor.TabIndex = 7;
            this.lblProveedor.Text = "-";
            // 
            // lblTituloProveedor
            // 
            this.lblTituloProveedor.AutoSize = true;
            this.lblTituloProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedor.Location = new System.Drawing.Point(20, 110);
            this.lblTituloProveedor.Name = "lblTituloProveedor";
            this.lblTituloProveedor.Size = new System.Drawing.Size(115, 28);
            this.lblTituloProveedor.TabIndex = 6;
            this.lblTituloProveedor.Text = "Proveedor:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(140, 80);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(20, 28);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "-";
            // 
            // lblTituloModelo
            // 
            this.lblTituloModelo.AutoSize = true;
            this.lblTituloModelo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModelo.Location = new System.Drawing.Point(20, 80);
            this.lblTituloModelo.Name = "lblTituloModelo";
            this.lblTituloModelo.Size = new System.Drawing.Size(89, 28);
            this.lblTituloModelo.TabIndex = 4;
            this.lblTituloModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(140, 50);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(20, 28);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "-";
            // 
            // lblTituloMarca
            // 
            this.lblTituloMarca.AutoSize = true;
            this.lblTituloMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarca.Location = new System.Drawing.Point(20, 50);
            this.lblTituloMarca.Name = "lblTituloMarca";
            this.lblTituloMarca.Size = new System.Drawing.Size(76, 28);
            this.lblTituloMarca.TabIndex = 2;
            this.lblTituloMarca.Text = "Marca:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(140, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(20, 28);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "-";
            // 
            // lblTituloProducto
            // 
            this.lblTituloProducto.AutoSize = true;
            this.lblTituloProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProducto.Location = new System.Drawing.Point(20, 20);
            this.lblTituloProducto.Name = "lblTituloProducto";
            this.lblTituloProducto.Size = new System.Drawing.Size(103, 28);
            this.lblTituloProducto.TabIndex = 0;
            this.lblTituloProducto.Text = "Producto:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCompras);
            this.tabControl.Controls.Add(this.tabVentas);
            this.tabControl.Controls.Add(this.tabInventario);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(150, 35);
            this.tabControl.Location = new System.Drawing.Point(0, 179);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1361, 465);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.dgvHistorialProducto);
            this.tabCompras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCompras.Location = new System.Drawing.Point(4, 39);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompras.Size = new System.Drawing.Size(1353, 422);
            this.tabCompras.TabIndex = 0;
            this.tabCompras.Text = "Compras";
            this.tabCompras.UseVisualStyleBackColor = true;
            // 
            // dgvHistorialProducto
            // 
            this.dgvHistorialProducto.AllowUserToAddRows = false;
            this.dgvHistorialProducto.AllowUserToDeleteRows = false;
            this.dgvHistorialProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialProducto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialProducto.ColumnHeadersHeight = 32;
            this.dgvHistorialProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCompra,
            this.colFecha,
            this.colFolio,
            this.colProveedor,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal,
            this.colUsuario});
            this.dgvHistorialProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorialProducto.EnableHeadersVisualStyles = false;
            this.dgvHistorialProducto.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHistorialProducto.Location = new System.Drawing.Point(3, 3);
            this.dgvHistorialProducto.MultiSelect = false;
            this.dgvHistorialProducto.Name = "dgvHistorialProducto";
            this.dgvHistorialProducto.ReadOnly = true;
            this.dgvHistorialProducto.RowHeadersVisible = false;
            this.dgvHistorialProducto.RowHeadersWidth = 62;
            this.dgvHistorialProducto.RowTemplate.Height = 28;
            this.dgvHistorialProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialProducto.Size = new System.Drawing.Size(1347, 416);
            this.dgvHistorialProducto.TabIndex = 4;
            this.dgvHistorialProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialProducto_CellDoubleClick);
            this.dgvHistorialProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvHistorialProducto_KeyDown);
            // 
            // colIdCompra
            // 
            this.colIdCompra.HeaderText = "IdCompra";
            this.colIdCompra.MinimumWidth = 8;
            this.colIdCompra.Name = "colIdCompra";
            this.colIdCompra.ReadOnly = true;
            this.colIdCompra.Visible = false;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 8;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colFolio
            // 
            this.colFolio.HeaderText = "Folio";
            this.colFolio.MinimumWidth = 8;
            this.colFolio.Name = "colFolio";
            this.colFolio.ReadOnly = true;
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.MinimumWidth = 8;
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio Compra";
            this.colPrecio.MinimumWidth = 8;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 8;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.MinimumWidth = 8;
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.dgvHistorialVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 39);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(1353, 422);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // dgvHistorialVentas
            // 
            this.dgvHistorialVentas.AllowUserToAddRows = false;
            this.dgvHistorialVentas.AllowUserToDeleteRows = false;
            this.dgvHistorialVentas.AllowUserToResizeRows = false;
            this.dgvHistorialVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialVentas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialVentas.ColumnHeadersHeight = 32;
            this.dgvHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVenta,
            this.colFechaVenta,
            this.colFolioVenta,
            this.colClienteVenta,
            this.colCantidadVenta,
            this.colPrecioVenta,
            this.colDescuentoVenta,
            this.colSubtotalVenta,
            this.colUsuarioVenta});
            this.dgvHistorialVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorialVentas.EnableHeadersVisualStyles = false;
            this.dgvHistorialVentas.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHistorialVentas.Location = new System.Drawing.Point(3, 3);
            this.dgvHistorialVentas.MultiSelect = false;
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.ReadOnly = true;
            this.dgvHistorialVentas.RowHeadersVisible = false;
            this.dgvHistorialVentas.RowHeadersWidth = 62;
            this.dgvHistorialVentas.RowTemplate.Height = 28;
            this.dgvHistorialVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialVentas.Size = new System.Drawing.Size(1347, 416);
            this.dgvHistorialVentas.TabIndex = 0;
            this.dgvHistorialVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialVentas_CellDoubleClick);
            this.dgvHistorialVentas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvHistorialVentas_KeyDown);
            // 
            // colIdVenta
            // 
            this.colIdVenta.HeaderText = "IdVenta";
            this.colIdVenta.MinimumWidth = 8;
            this.colIdVenta.Name = "colIdVenta";
            this.colIdVenta.ReadOnly = true;
            this.colIdVenta.Visible = false;
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.HeaderText = "Fecha";
            this.colFechaVenta.MinimumWidth = 8;
            this.colFechaVenta.Name = "colFechaVenta";
            this.colFechaVenta.ReadOnly = true;
            // 
            // colFolioVenta
            // 
            this.colFolioVenta.HeaderText = "Folio";
            this.colFolioVenta.MinimumWidth = 8;
            this.colFolioVenta.Name = "colFolioVenta";
            this.colFolioVenta.ReadOnly = true;
            // 
            // colClienteVenta
            // 
            this.colClienteVenta.HeaderText = "Cliente";
            this.colClienteVenta.MinimumWidth = 8;
            this.colClienteVenta.Name = "colClienteVenta";
            this.colClienteVenta.ReadOnly = true;
            // 
            // colCantidadVenta
            // 
            this.colCantidadVenta.HeaderText = "Cantidad";
            this.colCantidadVenta.MinimumWidth = 8;
            this.colCantidadVenta.Name = "colCantidadVenta";
            this.colCantidadVenta.ReadOnly = true;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.HeaderText = "Precio";
            this.colPrecioVenta.MinimumWidth = 8;
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.ReadOnly = true;
            // 
            // colDescuentoVenta
            // 
            this.colDescuentoVenta.HeaderText = "Desc.%";
            this.colDescuentoVenta.MinimumWidth = 8;
            this.colDescuentoVenta.Name = "colDescuentoVenta";
            this.colDescuentoVenta.ReadOnly = true;
            // 
            // colSubtotalVenta
            // 
            this.colSubtotalVenta.HeaderText = "Subtotal";
            this.colSubtotalVenta.MinimumWidth = 8;
            this.colSubtotalVenta.Name = "colSubtotalVenta";
            this.colSubtotalVenta.ReadOnly = true;
            // 
            // colUsuarioVenta
            // 
            this.colUsuarioVenta.HeaderText = "Usuario";
            this.colUsuarioVenta.MinimumWidth = 8;
            this.colUsuarioVenta.Name = "colUsuarioVenta";
            this.colUsuarioVenta.ReadOnly = true;
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.dgvHistorialInventario);
            this.tabInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInventario.Location = new System.Drawing.Point(4, 39);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventario.Size = new System.Drawing.Size(1353, 422);
            this.tabInventario.TabIndex = 2;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            // 
            // dgvHistorialInventario
            // 
            this.dgvHistorialInventario.AllowUserToAddRows = false;
            this.dgvHistorialInventario.AllowUserToDeleteRows = false;
            this.dgvHistorialInventario.AllowUserToResizeRows = false;
            this.dgvHistorialInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialInventario.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorialInventario.ColumnHeadersHeight = 36;
            this.dgvHistorialInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaMovimiento,
            this.colTipoMovimiento,
            this.colCantidadMovimiento,
            this.colDocumento,
            this.colUsuarioMovimiento,
            this.colDescripcionMovimiento});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialInventario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorialInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorialInventario.EnableHeadersVisualStyles = false;
            this.dgvHistorialInventario.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHistorialInventario.Location = new System.Drawing.Point(3, 3);
            this.dgvHistorialInventario.MultiSelect = false;
            this.dgvHistorialInventario.Name = "dgvHistorialInventario";
            this.dgvHistorialInventario.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistorialInventario.RowHeadersVisible = false;
            this.dgvHistorialInventario.RowHeadersWidth = 62;
            this.dgvHistorialInventario.RowTemplate.Height = 28;
            this.dgvHistorialInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialInventario.Size = new System.Drawing.Size(1347, 416);
            this.dgvHistorialInventario.TabIndex = 0;
            // 
            // colFechaMovimiento
            // 
            this.colFechaMovimiento.HeaderText = "Fecha";
            this.colFechaMovimiento.MinimumWidth = 8;
            this.colFechaMovimiento.Name = "colFechaMovimiento";
            this.colFechaMovimiento.ReadOnly = true;
            // 
            // colTipoMovimiento
            // 
            this.colTipoMovimiento.HeaderText = "Movimiento";
            this.colTipoMovimiento.MinimumWidth = 8;
            this.colTipoMovimiento.Name = "colTipoMovimiento";
            this.colTipoMovimiento.ReadOnly = true;
            // 
            // colCantidadMovimiento
            // 
            this.colCantidadMovimiento.HeaderText = "Cantidad";
            this.colCantidadMovimiento.MinimumWidth = 8;
            this.colCantidadMovimiento.Name = "colCantidadMovimiento";
            this.colCantidadMovimiento.ReadOnly = true;
            // 
            // colDocumento
            // 
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.MinimumWidth = 8;
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.ReadOnly = true;
            // 
            // colUsuarioMovimiento
            // 
            this.colUsuarioMovimiento.HeaderText = "Usuario";
            this.colUsuarioMovimiento.MinimumWidth = 8;
            this.colUsuarioMovimiento.Name = "colUsuarioMovimiento";
            this.colUsuarioMovimiento.ReadOnly = true;
            // 
            // colDescripcionMovimiento
            // 
            this.colDescripcionMovimiento.HeaderText = "Descripción";
            this.colDescripcionMovimiento.MinimumWidth = 8;
            this.colDescripcionMovimiento.Name = "colDescripcionMovimiento";
            this.colDescripcionMovimiento.ReadOnly = true;
            // 
            // FrmConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1361, 644);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmConsultaProducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta del Producto";
            this.Load += new System.EventHandler(this.FrmConsultaProducto_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialProducto)).EndInit();
            this.tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.tabInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblTituloProducto;
        private System.Windows.Forms.Label lblTituloMarca;
        private System.Windows.Forms.Label lblTituloModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTituloStock;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblTituloProveedor;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblTituloUltimoCosto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUltimoCosto;
        private System.Windows.Forms.Label lblCostoPromedio;
        private System.Windows.Forms.Label lblTituloCostoPromedio;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblTituloCompras;
        private System.Windows.Forms.Label lblCantidadComprada;
        private System.Windows.Forms.Label lblTituloCantidadComprada;
        private System.Windows.Forms.Label lblUltimaCompra;
        private System.Windows.Forms.Label blTituloUltimaCompra;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.DataGridView dgvHistorialProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.DataGridView dgvHistorialVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuentoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotalVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioVenta;
        private System.Windows.Forms.Label lblTituloUltimaVenta;
        private System.Windows.Forms.Label lblTituloCantidadVendida;
        private System.Windows.Forms.Label lblUltimaVenta;
        private System.Windows.Forms.Label lblCantidadVendida;
        private System.Windows.Forms.DataGridView dgvHistorialInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionMovimiento;
        private System.Windows.Forms.Button btnActualizarProducto;
    }
}