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
            lblHoraCorte.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Reset totales
            totalEfectivo = 0;
            totalElectronico = 0;
            totalTurno = 0;

            lblVentasEfectivo.Text = FormatCurrency(0);
            lblVentasElectronico.Text = FormatCurrency(0);
            lblTotalTurno.Text = FormatCurrency(0);

            dgvVentasSocios.Columns.Clear();
            dgvVentasSocios.Columns.Add("socio", "Socio");
            dgvVentasSocios.Columns.Add("efectivo", "Efectivo");
            dgvVentasSocios.Columns.Add("electronico", "Electrónico");
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
            fp.nombre AS forma_pago,
            SUM(vp.importe) AS total
        FROM ventas v
        INNER JOIN ventas_pagos vp
            ON v.id_venta = vp.id_venta
        INNER JOIN formas_pago fp
            ON vp.id_forma_pago = fp.id_forma_pago
        WHERE v.id_turno = @id_turno
        GROUP BY fp.id_forma_pago, fp.nombre;";

                    using (var cmd = new MySqlCommand(queryTotales, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string forma = reader["forma_pago"].ToString().ToLower();
                                decimal total = Convert.ToDecimal(reader["total"]);

                                if (forma.Contains("efectivo"))
                                    totalEfectivo += total;
                                else
                                    totalElectronico += total;
                            }
                        }
                    }

                    totalTurno = totalEfectivo + totalElectronico;

                    lblVentasEfectivo.Text = FormatCurrency(totalEfectivo);
                    lblVentasElectronico.Text = FormatCurrency(totalElectronico);
                    lblTotalTurno.Text = FormatCurrency(totalTurno);

                    // ================================================
                    // 2) VENTAS POR SOCIO
                    // ================================================
                    string querySocios = @"
    SELECT
        s.nombre_socio,

        SUM(
            CASE
                WHEN fp.id_forma_pago = 1
                THEN vp.importe * (ds.subtotal / v.total)
                ELSE 0
            END
        ) AS efectivo,

        SUM(
            CASE
                WHEN fp.id_forma_pago <> 1
                THEN vp.importe * (ds.subtotal / v.total)
                ELSE 0
            END
        ) AS electronico,

        SUM(ds.subtotal) AS total

    FROM ventas v

    INNER JOIN (
        SELECT
            dv.id_venta,
            p.id_socio,
            SUM(dv.subtotal) AS subtotal
        FROM detalle_ventas dv
        INNER JOIN productos p
            ON dv.id_producto = p.id_producto
        GROUP BY
            dv.id_venta,
            p.id_socio
    ) ds
        ON v.id_venta = ds.id_venta

    INNER JOIN socios s
        ON ds.id_socio = s.id_socio

    INNER JOIN ventas_pagos vp
        ON v.id_venta = vp.id_venta

    INNER JOIN formas_pago fp
        ON vp.id_forma_pago = fp.id_forma_pago

    WHERE v.id_turno = @id_turno
      AND v.total > 0

    GROUP BY
        s.id_socio,
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
            decimal totalVentas = totalTurno;
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

                    string query = @"
UPDATE cajas_turnos
SET fecha_cierre = NOW(),
    monto_final = @monto_final,
    efectivo_contado = @efectivo,
    electronico_contado = @electronico,
    total_ventas = @total_ventas,
    diferencia = @diferencia,
    observaciones = @obs
WHERE id_turno = @id_turno;";

                    using (var cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@monto_final", montoFinal);
                        cmd.Parameters.AddWithValue("@efectivo", efectivoContado);
                        cmd.Parameters.AddWithValue("@electronico", electronicoContado);
                        cmd.Parameters.AddWithValue("@total_ventas", totalVentas);
                        cmd.Parameters.AddWithValue("@diferencia", diferencia);
                        cmd.Parameters.AddWithValue("@obs", observaciones);
                        cmd.Parameters.AddWithValue("@id_turno", Session.IdTurno);

                        cmd.ExecuteNonQuery();
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