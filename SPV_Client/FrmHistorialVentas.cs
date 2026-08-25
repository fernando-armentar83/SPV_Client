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
using SPV_Client.Services;

namespace SPV_Client
{
    public partial class FrmHistorialVentas : Form
    {
        public FrmHistorialVentas()
        {
            InitializeComponent();
            this.Load += FrmHistorialVentas_Load;
        }

        private void FrmHistorialVentas_Load(object sender, EventArgs e)
        {
            cmbEstadoV.SelectedIndex = 0;

            ConfigurarFiltros();

            CargarVentas();
        }

        private void ConfigurarFiltros()
        {
            dtpFechaInicioV.Value = DateTime.Today.AddMonths(-1);
            dtpFechaFinV.Value = DateTime.Today;

            cmbEstadoV.SelectedIndex = 0;

            cmbFiltroUsuarioV.Items.Clear();
            cmbFiltroUsuarioV.Items.Add("Todos");

            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT id_usuario, nombre
FROM usuarios
WHERE activo = 1
ORDER BY nombre;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbFiltroUsuarioV.Items.Add(new ComboBoxItem(
                            dr.GetInt32("id_usuario"),
                            dr.GetString("nombre")));
                    }
                }
            }

            cmbFiltroUsuarioV.SelectedIndex = 0;
        }

        private void CargarVentas()
        {
            try
            {
                dgvHistorialVentas.Rows.Clear();

                using (var conexion = DB.GetConnection())
                {
                    conexion.Open();

                    string query = @"
SELECT
    v.id_venta,
    v.folio,
    v.fecha_venta,
    u.nombre AS usuario,
    COALESCE(s.nombre_socio, 'MOSTRADOR') AS socio,
    COUNT(vd.id_detalle) AS items,
    v.total,
    v.estado
FROM ventas v
LEFT JOIN usuarios u
    ON v.id_usuario = u.id_usuario
LEFT JOIN socios s
    ON v.id_socio = s.id_socio
LEFT JOIN detalle_ventas vd
    ON v.id_venta = vd.id_venta
WHERE 1=1";

                    // FILTRO FOLIO
                    if (!string.IsNullOrWhiteSpace(txtBuscarFolioV.Text))
                    {
                        query += " AND v.folio LIKE @folio";
                    }

                    // FILTRO ESTADO
                    if (cmbEstadoV.SelectedItem != null &&
                        cmbEstadoV.SelectedItem.ToString() != "Todas")
                    {
                        query += " AND v.estado = @estado";
                    }

                    // FILTRO USUARIO
                    if (cmbFiltroUsuarioV.SelectedItem != null &&
                        cmbFiltroUsuarioV.SelectedItem.ToString() != "Todos")
                    {
                        query += " AND u.nombre = @usuario";
                    }

                    // FILTRO FECHAS
                    query += @"
AND v.fecha_venta >= @fechaInicio
AND v.fecha_venta < @fechaFin

GROUP BY
    v.id_venta,
    v.folio,
    v.fecha_venta,
    u.nombre,
    s.nombre_socio,
    v.total,
    v.estado

ORDER BY v.id_venta DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    // PARAMETRO FOLIO
                    if (!string.IsNullOrWhiteSpace(txtBuscarFolioV.Text))
                    {
                        cmd.Parameters.AddWithValue(
                            "@folio",
                            "%" + txtBuscarFolioV.Text.Trim() + "%");
                    }

                    // PARAMETRO ESTADO
                    if (cmbEstadoV.SelectedItem != null &&
                        cmbEstadoV.SelectedItem.ToString() != "Todas")
                    {
                        cmd.Parameters.AddWithValue(
                            "@estado",
                            cmbEstadoV.SelectedItem.ToString());
                    }

                    // PARAMETRO USUARIO
                    if (cmbFiltroUsuarioV.SelectedItem != null &&
                        cmbFiltroUsuarioV.SelectedItem.ToString() != "Todos")
                    {
                        cmd.Parameters.AddWithValue(
                            "@usuario",
                            cmbFiltroUsuarioV.SelectedItem.ToString());
                    }

                    // PARAMETROS FECHAS
                    cmd.Parameters.AddWithValue(
                        "@fechaInicio",
                        dtpFechaInicioV.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@fechaFin",
                        dtpFechaFinV.Value.Date.AddDays(1));

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int fila = dgvHistorialVentas.Rows.Add(
                            reader["id_venta"],
                            reader["folio"],
                            Convert.ToDateTime(reader["fecha_venta"]).ToString("dd/MM/yyyy HH:mm"),
                            reader["usuario"].ToString(),
                            reader["socio"].ToString(),
                            reader["items"].ToString(),
                            Convert.ToDecimal(reader["total"]).ToString("N2"),
                            reader["estado"].ToString());

                        if (reader["estado"].ToString() == "CANCELADA")
                        {
                            dgvHistorialVentas.Rows[fila].DefaultCellStyle.BackColor = Color.LightCyan;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar historial de ventas:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarDetalleVenta(int idVenta)
        {
            try
            {
                dgvDetalleVenta.Rows.Clear();

                using (var conexion = DB.GetConnection())
                {
                    conexion.Open();

                    string query = @"
SELECT
    dv.id_producto,
    p.nombre,
    dv.cantidad,
    dv.precio_unitario,
    dv.descuento,
    dv.subtotal
FROM detalle_ventas dv
INNER JOIN productos p
    ON dv.id_producto = p.id_producto
WHERE dv.id_venta = @idVenta
ORDER BY dv.id_detalle";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    decimal total = 0;
                    decimal cantidad = 0;

                    while (reader.Read())
                    {
                        dgvDetalleVenta.Rows.Add(
                            reader["id_producto"],
                            reader["nombre"],
                            Convert.ToDecimal(reader["cantidad"]).ToString("N2"),
                            Convert.ToDecimal(reader["precio_unitario"]).ToString("N2"),
                            Convert.ToDecimal(reader["descuento"]).ToString("N2"),
                            Convert.ToDecimal(reader["subtotal"]).ToString("N2"));

                        cantidad += Convert.ToDecimal(reader["cantidad"]);
                        total += Convert.ToDecimal(reader["subtotal"]);
                    }

                    lblCantidadItemsV.Text = $"Productos : {cantidad:N2}";
                    lblTotalDetalleV.Text = $"Total : ${total:N2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar detalle de la venta:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarUsuariosFiltro()
        {
            try
            {
                cmbFiltroUsuarioV.Items.Clear();

                cmbFiltroUsuarioV.Items.Add("Todos");

                using (MySqlConnection conexion = DB.GetConnection())
                {
                    conexion.Open();

                    string query = @"
SELECT nombre
FROM usuarios
ORDER BY nombre;";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbFiltroUsuarioV.Items.Add(reader["nombre"].ToString());
                    }

                    reader.Close();
                }

                cmbFiltroUsuarioV.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar usuarios:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvHistorialVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistorialVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idVenta = Convert.ToInt32(
                dgvHistorialVentas.Rows[e.RowIndex].Cells["colIdVenta"].Value);

            CargarDetalleVenta(idVenta);
        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnLimpiarFiltroV_Click(object sender, EventArgs e)
        {
            // Limpiar folio
            txtBuscarFolioV.Clear();

            // Restaurar combos
            cmbFiltroUsuarioV.SelectedIndex = 0; // Todos
            cmbEstadoV.SelectedIndex = 0;        // Todas

            // Restaurar fechas (primer día del mes actual y hoy)
            dtpFechaInicioV.Value = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                1);

            dtpFechaFinV.Value = DateTime.Today;

            // Limpiar detalle
            dgvDetalleVenta.Rows.Clear();

            // Recargar historial
            CargarVentas();
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (dgvHistorialVentas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una venta.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idVenta = Convert.ToInt32(
                dgvHistorialVentas.CurrentRow.Cells["colIdVenta"].Value);

            string estado = dgvHistorialVentas.CurrentRow.Cells["colEstado"].Value.ToString();

            if (estado == "CANCELADA")
            {
                MessageBox.Show(
                    "La venta ya se encuentra cancelada.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (FrmLoginTemporal frm = new FrmLoginTemporal("Cancelar Venta"))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
            }

            DialogResult r = MessageBox.Show(
                "¿Desea cancelar la venta seleccionada?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes)
                return;

            VentaService servicio = new VentaService();

            if (servicio.CancelarVenta(idVenta, Session.IdUsuarioAutoriza))
            {
                MessageBox.Show(
                    "Venta cancelada correctamente.",
                    "Correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarVentas();
            }
            else
            {
                MessageBox.Show(
                    "No fue posible cancelar la venta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnReimprimirVenta_Click(object sender, EventArgs e)
        {
            if (dgvHistorialVentas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una venta.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using (FrmLoginTemporal frm = new FrmLoginTemporal("Reimpresión de ticket"))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
            }

            int idVenta = Convert.ToInt32(
    dgvHistorialVentas.CurrentRow.Cells["colIdVenta"].Value);

            VentaService servicio = new VentaService();

            VentaReimpresion venta = servicio.ObtenerVentaParaReimpresion(idVenta);

            if (venta == null)
            {
                MessageBox.Show(
                    "No fue posible recuperar la venta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            FrmTicketVenta frmTicket = new FrmTicketVenta(venta);

            // ← NUEVA LÍNEA
            frmTicket.ModoReimpresion = true;

            frmTicket.ShowDialog();

        }

        private void btnCerrarHistorialVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvHistorialVentas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una venta.",
                    "Exportar a Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (dgvHistorialVentas.CurrentRow.Cells["colIdVenta"].Value == null)
            {
                MessageBox.Show(
                    "No se pudo identificar la venta seleccionada.",
                    "Exportar a Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            int idVenta = Convert.ToInt32(
                dgvHistorialVentas.CurrentRow.Cells["colIdVenta"].Value);

            using (FrmSeleccionExportacion frm =
                new FrmSeleccionExportacion(true))
            {
                if (frm.ShowDialog(this) != DialogResult.OK)
                    return;

                if (frm.ExportacionSeleccionada ==
                    FrmSeleccionExportacion.TipoExportacion.HistorialVentas)
                {
                    ExportService.ExportarHistorialVentasExcel(
                        dgvHistorialVentas);

                    return;
                }

                           
                
                    if (frm.ExportacionSeleccionada ==
                    FrmSeleccionExportacion.TipoExportacion.DetalleVenta)
                    {
                        ExportService.ExportarDetalleVentaExcel(idVenta);

                        return;
                    }
                
            }
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            if (dgvHistorialVentas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una venta.",
                    "Exportar a PDF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (dgvHistorialVentas.CurrentRow.Cells["colIdVenta"].Value == null)
            {
                MessageBox.Show(
                    "No se pudo identificar la venta seleccionada.",
                    "Exportar a PDF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            int idVenta = Convert.ToInt32(
                dgvHistorialVentas.CurrentRow.Cells["colIdVenta"].Value);

            using (FrmSeleccionExportacion frm =
                new FrmSeleccionExportacion(true))
            {
                if (frm.ShowDialog(this) != DialogResult.OK)
                    return;

                if (frm.ExportacionSeleccionada ==
                    FrmSeleccionExportacion.TipoExportacion.HistorialVentas)
                {
                    ExportService.ExportarHistorialVentasPdf(
                        dgvHistorialVentas);

                    return;
                }

                if (frm.ExportacionSeleccionada ==
                    FrmSeleccionExportacion.TipoExportacion.DetalleVenta)
                {
                    ExportService.ExportarDetalleVentaPdf(idVenta);

                    return;
                }
            }
        }
    }
}
