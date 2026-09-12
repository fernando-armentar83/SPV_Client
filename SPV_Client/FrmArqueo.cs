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
                    lblEfectivoContado.Text =
                        frmConteo.TotalContado.ToString("C2");
                }
            }
        }

        private void FrmArqueo_Load(object sender, EventArgs e)
        {
            CargarResumenTurno();
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

        private void chkElectronicoVerificado_CheckedChanged(object sender, EventArgs e)
        {
            chkElectronicoVerificado.Text =
                chkElectronicoVerificado.Checked ? "Verificado" : "Verificar";
        }
    }
}
