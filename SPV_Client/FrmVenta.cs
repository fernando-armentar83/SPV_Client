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
using SPV_Client.Helpers;
using SPV_Client.Models;
using SPV_Client.Services;

namespace SPV_Client
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();

            ConfigurarToolTips();
        }

        private void ConfigurarToolTips()
        {
            ttAyuda.SetToolTip(
                txtCodigoBarrasVenta,
                "F2 = Buscar producto.\n" +
                "Escanee o escriba el código de barras.");

            ttAyuda.SetToolTip(
                txtProductoVenta,
                "F2 = Buscar producto.\n" +
                "Abre Buscador de Productos.");

            ttAyuda.SetToolTip(
                txtCantidadVenta,
                "Cantidad del producto.\n\n" +
                "Puede capturar:\n" +
                "1 = una unidad\n" +
                ".250 = 250 gramos/ml/metros\n" +
                "$20 = venta por importe (solo productos permitidos).\n\n" +
                "F4 = Editar cantidad.");

            ttAyuda.SetToolTip(
                btnAgregarVenta,
                "Agrega el producto a la venta.");

            ttAyuda.SetToolTip(
                btnDescuentoVenta,
                "F8 = Aplicar descuento.");

            ttAyuda.SetToolTip(
                btnCancelarLinea,
                "Supr = Eliminar la línea seleccionada.");

            ttAyuda.SetToolTip(
                btnCatalogoProductos,
                "F9 = Abrir catálogo de productos e historial.");

            ttAyuda.SetToolTip(
                btnPagarVenta,
                "F10 = Cobrar la venta.");

            ttAyuda.SetToolTip(
                lblInfoVenta,
                "F2 = Buscar Producto \n" +
                "F4 = Editar Cantidad ó Doble click \n" +
                "Editar precio = Doble click \n" +
                "Editar Producto = Doble click \n" +
                "Editar Descuento = Doble click");
                
        }

        private void ActualizarToolTipCantidad()
        {
            string ayuda;

            if (!permiteDecimal)
            {
                ayuda =
                    "Cantidad del producto.\n\n" +
                    "Solo permite cantidades enteras.\n\n" +
                    "Ejemplos:\n" +
                    "1\n" +
                    "2\n" +
                    "10";
            }
            else
            {
                ayuda =
                    $"Cantidad ({abreviaturaMedida}).\n\n" +
                    "Ejemplos:\n" +
                    $"1 = 1 {abreviaturaMedida}\n" +
                    $".250 = 0.250 {abreviaturaMedida}";

                if (permiteVentaImporte)
                {
                    ayuda += "\n$20 = Venta por importe.";
                }
            }

            ayuda += "\n\nF4 = Editar cantidad.";

            ttAyuda.SetToolTip(txtCantidadVenta, ayuda);
        }

        private Timer reloj = new Timer();
        private int idProductoActual = 0;
        private int idDepartamentoActual = 0;

        private decimal precioVentaActual = 0;
        private decimal stockActual = 0;
        private int idMedidaActual = 0;

        private bool permiteDecimal = false;
        private bool permiteImporte = false;

        private int decimalesCantidad = 0;

        private string abreviaturaMedida = "";

        private string modeloActual = "";
        private string nombreProductoActual = "";

        private bool permiteVentaImporte = false;
        private bool capturaPorImporte = false;



        private List<VentaDetalle> detalleVenta = new List<VentaDetalle>();

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            InicializarFormulario();

            reloj.Interval = 1000;
            reloj.Tick += Reloj_Tick;
            reloj.Start();

            txtCodigoBarrasVenta.Focus();
        }

        private void InicializarFormulario()
        {
            // Fecha y hora
            lblFechaVenta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraVenta.Text = DateTime.Now.ToString("HH:mm:ss");

            // Usuario y turno
            lblUsuarioVenta.Text = Session.NombreUsuario;
            lblTurnoVenta.Text = Session.IdTurno.ToString();

            // Estado de promociones (temporal)
            lblEstadoPromocion.Text = "SIN PROMOCIONES ACTIVAS";
            lblEstadoPromocion.BackColor = Color.Honeydew;
            lblEstadoPromocion.ForeColor = Color.DarkGreen;

            // Folio 
            MostrarProximoFolio();

            // Limpiar controles
            txtCodigoBarrasVenta.Clear();
            txtProductoVenta.Clear();

            txtCantidadVenta.Text = "1";

            lblPrecioVenta.Text = "$0.00";
            lblStockVenta.Text = "0";
            lblTotalVenta.Text = "$0.00";
            lblCantidadTexto.Text = "Cantidad";

            dgvDetalleVenta.Rows.Clear();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblHoraVenta.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MostrarProximoFolio()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT ultimo_consecutivo + 1
FROM folios
WHERE tipo = 'VENTA';
";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int siguiente = Convert.ToInt32(result);

                            lblFolioVenta.Text = $"VTA-{siguiente:D6}";
                        }
                        else
                        {
                            lblFolioVenta.Text = "VTA-SIN-FOLIO";
                        }
                    }
                }
            }
            catch
            {
                lblFolioVenta.Text = "ERROR-FOLIO";
            }
        }

        private void BuscarProducto(string codigo)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    
                    string sql = @"
