namespace SPV_Client
{
    partial class FrmCompras
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeaderCompra = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtFacturaProveedor = new System.Windows.Forms.TextBox();
            this.lblTituloFactura = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblTituloProveedor = new System.Windows.Forms.Label();
            this.lblFolioCompra = new System.Windows.Forms.Label();
            this.lblTituloFolio = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.panelCapturaCompra = new System.Windows.Forms.Panel();
            this.btnLimpiarProductoCompra = new System.Windows.Forms.Button();
            this.lblPrecioVentaActual = new System.Windows.Forms.Label();
            this.lblTituloPrecioVentaActual = new System.Windows.Forms.Label();
            this.lblProveedorProducto = new System.Windows.Forms.Label();
            this.lblTituloProveedorProducto = new System.Windows.Forms.Label();
            this.lblCodigoCompraProducto = new System.Windows.Forms.Label();
            this.lblTituloCodigoCompra = new System.Windows.Forms.Label();
            this.lblModeloProducto = new System.Windows.Forms.Label();
            this.lblTituloModelo = new System.Windows.Forms.Label();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.lblTituloMarca = new System.Windows.Forms.Label();
            this.btnAgregarProductoCompra = new System.Windows.Forms.Button();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblTituloGanancia = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblTituloStock = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblTituloPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblTituloPrecioCompra = new System.Windows.Forms.Label();
            this.txtCantidadCompra = new System.Windows.Forms.TextBox();
            this.lblTituloCantidadCompra = new System.Windows.Forms.Label();
            this.txtBuscarProductoCompra = new System.Windows.Forms.TextBox();
            this.panelDetalleCompra = new System.Windows.Forms.Panel();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPermiteDecimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDecimales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooterCompra = new System.Windows.Forms.Panel();
            this.btnHistorialCompra = new System.Windows.Forms.Button();
            this.btnCancelarCaptura = new System.Windows.Forms.Button();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblTituloTotalCompra = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.panelHeaderCompra.SuspendLayout();
            this.panelCapturaCompra.SuspendLayout();
            this.panelDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.panelFooterCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderCompra
            // 
            this.panelHeaderCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeaderCompra.Controls.Add(this.lblInfo);
            this.panelHeaderCompra.Controls.Add(this.txtFacturaProveedor);
            this.panelHeaderCompra.Controls.Add(this.lblTituloFactura);
            this.panelHeaderCompra.Controls.Add(this.cmbProveedor);
            this.panelHeaderCompra.Controls.Add(this.lblTituloProveedor);
            this.panelHeaderCompra.Controls.Add(this.lblFolioCompra);
            this.panelHeaderCompra.Controls.Add(this.lblTituloFolio);
            this.panelHeaderCompra.Controls.Add(this.lblUsuarioActivo);
            this.panelHeaderCompra.Controls.Add(this.lblTituloUsuario);
            this.panelHeaderCompra.Controls.Add(this.lblFechaHora);
            this.panelHeaderCompra.Controls.Add(this.lblTituloFecha);
            this.panelHeaderCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderCompra.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderCompra.Name = "panelHeaderCompra";
            this.panelHeaderCompra.Size = new System.Drawing.Size(1370, 119);
            this.panelHeaderCompra.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(1267, 86);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(101, 28);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "Info Click";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // txtFacturaProveedor
            // 
            this.txtFacturaProveedor.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaProveedor.Location = new System.Drawing.Point(750, 71);
            this.txtFacturaProveedor.Name = "txtFacturaProveedor";
            this.txtFacturaProveedor.Size = new System.Drawing.Size(184, 26);
            this.txtFacturaProveedor.TabIndex = 9;
            // 
            // lblTituloFactura
            // 
            this.lblTituloFactura.AutoSize = true;
            this.lblTituloFactura.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFactura.Location = new System.Drawing.Point(532, 74);
            this.lblTituloFactura.Name = "lblTituloFactura";
            this.lblTituloFactura.Size = new System.Drawing.Size(197, 23);
            this.lblTituloFactura.TabIndex = 8;
            this.lblTituloFactura.Text = "Factura / Ticket:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(750, 21);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(184, 28);
            this.cmbProveedor.TabIndex = 7;
            // 
            // lblTituloProveedor
            // 
            this.lblTituloProveedor.AutoSize = true;
            this.lblTituloProveedor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedor.Location = new System.Drawing.Point(609, 24);
            this.lblTituloProveedor.Name = "lblTituloProveedor";
            this.lblTituloProveedor.Size = new System.Drawing.Size(120, 23);
            this.lblTituloProveedor.TabIndex = 6;
            this.lblTituloProveedor.Text = "Proveedor:";
            // 
            // lblFolioCompra
            // 
            this.lblFolioCompra.AutoSize = true;
            this.lblFolioCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolioCompra.Location = new System.Drawing.Point(1170, 19);
            this.lblFolioCompra.Name = "lblFolioCompra";
            this.lblFolioCompra.Size = new System.Drawing.Size(153, 29);
            this.lblFolioCompra.TabIndex = 5;
            this.lblFolioCompra.Text = "CMP-000000";
            // 
            // lblTituloFolio
            // 
            this.lblTituloFolio.AutoSize = true;
            this.lblTituloFolio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFolio.Location = new System.Drawing.Point(1074, 22);
            this.lblTituloFolio.Name = "lblTituloFolio";
            this.lblTituloFolio.Size = new System.Drawing.Size(90, 28);
            this.lblTituloFolio.TabIndex = 4;
            this.lblTituloFolio.Text = "Folio:";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Location = new System.Drawing.Point(127, 71);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(99, 28);
            this.lblUsuarioActivo.TabIndex = 3;
            this.lblUsuarioActivo.Text = "USUARIO";
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.Location = new System.Drawing.Point(23, 77);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(87, 23);
            this.lblTituloUsuario.TabIndex = 2;
            this.lblTituloUsuario.Text = "Cajero:";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(127, 22);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(138, 23);
            this.lblFechaHora.TabIndex = 1;
            this.lblFechaHora.Text = "--/--/---- --:--:--";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.Location = new System.Drawing.Point(34, 22);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(76, 23);
            this.lblTituloFecha.TabIndex = 0;
            this.lblTituloFecha.Text = "Fecha:";
            // 
            // panelCapturaCompra
            // 
            this.panelCapturaCompra.Controls.Add(this.btnLimpiarProductoCompra);
            this.panelCapturaCompra.Controls.Add(this.lblPrecioVentaActual);
            this.panelCapturaCompra.Controls.Add(this.lblTituloPrecioVentaActual);
            this.panelCapturaCompra.Controls.Add(this.lblProveedorProducto);
            this.panelCapturaCompra.Controls.Add(this.lblTituloProveedorProducto);
            this.panelCapturaCompra.Controls.Add(this.lblCodigoCompraProducto);
            this.panelCapturaCompra.Controls.Add(this.lblTituloCodigoCompra);
            this.panelCapturaCompra.Controls.Add(this.lblModeloProducto);
            this.panelCapturaCompra.Controls.Add(this.lblTituloModelo);
            this.panelCapturaCompra.Controls.Add(this.lblMarcaProducto);
            this.panelCapturaCompra.Controls.Add(this.lblTituloMarca);
            this.panelCapturaCompra.Controls.Add(this.btnAgregarProductoCompra);
            this.panelCapturaCompra.Controls.Add(this.lblGanancia);
            this.panelCapturaCompra.Controls.Add(this.lblTituloGanancia);
            this.panelCapturaCompra.Controls.Add(this.lblStockActual);
            this.panelCapturaCompra.Controls.Add(this.lblTituloStock);
            this.panelCapturaCompra.Controls.Add(this.txtPrecioVenta);
            this.panelCapturaCompra.Controls.Add(this.lblTituloPrecioVenta);
            this.panelCapturaCompra.Controls.Add(this.txtPrecioCompra);
            this.panelCapturaCompra.Controls.Add(this.lblTituloPrecioCompra);
            this.panelCapturaCompra.Controls.Add(this.txtCantidadCompra);
            this.panelCapturaCompra.Controls.Add(this.lblTituloCantidadCompra);
            this.panelCapturaCompra.Controls.Add(this.txtBuscarProductoCompra);
            this.panelCapturaCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCapturaCompra.Location = new System.Drawing.Point(0, 119);
            this.panelCapturaCompra.Name = "panelCapturaCompra";
            this.panelCapturaCompra.Size = new System.Drawing.Size(1370, 275);
            this.panelCapturaCompra.TabIndex = 1;
            // 
            // btnLimpiarProductoCompra
            // 
            this.btnLimpiarProductoCompra.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLimpiarProductoCompra.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProductoCompra.Location = new System.Drawing.Point(1259, 62);
            this.btnLimpiarProductoCompra.Name = "btnLimpiarProductoCompra";
            this.btnLimpiarProductoCompra.Size = new System.Drawing.Size(99, 57);
            this.btnLimpiarProductoCompra.TabIndex = 22;
            this.btnLimpiarProductoCompra.Text = "Limpiar";
            this.btnLimpiarProductoCompra.UseVisualStyleBackColor = false;
            this.btnLimpiarProductoCompra.Click += new System.EventHandler(this.btnLimpiarProductoCompra_Click);
            // 
            // lblPrecioVentaActual
            // 
            this.lblPrecioVentaActual.AutoSize = true;
            this.lblPrecioVentaActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVentaActual.Location = new System.Drawing.Point(1182, 212);
            this.lblPrecioVentaActual.Name = "lblPrecioVentaActual";
            this.lblPrecioVentaActual.Size = new System.Drawing.Size(64, 28);
            this.lblPrecioVentaActual.TabIndex = 21;
            this.lblPrecioVentaActual.Text = "0.00";
            // 
            // lblTituloPrecioVentaActual
            // 
            this.lblTituloPrecioVentaActual.AutoSize = true;
            this.lblTituloPrecioVentaActual.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrecioVentaActual.Location = new System.Drawing.Point(987, 216);
            this.lblTituloPrecioVentaActual.Name = "lblTituloPrecioVentaActual";
            this.lblTituloPrecioVentaActual.Size = new System.Drawing.Size(189, 23);
            this.lblTituloPrecioVentaActual.TabIndex = 20;
            this.lblTituloPrecioVentaActual.Text = "Precio Venta Actual :";
            // 
            // lblProveedorProducto
            // 
            this.lblProveedorProducto.AutoSize = true;
            this.lblProveedorProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorProducto.Location = new System.Drawing.Point(788, 209);
            this.lblProveedorProducto.Name = "lblProveedorProducto";
            this.lblProveedorProducto.Size = new System.Drawing.Size(38, 28);
            this.lblProveedorProducto.TabIndex = 19;
            this.lblProveedorProducto.Text = "--\"";
            // 
            // lblTituloProveedorProducto
            // 
            this.lblTituloProveedorProducto.AutoSize = true;
            this.lblTituloProveedorProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedorProducto.Location = new System.Drawing.Point(661, 206);
            this.lblTituloProveedorProducto.Name = "lblTituloProveedorProducto";
            this.lblTituloProveedorProducto.Size = new System.Drawing.Size(120, 28);
            this.lblTituloProveedorProducto.TabIndex = 18;
            this.lblTituloProveedorProducto.Text = "Proveedor :";
            // 
            // lblCodigoCompraProducto
            // 
            this.lblCodigoCompraProducto.AutoSize = true;
            this.lblCodigoCompraProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCompraProducto.Location = new System.Drawing.Point(788, 150);
            this.lblCodigoCompraProducto.Name = "lblCodigoCompraProducto";
            this.lblCodigoCompraProducto.Size = new System.Drawing.Size(38, 28);
            this.lblCodigoCompraProducto.TabIndex = 17;
            this.lblCodigoCompraProducto.Text = "--\"";
            // 
            // lblTituloCodigoCompra
            // 
            this.lblTituloCodigoCompra.AutoSize = true;
            this.lblTituloCodigoCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCodigoCompra.Location = new System.Drawing.Point(690, 150);
            this.lblTituloCodigoCompra.Name = "lblTituloCodigoCompra";
            this.lblTituloCodigoCompra.Size = new System.Drawing.Size(89, 28);
            this.lblTituloCodigoCompra.TabIndex = 16;
            this.lblTituloCodigoCompra.Text = "Código :";
            // 
            // lblModeloProducto
            // 
            this.lblModeloProducto.AutoSize = true;
            this.lblModeloProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloProducto.Location = new System.Drawing.Point(457, 211);
            this.lblModeloProducto.Name = "lblModeloProducto";
            this.lblModeloProducto.Size = new System.Drawing.Size(38, 28);
            this.lblModeloProducto.TabIndex = 15;
            this.lblModeloProducto.Text = "--\"";
            // 
            // lblTituloModelo
            // 
            this.lblTituloModelo.AutoSize = true;
            this.lblTituloModelo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModelo.Location = new System.Drawing.Point(360, 211);
            this.lblTituloModelo.Name = "lblTituloModelo";
            this.lblTituloModelo.Size = new System.Drawing.Size(95, 28);
            this.lblTituloModelo.TabIndex = 14;
            this.lblTituloModelo.Text = "Modelo :";
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaProducto.Location = new System.Drawing.Point(457, 150);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(38, 28);
            this.lblMarcaProducto.TabIndex = 13;
            this.lblMarcaProducto.Text = "--\"";
            // 
            // lblTituloMarca
            // 
            this.lblTituloMarca.AutoSize = true;
            this.lblTituloMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarca.Location = new System.Drawing.Point(368, 150);
            this.lblTituloMarca.Name = "lblTituloMarca";
            this.lblTituloMarca.Size = new System.Drawing.Size(82, 28);
            this.lblTituloMarca.TabIndex = 12;
            this.lblTituloMarca.Text = "Marca :";
            // 
            // btnAgregarProductoCompra
            // 
            this.btnAgregarProductoCompra.BackColor = System.Drawing.Color.Cyan;
            this.btnAgregarProductoCompra.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductoCompra.Location = new System.Drawing.Point(991, 47);
            this.btnAgregarProductoCompra.Name = "btnAgregarProductoCompra";
            this.btnAgregarProductoCompra.Size = new System.Drawing.Size(139, 92);
            this.btnAgregarProductoCompra.TabIndex = 11;
            this.btnAgregarProductoCompra.Text = "Agregar";
            this.btnAgregarProductoCompra.UseVisualStyleBackColor = false;
            this.btnAgregarProductoCompra.Click += new System.EventHandler(this.btnAgregarProductoCompra_Click);
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.Location = new System.Drawing.Point(158, 155);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(41, 28);
            this.lblGanancia.TabIndex = 10;
            this.lblGanancia.Text = "0%";
            // 
            // lblTituloGanancia
            // 
            this.lblTituloGanancia.AutoSize = true;
            this.lblTituloGanancia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGanancia.Location = new System.Drawing.Point(12, 150);
            this.lblTituloGanancia.Name = "lblTituloGanancia";
            this.lblTituloGanancia.Size = new System.Drawing.Size(133, 28);
            this.lblTituloGanancia.TabIndex = 9;
            this.lblTituloGanancia.Text = "% Ganancia :";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.Location = new System.Drawing.Point(126, 216);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(24, 28);
            this.lblStockActual.TabIndex = 8;
            this.lblStockActual.Text = "0";
            this.lblStockActual.Click += new System.EventHandler(this.lblStockActual_Click);
            // 
            // lblTituloStock
            // 
            this.lblTituloStock.AutoSize = true;
            this.lblTituloStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloStock.Location = new System.Drawing.Point(39, 216);
            this.lblTituloStock.Name = "lblTituloStock";
            this.lblTituloStock.Size = new System.Drawing.Size(75, 28);
            this.lblTituloStock.TabIndex = 7;
            this.lblTituloStock.Text = "Stock :";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(411, 75);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(130, 26);
            this.txtPrecioVenta.TabIndex = 6;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // lblTituloPrecioVenta
            // 
            this.lblTituloPrecioVenta.AutoSize = true;
            this.lblTituloPrecioVenta.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrecioVenta.Location = new System.Drawing.Point(303, 78);
            this.lblTituloPrecioVenta.Name = "lblTituloPrecioVenta";
            this.lblTituloPrecioVenta.Size = new System.Drawing.Size(91, 23);
            this.lblTituloPrecioVenta.TabIndex = 5;
            this.lblTituloPrecioVenta.Text = "P. Venta :";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(131, 77);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(130, 26);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            this.txtPrecioCompra.Leave += new System.EventHandler(this.txtPrecioCompra_Leave);
            // 
            // lblTituloPrecioCompra
            // 
            this.lblTituloPrecioCompra.AutoSize = true;
            this.lblTituloPrecioCompra.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrecioCompra.Location = new System.Drawing.Point(12, 77);
            this.lblTituloPrecioCompra.Name = "lblTituloPrecioCompra";
            this.lblTituloPrecioCompra.Size = new System.Drawing.Size(109, 23);
            this.lblTituloPrecioCompra.TabIndex = 3;
            this.lblTituloPrecioCompra.Text = "P. Compra :";
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCompra.Location = new System.Drawing.Point(782, 72);
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadCompra.TabIndex = 2;
            this.txtCantidadCompra.Text = "1";
            this.txtCantidadCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadCompra_KeyPress);
            this.txtCantidadCompra.Leave += new System.EventHandler(this.txtCantidadCompra_Leave);
            // 
            // lblTituloCantidadCompra
            // 
            this.lblTituloCantidadCompra.AutoSize = true;
            this.lblTituloCantidadCompra.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCantidadCompra.Location = new System.Drawing.Point(607, 75);
            this.lblTituloCantidadCompra.Name = "lblTituloCantidadCompra";
            this.lblTituloCantidadCompra.Size = new System.Drawing.Size(98, 23);
            this.lblTituloCantidadCompra.TabIndex = 1;
            this.lblTituloCantidadCompra.Text = "Cantidad :";
            // 
            // txtBuscarProductoCompra
            // 
            this.txtBuscarProductoCompra.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProductoCompra.Location = new System.Drawing.Point(12, 21);
            this.txtBuscarProductoCompra.Name = "txtBuscarProductoCompra";
            this.txtBuscarProductoCompra.Size = new System.Drawing.Size(558, 26);
            this.txtBuscarProductoCompra.TabIndex = 0;
            this.txtBuscarProductoCompra.TextChanged += new System.EventHandler(this.txtBuscarProductoCompra_TextChanged);
            this.txtBuscarProductoCompra.DoubleClick += new System.EventHandler(this.txtBuscarProductoCompra_DoubleClick);
            this.txtBuscarProductoCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProductoCompra_KeyDown);
            // 
            // panelDetalleCompra
            // 
            this.panelDetalleCompra.Controls.Add(this.dgvDetalleCompra);
            this.panelDetalleCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalleCompra.Location = new System.Drawing.Point(0, 394);
            this.panelDetalleCompra.Name = "panelDetalleCompra";
            this.panelDetalleCompra.Size = new System.Drawing.Size(1370, 235);
            this.panelDetalleCompra.TabIndex = 2;
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalleCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleCompra.ColumnHeadersHeight = 35;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.colProducto,
            this.colCantidad,
            this.Precio_compra,
            this.colSubtotal,
            this.Modelo,
            this.CodigoCompra,
            this.colIdMedida,
            this.colPermiteDecimal,
            this.colDecimales});
            this.dgvDetalleCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleCompra.EnableHeadersVisualStyles = false;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.RowHeadersWidth = 62;
            this.dgvDetalleCompra.RowTemplate.Height = 28;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(1370, 235);
            this.dgvDetalleCompra.TabIndex = 0;
            this.dgvDetalleCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCompra_CellContentClick);
            this.dgvDetalleCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCompra_CellDoubleClick);
            this.dgvDetalleCompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCompra_CellEndEdit);
            this.dgvDetalleCompra.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDetalleCompra_CellValidating);
            this.dgvDetalleCompra.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDetalleCompra_DataBindingComplete);
            this.dgvDetalleCompra.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalleCompra_RowsRemoved);
            this.dgvDetalleCompra.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDetalleCompra_UserDeletedRow);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID";
            this.IdProducto.MinimumWidth = 8;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 8;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            // 
            // Precio_compra
            // 
            this.Precio_compra.HeaderText = "Precio Compra";
            this.Precio_compra.MinimumWidth = 8;
            this.Precio_compra.Name = "Precio_compra";
            this.Precio_compra.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 8;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 8;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // CodigoCompra
            // 
            this.CodigoCompra.HeaderText = "Codigo Compra";
            this.CodigoCompra.MinimumWidth = 8;
            this.CodigoCompra.Name = "CodigoCompra";
            this.CodigoCompra.ReadOnly = true;
            // 
            // colIdMedida
            // 
            this.colIdMedida.HeaderText = "IdMedida";
            this.colIdMedida.MinimumWidth = 8;
            this.colIdMedida.Name = "colIdMedida";
            this.colIdMedida.ReadOnly = true;
            this.colIdMedida.Visible = false;
            // 
            // colPermiteDecimal
            // 
            this.colPermiteDecimal.HeaderText = "PermiteDecimal";
            this.colPermiteDecimal.MinimumWidth = 8;
            this.colPermiteDecimal.Name = "colPermiteDecimal";
            this.colPermiteDecimal.ReadOnly = true;
            this.colPermiteDecimal.Visible = false;
            // 
            // colDecimales
            // 
            this.colDecimales.HeaderText = "Decimales";
            this.colDecimales.MinimumWidth = 8;
            this.colDecimales.Name = "colDecimales";
            this.colDecimales.ReadOnly = true;
            this.colDecimales.Visible = false;
            // 
            // panelFooterCompra
            // 
            this.panelFooterCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooterCompra.Controls.Add(this.btnHistorialCompra);
            this.panelFooterCompra.Controls.Add(this.btnCancelarCaptura);
            this.panelFooterCompra.Controls.Add(this.btnGuardarCompra);
            this.panelFooterCompra.Controls.Add(this.lblTotalCompra);
            this.panelFooterCompra.Controls.Add(this.lblTituloTotalCompra);
            this.panelFooterCompra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterCompra.Location = new System.Drawing.Point(0, 521);
            this.panelFooterCompra.Name = "panelFooterCompra";
            this.panelFooterCompra.Size = new System.Drawing.Size(1370, 108);
            this.panelFooterCompra.TabIndex = 3;
            // 
            // btnHistorialCompra
            // 
            this.btnHistorialCompra.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHistorialCompra.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialCompra.Location = new System.Drawing.Point(698, 23);
            this.btnHistorialCompra.Name = "btnHistorialCompra";
            this.btnHistorialCompra.Size = new System.Drawing.Size(120, 71);
            this.btnHistorialCompra.TabIndex = 13;
            this.btnHistorialCompra.Text = "Historial Compras";
            this.btnHistorialCompra.UseVisualStyleBackColor = false;
            this.btnHistorialCompra.Click += new System.EventHandler(this.btnHistorialCompra_Click);
            // 
            // btnCancelarCaptura
            // 
            this.btnCancelarCaptura.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancelarCaptura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarCaptura.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarCaptura.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCaptura.Location = new System.Drawing.Point(301, 20);
            this.btnCancelarCaptura.Name = "btnCancelarCaptura";
            this.btnCancelarCaptura.Size = new System.Drawing.Size(123, 76);
            this.btnCancelarCaptura.TabIndex = 12;
            this.btnCancelarCaptura.Text = "Cerrar Compra";
            this.btnCancelarCaptura.UseVisualStyleBackColor = false;
            this.btnCancelarCaptura.Click += new System.EventHandler(this.btnCancelarCaptura_Click);
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCompra.Location = new System.Drawing.Point(84, 20);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(141, 76);
            this.btnGuardarCompra.TabIndex = 11;
            this.btnGuardarCompra.Text = "Guardar Compra";
            this.btnGuardarCompra.UseVisualStyleBackColor = false;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(1278, 20);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(84, 37);
            this.lblTotalCompra.TabIndex = 10;
            this.lblTotalCompra.Text = "0.00";
            // 
            // lblTituloTotalCompra
            // 
            this.lblTituloTotalCompra.AutoSize = true;
            this.lblTituloTotalCompra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalCompra.Location = new System.Drawing.Point(1167, 25);
            this.lblTituloTotalCompra.Name = "lblTituloTotalCompra";
            this.lblTituloTotalCompra.Size = new System.Drawing.Size(105, 26);
            this.lblTituloTotalCompra.TabIndex = 0;
            this.lblTituloTotalCompra.Text = "TOTAL :";
            // 
            // timerReloj
            // 
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 629);
            this.Controls.Add(this.panelFooterCompra);
            this.Controls.Add(this.panelDetalleCompra);
            this.Controls.Add(this.panelCapturaCompra);
            this.Controls.Add(this.panelHeaderCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FrmCompras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Compras.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompras_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.panelHeaderCompra.ResumeLayout(false);
            this.panelHeaderCompra.PerformLayout();
            this.panelCapturaCompra.ResumeLayout(false);
            this.panelCapturaCompra.PerformLayout();
            this.panelDetalleCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.panelFooterCompra.ResumeLayout(false);
            this.panelFooterCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderCompra;
        private System.Windows.Forms.Panel panelCapturaCompra;
        private System.Windows.Forms.Panel panelDetalleCompra;
        private System.Windows.Forms.Panel panelFooterCompra;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.Label lblFolioCompra;
        private System.Windows.Forms.Label lblTituloFolio;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.TextBox txtFacturaProveedor;
        private System.Windows.Forms.Label lblTituloFactura;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblTituloProveedor;
        private System.Windows.Forms.TextBox txtCantidadCompra;
        private System.Windows.Forms.Label lblTituloCantidadCompra;
        private System.Windows.Forms.TextBox txtBuscarProductoCompra;
        private System.Windows.Forms.Label lblTituloPrecioCompra;
        private System.Windows.Forms.Label lblTituloPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Label lblTituloStock;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblTituloGanancia;
        private System.Windows.Forms.Button btnAgregarProductoCompra;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblTituloTotalCompra;
        private System.Windows.Forms.Button btnCancelarCaptura;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.Label lblTituloMarca;
        private System.Windows.Forms.Label lblModeloProducto;
        private System.Windows.Forms.Label lblTituloModelo;
        private System.Windows.Forms.Label lblCodigoCompraProducto;
        private System.Windows.Forms.Label lblTituloCodigoCompra;
        private System.Windows.Forms.Label lblProveedorProducto;
        private System.Windows.Forms.Label lblTituloProveedorProducto;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Label lblPrecioVentaActual;
        private System.Windows.Forms.Label lblTituloPrecioVentaActual;
        private System.Windows.Forms.Button btnHistorialCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPermiteDecimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDecimales;
        private System.Windows.Forms.Button btnLimpiarProductoCompra;
        private System.Windows.Forms.Label lblInfo;
    }
}