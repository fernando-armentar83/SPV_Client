namespace SPV_Client
{
    partial class FrmProveedores
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.lblBuscarProveedor = new System.Windows.Forms.Label();
            this.txtDireccionPro = new System.Windows.Forms.TextBox();
            this.lblDireccionPro = new System.Windows.Forms.Label();
            this.cmbEstadoPro = new System.Windows.Forms.ComboBox();
            this.lblEstadoPro = new System.Windows.Forms.Label();
            this.txtRFCPro = new System.Windows.Forms.TextBox();
            this.lblRFCPro = new System.Windows.Forms.Label();
            this.txtCorreoPro = new System.Windows.Forms.TextBox();
            this.lblCorreoPro = new System.Windows.Forms.Label();
            this.txtTelefonoPro = new System.Windows.Forms.TextBox();
            this.lblTelefonoPro = new System.Windows.Forms.Label();
            this.txtContactoPro = new System.Windows.Forms.TextBox();
            this.lblContactoPro = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.lblTotalProveedores = new System.Windows.Forms.Label();
            this.btnCerrarProveedor = new System.Windows.Forms.Button();
            this.btnDesactivarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.colIdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSuperior.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Controls.Add(this.txtBuscarProveedor);
            this.pnlSuperior.Controls.Add(this.lblBuscarProveedor);
            this.pnlSuperior.Controls.Add(this.txtDireccionPro);
            this.pnlSuperior.Controls.Add(this.lblDireccionPro);
            this.pnlSuperior.Controls.Add(this.cmbEstadoPro);
            this.pnlSuperior.Controls.Add(this.lblEstadoPro);
            this.pnlSuperior.Controls.Add(this.txtRFCPro);
            this.pnlSuperior.Controls.Add(this.lblRFCPro);
            this.pnlSuperior.Controls.Add(this.txtCorreoPro);
            this.pnlSuperior.Controls.Add(this.lblCorreoPro);
            this.pnlSuperior.Controls.Add(this.txtTelefonoPro);
            this.pnlSuperior.Controls.Add(this.lblTelefonoPro);
            this.pnlSuperior.Controls.Add(this.txtContactoPro);
            this.pnlSuperior.Controls.Add(this.lblContactoPro);
            this.pnlSuperior.Controls.Add(this.txtProveedor);
            this.pnlSuperior.Controls.Add(this.lblProveedor);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1373, 210);
            this.pnlSuperior.TabIndex = 0;
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProveedor.Location = new System.Drawing.Point(1045, 18);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(200, 29);
            this.txtBuscarProveedor.TabIndex = 15;
            this.txtBuscarProveedor.TextChanged += new System.EventHandler(this.txtBuscarProveedor_TextChanged);
            // 
            // lblBuscarProveedor
            // 
            this.lblBuscarProveedor.AutoSize = true;
            this.lblBuscarProveedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProveedor.Location = new System.Drawing.Point(950, 20);
            this.lblBuscarProveedor.Name = "lblBuscarProveedor";
            this.lblBuscarProveedor.Size = new System.Drawing.Size(89, 22);
            this.lblBuscarProveedor.TabIndex = 14;
            this.lblBuscarProveedor.Text = "Buscar : ";
            // 
            // txtDireccionPro
            // 
            this.txtDireccionPro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionPro.Location = new System.Drawing.Point(140, 138);
            this.txtDireccionPro.Multiline = true;
            this.txtDireccionPro.Name = "txtDireccionPro";
            this.txtDireccionPro.Size = new System.Drawing.Size(770, 50);
            this.txtDireccionPro.TabIndex = 13;
            // 
            // lblDireccionPro
            // 
            this.lblDireccionPro.AutoSize = true;
            this.lblDireccionPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionPro.Location = new System.Drawing.Point(20, 140);
            this.lblDireccionPro.Name = "lblDireccionPro";
            this.lblDireccionPro.Size = new System.Drawing.Size(113, 22);
            this.lblDireccionPro.TabIndex = 12;
            this.lblDireccionPro.Text = "Dirección : ";
            // 
            // cmbEstadoPro
            // 
            this.cmbEstadoPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoPro.FormattingEnabled = true;
            this.cmbEstadoPro.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmbEstadoPro.Location = new System.Drawing.Point(610, 98);
            this.cmbEstadoPro.Name = "cmbEstadoPro";
            this.cmbEstadoPro.Size = new System.Drawing.Size(180, 30);
            this.cmbEstadoPro.TabIndex = 11;
            // 
            // lblEstadoPro
            // 
            this.lblEstadoPro.AutoSize = true;
            this.lblEstadoPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPro.Location = new System.Drawing.Point(500, 100);
            this.lblEstadoPro.Name = "lblEstadoPro";
            this.lblEstadoPro.Size = new System.Drawing.Size(87, 22);
            this.lblEstadoPro.TabIndex = 10;
            this.lblEstadoPro.Text = "Estado : ";
            // 
            // txtRFCPro
            // 
            this.txtRFCPro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFCPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFCPro.Location = new System.Drawing.Point(610, 58);
            this.txtRFCPro.Name = "txtRFCPro";
            this.txtRFCPro.Size = new System.Drawing.Size(300, 29);
            this.txtRFCPro.TabIndex = 9;
            // 
            // lblRFCPro
            // 
            this.lblRFCPro.AutoSize = true;
            this.lblRFCPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFCPro.Location = new System.Drawing.Point(500, 60);
            this.lblRFCPro.Name = "lblRFCPro";
            this.lblRFCPro.Size = new System.Drawing.Size(62, 22);
            this.lblRFCPro.TabIndex = 8;
            this.lblRFCPro.Text = "RFC : ";
            // 
            // txtCorreoPro
            // 
            this.txtCorreoPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoPro.Location = new System.Drawing.Point(610, 18);
            this.txtCorreoPro.Name = "txtCorreoPro";
            this.txtCorreoPro.Size = new System.Drawing.Size(300, 29);
            this.txtCorreoPro.TabIndex = 7;
            // 
            // lblCorreoPro
            // 
            this.lblCorreoPro.AutoSize = true;
            this.lblCorreoPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoPro.Location = new System.Drawing.Point(500, 20);
            this.lblCorreoPro.Name = "lblCorreoPro";
            this.lblCorreoPro.Size = new System.Drawing.Size(88, 22);
            this.lblCorreoPro.TabIndex = 6;
            this.lblCorreoPro.Text = "Correo : ";
            // 
            // txtTelefonoPro
            // 
            this.txtTelefonoPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPro.Location = new System.Drawing.Point(140, 98);
            this.txtTelefonoPro.Name = "txtTelefonoPro";
            this.txtTelefonoPro.Size = new System.Drawing.Size(300, 29);
            this.txtTelefonoPro.TabIndex = 5;
            // 
            // lblTelefonoPro
            // 
            this.lblTelefonoPro.AutoSize = true;
            this.lblTelefonoPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoPro.Location = new System.Drawing.Point(20, 100);
            this.lblTelefonoPro.Name = "lblTelefonoPro";
            this.lblTelefonoPro.Size = new System.Drawing.Size(106, 22);
            this.lblTelefonoPro.TabIndex = 4;
            this.lblTelefonoPro.Text = "Telefono : ";
            // 
            // txtContactoPro
            // 
            this.txtContactoPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoPro.Location = new System.Drawing.Point(140, 58);
            this.txtContactoPro.Name = "txtContactoPro";
            this.txtContactoPro.Size = new System.Drawing.Size(300, 29);
            this.txtContactoPro.TabIndex = 3;
            // 
            // lblContactoPro
            // 
            this.lblContactoPro.AutoSize = true;
            this.lblContactoPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoPro.Location = new System.Drawing.Point(20, 60);
            this.lblContactoPro.Name = "lblContactoPro";
            this.lblContactoPro.Size = new System.Drawing.Size(108, 22);
            this.lblContactoPro.TabIndex = 2;
            this.lblContactoPro.Text = "Contacto : ";
            // 
            // txtProveedor
            // 
            this.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProveedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(140, 18);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(300, 29);
            this.txtProveedor.TabIndex = 1;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(20, 20);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(120, 22);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor : ";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.lblTotalProveedores);
            this.pnlBotones.Controls.Add(this.btnCerrarProveedor);
            this.pnlBotones.Controls.Add(this.btnDesactivarProveedor);
            this.pnlBotones.Controls.Add(this.btnEditarProveedor);
            this.pnlBotones.Controls.Add(this.btnGuardarProveedor);
            this.pnlBotones.Controls.Add(this.btnNuevoProveedor);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 210);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1373, 120);
            this.pnlBotones.TabIndex = 1;
            // 
            // lblTotalProveedores
            // 
            this.lblTotalProveedores.AutoSize = true;
            this.lblTotalProveedores.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProveedores.Location = new System.Drawing.Point(1209, 92);
            this.lblTotalProveedores.Name = "lblTotalProveedores";
            this.lblTotalProveedores.Size = new System.Drawing.Size(90, 19);
            this.lblTotalProveedores.TabIndex = 5;
            this.lblTotalProveedores.Text = "Total : 0";
            // 
            // btnCerrarProveedor
            // 
            this.btnCerrarProveedor.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarProveedor.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarProveedor.Location = new System.Drawing.Point(907, 28);
            this.btnCerrarProveedor.Name = "btnCerrarProveedor";
            this.btnCerrarProveedor.Size = new System.Drawing.Size(90, 35);
            this.btnCerrarProveedor.TabIndex = 4;
            this.btnCerrarProveedor.Text = "Cerrar";
            this.btnCerrarProveedor.UseVisualStyleBackColor = false;
            this.btnCerrarProveedor.Click += new System.EventHandler(this.btnCerrarProveedor_Click);
            // 
            // btnDesactivarProveedor
            // 
            this.btnDesactivarProveedor.BackColor = System.Drawing.Color.MintCream;
            this.btnDesactivarProveedor.Enabled = false;
            this.btnDesactivarProveedor.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarProveedor.Location = new System.Drawing.Point(693, 28);
            this.btnDesactivarProveedor.Name = "btnDesactivarProveedor";
            this.btnDesactivarProveedor.Size = new System.Drawing.Size(116, 35);
            this.btnDesactivarProveedor.TabIndex = 3;
            this.btnDesactivarProveedor.Text = "Desactivar";
            this.btnDesactivarProveedor.UseVisualStyleBackColor = false;
            this.btnDesactivarProveedor.Click += new System.EventHandler(this.btnDesactivarProveedor_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.BackColor = System.Drawing.Color.MintCream;
            this.btnEditarProveedor.Enabled = false;
            this.btnEditarProveedor.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedor.Location = new System.Drawing.Point(500, 28);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(90, 35);
            this.btnEditarProveedor.TabIndex = 2;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardarProveedor.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProveedor.Location = new System.Drawing.Point(283, 28);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(90, 35);
            this.btnGuardarProveedor.TabIndex = 1;
            this.btnGuardarProveedor.Text = "Guardar ";
            this.btnGuardarProveedor.UseVisualStyleBackColor = false;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.Location = new System.Drawing.Point(81, 28);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(90, 35);
            this.btnNuevoProveedor.TabIndex = 0;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.UseVisualStyleBackColor = false;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.dgvProveedores);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 330);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1373, 316);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProveedor,
            this.colProveedor,
            this.colContacto,
            this.colTelefono,
            this.colRFC,
            this.colEstado,
            this.colFechaRegistro});
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.Location = new System.Drawing.Point(0, 0);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidth = 62;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(1371, 314);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.DataPropertyName = "id_proveedor";
            this.colIdProveedor.HeaderText = "ID";
            this.colIdProveedor.MinimumWidth = 8;
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.ReadOnly = true;
            this.colIdProveedor.Visible = false;
            // 
            // colProveedor
            // 
            this.colProveedor.DataPropertyName = "nombre";
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.MinimumWidth = 8;
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colContacto
            // 
            this.colContacto.DataPropertyName = "contacto";
            this.colContacto.HeaderText = "Contacto";
            this.colContacto.MinimumWidth = 8;
            this.colContacto.Name = "colContacto";
            this.colContacto.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.DataPropertyName = "telefono";
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.MinimumWidth = 8;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colRFC
            // 
            this.colRFC.DataPropertyName = "rfc";
            this.colRFC.HeaderText = "RFC";
            this.colRFC.MinimumWidth = 8;
            this.colRFC.Name = "colRFC";
            this.colRFC.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 8;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.DataPropertyName = "fecha_registro";
            this.colFechaRegistro.HeaderText = "Fecha";
            this.colFechaRegistro.MinimumWidth = 8;
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.ReadOnly = true;
            this.colFechaRegistro.Visible = false;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1373, 646);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProveedores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtContactoPro;
        private System.Windows.Forms.Label lblContactoPro;
        private System.Windows.Forms.TextBox txtTelefonoPro;
        private System.Windows.Forms.Label lblTelefonoPro;
        private System.Windows.Forms.Label lblCorreoPro;
        private System.Windows.Forms.Label lblRFCPro;
        private System.Windows.Forms.TextBox txtCorreoPro;
        private System.Windows.Forms.ComboBox cmbEstadoPro;
        private System.Windows.Forms.Label lblEstadoPro;
        private System.Windows.Forms.TextBox txtRFCPro;
        private System.Windows.Forms.TextBox txtDireccionPro;
        private System.Windows.Forms.Label lblDireccionPro;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label lblBuscarProveedor;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.Button btnDesactivarProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Label lblTotalProveedores;
        private System.Windows.Forms.Button btnCerrarProveedor;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaRegistro;
    }
}