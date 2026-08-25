namespace SPV_Client
{
    partial class FrmHistorialVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFiltrosVentas = new System.Windows.Forms.Panel();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCerrarHistorialVenta = new System.Windows.Forms.Button();
            this.btnReimprimirVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnLimpiarFiltroV = new System.Windows.Forms.Button();
            this.btnBuscarVentas = new System.Windows.Forms.Button();
            this.cmbEstadoV = new System.Windows.Forms.ComboBox();
            this.lblEstadoV = new System.Windows.Forms.Label();
            this.cmbFiltroUsuarioV = new System.Windows.Forms.ComboBox();
            this.lblUsuarioV = new System.Windows.Forms.Label();
            this.dtpFechaFinV = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicioV = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinV = new System.Windows.Forms.Label();
            this.lblFechaInicioV = new System.Windows.Forms.Label();
            this.txtBuscarFolioV = new System.Windows.Forms.TextBox();
            this.lblBuscarFolioV = new System.Windows.Forms.Label();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.dgvHistorialVentas = new System.Windows.Forms.DataGridView();
            this.colIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetalleVenta = new System.Windows.Forms.Panel();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInfoDetalleV = new System.Windows.Forms.Panel();
            this.lblTotalDetalleV = new System.Windows.Forms.Label();
            this.lblCantidadItemsV = new System.Windows.Forms.Label();
            this.panelTituloDetalleV = new System.Windows.Forms.Panel();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.panelFiltrosVentas.SuspendLayout();
            this.panelVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.panelDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.panelInfoDetalleV.SuspendLayout();
            this.panelTituloDetalleV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltrosVentas
            // 
            this.panelFiltrosVentas.BackColor = System.Drawing.Color.Gainsboro;
            this.panelFiltrosVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltrosVentas.Controls.Add(this.btnExportarPdf);
            this.panelFiltrosVentas.Controls.Add(this.btnExportarExcel);
            this.panelFiltrosVentas.Controls.Add(this.btnCerrarHistorialVenta);
            this.panelFiltrosVentas.Controls.Add(this.btnReimprimirVenta);
            this.panelFiltrosVentas.Controls.Add(this.btnCancelarVenta);
            this.panelFiltrosVentas.Controls.Add(this.btnLimpiarFiltroV);
            this.panelFiltrosVentas.Controls.Add(this.btnBuscarVentas);
            this.panelFiltrosVentas.Controls.Add(this.cmbEstadoV);
            this.panelFiltrosVentas.Controls.Add(this.lblEstadoV);
            this.panelFiltrosVentas.Controls.Add(this.cmbFiltroUsuarioV);
            this.panelFiltrosVentas.Controls.Add(this.lblUsuarioV);
            this.panelFiltrosVentas.Controls.Add(this.dtpFechaFinV);
            this.panelFiltrosVentas.Controls.Add(this.dtpFechaInicioV);
            this.panelFiltrosVentas.Controls.Add(this.lblFechaFinV);
            this.panelFiltrosVentas.Controls.Add(this.lblFechaInicioV);
            this.panelFiltrosVentas.Controls.Add(this.txtBuscarFolioV);
            this.panelFiltrosVentas.Controls.Add(this.lblBuscarFolioV);
            this.panelFiltrosVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltrosVentas.Location = new System.Drawing.Point(0, 0);
            this.panelFiltrosVentas.Name = "panelFiltrosVentas";
            this.panelFiltrosVentas.Size = new System.Drawing.Size(1469, 166);
            this.panelFiltrosVentas.TabIndex = 0;
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.BackColor = System.Drawing.Color.Cyan;
            this.btnExportarPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportarPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPdf.Location = new System.Drawing.Point(1153, 87);
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Size = new System.Drawing.Size(107, 40);
            this.btnExportarPdf.TabIndex = 17;
            this.btnExportarPdf.Text = "PDF";
            this.btnExportarPdf.UseVisualStyleBackColor = false;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.Cyan;
            this.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Location = new System.Drawing.Point(1153, 19);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(107, 40);
            this.btnExportarExcel.TabIndex = 16;
            this.btnExportarExcel.Text = "Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnCerrarHistorialVenta
            // 
            this.btnCerrarHistorialVenta.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCerrarHistorialVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarHistorialVenta.Location = new System.Drawing.Point(879, 119);
            this.btnCerrarHistorialVenta.Name = "btnCerrarHistorialVenta";
            this.btnCerrarHistorialVenta.Size = new System.Drawing.Size(98, 37);
            this.btnCerrarHistorialVenta.TabIndex = 15;
            this.btnCerrarHistorialVenta.Text = "CERRAR";
            this.btnCerrarHistorialVenta.UseVisualStyleBackColor = false;
            this.btnCerrarHistorialVenta.Click += new System.EventHandler(this.btnCerrarHistorialVenta_Click);
            // 
            // btnReimprimirVenta
            // 
            this.btnReimprimirVenta.BackColor = System.Drawing.Color.Cyan;
            this.btnReimprimirVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimirVenta.Location = new System.Drawing.Point(693, 119);
            this.btnReimprimirVenta.Name = "btnReimprimirVenta";
            this.btnReimprimirVenta.Size = new System.Drawing.Size(116, 37);
            this.btnReimprimirVenta.TabIndex = 14;
            this.btnReimprimirVenta.Text = "Reimprimir";
            this.btnReimprimirVenta.UseVisualStyleBackColor = false;
            this.btnReimprimirVenta.Click += new System.EventHandler(this.btnReimprimirVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.Location = new System.Drawing.Point(512, 101);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(101, 58);
            this.btnCancelarVenta.TabIndex = 13;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnLimpiarFiltroV
            // 
            this.btnLimpiarFiltroV.BackColor = System.Drawing.Color.Cyan;
            this.btnLimpiarFiltroV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltroV.Location = new System.Drawing.Point(318, 119);
            this.btnLimpiarFiltroV.Name = "btnLimpiarFiltroV";
            this.btnLimpiarFiltroV.Size = new System.Drawing.Size(87, 37);
            this.btnLimpiarFiltroV.TabIndex = 12;
            this.btnLimpiarFiltroV.Text = "LIMPIAR";
            this.btnLimpiarFiltroV.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltroV.Click += new System.EventHandler(this.btnLimpiarFiltroV_Click);
            // 
            // btnBuscarVentas
            // 
            this.btnBuscarVentas.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVentas.Location = new System.Drawing.Point(183, 119);
            this.btnBuscarVentas.Name = "btnBuscarVentas";
            this.btnBuscarVentas.Size = new System.Drawing.Size(92, 37);
            this.btnBuscarVentas.TabIndex = 11;
            this.btnBuscarVentas.Text = "BUSCAR";
            this.btnBuscarVentas.UseVisualStyleBackColor = false;
            this.btnBuscarVentas.Click += new System.EventHandler(this.btnBuscarVentas_Click);
            // 
            // cmbEstadoV
            // 
            this.cmbEstadoV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoV.FormattingEnabled = true;
            this.cmbEstadoV.Items.AddRange(new object[] {
            "Todas",
            "Activa",
            "Cancelada"});
            this.cmbEstadoV.Location = new System.Drawing.Point(866, 63);
            this.cmbEstadoV.Name = "cmbEstadoV";
            this.cmbEstadoV.Size = new System.Drawing.Size(255, 33);
            this.cmbEstadoV.TabIndex = 10;
            // 
            // lblEstadoV
            // 
            this.lblEstadoV.AutoSize = true;
            this.lblEstadoV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoV.Location = new System.Drawing.Point(686, 66);
            this.lblEstadoV.Name = "lblEstadoV";
            this.lblEstadoV.Size = new System.Drawing.Size(87, 25);
            this.lblEstadoV.TabIndex = 9;
            this.lblEstadoV.Text = "ESTADO :";
            // 
            // cmbFiltroUsuarioV
            // 
            this.cmbFiltroUsuarioV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroUsuarioV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroUsuarioV.FormattingEnabled = true;
            this.cmbFiltroUsuarioV.Location = new System.Drawing.Point(866, 15);
            this.cmbFiltroUsuarioV.Name = "cmbFiltroUsuarioV";
            this.cmbFiltroUsuarioV.Size = new System.Drawing.Size(255, 33);
            this.cmbFiltroUsuarioV.TabIndex = 8;
            // 
            // lblUsuarioV
            // 
            this.lblUsuarioV.AutoSize = true;
            this.lblUsuarioV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioV.Location = new System.Drawing.Point(686, 19);
            this.lblUsuarioV.Name = "lblUsuarioV";
            this.lblUsuarioV.Size = new System.Drawing.Size(97, 25);
            this.lblUsuarioV.TabIndex = 7;
            this.lblUsuarioV.Text = "USUARIO :";
            // 
            // dtpFechaFinV
            // 
            this.dtpFechaFinV.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinV.Location = new System.Drawing.Point(466, 60);
            this.dtpFechaFinV.Name = "dtpFechaFinV";
            this.dtpFechaFinV.Size = new System.Drawing.Size(200, 31);
            this.dtpFechaFinV.TabIndex = 6;
            // 
            // dtpFechaInicioV
            // 
            this.dtpFechaInicioV.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioV.Location = new System.Drawing.Point(466, 14);
            this.dtpFechaInicioV.Name = "dtpFechaInicioV";
            this.dtpFechaInicioV.Size = new System.Drawing.Size(200, 31);
            this.dtpFechaInicioV.TabIndex = 5;
            // 
            // lblFechaFinV
            // 
            this.lblFechaFinV.AutoSize = true;
            this.lblFechaFinV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinV.Location = new System.Drawing.Point(277, 66);
            this.lblFechaFinV.Name = "lblFechaFinV";
            this.lblFechaFinV.Size = new System.Drawing.Size(107, 25);
            this.lblFechaFinV.TabIndex = 3;
            this.lblFechaFinV.Text = "FECHA FIN :";
            // 
            // lblFechaInicioV
            // 
            this.lblFechaInicioV.AutoSize = true;
            this.lblFechaInicioV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioV.Location = new System.Drawing.Point(245, 18);
            this.lblFechaInicioV.Name = "lblFechaInicioV";
            this.lblFechaInicioV.Size = new System.Drawing.Size(160, 25);
            this.lblFechaInicioV.TabIndex = 2;
            this.lblFechaInicioV.Text = "FECHA DE INICIO :";
            // 
            // txtBuscarFolioV
            // 
            this.txtBuscarFolioV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBuscarFolioV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFolioV.Location = new System.Drawing.Point(98, 41);
            this.txtBuscarFolioV.Name = "txtBuscarFolioV";
            this.txtBuscarFolioV.Size = new System.Drawing.Size(120, 31);
            this.txtBuscarFolioV.TabIndex = 1;
            // 
            // lblBuscarFolioV
            // 
            this.lblBuscarFolioV.AutoSize = true;
            this.lblBuscarFolioV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarFolioV.Location = new System.Drawing.Point(21, 62);
            this.lblBuscarFolioV.Name = "lblBuscarFolioV";
            this.lblBuscarFolioV.Size = new System.Drawing.Size(71, 25);
            this.lblBuscarFolioV.TabIndex = 0;
            this.lblBuscarFolioV.Text = "FOLIO :";
            // 
            // panelVentas
            // 
            this.panelVentas.Controls.Add(this.dgvHistorialVentas);
            this.panelVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVentas.Location = new System.Drawing.Point(0, 166);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(1469, 777);
            this.panelVentas.TabIndex = 1;
            // 
            // dgvHistorialVentas
            // 
            this.dgvHistorialVentas.AllowUserToAddRows = false;
            this.dgvHistorialVentas.AllowUserToDeleteRows = false;
            this.dgvHistorialVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHistorialVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorialVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorialVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialVentas.ColumnHeadersHeight = 38;
            this.dgvHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVenta,
            this.colFolio,
            this.colFecha,
            this.colUsuario,
            this.colCliente,
            this.colItems,
            this.colTotal,
            this.colEstado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialVentas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHistorialVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorialVentas.EnableHeadersVisualStyles = false;
            this.dgvHistorialVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvHistorialVentas.MultiSelect = false;
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.ReadOnly = true;
            this.dgvHistorialVentas.RowHeadersVisible = false;
            this.dgvHistorialVentas.RowHeadersWidth = 62;
            this.dgvHistorialVentas.RowTemplate.Height = 28;
            this.dgvHistorialVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialVentas.Size = new System.Drawing.Size(1469, 777);
            this.dgvHistorialVentas.TabIndex = 0;
            this.dgvHistorialVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialVentas_CellClick);
            this.dgvHistorialVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialVentas_CellContentClick);
            // 
            // colIdVenta
            // 
            this.colIdVenta.FillWeight = 60F;
            this.colIdVenta.HeaderText = "ID";
            this.colIdVenta.MinimumWidth = 8;
            this.colIdVenta.Name = "colIdVenta";
            this.colIdVenta.ReadOnly = true;
            this.colIdVenta.Visible = false;
            // 
            // colFolio
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFolio.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFolio.FillWeight = 90F;
            this.colFolio.HeaderText = "Folio";
            this.colFolio.MinimumWidth = 8;
            this.colFolio.Name = "colFolio";
            this.colFolio.ReadOnly = true;
            // 
            // colFecha
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFecha.FillWeight = 110F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 8;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.FillWeight = 140F;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.MinimumWidth = 8;
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 160F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 8;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colItems
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.colItems.FillWeight = 70F;
            this.colItems.HeaderText = "Productos";
            this.colItems.MinimumWidth = 8;
            this.colItems.Name = "colItems";
            this.colItems.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTotal.FillWeight = 90F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colEstado
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colEstado.DefaultCellStyle = dataGridViewCellStyle7;
            this.colEstado.FillWeight = 90F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 8;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // panelDetalleVenta
            // 
            this.panelDetalleVenta.BackColor = System.Drawing.Color.SkyBlue;
            this.panelDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.panelDetalleVenta.Controls.Add(this.panelInfoDetalleV);
            this.panelDetalleVenta.Controls.Add(this.panelTituloDetalleV);
            this.panelDetalleVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetalleVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDetalleVenta.Location = new System.Drawing.Point(0, 723);
            this.panelDetalleVenta.Name = "panelDetalleVenta";
            this.panelDetalleVenta.Size = new System.Drawing.Size(1469, 220);
            this.panelDetalleVenta.TabIndex = 2;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AllowUserToResizeRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colProducto,
            this.colCantidad,
            this.colPrecioVenta,
            this.colDescuento,
            this.colSubtotal});
            this.dgvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(0, 41);
            this.dgvDetalleVenta.MultiSelect = false;
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.RowHeadersWidth = 62;
            this.dgvDetalleVenta.RowTemplate.Height = 28;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(1469, 142);
            this.dgvDetalleVenta.TabIndex = 2;
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
            this.colProducto.FillWeight = 240F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 8;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N3";
            dataGridViewCellStyle10.NullValue = null;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.colCantidad.FillWeight = 70F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecioVenta
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.colPrecioVenta.DefaultCellStyle = dataGridViewCellStyle11;
            this.colPrecioVenta.FillWeight = 90F;
            this.colPrecioVenta.HeaderText = "Precio";
            this.colPrecioVenta.MinimumWidth = 8;
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.ReadOnly = true;
            // 
            // colDescuento
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.colDescuento.DefaultCellStyle = dataGridViewCellStyle12;
            this.colDescuento.FillWeight = 70F;
            this.colDescuento.HeaderText = "Desc %";
            this.colDescuento.MinimumWidth = 8;
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.colSubtotal.DefaultCellStyle = dataGridViewCellStyle13;
            this.colSubtotal.FillWeight = 90F;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 8;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // panelInfoDetalleV
            // 
            this.panelInfoDetalleV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoDetalleV.Controls.Add(this.lblTotalDetalleV);
            this.panelInfoDetalleV.Controls.Add(this.lblCantidadItemsV);
            this.panelInfoDetalleV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfoDetalleV.Location = new System.Drawing.Point(0, 183);
            this.panelInfoDetalleV.Name = "panelInfoDetalleV";
            this.panelInfoDetalleV.Size = new System.Drawing.Size(1469, 37);
            this.panelInfoDetalleV.TabIndex = 1;
            // 
            // lblTotalDetalleV
            // 
            this.lblTotalDetalleV.AutoSize = true;
            this.lblTotalDetalleV.Location = new System.Drawing.Point(1100, 1);
            this.lblTotalDetalleV.Name = "lblTotalDetalleV";
            this.lblTotalDetalleV.Size = new System.Drawing.Size(107, 25);
            this.lblTotalDetalleV.TabIndex = 1;
            this.lblTotalDetalleV.Text = "Total : $0.00";
            // 
            // lblCantidadItemsV
            // 
            this.lblCantidadItemsV.AutoSize = true;
            this.lblCantidadItemsV.Location = new System.Drawing.Point(327, 1);
            this.lblCantidadItemsV.Name = "lblCantidadItemsV";
            this.lblCantidadItemsV.Size = new System.Drawing.Size(117, 25);
            this.lblCantidadItemsV.TabIndex = 0;
            this.lblCantidadItemsV.Text = "Productos : 0";
            // 
            // panelTituloDetalleV
            // 
            this.panelTituloDetalleV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTituloDetalleV.Controls.Add(this.lblDetalleVenta);
            this.panelTituloDetalleV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDetalleV.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDetalleV.Name = "panelTituloDetalleV";
            this.panelTituloDetalleV.Size = new System.Drawing.Size(1469, 41);
            this.panelTituloDetalleV.TabIndex = 0;
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.Location = new System.Drawing.Point(614, 8);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(140, 28);
            this.lblDetalleVenta.TabIndex = 0;
            this.lblDetalleVenta.Text = "Detalle Venta";
            // 
            // FrmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1469, 943);
            this.Controls.Add(this.panelDetalleVenta);
            this.Controls.Add(this.panelVentas);
            this.Controls.Add(this.panelFiltrosVentas);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FrmHistorialVentas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHistorialVentas_Load);
            this.panelFiltrosVentas.ResumeLayout(false);
            this.panelFiltrosVentas.PerformLayout();
            this.panelVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.panelDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.panelInfoDetalleV.ResumeLayout(false);
            this.panelInfoDetalleV.PerformLayout();
            this.panelTituloDetalleV.ResumeLayout(false);
            this.panelTituloDetalleV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltrosVentas;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Panel panelDetalleVenta;
        private System.Windows.Forms.Panel panelTituloDetalleV;
        private System.Windows.Forms.Label lblBuscarFolioV;
        private System.Windows.Forms.TextBox txtBuscarFolioV;
        private System.Windows.Forms.Label lblFechaFinV;
        private System.Windows.Forms.Label lblFechaInicioV;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioV;
        private System.Windows.Forms.DateTimePicker dtpFechaFinV;
        private System.Windows.Forms.Label lblUsuarioV;
        private System.Windows.Forms.ComboBox cmbFiltroUsuarioV;
        private System.Windows.Forms.Label lblEstadoV;
        private System.Windows.Forms.ComboBox cmbEstadoV;
        private System.Windows.Forms.Button btnBuscarVentas;
        private System.Windows.Forms.Button btnLimpiarFiltroV;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.DataGridView dgvHistorialVentas;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.Panel panelInfoDetalleV;
        private System.Windows.Forms.Label lblCantidadItemsV;
        private System.Windows.Forms.Label lblTotalDetalleV;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnReimprimirVenta;
        private System.Windows.Forms.Button btnCerrarHistorialVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnExportarPdf;
    }
}