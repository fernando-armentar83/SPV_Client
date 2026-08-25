namespace SPV_Client
{
    partial class FrmItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItem));
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnMarca = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblTituloDatos = new System.Windows.Forms.Label();
            this.pnlInventarioCompras = new System.Windows.Forms.Panel();
            this.chkPermiteVentaImporte = new System.Windows.Forms.CheckBox();
            this.txtCodigoCompra = new System.Windows.Forms.TextBox();
            this.lblCodigoCompra = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.btnSocio = new System.Windows.Forms.Button();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.lblSocio = new System.Windows.Forms.Label();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnUnidad = new System.Windows.Forms.Button();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblTituloInventario = new System.Windows.Forms.Label();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.txtPorcentajeGanancia = new System.Windows.Forms.TextBox();
            this.lblPorcentajeGanancia = new System.Windows.Forms.Label();
            this.cmbActivo = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblTituloVentas = new System.Windows.Forms.Label();
            this.pnlObservaciones = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblTituloObservaciones = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCerrarItem = new System.Windows.Forms.Button();
            this.btnKardexItem = new System.Windows.Forms.Button();
            this.btnDesactivarItem = new System.Windows.Forms.Button();
            this.btnGuardarItem = new System.Windows.Forms.Button();
            this.btnNuevoItem = new System.Windows.Forms.Button();
            this.pnlDatosGenerales.SuspendLayout();
            this.pnlInventarioCompras.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.pnlObservaciones.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.BackColor = System.Drawing.Color.LightBlue;
            this.pnlDatosGenerales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosGenerales.Controls.Add(this.lblIdProducto);
            this.pnlDatosGenerales.Controls.Add(this.txtModelo);
            this.pnlDatosGenerales.Controls.Add(this.lblModelo);
            this.pnlDatosGenerales.Controls.Add(this.btnMarca);
            this.pnlDatosGenerales.Controls.Add(this.cmbMarca);
            this.pnlDatosGenerales.Controls.Add(this.lblMarca);
            this.pnlDatosGenerales.Controls.Add(this.btnCategoria);
            this.pnlDatosGenerales.Controls.Add(this.cmbCategoria);
            this.pnlDatosGenerales.Controls.Add(this.lblCategoria);
            this.pnlDatosGenerales.Controls.Add(this.txtProducto);
            this.pnlDatosGenerales.Controls.Add(this.lblProducto);
            this.pnlDatosGenerales.Controls.Add(this.lblTituloDatos);
            this.pnlDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosGenerales.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(1276, 230);
            this.pnlDatosGenerales.TabIndex = 0;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(10, 55);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(18, 20);
            this.lblIdProducto.TabIndex = 11;
            this.lblIdProducto.Text = "0";
            this.lblIdProducto.Visible = false;
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(763, 152);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(250, 33);
            this.txtModelo.TabIndex = 10;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(763, 127);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(75, 22);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = "Modelo";
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.LightCyan;
            this.btnMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarca.BackgroundImage")));
            this.btnMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMarca.Location = new System.Drawing.Point(698, 146);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(40, 33);
            this.btnMarca.TabIndex = 41;
            this.btnMarca.UseVisualStyleBackColor = false;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(443, 152);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(250, 34);
            this.cmbMarca.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(443, 127);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(82, 22);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca *";
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.LightCyan;
            this.btnCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCategoria.BackgroundImage")));
            this.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategoria.Location = new System.Drawing.Point(378, 146);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(40, 33);
            this.btnCategoria.TabIndex = 40;
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(123, 152);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 34);
            this.cmbCategoria.TabIndex = 4;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(123, 127);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(113, 22);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría *";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProducto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(123, 65);
            this.txtProducto.Multiline = true;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(700, 42);
            this.txtProducto.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(123, 45);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(113, 22);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = " Producto *";
            // 
            // lblTituloDatos
            // 
            this.lblTituloDatos.AutoSize = true;
            this.lblTituloDatos.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDatos.Location = new System.Drawing.Point(10, 10);
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.Size = new System.Drawing.Size(227, 27);
            this.lblTituloDatos.TabIndex = 0;
            this.lblTituloDatos.Text = "DATOS GENERALES";
            // 
            // pnlInventarioCompras
            // 
            this.pnlInventarioCompras.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInventarioCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventarioCompras.Controls.Add(this.chkPermiteVentaImporte);
            this.pnlInventarioCompras.Controls.Add(this.txtCodigoCompra);
            this.pnlInventarioCompras.Controls.Add(this.lblCodigoCompra);
            this.pnlInventarioCompras.Controls.Add(this.dtpFechaCompra);
            this.pnlInventarioCompras.Controls.Add(this.lblFechaCompra);
            this.pnlInventarioCompras.Controls.Add(this.txtStockMinimo);
            this.pnlInventarioCompras.Controls.Add(this.lblStockMinimo);
            this.pnlInventarioCompras.Controls.Add(this.txtStockActual);
            this.pnlInventarioCompras.Controls.Add(this.lblStockActual);
            this.pnlInventarioCompras.Controls.Add(this.btnSocio);
            this.pnlInventarioCompras.Controls.Add(this.cmbSocio);
            this.pnlInventarioCompras.Controls.Add(this.lblSocio);
            this.pnlInventarioCompras.Controls.Add(this.btnProveedor);
            this.pnlInventarioCompras.Controls.Add(this.cmbProveedor);
            this.pnlInventarioCompras.Controls.Add(this.lblProveedor);
            this.pnlInventarioCompras.Controls.Add(this.btnUnidad);
            this.pnlInventarioCompras.Controls.Add(this.cmbUnidad);
            this.pnlInventarioCompras.Controls.Add(this.lblUnidad);
            this.pnlInventarioCompras.Controls.Add(this.lblTituloInventario);
            this.pnlInventarioCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventarioCompras.Location = new System.Drawing.Point(0, 230);
            this.pnlInventarioCompras.Name = "pnlInventarioCompras";
            this.pnlInventarioCompras.Size = new System.Drawing.Size(1276, 280);
            this.pnlInventarioCompras.TabIndex = 1;
            // 
            // chkPermiteVentaImporte
            // 
            this.chkPermiteVentaImporte.AutoSize = true;
            this.chkPermiteVentaImporte.Location = new System.Drawing.Point(11, 176);
            this.chkPermiteVentaImporte.Name = "chkPermiteVentaImporte";
            this.chkPermiteVentaImporte.Size = new System.Drawing.Size(239, 24);
            this.chkPermiteVentaImporte.TabIndex = 42;
            this.chkPermiteVentaImporte.Text = "Permite venta por importe ($)";
            this.chkPermiteVentaImporte.UseVisualStyleBackColor = true;
            // 
            // txtCodigoCompra
            // 
            this.txtCodigoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoCompra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCompra.Location = new System.Drawing.Point(677, 176);
            this.txtCodigoCompra.Name = "txtCodigoCompra";
            this.txtCodigoCompra.Size = new System.Drawing.Size(220, 36);
            this.txtCodigoCompra.TabIndex = 15;
            this.txtCodigoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigoCompra
            // 
            this.lblCodigoCompra.AutoSize = true;
            this.lblCodigoCompra.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCompra.Location = new System.Drawing.Point(677, 144);
            this.lblCodigoCompra.Name = "lblCodigoCompra";
            this.lblCodigoCompra.Size = new System.Drawing.Size(146, 22);
            this.lblCodigoCompra.TabIndex = 31;
            this.lblCodigoCompra.Text = "Código Compra";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(437, 176);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(180, 36);
            this.dtpFechaCompra.TabIndex = 14;
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCompra.Location = new System.Drawing.Point(437, 144);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(139, 22);
            this.lblFechaCompra.TabIndex = 14;
            this.lblFechaCompra.Text = "Fecha Compra";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMinimo.Location = new System.Drawing.Point(277, 176);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(120, 26);
            this.txtStockMinimo.TabIndex = 13;
            this.txtStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo.Location = new System.Drawing.Point(277, 144);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(131, 22);
            this.lblStockMinimo.TabIndex = 12;
            this.lblStockMinimo.Text = "Stock Mínimo";
            // 
            // txtStockActual
            // 
            this.txtStockActual.BackColor = System.Drawing.Color.White;
            this.txtStockActual.Enabled = false;
            this.txtStockActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockActual.Location = new System.Drawing.Point(1131, 111);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(120, 36);
            this.txtStockActual.TabIndex = 11;
            this.txtStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockActual.Location = new System.Drawing.Point(1138, 79);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(122, 22);
            this.lblStockActual.TabIndex = 10;
            this.lblStockActual.Text = "Stock Actual";
            // 
            // btnSocio
            // 
            this.btnSocio.BackColor = System.Drawing.Color.LightCyan;
            this.btnSocio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSocio.BackgroundImage")));
            this.btnSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSocio.Location = new System.Drawing.Point(1036, 70);
            this.btnSocio.Name = "btnSocio";
            this.btnSocio.Size = new System.Drawing.Size(40, 33);
            this.btnSocio.TabIndex = 44;
            this.btnSocio.UseVisualStyleBackColor = false;
            this.btnSocio.Click += new System.EventHandler(this.btnSocio_Click);
            // 
            // cmbSocio
            // 
            this.cmbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(781, 74);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(250, 36);
            this.cmbSocio.TabIndex = 8;
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(781, 45);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(74, 22);
            this.lblSocio.TabIndex = 7;
            this.lblSocio.Text = "Socio *";
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.LightCyan;
            this.btnProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedor.BackgroundImage")));
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProveedor.Location = new System.Drawing.Point(706, 68);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(40, 33);
            this.btnProveedor.TabIndex = 43;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(421, 74);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(280, 34);
            this.cmbProveedor.TabIndex = 5;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(421, 45);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(119, 22);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor *";
            // 
            // btnUnidad
            // 
            this.btnUnidad.BackColor = System.Drawing.Color.LightCyan;
            this.btnUnidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnidad.BackgroundImage")));
            this.btnUnidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnidad.Location = new System.Drawing.Point(346, 68);
            this.btnUnidad.Name = "btnUnidad";
            this.btnUnidad.Size = new System.Drawing.Size(40, 33);
            this.btnUnidad.TabIndex = 42;
            this.btnUnidad.UseVisualStyleBackColor = false;
            this.btnUnidad.Click += new System.EventHandler(this.btnUnidad_Click);
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(121, 74);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(220, 36);
            this.cmbUnidad.TabIndex = 2;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(121, 45);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(89, 22);
            this.lblUnidad.TabIndex = 1;
            this.lblUnidad.Text = "Unidad *";
            // 
            // lblTituloInventario
            // 
            this.lblTituloInventario.AutoSize = true;
            this.lblTituloInventario.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInventario.Location = new System.Drawing.Point(10, 10);
            this.lblTituloInventario.Name = "lblTituloInventario";
            this.lblTituloInventario.Size = new System.Drawing.Size(296, 27);
            this.lblTituloInventario.TabIndex = 0;
            this.lblTituloInventario.Text = "INVENTARIO Y COMPRAS";
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.SystemColors.Control;
            this.pnlVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVentas.Controls.Add(this.txtPorcentajeGanancia);
            this.pnlVentas.Controls.Add(this.lblPorcentajeGanancia);
            this.pnlVentas.Controls.Add(this.cmbActivo);
            this.pnlVentas.Controls.Add(this.lblActivo);
            this.pnlVentas.Controls.Add(this.txtCodigoBarras);
            this.pnlVentas.Controls.Add(this.lblCodigoBarras);
            this.pnlVentas.Controls.Add(this.txtPrecioVenta);
            this.pnlVentas.Controls.Add(this.lblPrecioVenta);
            this.pnlVentas.Controls.Add(this.txtPrecioCompra);
            this.pnlVentas.Controls.Add(this.lblPrecioCompra);
            this.pnlVentas.Controls.Add(this.lblTituloVentas);
            this.pnlVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentas.Location = new System.Drawing.Point(0, 510);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(1276, 200);
            this.pnlVentas.TabIndex = 2;
            // 
            // txtPorcentajeGanancia
            // 
            this.txtPorcentajeGanancia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeGanancia.Location = new System.Drawing.Point(494, 102);
            this.txtPorcentajeGanancia.Name = "txtPorcentajeGanancia";
            this.txtPorcentajeGanancia.Size = new System.Drawing.Size(120, 36);
            this.txtPorcentajeGanancia.TabIndex = 6;
            this.txtPorcentajeGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPorcentajeGanancia.Leave += new System.EventHandler(this.txtPorcentajeGanancia_Leave);
            // 
            // lblPorcentajeGanancia
            // 
            this.lblPorcentajeGanancia.AutoSize = true;
            this.lblPorcentajeGanancia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeGanancia.Location = new System.Drawing.Point(494, 72);
            this.lblPorcentajeGanancia.Name = "lblPorcentajeGanancia";
            this.lblPorcentajeGanancia.Size = new System.Drawing.Size(122, 22);
            this.lblPorcentajeGanancia.TabIndex = 9;
            this.lblPorcentajeGanancia.Text = "% Ganancia";
            // 
            // cmbActivo
            // 
            this.cmbActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivo.FormattingEnabled = true;
            this.cmbActivo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbActivo.Location = new System.Drawing.Point(1007, 102);
            this.cmbActivo.Name = "cmbActivo";
            this.cmbActivo.Size = new System.Drawing.Size(150, 27);
            this.cmbActivo.TabIndex = 9;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(1007, 72);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(70, 22);
            this.lblActivo.TabIndex = 7;
            this.lblActivo.Text = "Estado";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(697, 102);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(250, 36);
            this.txtCodigoBarras.TabIndex = 8;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.Location = new System.Drawing.Point(697, 72);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(135, 22);
            this.lblCodigoBarras.TabIndex = 5;
            this.lblCodigoBarras.Text = "Código Barras";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(314, 102);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(120, 36);
            this.txtPrecioVenta.TabIndex = 4;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(314, 72);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(141, 22);
            this.lblPrecioVenta.TabIndex = 3;
            this.lblPrecioVenta.Text = "Precio Venta *";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(154, 102);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(120, 36);
            this.txtPrecioCompra.TabIndex = 2;
            this.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioCompra.Leave += new System.EventHandler(this.txtPrecioCompra_Leave);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(154, 72);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(158, 22);
            this.lblPrecioCompra.TabIndex = 1;
            this.lblPrecioCompra.Text = "Precio Compra *";
            // 
            // lblTituloVentas
            // 
            this.lblTituloVentas.AutoSize = true;
            this.lblTituloVentas.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentas.Location = new System.Drawing.Point(10, 10);
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.Size = new System.Drawing.Size(228, 27);
            this.lblTituloVentas.TabIndex = 0;
            this.lblTituloVentas.Text = "VENTAS Y PRECIOS";
            // 
            // pnlObservaciones
            // 
            this.pnlObservaciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlObservaciones.Controls.Add(this.txtObservaciones);
            this.pnlObservaciones.Controls.Add(this.lblTituloObservaciones);
            this.pnlObservaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlObservaciones.Location = new System.Drawing.Point(0, 710);
            this.pnlObservaciones.Name = "pnlObservaciones";
            this.pnlObservaciones.Size = new System.Drawing.Size(1276, 160);
            this.pnlObservaciones.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(20, 40);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(1198, 80);
            this.txtObservaciones.TabIndex = 1;
            // 
            // lblTituloObservaciones
            // 
            this.lblTituloObservaciones.AutoSize = true;
            this.lblTituloObservaciones.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloObservaciones.Location = new System.Drawing.Point(10, 10);
            this.lblTituloObservaciones.Name = "lblTituloObservaciones";
            this.lblTituloObservaciones.Size = new System.Drawing.Size(206, 27);
            this.lblTituloObservaciones.TabIndex = 0;
            this.lblTituloObservaciones.Text = "OBSERVACIONES";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnCerrarItem);
            this.pnlBotones.Controls.Add(this.btnKardexItem);
            this.pnlBotones.Controls.Add(this.btnDesactivarItem);
            this.pnlBotones.Controls.Add(this.btnGuardarItem);
            this.pnlBotones.Controls.Add(this.btnNuevoItem);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 869);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1276, 130);
            this.pnlBotones.TabIndex = 4;
            // 
            // btnCerrarItem
            // 
            this.btnCerrarItem.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarItem.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnCerrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarItem.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCerrarItem.Image = global::SPV_Client.Properties.Resources.close32px;
            this.btnCerrarItem.Location = new System.Drawing.Point(1059, 6);
            this.btnCerrarItem.Name = "btnCerrarItem";
            this.btnCerrarItem.Size = new System.Drawing.Size(138, 111);
            this.btnCerrarItem.TabIndex = 4;
            this.btnCerrarItem.Text = "Cerrar";
            this.btnCerrarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarItem.UseVisualStyleBackColor = false;
            this.btnCerrarItem.Click += new System.EventHandler(this.btnCerrarItem_Click_1);
            // 
            // btnKardexItem
            // 
            this.btnKardexItem.BackColor = System.Drawing.Color.MintCream;
            this.btnKardexItem.Enabled = false;
            this.btnKardexItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKardexItem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKardexItem.Image = global::SPV_Client.Properties.Resources.inventorykardex32px;
            this.btnKardexItem.Location = new System.Drawing.Point(839, 6);
            this.btnKardexItem.Name = "btnKardexItem";
            this.btnKardexItem.Size = new System.Drawing.Size(138, 111);
            this.btnKardexItem.TabIndex = 3;
            this.btnKardexItem.Text = "Kardex";
            this.btnKardexItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKardexItem.UseVisualStyleBackColor = false;
            // 
            // btnDesactivarItem
            // 
            this.btnDesactivarItem.BackColor = System.Drawing.Color.MintCream;
            this.btnDesactivarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesactivarItem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarItem.Image = global::SPV_Client.Properties.Resources.switch_32px;
            this.btnDesactivarItem.Location = new System.Drawing.Point(608, 6);
            this.btnDesactivarItem.Name = "btnDesactivarItem";
            this.btnDesactivarItem.Size = new System.Drawing.Size(138, 111);
            this.btnDesactivarItem.TabIndex = 2;
            this.btnDesactivarItem.Text = "Desactivar";
            this.btnDesactivarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesactivarItem.UseVisualStyleBackColor = false;
            this.btnDesactivarItem.Click += new System.EventHandler(this.btnDesactivarItem_Click);
            // 
            // btnGuardarItem
            // 
            this.btnGuardarItem.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarItem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarItem.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarItem.Image")));
            this.btnGuardarItem.Location = new System.Drawing.Point(362, 6);
            this.btnGuardarItem.Name = "btnGuardarItem";
            this.btnGuardarItem.Size = new System.Drawing.Size(138, 111);
            this.btnGuardarItem.TabIndex = 1;
            this.btnGuardarItem.Text = "Guardar";
            this.btnGuardarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarItem.UseVisualStyleBackColor = false;
            this.btnGuardarItem.Click += new System.EventHandler(this.btnGuardarItem_Click);
            // 
            // btnNuevoItem
            // 
            this.btnNuevoItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoItem.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevoItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoItem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoItem.Image")));
            this.btnNuevoItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoItem.Location = new System.Drawing.Point(158, 6);
            this.btnNuevoItem.Name = "btnNuevoItem";
            this.btnNuevoItem.Size = new System.Drawing.Size(138, 111);
            this.btnNuevoItem.TabIndex = 0;
            this.btnNuevoItem.Text = "Nuevo";
            this.btnNuevoItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoItem.UseCompatibleTextRendering = true;
            this.btnNuevoItem.UseVisualStyleBackColor = false;
            this.btnNuevoItem.Click += new System.EventHandler(this.btnNuevoItem_Click);
            // 
            // FrmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1276, 999);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlObservaciones);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.pnlInventarioCompras);
            this.Controls.Add(this.pnlDatosGenerales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmItem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmItem_Load);
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.pnlInventarioCompras.ResumeLayout(false);
            this.pnlInventarioCompras.PerformLayout();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.pnlObservaciones.ResumeLayout(false);
            this.pnlObservaciones.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Panel pnlInventarioCompras;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblTituloInventario;
        private System.Windows.Forms.Button btnUnidad;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbSocio;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Button btnSocio;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.TextBox txtCodigoCompra;
        private System.Windows.Forms.Label lblCodigoCompra;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Label lblTituloVentas;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.ComboBox cmbActivo;
        private System.Windows.Forms.TextBox txtPorcentajeGanancia;
        private System.Windows.Forms.Label lblPorcentajeGanancia;
        private System.Windows.Forms.Panel pnlObservaciones;
        private System.Windows.Forms.Label lblTituloObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnNuevoItem;
        private System.Windows.Forms.Button btnGuardarItem;
        private System.Windows.Forms.Button btnDesactivarItem;
        private System.Windows.Forms.Button btnKardexItem;
        private System.Windows.Forms.Button btnCerrarItem;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.CheckBox chkPermiteVentaImporte;
    }
}