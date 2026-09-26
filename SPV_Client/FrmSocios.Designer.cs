namespace SPV_Client
{
    partial class FrmSocios
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
            this.lblSocio = new System.Windows.Forms.Label();
            this.txtSocio = new System.Windows.Forms.TextBox();
            this.chkActivoSocio = new System.Windows.Forms.CheckBox();
            this.btnGuardarSocio = new System.Windows.Forms.Button();
            this.btnEditarSocio = new System.Windows.Forms.Button();
            this.btnDesactivarSocio = new System.Windows.Forms.Button();
            this.btnNuevoSocio = new System.Windows.Forms.Button();
            this.btnCerrarSocio = new System.Windows.Forms.Button();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.lblBuscarSocio = new System.Windows.Forms.Label();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.colIdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalSocios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(21, 49);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(175, 23);
            this.lblSocio.TabIndex = 0;
            this.lblSocio.Text = "Nombre Socio : ";
            // 
            // txtSocio
            // 
            this.txtSocio.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocio.Location = new System.Drawing.Point(186, 46);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(232, 31);
            this.txtSocio.TabIndex = 1;
            // 
            // chkActivoSocio
            // 
            this.chkActivoSocio.AutoSize = true;
            this.chkActivoSocio.Checked = true;
            this.chkActivoSocio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivoSocio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivoSocio.Location = new System.Drawing.Point(444, 49);
            this.chkActivoSocio.Name = "chkActivoSocio";
            this.chkActivoSocio.Size = new System.Drawing.Size(84, 26);
            this.chkActivoSocio.TabIndex = 2;
            this.chkActivoSocio.Text = "Activo";
            this.chkActivoSocio.UseVisualStyleBackColor = true;
            // 
            // btnGuardarSocio
            // 
            this.btnGuardarSocio.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardarSocio.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSocio.Location = new System.Drawing.Point(43, 152);
            this.btnGuardarSocio.Name = "btnGuardarSocio";
            this.btnGuardarSocio.Size = new System.Drawing.Size(85, 36);
            this.btnGuardarSocio.TabIndex = 3;
            this.btnGuardarSocio.Text = "Guardar";
            this.btnGuardarSocio.UseVisualStyleBackColor = false;
            this.btnGuardarSocio.Click += new System.EventHandler(this.btnGuardarSocio_Click);
            // 
            // btnEditarSocio
            // 
            this.btnEditarSocio.BackColor = System.Drawing.Color.MintCream;
            this.btnEditarSocio.Enabled = false;
            this.btnEditarSocio.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSocio.Location = new System.Drawing.Point(179, 152);
            this.btnEditarSocio.Name = "btnEditarSocio";
            this.btnEditarSocio.Size = new System.Drawing.Size(85, 36);
            this.btnEditarSocio.TabIndex = 4;
            this.btnEditarSocio.Text = "Editar";
            this.btnEditarSocio.UseVisualStyleBackColor = false;
            this.btnEditarSocio.Click += new System.EventHandler(this.btnEditarSocio_Click);
            // 
            // btnDesactivarSocio
            // 
            this.btnDesactivarSocio.BackColor = System.Drawing.Color.MintCream;
            this.btnDesactivarSocio.Enabled = false;
            this.btnDesactivarSocio.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarSocio.Location = new System.Drawing.Point(337, 152);
            this.btnDesactivarSocio.Name = "btnDesactivarSocio";
            this.btnDesactivarSocio.Size = new System.Drawing.Size(100, 36);
            this.btnDesactivarSocio.TabIndex = 5;
            this.btnDesactivarSocio.Text = "Desactivar";
            this.btnDesactivarSocio.UseVisualStyleBackColor = false;
            this.btnDesactivarSocio.Click += new System.EventHandler(this.btnDesactivarSocio_Click);
            // 
            // btnNuevoSocio
            // 
            this.btnNuevoSocio.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevoSocio.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoSocio.Location = new System.Drawing.Point(503, 152);
            this.btnNuevoSocio.Name = "btnNuevoSocio";
            this.btnNuevoSocio.Size = new System.Drawing.Size(85, 36);
            this.btnNuevoSocio.TabIndex = 6;
            this.btnNuevoSocio.Text = "Nuevo";
            this.btnNuevoSocio.UseVisualStyleBackColor = false;
            this.btnNuevoSocio.Click += new System.EventHandler(this.btnNuevoSocio_Click);
            // 
            // btnCerrarSocio
            // 
            this.btnCerrarSocio.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarSocio.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSocio.Location = new System.Drawing.Point(657, 152);
            this.btnCerrarSocio.Name = "btnCerrarSocio";
            this.btnCerrarSocio.Size = new System.Drawing.Size(85, 36);
            this.btnCerrarSocio.TabIndex = 7;
            this.btnCerrarSocio.Text = "Cerrar";
            this.btnCerrarSocio.UseVisualStyleBackColor = false;
            this.btnCerrarSocio.Click += new System.EventHandler(this.btnCerrarSocio_Click);
            // 
            // txtBuscarSocio
            // 
            this.txtBuscarSocio.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSocio.Location = new System.Drawing.Point(673, 49);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(242, 26);
            this.txtBuscarSocio.TabIndex = 8;
            this.txtBuscarSocio.TextChanged += new System.EventHandler(this.txtBuscarSocio_TextChanged);
            // 
            // lblBuscarSocio
            // 
            this.lblBuscarSocio.AutoSize = true;
            this.lblBuscarSocio.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarSocio.Location = new System.Drawing.Point(566, 49);
            this.lblBuscarSocio.Name = "lblBuscarSocio";
            this.lblBuscarSocio.Size = new System.Drawing.Size(100, 22);
            this.lblBuscarSocio.TabIndex = 9;
            this.lblBuscarSocio.Text = "Buscar : ";
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            this.dgvSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdSocio,
            this.colSocio,
            this.colActivo});
            this.dgvSocios.Location = new System.Drawing.Point(12, 217);
            this.dgvSocios.MultiSelect = false;
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.RowHeadersVisible = false;
            this.dgvSocios.RowHeadersWidth = 62;
            this.dgvSocios.RowTemplate.Height = 28;
            this.dgvSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocios.Size = new System.Drawing.Size(918, 301);
            this.dgvSocios.TabIndex = 10;
            this.dgvSocios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocios_CellClick);
            // 
            // colIdSocio
            // 
            this.colIdSocio.DataPropertyName = "id_socio";
            this.colIdSocio.HeaderText = "ID";
            this.colIdSocio.MinimumWidth = 8;
            this.colIdSocio.Name = "colIdSocio";
            this.colIdSocio.ReadOnly = true;
            // 
            // colSocio
            // 
            this.colSocio.DataPropertyName = "nombre_socio";
            this.colSocio.HeaderText = "Socio";
            this.colSocio.MinimumWidth = 8;
            this.colSocio.Name = "colSocio";
            this.colSocio.ReadOnly = true;
            // 
            // colActivo
            // 
            this.colActivo.DataPropertyName = "activo";
            this.colActivo.HeaderText = "Estado";
            this.colActivo.MinimumWidth = 8;
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            // 
            // lblTotalSocios
            // 
            this.lblTotalSocios.AutoSize = true;
            this.lblTotalSocios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSocios.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSocios.Location = new System.Drawing.Point(812, 185);
            this.lblTotalSocios.Name = "lblTotalSocios";
            this.lblTotalSocios.Size = new System.Drawing.Size(2, 21);
            this.lblTotalSocios.TabIndex = 11;
            // 
            // FrmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 540);
            this.Controls.Add(this.lblTotalSocios);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.lblBuscarSocio);
            this.Controls.Add(this.txtBuscarSocio);
            this.Controls.Add(this.btnCerrarSocio);
            this.Controls.Add(this.btnNuevoSocio);
            this.Controls.Add(this.btnDesactivarSocio);
            this.Controls.Add(this.btnEditarSocio);
            this.Controls.Add(this.btnGuardarSocio);
            this.Controls.Add(this.chkActivoSocio);
            this.Controls.Add(this.txtSocio);
            this.Controls.Add(this.lblSocio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSocios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios.";
            this.Load += new System.EventHandler(this.FrmSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.TextBox txtSocio;
        private System.Windows.Forms.CheckBox chkActivoSocio;
        private System.Windows.Forms.Button btnGuardarSocio;
        private System.Windows.Forms.Button btnEditarSocio;
        private System.Windows.Forms.Button btnDesactivarSocio;
        private System.Windows.Forms.Button btnNuevoSocio;
        private System.Windows.Forms.Button btnCerrarSocio;
        private System.Windows.Forms.TextBox txtBuscarSocio;
        private System.Windows.Forms.Label lblBuscarSocio;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
        private System.Windows.Forms.Label lblTotalSocios;
    }
}