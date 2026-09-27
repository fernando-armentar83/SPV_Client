namespace SPV_Client
{
    partial class FrmUsuarios
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
            this.lblTituloGral = new System.Windows.Forms.Label();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.pnlDatosUsuarios = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblTituloContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.chkActivoUsuario = new System.Windows.Forms.CheckBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.btnDesactivarUsuario = new System.Windows.Forms.Button();
            this.colIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEncabezado.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.pnlDatosUsuarios.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Azure;
            this.pnlEncabezado.Controls.Add(this.lblTituloGral);
            this.pnlEncabezado.Controls.Add(this.lblTotalUsuarios);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(908, 70);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTituloGral
            // 
            this.lblTituloGral.AutoSize = true;
            this.lblTituloGral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTituloGral.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGral.Location = new System.Drawing.Point(341, 20);
            this.lblTituloGral.Name = "lblTituloGral";
            this.lblTituloGral.Size = new System.Drawing.Size(161, 37);
            this.lblTituloGral.TabIndex = 0;
            this.lblTituloGral.Text = "USUARIOS";
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegistro.Controls.Add(this.chkActivoUsuario);
            this.pnlRegistro.Controls.Add(this.cmbRol);
            this.pnlRegistro.Controls.Add(this.lblRol);
            this.pnlRegistro.Controls.Add(this.txtContraseña);
            this.pnlRegistro.Controls.Add(this.lblTituloContraseña);
            this.pnlRegistro.Controls.Add(this.txtNombreUsuario);
            this.pnlRegistro.Controls.Add(this.lblTituloNombre);
            this.pnlRegistro.Controls.Add(this.txtBuscarUsuario);
            this.pnlRegistro.Controls.Add(this.lblBuscarUsuario);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegistro.Location = new System.Drawing.Point(0, 70);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(908, 200);
            this.pnlRegistro.TabIndex = 1;
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuario.Location = new System.Drawing.Point(56, 17);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(79, 25);
            this.lblBuscarUsuario.TabIndex = 0;
            this.lblBuscarUsuario.Text = "Buscar :";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.Location = new System.Drawing.Point(140, 13);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(250, 29);
            this.txtBuscarUsuario.TabIndex = 1;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsuarios.Location = new System.Drawing.Point(641, 29);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(126, 25);
            this.lblTotalUsuarios.TabIndex = 2;
            this.lblTotalUsuarios.Text = "# Usuarios : 0";
            // 
            // pnlDatosUsuarios
            // 
            this.pnlDatosUsuarios.Controls.Add(this.dgvUsuarios);
            this.pnlDatosUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosUsuarios.Location = new System.Drawing.Point(0, 270);
            this.pnlDatosUsuarios.Name = "pnlDatosUsuarios";
            this.pnlDatosUsuarios.Size = new System.Drawing.Size(908, 329);
            this.pnlDatosUsuarios.TabIndex = 2;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnDesactivarUsuario);
            this.pnlBotones.Controls.Add(this.btnCerrarUsuario);
            this.pnlBotones.Controls.Add(this.btnEditarUsuario);
            this.pnlBotones.Controls.Add(this.btnGuardarUsuario);
            this.pnlBotones.Controls.Add(this.btnNuevoUsuario);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 510);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(908, 89);
            this.pnlBotones.TabIndex = 3;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.ColumnHeadersHeight = 34;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdUsuario,
            this.colNombreUsuario,
            this.colRolUsuario,
            this.colActivoUsuario});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuarios.Size = new System.Drawing.Size(908, 329);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(45, 76);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(91, 25);
            this.lblTituloNombre.TabIndex = 3;
            this.lblTituloNombre.Text = "Nombre :";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(140, 72);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(250, 29);
            this.txtNombreUsuario.TabIndex = 4;
            // 
            // lblTituloContraseña
            // 
            this.lblTituloContraseña.AutoSize = true;
            this.lblTituloContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloContraseña.Location = new System.Drawing.Point(19, 139);
            this.lblTituloContraseña.Name = "lblTituloContraseña";
            this.lblTituloContraseña.Size = new System.Drawing.Size(118, 25);
            this.lblTituloContraseña.TabIndex = 5;
            this.lblTituloContraseña.Text = "Contraseña :";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(143, 137);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(247, 29);
            this.txtContraseña.TabIndex = 6;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(507, 46);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(50, 25);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol :";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(561, 42);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(168, 30);
            this.cmbRol.TabIndex = 8;
            // 
            // chkActivoUsuario
            // 
            this.chkActivoUsuario.AutoSize = true;
            this.chkActivoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivoUsuario.Location = new System.Drawing.Point(593, 109);
            this.chkActivoUsuario.Name = "chkActivoUsuario";
            this.chkActivoUsuario.Size = new System.Drawing.Size(93, 29);
            this.chkActivoUsuario.TabIndex = 9;
            this.chkActivoUsuario.Text = "Activo";
            this.chkActivoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkActivoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.MintCream;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(30, 22);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(120, 35);
            this.btnNuevoUsuario.TabIndex = 0;
            this.btnNuevoUsuario.Text = "Nuevo";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.MintCream;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Location = new System.Drawing.Point(200, 22);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(120, 35);
            this.btnGuardarUsuario.TabIndex = 1;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.MintCream;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Location = new System.Drawing.Point(370, 22);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(120, 35);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnCerrarUsuario
            // 
            this.btnCerrarUsuario.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarUsuario.Location = new System.Drawing.Point(710, 22);
            this.btnCerrarUsuario.Name = "btnCerrarUsuario";
            this.btnCerrarUsuario.Size = new System.Drawing.Size(120, 35);
            this.btnCerrarUsuario.TabIndex = 3;
            this.btnCerrarUsuario.Text = "Cerrar";
            this.btnCerrarUsuario.UseVisualStyleBackColor = false;
            this.btnCerrarUsuario.Click += new System.EventHandler(this.btnCerrarUsuario_Click);
            // 
            // btnDesactivarUsuario
            // 
            this.btnDesactivarUsuario.BackColor = System.Drawing.Color.MintCream;
            this.btnDesactivarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarUsuario.Location = new System.Drawing.Point(540, 22);
            this.btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            this.btnDesactivarUsuario.Size = new System.Drawing.Size(120, 35);
            this.btnDesactivarUsuario.TabIndex = 4;
            this.btnDesactivarUsuario.Text = "Desactivar";
            this.btnDesactivarUsuario.UseVisualStyleBackColor = false;
            this.btnDesactivarUsuario.Click += new System.EventHandler(this.btnDesactivarUsuario_Click);
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.DataPropertyName = "id_usuario";
            this.colIdUsuario.HeaderText = "Id";
            this.colIdUsuario.MinimumWidth = 8;
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.ReadOnly = true;
            this.colIdUsuario.Visible = false;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.DataPropertyName = "nombre";
            this.colNombreUsuario.HeaderText = "Nombre";
            this.colNombreUsuario.MinimumWidth = 8;
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.ReadOnly = true;
            // 
            // colRolUsuario
            // 
            this.colRolUsuario.DataPropertyName = "rol";
            this.colRolUsuario.HeaderText = "Rol";
            this.colRolUsuario.MinimumWidth = 8;
            this.colRolUsuario.Name = "colRolUsuario";
            this.colRolUsuario.ReadOnly = true;
            // 
            // colActivoUsuario
            // 
            this.colActivoUsuario.DataPropertyName = "activo";
            this.colActivoUsuario.HeaderText = "Estado";
            this.colActivoUsuario.MinimumWidth = 8;
            this.colActivoUsuario.Name = "colActivoUsuario";
            this.colActivoUsuario.ReadOnly = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 599);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlDatosUsuarios);
            this.Controls.Add(this.pnlRegistro);
            this.Controls.Add(this.pnlEncabezado);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlDatosUsuarios.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTituloGral;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Panel pnlDatosUsuarios;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblTituloContraseña;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.CheckBox chkActivoUsuario;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private System.Windows.Forms.Button btnDesactivarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRolUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivoUsuario;
    }
}