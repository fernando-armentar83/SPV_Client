namespace SPV_Client
{
    partial class FrmTicketCompra
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
            this.rtbTicket = new System.Windows.Forms.RichTextBox();
            this.btnImprimirT = new System.Windows.Forms.Button();
            this.btnCerrarTicket = new System.Windows.Forms.Button();
            this.pnlbotnesticket = new System.Windows.Forms.Panel();
            this.pnlbotnesticket.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTicket
            // 
            this.rtbTicket.BackColor = System.Drawing.Color.White;
            this.rtbTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTicket.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTicket.Location = new System.Drawing.Point(0, 0);
            this.rtbTicket.Name = "rtbTicket";
            this.rtbTicket.ReadOnly = true;
            this.rtbTicket.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbTicket.Size = new System.Drawing.Size(478, 539);
            this.rtbTicket.TabIndex = 4;
            this.rtbTicket.Text = "";
            // 
            // btnImprimirT
            // 
            this.btnImprimirT.BackColor = System.Drawing.Color.Ivory;
            this.btnImprimirT.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirT.Location = new System.Drawing.Point(81, 9);
            this.btnImprimirT.Name = "btnImprimirT";
            this.btnImprimirT.Size = new System.Drawing.Size(88, 34);
            this.btnImprimirT.TabIndex = 1;
            this.btnImprimirT.Text = "Imprimir";
            this.btnImprimirT.UseVisualStyleBackColor = false;
            this.btnImprimirT.Click += new System.EventHandler(this.btnImprimirT_Click);
            // 
            // btnCerrarTicket
            // 
            this.btnCerrarTicket.BackColor = System.Drawing.Color.Ivory;
            this.btnCerrarTicket.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarTicket.Location = new System.Drawing.Point(263, 9);
            this.btnCerrarTicket.Name = "btnCerrarTicket";
            this.btnCerrarTicket.Size = new System.Drawing.Size(88, 34);
            this.btnCerrarTicket.TabIndex = 2;
            this.btnCerrarTicket.Text = "Cerrar";
            this.btnCerrarTicket.UseVisualStyleBackColor = false;
            this.btnCerrarTicket.Click += new System.EventHandler(this.btnCerrarTicket_Click);
            // 
            // pnlbotnesticket
            // 
            this.pnlbotnesticket.Controls.Add(this.btnImprimirT);
            this.pnlbotnesticket.Controls.Add(this.btnCerrarTicket);
            this.pnlbotnesticket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbotnesticket.Location = new System.Drawing.Point(0, 539);
            this.pnlbotnesticket.Name = "pnlbotnesticket";
            this.pnlbotnesticket.Size = new System.Drawing.Size(478, 55);
            this.pnlbotnesticket.TabIndex = 5;
            // 
            // FrmTicketCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 594);
            this.Controls.Add(this.rtbTicket);
            this.Controls.Add(this.pnlbotnesticket);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTicketCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Compra";
            this.Load += new System.EventHandler(this.FrmTicketCompra_Load);
            this.pnlbotnesticket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTicket;
        private System.Windows.Forms.Button btnImprimirT;
        private System.Windows.Forms.Button btnCerrarTicket;
        private System.Windows.Forms.Panel pnlbotnesticket;
    }
}