using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SPV_Client
{
    public partial class FrmCierreSesion : Form
    {
        private decimal totalEfectivo = 0m;
        private decimal totalElectronico = 0m;
        private decimal totalTurno = 0m;
        private readonly FrmConteoEfectivo frmConteo = new FrmConteoEfectivo();
        private decimal totalVales = 0m;

        private readonly string connString = "server=localhost;database=spv_tlapaleria;uid=fer;pwd=129112;";
        
        public FrmCierreSesion()
        {
            InitializeComponent();
        }

        private void FrmCierreSesion_Load(object sender, EventArgs e)
        {
            // Validar sesión activa
            if (Session.IdUsuario == 0 || Session.IdTurno == 0)
            {
                MessageBox.Show("No hay sesión o turno activo.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            lblUsuarioActivo.Text = Session.NombreUsuario;
            lblTurnoActivo.Text = $"Turno #{Session.IdTurno}";
            lblHoraCorte.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Reset totales
            totalEfectivo = 0;
            totalElectronico = 0;
            totalVales = 0;
            totalTurno = 0;

            lblVentasEfectivo.Text = FormatCurrency(0);
            lblVentasElectronico.Text = FormatCurrency(0);
            lblTotalTurno.Text = FormatCurrency(0);

            dgvVentasSocios.Columns.Clear();
            dgvVentasSocios.Columns.Add("socio", "Socio");
            dgvVentasSocios.Columns.Add("efectivo", "Efectivo");
            dgvVentasSocios.Columns.Add("electronico", "Electrónico");
            dgvVentasSocios.Columns.Add("vales", "Vales");
            dgvVentasSocios.Columns.Add("total", "Total");

            dgvVentasSocios.Rows.Clear();

            btnConfirmarCorte.Enabled = false;
            btnCerrarSesion.Enabled = false;
            btnImprimirCorte.Enabled = false;

            // Cargar datos correctos del turno
            CargarResumenTurno();

            txtEfectivoContado.Text = "0.00";
            txtElectronicoContado.Text = totalElectronico.ToString("0.00");
            CalcularDiferencias();
        }

        private string FormatCurrency(decimal value)
        {
            return value.ToString("C2");
        }

        private void CalcularDiferencias()
        {
            decimal efectivoContado = 0;
            decimal electronicoContado = 0;

            decimal.TryParse(txtEfectivoContado.Text, out efectivoContado);
            decimal.TryParse(txtElectronicoContado.Text, out electronicoContado);

            decimal diferenciaEfectivo = efectivoContado - totalEfectivo;
            decimal diferenciaElectronico = electronicoContado - totalElectronico;
            decimal diferenciaTotal = diferenciaEfectivo + diferenciaElectronico;

            lblValorDiferenciaEfectivo.Text = FormatCurrency(diferenciaEfectivo);
            lblValorDiferenciaElectronico.Text = FormatCurrency(diferenciaElectronico);
            lblValorDiferenciaTotal.Text = FormatCurrency(diferenciaTotal);
        }

        private void txtEfectivoContado_TextChanged(object sender, EventArgs e)
        {
            CalcularDiferencias();
        }

        private void txtElectronicoContado_TextChanged(object sender, EventArgs e)
        {
            CalcularDiferencias();
        }

        // ============================================================
        // 🔥 MÉTODO PRINCIPAL: CARGAR TODAS LAS VENTAS DEL TURNO ACTIVO
        // ============================================================
        private void CargarResumenTurno()
        {
            try
            {
                using (var cn = new MySqlConnection(connString))
                {
                    cn.Open();

                    // ================================================
                    // 1) TOTAL POR FORMA DE PAGO (FILTRADO POR id_turno)
                    // ================================================
                    string queryTotales = @"
    SELECT
        fp.id_forma_pago,
        fp.nombre AS forma_pago,
        COALESCE(SUM(vp.importe), 0) AS total
    FROM ventas v
    INNER JOIN ventas_pagos vp
        ON vp.id_venta = v.id_venta
    INNER JOIN formas_pago fp
        ON fp.id_forma_pago = vp.id_forma_pago
    WHERE v.id_turno = @id_turno
      AND v.estado = 'ACTIVA'
    GROUP BY
        fp.id_forma_pago,
        fp.nombre
    ORDER BY
        fp.id_forma_pago;";

                    using (var cmd = new MySqlCommand(queryTotales, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string forma = reader["forma_pago"].ToString().ToLower();
                                decimal total = Convert.ToDecimal(reader["total"]);

                                if (forma == "efectivo")
                                {
                                    totalEfectivo += total;
                                }
                                else if (forma == "tarjeta" ||
                                         forma == "transferencia")
                                {
                                    totalElectronico += total;
                                }
                                else if (forma == "vale")
                                { 
                                    totalVales += total;
                                }
                                
                            }
                        }
                    }

                    totalTurno = totalEfectivo + totalElectronico + totalVales;

                    lblVentasEfectivo.Text = FormatCurrency(totalEfectivo);
                    lblVentasElectronico.Text = FormatCurrency(totalElectronico);
                    lblTotalTurno.Text = FormatCurrency(totalTurno);

                    // ================================================
                    // 2) VENTAS POR SOCIO
                    // ================================================
                    string querySocios = @"
    SELECT
        s.nombre_socio,

        COALESCE(SUM(
            CASE
                WHEN fp.id_forma_pago = 1
                THEN vp.importe
                ELSE 0
            END
        ), 0) AS efectivo,

        COALESCE(SUM(
            CASE
                WHEN fp.id_forma_pago IN (2, 3)
                THEN vp.importe
                ELSE 0
            END
        ), 0) AS electronico,

        COALESCE(SUM(
            CASE
                WHEN fp.id_forma_pago = 4
                THEN vp.importe
                ELSE 0
            END
        ), 0) AS vales,

        COALESCE(SUM(vp.importe), 0) AS total

    FROM ventas v

    INNER JOIN socios s
        ON s.id_socio = v.id_socio

    INNER JOIN ventas_pagos vp
        ON vp.id_venta = v.id_venta

    INNER JOIN formas_pago fp
        ON fp.id_forma_pago = vp.id_forma_pago

    WHERE v.id_turno = @id_turno
      AND v.estado = 'ACTIVA'

    GROUP BY
        s.id_socio,
        s.nombre_socio

    ORDER BY
        s.nombre_socio;";

                    using (var cmd = new MySqlCommand(querySocios, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                        using (var reader = cmd.ExecuteReader())
                        {
                            dgvVentasSocios.Rows.Clear();

                            while (reader.Read())
                            {
                                dgvVentasSocios.Rows.Add(
                                    reader["nombre_socio"].ToString(),
                                    FormatCurrency(Convert.ToDecimal(reader["efectivo"])),
                                    FormatCurrency(Convert.ToDecimal(reader["electronico"])),
                                    FormatCurrency(Convert.ToDecimal(reader["vales"])),
                                    FormatCurrency(Convert.ToDecimal(reader["total"]))
                                );
                            }
                        }
                    }
                }
                btnConfirmarCorte.Enabled = true;
                //btnConfirmarCorte.Enabled = totalTurno > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el turno:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // 🔥 CONFIRMAR CORTE
        // ============================================================
        private void btnConfirmarCorte_Click(object sender, EventArgs e)
        {
            if (Session.IdTurno == 0)
            {
                MessageBox.Show("No hay turno activo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtEfectivoContado.Text, out decimal efectivoContado))
            {
                MessageBox.Show(
                    "Ingresa un valor válido en Efectivo Contado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtElectronicoContado.Text, out decimal electronicoContado))
            {
                MessageBox.Show(
                    "Ingresa un valor válido en Electrónico Contado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validaciones
            if (totalEfectivo > 0 && efectivoContado <= 0)
            {
                MessageBox.Show(
                    "Debes capturar el efectivo contado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (totalElectronico > 0 && electronicoContado <= 0)
            {
                MessageBox.Show(
                    "Debes capturar el monto electrónico contado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            decimal montoFinal = efectivoContado + electronicoContado;
            decimal totalVentas = totalEfectivo + totalElectronico;
            decimal diferencia = montoFinal - totalVentas;
            string observaciones = txtObservaciones.Text.Trim();

            DialogResult confirmar = MessageBox.Show(
                $"¿Confirmar cierre del turno #{Session.IdTurno}?\n\n" +
                $"Total ventas: {FormatCurrency(totalVentas)}\n" +
                $"Efectivo contado: {FormatCurrency(efectivoContado)}\n" +
                $"Electrónico contado: {FormatCurrency(electronicoContado)}\n" +
                $"Total contado: {FormatCurrency(montoFinal)}\n" +
                $"Diferencia: {FormatCurrency(diferencia)}",
                "Confirmar cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            try
            {
                using (var cn = new MySqlConnection(connString))
                {
                    cn.Open();
                    string validarTurno = @"
SELECT fecha_cierre
FROM cajas_turnos
WHERE id_turno = @id_turno;";

                    using (var cmdValidar = new MySqlCommand(validarTurno, cn))
                    {
                        cmdValidar.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                        object resultado = cmdValidar.ExecuteScalar();

                        if (resultado == null)
                        {
                            MessageBox.Show(
                                "El turno ya no existe en la base de datos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }

                        if (resultado != DBNull.Value)
                        {
                            MessageBox.Show(
                                "Este turno ya fue cerrado anteriormente.",
                                "Turno cerrado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    string query = @"
UPDATE cajas_turnos
SET fecha_cierre = NOW(),
    id_usuario_cierre = @id_usuario_cierre,
                    
    monto_final = @monto_final,
    efectivo_contado = @efectivo,
    electronico_contado = @electronico,
    total_ventas = @total_ventas,
    diferencia = @diferencia,
    observaciones = @obs
WHERE id_turno = @id_turno
  AND fecha_cierre IS NULL;";

                    using (var cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@monto_final", montoFinal);
                        cmd.Parameters.AddWithValue("@efectivo", efectivoContado);
                        cmd.Parameters.AddWithValue("@electronico", electronicoContado);
                        cmd.Parameters.AddWithValue("@total_ventas", totalVentas);
                        cmd.Parameters.AddWithValue("@diferencia", diferencia);
                        cmd.Parameters.AddWithValue("@obs", observaciones);
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);
                        cmd.Parameters.AddWithValue("@id_usuario_cierre", Session.IdUsuario);

                        cmd.ExecuteNonQuery();

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas != 1)
                        {
                            MessageBox.Show(
                                "No fue posible cerrar el turno. Es posible que ya haya sido cerrado.",
                                "Cierre no realizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                MessageBox.Show(
                    "El turno se cerró correctamente.",
                    "Cierre guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnConfirmarCorte.Enabled = false;
                btnImprimirCorte.Enabled = true;
                btnCerrarSesion.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el cierre:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Deseas cerrar la sesión actual?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes)
                return;

            // Limpiar sesión
            Session.IdUsuario = 0;
            Session.NombreUsuario = "";
            Session.IdRol = 0;
            Session.NombreRol = "";
            Session.IdTurno = 0;

            // Actualizar menú
            FrmMenu menu = Application.OpenForms["FrmMenu"] as FrmMenu;

            if (menu != null)
                EstadoMenu.Actualizar(menu);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Deseas cancelar el cierre de sesión?",
        "Cancelar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConteoEfectivo_Click(object sender, EventArgs e)
        {
            if (frmConteo.ShowDialog() == DialogResult.OK)
            {
                txtEfectivoContado.Text = frmConteo.TotalContado.ToString("0.00");

                CalcularDiferencias();
            }
        }
    }
}