SELECT
    p.id_producto,
    p.id_categoria,
    p.id_medida,
    p.nombre,
    p.modelo,
    p.precio_venta,
    p.stock_actual,
    p.permite_venta_importe,

    um.abreviatura,
    um.permite_decimal,
    um.permite_importe,
    um.decimales

FROM productos p

INNER JOIN unidades_medida um
    ON p.id_medida = um.id_medida

WHERE p.codigo_barras = @codigo
AND p.activo = 1

LIMIT 1;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                CargarProductoDesdeReader(dr);
                                

                            }
                            else
                            {
                                LimpiarProductoActual();

                                MessageBox.Show(
                                    "Producto no encontrado.",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                txtCodigoBarrasVenta.SelectAll();
                                txtCodigoBarrasVenta.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarProducto(int idProducto)
        {

        }

        private void ConfigurarCantidadSegunUnidad()
        {
            if (permiteDecimal)
            {
                txtCantidadVenta.Text = "1";

                txtCantidadVenta.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                txtCantidadVenta.Text = "1";

                txtCantidadVenta.TextAlign = HorizontalAlignment.Center;
            }

            txtCantidadVenta.Focus();
            txtCantidadVenta.SelectAll();
        }

        private bool ValidarCantidad()
        {
            decimal cantidad;

            string texto = txtCantidadVenta.Text.Trim();

            capturaPorImporte = false;

            if (texto.StartsWith("$"))
            {
                if (!permiteVentaImporte)
                {
                    MessageBox.Show(
                        "Este producto no permite venta por importe.",
                        "Venta por importe",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCantidadVenta.Focus();
                    txtCantidadVenta.SelectAll();

                    return false;
                }

                capturaPorImporte = true;

                texto = texto.Substring(1).Trim();
            }

            if (!decimal.TryParse(texto, out cantidad))
            {
                MessageBox.Show(
                    "Cantidad inválida.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidadVenta.Focus();
                txtCantidadVenta.SelectAll();
                return false;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor que cero.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidadVenta.Focus();
                txtCantidadVenta.SelectAll();
                return false;
            }

            // Validar si la unidad permite decimales
            if (!permiteDecimal)
            {
                if (cantidad != Math.Truncate(cantidad))
                {
                    MessageBox.Show(
                        $"La unidad {abreviaturaMedida} no permite cantidades decimales.",
                        "Cantidad inválida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCantidadVenta.Focus();
                    txtCantidadVenta.SelectAll();

                    return false;
                }
            }
            else
            {
                texto = capturaPorImporte
    ? texto
    : txtCantidadVenta.Text.Trim();

                if (texto.Contains("."))
                {
                    int decimales = texto.Substring(texto.IndexOf('.') + 1).Length;

                    if (decimales > decimalesCantidad)
                    {
                        MessageBox.Show(
                            $"La unidad {abreviaturaMedida} permite un máximo de {decimalesCantidad} decimales.",
                            "Cantidad inválida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtCantidadVenta.Focus();
                        txtCantidadVenta.SelectAll();

                        return false;
                    }
                }
            }

            return true;
        }

        private void LimpiarProductoActual()
        {
            idProductoActual = 0;
            idDepartamentoActual = 0;

            nombreProductoActual = "";
            modeloActual = "";

            precioVentaActual = 0;
            stockActual = 0;

            txtProductoVenta.Clear();

            lblPrecioVenta.Text = "$0.00";
            lblStockVenta.Text = "0";
            lblCantidadTexto.Text = "Cantidad :";

            txtCantidadVenta.Enabled = false;
            txtCantidadVenta.Text = "1";
        }

        private void AgregarProductoAVenta()
        {
            // Verificar que exista un producto seleccionado
            if (idProductoActual == 0)
                return;

            // Validar cantidad

            if (!ValidarCantidad())
                return;

            decimal cantidad;

            
            if (capturaPorImporte)
            {
                string textoImporte = txtCantidadVenta.Text
                    .Replace("$", "")
                    .Trim();

                decimal importeDeseado = Convert.ToDecimal(textoImporte);

                cantidad = importeDeseado / precioVentaActual;

                if (permiteDecimal)
                {
                    cantidad = Math.Round(
                        cantidad,
                        decimalesCantidad,
                        MidpointRounding.AwayFromZero);
                }
            }
            else
            {
                cantidad = Convert.ToDecimal(txtCantidadVenta.Text);
            }


            VentaDetalle detalle = new VentaDetalle();

            detalle.IdProducto = idProductoActual;
            detalle.IdCategoria = idDepartamentoActual;

            detalle.Producto = nombreProductoActual;
            detalle.Modelo = modeloActual;

            detalle.Cantidad = cantidad;
            detalle.Precio = precioVentaActual;

            detalle.Descuento = 0;
            detalle.ImporteDescuento = 0;
            detalle.TipoDescuento = "";

            detalle.Subtotal = cantidad * precioVentaActual;

            detalle.SubtotalOriginal = detalle.Subtotal;

            // Buscar si el producto ya existe en la venta
            VentaDetalle existente = detalleVenta.FirstOrDefault(x => x.IdProducto == detalle.IdProducto);

            if (existente != null)
            {
                existente.Cantidad += detalle.Cantidad;

                existente.Subtotal =
                    (existente.Cantidad * existente.Precio)
                    - existente.ImporteDescuento;
            }
            else
            {
                detalleVenta.Add(detalle);
            }
            
            ActualizarGridVenta();

            CalcularTotalVenta();

            LimpiarProductoActual();

            txtCodigoBarrasVenta.Clear();
            txtCodigoBarrasVenta.Focus();
        }

        private void ActualizarGridVenta()
        {
            dgvDetalleVenta.Rows.Clear();

            foreach (VentaDetalle item in detalleVenta)
            {
                dgvDetalleVenta.Rows.Add(
                    0,                          // IdDetalle
                    item.IdProducto,
                    item.IdCategoria,
                    item.Categoria,
                    item.Producto,
                    item.Modelo,
                    item.Cantidad,
                    item.Precio,
                    item.Descuento,
                    item.ImporteDescuento,
                    item.TipoDescuento,
                    item.Subtotal
                );
            }
        }

        private void CalcularTotalVenta()
        {
            decimal total = detalleVenta.Sum(x => x.Subtotal);

            lblTotalVenta.Text = total.ToString("C2");
        }

        private void ActualizarRenglonVenta(int fila)
        {
            VentaDetalle detalle = detalleVenta[fila];

            // Recalcular subtotal
            detalle.Subtotal =
                detalle.Cantidad *
                detalle.Precio *
                (1 - (detalle.Descuento / 100m));

            DataGridViewRow row = dgvDetalleVenta.Rows[fila];

            row.Cells["colProducto"].Value = detalle.Producto;
            row.Cells["colModelo"].Value = detalle.Modelo;

            row.Cells["colCantidad"].Value = detalle.Cantidad;
            row.Cells["colPrecioVenta"].Value = detalle.Precio;
            row.Cells["colDescuento"].Value = detalle.Descuento;
            row.Cells["colSubtotal"].Value = detalle.Subtotal;

            CalcularTotalVenta();
        }

        private void CambiarProductoVenta()
        {
            if (dgvDetalleVenta.CurrentRow == null)
                return;

            int fila = dgvDetalleVenta.CurrentRow.Index;

            if (fila < 0 || fila >= detalleVenta.Count)
                return;

            using (FrmBuscarProducto frm = new FrmBuscarProducto())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                if (frm.ProductoSeleccionado == null)
                    return;

                ProductoSeleccionado productoNuevo =
                    frm.ProductoSeleccionado;

                                
                // Verificar si el producto ya existe en otra fila
                bool existe = false;

                for (int i = 0; i < detalleVenta.Count; i++)
                {
                    if (i == fila)
                        continue;

                    if (detalleVenta[i].IdProducto == productoNuevo.IdProducto)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    MessageBox.Show(
                        "El producto ya existe en la venta.",
                        "Producto duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Obtener datos completos del nuevo producto

                VentaDetalle detalle = detalleVenta[fila];

                // Si el producto tiene descuento, confirmar antes de perderlo
                if (detalle.Descuento > 0)
                {
                    DialogResult respuesta = MessageBox.Show(
                        "El producto tiene un descuento aplicado.\n\n" +
                        "Si cambia el producto, el descuento será eliminado.\n\n" +
                        "¿Desea continuar?",
                        "Confirmar cambio de producto",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                        return;
                }
                if (!ObtenerDatosProducto(productoNuevo.IdProducto))
                    return;

                ReemplazarProductoVenta(fila);
            }


        }

        private void ReemplazarProductoVenta(int fila)
        {
            VentaDetalle detalle = detalleVenta[fila];

            detalle.IdProducto = idProductoActual;
            detalle.IdCategoria = idDepartamentoActual;

            detalle.Producto = nombreProductoActual;
            detalle.Modelo = modeloActual;

            detalle.Precio = precioVentaActual;

            // Al cambiar de producto se eliminan descuentos
            detalle.Descuento = 0;
            detalle.ImporteDescuento = 0;
            detalle.TipoDescuento = "";

            detalle.SubtotalOriginal =
                detalle.Cantidad * detalle.Precio;

            detalle.Subtotal =
                detalle.SubtotalOriginal;

            ActualizarRenglonVenta(fila);
        }

        private void txtCodigoBarrasVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (txtCodigoBarrasVenta.Text.Trim() == "")
                    return;

                BuscarProducto(txtCodigoBarrasVenta.Text.Trim());
            }
        }

        private void txtCantidadVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                btnAgregarVenta.PerformClick();
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            AgregarProductoAVenta();
        }

        private void FrmVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;

                AbrirBusquedaProducto();
            }

            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                EliminarRenglonSeleccionado();
            }

            if (e.KeyCode == Keys.F4)
            {
                e.SuppressKeyPress = true;
                EditarCantidad();
            }

            if (e.KeyCode == Keys.F8)
            {
                e.SuppressKeyPress = true;
                SolicitarDescuento();
            }

            if (e.KeyCode == Keys.F9)
            {
                e.SuppressKeyPress = true;
                EditarProductoSeleccionado();
            }
        }

        private void EditarProductoSeleccionado()
        {
            if (dgvDetalleVenta.CurrentRow == null)
                return;

            if (dgvDetalleVenta.CurrentRow.Index < 0)
                return;

            int fila = dgvDetalleVenta.CurrentRow.Index;

            VentaDetalle detalle = detalleVenta[fila];

            // Si es Administrador entra directo.
            if (Session.NombreRol == "Administrador")
            {
                FrmItem frm = new FrmItem();

                frm.IdProducto = detalle.IdProducto;

                frm.ShowDialog();

                return;
            }

            // Cualquier otro rol solicita autorización.
            using (FrmLoginTemporal login =
                new FrmLoginTemporal("Editar producto"))
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            FrmItem frmEditar = new FrmItem();

            frmEditar.IdProducto = detalle.IdProducto;

            frmEditar.ShowDialog();
        }

        private void AbrirBusquedaProducto()
        {
            using (FrmBuscarProducto frm = new FrmBuscarProducto())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.ProductoSeleccionado == null)
                        return;

                    ProductoSeleccionado p = frm.ProductoSeleccionado;

                    BuscarProductoPorId(p.IdProducto);

                    
                }
            }
        }

        private bool ObtenerDatosProducto(int idProducto)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    p.id_producto,
    p.id_categoria,
    p.id_medida,
    p.nombre,
    p.modelo,
    p.precio_venta,
    p.stock_actual,
    p.permite_venta_importe,

    um.abreviatura,
    um.permite_decimal,
    um.permite_importe,
    um.decimales

