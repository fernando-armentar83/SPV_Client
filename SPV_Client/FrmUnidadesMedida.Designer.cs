namespace SPV_Client
{
    partial class FrmUnidadesMedida
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
            this.txtBuscarUnidad = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.lblAbreviatura = new System.Windows.Forms.Label();
            this.txtNombreMedida = new System.Windows.Forms.TextBox();
            this.lblNombreMedida = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.lblTotalUnidades = new System.Windows.Forms.Label();
            this.btnCerrarUnidad = new System.Windows.Forms.Button();
            this.btnEliminarUnidad = new System.Windows.Forms.Button();
            this.btnEditarUnidad = new System.Windows.Forms.Button();
            this.btnGuardarUnidad = new System.Windows.Forms.Button();
            this.btnNuevoUnidad = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.colIdMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSuperior.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Controls.Add(this.txtBuscarUnidad);
            this.pnlSuperior.Controls.Add(this.lblBuscar);
            this.pnlSuperior.Controls.Add(this.txtAbreviatura);
            this.pnlSuperior.Controls.Add(this.lblAbreviatura);
            this.pnlSuperior.Controls.Add(this.txtNombreMedida);
            this.pnlSuperior.Controls.Add(this.lblNombreMedida);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1129, 120);
            this.pnlSuperior.TabIndex = 0;
            // 
            // txtBuscarUnidad
            // 
            this.txtBuscarUnidad.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUnidad.Location = new System.Drawing.Point(850, 18);
            this.txtBuscarUnidad.Name = "txtBuscarUnidad";
            this.txtBuscarUnidad.Size = new System.Drawing.Size(250, 27);
            this.txtBuscarUnidad.TabIndex = 5;
            this.txtBuscarUnidad.TextChanged += new System.EventHandler(this.txtBuscarUnidad_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(760, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(79, 19);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar : ";
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAbreviatura.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbreviatura.Location = new System.Drawing.Point(520, 18);
            this.txtAbreviatura.MaxLength = 10;
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(120, 27);
            this.txtAbreviatura.TabIndex = 3;
            // 
            // lblAbreviatura
            // 
            this.lblAbreviatura.AutoSize = true;
            this.lblAbreviatura.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbreviatura.Location = new System.Drawing.Point(420, 20);
            this.lblAbreviatura.Name = "lblAbreviatura";
            this.lblAbreviatura.Size = new System.Drawing.Size(73, 19);
            this.lblAbreviatura.TabIndex = 2;
            this.lblAbreviatura.Text = "Abrev. :";
            // 
            // txtNombreMedida
            // 
            this.txtNombreMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreMedida.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedida.Location = new System.Drawing.Point(130, 18);
            this.txtNombreMedida.Name = "txtNombreMedida";
            this.txtNombreMedida.Size = new System.Drawing.Size(250, 29);
            this.txtNombreMedida.TabIndex = 1;
            // 
            // lblNombreMedida
            // 
            this.lblNombreMedida.AutoSize = true;
            this.lblNombreMedida.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedida.Location = new System.Drawing.Point(20, 20);
            this.lblNombreMedida.Name = "lblNombreMedida";
            this.lblNombreMedida.Size = new System.Drawing.Size(90, 22);
            this.lblNombreMedida.TabIndex = 0;
            this.lblNombreMedida.Text = "Unidad : ";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.lblTotalUnidades);
            this.pnlBotones.Controls.Add(this.btnCerrarUnidad);
            this.pnlBotones.Controls.Add(this.btnEliminarUnidad);
            this.pnlBotones.Controls.Add(this.btnEditarUnidad);
            this.pnlBotones.Controls.Add(this.btnGuardarUnidad);
            this.pnlBotones.Controls.Add(this.btnNuevoUnidad);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 120);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1129, 100);
            this.pnlBotones.TabIndex = 1;
            // 
            // lblTotalUnidades
            // 
            this.lblTotalUnidades.AutoSize = true;
            this.lblTotalUnidades.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnidades.Location = new System.Drawing.Point(1018, 65);
            this.lblTotalUnidades.Name = "lblTotalUnidades";
            this.lblTotalUnidades.Size = new System.Drawing.Size(88, 22);
            this.lblTotalUnidades.TabIndex = 5;
            this.lblTotalUnidades.Text = "Total :  0";
            // 
            // btnCerrarUnidad
            // 
            this.btnCerrarUnidad.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarUnidad.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarUnidad.Location = new System.Drawing.Point(851, 21);
            this.btnCerrarUnidad.Name = "btnCerrarUnidad";
            this.btnCerrarUnidad.Size = new System.Drawing.Size(90, 35);
            this.btnCerrarUnidad.TabIndex = 4;
            this.btnCerrarUnidad.Text = "Cerrar";
            this.btnCerrarUnidad.UseVisualStyleBackColor = false;
            this.btnCerrarUnidad.Click += new System.EventHandler(this.btnCerrarUnidad_Click);
            // 
            // btnEliminarUnidad
            // 
            this.btnEliminarUnidad.BackColor = System.Drawing.Color.MintCream;
            this.btnEliminarUnidad.Enabled = false;
            this.btnEliminarUnidad.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUnidad.Location = new System.Drawing.Point(637, 21);
            this.btnEliminarUnidad.Name = "btnEliminarUnidad";
            this.btnEliminarUnidad.Size = new System.Drawing.Size(118, 35);
            this.btnEliminarUnidad.TabIndex = 3;
            this.btnEliminarUnidad.Text = "Desactivar";
            this.btnEliminarUnidad.UseVisualStyleBackColor = false;
            this.btnEliminarUnidad.Click += new System.EventHandler(this.btnEliminarUnidad_Click);
            // 
            // btnEditarUnidad
            // 
            this.btnEditarUnidad.BackColor = System.Drawing.Color.MintCream;
            this.btnEditarUnidad.Enabled = false;
            this.btnEditarUnidad.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUnidad.Location = new System.Drawing.Point(444, 21);
            this.btnEditarUnidad.Name = "btnEditarUnidad";
            this.btnEditarUnidad.Size = new System.Drawing.Size(90, 35);
            this.btnEditarUnidad.TabIndex = 2;
            this.btnEditarUnidad.Text = "Editar";
            this.btnEditarUnidad.UseVisualStyleBackColor = false;
            this.btnEditarUnidad.Click += new System.EventHandler(this.btnEditarUnidad_Click);
            // 
            // btnGuardarUnidad
            // 
            this.btnGuardarUnidad.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardarUnidad.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUnidad.Location = new System.Drawing.Point(227, 21);
            this.btnGuardarUnidad.Name = "btnGuardarUnidad";
            this.btnGuardarUnidad.Size = new System.Drawing.Size(90, 35);
            this.btnGuardarUnidad.TabIndex = 1;
            this.btnGuardarUnidad.Text = "Guardar";
            this.btnGuardarUnidad.UseVisualStyleBackColor = false;
            this.btnGuardarUnidad.Click += new System.EventHandler(this.btnGuardarUnidad_Click);
            // 
            // btnNuevoUnidad
            // 
            this.btnNuevoUnidad.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevoUnidad.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUnidad.Location = new System.Drawing.Point(25, 21);
            this.btnNuevoUnidad.Name = "btnNuevoUnidad";
            this.btnNuevoUnidad.Size = new System.Drawing.Size(90, 35);
            this.btnNuevoUnidad.TabIndex = 0;
            this.btnNuevoUnidad.Text = "Nuevo";
            this.btnNuevoUnidad.UseVisualStyleBackColor = false;
            this.btnNuevoUnidad.Click += new System.EventHandler(this.btnNuevoUnidad_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.dgvUnidades);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 220);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1129, 308);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AllowUserToAddRows = false;
            this.dgvUnidades.AllowUserToDeleteRows = false;
            this.dgvUnidades.AllowUserToResizeRows = false;
            this.dgvUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMedida,
            this.colNombreMedida,
            this.colAbreviatura,
            this.colActivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnidades.Location = new System.Drawing.Point(0, 0);
            this.dgvUnidades.MultiSelect = false;
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.ReadOnly = true;
            this.dgvUnidades.RowHeadersVisible = false;
            this.dgvUnidades.RowHeadersWidth = 62;
            this.dgvUnidades.RowTemplate.Height = 28;
            this.dgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidades.Size = new System.Drawing.Size(1127, 306);
            this.dgvUnidades.TabIndex = 0;
            this.dgvUnidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellClick);
            this.dgvUnidades.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUnidades_CellFormatting);
            // 
            // colIdMedida
            // 
            this.colIdMedida.DataPropertyName = "id_medida";
            this.colIdMedida.HeaderText = "ID";
            this.colIdMedida.MinimumWidth = 8;
            this.colIdMedida.Name = "colIdMedida";
            this.colIdMedida.ReadOnly = true;
            this.colIdMedida.Visible = false;
            // 
            // colNombreMedida
            // 
            this.colNombreMedida.DataPropertyName = "nombre_medida";
            this.colNombreMedida.HeaderText = "Unidad";
            this.colNombreMedida.MinimumWidth = 8;
            this.colNombreMedida.Name = "colNombreMedida";
            this.colNombreMedida.ReadOnly = true;
            // 
            // colAbreviatura
            // 
            this.colAbreviatura.DataPropertyName = "abreviatura";
            this.colAbreviatura.HeaderText = "Abreviatura";
            this.colAbreviatura.MinimumWidth = 8;
            this.colAbreviatura.Name = "colAbreviatura";
            this.colAbreviatura.ReadOnly = true;
            // 
            // colActivo
            // 
            this.colActivo.DataPropertyName = "activo";
            this.colActivo.HeaderText = "Estado";
            this.colActivo.MinimumWidth = 8;
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            // 
            // FrmUnidadesMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1129, 528);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnidadesMedida";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Medidas";
            this.Load += new System.EventHandler(this.FrmUnidadesMedida_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblNombreMedida;
        private System.Windows.Forms.Label lblAbreviatura;
        private System.Windows.Forms.TextBox txtNombreMedida;
        private System.Windows.Forms.TextBox txtBuscarUnidad;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtAbreviatura;
        private System.Windows.Forms.Button btnGuardarUnidad;
        private System.Windows.Forms.Button btnNuevoUnidad;
        private System.Windows.Forms.Button btnEliminarUnidad;
        private System.Windows.Forms.Button btnEditarUnidad;
        private System.Windows.Forms.Label lblTotalUnidades;
        private System.Windows.Forms.Button btnCerrarUnidad;
        private System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
    }
}