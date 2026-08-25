namespace SPV_Client
{
    partial class FrmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.chkMostrarInactivos = new System.Windows.Forms.CheckBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.cmbSocioFiltro = new System.Windows.Forms.ComboBox();
            this.lblSocioFiltro = new System.Windows.Forms.Label();
            this.cmbProveedorFiltro = new System.Windows.Forms.ComboBox();
            this.lblProveedorFiltro = new System.Windows.Forms.Label();
            this.cmbMarcaFiltro = new System.Windows.Forms.ComboBox();
            this.lblMarcaFiltro = new System.Windows.Forms.Label();
            this.cmbCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.lblCategoriaFiltro = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.btnCerrarProductos = new System.Windows.Forms.Button();
            this.btnActualizarProductos = new System.Windows.Forms.Button();
            this.btnDesactivarProducto = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltros.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.chkMostrarInactivos);
            this.pnlFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.pnlFiltros.Controls.Add(this.cmbSocioFiltro);
            this.pnlFiltros.Controls.Add(this.lblSocioFiltro);
            this.pnlFiltros.Controls.Add(this.cmbProveedorFiltro);
            this.pnlFiltros.Controls.Add(this.lblProveedorFiltro);
            this.pnlFiltros.Controls.Add(this.cmbMarcaFiltro);
            this.pnlFiltros.Controls.Add(this.lblMarcaFiltro);
            this.pnlFiltros.Controls.Add(this.cmbCategoriaFiltro);
            this.pnlFiltros.Controls.Add(this.lblCategoriaFiltro);
            this.pnlFiltros.Controls.Add(this.txtBuscarProducto);
            this.pnlFiltros.Controls.Add(this.lblBuscarProducto);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1495, 120);
            this.pnlFiltros.TabIndex = 0;
            // 
            // chkMostrarInactivos
            // 
            this.chkMostrarInactivos.AutoSize = true;
            this.chkMostrarInactivos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarInactivos.Location = new System.Drawing.Point(512, 78);
            this.chkMostrarInactivos.Name = "chkMostrarInactivos";
            this.chkMostrarInactivos.Size = new System.Drawing.Size(126, 26);
            this.chkMostrarInactivos.TabIndex = 9;
            this.chkMostrarInactivos.Text = "Inactivos";
            this.chkMostrarInactivos.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.MintCream;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(866, 73);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(104, 35);
            this.btnLimpiarFiltros.TabIndex = 0;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // cmbSocioFiltro
            // 
            this.cmbSocioFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocioFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSocioFiltro.FormattingEnabled = true;
            this.cmbSocioFiltro.Location = new System.Drawing.Point(122, 76);
            this.cmbSocioFiltro.Name = "cmbSocioFiltro";
            this.cmbSocioFiltro.Size = new System.Drawing.Size(183, 30);
            this.cmbSocioFiltro.TabIndex = 0;
            // 
            // lblSocioFiltro
            // 
            this.lblSocioFiltro.AutoSize = true;
            this.lblSocioFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocioFiltro.Location = new System.Drawing.Point(39, 78);
            this.lblSocioFiltro.Name = "lblSocioFiltro";
            this.lblSocioFiltro.Size = new System.Drawing.Size(80, 22);
            this.lblSocioFiltro.TabIndex = 8;
            this.lblSocioFiltro.Text = "Socio :";
            // 
            // cmbProveedorFiltro
            // 
            this.cmbProveedorFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedorFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedorFiltro.FormattingEnabled = true;
            this.cmbProveedorFiltro.Location = new System.Drawing.Point(1257, 21);
            this.cmbProveedorFiltro.Name = "cmbProveedorFiltro";
            this.cmbProveedorFiltro.Size = new System.Drawing.Size(213, 30);
            this.cmbProveedorFiltro.TabIndex = 7;
            // 
            // lblProveedorFiltro
            // 
            this.lblProveedorFiltro.AutoSize = true;
            this.lblProveedorFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorFiltro.Location = new System.Drawing.Point(1130, 23);
            this.lblProveedorFiltro.Name = "lblProveedorFiltro";
            this.lblProveedorFiltro.Size = new System.Drawing.Size(120, 22);
            this.lblProveedorFiltro.TabIndex = 6;
            this.lblProveedorFiltro.Text = "Proveedor :";
            // 
            // cmbMarcaFiltro
            // 
            this.cmbMarcaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcaFiltro.FormattingEnabled = true;
            this.cmbMarcaFiltro.Location = new System.Drawing.Point(878, 21);
            this.cmbMarcaFiltro.Name = "cmbMarcaFiltro";
            this.cmbMarcaFiltro.Size = new System.Drawing.Size(200, 30);
            this.cmbMarcaFiltro.TabIndex = 5;
            // 
            // lblMarcaFiltro
            // 
            this.lblMarcaFiltro.AutoSize = true;
            this.lblMarcaFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaFiltro.Location = new System.Drawing.Point(787, 23);
            this.lblMarcaFiltro.Name = "lblMarcaFiltro";
            this.lblMarcaFiltro.Size = new System.Drawing.Size(80, 22);
            this.lblMarcaFiltro.TabIndex = 4;
            this.lblMarcaFiltro.Text = "Marca :";
            // 
            // cmbCategoriaFiltro
            // 
            this.cmbCategoriaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaFiltro.FormattingEnabled = true;
            this.cmbCategoriaFiltro.Location = new System.Drawing.Point(540, 21);
            this.cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            this.cmbCategoriaFiltro.Size = new System.Drawing.Size(200, 28);
            this.cmbCategoriaFiltro.TabIndex = 3;
            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(413, 23);
            this.lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            this.lblCategoriaFiltro.Size = new System.Drawing.Size(120, 22);
            this.lblCategoriaFiltro.TabIndex = 2;
            this.lblCategoriaFiltro.Text = "Categoría :";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(122, 21);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(250, 29);
            this.txtBuscarProducto.TabIndex = 1;
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProducto.Location = new System.Drawing.Point(29, 23);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(90, 22);
            this.lblBuscarProducto.TabIndex = 0;
            this.lblBuscarProducto.Text = "Buscar :";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.lblTotalProductos);
            this.pnlBotones.Controls.Add(this.btnCerrarProductos);
            this.pnlBotones.Controls.Add(this.btnActualizarProductos);
            this.pnlBotones.Controls.Add(this.btnDesactivarProducto);
            this.pnlBotones.Controls.Add(this.btnNuevoProducto);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 120);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1495, 160);
            this.pnlBotones.TabIndex = 1;
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductos.Location = new System.Drawing.Point(1174, 131);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(190, 22);
            this.lblTotalProductos.TabIndex = 5;
            this.lblTotalProductos.Text = "Total productos: 0";
            this.lblTotalProductos.Click += new System.EventHandler(this.lblTotalProductos_Click);
            // 
            // btnCerrarProductos
            // 
            this.btnCerrarProductos.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarProductos.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarProductos.Image = global::SPV_Client.Properties.Resources.closed_sign;
            this.btnCerrarProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrarProductos.Location = new System.Drawing.Point(904, 14);
            this.btnCerrarProductos.Name = "btnCerrarProductos";
            this.btnCerrarProductos.Size = new System.Drawing.Size(125, 139);
            this.btnCerrarProductos.TabIndex = 4;
            this.btnCerrarProductos.Text = "Cerrar";
            this.btnCerrarProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarProductos.UseVisualStyleBackColor = false;
            this.btnCerrarProductos.Click += new System.EventHandler(this.btnCerrarProductos_Click);
            // 
            // btnActualizarProductos
            // 
            this.btnActualizarProductos.BackColor = System.Drawing.Color.MintCream;
            this.btnActualizarProductos.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProductos.Image = global::SPV_Client.Properties.Resources.updated;
            this.btnActualizarProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizarProductos.Location = new System.Drawing.Point(641, 14);
            this.btnActualizarProductos.Name = "btnActualizarProductos";
            this.btnActualizarProductos.Size = new System.Drawing.Size(125, 139);
            this.btnActualizarProductos.TabIndex = 3;
            this.btnActualizarProductos.Text = "Actualizar";
            this.btnActualizarProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizarProductos.UseVisualStyleBackColor = false;
            // 
            // btnDesactivarProducto
            // 
            this.btnDesactivarProducto.BackColor = System.Drawing.Color.MintCream;
            this.btnDesactivarProducto.Enabled = false;
            this.btnDesactivarProducto.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarProducto.Image = global::SPV_Client.Properties.Resources.switch1;
            this.btnDesactivarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesactivarProducto.Location = new System.Drawing.Point(359, 14);
            this.btnDesactivarProducto.Name = "btnDesactivarProducto";
            this.btnDesactivarProducto.Size = new System.Drawing.Size(125, 139);
            this.btnDesactivarProducto.TabIndex = 2;
            this.btnDesactivarProducto.Text = "Desactivar";
            this.btnDesactivarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesactivarProducto.UseVisualStyleBackColor = false;
            this.btnDesactivarProducto.Click += new System.EventHandler(this.btnDesactivarProducto_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Image = global::SPV_Client.Properties.Resources.new_item__1_;
            this.btnNuevoProducto.Location = new System.Drawing.Point(102, 14);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(125, 139);
            this.btnNuevoProducto.TabIndex = 0;
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.dgvProductos);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 280);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1495, 295);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colProducto,
            this.colCategoria,
            this.colMarca,
            this.colModelo,
            this.colProveedor,
            this.colSocio,
            this.colStock,
            this.colStockMinimo,
            this.colPrecioCompra,
            this.colPrecioVenta,
            this.colActivo});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1493, 293);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            this.dgvProductos.DoubleClick += new System.EventHandler(this.dgvProductos_DoubleClick);
            this.dgvProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductos_KeyDown);
            // 
            // colIdProducto
            // 
            this.colIdProducto.DataPropertyName = "id_producto";
            this.colIdProducto.HeaderText = "ID";
            this.colIdProducto.MinimumWidth = 8;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            this.colIdProducto.Width = 150;
            // 
            // colProducto
            // 
            this.colProducto.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.colProducto.FillWeight = 562.5001F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 8;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 762;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "categoria";
            this.colCategoria.FillWeight = 137.4302F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.MinimumWidth = 8;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 150;
            // 
            // colMarca
            // 
            this.colMarca.DataPropertyName = "marca";
            this.colMarca.FillWeight = 113.6852F;
            this.colMarca.HeaderText = "Marca";
            this.colMarca.MinimumWidth = 8;
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            this.colMarca.Width = 120;
            // 
            // colModelo
            // 
            this.colModelo.DataPropertyName = "modelo";
            this.colModelo.FillWeight = 57.05066F;
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.MinimumWidth = 8;
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            this.colModelo.Width = 77;
            // 
            // colProveedor
            // 
            this.colProveedor.DataPropertyName = "proveedor";
            this.colProveedor.FillWeight = 32.79847F;
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.MinimumWidth = 8;
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            this.colProveedor.Width = 150;
            // 
            // colSocio
            // 
            this.colSocio.DataPropertyName = "socio";
            this.colSocio.FillWeight = 29.30672F;
            this.colSocio.HeaderText = "Socio";
            this.colSocio.MinimumWidth = 8;
            this.colSocio.Name = "colSocio";
            this.colSocio.ReadOnly = true;
            this.colSocio.Width = 120;
            // 
            // colStock
            // 
            this.colStock.DataPropertyName = "stock_actual";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.colStock.FillWeight = 39.69036F;
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 8;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 80;
            // 
            // colStockMinimo
            // 
            this.colStockMinimo.DataPropertyName = "stock_minimo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStockMinimo.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStockMinimo.FillWeight = 23.31309F;
            this.colStockMinimo.HeaderText = "Mínimo";
            this.colStockMinimo.MinimumWidth = 8;
            this.colStockMinimo.Name = "colStockMinimo";
            this.colStockMinimo.ReadOnly = true;
            this.colStockMinimo.Width = 80;
            // 
            // colPrecioCompra
            // 
            this.colPrecioCompra.DataPropertyName = "precio_compra";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecioCompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPrecioCompra.FillWeight = 29.89419F;
            this.colPrecioCompra.HeaderText = "Compra";
            this.colPrecioCompra.MinimumWidth = 8;
            this.colPrecioCompra.Name = "colPrecioCompra";
            this.colPrecioCompra.ReadOnly = true;
            this.colPrecioCompra.Width = 90;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.DataPropertyName = "precio_venta";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecioVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPrecioVenta.FillWeight = 45.38707F;
            this.colPrecioVenta.HeaderText = "Venta";
            this.colPrecioVenta.MinimumWidth = 8;
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.ReadOnly = true;
            this.colPrecioVenta.Width = 90;
            // 
            // colActivo
            // 
            this.colActivo.DataPropertyName = "activo";
            this.colActivo.FillWeight = 28.94413F;
            this.colActivo.HeaderText = "Estado";
            this.colActivo.MinimumWidth = 8;
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            this.colActivo.Width = 80;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1495, 575);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "FrmProductos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblCategoriaFiltro;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.ComboBox cmbCategoriaFiltro;
        private System.Windows.Forms.Label lblMarcaFiltro;
        private System.Windows.Forms.Label lblProveedorFiltro;
        private System.Windows.Forms.ComboBox cmbMarcaFiltro;
        private System.Windows.Forms.Label lblSocioFiltro;
        private System.Windows.Forms.ComboBox cmbProveedorFiltro;
        private System.Windows.Forms.ComboBox cmbSocioFiltro;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnCerrarProductos;
        private System.Windows.Forms.Button btnActualizarProductos;
        private System.Windows.Forms.Button btnDesactivarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.CheckBox chkMostrarInactivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
    }
}