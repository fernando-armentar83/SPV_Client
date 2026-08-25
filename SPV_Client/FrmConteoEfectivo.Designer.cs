namespace SPV_Client
{
    partial class FrmConteoEfectivo
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
            this.grpBilletes = new System.Windows.Forms.GroupBox();
            this.lblMil = new System.Windows.Forms.Label();
            this.lbl500 = new System.Windows.Forms.Label();
            this.lbl200 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.txt1000 = new System.Windows.Forms.TextBox();
            this.txt500 = new System.Windows.Forms.TextBox();
            this.txt200 = new System.Windows.Forms.TextBox();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.txt50 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.grpMonedas = new System.Windows.Forms.GroupBox();
            this.lbl20M = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl50M = new System.Windows.Forms.Label();
            this.txtM20 = new System.Windows.Forms.TextBox();
            this.txtM10 = new System.Windows.Forms.TextBox();
            this.txtM5 = new System.Windows.Forms.TextBox();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.txtM1 = new System.Windows.Forms.TextBox();
            this.txtM50 = new System.Windows.Forms.TextBox();
            this.lblTotalCalculado = new System.Windows.Forms.Label();
            this.lblTConta = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBilletes.SuspendLayout();
            this.grpMonedas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBilletes
            // 
            this.grpBilletes.Controls.Add(this.txt20);
            this.grpBilletes.Controls.Add(this.txt50);
            this.grpBilletes.Controls.Add(this.txt100);
            this.grpBilletes.Controls.Add(this.txt200);
            this.grpBilletes.Controls.Add(this.txt500);
            this.grpBilletes.Controls.Add(this.txt1000);
            this.grpBilletes.Controls.Add(this.lbl20);
            this.grpBilletes.Controls.Add(this.lbl100);
            this.grpBilletes.Controls.Add(this.lbl50);
            this.grpBilletes.Controls.Add(this.lbl200);
            this.grpBilletes.Controls.Add(this.lbl500);
            this.grpBilletes.Controls.Add(this.lblMil);
            this.grpBilletes.Location = new System.Drawing.Point(15, 15);
            this.grpBilletes.Name = "grpBilletes";
            this.grpBilletes.Size = new System.Drawing.Size(470, 220);
            this.grpBilletes.TabIndex = 0;
            this.grpBilletes.TabStop = false;
            this.grpBilletes.Text = "Billetes";
            // 
            // lblMil
            // 
            this.lblMil.AutoSize = true;
            this.lblMil.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMil.Location = new System.Drawing.Point(20, 35);
            this.lblMil.Name = "lblMil";
            this.lblMil.Size = new System.Drawing.Size(54, 19);
            this.lblMil.TabIndex = 0;
            this.lblMil.Text = "$1000";
            // 
            // lbl500
            // 
            this.lbl500.AutoSize = true;
            this.lbl500.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl500.Location = new System.Drawing.Point(20, 65);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(45, 19);
            this.lbl500.TabIndex = 1;
            this.lbl500.Text = "$500";
            // 
            // lbl200
            // 
            this.lbl200.AutoSize = true;
            this.lbl200.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl200.Location = new System.Drawing.Point(20, 95);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(45, 19);
            this.lbl200.TabIndex = 2;
            this.lbl200.Text = "$200";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.Location = new System.Drawing.Point(20, 125);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(45, 19);
            this.lbl100.TabIndex = 3;
            this.lbl100.Text = "$100";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50.Location = new System.Drawing.Point(20, 155);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(36, 19);
            this.lbl50.TabIndex = 1;
            this.lbl50.Text = "$50";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.Location = new System.Drawing.Point(20, 185);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(36, 19);
            this.lbl20.TabIndex = 2;
            this.lbl20.Text = "$20";
            // 
            // txt1000
            // 
            this.txt1000.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1000.Location = new System.Drawing.Point(120, 32);
            this.txt1000.Name = "txt1000";
            this.txt1000.Size = new System.Drawing.Size(70, 26);
            this.txt1000.TabIndex = 4;
            this.txt1000.Text = "0";
            this.txt1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1000.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txt1000.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txt1000.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txt500
            // 
            this.txt500.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt500.Location = new System.Drawing.Point(120, 62);
            this.txt500.Name = "txt500";
            this.txt500.Size = new System.Drawing.Size(70, 26);
            this.txt500.TabIndex = 5;
            this.txt500.Text = "0";
            this.txt500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt500.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txt500.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txt500.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txt200
            // 
            this.txt200.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt200.Location = new System.Drawing.Point(120, 92);
            this.txt200.Name = "txt200";
            this.txt200.Size = new System.Drawing.Size(70, 26);
            this.txt200.TabIndex = 6;
            this.txt200.Text = "0";
            this.txt200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt200.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txt200.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txt200.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txt100
            // 
            this.txt100.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt100.Location = new System.Drawing.Point(120, 122);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(70, 26);
            this.txt100.TabIndex = 7;
            this.txt100.Text = "0";
            this.txt100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt100.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txt100.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txt100.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txt50
            // 
            this.txt50.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt50.Location = new System.Drawing.Point(120, 152);
            this.txt50.Name = "txt50";
            this.txt50.Size = new System.Drawing.Size(70, 26);
            this.txt50.TabIndex = 8;
            this.txt50.Text = "0";
            this.txt50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt50.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txt50.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txt50.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txt20
            // 
            this.txt20.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt20.Location = new System.Drawing.Point(120, 182);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(70, 26);
            this.txt20.TabIndex = 9;
            this.txt20.Text = "0";
            this.txt20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt20.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txt20.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txt20.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // grpMonedas
            // 
            this.grpMonedas.Controls.Add(this.txtM50);
            this.grpMonedas.Controls.Add(this.txtM1);
            this.grpMonedas.Controls.Add(this.txtM2);
            this.grpMonedas.Controls.Add(this.txtM5);
            this.grpMonedas.Controls.Add(this.txtM10);
            this.grpMonedas.Controls.Add(this.txtM20);
            this.grpMonedas.Controls.Add(this.lbl50M);
            this.grpMonedas.Controls.Add(this.lbl1);
            this.grpMonedas.Controls.Add(this.lbl2);
            this.grpMonedas.Controls.Add(this.lbl5);
            this.grpMonedas.Controls.Add(this.lbl10);
            this.grpMonedas.Controls.Add(this.lbl20M);
            this.grpMonedas.Location = new System.Drawing.Point(15, 245);
            this.grpMonedas.Name = "grpMonedas";
            this.grpMonedas.Size = new System.Drawing.Size(470, 280);
            this.grpMonedas.TabIndex = 1;
            this.grpMonedas.TabStop = false;
            this.grpMonedas.Text = "0";
            this.grpMonedas.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.grpMonedas.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // lbl20M
            // 
            this.lbl20M.AutoSize = true;
            this.lbl20M.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20M.Location = new System.Drawing.Point(20, 35);
            this.lbl20M.Name = "lbl20M";
            this.lbl20M.Size = new System.Drawing.Size(36, 19);
            this.lbl20M.TabIndex = 0;
            this.lbl20M.Text = "$20";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(20, 65);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(36, 19);
            this.lbl10.TabIndex = 1;
            this.lbl10.Text = "$10";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(20, 95);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(27, 19);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "$5";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(20, 125);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(27, 19);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "$2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(20, 155);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(27, 19);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "$1";
            // 
            // lbl50M
            // 
            this.lbl50M.AutoSize = true;
            this.lbl50M.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50M.Location = new System.Drawing.Point(20, 185);
            this.lbl50M.Name = "lbl50M";
            this.lbl50M.Size = new System.Drawing.Size(45, 19);
            this.lbl50M.TabIndex = 2;
            this.lbl50M.Text = "$.50";
            // 
            // txtM20
            // 
            this.txtM20.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM20.Location = new System.Drawing.Point(120, 32);
            this.txtM20.Name = "txtM20";
            this.txtM20.Size = new System.Drawing.Size(70, 26);
            this.txtM20.TabIndex = 5;
            this.txtM20.Text = "0";
            this.txtM20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM20.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txtM20.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txtM20.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txtM10
            // 
            this.txtM10.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM10.Location = new System.Drawing.Point(120, 62);
            this.txtM10.Name = "txtM10";
            this.txtM10.Size = new System.Drawing.Size(70, 26);
            this.txtM10.TabIndex = 6;
            this.txtM10.Text = "0";
            this.txtM10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM10.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txtM10.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txtM10.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txtM5
            // 
            this.txtM5.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM5.Location = new System.Drawing.Point(120, 92);
            this.txtM5.Name = "txtM5";
            this.txtM5.Size = new System.Drawing.Size(70, 26);
            this.txtM5.TabIndex = 7;
            this.txtM5.Text = "0";
            this.txtM5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM5.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txtM5.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txtM5.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txtM2
            // 
            this.txtM2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM2.Location = new System.Drawing.Point(120, 122);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(70, 26);
            this.txtM2.TabIndex = 8;
            this.txtM2.Text = "0";
            this.txtM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM2.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txtM2.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txtM2.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txtM1
            // 
            this.txtM1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM1.Location = new System.Drawing.Point(120, 152);
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(70, 26);
            this.txtM1.TabIndex = 9;
            this.txtM1.Text = "0";
            this.txtM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM1.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txtM1.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txtM1.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // txtM50
            // 
            this.txtM50.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM50.Location = new System.Drawing.Point(120, 182);
            this.txtM50.Name = "txtM50";
            this.txtM50.Size = new System.Drawing.Size(70, 26);
            this.txtM50.TabIndex = 10;
            this.txtM50.Text = "0";
            this.txtM50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM50.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.txtM50.Enter += new System.EventHandler(this.Cantidad_Enter);
            this.txtM50.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // lblTotalCalculado
            // 
            this.lblTotalCalculado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCalculado.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalculado.Location = new System.Drawing.Point(159, 528);
            this.lblTotalCalculado.Name = "lblTotalCalculado";
            this.lblTotalCalculado.Size = new System.Drawing.Size(180, 30);
            this.lblTotalCalculado.TabIndex = 2;
            this.lblTotalCalculado.Text = "$0.00";
            this.lblTotalCalculado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTConta
            // 
            this.lblTConta.AutoSize = true;
            this.lblTConta.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTConta.Location = new System.Drawing.Point(12, 533);
            this.lblTConta.Name = "lblTConta";
            this.lblTConta.Size = new System.Drawing.Size(135, 19);
            this.lblTConta.TabIndex = 3;
            this.lblTConta.Text = "Total contado:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MintCream;
            this.btnAceptar.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(27, 576);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 45);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MintCream;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(233, 576);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 45);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmConteoEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 644);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTConta);
            this.Controls.Add(this.lblTotalCalculado);
            this.Controls.Add(this.grpMonedas);
            this.Controls.Add(this.grpBilletes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConteoEfectivo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conteo de Efectivo";
            this.Load += new System.EventHandler(this.FrmConteoEfectivo_Load);
            this.grpBilletes.ResumeLayout(false);
            this.grpBilletes.PerformLayout();
            this.grpMonedas.ResumeLayout(false);
            this.grpMonedas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBilletes;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.Label lbl500;
        private System.Windows.Forms.Label lblMil;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.TextBox txt200;
        private System.Windows.Forms.TextBox txt500;
        private System.Windows.Forms.TextBox txt1000;
        private System.Windows.Forms.GroupBox grpMonedas;
        private System.Windows.Forms.Label lbl50M;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl20M;
        private System.Windows.Forms.TextBox txtM50;
        private System.Windows.Forms.TextBox txtM1;
        private System.Windows.Forms.TextBox txtM2;
        private System.Windows.Forms.TextBox txtM5;
        private System.Windows.Forms.TextBox txtM10;
        private System.Windows.Forms.TextBox txtM20;
        private System.Windows.Forms.Label lblTotalCalculado;
        private System.Windows.Forms.Label lblTConta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}