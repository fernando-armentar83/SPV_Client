namespace SPV_Client
{
    partial class FrmEditarCantidad
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
            this.lblProductoTitulo = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadEditar = new System.Windows.Forms.TextBox();
            this.btnAceptarCantidad = new System.Windows.Forms.Button();
            this.btnCancelarCantidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductoTitulo
            // 
            this.lblProductoTitulo.AutoSize = true;
            this.lblProductoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblProductoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductoTitulo.Name = "lblProductoTitulo";
            this.lblProductoTitulo.Size = new System.Drawing.Size(84, 21);
            this.lblProductoTitulo.TabIndex = 0;
            this.lblProductoTitulo.Text = "Producto:";
            // 
            // lblProducto
            // 
            this.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(9, 35);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(291, 20);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "(Producto)";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(16, 74);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(83, 21);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidadEditar
            // 
            this.txtCantidadEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEditar.Location = new System.Drawing.Point(78, 70);
            this.txtCantidadEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadEditar.Multiline = true;
            this.txtCantidadEditar.Name = "txtCantidadEditar";
            this.txtCantidadEditar.Size = new System.Drawing.Size(94, 24);
            this.txtCantidadEditar.TabIndex = 3;
            this.txtCantidadEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadEditar_KeyPress);
            // 
            // btnAceptarCantidad
            // 
            this.btnAceptarCantidad.BackColor = System.Drawing.Color.MintCream;
            this.btnAceptarCantidad.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCantidad.Location = new System.Drawing.Point(62, 119);
            this.btnAceptarCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptarCantidad.Name = "btnAceptarCantidad";
            this.btnAceptarCantidad.Size = new System.Drawing.Size(86, 30);
            this.btnAceptarCantidad.TabIndex = 4;
            this.btnAceptarCantidad.Text = "Aceptar";
            this.btnAceptarCantidad.UseVisualStyleBackColor = false;
            this.btnAceptarCantidad.Click += new System.EventHandler(this.btnAceptarCantidad_Click);
            // 
            // btnCancelarCantidad
            // 
            this.btnCancelarCantidad.BackColor = System.Drawing.Color.MintCream;
            this.btnCancelarCantidad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarCantidad.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCantidad.Location = new System.Drawing.Point(171, 119);
            this.btnCancelarCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarCantidad.Name = "btnCancelarCantidad";
            this.btnCancelarCantidad.Size = new System.Drawing.Size(86, 30);
            this.btnCancelarCantidad.TabIndex = 5;
            this.btnCancelarCantidad.Text = "Cancelar";
            this.btnCancelarCantidad.UseVisualStyleBackColor = false;
            // 
            // FrmEditarCantidad
            // 
            this.AcceptButton = this.btnAceptarCantidad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarCantidad;
            this.ClientSize = new System.Drawing.Size(305, 158);
            this.Controls.Add(this.btnCancelarCantidad);
            this.Controls.Add(this.btnAceptarCantidad);
            this.Controls.Add(this.txtCantidadEditar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblProductoTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarCantidad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar cantidad";
            this.Load += new System.EventHandler(this.FrmEditarCantidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductoTitulo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadEditar;
        private System.Windows.Forms.Button btnAceptarCantidad;
        private System.Windows.Forms.Button btnCancelarCantidad;
    }
}