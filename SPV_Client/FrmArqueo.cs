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

            bool efectivoContadoRealizado = efectivoContado > 0m;
            bool electronicoVerificado = chkElectronicoVerificado.Checked;

            if (!efectivoContadoRealizado)
            {
                lblEstadoArqueo.Text = "PENDIENTE";
            }
            else if (efectivoContado != efectivoEsperado)
            {
                lblEstadoArqueo.Text = "DIFERENCIA DE EFECTIVO";
            }
            else if (!electronicoVerificado)
            {
                lblEstadoArqueo.Text = "ELECTRÓNICO NO VERIFICADO";
            }
            else
            {
                lblEstadoArqueo.Text = "CORRECTO";
            }
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
            CargarResumenTurno();
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

                            // Determinar el tipo de turno según el rol
                            if (Session.IdRol == 1)
                            {
                                lblTipoTurnoCaja.Text = "ADMINISTRADOR";
                            }
                            else if (Session.IdRol == 2 || Session.IdRol == 3)
                            {
                                lblTipoTurnoCaja.Text = "OPERATIVO";
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
            decimal totalEfectivo = 0m;
            decimal totalElectronico = 0m;

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
                GROUP BY fp.id_forma_pago, fp.nombre;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

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
WHERE tipo = 'ARQUEO';";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
            {
                int siguiente = Convert.ToInt32(cmd.ExecuteScalar());

                return $"ARQ-{siguiente:D6}";
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

        private void chkElectronicoVerificado_CheckedChanged(object sender, EventArgs e)
        {
            chkElectronicoVerificado.Text =
                chkElectronicoVerificado.Checked ? "Verificado" : "Verificar";
            ActualizarEstadoArqueo();
        }
    }
}
