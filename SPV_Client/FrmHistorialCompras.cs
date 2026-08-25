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
    public partial class FrmHistorialCompras : Form
    {
        public FrmHistorialCompras()
        {
            InitializeComponent();
        }

        private void CargarProveedoresFiltro()
        {
            try
            {
                cmbProveedorFiltro.Items.Clear();

                cmbProveedorFiltro.Items.Add("Todos");

                using (var conexion = DB.GetConnection())
                {
                    conexion.Open();

                    string query = @"
            SELECT nombre
            FROM proveedores
            ORDER BY nombre ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbProveedorFiltro.Items.Add(
                            reader["nombre"].ToString()
                        );
                    }
                }

                cmbProveedorFiltro.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar proveedores:\n" + ex.Message
                );
            }
        }



        private void CargarUsuariosFiltro()
        {
            cmbUsuarioFiltro.Items.Clear();

            cmbUsuarioFiltro.Items.Add("Todos");

            using (var conexion = DB.GetConnection())
            {
                conexion.Open();

                string query = @"
        SELECT nombre
        FROM usuarios
        ORDER BY nombre ASC";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbUsuarioFiltro.Items.Add(
                        reader["nombre"].ToString()
                    );
                }
            }

            cmbUsuarioFiltro.SelectedIndex = 0;
        }

        private void FrmHistorialCompras_Load(object sender, EventArgs e)
        {
            
            cmbEstadoFiltro.SelectedIndex = 0;
            
            CargarProveedoresFiltro();

            CargarUsuariosFiltro();

            dtpFechaInicio.Value = DateTime.Today.AddMonths(-1);

            dtpFechaFin.Value = DateTime.Today;

            
           

            CargarCompras();
        }

        private void CargarCompras()
        {
            try
            {
                dgvHistorialCompras.Rows.Clear();

                using (var conexion = DB.GetConnection())
                {
                    conexion.Open();

                    string query = @"
            SELECT
                c.id_compra,
                c.folio,
                c.fecha_compra,
                p.nombre AS proveedor,
                u.nombre AS usuario,
                c.total,
                c.estado
            FROM compras c
            LEFT JOIN proveedores p
                ON c.id_proveedor = p.id_proveedor
            LEFT JOIN usuarios u
                ON c.id_usuario = u.id_usuario
            WHERE 1=1";

                    // FILTRO FOLIO
                    if (!string.IsNullOrWhiteSpace(txtBuscarFolio.Text))
                    {
                        query += " AND c.folio LIKE @folio";
                    }

                    // FILTRO ESTADO
                    if (cmbEstadoFiltro.SelectedItem != null &&
                        cmbEstadoFiltro.SelectedItem.ToString() != "Todas")
                    {
                        query += " AND c.estado = @estado";
                    }

                    // FILTRO PROVEEDOR
                    if (cmbProveedorFiltro.SelectedItem != null &&
                        cmbProveedorFiltro.SelectedItem.ToString() != "Todos")
                    {
                        query += " AND p.nombre = @proveedor";
                    }

                    // FILTRO USUARIO
                    if (cmbUsuarioFiltro.SelectedItem != null &&
                        cmbUsuarioFiltro.SelectedItem.ToString() != "Todos")
                    {
                        query += " AND u.nombre = @usuario";
                    }

                    // FILTRO FECHAS
                    query += @"
 AND c.fecha_compra >= @fechaInicio
 AND c.fecha_compra < @fechaFin";

                    query += " ORDER BY c.id_compra DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    // PARAMETRO FOLIO
                    if (!string.IsNullOrWhiteSpace(txtBuscarFolio.Text))
                    {
                        cmd.Parameters.AddWithValue(
                            "@folio",
                            "%" + txtBuscarFolio.Text.Trim() + "%"
                        );
                    }

                    // PARAMETRO ESTADO
                    if (cmbEstadoFiltro.SelectedItem != null &&
                        cmbEstadoFiltro.SelectedItem.ToString() != "Todas")
                    {
                        cmd.Parameters.AddWithValue(
                            "@estado",
                            cmbEstadoFiltro.SelectedItem.ToString()
                        );
                    }

                    // PARAMETRO PROVEEDOR
                    if (cmbProveedorFiltro.SelectedItem != null &&
                        cmbProveedorFiltro.SelectedItem.ToString() != "Todos")
                    {
                        cmd.Parameters.AddWithValue(
                            "@proveedor",
                            cmbProveedorFiltro.SelectedItem.ToString()
                        );
                    }

                    // PARAMETRO USUARIO
                    if (cmbUsuarioFiltro.SelectedItem != null &&
                        cmbUsuarioFiltro.SelectedItem.ToString() != "Todos")
                    {
                        cmd.Parameters.AddWithValue(
                            "@usuario",
                            cmbUsuarioFiltro.SelectedItem.ToString()
                        );
                    }

                    // PARAMETROS FECHAS
                    cmd.Parameters.AddWithValue(
                        "@fechaInicio",
                        dtpFechaInicio.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@fechaFin",
                        dtpFechaFin.Value.Date.AddDays(1)
                    );

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int fila = dgvHistorialCompras.Rows.Add(
                        reader["id_compra"],
                        reader["folio"],
                        Convert.ToDateTime(reader["fecha_compra"]).ToString("dd/MM/yyyy HH:mm"),
                        reader["proveedor"].ToString(),
                        reader["usuario"].ToString(),
                        Convert.ToDecimal(reader["total"]).ToString("N2"),
                        reader["estado"].ToString()
                        );
                        if (reader["estado"].ToString() == "CANCELADA")
                        {
                            dgvHistorialCompras.Rows[fila].DefaultCellStyle.BackColor = Color.LightCyan;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar historial de compras:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


       
        private void CargarDetalleCompra(int idCompra)
        {
            try
            {
                dgvDetalleCompra.Rows.Clear();

                decimal totalCompra = 0;
                int totalProductos = 0;

                using (var conexion = DB.GetConnection())
                {
                    conexion.Open();

                    string query = @"
                    SELECT
                        cd.id_producto,
                        p.nombre,
                        cd.cantidad,
                        cd.precio_compra,
                        cd.subtotal
                    FROM compras_detalle cd
                    INNER JOIN productos p
                        ON cd.id_producto = p.id_producto
                    WHERE cd.id_compra = @idCompra";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@idCompra", idCompra);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        decimal subtotal = Convert.ToDecimal(reader["subtotal"]);

                        dgvDetalleCompra.Rows.Add(
                            reader["id_producto"],
                            reader["nombre"].ToString(),
                            Convert.ToDecimal(reader["cantidad"]).ToString("N2"),
                            Convert.ToDecimal(reader["precio_compra"]).ToString("N2"),
                            subtotal.ToString("N2")
                        );

                        totalCompra += subtotal;
                        totalProductos++;
                    }
                }

                lblTotalDetalle.Text = "Total: $" + totalCompra.ToString("N2");
                lblCantidadItems.Text = "Productos: " + totalProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar detalle de compra:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AbrirCompraGuardada(int idCompra)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    c.folio,
    c.fecha_compra,
    p.nombre AS proveedor,
    u.nombre AS usuario,
    ua.nombre AS autorizo,
    c.total
FROM compras c
INNER JOIN proveedores p
    ON p.id_proveedor = c.id_proveedor
INNER JOIN usuarios u
    ON u.id_usuario = c.id_usuario
LEFT JOIN usuarios ua
    ON ua.id_usuario = c.id_usuario_autoriza
WHERE c.id_compra = @idCompra;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return;

                        CompraReimpresion compra = new CompraReimpresion();

                        compra.Folio = dr["folio"].ToString();

                        DateTime fecha =
                                Convert.ToDateTime(dr["fecha_compra"]);

                        compra.Fecha = fecha;

                        compra.Proveedor = dr["proveedor"].ToString();

                        compra.Usuario = dr["usuario"].ToString();

                        compra.Autorizo =
                            dr["autorizo"] == DBNull.Value
                            ? "N/A"
                            : dr["autorizo"].ToString();

                        compra.Total =
                            Convert.ToDecimal(dr["total"]);

                        dr.Close();

                        string sqlDetalle = @"
SELECT
    p.nombre,
    cd.cantidad,
    cd.precio_compra,
    cd.subtotal
FROM compras_detalle cd
INNER JOIN productos p
    ON p.id_producto = cd.id_producto
WHERE cd.id_compra = @idCompra;";

                        using (var cmdDetalle = new MySqlCommand(sqlDetalle, conn))
                        {
                            cmdDetalle.Parameters.AddWithValue("@idCompra", idCompra);

                            using (var drDetalle = cmdDetalle.ExecuteReader())
                            {
                                while (drDetalle.Read())
                                {
                                    compra.Detalle.Add(new CompraDetalleReimpresion
                                    {
                                        Producto = drDetalle["nombre"].ToString(),

                                        Cantidad = Convert.ToDecimal(drDetalle["cantidad"]),

                                        PrecioCompra = Convert.ToDecimal(drDetalle["precio_compra"]),

                                        Subtotal = Convert.ToDecimal(drDetalle["subtotal"])
                                    });
                                }
                            }
                        }
                        FrmTicketCompra frm = new FrmTicketCompra(compra);
                        frm.EsReimpresion = true;
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void panelFiltros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDetalle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistorialCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                int idCompra = Convert.ToInt32(
                    dgvHistorialCompras.Rows[e.RowIndex]
                    .Cells["colIdCompra"].Value
                );

                CargarDetalleCompra(idCompra);
            }
        }

        private void cmbEstadoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscarCompras_Click(object sender, EventArgs e)
        {
            CargarCompras();
            
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscarFolio.Clear();

            cmbEstadoFiltro.SelectedIndex = 0;

            cmbProveedorFiltro.SelectedIndex = 0; 

            cmbUsuarioFiltro.SelectedIndex = 0;

            dtpFechaInicio.Value = DateTime.Today.AddMonths(-1);

            dtpFechaFin.Value = DateTime.Today;

            CargarCompras();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            if (dgvHistorialCompras.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una compra.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int idCompra = Convert.ToInt32(
                dgvHistorialCompras.CurrentRow.Cells["colIdCompra"].Value
            );

            string folio = dgvHistorialCompras.CurrentRow.Cells["colFolio"].Value.ToString();

            string estado = dgvHistorialCompras.CurrentRow.Cells["colEstado"].Value.ToString();

            if (estado == "CANCELADA")
            {
                try
                {
                    using (var conexion = DB.GetConnection())
                    {
                        conexion.Open();

                        string sql = @"
            SELECT
                c.folio,
                c.fecha_cancelacion,
                uc.nombre AS usuario_cancela,
                ua.nombre AS usuario_autoriza
            FROM compras c
            LEFT JOIN usuarios uc
                ON c.id_usuario_cancela = uc.id_usuario
            LEFT JOIN usuarios ua
                ON c.id_usuario_autoriza = ua.id_usuario
            WHERE c.id_compra = @idCompra";

                        MySqlCommand cmd = new MySqlCommand(sql, conexion);

                        cmd.Parameters.AddWithValue("@idCompra", idCompra);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string usuarioCancela =
                                reader["usuario_cancela"]?.ToString() ?? "N/D";

                            string usuarioAutoriza =
                                reader["usuario_autoriza"]?.ToString() ?? "N/D";

                            string fechaCancelacion =
                                reader["fecha_cancelacion"] == DBNull.Value
                                ? "N/D"
                                : Convert.ToDateTime(reader["fecha_cancelacion"])
                                    .ToString("dd/MM/yyyy HH:mm:ss");

                            MessageBox.Show(
                                $"La compra ya está cancelada.\n\n" +
                                $"Folio: {folio}\n\n" +
                                $"Fecha cancelación:\n{fechaCancelacion}\n\n" +
                                $"Canceló:\n{usuarioCancela}\n\n" +
                                $"Autorizó compra:\n{usuarioAutoriza}",
                                "Compra cancelada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al consultar información:\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                return;
            }

            DialogResult r = MessageBox.Show(
                $"¿Deseas cancelar la compra {folio}?\n\nEsta acción devolverá el inventario al estado anterior.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r != DialogResult.Yes)
                return;

            using (FrmLoginTemporal frm = new FrmLoginTemporal("Cancelar compra"))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
            }

            try
            {
                using (var conexion = DB.GetConnection())
                {
                    conexion.Open();

                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            string sqlDetalle = @"
                        SELECT
                            id_producto,
                            cantidad
                        FROM compras_detalle
                        WHERE id_compra = @idCompra";

                            MySqlCommand cmdDetalle =
                                new MySqlCommand(sqlDetalle, conexion, transaccion);

                            cmdDetalle.Parameters.AddWithValue(
                                "@idCompra",
                                idCompra
                            );

                            MySqlDataReader reader = cmdDetalle.ExecuteReader();

                            List<(int idProducto, decimal cantidad)> productos =
                                new List<(int, decimal)>();

                            while (reader.Read())
                            {
                                productos.Add(
                                    (
                                        Convert.ToInt32(reader["id_producto"]),
                                        Convert.ToDecimal(reader["cantidad"])
                                    )
                                );
                            }

                            reader.Close();

                            foreach (var item in productos)
                            {
                                string sqlMovimiento = @"
INSERT INTO movimientos_stock
(
    id_producto,
    id_usuario,
    tipo_movimiento,
    cantidad,
    descripcion,
    id_compra
)
VALUES
(
    @id_producto,
    @id_usuario,
    'SALIDA',
    @cantidad,
    @descripcion,
    @id_compra
);";

                                using (var cmdMovimiento =
                                    new MySqlCommand(sqlMovimiento, conexion, transaccion))
                                {
                                    cmdMovimiento.Parameters.AddWithValue(
                                        "@id_producto",
                                        item.idProducto);

                                    cmdMovimiento.Parameters.AddWithValue(
                                        "@id_usuario",
                                        Session.IdUsuarioAutoriza);

                                    cmdMovimiento.Parameters.AddWithValue(
                                        "@cantidad",
                                        item.cantidad);

                                    cmdMovimiento.Parameters.AddWithValue(
                                        "@descripcion",
                                        $"Cancelación compra {folio}");

                                    cmdMovimiento.Parameters.AddWithValue(
                                        "@id_compra",
                                        idCompra);

                                    cmdMovimiento.ExecuteNonQuery();
                                }
                            }

                            string sqlCancelar = @"
                        UPDATE compras
                        SET
                            estado = 'CANCELADA',
                            fecha_cancelacion = NOW(),
                            id_usuario_cancela = @idUsuario
                        WHERE id_compra = @idCompra";

                            MySqlCommand cmdCancelar =
                                new MySqlCommand(sqlCancelar, conexion, transaccion);

                            cmdCancelar.Parameters.AddWithValue(
                                "@idUsuario",
                                Session.IdUsuarioAutoriza
                            );

                            cmdCancelar.Parameters.AddWithValue(
                                "@idCompra",
                                idCompra
                            );

                            cmdCancelar.ExecuteNonQuery();

                            transaccion.Commit();

                            MessageBox.Show(
                                "Compra cancelada correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            CargarCompras();
                            dgvDetalleCompra.Rows.Clear();
                        }
                        catch
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cancelar compra:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvHistorialCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvHistorialCompras.CurrentRow == null)
                return;

            int idCompra = Convert.ToInt32(
                dgvHistorialCompras.CurrentRow.Cells["colIdCompra"].Value);

            AbrirCompraGuardada(idCompra);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvHistorialCompras.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una compra.",
                    "Exportar a Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (FrmSeleccionExportacion frm = new FrmSeleccionExportacion(false))
            {
                if (frm.ShowDialog(this) != DialogResult.OK)
                    return;

                if (frm.ExportacionSeleccionada ==
                    FrmSeleccionExportacion.TipoExportacion.HistorialCompras)
                {
                    ExportService.ExportarHistorialComprasExcel(dgvHistorialCompras);
                    return;
                }

                if (frm.ExportacionSeleccionada ==
                    FrmSeleccionExportacion.TipoExportacion.DetalleCompra)
                {
                    int idCompra = Convert.ToInt32(
                        dgvHistorialCompras.CurrentRow.Cells["colIdCompra"].Value);

                    ExportService.ExportarDetalleCompraExcel(idCompra);
                }
            }
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            if (dgvHistorialCompras.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una compra.",
                    "Exportar a PDF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (dgvHistorialCompras.CurrentRow.Cells["colIdCompra"].Value == null)
            {
                MessageBox.Show(
                    "No se pudo identificar la compra seleccionada.",
                    "Exportar a PDF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            int idCompra = Convert.ToInt32(
                dgvHistorialCompras.CurrentRow.Cells["colIdCompra"].Value);

            using (FrmSeleccionExportacion frm = new FrmSeleccionExportacion(false))
            {
                if (frm.ShowDialog(this) != DialogResult.OK)
                    return;

                if (frm.ExportacionSeleccionada ==
                    FrmSeleccionExportacion.TipoExportacion.DetalleCompra)
                {
                    ExportService.ExportarDetalleCompraPdf(idCompra);
                    return;
                }

                if (frm.ExportacionSeleccionada ==
                    FrmSeleccionExportacion.TipoExportacion.HistorialCompras)
                {
                    ExportService.ExportarHistorialComprasPdf(
                        dgvHistorialCompras);

                    return;
                }
            }
        }
    }
}
