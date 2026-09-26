namespace SPV_Client
{
    partial class FrmDepartamentos
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarDepto = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnNuevoDepto = new System.Windows.Forms.Button();
            this.btnGuardarDepto = new System.Windows.Forms.Button();
            this.btnEditarDepto = new System.Windows.Forms.Button();
            this.btnDesactivarDepto = new System.Windows.Forms.Button();
            this.btnCerrarDepto = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.colIdDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlSuperior.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Controls.Add(this.lblDepartamento);
            this.pnlSuperior.Controls.Add(this.txtDepartamento);
            this.pnlSuperior.Controls.Add(this.chkActivo);
            this.pnlSuperior.Controls.Add(this.lblBuscar);
            this.pnlSuperior.Controls.Add(this.txtBuscarDepto);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1165, 90);
            this.pnlSuperior.TabIndex = 0;
            this.pnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSuperior_Paint);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(15, 35);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(150, 22);
            this.lblDepartamento.TabIndex = 0;
            this.lblDepartamento.Text = "Departamento :";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(174, 33);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(250, 29);
            this.txtDepartamento.TabIndex = 1;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(469, 34);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(89, 23);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(621, 33);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 22);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar :";
            // 
            // txtBuscarDepto
            // 
            this.txtBuscarDepto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDepto.Location = new System.Drawing.Point(716, 31);
            this.txtBuscarDepto.Name = "txtBuscarDepto";
            this.txtBuscarDepto.Size = new System.Drawing.Size(250, 29);
            this.txtBuscarDepto.TabIndex = 4;
            this.txtBuscarDepto.TextChanged += new System.EventHandler(this.txtBuscarDepto_TextChanged);
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnNuevoDepto);
            this.pnlBotones.Controls.Add(this.btnGuardarDepto);
            this.pnlBotones.Controls.Add(this.btnEditarDepto);
            this.pnlBotones.Controls.Add(this.btnDesactivarDepto);
            this.pnlBotones.Controls.Add(this.btnCerrarDepto);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 90);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1165, 57);
            this.pnlBotones.TabIndex = 1;
            // 
            // btnNuevoDepto
            // 
            this.btnNuevoDepto.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevoDepto.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDepto.Location = new System.Drawing.Point(79, 12);
            this.btnNuevoDepto.Name = "btnNuevoDepto";
            this.btnNuevoDepto.Size = new System.Drawing.Size(90, 35);
            this.btnNuevoDepto.TabIndex = 0;
            this.btnNuevoDepto.Text = "Nuevo";
            this.btnNuevoDepto.UseVisualStyleBackColor = false;
            this.btnNuevoDepto.Click += new System.EventHandler(this.btnNuevoDepto_Click);
            // 
            // btnGuardarDepto
            // 
            this.btnGuardarDepto.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardarDepto.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDepto.Location = new System.Drawing.Point(317, 12);
            this.btnGuardarDepto.Name = "btnGuardarDepto";
            this.btnGuardarDepto.Size = new System.Drawing.Size(90, 35);
            this.btnGuardarDepto.TabIndex = 1;
            this.btnGuardarDepto.Text = "Guardar";
            this.btnGuardarDepto.UseVisualStyleBackColor = false;
            this.btnGuardarDepto.Click += new System.EventHandler(this.btnGuardarDepto_Click);
            // 
            // btnEditarDepto
            // 
            this.btnEditarDepto.BackColor = System.Drawing.Color.MintCream;
            this.btnEditarDepto.Enabled = false;
            this.btnEditarDepto.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDepto.Location = new System.Drawing.Point(531, 12);
            this.btnEditarDepto.Name = "btnEditarDepto";
            this.btnEditarDepto.Size = new System.Drawing.Size(90, 35);
            this.btnEditarDepto.TabIndex = 2;
            this.btnEditarDepto.Text = "Editar";
            this.btnEditarDepto.UseVisualStyleBackColor = false;
            this.btnEditarDepto.Click += new System.EventHandler(this.btnEditarDepto_Click);
            // 
            // btnDesactivarDepto
            // 
            this.btnDesactivarDepto.BackColor = System.Drawing.Color.MintCream;
            this.btnDesactivarDepto.Enabled = false;
            this.btnDesactivarDepto.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarDepto.Location = new System.Drawing.Point(756, 12);
            this.btnDesactivarDepto.Name = "btnDesactivarDepto";
            this.btnDesactivarDepto.Size = new System.Drawing.Size(116, 35);
            this.btnDesactivarDepto.TabIndex = 3;
            this.btnDesactivarDepto.Text = "Desactivar";
            this.btnDesactivarDepto.UseVisualStyleBackColor = false;
            this.btnDesactivarDepto.Click += new System.EventHandler(this.btnDesactivarDepto_Click);
            // 
            // btnCerrarDepto
            // 
            this.btnCerrarDepto.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarDepto.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDepto.Location = new System.Drawing.Point(968, 12);
            this.btnCerrarDepto.Name = "btnCerrarDepto";
            this.btnCerrarDepto.Size = new System.Drawing.Size(90, 35);
            this.btnCerrarDepto.TabIndex = 4;
            this.btnCerrarDepto.Text = "Cerrar";
            this.btnCerrarDepto.UseVisualStyleBackColor = false;
            this.btnCerrarDepto.Click += new System.EventHandler(this.btnCerrarDepto_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.SeaShell;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.dgvDepartamentos);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 147);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1165, 303);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToAddRows = false;
            this.dgvDepartamentos.AllowUserToDeleteRows = false;
            this.dgvDepartamentos.AllowUserToResizeRows = false;
            this.dgvDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartamentos.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdDepartamento,
            this.colDepartamento,
            this.colActivo});
            this.dgvDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartamentos.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartamentos.MultiSelect = false;
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.ReadOnly = true;
            this.dgvDepartamentos.RowHeadersVisible = false;
            this.dgvDepartamentos.RowHeadersWidth = 62;
            this.dgvDepartamentos.RowTemplate.Height = 28;
            this.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamentos.Size = new System.Drawing.Size(1163, 301);
            this.dgvDepartamentos.TabIndex = 0;
            this.dgvDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellClick);
            // 
            // colIdDepartamento
            // 
            this.colIdDepartamento.DataPropertyName = "id_departamento";
            this.colIdDepartamento.HeaderText = "ID";
            this.colIdDepartamento.MinimumWidth = 8;
            this.colIdDepartamento.Name = "colIdDepartamento";
            this.colIdDepartamento.ReadOnly = true;
            this.colIdDepartamento.Visible = false;
            // 
            // colDepartamento
            // 
            this.colDepartamento.DataPropertyName = "nombre";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDepartamento.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDepartamento.HeaderText = "Departamento";
            this.colDepartamento.MinimumWidth = 8;
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.ReadOnly = true;
            // 
            // colActivo
            // 
            this.colActivo.DataPropertyName = "activo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.colActivo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colActivo.HeaderText = "Activo";
            this.colActivo.MinimumWidth = 8;
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            this.colActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartamentos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálgo  Departamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDepartamentos_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtBuscarDepto;
        private System.Windows.Forms.Button btnCerrarDepto;
        private System.Windows.Forms.Button btnDesactivarDepto;
        private System.Windows.Forms.Button btnEditarDepto;
        private System.Windows.Forms.Button btnGuardarDepto;
        private System.Windows.Forms.Button btnNuevoDepto;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActivo;
    }
}