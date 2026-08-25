using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SPV_Client.Models;

namespace SPV_Client.Services
{
    internal class VentaService
    {
        public int GuardarVenta(VentaCompleta venta)
        {
            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        int idVenta = GuardarEncabezadoVenta(
     venta,
     conn,
     trans);

                        GuardarDetalleVenta(
                            idVenta,
                            venta,
                            conn,
                            trans);

                        new StockService().RegistrarSalida(
                            idVenta,
                            venta,
                            conn,
                            trans);

                        GuardarPagoVenta(
                            idVenta,
                            venta,
                            conn,
                            trans);

                        ActualizarConsecutivoVenta(
                            conn,
                            trans);

                        trans.Commit();

                        return idVenta;
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            trans.Rollback();
                        }
                        catch
                        {
                        }

                        MessageBox.Show(
                            ex.ToString(),
                            "Error VentaService",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return 0;
                    }
                }
            }
        }

        private string ObtenerSiguienteFolioVenta(
    MySqlConnection conn,
    MySqlTransaction trans)
        {
            string sql = @"
SELECT ultimo_consecutivo + 1
FROM folios
WHERE tipo='VENTA';";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
            {
                int siguiente = Convert.ToInt32(cmd.ExecuteScalar());

                return $"VTA-{siguiente:D6}";
            }
        }

        private int GuardarEncabezadoVenta(VentaCompleta venta, MySqlConnection conn, MySqlTransaction trans)
        {
            string folio = ObtenerSiguienteFolioVenta(conn, trans);
            string sql = @"
INSERT INTO ventas
(
    folio,
    id_usuario,
    id_turno,
    id_socio,
    total,
    descuento_general
)
VALUES
(
    @folio,
    @id_usuario,
    @id_turno,
    @id_socio,
    @total,
    @descuento_general
);";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@folio", folio);

                cmd.Parameters.AddWithValue("@id_usuario", venta.IdUsuario);

                cmd.Parameters.AddWithValue("@id_turno", venta.IdTurno);

                

                cmd.Parameters.AddWithValue("@id_socio",
                    venta.IdSocio == 0 ? (object)DBNull.Value : venta.IdSocio);

                cmd.Parameters.AddWithValue("@total", venta.Total);

                cmd.Parameters.AddWithValue("@descuento_general",
                    venta.DescuentoGeneral);

                cmd.ExecuteNonQuery();

                return Convert.ToInt32(cmd.LastInsertedId);
            }
        }

        private void GuardarDetalleVenta(int idVenta, VentaCompleta venta, MySqlConnection conn, MySqlTransaction trans)
        {
            foreach (VentaDetalle item in venta.Detalle)
            {
                string sql = @"
INSERT INTO detalle_ventas
(
    id_venta,
    id_producto,
    cantidad,
    precio_unitario,
    subtotal,
    descuento
)
VALUES
(
    @id_venta,
    @id_producto,
    @cantidad,
    @precio,
    @subtotal,
    @descuento
);";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@id_venta", idVenta);

                    cmd.Parameters.AddWithValue("@id_producto", item.IdProducto);

                    cmd.Parameters.AddWithValue("@cantidad", item.Cantidad);

                    cmd.Parameters.AddWithValue("@precio", item.Precio);

                    cmd.Parameters.AddWithValue("@subtotal", item.SubtotalOriginal);

                    cmd.Parameters.AddWithValue("@descuento", item.Descuento);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void GuardarPagoVenta(
     int idVenta,
     VentaCompleta venta,
     MySqlConnection conn,
     MySqlTransaction trans)
        {
            decimal efectivoAplicado =
    venta.Pago.Efectivo - venta.Pago.Cambio;

            if (efectivoAplicado > 0)
            {
                InsertarPago(
                    idVenta,
                    1,
                    efectivoAplicado,
                    conn,
                    trans);
            }

            if (venta.Pago.Tarjeta > 0)
            {
                InsertarPago(
                    idVenta,
                    2,
                    venta.Pago.Tarjeta,
                    conn,
                    trans);
            }

            if (venta.Pago.Transferencia > 0)
            {
                InsertarPago(
                    idVenta,
                    3,
                    venta.Pago.Transferencia,
                    conn,
                    trans);
            }

            if (venta.Pago.Vale > 0)
            {
                InsertarPago(
                    idVenta,
                    4,
                    venta.Pago.Vale,
                    conn,
                    trans);
            }
        }

        private void InsertarPago(
    int idVenta,
    int idFormaPago,
    decimal importe,
    MySqlConnection conn,
    MySqlTransaction trans)
        {
            string sql = @"
INSERT INTO ventas_pagos
(
    id_venta,
    id_forma_pago,
    importe
)
VALUES
(
    @id_venta,
    @id_forma_pago,
    @importe
);";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
            {
                cmd.Parameters.AddWithValue("@id_venta", idVenta);
                cmd.Parameters.AddWithValue("@id_forma_pago", idFormaPago);
                cmd.Parameters.AddWithValue("@importe", importe);

                cmd.ExecuteNonQuery();
            }
        }

        private void ActualizarConsecutivoVenta(
    MySqlConnection conn,
    MySqlTransaction trans)
        {
            string sql = @"
UPDATE folios
SET ultimo_consecutivo = ultimo_consecutivo + 1
WHERE tipo = 'VENTA';";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void GuardarMovimientosStock()
        {

        }

        private void GuardarPago()
        {

        }

        private void ActualizarConsecutivo()
        {

        }

        public bool CancelarVenta(int idVenta, int idUsuarioCancela)
        {
            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlVenta = @"
UPDATE ventas
SET
    estado = 'CANCELADA',
    fecha_cancelacion = NOW(),
    id_usuario_cancela = @usuario
WHERE id_venta = @venta;";

                        using (MySqlCommand cmd = new MySqlCommand(sqlVenta, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@usuario", idUsuarioCancela);
                            cmd.Parameters.AddWithValue("@venta", idVenta);

                            int filas = cmd.ExecuteNonQuery();

                            if (filas == 0)
                            {
                                throw new Exception("No se encontró la venta.");
                            }
                        }

                        string sqlDetalle = @"
SELECT
    id_producto,
    cantidad
FROM detalle_ventas
WHERE id_venta = @venta;";

                        using (MySqlCommand cmdDetalle = new MySqlCommand(sqlDetalle, conn, trans))
                        {
                            cmdDetalle.Parameters.AddWithValue("@venta", idVenta);

                            using (MySqlDataReader reader = cmdDetalle.ExecuteReader())
                            {
                                List<(int idProducto, decimal cantidad)> productos =
                                    new List<(int, decimal)>();

                                while (reader.Read())
                                {
                                    productos.Add((
                                        Convert.ToInt32(reader["id_producto"]),
                                        Convert.ToDecimal(reader["cantidad"])
                                    ));
                                }

                                reader.Close();

                                foreach (var p in productos)
                                {
                                    string sqlStock = @"
UPDATE productos
SET stock_actual = stock_actual + @cantidad
WHERE id_producto = @producto;";

                                    using (MySqlCommand cmdStock =
                                        new MySqlCommand(sqlStock, conn, trans))
                                    {
                                        cmdStock.Parameters.AddWithValue("@cantidad", p.cantidad);
                                        cmdStock.Parameters.AddWithValue("@producto", p.idProducto);

                                        cmdStock.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        string sqlMovimientos = @"
SELECT
    id_producto,
    cantidad
FROM detalle_ventas
WHERE id_venta = @venta;";

                        using (MySqlCommand cmdMov = new MySqlCommand(sqlMovimientos, conn, trans))
                        {
                            cmdMov.Parameters.AddWithValue("@venta", idVenta);

                            using (MySqlDataReader reader = cmdMov.ExecuteReader())
                            {
                                List<(int idProducto, decimal cantidad)> movimientos =
                                    new List<(int, decimal)>();

                                while (reader.Read())
                                {
                                    movimientos.Add((
                                        Convert.ToInt32(reader["id_producto"]),
                                        Convert.ToDecimal(reader["cantidad"])
                                    ));
                                }

                                reader.Close();

                                foreach (var mov in movimientos)
                                {
                                    string sqlInsert = @"
INSERT INTO movimientos_stock
(
    id_producto,
    id_usuario,
    tipo_movimiento,
    cantidad,
    descripcion,
    id_venta
)
VALUES
(
    @producto,
    @usuario,
    'DEVOLUCION',
    @cantidad,
    @descripcion,
    @venta
);";

                                    using (MySqlCommand cmdInsert =
                                        new MySqlCommand(sqlInsert, conn, trans))
                                    {
                                        cmdInsert.Parameters.AddWithValue("@producto", mov.idProducto);
                                        cmdInsert.Parameters.AddWithValue("@usuario", idUsuarioCancela);
                                        cmdInsert.Parameters.AddWithValue("@cantidad", mov.cantidad);
                                        cmdInsert.Parameters.AddWithValue("@descripcion",
                                            "Cancelación de venta");
                                        cmdInsert.Parameters.AddWithValue("@venta", idVenta);

                                        cmdInsert.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();

                        MessageBox.Show(
                            ex.Message,
                            "Error al cancelar venta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }
            }
        }

        public VentaReimpresion ObtenerVentaParaReimpresion(int idVenta)
        {
            VentaReimpresion venta = null;

            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    v.folio,
    v.fecha_venta,
    u.nombre AS usuario,
    COALESCE(s.nombre_socio,'PUBLICO GENERAL') AS cliente,
    v.total,
    v.descuento_general
FROM ventas v
INNER JOIN usuarios u
    ON v.id_usuario=u.id_usuario
LEFT JOIN socios s
    ON v.id_socio=s.id_socio
WHERE v.id_venta=@idVenta;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            venta = new VentaReimpresion
                            {
                                Folio = dr["folio"].ToString(),
                                Fecha = Convert.ToDateTime(dr["fecha_venta"]),
                                Usuario = dr["usuario"].ToString(),
                                Cliente = dr["cliente"].ToString(),
                                Total = Convert.ToDecimal(dr["total"]),
                                DescuentoGeneral = Convert.ToDecimal(dr["descuento_general"])
                            };
                        }
                    }
                }

                if (venta == null)
                    return null;

                sql = @"
SELECT
    p.nombre,
    dv.cantidad,
    dv.precio_unitario,
    dv.descuento,
    dv.subtotal
FROM detalle_ventas dv
INNER JOIN productos p
    ON dv.id_producto=p.id_producto
WHERE dv.id_venta=@idVenta;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            venta.Detalle.Add(new VentaDetalleReimpresion
                            {
                                Producto = dr["nombre"].ToString(),
                                Cantidad = Convert.ToDecimal(dr["cantidad"]),
                                PrecioUnitario = Convert.ToDecimal(dr["precio_unitario"]),
                                Descuento = Convert.ToDecimal(dr["descuento"]),
                                Subtotal = Convert.ToDecimal(dr["subtotal"])
                            });
                        }
                    }
                }
            }

            return venta;
        }
    }

    
}
