namespace SPV_Client
{
    partial class FrmConversiones
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.btnBuscarDestinoConv = new System.Windows.Forms.Button();
            this.txtProductoDestinoConv = new System.Windows.Forms.TextBox();
            this.lblProductoDestino = new System.Windows.Forms.Label();
            this.btnBuscarOrigenConv = new System.Windows.Forms.Button();
            this.txtProductoOrigenConv = new System.Windows.Forms.TextBox();
            this.lblProductoOrigen = new System.Windows.Forms.Label();
            this.pnlConversiones = new System.Windows.Forms.Panel();
            this.chkActivoConversion = new System.Windows.Forms.CheckBox();
            this.txtFactorConversion = new System.Windows.Forms.TextBox();
            this.lblFactor = new System.Windows.Forms.Label();
            this.pnldgvConversiones = new System.Windows.Forms.Panel();
            this.dgvConversiones = new System.Windows.Forms.DataGridView();
            this.colIdConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCerrarConversiones = new System.Windows.Forms.Button();
            this.btnDesactivarConversion = new System.Windows.Forms.Button();
            this.btnEditarConversion = new System.Windows.Forms.Button();
            this.btnGuardarConversion = new System.Windows.Forms.Button();
            this.btnNuevoConversion = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlConversiones.SuspendLayout();
            this.pnldgvConversiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversiones)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.MintCream;
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.lblInfo);
            this.pnlEncabezado.Controls.Add(this.btnBuscarDestinoConv);
            this.pnlEncabezado.Controls.Add(this.txtProductoDestinoConv);
            this.pnlEncabezado.Controls.Add(this.lblProductoDestino);
            this.pnlEncabezado.Controls.Add(this.btnBuscarOrigenConv);
            this.pnlEncabezado.Controls.Add(this.txtProductoOrigenConv);
            this.pnlEncabezado.Controls.Add(this.lblProductoOrigen);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(872, 158);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // btnBuscarDestinoConv
            // 
            this.btnBuscarDestinoConv.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarDestinoConv.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDestinoConv.Location = new System.Drawing.Point(433, 110);
            this.btnBuscarDestinoConv.Name = "btnBuscarDestinoConv";
            this.btnBuscarDestinoConv.Size = new System.Drawing.Size(125, 35);
            this.btnBuscarDestinoConv.TabIndex = 5;
            this.btnBuscarDestinoConv.Text = "Buscar (F3)";
            this.btnBuscarDestinoConv.UseVisualStyleBackColor = false;
            // 
            // txtProductoDestinoConv
            // 
            this.txtProductoDestinoConv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoDestinoConv.Location = new System.Drawing.Point(83, 110);
            this.txtProductoDestinoConv.Name = "txtProductoDestinoConv";
            this.txtProductoDestinoConv.ReadOnly = true;
            this.txtProductoDestinoConv.Size = new System.Drawing.Size(340, 31);
            this.txtProductoDestinoConv.TabIndex = 4;
            // 
            // lblProductoDestino
            // 
            this.lblProductoDestino.AutoSize = true;
            this.lblProductoDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoDestino.Location = new System.Drawing.Point(83, 85);
            this.lblProductoDestino.Name = "lblProductoDestino";
            this.lblProductoDestino.Size = new System.Drawing.Size(165, 25);
            this.lblProductoDestino.TabIndex = 3;
            this.lblProductoDestino.Text = "Producto Destino:";
            // 
            // btnBuscarOrigenConv
            // 
            this.btnBuscarOrigenConv.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarOrigenConv.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOrigenConv.Location = new System.Drawing.Point(433, 50);
            this.btnBuscarOrigenConv.Name = "btnBuscarOrigenConv";
            this.btnBuscarOrigenConv.Size = new System.Drawing.Size(125, 35);
            this.btnBuscarOrigenConv.TabIndex = 2;
            this.btnBuscarOrigenConv.Text = "Buscar (F2)";
            this.btnBuscarOrigenConv.UseVisualStyleBackColor = false;
            // 
            // txtProductoOrigenConv
            // 
            this.txtProductoOrigenConv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoOrigenConv.Location = new System.Drawing.Point(83, 50);
            this.txtProductoOrigenConv.Name = "txtProductoOrigenConv";
            this.txtProductoOrigenConv.ReadOnly = true;
            this.txtProductoOrigenConv.Size = new System.Drawing.Size(340, 31);
            this.txtProductoOrigenConv.TabIndex = 1;
            // 
            // lblProductoOrigen
            // 
            this.lblProductoOrigen.AutoSize = true;
            this.lblProductoOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoOrigen.Location = new System.Drawing.Point(83, 20);
            this.lblProductoOrigen.Name = "lblProductoOrigen";
            this.lblProductoOrigen.Size = new System.Drawing.Size(158, 25);
            this.lblProductoOrigen.TabIndex = 0;
            this.lblProductoOrigen.Text = "Producto Origen:";
            // 
            // pnlConversiones
            // 
            this.pnlConversiones.BackColor = System.Drawing.Color.Azure;
            this.pnlConversiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConversiones.Controls.Add(this.chkActivoConversion);
            this.pnlConversiones.Controls.Add(this.txtFactorConversion);
            this.pnlConversiones.Controls.Add(this.lblFactor);
            this.pnlConversiones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConversiones.Location = new System.Drawing.Point(0, 158);
            this.pnlConversiones.Name = "pnlConversiones";
            this.pnlConversiones.Size = new System.Drawing.Size(872, 106);
            this.pnlConversiones.TabIndex = 1;
            // 
            // chkActivoConversion
            // 
            this.chkActivoConversion.AutoSize = true;
            this.chkActivoConversion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivoConversion.Location = new System.Drawing.Point(206, 52);
            this.chkActivoConversion.Name = "chkActivoConversion";
            this.chkActivoConversion.Size = new System.Drawing.Size(92, 29);
            this.chkActivoConversion.TabIndex = 2;
            this.chkActivoConversion.Text = "Activa";
            this.chkActivoConversion.UseVisualStyleBackColor = true;
            // 
            // txtFactorConversion
            // 
            this.txtFactorConversion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactorConversion.Location = new System.Drawing.Point(20, 50);
            this.txtFactorConversion.Name = "txtFactorConversion";
            this.txtFactorConversion.Size = new System.Drawing.Size(150, 31);
            this.txtFactorConversion.TabIndex = 1;
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            this.lblFactor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactor.Location = new System.Drawing.Point(20, 20);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(261, 25);
            this.lblFactor.TabIndex = 0;
            this.lblFactor.Text = "Factor (1 origen = X destino):";
            // 
            // pnldgvConversiones
            // 
            this.pnldgvConversiones.BackColor = System.Drawing.Color.LightCyan;
            this.pnldgvConversiones.Controls.Add(this.dgvConversiones);
            this.pnldgvConversiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldgvConversiones.Location = new System.Drawing.Point(0, 264);
            this.pnldgvConversiones.Name = "pnldgvConversiones";
            this.pnldgvConversiones.Size = new System.Drawing.Size(872, 364);
            this.pnldgvConversiones.TabIndex = 2;
            // 
            // dgvConversiones
            // 
            this.dgvConversiones.AllowUserToAddRows = false;
            this.dgvConversiones.AllowUserToDeleteRows = false;
            this.dgvConversiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConversiones.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvConversiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConversiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdConversion,
            this.colOrigen,
            this.colDestino,
            this.colFactor,
            this.colEstado});
            this.dgvConversiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConversiones.Location = new System.Drawing.Point(0, 0);
            this.dgvConversiones.MultiSelect = false;
            this.dgvConversiones.Name = "dgvConversiones";
            this.dgvConversiones.ReadOnly = true;
            this.dgvConversiones.RowHeadersWidth = 62;
            this.dgvConversiones.RowTemplate.Height = 28;
            this.dgvConversiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConversiones.Size = new System.Drawing.Size(872, 364);
            this.dgvConversiones.TabIndex = 0;
            this.dgvConversiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConversiones_CellClick);
            // 
            // colIdConversion
            // 
            this.colIdConversion.DataPropertyName = "id_conversion";
            this.colIdConversion.HeaderText = "ID";
            this.colIdConversion.MinimumWidth = 8;
            this.colIdConversion.Name = "colIdConversion";
            this.colIdConversion.ReadOnly = true;
            this.colIdConversion.Visible = false;
            // 
            // colOrigen
            // 
            this.colOrigen.DataPropertyName = "origen";
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.MinimumWidth = 8;
            this.colOrigen.Name = "colOrigen";
            this.colOrigen.ReadOnly = true;
            // 
            // colDestino
            // 
            this.colDestino.DataPropertyName = "destino";
            this.colDestino.HeaderText = "Destino";
            this.colDestino.MinimumWidth = 8;
            this.colDestino.Name = "colDestino";
            this.colDestino.ReadOnly = true;
            // 
            // colFactor
            // 
            this.colFactor.DataPropertyName = "factor";
            this.colFactor.HeaderText = "Factor";
            this.colFactor.MinimumWidth = 8;
            this.colFactor.Name = "colFactor";
            this.colFactor.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 8;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlBotones.Controls.Add(this.btnCerrarConversiones);
            this.pnlBotones.Controls.Add(this.btnDesactivarConversion);
            this.pnlBotones.Controls.Add(this.btnEditarConversion);
            this.pnlBotones.Controls.Add(this.btnGuardarConversion);
            this.pnlBotones.Controls.Add(this.btnNuevoConversion);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 528);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(872, 100);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnCerrarConversiones
            // 
            this.btnCerrarConversiones.BackColor = System.Drawing.Color.Cyan;
            this.btnCerrarConversiones.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarConversiones.Location = new System.Drawing.Point(624, 30);
            this.btnCerrarConversiones.Name = "btnCerrarConversiones";
            this.btnCerrarConversiones.Size = new System.Drawing.Size(100, 40);
            this.btnCerrarConversiones.TabIndex = 4;
            this.btnCerrarConversiones.Text = "Cerrar";
            this.btnCerrarConversiones.UseVisualStyleBackColor = false;
            this.btnCerrarConversiones.Click += new System.EventHandler(this.btnCerrarConversiones_Click);
            // 
            // btnDesactivarConversion
            // 
            this.btnDesactivarConversion.BackColor = System.Drawing.Color.Cyan;
            this.btnDesactivarConversion.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarConversion.Location = new System.Drawing.Point(474, 30);
            this.btnDesactivarConversion.Name = "btnDesactivarConversion";
            this.btnDesactivarConversion.Size = new System.Drawing.Size(115, 40);
            this.btnDesactivarConversion.TabIndex = 3;
            this.btnDesactivarConversion.Text = "Desactivar";
            this.btnDesactivarConversion.UseVisualStyleBackColor = false;
            this.btnDesactivarConversion.Click += new System.EventHandler(this.btnDesactivarConversion_Click);
            // 
            // btnEditarConversion
            // 
            this.btnEditarConversion.BackColor = System.Drawing.Color.Cyan;
            this.btnEditarConversion.Enabled = false;
            this.btnEditarConversion.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarConversion.Location = new System.Drawing.Point(344, 30);
            this.btnEditarConversion.Name = "btnEditarConversion";
            this.btnEditarConversion.Size = new System.Drawing.Size(100, 40);
            this.btnEditarConversion.TabIndex = 2;
            this.btnEditarConversion.Text = "Editar";
            this.btnEditarConversion.UseVisualStyleBackColor = false;
            this.btnEditarConversion.Click += new System.EventHandler(this.btnEditarConversion_Click);
            // 
            // btnGuardarConversion
            // 
            this.btnGuardarConversion.BackColor = System.Drawing.Color.Cyan;
            this.btnGuardarConversion.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConversion.Location = new System.Drawing.Point(214, 30);
            this.btnGuardarConversion.Name = "btnGuardarConversion";
            this.btnGuardarConversion.Size = new System.Drawing.Size(100, 40);
            this.btnGuardarConversion.TabIndex = 1;
            this.btnGuardarConversion.Text = "Guardar";
            this.btnGuardarConversion.UseVisualStyleBackColor = false;
            this.btnGuardarConversion.Click += new System.EventHandler(this.btnGuardarConversion_Click);
            // 
            // btnNuevoConversion
            // 
            this.btnNuevoConversion.BackColor = System.Drawing.Color.Cyan;
            this.btnNuevoConversion.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoConversion.Location = new System.Drawing.Point(84, 30);
            this.btnNuevoConversion.Name = "btnNuevoConversion";
            this.btnNuevoConversion.Size = new System.Drawing.Size(100, 40);
            this.btnNuevoConversion.TabIndex = 0;
            this.btnNuevoConversion.Text = "Nuevo";
            this.btnNuevoConversion.UseVisualStyleBackColor = false;
            this.btnNuevoConversion.Click += new System.EventHandler(this.btnNuevoConversion_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblInfo.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(718, 23);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 22);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "InfoClick";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // FrmConversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 628);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnldgvConversiones);
            this.Controls.Add(this.pnlConversiones);
            this.Controls.Add(this.pnlEncabezado);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConversiones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion de Producto";
            this.Load += new System.EventHandler(this.FrmConversiones_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConversiones_KeyDown);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlConversiones.ResumeLayout(false);
            this.pnlConversiones.PerformLayout();
            this.pnldgvConversiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversiones)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblProductoOrigen;
        private System.Windows.Forms.TextBox txtProductoOrigenConv;
        private System.Windows.Forms.Button btnBuscarOrigenConv;
        private System.Windows.Forms.TextBox txtProductoDestinoConv;
        private System.Windows.Forms.Label lblProductoDestino;
        private System.Windows.Forms.Button btnBuscarDestinoConv;
        private System.Windows.Forms.Panel pnlConversiones;
        private System.Windows.Forms.TextBox txtFactorConversion;
        private System.Windows.Forms.Label lblFactor;
        private System.Windows.Forms.CheckBox chkActivoConversion;
        private System.Windows.Forms.Panel pnldgvConversiones;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.DataGridView dgvConversiones;
        private System.Windows.Forms.Button btnNuevoConversion;
        private System.Windows.Forms.Button btnGuardarConversion;
        private System.Windows.Forms.Button btnDesactivarConversion;
        private System.Windows.Forms.Button btnEditarConversion;
        private System.Windows.Forms.Button btnCerrarConversiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdConversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label lblInfo;
    }
}