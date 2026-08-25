namespace SPV_Client
{
    partial class FrmCobro
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
            this.lblTituloCobro = new System.Windows.Forms.Label();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.lblTotalCobro = new System.Windows.Forms.Label();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.txtVale = new System.Windows.Forms.TextBox();
            this.lblVale = new System.Windows.Forms.Label();
            this.txtTransferencia = new System.Windows.Forms.TextBox();
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.lblMontoEstado = new System.Windows.Forms.Label();
            this.lblEstadoCobro = new System.Windows.Forms.Label();
            this.lblTotalRecibido = new System.Windows.Forms.Label();
            this.lblTotalRecibidoTexto = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelarCobro = new System.Windows.Forms.Button();
            this.gbPago.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloCobro
            // 
            this.lblTituloCobro.AutoSize = true;
            this.lblTituloCobro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCobro.Location = new System.Drawing.Point(20, 20);
            this.lblTituloCobro.Name = "lblTituloCobro";
            this.lblTituloCobro.Size = new System.Drawing.Size(292, 45);
            this.lblTituloCobro.TabIndex = 0;
            this.lblTituloCobro.Text = "COBRO DE VENTA";
            // 
            // lblTotalTexto
            // 
            this.lblTotalTexto.AutoSize = true;
            this.lblTotalTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTexto.Location = new System.Drawing.Point(25, 70);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(197, 32);
            this.lblTotalTexto.TabIndex = 1;
            this.lblTotalTexto.Text = "TOTAL A PAGAR";
            // 
            // lblTotalCobro
            // 
            this.lblTotalCobro.AutoSize = true;
            this.lblTotalCobro.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCobro.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalCobro.Location = new System.Drawing.Point(25, 95);
            this.lblTotalCobro.Name = "lblTotalCobro";
            this.lblTotalCobro.Size = new System.Drawing.Size(175, 74);
            this.lblTotalCobro.TabIndex = 2;
            this.lblTotalCobro.Text = "$0.00";
            // 
            // gbPago
            // 
            this.gbPago.Controls.Add(this.txtVale);
            this.gbPago.Controls.Add(this.lblVale);
            this.gbPago.Controls.Add(this.txtTransferencia);
            this.gbPago.Controls.Add(this.lblTransferencia);
            this.gbPago.Controls.Add(this.txtTarjeta);
            this.gbPago.Controls.Add(this.lblTarjeta);
            this.gbPago.Controls.Add(this.txtEfectivo);
            this.gbPago.Controls.Add(this.lblEfectivo);
            this.gbPago.Location = new System.Drawing.Point(20, 165);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(323, 282);
            this.gbPago.TabIndex = 180;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Formas de pago";
            // 
            // txtVale
            // 
            this.txtVale.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVale.Location = new System.Drawing.Point(150, 214);
            this.txtVale.Multiline = true;
            this.txtVale.Name = "txtVale";
            this.txtVale.Size = new System.Drawing.Size(165, 44);
            this.txtVale.TabIndex = 7;
            this.txtVale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVale.TextChanged += new System.EventHandler(this.txtVale_TextChanged);
            // 
            // lblVale
            // 
            this.lblVale.AutoSize = true;
            this.lblVale.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVale.Location = new System.Drawing.Point(20, 230);
            this.lblVale.Name = "lblVale";
            this.lblVale.Size = new System.Drawing.Size(45, 19);
            this.lblVale.TabIndex = 6;
            this.lblVale.Text = "Vale";
            // 
            // txtTransferencia
            // 
            this.txtTransferencia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferencia.Location = new System.Drawing.Point(150, 150);
            this.txtTransferencia.Multiline = true;
            this.txtTransferencia.Name = "txtTransferencia";
            this.txtTransferencia.Size = new System.Drawing.Size(165, 44);
            this.txtTransferencia.TabIndex = 5;
            this.txtTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTransferencia.TextChanged += new System.EventHandler(this.txtTransferencia_TextChanged);
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferencia.Location = new System.Drawing.Point(20, 165);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(126, 19);
            this.lblTransferencia.TabIndex = 4;
            this.lblTransferencia.Text = "Transferencia";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.Location = new System.Drawing.Point(150, 87);
            this.txtTarjeta.Multiline = true;
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(165, 44);
            this.txtTarjeta.TabIndex = 3;
            this.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarjeta.TextChanged += new System.EventHandler(this.txtTarjeta_TextChanged);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(20, 100);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(72, 19);
            this.lblTarjeta.TabIndex = 2;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BackColor = System.Drawing.Color.Yellow;
            this.txtEfectivo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(150, 25);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(165, 50);
            this.txtEfectivo.TabIndex = 1;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(20, 35);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(81, 19);
            this.lblEfectivo.TabIndex = 0;
            this.lblEfectivo.Text = "Efectivo";
            // 
            // panelResumen
            // 
            this.panelResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumen.Controls.Add(this.lblMontoEstado);
            this.panelResumen.Controls.Add(this.lblEstadoCobro);
            this.panelResumen.Controls.Add(this.lblTotalRecibido);
            this.panelResumen.Controls.Add(this.lblTotalRecibidoTexto);
            this.panelResumen.Location = new System.Drawing.Point(349, 185);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(260, 239);
            this.panelResumen.TabIndex = 181;
            // 
            // lblMontoEstado
            // 
            this.lblMontoEstado.AutoSize = true;
            this.lblMontoEstado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoEstado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMontoEstado.Location = new System.Drawing.Point(61, 140);
            this.lblMontoEstado.Name = "lblMontoEstado";
            this.lblMontoEstado.Size = new System.Drawing.Size(126, 54);
            this.lblMontoEstado.TabIndex = 3;
            this.lblMontoEstado.Text = "$0.00";
            // 
            // lblEstadoCobro
            // 
            this.lblEstadoCobro.AutoSize = true;
            this.lblEstadoCobro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCobro.Location = new System.Drawing.Point(61, 115);
            this.lblEstadoCobro.Name = "lblEstadoCobro";
            this.lblEstadoCobro.Size = new System.Drawing.Size(69, 28);
            this.lblEstadoCobro.TabIndex = 2;
            this.lblEstadoCobro.Text = "FALTA";
            // 
            // lblTotalRecibido
            // 
            this.lblTotalRecibido.AutoSize = true;
            this.lblTotalRecibido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecibido.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalRecibido.Location = new System.Drawing.Point(61, 45);
            this.lblTotalRecibido.Name = "lblTotalRecibido";
            this.lblTotalRecibido.Size = new System.Drawing.Size(114, 48);
            this.lblTotalRecibido.TabIndex = 1;
            this.lblTotalRecibido.Text = "$0.00";
            // 
            // lblTotalRecibidoTexto
            // 
            this.lblTotalRecibidoTexto.AutoSize = true;
            this.lblTotalRecibidoTexto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecibidoTexto.Location = new System.Drawing.Point(45, 20);
            this.lblTotalRecibidoTexto.Name = "lblTotalRecibidoTexto";
            this.lblTotalRecibidoTexto.Size = new System.Drawing.Size(169, 28);
            this.lblTotalRecibidoTexto.TabIndex = 0;
            this.lblTotalRecibidoTexto.Text = "TOTAL RECIBIDO";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.MintCream;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(67, 475);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(180, 55);
            this.btnCobrar.TabIndex = 182;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelarCobro
            // 
            this.btnCancelarCobro.BackColor = System.Drawing.Color.MintCream;
            this.btnCancelarCobro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCobro.Location = new System.Drawing.Point(368, 475);
            this.btnCancelarCobro.Name = "btnCancelarCobro";
            this.btnCancelarCobro.Size = new System.Drawing.Size(180, 55);
            this.btnCancelarCobro.TabIndex = 183;
            this.btnCancelarCobro.Text = "Cancelar";
            this.btnCancelarCobro.UseVisualStyleBackColor = false;
            this.btnCancelarCobro.Click += new System.EventHandler(this.btnCancelarCobro_Click);
            // 
            // FrmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 564);
            this.Controls.Add(this.btnCancelarCobro);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.gbPago);
            this.Controls.Add(this.lblTotalCobro);
            this.Controls.Add(this.lblTotalTexto);
            this.Controls.Add(this.lblTituloCobro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCobro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro";
            this.Load += new System.EventHandler(this.FrmCobro_Load);
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCobro;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblTotalCobro;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtTransferencia;
        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.TextBox txtVale;
        private System.Windows.Forms.Label lblVale;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Label lblTotalRecibido;
        private System.Windows.Forms.Label lblTotalRecibidoTexto;
        private System.Windows.Forms.Label lblMontoEstado;
        private System.Windows.Forms.Label lblEstadoCobro;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelarCobro;
    }
}