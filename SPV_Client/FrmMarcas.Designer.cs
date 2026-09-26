namespace SPV_Client
{
    partial class FrmMarcas
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.lblTotalMarcas = new System.Windows.Forms.Label();
            this.btnCerrarMarca = new System.Windows.Forms.Button();
            this.btnDesactivarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.btnNuevoMarca = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.colIdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlSuperior.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Controls.Add(this.txtBuscarMarca);
            this.pnlSuperior.Controls.Add(this.lblBuscar);
            this.pnlSuperior.Controls.Add(this.chkActivo);
            this.pnlSuperior.Controls.Add(this.txtMarca);
            this.pnlSuperior.Controls.Add(this.lblMarca);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1197, 120);
            this.pnlSuperior.TabIndex = 0;
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarca.Location = new System.Drawing.Point(819, 23);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(250, 29);
            this.txtBuscarMarca.TabIndex = 4;
            this.txtBuscarMarca.TextChanged += new System.EventHandler(this.txtBuscarMarca_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(714, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(84, 22);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar :";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(446, 25);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(78, 24);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(145, 23);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(250, 29);
            this.txtMarca.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(48, 24);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(78, 22);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca :";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.MintCream;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.lblTotalMarcas);
            this.pnlBotones.Controls.Add(this.btnCerrarMarca);
            this.pnlBotones.Controls.Add(this.btnDesactivarMarca);
            this.pnlBotones.Controls.Add(this.btnEditarMarca);
            this.pnlBotones.Controls.Add(this.btnGuardarMarca);
            this.pnlBotones.Controls.Add(this.btnNuevoMarca);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBotones.Location = new System.Drawing.Point(0, 120);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1197, 100);
            this.pnlBotones.TabIndex = 1;
            // 
            // lblTotalMarcas
            // 
            this.lblTotalMarcas.AutoSize = true;
            this.lblTotalMarcas.Location = new System.Drawing.Point(1089, 69);
            this.lblTotalMarcas.Name = "lblTotalMarcas";
            this.lblTotalMarcas.Size = new System.Drawing.Size(90, 19);
            this.lblTotalMarcas.TabIndex = 5;
            this.lblTotalMarcas.Text = "Total : 0";
            // 
            // btnCerrarMarca
            // 
            this.btnCerrarMarca.Location = new System.Drawing.Point(907, 35);
            this.btnCerrarMarca.Name = "btnCerrarMarca";
            this.btnCerrarMarca.Size = new System.Drawing.Size(90, 35);
            this.btnCerrarMarca.TabIndex = 4;
            this.btnCerrarMarca.Text = "Cerrar";
            this.btnCerrarMarca.UseVisualStyleBackColor = true;
            this.btnCerrarMarca.Click += new System.EventHandler(this.btnCerrarMarca_Click);
            // 
            // btnDesactivarMarca
            // 
            this.btnDesactivarMarca.Enabled = false;
            this.btnDesactivarMarca.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarMarca.Location = new System.Drawing.Point(677, 35);
            this.btnDesactivarMarca.Name = "btnDesactivarMarca";
            this.btnDesactivarMarca.Size = new System.Drawing.Size(116, 35);
            this.btnDesactivarMarca.TabIndex = 3;
            this.btnDesactivarMarca.Text = "Desactivar";
            this.btnDesactivarMarca.UseVisualStyleBackColor = true;
            this.btnDesactivarMarca.Click += new System.EventHandler(this.btnDesactivarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Enabled = false;
            this.btnEditarMarca.Location = new System.Drawing.Point(494, 35);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(90, 35);
            this.btnEditarMarca.TabIndex = 2;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(292, 35);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(90, 35);
            this.btnGuardarMarca.TabIndex = 1;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // btnNuevoMarca
            // 
            this.btnNuevoMarca.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevoMarca.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMarca.Location = new System.Drawing.Point(86, 35);
            this.btnNuevoMarca.Name = "btnNuevoMarca";
            this.btnNuevoMarca.Size = new System.Drawing.Size(90, 35);
            this.btnNuevoMarca.TabIndex = 0;
            this.btnNuevoMarca.Text = "Nuevo";
            this.btnNuevoMarca.UseVisualStyleBackColor = false;
            this.btnNuevoMarca.Click += new System.EventHandler(this.btnNuevoMarca_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.dgvMarcas);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 220);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1197, 326);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.AllowUserToResizeRows = false;
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMarca,
            this.colMarca,
            this.colActivo});
            this.dgvMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarcas.Location = new System.Drawing.Point(0, 0);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowHeadersVisible = false;
            this.dgvMarcas.RowHeadersWidth = 62;
            this.dgvMarcas.RowTemplate.Height = 28;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(1195, 324);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellClick);
            // 
            // colIdMarca
            // 
            this.colIdMarca.DataPropertyName = "id_marca";
            this.colIdMarca.HeaderText = "ID";
            this.colIdMarca.MinimumWidth = 8;
            this.colIdMarca.Name = "colIdMarca";
            this.colIdMarca.ReadOnly = true;
            this.colIdMarca.Visible = false;
            // 
            // colMarca
            // 
            this.colMarca.DataPropertyName = "nombre_marca";
            this.colMarca.HeaderText = "Marca";
            this.colMarca.MinimumWidth = 8;
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colActivo
            // 
            this.colActivo.DataPropertyName = "activo";
            this.colActivo.HeaderText = "Activo";
            this.colActivo.MinimumWidth = 8;
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            this.colActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1197, 546);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMarcas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo Marcas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMarcas_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnNuevoMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Button btnDesactivarMarca;
        private System.Windows.Forms.Button btnCerrarMarca;
        private System.Windows.Forms.Label lblTotalMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActivo;
    }
}