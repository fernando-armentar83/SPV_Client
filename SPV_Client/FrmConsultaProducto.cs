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
    public partial class FrmConsultaProducto : Form
    {
        private int _idProducto;

        public FrmConsultaProducto(int idProducto)
        {
            InitializeComponent();

            _idProducto = idProducto;
        }

        private void FrmConsultaProducto_Load(object sender, EventArgs e)
        {
            CargarCabeceraProducto();

            CargarEstadisticasProducto();

            CargarResumenVentas();

            CargarHistorialCompras();
        }

        private void CargarCabeceraProducto()
        {
            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    p.nombre,
    m.nombre_marca,
    p.modelo,
    pr.nombre AS proveedor,
    p.stock_actual,
    p.precio_compra
FROM productos p
LEFT JOIN marcas m
    ON m.id_marca = p.id_marca
LEFT JOIN proveedores pr
    ON pr.id_proveedor = p.id_proveedor
WHERE p.id_producto = @idProducto;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idProducto", _idProducto);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return;

                        lblProducto.Text = dr["nombre"].ToString();

                        lblMarca.Text =
                            dr["nombre_marca"] == DBNull.Value
                            ? ""
                            : dr["nombre_marca"].ToString();

                        lblModelo.Text =
                            dr["modelo"] == DBNull.Value
                            ? ""
                            : dr["modelo"].ToString();

                        lblProveedor.Text =
                            dr["proveedor"] == DBNull.Value
                            ? ""
                            : dr["proveedor"].ToString();

                        lblStock.Text =
                            Convert.ToDecimal(dr["stock_actual"])
                            .ToString("0.###");

                        lblUltimoCosto.Text =
                            Convert.ToDecimal(dr["precio_compra"])
                            .ToString("C2");
                    }
                }
            }
        }

        private void CargarResumenVentas()
        {
            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    IFNULL(SUM(dv.cantidad),0) AS cantidad_vendida,
    MAX(v.fecha_venta) AS ultima_venta
FROM detalle_ventas dv
INNER JOIN ventas v
    ON v.id_venta = dv.id_venta
WHERE dv.id_producto = @idProducto
AND v.estado = 'ACTIVA';";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idProducto", _idProducto);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return;

                        lblCantidadVendida.Text =
                            Convert.ToDecimal(dr["cantidad_vendida"])
                            .ToString("0.###");

                        lblUltimaVenta.Text =
                            dr["ultima_venta"] == DBNull.Value
                            ? "--/--/----"
                            : Convert.ToDateTime(dr["ultima_venta"])
                                .ToString("dd/MM/yyyy");
                    }
                }
            }
        }

        private void CargarEstadisticasProducto()
        {
            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    COUNT(*) AS compras,
    IFNULL(SUM(cantidad),0) AS cantidad,
    IFNULL(AVG(precio_compra),0) AS promedio,
    IFNULL(MIN(precio_compra),0) AS minimo,
    IFNULL(MAX(precio_compra),0) AS maximo,
    MAX(c.fecha_compra) AS ultima
FROM compras_detalle cd
INNER JOIN compras c
    ON c.id_compra = cd.id_compra
WHERE cd.id_producto=@idProducto;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idProducto", _idProducto);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return;

                        lblCompras.Text = dr["compras"].ToString();

                        lblCantidadComprada.Text =
                            Convert.ToDecimal(dr["cantidad"])
                            .ToString("0.###");

                        lblCostoPromedio.Text =
                            Convert.ToDecimal(dr["promedio"])
                            .ToString("C2");

                        if (dr["ultima"] == DBNull.Value)
                            lblUltimaCompra.Text = "-";
                        else
                            lblUltimaCompra.Text =
                                Convert.ToDateTime(dr["ultima"])
                                .ToString("dd/MM/yyyy");
                    }
                }
            }
        }

        private void CargarHistorialCompras()
        {
            dgvHistorialProducto.Rows.Clear();

            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    c.id_compra,
    c.fecha_compra,
    c.folio,
    pr.nombre AS proveedor,
    cd.cantidad,
    cd.precio_compra,
    cd.subtotal,
    u.nombre AS usuario
FROM compras_detalle cd
INNER JOIN compras c
    ON c.id_compra = cd.id_compra
INNER JOIN proveedores pr
    ON pr.id_proveedor = c.id_proveedor
INNER JOIN usuarios u
    ON u.id_usuario = c.id_usuario
WHERE cd.id_producto = @idProducto
ORDER BY c.fecha_compra DESC, c.id_compra DESC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idProducto", _idProducto);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvHistorialProducto.Rows.Add(
                                dr["id_compra"],
                                Convert.ToDateTime(dr["fecha_compra"]).ToString("dd/MM/yyyy"),
                                dr["folio"],
                                dr["proveedor"],
                                Convert.ToDecimal(dr["cantidad"]),
                                Convert.ToDecimal(dr["precio_compra"]).ToString("C2"),
                                Convert.ToDecimal(dr["subtotal"]).ToString("C2"),
                                dr["usuario"]
                            );
                        }
                    }
                }
            }
        }

        private void CargarHistorialVentas()
        {
            dgvHistorialVentas.Rows.Clear();

            if (_idProducto <= 0)
                return;

            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    v.id_venta,
    v.fecha_venta,
    v.folio,
    COALESCE(s.nombre_socio, 'PUBLICO GENERAL') AS cliente,
    dv.cantidad,
    dv.precio_unitario,
    dv.descuento,
    dv.subtotal,
    u.nombre AS usuario
FROM detalle_ventas dv
INNER JOIN ventas v
    ON v.id_venta = dv.id_venta
INNER JOIN usuarios u
    ON u.id_usuario = v.id_usuario
LEFT JOIN socios s
    ON s.id_socio = v.id_socio
WHERE dv.id_producto = @idProducto
ORDER BY v.fecha_venta DESC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@idProducto",
                        _idProducto);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvHistorialVentas.Rows.Add(
                                dr["id_venta"],
                                Convert.ToDateTime(dr["fecha_venta"]).ToString("dd/MM/yyyy"),
                                dr["folio"],
                                dr["cliente"],
                                Convert.ToDecimal(dr["cantidad"]),
                                Convert.ToDecimal(dr["precio_unitario"]).ToString("C2"),
                                Convert.ToDecimal(dr["descuento"]),
                                Convert.ToDecimal(dr["subtotal"]).ToString("C2"),
                                dr["usuario"]
                            );
                        }
                    }
                }
            }
        }

        private void AbrirVentaGuardada(int idVenta)
        {
            VentaService servicio = new VentaService();

            VentaReimpresion venta =
                servicio.ObtenerVentaParaReimpresion(idVenta);

            if (venta == null)
            {
                MessageBox.Show(
                    "No fue posible recuperar la venta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            FrmTicketVenta frm = new FrmTicketVenta(venta);

            frm.ModoReimpresion = true;

            frm.ShowDialog();
        }

        private void CargarHistorialInventario()
        {
            dgvHistorialInventario.Rows.Clear();

            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    ms.fecha_movimiento,
    ms.tipo_movimiento,
    ms.cantidad,
    CASE
    WHEN ms.id_compra IS NOT NULL THEN CONCAT('Compra ', c.folio)
    WHEN ms.id_venta IS NOT NULL THEN CONCAT('Venta ', v.folio)
    ELSE 'Movimiento Manual'
END AS documento,
    u.nombre AS usuario,
    ms.descripcion
FROM movimientos_stock ms
INNER JOIN usuarios u
    ON u.id_usuario = ms.id_usuario
LEFT JOIN compras c
    ON c.id_compra = ms.id_compra
LEFT JOIN ventas v
    ON v.id_venta = ms.id_venta
WHERE ms.id_producto = @idProducto
ORDER BY ms.fecha_movimiento DESC;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@idProducto",
                        _idProducto);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvHistorialInventario.Rows.Add(
                                Convert.ToDateTime(dr["fecha_movimiento"])
                                    .ToString("dd/MM/yyyy HH:mm"),

                                dr["tipo_movimiento"],

                                Convert.ToDecimal(dr["cantidad"])
                                    .ToString("0.###"),

                                dr["documento"],

                                dr["usuario"],

                                dr["descripcion"]
                            );
                        }
                    }
                }
            }
        }

        private void AbrirTicketCompra()
        {
            if (dgvHistorialProducto.CurrentRow == null)
                return;

            int idCompra =
                Convert.ToInt32(
                    dgvHistorialProducto.CurrentRow.Cells["colIdCompra"].Value);

            using (MySqlConnection conn = DB.GetConnection())
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

                CompraReimpresion compra = new CompraReimpresion();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return;

                        compra.Folio = dr["folio"].ToString();

                        compra.Fecha =
                            Convert.ToDateTime(dr["fecha_compra"]);

                        compra.Proveedor = dr["proveedor"].ToString();

                        compra.Usuario = dr["usuario"].ToString();

                        compra.Autorizo =
                            dr["autorizo"] == DBNull.Value
                            ? "N/A"
                            : dr["autorizo"].ToString();

                        compra.Total =
                            Convert.ToDecimal(dr["total"]);
                    }
                }

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

                using (MySqlCommand cmd = new MySqlCommand(sqlDetalle, conn))
                {
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            compra.Detalle.Add(
                                new CompraDetalleReimpresion
                                {
                                    Producto = dr["nombre"].ToString(),
                                    Cantidad = Convert.ToDecimal(dr["cantidad"]),
                                    PrecioCompra = Convert.ToDecimal(dr["precio_compra"]),
                                    Subtotal = Convert.ToDecimal(dr["subtotal"])
                                });
                        }
                    }
                }

                FrmTicketCompra frm = new FrmTicketCompra(compra);

                frm.EsReimpresion = true;

                frm.ShowDialog();
            }
        }

        private void dgvHistorialProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            AbrirTicketCompra();
        }

        private void dgvHistorialProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AbrirTicketCompra();

                e.SuppressKeyPress = true;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedTab.Name)
            {
                case "tabCompras":
                    CargarHistorialCompras();
                    break;

                case "tabVentas":
                    CargarHistorialVentas();
                    break;

                case "tabInventario":
                    CargarHistorialInventario();
                    break;
            }
        }

        private void dgvHistorialVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idVenta =
                Convert.ToInt32(
                    dgvHistorialVentas.Rows[e.RowIndex]
                    .Cells["colIdVenta"].Value);

            AbrirVentaGuardada(idVenta);
        }

        private void dgvHistorialVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (dgvHistorialVentas.CurrentRow == null)
                return;

            e.Handled = true;

            int idVenta =
                Convert.ToInt32(
                    dgvHistorialVentas.CurrentRow
                    .Cells["colIdVenta"].Value);

            AbrirVentaGuardada(idVenta);
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            CargarCabeceraProducto();

            CargarEstadisticasProducto();

            CargarResumenVentas();

            CargarHistorialCompras();

            CargarHistorialVentas();

            CargarHistorialInventario();
        }
    }
}
