namespace SPV_Client
{
    partial class FrmTicket
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
            this.pnlFormato = new System.Windows.Forms.Panel();
            this.rb80mm = new System.Windows.Forms.RadioButton();
            this.lblFormatoTk = new System.Windows.Forms.Label();
            this.rb55mm = new System.Windows.Forms.RadioButton();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.txtLinea3 = new System.Windows.Forms.TextBox();
            this.lblLinea3 = new System.Windows.Forms.Label();
            this.txtLinea2 = new System.Windows.Forms.TextBox();
            this.lblLinea2 = new System.Windows.Forms.Label();
            this.txtNombreNegocio = new System.Windows.Forms.TextBox();
            this.lblNombreNegocio = new System.Windows.Forms.Label();
            this.pnlDatosVenta = new System.Windows.Forms.Panel();
            this.lblCajeroValor = new System.Windows.Forms.Label();
            this.lblHoraValor = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.lblFolioValor = new System.Windows.Forms.Label();
            this.lblCajeroTitulo = new System.Windows.Forms.Label();
            this.lblHoraTitulo = new System.Windows.Forms.Label();
            this.lblFechaTitulo = new System.Windows.Forms.Label();
            this.lblFolioTitulo = new System.Windows.Forms.Label();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrarTicket = new System.Windows.Forms.Button();
            this.txtMensajeFinal = new System.Windows.Forms.TextBox();
            this.lblMensajeFinal = new System.Windows.Forms.Label();
            this.lblTotalTicket = new System.Windows.Forms.Label();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.printDocumentTicket = new System.Drawing.Printing.PrintDocument();
            this.pnlFormato.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.pnlDatosVenta.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormato
            // 
            this.pnlFormato.Controls.Add(this.rb80mm);
            this.pnlFormato.Controls.Add(this.lblFormatoTk);
            this.pnlFormato.Controls.Add(this.rb55mm);
            this.pnlFormato.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormato.Location = new System.Drawing.Point(0, 0);
            this.pnlFormato.Name = "pnlFormato";
            this.pnlFormato.Size = new System.Drawing.Size(818, 81);
            this.pnlFormato.TabIndex = 0;
            // 
            // rb80mm
            // 
            this.rb80mm.AutoSize = true;
            this.rb80mm.Location = new System.Drawing.Point(471, 26);
            this.rb80mm.Name = "rb80mm";
            this.rb80mm.Size = new System.Drawing.Size(78, 24);
            this.rb80mm.TabIndex = 2;
            this.rb80mm.TabStop = true;
            this.rb80mm.Text = "80mm";
            this.rb80mm.UseVisualStyleBackColor = true;
            // 
            // lblFormatoTk
            // 
            this.lblFormatoTk.AutoSize = true;
            this.lblFormatoTk.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatoTk.Location = new System.Drawing.Point(31, 25);
            this.lblFormatoTk.Name = "lblFormatoTk";
            this.lblFormatoTk.Size = new System.Drawing.Size(170, 23);
            this.lblFormatoTk.TabIndex = 1;
            this.lblFormatoTk.Text = "Formato de Ticket";
            // 
            // rb55mm
            // 
            this.rb55mm.AutoSize = true;
            this.rb55mm.Location = new System.Drawing.Point(259, 24);
            this.rb55mm.Name = "rb55mm";
            this.rb55mm.Size = new System.Drawing.Size(78, 24);
            this.rb55mm.TabIndex = 1;
            this.rb55mm.TabStop = true;
            this.rb55mm.Text = "55mm";
            this.rb55mm.UseVisualStyleBackColor = true;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.txtLinea3);
            this.pnlEncabezado.Controls.Add(this.lblLinea3);
            this.pnlEncabezado.Controls.Add(this.txtLinea2);
            this.pnlEncabezado.Controls.Add(this.lblLinea2);
            this.pnlEncabezado.Controls.Add(this.txtNombreNegocio);
            this.pnlEncabezado.Controls.Add(this.lblNombreNegocio);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 81);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(818, 238);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // txtLinea3
            // 
            this.txtLinea3.Location = new System.Drawing.Point(173, 188);
            this.txtLinea3.Name = "txtLinea3";
            this.txtLinea3.Size = new System.Drawing.Size(457, 26);
            this.txtLinea3.TabIndex = 6;
            // 
            // lblLinea3
            // 
            this.lblLinea3.AutoSize = true;
            this.lblLinea3.Location = new System.Drawing.Point(227, 165);
            this.lblLinea3.Name = "lblLinea3";
            this.lblLinea3.Size = new System.Drawing.Size(155, 20);
            this.lblLinea3.TabIndex = 5;
            this.lblLinea3.Text = "Encabezado Linea 3";
            // 
            // txtLinea2
            // 
            this.txtLinea2.Location = new System.Drawing.Point(173, 113);
            this.txtLinea2.Name = "txtLinea2";
            this.txtLinea2.Size = new System.Drawing.Size(457, 26);
            this.txtLinea2.TabIndex = 4;
            // 
            // lblLinea2
            // 
            this.lblLinea2.AutoSize = true;
            this.lblLinea2.Location = new System.Drawing.Point(227, 90);
            this.lblLinea2.Name = "lblLinea2";
            this.lblLinea2.Size = new System.Drawing.Size(155, 20);
            this.lblLinea2.TabIndex = 3;
            this.lblLinea2.Text = "Encabezado Linea 2";
            // 
            // txtNombreNegocio
            // 
            this.txtNombreNegocio.Location = new System.Drawing.Point(173, 50);
            this.txtNombreNegocio.Name = "txtNombreNegocio";
            this.txtNombreNegocio.Size = new System.Drawing.Size(457, 26);
            this.txtNombreNegocio.TabIndex = 2;
            // 
            // lblNombreNegocio
            // 
            this.lblNombreNegocio.AutoSize = true;
            this.lblNombreNegocio.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNegocio.Location = new System.Drawing.Point(268, 12);
            this.lblNombreNegocio.Name = "lblNombreNegocio";
            this.lblNombreNegocio.Size = new System.Drawing.Size(263, 23);
            this.lblNombreNegocio.TabIndex = 2;
            this.lblNombreNegocio.Text = "Tlapa y Pape \"Nordikos\"";
            // 
            // pnlDatosVenta
            // 
            this.pnlDatosVenta.Controls.Add(this.lblCajeroValor);
            this.pnlDatosVenta.Controls.Add(this.lblHoraValor);
            this.pnlDatosVenta.Controls.Add(this.lblFechaValor);
            this.pnlDatosVenta.Controls.Add(this.lblFolioValor);
            this.pnlDatosVenta.Controls.Add(this.lblCajeroTitulo);
            this.pnlDatosVenta.Controls.Add(this.lblHoraTitulo);
            this.pnlDatosVenta.Controls.Add(this.lblFechaTitulo);
            this.pnlDatosVenta.Controls.Add(this.lblFolioTitulo);
            this.pnlDatosVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosVenta.Location = new System.Drawing.Point(0, 319);
            this.pnlDatosVenta.Name = "pnlDatosVenta";
            this.pnlDatosVenta.Size = new System.Drawing.Size(818, 135);
            this.pnlDatosVenta.TabIndex = 2;
            this.pnlDatosVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatosVenta_Paint);
            // 
            // lblCajeroValor
            // 
            this.lblCajeroValor.AutoSize = true;
            this.lblCajeroValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCajeroValor.Location = new System.Drawing.Point(82, 96);
            this.lblCajeroValor.Name = "lblCajeroValor";
            this.lblCajeroValor.Size = new System.Drawing.Size(2, 22);
            this.lblCajeroValor.TabIndex = 7;
            // 
            // lblHoraValor
            // 
            this.lblHoraValor.AutoSize = true;
            this.lblHoraValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoraValor.Location = new System.Drawing.Point(83, 64);
            this.lblHoraValor.Name = "lblHoraValor";
            this.lblHoraValor.Size = new System.Drawing.Size(2, 22);
            this.lblHoraValor.TabIndex = 6;
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaValor.Location = new System.Drawing.Point(84, 33);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(2, 22);
            this.lblFechaValor.TabIndex = 5;
            // 
            // lblFolioValor
            // 
            this.lblFolioValor.AutoSize = true;
            this.lblFolioValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFolioValor.Location = new System.Drawing.Point(84, 2);
            this.lblFolioValor.Name = "lblFolioValor";
            this.lblFolioValor.Size = new System.Drawing.Size(2, 22);
            this.lblFolioValor.TabIndex = 4;
            // 
            // lblCajeroTitulo
            // 
            this.lblCajeroTitulo.AutoSize = true;
            this.lblCajeroTitulo.Location = new System.Drawing.Point(8, 96);
            this.lblCajeroTitulo.Name = "lblCajeroTitulo";
            this.lblCajeroTitulo.Size = new System.Drawing.Size(63, 20);
            this.lblCajeroTitulo.TabIndex = 3;
            this.lblCajeroTitulo.Text = "Cajero :";
            // 
            // lblHoraTitulo
            // 
            this.lblHoraTitulo.AutoSize = true;
            this.lblHoraTitulo.Location = new System.Drawing.Point(19, 64);
            this.lblHoraTitulo.Name = "lblHoraTitulo";
            this.lblHoraTitulo.Size = new System.Drawing.Size(52, 20);
            this.lblHoraTitulo.TabIndex = 2;
            this.lblHoraTitulo.Text = "Hora :";
            // 
            // lblFechaTitulo
            // 
            this.lblFechaTitulo.AutoSize = true;
            this.lblFechaTitulo.Location = new System.Drawing.Point(10, 33);
            this.lblFechaTitulo.Name = "lblFechaTitulo";
            this.lblFechaTitulo.Size = new System.Drawing.Size(62, 20);
            this.lblFechaTitulo.TabIndex = 1;
            this.lblFechaTitulo.Text = "Fecha :";
            // 
            // lblFolioTitulo
            // 
            this.lblFolioTitulo.AutoSize = true;
            this.lblFolioTitulo.Location = new System.Drawing.Point(21, 3);
            this.lblFolioTitulo.Name = "lblFolioTitulo";
            this.lblFolioTitulo.Size = new System.Drawing.Size(51, 20);
            this.lblFolioTitulo.TabIndex = 0;
            this.lblFolioTitulo.Text = "Folio :";
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.dgvDetalle);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 454);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(818, 415);
            this.pnlDetalle.TabIndex = 3;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 62;
            this.dgvDetalle.RowTemplate.Height = 28;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(818, 415);
            this.dgvDetalle.TabIndex = 0;
            // 
            // pnlTotales
            // 
            this.pnlTotales.Controls.Add(this.btnImprimir);
            this.pnlTotales.Controls.Add(this.btnCerrarTicket);
            this.pnlTotales.Controls.Add(this.txtMensajeFinal);
            this.pnlTotales.Controls.Add(this.lblMensajeFinal);
            this.pnlTotales.Controls.Add(this.lblTotalTicket);
            this.pnlTotales.Controls.Add(this.lblTituloTotal);
            this.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotales.Location = new System.Drawing.Point(0, 726);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(818, 143);
            this.pnlTotales.TabIndex = 4;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Honeydew;
            this.btnImprimir.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(163, 64);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 41);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrarTicket
            // 
            this.btnCerrarTicket.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrarTicket.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarTicket.Location = new System.Drawing.Point(23, 62);
            this.btnCerrarTicket.Name = "btnCerrarTicket";
            this.btnCerrarTicket.Size = new System.Drawing.Size(85, 43);
            this.btnCerrarTicket.TabIndex = 6;
            this.btnCerrarTicket.Text = "Cerrar";
            this.btnCerrarTicket.UseVisualStyleBackColor = false;
            this.btnCerrarTicket.Click += new System.EventHandler(this.btnCerrarTicket_Click);
            // 
            // txtMensajeFinal
            // 
            this.txtMensajeFinal.Location = new System.Drawing.Point(290, 62);
            this.txtMensajeFinal.Multiline = true;
            this.txtMensajeFinal.Name = "txtMensajeFinal";
            this.txtMensajeFinal.Size = new System.Drawing.Size(229, 43);
            this.txtMensajeFinal.TabIndex = 5;
            this.txtMensajeFinal.Visible = false;
            // 
            // lblMensajeFinal
            // 
            this.lblMensajeFinal.AutoSize = true;
            this.lblMensajeFinal.Location = new System.Drawing.Point(286, 17);
            this.lblMensajeFinal.Name = "lblMensajeFinal";
            this.lblMensajeFinal.Size = new System.Drawing.Size(233, 20);
            this.lblMensajeFinal.TabIndex = 4;
            this.lblMensajeFinal.Text = "¡GRACIAS POR SU COMPRA! ";
            this.lblMensajeFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTicket
            // 
            this.lblTotalTicket.AutoSize = true;
            this.lblTotalTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTicket.Location = new System.Drawing.Point(697, 17);
            this.lblTotalTicket.Name = "lblTotalTicket";
            this.lblTotalTicket.Size = new System.Drawing.Size(2, 22);
            this.lblTotalTicket.TabIndex = 3;
            this.lblTotalTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotal.Location = new System.Drawing.Point(628, 17);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(59, 20);
            this.lblTituloTotal.TabIndex = 2;
            this.lblTituloTotal.Text = "Total :";
            this.lblTituloTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 869);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlDatosVenta);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlFormato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion de Ticket";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            this.pnlFormato.ResumeLayout(false);
            this.pnlFormato.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlDatosVenta.ResumeLayout(false);
            this.pnlDatosVenta.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormato;
        private System.Windows.Forms.Label lblFormatoTk;
        private System.Windows.Forms.RadioButton rb80mm;
        private System.Windows.Forms.RadioButton rb55mm;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblNombreNegocio;
        private System.Windows.Forms.TextBox txtNombreNegocio;
        private System.Windows.Forms.Label lblLinea2;
        private System.Windows.Forms.TextBox txtLinea3;
        private System.Windows.Forms.Label lblLinea3;
        private System.Windows.Forms.TextBox txtLinea2;
        private System.Windows.Forms.Panel pnlDatosVenta;
        private System.Windows.Forms.Label lblCajeroTitulo;
        private System.Windows.Forms.Label lblHoraTitulo;
        private System.Windows.Forms.Label lblFechaTitulo;
        private System.Windows.Forms.Label lblFolioTitulo;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lblFolioValor;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblHoraValor;
        private System.Windows.Forms.Label lblCajeroValor;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblMensajeFinal;
        private System.Windows.Forms.Label lblTotalTicket;
        private System.Windows.Forms.Label lblTituloTotal;
        private System.Windows.Forms.TextBox txtMensajeFinal;
        private System.Windows.Forms.Button btnCerrarTicket;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocumentTicket;
    }
}