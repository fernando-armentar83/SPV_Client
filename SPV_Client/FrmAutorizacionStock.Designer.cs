namespace SPV_Client
{
    partial class FrmAutorizacionStock
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboUsuarioAutoriza = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPasswordAuto = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnCancelarStk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(197, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(327, 25);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario administrador / supervisor";
            // 
            // cboUsuarioAutoriza
            // 
            this.cboUsuarioAutoriza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarioAutoriza.FormattingEnabled = true;
            this.cboUsuarioAutoriza.Location = new System.Drawing.Point(76, 119);
            this.cboUsuarioAutoriza.Name = "cboUsuarioAutoriza";
            this.cboUsuarioAutoriza.Size = new System.Drawing.Size(250, 28);
            this.cboUsuarioAutoriza.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(76, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(140, 26);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = " Contraseña :";
            // 
            // txtPasswordAuto
            // 
            this.txtPasswordAuto.Location = new System.Drawing.Point(239, 188);
            this.txtPasswordAuto.Name = "txtPasswordAuto";
            this.txtPasswordAuto.Size = new System.Drawing.Size(250, 26);
            this.txtPasswordAuto.TabIndex = 1;
            this.txtPasswordAuto.UseSystemPasswordChar = true;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(270, 237);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(253, 24);
            this.lblMotivo.TabIndex = 7;
            this.lblMotivo.Text = "Motivo de la autorización.";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(228, 264);
            this.txtMotivo.MaxLength = 300;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(320, 60);
            this.txtMotivo.TabIndex = 2;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAutorizar.Location = new System.Drawing.Point(128, 373);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(140, 37);
            this.btnAutorizar.TabIndex = 3;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = false;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnCancelarStk
            // 
            this.btnCancelarStk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarStk.Location = new System.Drawing.Point(428, 373);
            this.btnCancelarStk.Name = "btnCancelarStk";
            this.btnCancelarStk.Size = new System.Drawing.Size(120, 37);
            this.btnCancelarStk.TabIndex = 4;
            this.btnCancelarStk.Text = "Cancelar";
            this.btnCancelarStk.UseVisualStyleBackColor = true;
            this.btnCancelarStk.Click += new System.EventHandler(this.btnCancelarStk_Click);
            // 
            // FrmAutorizacionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarStk);
            this.Controls.Add(this.btnAutorizar);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtPasswordAuto);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cboUsuarioAutoriza);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutorizacionStock";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autorización de stock insuficiente";
            this.Load += new System.EventHandler(this.FrmAutorizacionStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboUsuarioAutoriza;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPasswordAuto;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnCancelarStk;
    }
}