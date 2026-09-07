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
using SPV_Client.Enums;
using SPV_Client.Helpers;
using SPV_Client.Models;
using SPV_Client.Enums;

namespace SPV_Client
{
    public partial class FrmCompras : Form
    {
        private ProductoSeleccionado _productoActual;
        private bool permiteDecimal = false;
        private bool permiteImporte = false;      // Se usará después
        private int decimalesCantidad = 0;
        private string abreviaturaMedida = "";
        private bool permiteDecimalCantidad = false;
        

        public FrmCompras()
        {
            InitializeComponent();
        }

        private void SoloNumerosDecimal(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir tecla de control (Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir números
            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir punto o coma (pero solo uno)
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // Si ya existe un separador, bloquear
                if (txt.Text.Contains(".") || txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
                return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
        }

        private void ValidarCantidadKeyPress(
    TextBox txt,
    KeyPressEventArgs e,
    bool permiteDecimal,
    int decimales)
        {
            if (permiteDecimal)
            {
                SoloNumerosDecimal(txt, e);

                if (e.Handled)
                    return;

                int punto = txt.Text.IndexOf('.');

                if (punto >= 0)
                {
                    if (txt.SelectionStart > punto)
                    {
                        int cantidadDecimales =
                            txt.Text.Substring(punto + 1).Length;

                        if (cantidadDecimales >= decimales &&
                            txt.SelectionLength == 0 &&
                            char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                    return;

                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

                       

        private decimal? ObtenerDecimal(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
                return null;

            // Normalizar: convertir coma a punto
            string valor = txt.Text.Replace(",", ".");

            if (decimal.TryParse(valor, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal resultado))
            {
                return resultado;
            }

            return null;
        }

        private void FormatearDecimal(TextBox txt)
        {
            decimal? valor = ObtenerDecimal(txt);

            if (valor == null)
            {
                txt.Text = "";
                return;
            }

            // Formato con 2 decimales y punto
            txt.Text = valor.Value.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void FormatearCantidadCompra()
        {
            decimal? valor = ObtenerDecimal(txtCantidadCompra);

            if (valor == null)
            {
                txtCantidadCompra.Text = "";
                return;
            }

            string formato = "N" + decimalesCantidad;

            txtCantidadCompra.Text =
                valor.Value.ToString(
                    formato,
                    System.Globalization.CultureInfo.InvariantCulture);
        }

        private void MostrarProductoSeleccionado(ProductoSeleccionado producto)
        {
            _productoActual = producto;

            txtBuscarProductoCompra.Text = _productoActual.Nombre;

            lblMarcaProducto.Text = _productoActual.Marca;

            lblModeloProducto.Text = _productoActual.Modelo;

            lblCodigoCompraProducto.Text = _productoActual.CodigoCompra;

            lblProveedorProducto.Text = _productoActual.Proveedor;

            lblStockActual.Text = _productoActual.StockActual.ToString("N2");

            txtPrecioCompra.Text = _productoActual.PrecioCompra.ToString("N2");

            txtPrecioVenta.Text = _productoActual.PrecioVenta.ToString("N2");

            lblPrecioVentaActual.Text = _productoActual.PrecioVenta.ToString("N2");

            lblTituloCantidadCompra.Text =
                $"Cantidad ({_productoActual.Abreviatura})";

            ConfigurarCantidadSegunUnidadCompra();
        }

        private void AbrirBuscadorProductoCompra()
        {
            using (var frm = new FrmBuscarProducto())
            {
                var result = frm.ShowDialog();

                
                if (result == DialogResult.OK && frm.ProductoSeleccionado != null)
                {
                    MostrarProductoSeleccionado(frm.ProductoSeleccionado);
                }
            }



        }

        private void BuscarProductoPorCodigoBarras(string codigo)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    p.id_producto,
    p.nombre,
    IFNULL(m.nombre_marca,'') AS marca,
    IFNULL(p.modelo,'') AS modelo,
    p.precio_compra,
    p.precio_venta,
    p.stock_actual,
    p.codigo_barras,
    p.codigo_compra,
    IFNULL(pr.nombre,'') AS proveedor,
    um.id_medida,
    um.abreviatura,
    um.permite_decimal,
    um.permite_importe,
    um.decimales
FROM productos p
LEFT JOIN marcas m ON p.id_marca = m.id_marca
LEFT JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor
INNER JOIN unidades_medida um ON p.id_medida = um.id_medida
WHERE p.codigo_barras = @codigo
LIMIT 1;";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            MessageBox.Show(
                                "Producto no encontrado.",
                                "Código de barras",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            txtBuscarProductoCompra.SelectAll();
                            txtBuscarProductoCompra.Focus();
                            return;
                        }

                        _productoActual = new ProductoSeleccionado
                        {
                            IdProducto = Convert.ToInt32(dr["id_producto"]),
                            Nombre = dr["nombre"].ToString(),
                            Marca = dr["marca"].ToString(),
                            Modelo = dr["modelo"].ToString(),
                            PrecioCompra = Convert.ToDecimal(dr["precio_compra"]),
                            PrecioVenta = Convert.ToDecimal(dr["precio_venta"]),
                            StockActual = Convert.ToDecimal(dr["stock_actual"]),
                            CodigoBarras = dr["codigo_barras"].ToString(),
                            CodigoCompra = dr["codigo_compra"].ToString(),
                            Proveedor = dr["proveedor"].ToString(),
                            IdMedida = Convert.ToInt32(dr["id_medida"]),
                            Abreviatura = dr["abreviatura"].ToString(),
                            PermiteDecimal = Convert.ToBoolean(dr["permite_decimal"]),
                            PermiteImporte = Convert.ToBoolean(dr["permite_importe"]),
                            Decimales = Convert.ToInt32(dr["decimales"])
                        };
                    }
                }
            }

            MostrarProductoSeleccionado(_productoActual);
        }

        private void ConfigurarCantidadSegunUnidadCompra()
        {
            permiteDecimalCantidad = _productoActual.PermiteDecimal;
            decimalesCantidad = _productoActual.Decimales;

            if (permiteDecimalCantidad)
            {
                txtCantidadCompra.Text = "1.000";
            }
            else
            {
                txtCantidadCompra.Text = "1";
            }

            txtCantidadCompra.Focus();
            txtCantidadCompra.SelectAll();
        }

        


        private decimal RecalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["colSubtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["colSubtotal"].Value);
                }
            }

            lblTotalCompra.Text = total.ToString("C2");

            return total;
        }

        private void LimpiarProductoActual()
        {
            txtBuscarProductoCompra.Clear();

            txtCantidadCompra.Text = "1";

            txtPrecioCompra.Clear();

            txtPrecioVenta.Clear();

            lblStockActual.Text = "";

            lblMarcaProducto.Text = "";

            lblModeloProducto.Text = "";

            lblCodigoCompraProducto.Text = "";

            lblPrecioVentaActual.Text = "";

            lblProveedorProducto.Text = "";

            lblTituloCantidadCompra.Text = "Cantidad";

            _productoActual = null;

            txtBuscarProductoCompra.Focus();
        }

        private void LimpiarFormulario()
        {
            dgvDetalleCompra.Rows.Clear();

            txtBuscarProductoCompra.Text = "";
            txtCantidadCompra.Text = "1";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtFacturaProveedor.Text = "";

            lblStockActual.Text = "";
            lblMarcaProducto.Text = "";
            lblModeloProducto.Text = "";
            lblCodigoCompraProducto.Text = "";
            lblPrecioVentaActual.Text = "";
            lblProveedorProducto.Text = "";
            lblGanancia.Text = "---";
            

            cmbProveedor.SelectedIndex = -1;

            lblTotalCompra.Text = "$0.00";
            lblFolioCompra.Text = "N-CMP-PENDIENTE";

            _productoActual = null;

            txtBuscarProductoCompra.Focus();
        }

        private void CalcularGanancia()
        {
            decimal? precioCompra = ObtenerDecimal(txtPrecioCompra);
            decimal? precioVenta = ObtenerDecimal(txtPrecioVenta);

            if (precioCompra == null || precioVenta == null)
            {
                lblGanancia.Text = "---";
                return;
            }

            // Evitar división por cero
            if (precioCompra <= 0)
            {
                lblGanancia.Text = "---";
                return;
            }

            // Calcular porcentaje de ganancia
            
            decimal ganancia = ((precioVenta.Value - precioCompra.Value) / precioCompra.Value) * 100;

            // Mostrar con 2 decimales
            lblGanancia.Text = Math.Round(ganancia, 2) + " %";
        }
        private void CargarProveedores()
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();

                string sql = "SELECT id_proveedor, nombre FROM proveedores ORDER BY nombre";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProveedor.DataSource = dt;
                    cmbProveedor.DisplayMember = "nombre";
                    cmbProveedor.ValueMember = "id_proveedor";
                    cmbProveedor.SelectedIndex = -1; // Ninguno seleccionado
                }
            }
        }



        private void lblStockActual_Click(object sender, EventArgs e)
        {

        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += FrmCompras_KeyDown;
            timerReloj.Start();
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblUsuarioActivo.Text = Session.NombreUsuario;

            txtFacturaProveedor.Text = "";
                                 

            CargarProveedores();
            MostrarProximoFolio();


        }

       

        private bool _buscadorAbierto = false;

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
WHERE tipo = 'COMPRA';
";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int siguiente = Convert.ToInt32(result);

                            lblFolioCompra.Text = $"PRÓXIMO: CMP-{siguiente.ToString("D6")}";
                        }
                        else
                        {
                            lblFolioCompra.Text = "CMP-SIN-FOLIO";
                        }
                    }
                }
            }
            catch
            {
                lblFolioCompra.Text = "ERROR-FOLIO";
            }
        }



        private void txtBuscarProductoCompra_DoubleClick(object sender, EventArgs e)
        {

            AbrirBuscadorProductoCompra();
            
        }


        private void FrmCompras_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.Handled = true;
                    AbrirBuscadorProductoCompra();
                    break;

                case Keys.F3:
                    e.Handled = true;
                    CambiarProductoCompra();
                    break;

                case Keys.F4:
                    e.Handled = true;
                    EditarCantidadCompra();
                    break;

                case Keys.F5:
                    e.Handled = true;
                    AbrirItemProducto();
                    break;
            }
        }

        private void AbrirItemProducto()
        {
            if (dgvDetalleCompra.CurrentRow == null)
                return;

            int filaSeleccionada =
                dgvDetalleCompra.CurrentRow.Index;

            int idProducto = Convert.ToInt32(
                dgvDetalleCompra.Rows[filaSeleccionada]
                .Cells["IdProducto"].Value);

            FrmItem frm = new FrmItem();

            frm.IdProducto = idProducto;

            frm.ModoApertura =
                ModoAperturaItem.Consulta;

            frm.ShowDialog();

            ActualizarProductoDesdeBaseDeDatos(
                filaSeleccionada,
                idProducto);
        }

        private void ActualizarProductoDesdeBaseDeDatos(
    int fila,
    int idProducto)
        {
            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT
    nombre,
    modelo,
    precio_compra,
    codigo_compra
FROM productos
WHERE id_producto = @idProducto;";

                using (MySqlCommand cmd =
                    new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@idProducto",
                        idProducto);

                    using (MySqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return;

                        DataGridViewRow row =
                            dgvDetalleCompra.Rows[fila];

                        decimal precioCompra =
                            Convert.ToDecimal(
                                reader["precio_compra"]);

                        decimal cantidad =
                            Convert.ToDecimal(
                                row.Cells["colCantidad"].Value);

                        decimal subtotal =
                            cantidad * precioCompra;

                        row.Cells["colProducto"].Value =
                            reader["nombre"].ToString();

                        row.Cells["Modelo"].Value =
                            reader["modelo"] == DBNull.Value
                                ? ""
                                : reader["modelo"].ToString();

                        row.Cells["Precio_compra"].Value =
                            precioCompra;

                        row.Cells["colSubtotal"].Value =
                            subtotal;
                        RecalcularTotal();

                        row.Cells["CodigoCompra"].Value =
                            reader["codigo_compra"] == DBNull.Value
                                ? ""
                                : reader["codigo_compra"].ToString();
                    }
                }
            }
        }

        private void EditarCantidadCompra()
        {
            if (dgvDetalleCompra.CurrentRow == null)
                return;

            int fila = dgvDetalleCompra.CurrentRow.Index;

            string producto =
                dgvDetalleCompra.Rows[fila]
                .Cells["colProducto"].Value.ToString();

            decimal cantidad =
                Convert.ToDecimal(
                    dgvDetalleCompra.Rows[fila]
                    .Cells["colCantidad"].Value);

            bool permiteDecimal =
                Convert.ToBoolean(
                    dgvDetalleCompra.Rows[fila]
                    .Cells["colPermiteDecimal"].Value);

            int decimales =
                Convert.ToInt32(
                    dgvDetalleCompra.Rows[fila]
                    .Cells["colDecimales"].Value);

            using (FrmEditarCantidad frm =
                new FrmEditarCantidad(
                    producto,
                    cantidad,
                    permiteDecimal,
                    decimales))
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                decimal nuevaCantidad = frm.NuevaCantidad;

                dgvDetalleCompra.Rows[fila]
                    .Cells["colCantidad"].Value = nuevaCantidad;

                decimal precioCompra =
                    Convert.ToDecimal(
                        dgvDetalleCompra.Rows[fila]
                        .Cells["Precio_compra"].Value);

                dgvDetalleCompra.Rows[fila]
                    .Cells["colSubtotal"].Value =
                    nuevaCantidad * precioCompra;

                RecalcularTotal();
            }
        }

        private void dgvDetalleCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columna =
                dgvDetalleCompra.Columns[e.ColumnIndex].Name;

            switch (columna)
            {
                case "colProducto":

                    dgvDetalleCompra.CurrentCell =
                        dgvDetalleCompra.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex];

                    CambiarProductoCompra();

                    break;

                case "colCantidad":

                    dgvDetalleCompra.CurrentCell =
                        dgvDetalleCompra.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex];

                    EditarCantidadCompra();

                    break;
            }
        }

        private void CambiarProductoCompra()
        {
            if (dgvDetalleCompra.CurrentRow == null)
                return;

            int fila = dgvDetalleCompra.CurrentRow.Index;

            decimal cantidad =
                Convert.ToDecimal(
                    dgvDetalleCompra.Rows[fila]
                    .Cells["colCantidad"].Value);

            using (FrmBuscarProducto frm = new FrmBuscarProducto())
            {
                if (frm.ShowDialog() != DialogResult.OK)
                    return;

                if (frm.ProductoSeleccionado == null)
                    return;

                ProductoSeleccionado nuevoProducto = frm.ProductoSeleccionado;

                // Verificar si el producto ya existe en otro renglón
                foreach (DataGridViewRow r in dgvDetalleCompra.Rows)
                {
                    if (r.IsNewRow)
                        continue;

                    if (r.Index == fila)
                        continue;

                    int id =
                        Convert.ToInt32(r.Cells["IdProducto"].Value);

                    if (id == nuevoProducto.IdProducto)
                    {
                        MessageBox.Show(
                            "Ese producto ya existe en la compra.\n\n" +
                            "Edite la cantidad del renglón existente.",
                            "Producto duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }
                }

                dgvDetalleCompra.Rows[fila].Cells["IdProducto"].Value =
    nuevoProducto.IdProducto;

                dgvDetalleCompra.Rows[fila].Cells["colProducto"].Value =
                    nuevoProducto.Nombre;

                dgvDetalleCompra.Rows[fila].Cells["Modelo"].Value =
                    nuevoProducto.Modelo;

                dgvDetalleCompra.Rows[fila].Cells["CodigoCompra"].Value =
                    nuevoProducto.CodigoCompra;

                dgvDetalleCompra.Rows[fila].Cells["Precio_compra"].Value =
                    nuevoProducto.PrecioCompra;

                dgvDetalleCompra.Rows[fila].Cells["colIdMedida"].Value =
                    nuevoProducto.IdMedida;

                dgvDetalleCompra.Rows[fila].Cells["colPermiteDecimal"].Value =
                    nuevoProducto.PermiteDecimal;

                dgvDetalleCompra.Rows[fila].Cells["colDecimales"].Value =
                    nuevoProducto.Decimales;

                decimal subtotal = cantidad * nuevoProducto.PrecioCompra;

                dgvDetalleCompra.Rows[fila].Cells["colSubtotal"].Value =
                    subtotal;

                RecalcularTotal();

            }
        }

        private void btnAgregarProductoCompra_Click(object sender, EventArgs e)
        {
            // Validar que haya producto seleccionado
            if (_productoActual == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            // Validar cantidad
            decimal? cantidad = ObtenerDecimal(txtCantidadCompra);

            if (cantidad == null || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            // Validar precio compra
            decimal? precioCompra = ObtenerDecimal(txtPrecioCompra);

            if (precioCompra == null || precioCompra <= 0)
            {
                MessageBox.Show("Precio de compra inválido.");
                return;
            }

            // 🔍 BUSCAR SI YA EXISTE EN EL GRID
            foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
            {
                if (fila.IsNewRow) continue;

                int id = Convert.ToInt32(fila.Cells["IdProducto"].Value);

                if (id == _productoActual.IdProducto)
                {
                    // ✔ YA EXISTE → SUMAR CANTIDAD
                    decimal cantidadActual = Convert.ToDecimal(fila.Cells["colCantidad"].Value);
                    cantidadActual += cantidad.Value;

                    fila.Cells["colCantidad"].Value = cantidadActual;

                    decimal nuevoSubtotal = cantidadActual * precioCompra.Value;
                    fila.Cells["colSubtotal"].Value = nuevoSubtotal;

                    RecalcularTotal();

                    // Limpiar
                    LimpiarProductoActual();

                    return; // 🔥 IMPORTANTE: salir aquí
                }
            }

            // 🚀 SI NO EXISTE → AGREGAR NUEVA FILA
            decimal subtotal = cantidad.Value * precioCompra.Value;

            dgvDetalleCompra.Rows.Add(
                _productoActual.IdProducto,
                _productoActual.Nombre,
                cantidad,
                precioCompra,
                subtotal,
                _productoActual.Modelo,
                _productoActual.CodigoCompra,

                _productoActual.IdMedida,
                _productoActual.PermiteDecimal,
                _productoActual.Decimales
            );

            RecalcularTotal();

            // Limpiar
            LimpiarProductoActual();
        }

        private void dgvDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarProductoCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDetalleCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string col = dgvDetalleCompra.Columns[e.ColumnIndex].Name;

            if (col == "colCantidad" || col == "Precio_Compra")
            {
                DataGridViewRow fila = dgvDetalleCompra.Rows[e.RowIndex];

                if (fila.Cells["colCantidad"].Value == null || fila.Cells["Precio_Compra"].Value == null)
                    return;

                decimal cantidad = Convert.ToDecimal(fila.Cells["colCantidad"].Value);
                decimal precio = Convert.ToDecimal(fila.Cells["Precio_Compra"].Value);

                decimal subtotal = cantidad * precio;

                fila.Cells["colSubtotal"].Value = subtotal;

                RecalcularTotal();
            }
        }

        private void dgvDetalleCompra_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string col = dgvDetalleCompra.Columns[e.ColumnIndex].Name;

            if (col == "colCantidad" || col == "Precio_Compra")
            {
                string valor = e.FormattedValue.ToString();

                decimal numero;

                if (!decimal.TryParse(valor, out numero))
                {
                    MessageBox.Show("Solo se permiten números");
                    e.Cancel = true;
                    return;
                }

                if (numero <= 0)
                {
                    MessageBox.Show("El valor debe ser mayor a 0");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void dgvDetalleCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           // dgvDetalleCompra.ReadOnly = true;
            //dgvDetalleCompra.Columns["colCantidad"].ReadOnly = false;
        }

        private void dgvDetalleCompra_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            RecalcularTotal();
        }

        private void dgvDetalleCompra_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RecalcularTotal();
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            CalcularGanancia();
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            CalcularGanancia();
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosDecimal(sender, e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosDecimal(sender, e);
        }

        private void txtCantidadCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCantidadKeyPress(
               txtCantidadCompra,
               e,
               permiteDecimalCantidad,
               decimalesCantidad);
        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            FormatearDecimal(txtPrecioCompra);
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            FormatearDecimal(txtPrecioVenta);
        }

        private void txtCantidadCompra_Leave(object sender, EventArgs e)
        {
            FormatearCantidadCompra();
        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            bool hayProductos = false;

            foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
            {
                if (!fila.IsNewRow)
                {
                    hayProductos = true;
                    break;
                }
            }

            if (!hayProductos)
            {
                MessageBox.Show("No hay productos en la compra.");
                return;
            }

            if (cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un proveedor.");
                return;
            }

            foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells["colCantidad"].Value == null ||
                    fila.Cells["Precio_compra"].Value == null ||
                    fila.Cells["colSubtotal"].Value == null)
                {
                    MessageBox.Show("Hay filas incompletas en la compra.");
                    return;
                }

                decimal cantidad = Convert.ToDecimal(fila.Cells["colCantidad"].Value);
                decimal precio = Convert.ToDecimal(fila.Cells["Precio_compra"].Value);

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0.");
                    return;
                }

                if (precio <= 0)
                {
                    MessageBox.Show("El precio de compra debe ser mayor a 0.");
                    return;
                }
            }
           

            // 🔴 AHORA SÍ bloqueas el botón (DESPUÉS de validar)
            btnGuardarCompra.Enabled = false;

            using (var conn = DB.GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // FOLIO
                        string sqlFolio = @"
UPDATE folios 
SET ultimo_consecutivo = ultimo_consecutivo + 1 
WHERE tipo = 'COMPRA';

SELECT ultimo_consecutivo FROM folios WHERE tipo = 'COMPRA';
";

                        int consecutivo;

                        using (var cmdFolio = new MySqlCommand(sqlFolio, conn, transaction))
                        {
                            consecutivo = Convert.ToInt32(cmdFolio.ExecuteScalar());
                        }

                        string folio = $"CMP-{consecutivo.ToString("D6")}";

                        lblFolioCompra.Text = folio;

                        // COMPRA
                        string sqlCompra = @"
INSERT INTO compras 
(id_usuario, id_usuario_autoriza, id_proveedor, total, estado, folio)
VALUES (@id_usuario, @id_usuario_autoriza, @id_proveedor, @total, 'ACTIVA', @folio);

SELECT LAST_INSERT_ID();
";

                        int idCompra;

                        decimal totalCompra = RecalcularTotal();

                        using (var cmdCompra = new MySqlCommand(sqlCompra, conn, transaction))
                        {
                            cmdCompra.Parameters.AddWithValue("@id_usuario", Session.IdUsuario);
                            if (Session.IdUsuarioAutoriza == 0)
                            {
                                cmdCompra.Parameters.AddWithValue("@id_usuario_autoriza", DBNull.Value);
                            }
                            else
                            {
                                cmdCompra.Parameters.AddWithValue("@id_usuario_autoriza", Session.IdUsuarioAutoriza);
                            }
                            cmdCompra.Parameters.AddWithValue("@id_proveedor", cmbProveedor.SelectedValue);

                            //decimal totalCompra = RecalcularTotal();
                            cmdCompra.Parameters.AddWithValue("@total", totalCompra);

                            cmdCompra.Parameters.AddWithValue("@folio", folio);

                            idCompra = Convert.ToInt32(cmdCompra.ExecuteScalar());
                        }

                        // DETALLE + STOCK
                        foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
                        {
                            if (fila.IsNewRow) continue;

                            int idProducto = Convert.ToInt32(fila.Cells["idProducto"].Value);
                            decimal cantidad = Convert.ToDecimal(fila.Cells["colCantidad"].Value);
                            decimal precio = Convert.ToDecimal(fila.Cells["Precio_compra"].Value);
                            decimal subtotal = Convert.ToDecimal(fila.Cells["colSubtotal"].Value);

                            string sqlDetalle = @"
INSERT INTO compras_detalle 
(id_compra, id_producto, cantidad, precio_compra, subtotal)
VALUES (@id_compra, @id_producto, @cantidad, @precio, @subtotal)";

                            using (var cmdDetalle = new MySqlCommand(sqlDetalle, conn, transaction))
                            {
                                cmdDetalle.Parameters.AddWithValue("@id_compra", idCompra);
                                cmdDetalle.Parameters.AddWithValue("@id_producto", idProducto);
                                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                                cmdDetalle.Parameters.AddWithValue("@precio", precio);
                                cmdDetalle.Parameters.AddWithValue("@subtotal", subtotal);

                                cmdDetalle.ExecuteNonQuery();
                            }

                         

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
    'ENTRADA',
    @cantidad,
    @descripcion,
    @id_compra
);";

                            using (var cmdMovimiento = new MySqlCommand(sqlMovimiento, conn, transaction))
                            {
                                cmdMovimiento.Parameters.AddWithValue("@id_producto", idProducto);

                                cmdMovimiento.Parameters.AddWithValue("@id_usuario", Session.IdUsuario);

                                cmdMovimiento.Parameters.AddWithValue("@cantidad", cantidad);

                                cmdMovimiento.Parameters.AddWithValue(
                                    "@descripcion",
                                    "Compra Registrada");

                                cmdMovimiento.Parameters.AddWithValue("@id_compra", idCompra);

                                cmdMovimiento.ExecuteNonQuery();
                            }
                            string sqlActualizarFechaCompra = @"
UPDATE productos
SET fecha_compra = CURDATE()
WHERE id_producto = @id_producto;";

                            using (var cmdFechaCompra =
                                new MySqlCommand(sqlActualizarFechaCompra, conn, transaction))
                            {
                                cmdFechaCompra.Parameters.AddWithValue(
                                    "@id_producto",
                                    idProducto);

                                cmdFechaCompra.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        CompraReimpresion compra = new CompraReimpresion();

                        compra.Folio = folio;
                        compra.Fecha = DateTime.Now;
                        compra.Usuario = Session.NombreUsuario;

                        compra.Autorizo =
                            string.IsNullOrWhiteSpace(Session.NombreUsuarioAutoriza)
                            ? "N/A"
                            : Session.NombreUsuarioAutoriza;

                        compra.Proveedor = cmbProveedor.Text;
                        compra.Total = totalCompra;

                        foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
                        {
                            if (fila.IsNewRow)
                                continue;

                            compra.Detalle.Add(new CompraDetalleReimpresion
                            {
                                Producto = fila.Cells["colProducto"].Value.ToString(),

                                Cantidad = Convert.ToDecimal(
                                    fila.Cells["colCantidad"].Value),

                                PrecioCompra = Convert.ToDecimal(
                                    fila.Cells["Precio_compra"].Value),

                                Subtotal = Convert.ToDecimal(
                                    fila.Cells["colSubtotal"].Value)
                            });
                        }

                        FrmTicketCompra frmTicket = new FrmTicketCompra(compra);
                        frmTicket.EsReimpresion = false;
                        frmTicket.ShowDialog();

                        

                        // LIMPIEZA SOLO SI TODO SALE BIEN

                        LimpiarFormulario();
                        MostrarProximoFolio();

                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch
                        {
                            // ignorar si ya no existe la transacción
                        }

                        MessageBox.Show(
                            ex.ToString(),
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    /*catch (Exception ex)
                     {
                         transaction.Rollback();
                         MessageBox.Show("Error al guardar: " + ex.Message);
                     }*/
                    finally
                    {
                        btnGuardarCompra.Enabled = true;
                    }
                }
            }
        }

        /*private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            bool hayDatos = false;

            foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
            {
                if (!fila.IsNewRow)
                {
                    hayDatos = true;
                    break;
                }
            }

            if (hayDatos)
            {
                var r = MessageBox.Show(
                    "¿Deseas cancelar la compra actual?\nSe perderán los datos capturados.",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (r != DialogResult.Yes)
                    return;
            }

            LimpiarFormulario();
        }*/

        private void FrmCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool hayDatos = false;

            foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
            {
                if (!fila.IsNewRow)
                {
                    hayDatos = true;
                    break;
                }
            }

            if (hayDatos)
            {
                var r = MessageBox.Show(
                    "Tienes una compra en proceso.\n¿Deseas salir sin guardar?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (r != DialogResult.Yes)
                {
                    e.Cancel = true; // 🔥 ESTO BLOQUEA EL CIERRE
                }
            }
        }

        private void btnCancelarCaptura_Click(object sender, EventArgs e)
        {
            bool hayDatos = false;

            foreach (DataGridViewRow fila in dgvDetalleCompra.Rows)
            {
                if (!fila.IsNewRow)
                {
                    hayDatos = true;
                    break;
                }
            }

            if (hayDatos)
            {
                var r = MessageBox.Show(
                    "¿Deseas cancelar la compra actual?\nSe perderán los datos capturados.",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (r != DialogResult.Yes)
                    return;
            }

            LimpiarFormulario();
        }

        private void btnHistorialCompra_Click(object sender, EventArgs e)
        {
            FormManager.AbrirFormularioUnico<FrmHistorialCompras>();
        }

        private void btnLimpiarProductoCompra_Click(object sender, EventArgs e)
        {
            LimpiarProductoActual();
        }

        private void txtBuscarProductoCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;

            string texto = txtBuscarProductoCompra.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
                return;

            // Si contiene alguna letra, usar el buscador normal
            if (texto.Any(char.IsLetter))
            {
                AbrirBuscadorProductoCompra();
                return;
            }

            // Si llega aquí, probablemente es un código de barras
            BuscarProductoPorCodigoBarras(texto);
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"COMPRAS

F2
Buscar producto.

ENTER
Seleccionar producto.

DOBLE CLICK EN PRODUCTO O F2 (con producto seleccionado)
Abre buscador, Cambia Producto sin eliminar.

DOBLE CLICK EN CANTIDAD O F4 (con producto seleccionado)
Editar Cantidad.

F5 ABRIR ITEM DEL PRODUCTO (con producto seleccionado)
Abre Item del producto.

BOTON GUARDAR
Guardar compra.

SUPRIMIR
Con producto seleccionado quita producto agregado.



➤➥¡NO OLVIDES AGREGAR PROVEEDOR Y NUMERO DE TICKET O FACTURA!",

"Información",
MessageBoxButtons.OK,
MessageBoxIcon.Information);
        }
    }
}
