namespace SPV_Client
{
    partial class FrmAdministracion
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
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.btnAbrirArqueo = new System.Windows.Forms.Button();
            this.pnlencabezado = new System.Windows.Forms.Panel();
            this.pnlOperacion = new System.Windows.Forms.Panel();
            this.btnCategorías = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnUnidadesMedida = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.pnlencabezado.SuspendLayout();
            this.pnlOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(166, 20);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(358, 32);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "PANEL DEL ADMINISTRADOR.";
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.BackColor = System.Drawing.Color.MintCream;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Location = new System.Drawing.Point(656, 23);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(34, 22);
            this.lblUsuarioActivo.TabIndex = 1;
            this.lblUsuarioActivo.Text = "---";
            // 
            // btnAbrirArqueo
            // 
            this.btnAbrirArqueo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArqueo.Location = new System.Drawing.Point(60, 30);
            this.btnAbrirArqueo.Name = "btnAbrirArqueo";
            this.btnAbrirArqueo.Size = new System.Drawing.Size(162, 64);
            this.btnAbrirArqueo.TabIndex = 2;
            this.btnAbrirArqueo.Text = "Arqueo de turno";
            this.btnAbrirArqueo.UseVisualStyleBackColor = true;
            this.btnAbrirArqueo.Click += new System.EventHandler(this.btnAbrirArqueo_Click);
            // 
            // pnlencabezado
            // 
            this.pnlencabezado.BackColor = System.Drawing.Color.LightCyan;
            this.pnlencabezado.Controls.Add(this.lblEncabezado);
            this.pnlencabezado.Controls.Add(this.lblUsuarioActivo);
            this.pnlencabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlencabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlencabezado.Name = "pnlencabezado";
            this.pnlencabezado.Size = new System.Drawing.Size(800, 70);
            this.pnlencabezado.TabIndex = 3;
            // 
            // pnlOperacion
            // 
            this.pnlOperacion.BackColor = System.Drawing.Color.Honeydew;
            this.pnlOperacion.Controls.Add(this.btnProveedores);
            this.pnlOperacion.Controls.Add(this.btnUsuarios);
            this.pnlOperacion.Controls.Add(this.btnUnidadesMedida);
            this.pnlOperacion.Controls.Add(this.btnSocios);
            this.pnlOperacion.Controls.Add(this.btnProductos);
            this.pnlOperacion.Controls.Add(this.btnMarcas);
            this.pnlOperacion.Controls.Add(this.btnDepartamentos);
            this.pnlOperacion.Controls.Add(this.btnCategorías);
            this.pnlOperacion.Controls.Add(this.btnAbrirArqueo);
            this.pnlOperacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperacion.Location = new System.Drawing.Point(0, 70);
            this.pnlOperacion.Name = "pnlOperacion";
            this.pnlOperacion.Size = new System.Drawing.Size(800, 380);
            this.pnlOperacion.TabIndex = 4;
            // 
            // btnCategorías
            // 
            this.btnCategorías.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorías.Location = new System.Drawing.Point(60, 120);
            this.btnCategorías.Name = "btnCategorías";
            this.btnCategorías.Size = new System.Drawing.Size(162, 64);
            this.btnCategorías.TabIndex = 3;
            this.btnCategorías.Text = "Categorías";
            this.btnCategorías.UseVisualStyleBackColor = true;
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamentos.Location = new System.Drawing.Point(60, 210);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(162, 64);
            this.btnDepartamentos.TabIndex = 4;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(260, 30);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(162, 64);
            this.btnMarcas.TabIndex = 5;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(260, 120);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(162, 64);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnSocios
            // 
            this.btnSocios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocios.Location = new System.Drawing.Point(460, 30);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(162, 64);
            this.btnSocios.TabIndex = 8;
            this.btnSocios.Text = "Socios";
            this.btnSocios.UseVisualStyleBackColor = true;
            // 
            // btnUnidadesMedida
            // 
            this.btnUnidadesMedida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidadesMedida.Location = new System.Drawing.Point(460, 120);
            this.btnUnidadesMedida.Name = "btnUnidadesMedida";
            this.btnUnidadesMedida.Size = new System.Drawing.Size(162, 64);
            this.btnUnidadesMedida.TabIndex = 9;
            this.btnUnidadesMedida.Text = "Unidades de Medida";
            this.btnUnidadesMedida.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(460, 210);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(162, 64);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(260, 210);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(164, 62);
            this.btnProveedores.TabIndex = 11;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOperacion);
            this.Controls.Add(this.pnlencabezado);
            this.Name = "FrmAdministracion";
            this.ShowIcon = false;
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.FrmAdministracion_Load);
            this.pnlencabezado.ResumeLayout(false);
            this.pnlencabezado.PerformLayout();
            this.pnlOperacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Button btnAbrirArqueo;
        private System.Windows.Forms.Panel pnlencabezado;
        private System.Windows.Forms.Panel pnlOperacion;
        private System.Windows.Forms.Button btnCategorías;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnUnidadesMedida;
        private System.Windows.Forms.Button btnProveedores;
    }
}