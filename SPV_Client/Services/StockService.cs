using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SPV_Client.Models;

namespace SPV_Client.Services
{
    internal class StockService
    {
        public void RegistrarSalida(
    int idVenta,
    VentaCompleta venta,
    MySqlConnection conn,
    MySqlTransaction trans)
        {
            foreach (VentaDetalle item in venta.Detalle)
            {
                string sqlMovimiento = @"
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
    @id_producto,
    @id_usuario,
    'SALIDA',
    @cantidad,
    @descripcion,
    @id_venta
);";
                using (MySqlCommand cmd = new MySqlCommand(sqlMovimiento, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@id_producto", item.IdProducto);

                    cmd.Parameters.AddWithValue("@id_usuario", venta.IdUsuario);

                    cmd.Parameters.AddWithValue("@cantidad", item.Cantidad);

                    cmd.Parameters.AddWithValue("@descripcion",
                        "Venta Realizada");

                    cmd.Parameters.AddWithValue("@id_venta", idVenta);

                    cmd.ExecuteNonQuery();

                    
                }
            }
        }
    }
    
    }