FROM productos p
INNER JOIN unidades_medida um
    ON p.id_medida = um.id_medida

WHERE p.id_producto=@id
LIMIT 1;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idProducto);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                                return false;

                            idProductoActual = Convert.ToInt32(dr["id_producto"]);
                            idDepartamentoActual = Convert.ToInt32(dr["id_categoria"]);

                            nombreProductoActual = dr["nombre"].ToString();
                            modeloActual = dr["modelo"].ToString();

                            precioVentaActual = Convert.ToDecimal(dr["precio_venta"]);
                            stockActual = Convert.ToDecimal(dr["stock_actual"]);

                            idMedidaActual = Convert.ToInt32(dr["id_medida"]);

                            abreviaturaMedida = dr["abreviatura"].ToString();

                            permiteDecimal = Convert.ToBoolean(dr["permite_decimal"]);
                            permiteImporte = Convert.ToBoolean(dr["permite_importe"]);

                            permiteVentaImporte = Convert.ToBoolean(dr["permite_venta_importe"]);



                            decimalesCantidad = Convert.ToInt32(dr["decimales"]);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        private void BuscarProductoPorId(int idProducto)
        {
            try
            {
                
                if (!ObtenerDatosProducto(idProducto))
                    return;

                txtCodigoBarrasVenta.Text = "";
                txtProductoVenta.Text = nombreProductoActual;

                lblPrecioVenta.Text = precioVentaActual.ToString("C2");
                lblStockVenta.Text = stockActual.ToString("N3");
                lblCantidadTexto.Text = $"Cantidad ({abreviaturaMedida})";

                txtCantidadVenta.Text = "1";

                ConfigurarCantidadSegunUnidad();

                ActualizarToolTipCantidad();

                txtCantidadVenta.Enabled = true;
                txtCantidadVenta.Focus();
                txtCantidadVenta.SelectAll();

                this.ActiveControl = txtCantidadVenta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void CargarProductoDesdeReader(MySqlDataReader dr)
        {
            idProductoActual = Convert.ToInt32(dr["id_producto"]);
            idDepartamentoActual = Convert.ToInt32(dr["id_categoria"]);

            nombreProductoActual = dr["nombre"].ToString();
            modeloActual = dr["modelo"].ToString();

            precioVentaActual = Convert.ToDecimal(dr["precio_venta"]);
            stockActual = Convert.ToDecimal(dr["stock_actual"]);

            idMedidaActual = Convert.ToInt32(dr["id_medida"]);

            abreviaturaMedida = dr["abreviatura"].ToString();

            permiteDecimal = Convert.ToBoolean(dr["permite_decimal"]);
            permiteImporte = Convert.ToBoolean(dr["permite_importe"]);

            permiteVentaImporte = Convert.ToBoolean(dr["permite_venta_importe"]);


            decimalesCantidad = Convert.ToInt32(dr["decimales"]);

            txtProductoVenta.Text = nombreProductoActual;

            lblPrecioVenta.Text = precioVentaActual.ToString("C2");
            lblStockVenta.Text = stockActual.ToString("N2");
            lblCantidadTexto.Text = $"Cantidad ({abreviaturaMedida})";

            txtCantidadVenta.Enabled = true;
            //txtCantidadVenta.Text = "1";
            if (permiteDecimal)
                txtCantidadVenta.Text = "1.000";
            else
                txtCantidadVenta.Text = "1";

            ConfigurarCantidadSegunUnidad();

            string ayudaCantidad = "";

            if (!permiteDecimal)
            {
                ayudaCantidad =
                    "Cantidad del producto.\n\n" +
                    "Solo permite cantidades enteras.\n\n" +
                    "Ejemplos:\n" +
                    "1\n" +
                    "2\n" +
                    "10\n\n" +
                    "F4 = Editar cantidad.";
            }
            else
            {
                ayudaCantidad =
                    $"Cantidad ({abreviaturaMedida}).\n\n" +
                    "Ejemplos:\n" +
                    $"1 = 1 {abreviaturaMedida}\n" +
                    $".250 = 0.250 {abreviaturaMedida}";

                if (permiteVentaImporte)
                {
                    ayudaCantidad +=
                        "\n$20 = Venta por importe.";
                }

                ayudaCantidad +=
                    "\n\nF4 = Editar cantidad.";
            }
            
            ttAyuda.SetToolTip(txtCantidadVenta, ayudaCantidad);
            MessageBox.Show(ayudaCantidad);
        }

        private void EliminarRenglonSeleccionado()
        {
            if (dgvDetalleVenta.CurrentRow == null)
                return;

            int indice = dgvDetalleVenta.CurrentRow.Index;

            if (indice < 0 || indice >= detalleVenta.Count)
                return;

            DialogResult r = MessageBox.Show(
                "¿Eliminar el producto seleccionado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes)
                return;

            detalleVenta.RemoveAt(indice);

            ActualizarGridVenta();

            CalcularTotalVenta();

            txtCodigoBarrasVenta.Focus();
        }

        private void btnCancelarLinea_Click(object sender, EventArgs e)
        {
            EliminarRenglonSeleccionado();
        }

        private bool HayPromocionActiva()
        {
            // Temporal.
            // Más adelante consultará la tabla de promociones.
            return false;
        }

        private void EditarCantidad()
        {
            if (dgvDetalleVenta.CurrentRow == null)
                return;

            int fila = dgvDetalleVenta.CurrentRow.Index;

            if (fila < 0 || fila >= detalleVenta.Count)
                return;

            VentaDetalle detalle = detalleVenta[fila];

            using (FrmEditarCantidad frm = new FrmEditarCantidad(
    detalle.Producto,
    detalle.Cantidad,
    permiteDecimal,
    decimalesCantidad))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                detalle.Cantidad = frm.NuevaCantidad;

                detalle.SubtotalOriginal =
     detalle.Cantidad * detalle.Precio;

                if (detalle.TipoDescuento == "Porcentaje")
                {
                    detalle.ImporteDescuento =
                        detalle.SubtotalOriginal * (detalle.Descuento / 100m);
                }

                detalle.Subtotal =
                    detalle.SubtotalOriginal - detalle.ImporteDescuento;
            }

            ActualizarRenglonVenta(fila);
            //ActualizarGridVenta();

            //CalcularTotalVenta();
        }

        private void SolicitarDescuento()
        {
            if (dgvDetalleVenta.CurrentRow == null)
                return;

            if (HayPromocionActiva())
            {
                MessageBox.Show(
                    "Aquí abrirá la pantalla de descuentos.",
                    "Promoción",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Si la sesión actual es Administrador, no solicita autorización.
            if (Session.NombreRol != "Administrador")
            {
                using (FrmLoginTemporal frm =
                    new FrmLoginTemporal("Descuento en venta"))
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;
                }
            }

            int fila = dgvDetalleVenta.CurrentRow.Index;

            VentaDetalle detalle = detalleVenta[fila];
                        
            using (FrmDescuento frm = new FrmDescuento(
                detalle.Producto,
                detalle.Cantidad,
                detalle.Precio,
                detalle.SubtotalOriginal,
                detalle.TipoDescuento,
                detalle.Descuento,
                detalle.ImporteDescuento))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                detalle.Descuento = frm.Resultado.Porcentaje;
                detalle.ImporteDescuento = frm.Resultado.ImporteDescuento;
                detalle.TipoDescuento = frm.Resultado.TipoDescuento;

                detalle.Subtotal = frm.Resultado.NuevoSubtotal;
            }

            ActualizarRenglonVenta(fila);
        }

        private void btnDescuentoVenta_Click(object sender, EventArgs e)
        {
            SolicitarDescuento();
        }

        private void btnPagarVenta_Click(object sender, EventArgs e)
        {
            if (detalleVenta.Count == 0)
            {
                MessageBox.Show(
                    "No hay productos en la venta.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal total = detalleVenta.Sum(x => x.Subtotal);

            using (FrmCobro frm = new FrmCobro(total))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                CobroResultado cobro = frm.Resultado;

                GuardarVenta(cobro);
            }
        }

        private void GuardarVenta(CobroResultado cobro)
        {
            VentaCompleta venta = ConstruirVenta(cobro);

            VentaService servicio = new VentaService();

            int idVenta = servicio.GuardarVenta(venta);

            if (idVenta == 0)
            {
                MessageBox.Show(
                    "No fue posible guardar la venta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            VentaReimpresion ventaTicket =
                servicio.ObtenerVentaParaReimpresion(idVenta);

            if (ventaTicket != null)
            {
                FrmTicketVenta frm = new FrmTicketVenta(ventaTicket);

                frm.ModoReimpresion = false;

                frm.ShowDialog();
            }

            LimpiarVenta();

            MostrarProximoFolio();

            txtCodigoBarrasVenta.Focus();
        }

        private VentaCompleta ConstruirVenta(CobroResultado cobro)
        {
            VentaCompleta venta = new VentaCompleta();

            venta.IdUsuario = Session.IdUsuario;

            venta.IdTurno = Session.IdTurno;

            venta.Total = detalleVenta.Sum(x => x.Subtotal);

            venta.DescuentoGeneral = 0;

            venta.Detalle = detalleVenta;

            venta.Pago = new VentaPago
            {
                Efectivo = cobro.Efectivo,
                Tarjeta = cobro.Tarjeta,
                Transferencia = cobro.Transferencia,
                Vale = cobro.Vale,
                TotalRecibido = cobro.TotalRecibido,
                Cambio = cobro.Cambio
            };

            

            return venta;
        }

        private void GuardarEncabezadoVenta()
        {

        }

        private void GuardarDetalleVenta()
        {

        }

        private void GuardarMovimientosStock()
        {

        }

        private void GuardarPagoVenta()
        {

        }

        private void ActualizarConsecutivoVenta()
        {

        }

        private void LimpiarVenta()
        {
            detalleVenta.Clear();

            dgvDetalleVenta.Rows.Clear();

            LimpiarProductoActual();

            txtCodigoBarrasVenta.Clear();

            CalcularTotalVenta();

            txtProductoVenta.Focus();
        }

        private void btnLimpiarVenta_Click(object sender, EventArgs e)
        {
            if (detalleVenta.Count == 0 && idProductoActual == 0)
            {
                LimpiarVenta();
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Desea cancelar la venta actual?",
                "Cancelar venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                LimpiarVenta();
            }
        }

        private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (detalleVenta.Count == 0 && idProductoActual == 0)
                return;

            DialogResult r = MessageBox.Show(
                "Hay una venta en proceso.\n\n¿Desea salir y perder la venta actual?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            LimpiarVenta();
        }

        private void btnHistorialVenta_Click(object sender, EventArgs e)
        {
            using (FrmLoginTemporal login =
        new FrmLoginTemporal("Historial de ventas"))
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            FormManager.AbrirFormularioUnico<FrmHistorialVentas>();
        }

        private void dgvDetalleVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columna =
                dgvDetalleVenta.Columns[e.ColumnIndex].Name;

            switch (columna)
            {
                case "colPrecioVenta":

                    // Si la sesión actual es Administrador, no solicita autorización.
                    if (Session.NombreRol != "Administrador")
                    {
                        using (FrmLoginTemporal login =
                            new FrmLoginTemporal("Editar precio de venta"))
                        {
                            if (login.ShowDialog() != DialogResult.OK)
                                return;
                        }
                    }

                    VentaDetalle detalle = detalleVenta[e.RowIndex];

                    FrmEditarPrecioVenta frm =
                        new FrmEditarPrecioVenta();

                    frm.PrecioActual = detalle.Precio;

                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    detalle.Precio = frm.NuevoPrecio;

                    ActualizarRenglonVenta(e.RowIndex);

                    break;

                case "colCantidad":

                    dgvDetalleVenta.CurrentCell =
                        dgvDetalleVenta.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex];

                    EditarCantidad();

                    break;

                case "colDescuento":

                    dgvDetalleVenta.CurrentCell =
                        dgvDetalleVenta.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex];

                    SolicitarDescuento();

                    break;

                case "colProducto":

                    dgvDetalleVenta.CurrentCell =
                        dgvDetalleVenta.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex];

                    CambiarProductoVenta();

                    break;
            }
        }

        private void btnCatalogoProductos_Click(object sender, EventArgs e)
        {
            
            // Si el usuario ya es Administrador, entra directamente.
            if (Session.NombreRol == "Administrador")
            {
                FormManager.AbrirFormularioUnico<FrmCatalogo>();

                return;
            }

            // Cualquier otro rol solicita autorización.
            using (FrmLoginTemporal login =
                new FrmLoginTemporal("Catálogo"))
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            using (FrmCatalogo frm = new FrmCatalogo())
            {
                frm.ShowDialog();
            }
        }
    }
}
