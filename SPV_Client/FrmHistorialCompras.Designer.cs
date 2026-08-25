namespace SPV_Client
{
    partial class FrmHistorialCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnBuscarCompras = new System.Windows.Forms.Button();
            this.cmbEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbUsuarioFiltro = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbProveedorFiltro = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtBuscarFolio = new System.Windows.Forms.TextBox();
            this.lblBuscarFolio = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.dgvHistorialCompras = new System.Windows.Forms.DataGridView();
            this.colIdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTituloDetalle = new System.Windows.Forms.Panel();
            this.lblDetalleCompra = new System.Windows.Forms.Label();
            this.panelInfoDetalle = new System.Windows.Forms.Panel();
            this.lblCantidadItems = new System.Windows.Forms.Label();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.panelFiltros.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompras)).BeginInit();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.panelTituloDetalle.SuspendLayout();
            this.panelInfoDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.Gainsboro;
            this.panelFiltros.Controls.Add(this.btnExportarPdf);
            this.panelFiltros.Controls.Add(this.btnExportarExcel);
            this.panelFiltros.Controls.Add(this.btnCancelarCompra);
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.panelFiltros.Controls.Add(this.btnBuscarCompras);
            this.panelFiltros.Controls.Add(this.cmbEstadoFiltro);
            this.panelFiltros.Controls.Add(this.lblEstado);
            this.panelFiltros.Controls.Add(this.cmbUsuarioFiltro);
            this.panelFiltros.Controls.Add(this.lblUsuario);
            this.panelFiltros.Controls.Add(this.cmbProveedorFiltro);
            this.panelFiltros.Controls.Add(this.lblProveedor);
            this.panelFiltros.Controls.Add(this.dtpFechaFin);
            this.panelFiltros.Controls.Add(this.lblFechaFin);
            this.panelFiltros.Controls.Add(this.dtpFechaInicio);
            this.panelFiltros.Controls.Add(this.lblFechaInicio);
            this.panelFiltros.Controls.Add(this.txtBuscarFolio);
            this.panelFiltros.Controls.Add(this.lblBuscarFolio);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1469, 204);
            this.panelFiltros.TabIndex = 0;
            this.panelFiltros.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFiltros_Paint);
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.BackColor = System.Drawing.Color.MintCream;
            this.btnExportarPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExportarPdf.FlatAppearance.BorderSize = 3;
            this.btnExportarPdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPdf.Location = new System.Drawing.Point(1161, 140);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(84, 43);
            this.btnExportarPdf.TabIndex = 17;
            this.btnExportarPdf.Text = "PDF";
            this.btnExportarPdf.UseVisualStyleBackColor = false;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.MintCream;
            this.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExportarExcel.FlatAppearance.BorderSize = 3;
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Location = new System.Drawing.Point(1161, 45);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(84, 43);
            this.btnExportarExcel.TabIndex = 16;
            this.btnExportarExcel.Text = "Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarCompra.Location = new System.Drawing.Point(505, 121);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(101, 58);
            this.btnCancelarCompra.TabIndex = 15;
            this.btnCancelarCompra.Text = "Cancelar Compra";
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.Aqua;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(318, 139);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(87, 37);
            this.btnLimpiarFiltros.TabIndex = 14;
            this.btnLimpiarFiltros.Text = "LIMPIAR";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnBuscarCompras
            // 
            this.btnBuscarCompras.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarCompras.Location = new System.Drawing.Point(183, 139);
            this.btnBuscarCompras.Name = "btnBuscarCompras";
            this.btnBuscarCompras.Size = new System.Drawing.Size(92, 37);
            this.btnBuscarCompras.TabIndex = 13;
            this.btnBuscarCompras.Text = "BUSCAR :";
            this.btnBuscarCompras.UseVisualStyleBackColor = false;
            this.btnBuscarCompras.Click += new System.EventHandler(this.btnBuscarCompras_Click);
            // 
            // cmbEstadoFiltro
            // 
            this.cmbEstadoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEstadoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFiltro.FormattingEnabled = true;
            this.cmbEstadoFiltro.Items.AddRange(new object[] {
            "Todas",
            "Activa",
            "Cancelada"});
            this.cmbEstadoFiltro.Location = new System.Drawing.Point(866, 139);
            this.cmbEstadoFiltro.Name = "cmbEstadoFiltro";
            this.cmbEstadoFiltro.Size = new System.Drawing.Size(250, 33);
            this.cmbEstadoFiltro.TabIndex = 12;
            this.cmbEstadoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoFiltro_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(708, 142);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(87, 25);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "ESTADO :";
            // 
            // cmbUsuarioFiltro
            // 
            this.cmbUsuarioFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbUsuarioFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioFiltro.FormattingEnabled = true;
            this.cmbUsuarioFiltro.Location = new System.Drawing.Point(866, 63);
            this.cmbUsuarioFiltro.Name = "cmbUsuarioFiltro";
            this.cmbUsuarioFiltro.Size = new System.Drawing.Size(250, 33);
            this.cmbUsuarioFiltro.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(686, 66);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(97, 25);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "USUARIO :";
            // 
            // cmbProveedorFiltro
            // 
            this.cmbProveedorFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbProveedorFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedorFiltro.FormattingEnabled = true;
            this.cmbProveedorFiltro.Location = new System.Drawing.Point(866, 15);
            this.cmbProveedorFiltro.Name = "cmbProveedorFiltro";
            this.cmbProveedorFiltro.Size = new System.Drawing.Size(250, 33);
            this.cmbProveedorFiltro.TabIndex = 8;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(672, 19);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(123, 25);
            this.lblProveedor.TabIndex = 7;
            this.lblProveedor.Text = "PROVEEDOR :";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(466, 60);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 31);
            this.dtpFechaFin.TabIndex = 6;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(277, 63);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(107, 25);
            this.lblFechaFin.TabIndex = 5;
            this.lblFechaFin.Text = "FECHA FIN :";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(466, 14);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 31);
            this.dtpFechaInicio.TabIndex = 4;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(245, 18);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(160, 25);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "FECHA DE INICIO :";
            // 
            // txtBuscarFolio
            // 
            this.txtBuscarFolio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBuscarFolio.Location = new System.Drawing.Point(98, 60);
            this.txtBuscarFolio.Name = "txtBuscarFolio";
            this.txtBuscarFolio.Size = new System.Drawing.Size(120, 31);
            this.txtBuscarFolio.TabIndex = 2;
            // 
            // lblBuscarFolio
            // 
            this.lblBuscarFolio.AutoSize = true;
            this.lblBuscarFolio.Location = new System.Drawing.Point(21, 62);
            this.lblBuscarFolio.Name = "lblBuscarFolio";
            this.lblBuscarFolio.Size = new System.Drawing.Size(71, 25);
            this.lblBuscarFolio.TabIndex = 0;
            this.lblBuscarFolio.Text = "FOLIO :";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Controls.Add(this.dgvHistorialCompras);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1469, 723);
            this.panelContenido.TabIndex = 1;
            // 
            // dgvHistorialCompras
            // 
            this.dgvHistorialCompras.AllowUserToAddRows = false;
            this.dgvHistorialCompras.AllowUserToDeleteRows = false;
            this.dgvHistorialCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHistorialCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorialCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorialCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorialCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorialCompras.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialCompras.ColumnHeadersHeight = 38;
            this.dgvHistorialCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCompra,
            this.colFolio,
            this.colFecha,
            this.colProveedor,
            this.colUsuario,
            this.colTotal,
            this.colEstado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialCompras.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHistorialCompras.EnableHeadersVisualStyles = false;
            this.dgvHistorialCompras.Location = new System.Drawing.Point(3, 205);
            this.dgvHistorialCompras.MultiSelect = false;
            this.dgvHistorialCompras.Name = "dgvHistorialCompras";
            this.dgvHistorialCompras.ReadOnly = true;
            this.dgvHistorialCompras.RowHeadersVisible = false;
            this.dgvHistorialCompras.RowHeadersWidth = 62;
            this.dgvHistorialCompras.RowTemplate.Height = 28;
            this.dgvHistorialCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialCompras.Size = new System.Drawing.Size(1463, 518);
            this.dgvHistorialCompras.TabIndex = 0;
            this.dgvHistorialCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialCompras_CellClick);
            this.dgvHistorialCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialCompras_CellDoubleClick);
            // 
            // colIdCompra
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colIdCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.colIdCompra.FillWeight = 63.63636F;
            this.colIdCompra.HeaderText = "ID";
            this.colIdCompra.MinimumWidth = 8;
            this.colIdCompra.Name = "colIdCompra";
            this.colIdCompra.ReadOnly = true;
            this.colIdCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colIdCompra.Visible = false;
            // 
            // colFolio
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFolio.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFolio.FillWeight = 106.0606F;
            this.colFolio.HeaderText = "Folio";
            this.colFolio.MinimumWidth = 8;
            this.colFolio.Name = "colFolio";
            this.colFolio.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 106.0606F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 8;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colProveedor
            // 
            this.colProveedor.FillWeight = 106.0606F;
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.MinimumWidth = 8;
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colUsuario
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUsuario.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUsuario.FillWeight = 106.0606F;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.MinimumWidth = 8;
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTotal.FillWeight = 106.0606F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colEstado
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colEstado.DefaultCellStyle = dataGridViewCellStyle7;
            this.colEstado.FillWeight = 106.0606F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 8;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.SkyBlue;
            this.panelDetalle.Controls.Add(this.dgvDetalleCompra);
            this.panelDetalle.Controls.Add(this.panelTituloDetalle);
            this.panelDetalle.Controls.Add(this.panelInfoDetalle);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetalle.Location = new System.Drawing.Point(0, 723);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(1469, 220);
            this.panelDetalle.TabIndex = 2;
            this.panelDetalle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDetalle_Paint);
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.AllowUserToResizeRows = false;
            this.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colProducto,
            this.colCantidad,
            this.colPrecioCompra,
            this.colSubtotal});
            this.dgvDetalleCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(0, 41);
            this.dgvDetalleCompra.MultiSelect = false;
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.RowHeadersVisible = false;
            this.dgvDetalleCompra.RowHeadersWidth = 62;
            this.dgvDetalleCompra.RowTemplate.Height = 28;
            this.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(1469, 142);
            this.dgvDetalleCompra.TabIndex = 1;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "ID";
            this.colIdProducto.MinimumWidth = 8;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 250F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 8;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle9;
            this.colCantidad.FillWeight = 70F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecioCompra
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPrecioCompra.DefaultCellStyle = dataGridViewCellStyle10;
            this.colPrecioCompra.FillWeight = 90F;
            this.colPrecioCompra.HeaderText = "Precio Compra";
            this.colPrecioCompra.MinimumWidth = 8;
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSubtotal.DefaultCellStyle = dataGridViewCellStyle11;
            this.colSubtotal.FillWeight = 90F;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 8;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // panelTituloDetalle
            // 
            this.panelTituloDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTituloDetalle.Controls.Add(this.lblDetalleCompra);
            this.panelTituloDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDetalle.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDetalle.Name = "panelTituloDetalle";
            this.panelTituloDetalle.Size = new System.Drawing.Size(1469, 41);
            this.panelTituloDetalle.TabIndex = 3;
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.AutoSize = true;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCompra.Location = new System.Drawing.Point(614, 12);
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(192, 28);
            this.lblDetalleCompra.TabIndex = 0;
            this.lblDetalleCompra.Text = "Detalle de compra ";
            this.lblDetalleCompra.UseMnemonic = false;
            // 
            // panelInfoDetalle
            // 
            this.panelInfoDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoDetalle.Controls.Add(this.lblCantidadItems);
            this.panelInfoDetalle.Controls.Add(this.lblTotalDetalle);
            this.panelInfoDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfoDetalle.Location = new System.Drawing.Point(0, 183);
            this.panelInfoDetalle.Name = "panelInfoDetalle";
            this.panelInfoDetalle.Size = new System.Drawing.Size(1469, 37);
            this.panelInfoDetalle.TabIndex = 4;
            // 
            // lblCantidadItems
            // 
            this.lblCantidadItems.AutoSize = true;
            this.lblCantidadItems.Location = new System.Drawing.Point(327, 1);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(117, 25);
            this.lblCantidadItems.TabIndex = 1;
            this.lblCantidadItems.Text = "Productos : 0";
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.AutoSize = true;
            this.lblTotalDetalle.Location = new System.Drawing.Point(1100, 1);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(107, 25);
            this.lblTotalDetalle.TabIndex = 0;
            this.lblTotalDetalle.Text = "Total : $0.00";
            // 
            // FrmHistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1469, 943);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelDetalle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHistorialCompras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHistorialCompras_Load);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompras)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.panelTituloDetalle.ResumeLayout(false);
            this.panelTituloDetalle.PerformLayout();
            this.panelInfoDetalle.ResumeLayout(false);
            this.panelInfoDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblBuscarFolio;
        private System.Windows.Forms.TextBox txtBuscarFolio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.ComboBox cmbProveedorFiltro;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.ComboBox cmbUsuarioFiltro;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbEstadoFiltro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnBuscarCompras;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.DataGridView dgvHistorialCompras;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Panel panelTituloDetalle;
        private System.Windows.Forms.Label lblDetalleCompra;
        private System.Windows.Forms.Panel panelInfoDetalle;
        private System.Windows.Forms.Label lblCantidadItems;
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.Button btnExportarExcel;
    }
}