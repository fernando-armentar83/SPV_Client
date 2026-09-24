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
using SPV_Client.Models;

namespace SPV_Client
{
    public partial class FrmCierreSesion : Form
    {
        private decimal totalEfectivo = 0m;
        private decimal totalElectronico = 0m;
        private decimal totalTurno = 0m;
        private readonly FrmConteoEfectivo frmConteo = new FrmConteoEfectivo();
        private decimal totalVales = 0m;
        private decimal montoInicialTurno = 0m;
        private decimal totalVentasArqueos = 0m;
        private decimal totalElectronicoArqueos = 0m;
        private decimal totalRetiradoArqueos = 0m;

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

            btnConfirmarCorte.Enabled = false;

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

        private DateTime ObtenerFechaInicioPendiente(MySqlConnection cn)
        {
            string sql = @"
SELECT COALESCE(
    (
        SELECT fecha_arqueo
        FROM arqueos_caja
        WHERE id_turno = @id_turno
        ORDER BY fecha_arqueo DESC
        LIMIT 1
    ),
    (
        SELECT fecha_apertura
        FROM cajas_turnos
        WHERE id_turno = @id_turno
        LIMIT 1
    )
) AS fecha_inicio;";

            using (var cmd = new MySqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                object resultado = cmd.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    throw new Exception("No fue posible determinar el período pendiente del turno.");
                }

                return Convert.ToDateTime(resultado);
            }
        }

        private decimal ObtenerMontoInicial(MySqlConnection cn)
        {
            string sql = "SELECT monto_inicial FROM cajas_turnos WHERE id_turno = @id_turno LIMIT 1;";

            using (var cmd = new MySqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                object resultado = cmd.ExecuteScalar();

                return (resultado == null || resultado == DBNull.Value)
                    ? 0m
                    : Convert.ToDecimal(resultado);
            }
        }

        private void ObtenerResumenArqueos(MySqlConnection cn, out int cantidadArqueos)
        {
            string sql = @"
SELECT
    COUNT(*) AS cantidad,
    COALESCE(SUM(efectivo_retirado), 0) AS total_retirado,
    COALESCE(SUM(electronico_comprobado), 0) AS total_electronico,
    COALESCE(SUM(total_ventas), 0) AS total_ventas
FROM arqueos_caja
WHERE id_turno = @id_turno;";

            cantidadArqueos = 0;
            totalRetiradoArqueos = 0m;
            totalElectronicoArqueos = 0m;
            totalVentasArqueos = 0m;

            using (var cmd = new MySqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cantidadArqueos = Convert.ToInt32(reader["cantidad"]);
                        totalRetiradoArqueos = Convert.ToDecimal(reader["total_retirado"]);
                        totalElectronicoArqueos = Convert.ToDecimal(reader["total_electronico"]);
                        totalVentasArqueos = Convert.ToDecimal(reader["total_ventas"]);
                    }
                }
            }
        }

        private CierreReimpresion ObtenerCierreParaTicket(int idTurno)
        {
            CierreReimpresion cierre = null;

            using (var cn = new MySqlConnection(connString))
            {
                cn.Open();

                string sql = @"
SELECT
    ct.id_turno,
    ua.nombre AS usuario_apertura,
    uc.nombre AS usuario_cierre,
    ct.fecha_apertura,
    ct.fecha_cierre,
    ct.monto_inicial,
    ct.efectivo_contado,
    ct.electronico_contado,
    ct.diferencia_efectivo,
    ct.diferencia_electronico,
    ct.total_ventas,
    ct.observaciones
FROM cajas_turnos ct
INNER JOIN usuarios ua ON ct.id_usuario = ua.id_usuario
LEFT JOIN usuarios uc ON ct.id_usuario_cierre = uc.id_usuario
WHERE ct.id_turno = @id_turno
LIMIT 1;";

                using (var cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@id_turno", idTurno);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cierre = new CierreReimpresion
                            {
                                IdTurno = Convert.ToInt32(reader["id_turno"]),
                                UsuarioApertura = reader["usuario_apertura"].ToString(),
                                UsuarioCierre = reader["usuario_cierre"] == DBNull.Value
                                    ? "" : reader["usuario_cierre"].ToString(),
                                FechaApertura = Convert.ToDateTime(reader["fecha_apertura"]),
                                FechaCierre = Convert.ToDateTime(reader["fecha_cierre"]),
                                MontoInicial = Convert.ToDecimal(reader["monto_inicial"]),
                                EfectivoContado = Convert.ToDecimal(reader["efectivo_contado"]),
                                ElectronicoContado = Convert.ToDecimal(reader["electronico_contado"]),
                                DiferenciaEfectivo = Convert.ToDecimal(reader["diferencia_efectivo"]),
                                DiferenciaElectronico = Convert.ToDecimal(reader["diferencia_electronico"]),
                                TotalVentasHistorico = Convert.ToDecimal(reader["total_ventas"]),
                                Observaciones = reader["observaciones"] == DBNull.Value
                                    ? null : reader["observaciones"].ToString()
                            };
                        }
                    }
                }

                if (cierre != null)
                {
                    string sqlArqueos = @"
SELECT
    COUNT(*) AS cantidad,
    COALESCE(SUM(efectivo_retirado), 0) AS total_retirado,
    COALESCE(SUM(electronico_comprobado), 0) AS total_electronico,
    COALESCE(SUM(total_ventas), 0) AS total_ventas
FROM arqueos_caja
WHERE id_turno = @id_turno;";

                    using (var cmd = new MySqlCommand(sqlArqueos, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_turno", idTurno);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cierre.CantidadArqueos = Convert.ToInt32(reader["cantidad"]);
                                cierre.TotalRetiradoArqueos = Convert.ToDecimal(reader["total_retirado"]);
                                cierre.TotalElectronicoArqueos = Convert.ToDecimal(reader["total_electronico"]);
                                cierre.TotalVentasArqueos = Convert.ToDecimal(reader["total_ventas"]);
                            }
                        }
                    }

                    cierre.EfectivoEsperado = cierre.EfectivoContado - cierre.DiferenciaEfectivo;
                    cierre.ElectronicoEsperado = cierre.ElectronicoContado - cierre.DiferenciaElectronico;
                }
            }

            return cierre;
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
                    // ================================================
                    // 1) TOTAL POR FORMA DE PAGO (SOLO PERÍODO PENDIENTE)
                    // ================================================
                    DateTime fechaInicioPendiente = ObtenerFechaInicioPendiente(cn);
                    montoInicialTurno = ObtenerMontoInicial(cn);

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
  AND v.fecha_venta > @fecha_inicio
