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
    public partial class FrmArqueo : Form
    {

        private string folioArqueo = null;
        private DateTime fechaInicioArqueo;
        private DateTime fechaFinArqueo;
        private decimal totalEfectivo = 0m;
        private decimal totalElectronico = 0m;
        private bool efectivoContadoRealizado = false;

        public FrmArqueo()
        {
            InitializeComponent();
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnContarEfectivo_Click(object sender, EventArgs e)
        {
            using (FrmConteoEfectivo frmConteo = new FrmConteoEfectivo())
            {
                if (frmConteo.ShowDialog() == DialogResult.OK)
                {
                    efectivoContadoRealizado = true;
                    decimal efectivoContado = frmConteo.TotalContado;

                    lblEfectivoContado.Text =
                        efectivoContado.ToString("C2");

                    CalcularDiferenciaEfectivo();
                    ActualizarEstadoArqueo();
                }
            }
        }

        private void CalcularDiferenciaEfectivo()
        {
            decimal efectivoEsperado = 0m;
            decimal efectivoContado = 0m;

            decimal.TryParse(
                lblEfectivoEsperado.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out efectivoEsperado);

            decimal.TryParse(
                lblEfectivoContado.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out efectivoContado);

            decimal diferencia = efectivoContado - efectivoEsperado;

            lblDiferencia.Text = diferencia.ToString("C2");
        }

        private void ActualizarEstadoArqueo()
        {
            decimal efectivoEsperado = 0m;
            decimal efectivoContado = 0m;
            decimal diferenciaElectronica = 0m;

            decimal.TryParse(
                lblEfectivoEsperado.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out efectivoEsperado);

            decimal.TryParse(
                lblEfectivoContado.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out efectivoContado);

            decimal.TryParse(
                lblDiferenciaElectronico.Text,
                System.Globalization.NumberStyles.Currency |
                System.Globalization.NumberStyles.AllowLeadingSign,
                System.Globalization.CultureInfo.CurrentCulture,
                out diferenciaElectronica);

            bool efectivoRequerido = efectivoEsperado > 0m;
            bool efectivoContadoRealizado =
                efectivoRequerido && efectivoContado >= 0m;

            bool electronicoRequerido = totalElectronico > 0m;
            bool electronicoVerificado = chkElectronicoVerificado.Checked;

            bool diferenciaEfectivo =
                efectivoContadoRealizado &&
                efectivoContado != efectivoEsperado;

            bool diferenciaElectronico =
                electronicoRequerido &&
                electronicoVerificado &&
                diferenciaElectronica != 0m;

            if (!efectivoContadoRealizado && efectivoRequerido)
            {
                lblEstadoArqueo.Text = "PENDIENTE";
            }
            else if (diferenciaEfectivo && diferenciaElectronico)
            {
                lblEstadoArqueo.Text = "DIFERENCIA DE EFECTIVO Y ELECTRÓNICO";
            }
            else if (diferenciaEfectivo)
            {
                lblEstadoArqueo.Text = "DIFERENCIA DE EFECTIVO";
            }
            else if (electronicoRequerido && !electronicoVerificado)
            {
                lblEstadoArqueo.Text = "ELECTRÓNICO NO VERIFICADO";
            }
            else if (diferenciaElectronico)
            {
                lblEstadoArqueo.Text = "DIFERENCIA DE ELECTRÓNICO";
            }
            else
            {
                lblEstadoArqueo.Text = "CORRECTO";
            }
        }

        private void CalcularDiferenciaElectronico()
        {
            decimal electronicoEsperado = 0m;
            decimal electronicoComprobado = 0m;

            decimal.TryParse(
                lblElectronico.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out electronicoEsperado);

            decimal.TryParse(
                txtElectronicoComprobado.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out electronicoComprobado);

            decimal diferencia =
                electronicoComprobado - electronicoEsperado;

            lblDiferenciaElectronico.Text =
                diferencia.ToString("+$#,##0.00;-$#,##0.00;$0.00");
        }

        private void FrmArqueo_Load(object sender, EventArgs e)
        {
            if (Session.IdUsuario == 0 || Session.IdTurno == 0)
            {
                MessageBox.Show(
                    "No hay sesión o turno activo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
                return;
            }

            CargarInformacionTurno();

            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                ObtenerPeriodoArqueo(
                    conn,
                    null,
                    out fechaInicioArqueo,
                    out fechaFinArqueo);
                lblInicioArqueo.Text = fechaInicioArqueo.ToString("dd/MM/yyyy HH:mm:ss");
                lblFinArqueo.Text = fechaFinArqueo.ToString("dd/MM/yyyy HH:mm:ss");
            }

            CargarResumenTurno();
            btnRealizarArqueo.Enabled =
            lblEfectivoEsperado.Text != "$0.00" ||
            lblElectronico.Text != "$0.00";
            MostrarProximoFolioArqueo();
        }

        private void CargarInformacionTurno()
        {
            try
            {
                using (MySqlConnection conn = DB.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT
                    id_turno,
                    id_usuario,
                    tipo_turno,
                    fecha_apertura,
                    fecha_cierre
                FROM cajas_turnos
                WHERE id_turno = @id_turno;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "No fue posible encontrar el turno activo.",
                                    "Turno no encontrado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                this.Close();
                                return;
                            }
                                                        
                            lblIdTurno.Text = reader["id_turno"].ToString();

                            lblUsuario.Text = Session.NombreUsuario;

                            // Mostrar el rol del usuario
                            lblTipoTurno.Text = Session.NombreRol;

                            
                            // Mostrar el tipo de turno almacenado en la base de datos
                            if (reader["tipo_turno"] != DBNull.Value)
                            {
                                lblTipoTurnoCaja.Text = reader["tipo_turno"].ToString();
                            }
                            else
                            {
                                lblTipoTurnoCaja.Text = "---";
                            }   

                            if (reader["fecha_apertura"] != DBNull.Value)
                            {
                                DateTime fechaApertura =
                                    Convert.ToDateTime(reader["fecha_apertura"]);

                                lblFechaApertura.Text =
                                    fechaApertura.ToString("dd/MM/yyyy HH:mm:ss");
                            }
                            else
                            {
                                lblFechaApertura.Text = "---";
                            }

                            if (reader["fecha_cierre"] == DBNull.Value)
                            {
                                lblEstadoTurno.Text = "ABIERTO";
                            }
                            else
                            {
                                lblEstadoTurno.Text = "CERRADO";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar la información del turno.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarResumenTurno()
        {
           try
            {
                using (MySqlConnection conn = DB.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    fp.nombre AS forma_pago,
                    SUM(vp.importe) AS total
                FROM ventas v
                INNER JOIN ventas_pagos vp 
                    ON v.id_venta = vp.id_venta
                INNER JOIN formas_pago fp 
                    ON vp.id_forma_pago = fp.id_forma_pago
                WHERE v.id_turno = @id_turno
                  AND v.estado = 'ACTIVA'
                  AND v.fecha_venta > @fecha_inicio
                  AND v.fecha_venta <= @fecha_fin    
                GROUP BY fp.id_forma_pago, fp.nombre;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);
                        cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicioArqueo);
                        cmd.Parameters.AddWithValue("@fecha_fin", fechaFinArqueo);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string formaPago = reader["forma_pago"].ToString().ToLower();
                                decimal total = Convert.ToDecimal(reader["total"]);

                                if (formaPago == "efectivo")
                                {
                                    totalEfectivo += total;
                                }
                                else if (formaPago == "tarjeta" ||
                                         formaPago == "transferencia")
                                {
                                    totalElectronico += total;
                                }
                            }
                        }
                    }
                }

                decimal totalVentas = totalEfectivo + totalElectronico;

                lblEfectivoEsperado.Text = totalEfectivo.ToString("C2");
                lblElectronico.Text = totalElectronico.ToString("C2");
                lblTotalVentas.Text = totalVentas.ToString("C2");
                btnRealizarArqueo.Enabled =
                            totalEfectivo > 0m || totalElectronico > 0m;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar el resumen del turno.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string ObtenerSiguienteFolioArqueo(
    MySqlConnection conn,
    MySqlTransaction trans)
        {
            string sql = @"
SELECT ultimo_consecutivo + 1
FROM folios
WHERE tipo = 'ARQUEO'
FOR UPDATE;";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
            {
                object resultado = cmd.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    throw new Exception(
                        "No existe el consecutivo para los folios de tipo ARQUEO.");
                }

                int siguiente = Convert.ToInt32(resultado);

                return $"ARQ-{siguiente:D6}";
            }
        }

        private void ActualizarConsecutivoArqueo(
    MySqlConnection conn,
    MySqlTransaction trans)
        {
            string sql = @"
UPDATE folios
SET ultimo_consecutivo = ultimo_consecutivo + 1
WHERE tipo = 'ARQUEO';";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
            {
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas != 1)
                {
                    throw new Exception(
                        "No fue posible actualizar el consecutivo del folio de ARQUEO.");
                }
            }
        }

        private void MostrarProximoFolioArqueo()
        {
            try
            {
                using (MySqlConnection conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT ultimo_consecutivo + 1
FROM folios
WHERE tipo = 'ARQUEO';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            int siguiente = Convert.ToInt32(resultado);

                            lblFolioArqueo.Text =
                                $"ARQ-{siguiente:D6}";
                        }
                        else
                        {
                            lblFolioArqueo.Text = "ARQ-SIN-FOLIO";
                        }
                    }
                }
            }
            catch
            {
                lblFolioArqueo.Text = "ARQ-ERROR";
            }
        }

        private void ObtenerPeriodoArqueo(
    MySqlConnection conn,
    MySqlTransaction trans,
    out DateTime fechaInicio,
    out DateTime fechaFin)
        {
            fechaFin = DateTime.Now;

            string sql = @"
SELECT
    COALESCE(
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

            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                object resultado = cmd.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                {
                    throw new Exception(
                        "No fue posible determinar la fecha de inicio del período del arqueo.");
                }

                fechaInicio = Convert.ToDateTime(resultado);
            }

            if (fechaInicio >= fechaFin)
            {
                throw new Exception(
                    "La fecha de inicio del arqueo no puede ser igual o posterior a la fecha de fin.");
            }
        }

        private void chkElectronicoVerificado_CheckedChanged(object sender, EventArgs e)
        {
            chkElectronicoVerificado.Text =
                chkElectronicoVerificado.Checked ? "Verificado" : "Verificar";
            ActualizarEstadoArqueo();
        }

        private void btnRealizarArqueo_Click(object sender, EventArgs e)
        {
            decimal efectivoEsperado = 0m;
            decimal efectivoContado = 0m;

            

            decimal.TryParse(
                lblEfectivoEsperado.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out efectivoEsperado);

            decimal.TryParse(
                lblEfectivoContado.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out efectivoContado);

            
            

            // Validar que el electrónico haya sido verificado
            if (!chkElectronicoVerificado.Checked)
            {
                MessageBox.Show(
                    "Debes verificar el efectivo electrónico antes de realizar el arqueo.",
                    "Arqueo pendiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Actualizar diferencia y estado antes de continuar
            CalcularDiferenciaEfectivo();
            ActualizarEstadoArqueo();

            try
            {
                using (MySqlConnection conn = DB.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        DateTime fechaInicio;
                        DateTime fechaFin;

                        ObtenerPeriodoArqueo(
                            conn,
                            trans,
                            out fechaInicio,
                            out fechaFin);
                        try
                        {
                            // Obtener folio definitivo dentro de la transacción
                            string folio = ObtenerSiguienteFolioArqueo(conn, trans);

                            // Obtener valores del arqueo
                            decimal diferenciaEfectivo = 0m;

                            decimal.TryParse(
                                lblDiferencia.Text,
                                System.Globalization.NumberStyles.Currency,
                                System.Globalization.CultureInfo.CurrentCulture,
                                out diferenciaEfectivo);

                            decimal electronico = 0m;

                            decimal.TryParse(
                                lblElectronico.Text,
                                System.Globalization.NumberStyles.Currency,
                                System.Globalization.CultureInfo.CurrentCulture,
                                out electronico);

                            
                            decimal electronicoComprobado = 0m;

                            decimal.TryParse(
                                txtElectronicoComprobado.Text,
                                System.Globalization.NumberStyles.Currency,
                                System.Globalization.CultureInfo.CurrentCulture,
                                out electronicoComprobado);

                            decimal diferenciaElectronico = 0m;

                            decimal.TryParse(
                                lblDiferenciaElectronico.Text,
                                System.Globalization.NumberStyles.Currency |
                                System.Globalization.NumberStyles.AllowLeadingSign,
                                System.Globalization.CultureInfo.CurrentCulture,
                                out diferenciaElectronico);

                            decimal totalVentas = 0m;

                            decimal.TryParse(
                                lblTotalVentas.Text,
                                System.Globalization.NumberStyles.Currency,
                                System.Globalization.CultureInfo.CurrentCulture,
                                out totalVentas);

                            string estado = lblEstadoArqueo.Text;

                            string observaciones =
                                string.IsNullOrWhiteSpace(txtObservaciones.Text)
                                    ? null
                                    : txtObservaciones.Text.Trim();

                            // Guardar arqueo
                            string sql = @"

INSERT INTO arqueos_caja
(
    folio,
    id_turno,
    id_usuario,
    fecha_arqueo,
    fecha_inicio,
    fecha_fin,
    efectivo_esperado,
    efectivo_contado,
    diferencia_efectivo,
    electronico,
    electronico_comprobado,
    diferencia_electronico,
    electronico_verificado,
    total_ventas,
    estado,
    observaciones
)
VALUES
(
    @folio,
    @id_turno,
    @id_usuario,
    @fecha_arqueo,
    @fecha_inicio,
    @fecha_fin,
    @efectivo_esperado,
    @efectivo_contado,
    @diferencia_efectivo,
    @electronico,
    @electronico_comprobado,
    @diferencia_electronico,
    @electronico_verificado,
    @total_ventas,
    @estado,
    @observaciones
);";

                            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@folio", folio);
                                cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);
                                cmd.Parameters.AddWithValue("@id_usuario", Session.IdUsuario);
                                cmd.Parameters.AddWithValue("@fecha_arqueo", fechaFin);
                                cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                                cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);
                                cmd.Parameters.AddWithValue("@efectivo_esperado", efectivoEsperado);
                                cmd.Parameters.AddWithValue("@efectivo_contado", efectivoContado);
                                cmd.Parameters.AddWithValue("@diferencia_efectivo", diferenciaEfectivo);
                                cmd.Parameters.AddWithValue("@electronico", electronico);
                                cmd.Parameters.AddWithValue("@electronico_comprobado", electronicoComprobado);
                                cmd.Parameters.AddWithValue("@diferencia_electronico", diferenciaElectronico);
                                cmd.Parameters.AddWithValue(
                                    "@electronico_verificado",
                                    chkElectronicoVerificado.Checked ? 1 : 0);
                                cmd.Parameters.AddWithValue("@total_ventas", totalVentas);
                                cmd.Parameters.AddWithValue("@estado", estado);
                                cmd.Parameters.AddWithValue("@observaciones", (object)observaciones ?? DBNull.Value);

                                cmd.ExecuteNonQuery();
                            }

                            // Consumir el folio solamente si el arqueo fue insertado correctamente
                            ActualizarConsecutivoArqueo(conn, trans);

                            // Confirmar toda la operación
                            trans.Commit();

                            // Guardar el folio generado para utilizarlo posteriormente
                            folioArqueo = folio;

                            lblFolioArqueo.Text = folio;

                            MessageBox.Show(
                                "El arqueo se registró correctamente.\n\n" +
                                "Folio: " + folio + "\n" +
                                "Estado: " + estado,
                                "Arqueo registrado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible registrar el arqueo.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void txtElectronicoComprobado_TextChanged(object sender, EventArgs e)
        {
            CalcularDiferenciaElectronico();
            ActualizarEstadoArqueo();
        }

        private void txtElectronicoComprobado_Enter(object sender, EventArgs e)
        {
            if (txtElectronicoComprobado.Text.StartsWith("$"))
            {
                decimal importe;

                if (decimal.TryParse(
                    txtElectronicoComprobado.Text,
                    System.Globalization.NumberStyles.Currency,
                    System.Globalization.CultureInfo.CurrentCulture,
                    out importe))
                {
                    txtElectronicoComprobado.Text =
                        importe.ToString("0.00");

                    txtElectronicoComprobado.SelectAll();
                }
            }
            else if (txtElectronicoComprobado.Text == "0.00")
            {
                txtElectronicoComprobado.Clear();
            }
        }

        private void txtElectronicoComprobado_Leave(object sender, EventArgs e)
        {
            decimal importe;

            if (decimal.TryParse(
                txtElectronicoComprobado.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out importe))
            {
                txtElectronicoComprobado.Text =
                    importe.ToString("C2");
            }
            else
            {
                txtElectronicoComprobado.Text = "$0.00";
            }
        }

        private void txtElectronicoComprobado_Click(object sender, EventArgs e)
        {
            /*if (txtElectronicoComprobado.Text == "0.00")
            {
                txtElectronicoComprobado.Clear();
            }*/
        }
    }
}
