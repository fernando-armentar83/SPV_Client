namespace SPV_Client
{
    partial class FrmCierreSesion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValorArqueoElectronico = new System.Windows.Forms.Label();
            this.lblArqueoElectronico = new System.Windows.Forms.Label();
            this.lblValorTotalRetirado = new System.Windows.Forms.Label();
            this.lblTotalRetirado = new System.Windows.Forms.Label();
            this.lblValorArqueosRealizados = new System.Windows.Forms.Label();
            this.lblArqueosRealizados = new System.Windows.Forms.Label();
            this.lblTotalTurno = new System.Windows.Forms.Label();
            this.lblVentasElectronico = new System.Windows.Forms.Label();
            this.lblVentasEfectivo = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblValorDiferenciaTotal = new System.Windows.Forms.Label();
            this.lblDiferenciaTotal = new System.Windows.Forms.Label();
            this.lblValorDiferenciaElectronico = new System.Windows.Forms.Label();
            this.lblDiferenciaElectronico = new System.Windows.Forms.Label();
            this.txtElectronicoContado = new System.Windows.Forms.TextBox();
            this.lblElectronicoContado = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblValorDiferenciaEfectivo = new System.Windows.Forms.Label();
            this.lblDiferenciaEfectivo = new System.Windows.Forms.Label();
            this.txtEfectivoContado = new System.Windows.Forms.TextBox();
            this.lblEfectivoContado = new System.Windows.Forms.Label();
            this.btnConfirmarCorte = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.lblHoraCorte = new System.Windows.Forms.Label();
            this.btnConteoEfectivo = new System.Windows.Forms.Button();
            this.lblTurnoActivo = new System.Windows.Forms.Label();
            this.lblTotalHistorico = new System.Windows.Forms.Label();
            this.lblValorTotalHistorico = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(253, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(275, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CERRAR SESION";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.Location = new System.Drawing.Point(85, 57);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(100, 24);
            this.lblU.TabIndex = 1;
            this.lblU.Text = "Usuario :";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(12, 109);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(168, 24);
            this.lblH.TabIndex = 2;
            this.lblH.Text = "Hora del Corte :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.lblValorTotalHistorico);
            this.groupBox1.Controls.Add(this.lblTotalHistorico);
            this.groupBox1.Controls.Add(this.lblValorArqueoElectronico);
            this.groupBox1.Controls.Add(this.lblArqueoElectronico);
            this.groupBox1.Controls.Add(this.lblValorTotalRetirado);
            this.groupBox1.Controls.Add(this.lblTotalRetirado);
            this.groupBox1.Controls.Add(this.lblValorArqueosRealizados);
            this.groupBox1.Controls.Add(this.lblArqueosRealizados);
            this.groupBox1.Controls.Add(this.lblTotalTurno);
            this.groupBox1.Controls.Add(this.lblVentasElectronico);
            this.groupBox1.Controls.Add(this.lblVentasEfectivo);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(58, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen General de Turno";
            // 
            // lblValorArqueoElectronico
            // 
            this.lblValorArqueoElectronico.AutoSize = true;
            this.lblValorArqueoElectronico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorArqueoElectronico.ForeColor = System.Drawing.Color.Black;
            this.lblValorArqueoElectronico.Location = new System.Drawing.Point(655, 122);
            this.lblValorArqueoElectronico.Name = "lblValorArqueoElectronico";
            this.lblValorArqueoElectronico.Size = new System.Drawing.Size(33, 25);
            this.lblValorArqueoElectronico.TabIndex = 11;
            this.lblValorArqueoElectronico.Text = "---";
            this.lblValorArqueoElectronico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArqueoElectronico
            // 
            this.lblArqueoElectronico.AutoSize = true;
            this.lblArqueoElectronico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArqueoElectronico.ForeColor = System.Drawing.Color.Black;
            this.lblArqueoElectronico.Location = new System.Drawing.Point(445, 119);
            this.lblArqueoElectronico.Name = "lblArqueoElectronico";
            this.lblArqueoElectronico.Size = new System.Drawing.Size(206, 25);
            this.lblArqueoElectronico.TabIndex = 10;
            this.lblArqueoElectronico.Text = "Electrónico Arqueado :";
            // 
            // lblValorTotalRetirado
            // 
            this.lblValorTotalRetirado.AutoSize = true;
            this.lblValorTotalRetirado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalRetirado.ForeColor = System.Drawing.Color.Black;
            this.lblValorTotalRetirado.Location = new System.Drawing.Point(654, 80);
            this.lblValorTotalRetirado.Name = "lblValorTotalRetirado";
            this.lblValorTotalRetirado.Size = new System.Drawing.Size(33, 25);
            this.lblValorTotalRetirado.TabIndex = 9;
            this.lblValorTotalRetirado.Text = "---";
            this.lblValorTotalRetirado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalRetirado
            // 
            this.lblTotalRetirado.AutoSize = true;
            this.lblTotalRetirado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRetirado.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRetirado.Location = new System.Drawing.Point(454, 80);
            this.lblTotalRetirado.Name = "lblTotalRetirado";
            this.lblTotalRetirado.Size = new System.Drawing.Size(197, 25);
            this.lblTotalRetirado.TabIndex = 8;
            this.lblTotalRetirado.Text = "Retirado en Arqueos :";
            // 
            // lblValorArqueosRealizados
            // 
            this.lblValorArqueosRealizados.AutoSize = true;
            this.lblValorArqueosRealizados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorArqueosRealizados.ForeColor = System.Drawing.Color.Black;
            this.lblValorArqueosRealizados.Location = new System.Drawing.Point(654, 38);
            this.lblValorArqueosRealizados.Name = "lblValorArqueosRealizados";
            this.lblValorArqueosRealizados.Size = new System.Drawing.Size(33, 25);
            this.lblValorArqueosRealizados.TabIndex = 7;
            this.lblValorArqueosRealizados.Text = "---";
            this.lblValorArqueosRealizados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArqueosRealizados
            // 
            this.lblArqueosRealizados.AutoSize = true;
            this.lblArqueosRealizados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArqueosRealizados.ForeColor = System.Drawing.Color.Black;
            this.lblArqueosRealizados.Location = new System.Drawing.Point(558, 38);
            this.lblArqueosRealizados.Name = "lblArqueosRealizados";
            this.lblArqueosRealizados.Size = new System.Drawing.Size(93, 25);
            this.lblArqueosRealizados.TabIndex = 6;
            this.lblArqueosRealizados.Text = "Arqueos :";
            // 
            // lblTotalTurno
            // 
            this.lblTotalTurno.AutoSize = true;
            this.lblTotalTurno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTurno.ForeColor = System.Drawing.Color.Black;
            this.lblTotalTurno.Location = new System.Drawing.Point(278, 119);
            this.lblTotalTurno.Name = "lblTotalTurno";
            this.lblTotalTurno.Size = new System.Drawing.Size(33, 25);
            this.lblTotalTurno.TabIndex = 5;
            this.lblTotalTurno.Text = "---";
            // 
            // lblVentasElectronico
            // 
            this.lblVentasElectronico.AutoSize = true;
            this.lblVentasElectronico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasElectronico.ForeColor = System.Drawing.Color.Black;
            this.lblVentasElectronico.Location = new System.Drawing.Point(279, 81);
            this.lblVentasElectronico.Name = "lblVentasElectronico";
            this.lblVentasElectronico.Size = new System.Drawing.Size(33, 25);
            this.lblVentasElectronico.TabIndex = 4;
            this.lblVentasElectronico.Text = "---";
            // 
            // lblVentasEfectivo
            // 
            this.lblVentasEfectivo.AutoSize = true;
            this.lblVentasEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasEfectivo.ForeColor = System.Drawing.Color.Black;
            this.lblVentasEfectivo.Location = new System.Drawing.Point(279, 40);
            this.lblVentasEfectivo.Name = "lblVentasEfectivo";
            this.lblVentasEfectivo.Size = new System.Drawing.Size(33, 25);
            this.lblVentasEfectivo.TabIndex = 3;
            this.lblVentasEfectivo.Text = "---";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(13, 119);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(256, 25);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Total Pendiente de Verificar :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(61, 80);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(207, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Electrónico Pendiente :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(28, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(241, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Efectivo Esperado en Caja :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.lblValorDiferenciaTotal);
            this.groupBox3.Controls.Add(this.btnConteoEfectivo);
            this.groupBox3.Controls.Add(this.lblDiferenciaTotal);
            this.groupBox3.Controls.Add(this.lblValorDiferenciaElectronico);
            this.groupBox3.Controls.Add(this.lblDiferenciaElectronico);
            this.groupBox3.Controls.Add(this.txtElectronicoContado);
            this.groupBox3.Controls.Add(this.lblElectronicoContado);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.lblObservaciones);
            this.groupBox3.Controls.Add(this.lblValorDiferenciaEfectivo);
            this.groupBox3.Controls.Add(this.lblDiferenciaEfectivo);
            this.groupBox3.Controls.Add(this.txtEfectivoContado);
            this.groupBox3.Controls.Add(this.lblEfectivoContado);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Location = new System.Drawing.Point(58, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 394);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control de Cierre";
            // 
            // lblValorDiferenciaTotal
            // 
            this.lblValorDiferenciaTotal.AutoSize = true;
            this.lblValorDiferenciaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorDiferenciaTotal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDiferenciaTotal.ForeColor = System.Drawing.Color.Black;
            this.lblValorDiferenciaTotal.Location = new System.Drawing.Point(283, 252);
            this.lblValorDiferenciaTotal.Name = "lblValorDiferenciaTotal";
            this.lblValorDiferenciaTotal.Size = new System.Drawing.Size(2, 24);
            this.lblValorDiferenciaTotal.TabIndex = 11;
            // 
            // lblDiferenciaTotal
            // 
            this.lblDiferenciaTotal.AutoSize = true;
            this.lblDiferenciaTotal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferenciaTotal.ForeColor = System.Drawing.Color.Black;
            this.lblDiferenciaTotal.Location = new System.Drawing.Point(66, 252);
            this.lblDiferenciaTotal.Name = "lblDiferenciaTotal";
            this.lblDiferenciaTotal.Size = new System.Drawing.Size(190, 22);
            this.lblDiferenciaTotal.TabIndex = 10;
            this.lblDiferenciaTotal.Text = "Diferencia Total :";
            // 
            // lblValorDiferenciaElectronico
            // 
            this.lblValorDiferenciaElectronico.AutoSize = true;
            this.lblValorDiferenciaElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorDiferenciaElectronico.ForeColor = System.Drawing.Color.Black;
            this.lblValorDiferenciaElectronico.Location = new System.Drawing.Point(283, 202);
            this.lblValorDiferenciaElectronico.Name = "lblValorDiferenciaElectronico";
            this.lblValorDiferenciaElectronico.Size = new System.Drawing.Size(2, 26);
            this.lblValorDiferenciaElectronico.TabIndex = 9;
            // 
            // lblDiferenciaElectronico
            // 
            this.lblDiferenciaElectronico.AutoSize = true;
            this.lblDiferenciaElectronico.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferenciaElectronico.ForeColor = System.Drawing.Color.Black;
            this.lblDiferenciaElectronico.Location = new System.Drawing.Point(6, 202);
            this.lblDiferenciaElectronico.Name = "lblDiferenciaElectronico";
            this.lblDiferenciaElectronico.Size = new System.Drawing.Size(250, 22);
            this.lblDiferenciaElectronico.TabIndex = 8;
            this.lblDiferenciaElectronico.Text = "Diferencia Electrónico :";
            // 
            // txtElectronicoContado
            // 
            this.txtElectronicoContado.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectronicoContado.Location = new System.Drawing.Point(283, 82);
            this.txtElectronicoContado.Name = "txtElectronicoContado";
            this.txtElectronicoContado.Size = new System.Drawing.Size(147, 29);
            this.txtElectronicoContado.TabIndex = 7;
            this.txtElectronicoContado.Text = "0.00";
            this.txtElectronicoContado.TextChanged += new System.EventHandler(this.txtElectronicoContado_TextChanged);
            // 
            // lblElectronicoContado
            // 
            this.lblElectronicoContado.AutoSize = true;
            this.lblElectronicoContado.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectronicoContado.ForeColor = System.Drawing.Color.Black;
            this.lblElectronicoContado.Location = new System.Drawing.Point(46, 82);
            this.lblElectronicoContado.Name = "lblElectronicoContado";
            this.lblElectronicoContado.Size = new System.Drawing.Size(210, 22);
            this.lblElectronicoContado.TabIndex = 6;
            this.lblElectronicoContado.Text = "Electrónico Contado:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(241, 307);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(482, 60);
            this.txtObservaciones.TabIndex = 5;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.Black;
            this.lblObservaciones.Location = new System.Drawing.Point(36, 307);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(160, 22);
            this.lblObservaciones.TabIndex = 4;
            this.lblObservaciones.Text = "Observaciones :";
            // 
            // lblValorDiferenciaEfectivo
            // 
            this.lblValorDiferenciaEfectivo.AutoSize = true;
            this.lblValorDiferenciaEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorDiferenciaEfectivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDiferenciaEfectivo.ForeColor = System.Drawing.Color.Black;
            this.lblValorDiferenciaEfectivo.Location = new System.Drawing.Point(283, 140);
            this.lblValorDiferenciaEfectivo.Name = "lblValorDiferenciaEfectivo";
            this.lblValorDiferenciaEfectivo.Size = new System.Drawing.Size(2, 23);
            this.lblValorDiferenciaEfectivo.TabIndex = 3;
            this.lblValorDiferenciaEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiferenciaEfectivo
            // 
            this.lblDiferenciaEfectivo.AutoSize = true;
            this.lblDiferenciaEfectivo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferenciaEfectivo.ForeColor = System.Drawing.Color.Black;
            this.lblDiferenciaEfectivo.Location = new System.Drawing.Point(36, 141);
            this.lblDiferenciaEfectivo.Name = "lblDiferenciaEfectivo";
            this.lblDiferenciaEfectivo.Size = new System.Drawing.Size(220, 22);
            this.lblDiferenciaEfectivo.TabIndex = 2;
            this.lblDiferenciaEfectivo.Text = "Diferencia Efectivo :";
            // 
            // txtEfectivoContado
            // 
            this.txtEfectivoContado.Location = new System.Drawing.Point(283, 21);
            this.txtEfectivoContado.Name = "txtEfectivoContado";
            this.txtEfectivoContado.Size = new System.Drawing.Size(147, 30);
            this.txtEfectivoContado.TabIndex = 1;
            this.txtEfectivoContado.TextChanged += new System.EventHandler(this.txtEfectivoContado_TextChanged);
            // 
            // lblEfectivoContado
            // 
            this.lblEfectivoContado.AutoSize = true;
            this.lblEfectivoContado.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivoContado.ForeColor = System.Drawing.Color.Black;
            this.lblEfectivoContado.Location = new System.Drawing.Point(66, 29);
            this.lblEfectivoContado.Name = "lblEfectivoContado";
            this.lblEfectivoContado.Size = new System.Drawing.Size(190, 22);
            this.lblEfectivoContado.TabIndex = 0;
            this.lblEfectivoContado.Text = "Efectivo Contado :";
            // 
            // btnConfirmarCorte
            // 
            this.btnConfirmarCorte.BackColor = System.Drawing.Color.LightCyan;
            this.btnConfirmarCorte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCorte.Location = new System.Drawing.Point(270, 837);
            this.btnConfirmarCorte.Name = "btnConfirmarCorte";
            this.btnConfirmarCorte.Size = new System.Drawing.Size(127, 63);
            this.btnConfirmarCorte.TabIndex = 8;
            this.btnConfirmarCorte.Text = "Confirmar Corte";
            this.btnConfirmarCorte.UseVisualStyleBackColor = false;
            this.btnConfirmarCorte.Click += new System.EventHandler(this.btnConfirmarCorte_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCyan;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(581, 837);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 63);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.Location = new System.Drawing.Point(191, 55);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(36, 28);
            this.lblUsuarioActivo.TabIndex = 11;
            this.lblUsuarioActivo.Text = "---";
            this.lblUsuarioActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoraCorte
            // 
            this.lblHoraCorte.AutoSize = true;
            this.lblHoraCorte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCorte.Location = new System.Drawing.Point(191, 112);
            this.lblHoraCorte.Name = "lblHoraCorte";
            this.lblHoraCorte.Size = new System.Drawing.Size(28, 21);
            this.lblHoraCorte.TabIndex = 12;
            this.lblHoraCorte.Text = "---";
            // 
            // btnConteoEfectivo
            // 
            this.btnConteoEfectivo.BackColor = System.Drawing.Color.MintCream;
            this.btnConteoEfectivo.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConteoEfectivo.Location = new System.Drawing.Point(609, 184);
            this.btnConteoEfectivo.Name = "btnConteoEfectivo";
            this.btnConteoEfectivo.Size = new System.Drawing.Size(114, 63);
            this.btnConteoEfectivo.TabIndex = 13;
            this.btnConteoEfectivo.Text = "Conteo de efectivo";
            this.btnConteoEfectivo.UseVisualStyleBackColor = false;
            this.btnConteoEfectivo.Click += new System.EventHandler(this.btnConteoEfectivo_Click);
            // 
            // lblTurnoActivo
            // 
            this.lblTurnoActivo.AutoSize = true;
            this.lblTurnoActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoActivo.Location = new System.Drawing.Point(578, 64);
            this.lblTurnoActivo.Name = "lblTurnoActivo";
            this.lblTurnoActivo.Size = new System.Drawing.Size(36, 28);
            this.lblTurnoActivo.TabIndex = 14;
            this.lblTurnoActivo.Text = "---";
            // 
            // lblTotalHistorico
            // 
            this.lblTotalHistorico.AutoSize = true;
            this.lblTotalHistorico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHistorico.ForeColor = System.Drawing.Color.Black;
            this.lblTotalHistorico.Location = new System.Drawing.Point(371, 159);
            this.lblTotalHistorico.Name = "lblTotalHistorico";
            this.lblTotalHistorico.Size = new System.Drawing.Size(232, 25);
            this.lblTotalHistorico.TabIndex = 12;
            this.lblTotalHistorico.Text = "Total Histórico del Turno :";
            // 
            // lblValorTotalHistorico
            // 
            this.lblValorTotalHistorico.AutoSize = true;
            this.lblValorTotalHistorico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalHistorico.ForeColor = System.Drawing.Color.Black;
            this.lblValorTotalHistorico.Location = new System.Drawing.Point(604, 159);
            this.lblValorTotalHistorico.Name = "lblValorTotalHistorico";
            this.lblValorTotalHistorico.Size = new System.Drawing.Size(33, 25);
            this.lblValorTotalHistorico.TabIndex = 13;
            this.lblValorTotalHistorico.Text = "---";
            this.lblValorTotalHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCierreSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(904, 927);
            this.Controls.Add(this.lblTurnoActivo);
            this.Controls.Add(this.lblHoraCorte);
            this.Controls.Add(this.lblUsuarioActivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarCorte);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCierreSesion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Turno";
            this.Load += new System.EventHandler(this.FrmCierreSesion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEfectivoContado;
        private System.Windows.Forms.Label lblDiferenciaEfectivo;
        private System.Windows.Forms.TextBox txtEfectivoContado;
        private System.Windows.Forms.Label lblValorDiferenciaEfectivo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Button btnConfirmarCorte;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblVentasEfectivo;
        private System.Windows.Forms.Label lblTotalTurno;
        private System.Windows.Forms.Label lblVentasElectronico;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblHoraCorte;
        private System.Windows.Forms.Label lblElectronicoContado;
        private System.Windows.Forms.TextBox txtElectronicoContado;
        private System.Windows.Forms.Label lblDiferenciaElectronico;
        private System.Windows.Forms.Label lblValorDiferenciaTotal;
        private System.Windows.Forms.Label lblDiferenciaTotal;
        private System.Windows.Forms.Label lblValorDiferenciaElectronico;
        private System.Windows.Forms.Button btnConteoEfectivo;
        private System.Windows.Forms.Label lblTurnoActivo;
        private System.Windows.Forms.Label lblArqueosRealizados;
        private System.Windows.Forms.Label lblTotalRetirado;
        private System.Windows.Forms.Label lblValorArqueosRealizados;
        private System.Windows.Forms.Label lblValorTotalRetirado;
        private System.Windows.Forms.Label lblArqueoElectronico;
        private System.Windows.Forms.Label lblValorArqueoElectronico;
        private System.Windows.Forms.Label lblTotalHistorico;
        private System.Windows.Forms.Label lblValorTotalHistorico;
    }
}