GROUP BY
    fp.id_forma_pago,
    fp.nombre
ORDER BY
    fp.id_forma_pago;";

                    using (var cmd = new MySqlCommand(queryTotales, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);
                        cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicioPendiente);

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

                    totalEfectivo += montoInicialTurno;

                    totalTurno = totalEfectivo + totalElectronico + totalVales;

                    lblVentasEfectivo.Text = FormatCurrency(totalEfectivo);
                    lblVentasElectronico.Text = FormatCurrency(totalElectronico);
                    lblTotalTurno.Text = FormatCurrency(totalTurno);

                    ObtenerResumenArqueos(cn, out int cantidadArqueos);

                    lblValorArqueosRealizados.Text = cantidadArqueos.ToString();
                    lblValorTotalRetirado.Text = FormatCurrency(totalRetiradoArqueos);
                    lblValorArqueoElectronico.Text = FormatCurrency(totalElectronicoArqueos);

                    decimal totalHistoricoTurno =
                        totalVentasArqueos +
                        (totalEfectivo - montoInicialTurno) +
                        totalElectronico;

                    lblValorTotalHistorico.Text = FormatCurrency(totalHistoricoTurno);

                   
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

            decimal diferenciaEfectivo = efectivoContado - totalEfectivo;
            decimal diferenciaElectronico = electronicoContado - totalElectronico;
            decimal diferencia = diferenciaEfectivo + diferenciaElectronico;

            decimal totalVentas =
                totalVentasArqueos +
                (totalEfectivo - montoInicialTurno) +
                totalElectronico;
            string observaciones = txtObservaciones.Text.Trim();

            DialogResult confirmar = MessageBox.Show(
                $"¿Confirmar cierre del turno #{Session.IdTurno}?\n\n" +
                $"Total ventas: {FormatCurrency(totalVentas)}\n\n" +
                $"Efectivo contado: {FormatCurrency(efectivoContado)}\n\n" +
                $"Electrónico contado: {FormatCurrency(electronicoContado)}\n\n" +
                $"Total contado: {FormatCurrency(montoFinal)}\n\n" +
                $"Diferencia: {FormatCurrency(diferencia)}\n",
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
    diferencia_efectivo = @diferencia_efectivo,
    diferencia_electronico = @diferencia_electronico,
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
                        cmd.Parameters.AddWithValue("@diferencia_efectivo", diferenciaEfectivo);
                        cmd.Parameters.AddWithValue("@diferencia_electronico", diferenciaElectronico);
                        cmd.Parameters.AddWithValue("@obs", observaciones);
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);
                        cmd.Parameters.AddWithValue("@id_usuario_cierre", Session.IdUsuario);

                        //cmd.ExecuteNonQuery();

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

                CierreReimpresion cierreTicket = ObtenerCierreParaTicket(Session.IdTurno);

                using (FrmTicketCierre frmTicket = new FrmTicketCierre(cierreTicket))
                {
                    frmTicket.ModoReimpresion = false;
                    frmTicket.ShowDialog();
                }

                Session.Clear();

                FrmMenu menu = Application.OpenForms["FrmMenu"] as FrmMenu;
                if (menu != null)
                    EstadoMenu.Actualizar(menu);

                this.DialogResult = DialogResult.OK;
                this.Close();
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