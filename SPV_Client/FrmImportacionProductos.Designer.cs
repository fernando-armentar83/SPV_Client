namespace SPV_Client
{
    partial class FrmImportacionProductos
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
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtRutaExcel = new System.Windows.Forms.TextBox();
            this.btnBuscarExcel = new System.Windows.Forms.Button();
            this.btnGenerarPlantilla = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblResumenImportacion = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.pnldgv = new System.Windows.Forms.Panel();
            this.dgvPreviewImportacion = new System.Windows.Forms.DataGridView();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCerrarImportacion = new System.Windows.Forms.Button();
            this.colFila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones.SuspendLayout();
            this.pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewImportacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.Location = new System.Drawing.Point(20, 20);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(132, 25);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Archivo Excel:";
            // 
            // txtRutaExcel
            // 
            this.txtRutaExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaExcel.Location = new System.Drawing.Point(20, 50);
            this.txtRutaExcel.Name = "txtRutaExcel";
            this.txtRutaExcel.ReadOnly = true;
            this.txtRutaExcel.Size = new System.Drawing.Size(450, 31);
            this.txtRutaExcel.TabIndex = 1;
            // 
            // btnBuscarExcel
            // 
            this.btnBuscarExcel.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarExcel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarExcel.Location = new System.Drawing.Point(480, 52);
            this.btnBuscarExcel.Name = "btnBuscarExcel";
            this.btnBuscarExcel.Size = new System.Drawing.Size(90, 25);
            this.btnBuscarExcel.TabIndex = 2;
            this.btnBuscarExcel.Text = ". . .";
            this.btnBuscarExcel.UseVisualStyleBackColor = false;
            this.btnBuscarExcel.Click += new System.EventHandler(this.btnBuscarExcel_Click);
            // 
            // btnGenerarPlantilla
            // 
            this.btnGenerarPlantilla.BackColor = System.Drawing.Color.Cyan;
            this.btnGenerarPlantilla.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPlantilla.Location = new System.Drawing.Point(612, 42);
            this.btnGenerarPlantilla.Name = "btnGenerarPlantilla";
            this.btnGenerarPlantilla.Size = new System.Drawing.Size(140, 52);
            this.btnGenerarPlantilla.TabIndex = 3;
            this.btnGenerarPlantilla.Text = "Generar Plantilla";
            this.btnGenerarPlantilla.UseVisualStyleBackColor = false;
            this.btnGenerarPlantilla.Click += new System.EventHandler(this.btnGenerarPlantilla_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Cyan;
            this.btnValidar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(20, 100);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(140, 32);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar Archivo";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblResumenImportacion
            // 
            this.lblResumenImportacion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenImportacion.Location = new System.Drawing.Point(180, 100);
            this.lblResumenImportacion.Name = "lblResumenImportacion";
            this.lblResumenImportacion.Size = new System.Drawing.Size(540, 32);
            this.lblResumenImportacion.TabIndex = 5;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.Honeydew;
            this.pnlBotones.Controls.Add(this.btnCerrarImportacion);
            this.pnlBotones.Controls.Add(this.lblInfo);
            this.pnlBotones.Controls.Add(this.btnImportar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 394);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(800, 100);
            this.pnlBotones.TabIndex = 6;
            // 
            // pnldgv
            // 
            this.pnldgv.Controls.Add(this.dgvPreviewImportacion);
            this.pnldgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnldgv.Location = new System.Drawing.Point(0, 138);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(800, 256);
            this.pnldgv.TabIndex = 7;
            // 
            // dgvPreviewImportacion
            // 
            this.dgvPreviewImportacion.AllowUserToAddRows = false;
            this.dgvPreviewImportacion.AllowUserToDeleteRows = false;
            this.dgvPreviewImportacion.AllowUserToResizeColumns = false;
            this.dgvPreviewImportacion.AllowUserToResizeRows = false;
            this.dgvPreviewImportacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreviewImportacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviewImportacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFila,
            this.colNombreProd,
            this.colEstadoProd});
            this.dgvPreviewImportacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreviewImportacion.Location = new System.Drawing.Point(0, 0);
            this.dgvPreviewImportacion.Name = "dgvPreviewImportacion";
            this.dgvPreviewImportacion.ReadOnly = true;
            this.dgvPreviewImportacion.RowHeadersWidth = 62;
            this.dgvPreviewImportacion.RowTemplate.Height = 28;
            this.dgvPreviewImportacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreviewImportacion.Size = new System.Drawing.Size(800, 256);
            this.dgvPreviewImportacion.TabIndex = 0;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Cyan;
            this.btnImportar.Enabled = false;
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(116, 30);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(120, 35);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(700, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(47, 25);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Info";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // btnCerrarImportacion
            // 
            this.btnCerrarImportacion.BackColor = System.Drawing.Color.Cyan;
            this.btnCerrarImportacion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarImportacion.Location = new System.Drawing.Point(400, 30);
            this.btnCerrarImportacion.Name = "btnCerrarImportacion";
            this.btnCerrarImportacion.Size = new System.Drawing.Size(120, 35);
            this.btnCerrarImportacion.TabIndex = 2;
            this.btnCerrarImportacion.Text = "Cerrar";
            this.btnCerrarImportacion.UseVisualStyleBackColor = false;
            this.btnCerrarImportacion.Click += new System.EventHandler(this.btnCerrarImportacion_Click);
            // 
            // colFila
            // 
            this.colFila.DataPropertyName = "Fila";
            this.colFila.HeaderText = "Fila";
            this.colFila.MinimumWidth = 8;
            this.colFila.Name = "colFila";
            this.colFila.ReadOnly = true;
            // 
            // colNombreProd
            // 
            this.colNombreProd.DataPropertyName = "Nombre";
            this.colNombreProd.HeaderText = "Producto";
            this.colNombreProd.MinimumWidth = 8;
            this.colNombreProd.Name = "colNombreProd";
            this.colNombreProd.ReadOnly = true;
            // 
            // colEstadoProd
            // 
            this.colEstadoProd.DataPropertyName = "Estado";
            this.colEstadoProd.HeaderText = "Estado";
            this.colEstadoProd.MinimumWidth = 8;
            this.colEstadoProd.Name = "colEstadoProd";
            this.colEstadoProd.ReadOnly = true;
            // 
            // FrmImportacionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.lblResumenImportacion);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnGenerarPlantilla);
            this.Controls.Add(this.btnBuscarExcel);
            this.Controls.Add(this.txtRutaExcel);
            this.Controls.Add(this.lblArchivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportacionProductos";
            this.ShowIcon = false;
            this.Text = "Importar Productos";
            this.Load += new System.EventHandler(this.FrmImportacionProductos_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewImportacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtRutaExcel;
        private System.Windows.Forms.Button btnBuscarExcel;
        private System.Windows.Forms.Button btnGenerarPlantilla;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblResumenImportacion;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnldgv;
        private System.Windows.Forms.DataGridView dgvPreviewImportacion;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnCerrarImportacion;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoProd;
    }
}