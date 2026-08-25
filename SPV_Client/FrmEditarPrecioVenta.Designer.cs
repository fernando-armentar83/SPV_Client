namespace SPV_Client
{
    partial class FrmEditarPrecioVenta
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
            this.lblPrecioActual = new System.Windows.Forms.Label();
            this.lblPrecioActualValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptarPrecio = new System.Windows.Forms.Button();
            this.btnCancelarPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrecioActual
            // 
            this.lblPrecioActual.AutoSize = true;
            this.lblPrecioActual.Location = new System.Drawing.Point(20, 20);
            this.lblPrecioActual.Name = "lblPrecioActual";
            this.lblPrecioActual.Size = new System.Drawing.Size(108, 20);
            this.lblPrecioActual.TabIndex = 0;
            this.lblPrecioActual.Text = "Precio actual :";
            // 
            // lblPrecioActualValor
            // 
            this.lblPrecioActualValor.AutoSize = true;
            this.lblPrecioActualValor.Font = new System.Drawing.Font("Sans Serif Collection", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioActualValor.ForeColor = System.Drawing.Color.Blue;
            this.lblPrecioActualValor.Location = new System.Drawing.Point(140, 8);
            this.lblPrecioActualValor.Name = "lblPrecioActualValor";
            this.lblPrecioActualValor.Size = new System.Drawing.Size(83, 68);
            this.lblPrecioActualValor.TabIndex = 1;
            this.lblPrecioActualValor.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo precio :";
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(140, 60);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(150, 26);
            this.txtNuevoPrecio.TabIndex = 3;
            this.txtNuevoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNuevoPrecio.TextChanged += new System.EventHandler(this.txtNuevoPrecio_TextChanged);
            this.txtNuevoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevoPrecio_KeyPress);
            // 
            // btnAceptarPrecio
            // 
            this.btnAceptarPrecio.Location = new System.Drawing.Point(70, 120);
            this.btnAceptarPrecio.Name = "btnAceptarPrecio";
            this.btnAceptarPrecio.Size = new System.Drawing.Size(90, 32);
            this.btnAceptarPrecio.TabIndex = 4;
            this.btnAceptarPrecio.Text = "Aceptar";
            this.btnAceptarPrecio.UseVisualStyleBackColor = true;
            this.btnAceptarPrecio.Click += new System.EventHandler(this.btnAceptarPrecio_Click);
            // 
            // btnCancelarPrecio
            // 
            this.btnCancelarPrecio.Location = new System.Drawing.Point(180, 120);
            this.btnCancelarPrecio.Name = "btnCancelarPrecio";
            this.btnCancelarPrecio.Size = new System.Drawing.Size(90, 32);
            this.btnCancelarPrecio.TabIndex = 5;
            this.btnCancelarPrecio.Text = "Cancelar";
            this.btnCancelarPrecio.UseVisualStyleBackColor = true;
            this.btnCancelarPrecio.Click += new System.EventHandler(this.btnCancelarPrecio_Click);
            // 
            // FrmEditarPrecioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 154);
            this.Controls.Add(this.btnCancelarPrecio);
            this.Controls.Add(this.btnAceptarPrecio);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrecioActualValor);
            this.Controls.Add(this.lblPrecioActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarPrecioVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Precio";
            this.Load += new System.EventHandler(this.FrmEditarPrecioVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioActual;
        private System.Windows.Forms.Label lblPrecioActualValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.Button btnAceptarPrecio;
        private System.Windows.Forms.Button btnCancelarPrecio;
    }
}