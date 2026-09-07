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

namespace SPV_Client
{
    public partial class FrmItem : Form
    {

        private int idProducto = 0;
        private bool modoEdicion = false;
        private bool calculandoPrecio = false;
        private bool hayCambios = false;
        private bool edicionHabilitada = false;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }  
            
        }

        public ModoAperturaItem ModoApertura { get; set; }

        public FrmItem()
        {
            InitializeComponent();
            
        }

        private void LimpiarFormulario()
        {
            //idProducto = 0;

            //modoEdicion = false;

            //hayCambios = false;

            txtProducto.Clear();

            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;

            txtModelo.Clear();

            cmbUnidad.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            cmbSocio.SelectedIndex = -1;

            txtStockActual.Text = "0";
            txtStockMinimo.Text = "0";

            dtpFechaCompra.Value = DateTime.Today;

            txtCodigoCompra.Clear();

            txtPrecioCompra.Text = "0.00";
            txtPrecioVenta.Text = "0.00";

            txtPorcentajeGanancia.Text = "0";

            txtCodigoBarras.Clear();

            cmbActivo.SelectedIndex = 0;

            txtObservaciones.Clear();

            
            btnDesactivarItem.Enabled = false;
            btnKardexItem.Enabled = false;

            chkPermiteVentaImporte.Checked = false;

            txtProducto.Focus();
        }



        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show(
                    "Debe capturar el nombre del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtProducto.Focus();
                return false;
            }

            if (!modoEdicion)
            {
                if (ExisteProducto(txtProducto.Text.Trim()))
                {
                    MessageBox.Show(
                        "Ya existe un producto con ese nombre.",
                        "Producto duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtProducto.Focus();

                    return false;
                }
            }

            if (cmbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar una categoría.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategoria.Focus();
                return false;
            }

            if (cmbMarca.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar una marca.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbMarca.Focus();
                return false;
            }

            if (cmbUnidad.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar una unidad de medida.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbUnidad.Focus();
                return false;
            }

            if (cmbProveedor.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un proveedor.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbProveedor.Focus();
                return false;
            }

            if (cmbSocio.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un socio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbSocio.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra) ||
                precioCompra <= 0)
            {
                MessageBox.Show(
                    "El precio de compra debe ser mayor a cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrecioCompra.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta) ||
                precioVenta <= 0)
            {
                MessageBox.Show(
                    "El precio de venta debe ser mayor a cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrecioVenta.Focus();
                return false;
            }

            return true;
        }

        private bool ExisteProducto(string nombre)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT COUNT(*)
                FROM productos
                WHERE UPPER(nombre)=UPPER(@nombre)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        int cantidad =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        return cantidad > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private bool GuardarProducto()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
INSERT INTO productos
(
    nombre,
    id_marca,
    modelo,
    codigo_compra,
    id_medida,
    permite_venta_importe,
    precio_compra,
    precio_venta,
    codigo_barras,
    fecha_compra,
    id_socio,
    stock_actual,
    id_proveedor,
    id_categoria,
    activo,
    stock_minimo,
    observaciones
)
VALUES
(
    @nombre,
    @id_marca,
    @modelo,
    @codigo_compra,
    @id_medida,
    @permite_venta_importe,
    @precio_compra,
    @precio_venta,
    @codigo_barras,
    @fecha_compra,
    @id_socio,
    0,
    @id_proveedor,
    @id_categoria,
    1,
    @stock_minimo,
    @observaciones
)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre",
                            txtProducto.Text.Trim());

                        cmd.Parameters.AddWithValue("@id_marca",
                            cmbMarca.SelectedValue);

                        cmd.Parameters.AddWithValue("@modelo",
                            txtModelo.Text.Trim());

                        cmd.Parameters.AddWithValue(
    "@codigo_compra",
    string.IsNullOrWhiteSpace(txtCodigoCompra.Text)
        ? (object)DBNull.Value
        : txtCodigoCompra.Text.Trim());

                        cmd.Parameters.AddWithValue("@id_medida",
                            cmbUnidad.SelectedValue);
                        
                        cmd.Parameters.AddWithValue(
                                "@permite_venta_importe",
                                chkPermiteVentaImporte.Checked);

                        cmd.Parameters.AddWithValue("@precio_compra",
                            Convert.ToDecimal(txtPrecioCompra.Text));

                        cmd.Parameters.AddWithValue("@precio_venta",
                            Convert.ToDecimal(txtPrecioVenta.Text));

                        cmd.Parameters.AddWithValue(
    "@codigo_barras",
    string.IsNullOrWhiteSpace(txtCodigoBarras.Text)
        ? (object)DBNull.Value
        : txtCodigoBarras.Text.Trim());

                        cmd.Parameters.AddWithValue("@fecha_compra",
                            dtpFechaCompra.Value.Date);

                        cmd.Parameters.AddWithValue("@id_socio",
                            cmbSocio.SelectedValue);

                        cmd.Parameters.AddWithValue("@id_proveedor",
                            cmbProveedor.SelectedValue);

                        cmd.Parameters.AddWithValue("@id_categoria",
                            cmbCategoria.SelectedValue);

                        cmd.Parameters.AddWithValue("@stock_minimo",
                            Convert.ToDecimal(txtStockMinimo.Text));

                        cmd.Parameters.AddWithValue("@observaciones",
                            txtObservaciones.Text.Trim());

                        cmd.ExecuteNonQuery();

                        idProducto =
                            Convert.ToInt32(cmd.LastInsertedId);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        private void CalcularGanancia()
        {
            if (calculandoPrecio) return;

            try
            {
                calculandoPrecio = true;

                if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra))
                    return;

                if (!decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta))
                    return;

                if (precioCompra <= 0)
                    return;

                decimal porcentaje =
                    ((precioVenta - precioCompra) / precioCompra) * 100;

                txtPorcentajeGanancia.Text =
                    porcentaje.ToString("N2");
            }
            finally
            {
                calculandoPrecio = false;
            }
        }

        private void CalcularPrecioVenta()
        {
            if (calculandoPrecio) return;

            try
            {
                calculandoPrecio = true;

                if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra))
                    return;

                if (!decimal.TryParse(txtPorcentajeGanancia.Text, out decimal porcentaje))
                    return;

                decimal precioVenta =
                    precioCompra + (precioCompra * porcentaje / 100);

                txtPrecioVenta.Text =
                    precioVenta.ToString("N2");
            }
            finally
            {
                calculandoPrecio = false;
            }
        }

        private void MarcarCambios(object sender, EventArgs e)
        {
            hayCambios = true;
        }

        private void CargarCombos()
        {
            CargarCategorias();
            CargarMarcas();
            CargarUnidades();
            CargarProveedores();
            CargarSocios();
        }

        private void CargarCategorias()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT id_categoria, nombre
                FROM categorias
                WHERE activo = 1
                ORDER BY nombre";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCategoria.DataSource = dt;
                        cmbCategoria.DisplayMember = "nombre";
                        cmbCategoria.ValueMember = "id_categoria";
                        cmbCategoria.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar categorías",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarMarcas()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT id_marca, nombre_marca
                FROM marcas
                WHERE activo = 1
                ORDER BY nombre_marca";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbMarca.DataSource = dt;
                        cmbMarca.DisplayMember = "nombre_marca";
                        cmbMarca.ValueMember = "id_marca";
                        cmbMarca.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar marcas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarUnidades()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT id_medida, nombre_medida
                FROM unidades_medida
                WHERE activo = 1
                ORDER BY nombre_medida";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbUnidad.DataSource = dt;
                        cmbUnidad.DisplayMember = "nombre_medida";
                        cmbUnidad.ValueMember = "id_medida";
                        cmbUnidad.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar unidades",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT id_proveedor, nombre
                FROM proveedores
                WHERE estado = 1
                ORDER BY nombre";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbProveedor.DataSource = dt;
                        cmbProveedor.DisplayMember = "nombre";
                        cmbProveedor.ValueMember = "id_proveedor";
                        cmbProveedor.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar proveedores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarSocios()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT id_socio, nombre_socio
                FROM socios
                WHERE activo = 1
                ORDER BY nombre_socio";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbSocio.DataSource = dt;
                        cmbSocio.DisplayMember = "nombre_socio";
                        cmbSocio.ValueMember = "id_socio";
                        cmbSocio.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar socios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            CargarCombos();

            txtStockActual.ReadOnly = true;

            LimpiarFormulario();

            edicionHabilitada = ModoApertura != ModoAperturaItem.Consulta;

            if (idProducto > 0)
            {
                CargarProducto();
                dtpFechaCompra.Enabled = false;
            }

            ConfigurarModoEdicion();

            txtProducto.TextChanged += MarcarCambios;
            txtModelo.TextChanged += MarcarCambios;
            txtCodigoCompra.TextChanged += MarcarCambios;
            txtPrecioCompra.TextChanged += MarcarCambios;
            txtPrecioVenta.TextChanged += MarcarCambios;
            txtPorcentajeGanancia.TextChanged += MarcarCambios;
            txtCodigoBarras.TextChanged += MarcarCambios;
            txtObservaciones.TextChanged += MarcarCambios;

            cmbCategoria.SelectedIndexChanged += MarcarCambios;
            cmbMarca.SelectedIndexChanged += MarcarCambios;
            cmbUnidad.SelectedIndexChanged += MarcarCambios;
            cmbProveedor.SelectedIndexChanged += MarcarCambios;
            cmbSocio.SelectedIndexChanged += MarcarCambios;
            cmbActivo.SelectedIndexChanged += MarcarCambios;

            dtpFechaCompra.ValueChanged += MarcarCambios;

        }

        private void HabilitarEdicion()
        {
            txtProducto.Enabled = true;

            cmbCategoria.Enabled = true;
            cmbMarca.Enabled = true;

            txtModelo.Enabled = true;

            cmbUnidad.Enabled = true;
            cmbProveedor.Enabled = true;
            cmbSocio.Enabled = true;

            txtStockMinimo.Enabled = true;

            txtCodigoCompra.Enabled = true;

            txtPrecioCompra.Enabled = true;
            txtPrecioVenta.Enabled = true;

            txtPorcentajeGanancia.Enabled = true;

            txtCodigoBarras.Enabled = true;

            cmbActivo.Enabled = true;

            txtObservaciones.Enabled = true;

            chkPermiteVentaImporte.Enabled = true;

            btnGuardarItem.Enabled = true;

            btnNuevoItem.Enabled = true;

            btnDesactivarItem.Enabled = true;

            btnHabilitarEdicion.Enabled = false;
        }

        private void ConfigurarModoEdicion()
        {
            bool permitirEdicion = edicionHabilitada;

            txtProducto.Enabled = permitirEdicion;

            cmbCategoria.Enabled = permitirEdicion;
            cmbMarca.Enabled = permitirEdicion;

            txtModelo.Enabled = permitirEdicion;

            cmbUnidad.Enabled = permitirEdicion;
            cmbProveedor.Enabled = permitirEdicion;
            cmbSocio.Enabled = permitirEdicion;

            txtStockMinimo.Enabled = permitirEdicion;

            dtpFechaCompra.Enabled = permitirEdicion;

            txtCodigoCompra.Enabled = permitirEdicion;

            txtPrecioCompra.Enabled = permitirEdicion;
            txtPrecioVenta.Enabled = permitirEdicion;

            txtPorcentajeGanancia.Enabled = permitirEdicion;

            txtCodigoBarras.Enabled = permitirEdicion;

            cmbActivo.Enabled = permitirEdicion;

            txtObservaciones.Enabled = permitirEdicion;

            chkPermiteVentaImporte.Enabled = permitirEdicion;

            btnGuardarItem.Enabled = permitirEdicion;

            btnNuevoItem.Enabled = permitirEdicion;

            btnHabilitarEdicion.Visible =
                ModoApertura == ModoAperturaItem.Consulta && !edicionHabilitada;
        }

        private void PrepararNuevoProducto()
        {
            idProducto = 0;

            modoEdicion = false;

            hayCambios = false;

            LimpiarFormulario();

            btnGuardarItem.Enabled = true;

            txtProducto.Focus();
        }

        private void BloquearEdicion()
        {
            txtProducto.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtCodigoCompra.ReadOnly = true;
            txtPrecioCompra.ReadOnly = true;
            txtPrecioVenta.ReadOnly = true;
            txtPorcentajeGanancia.ReadOnly = true;
            txtCodigoBarras.ReadOnly = true;
            txtObservaciones.ReadOnly = true;

            txtStockActual.ReadOnly = true;
            txtStockMinimo.ReadOnly = true;

            cmbCategoria.Enabled = false;
            cmbMarca.Enabled = false;
            cmbUnidad.Enabled = false;
            cmbProveedor.Enabled = false;
            cmbSocio.Enabled = false;
            cmbActivo.Enabled = false;

            dtpFechaCompra.Enabled = false;

            chkPermiteVentaImporte.Enabled = false;

            btnGuardarItem.Enabled = false;
            btnNuevoItem.Enabled = false;

            btnDesactivarItem.Enabled = false;

            btnHabilitarEdicion.Enabled = true;
            btnHabilitarEdicion.Visible = true;
        }

        

        private void btnNuevoItem_Click(object sender, EventArgs e)
        {
            PrepararNuevoProducto();

            //LimpiarFormulario();
            /*idProducto = 0;

            modoEdicion = false;

            hayCambios = false;

            LimpiarFormulario();

            btnGuardarItem.Enabled = true;

            txtProducto.Focus();*/
        }

        private void btnGuardarItem_Click(object sender, EventArgs e)
        {
            btnGuardarItem.Enabled = false;

            if (!ValidarFormulario())
            {
                btnGuardarItem.Enabled = true;
                return;
            }

            string mensaje;

            if (modoEdicion)
            {
                mensaje =
                    "¿Desea actualizar los cambios del producto?";
            }
            else
            {
                mensaje =
                    "¿Desea guardar el nuevo producto?";
            }

            DialogResult respuesta =
                MessageBox.Show(
                    mensaje,
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                btnGuardarItem.Enabled = true;
                return;
            }

            bool resultado = false;

            if (idProducto > 0)
            {
                resultado = ActualizarProducto();
            }
            else
            {
                resultado = GuardarProducto();
            }

            if (resultado)
            {
                hayCambios = false;

                MessageBox.Show(
                    modoEdicion
                        ? "Producto actualizado correctamente."
                        : "Producto guardado correctamente.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnDesactivarItem.Enabled = true;
                btnKardexItem.Enabled = true;

                modoEdicion = true;

                btnGuardarItem.Enabled = true; // AGREGAR
            }
            else
            {
                btnGuardarItem.Enabled = true; // AGREGAR
            
            }
        }

        private bool ActualizarProducto()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE productos
SET
    nombre = @nombre,
    id_marca = @id_marca,
    modelo = @modelo,
    codigo_compra = @codigo_compra,
    id_medida = @id_medida,
    permite_venta_importe = @permite_venta_importe,
    precio_compra = @precio_compra,
    precio_venta = @precio_venta,
    codigo_barras = @codigo_barras,
    fecha_compra = @fecha_compra,
    id_socio = @id_socio,
    id_proveedor = @id_proveedor,
    id_categoria = @id_categoria,
    stock_minimo = @stock_minimo,
    observaciones = @observaciones
WHERE id_producto = @id_producto";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nombre",
                            txtProducto.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@id_marca",
                            cmbMarca.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@modelo",
                            txtModelo.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@codigo_compra",
                            string.IsNullOrWhiteSpace(txtCodigoCompra.Text)
                                ? (object)DBNull.Value
                                : txtCodigoCompra.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@id_medida",
                            cmbUnidad.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@permite_venta_importe",
                            chkPermiteVentaImporte.Checked);

                        cmd.Parameters.AddWithValue(
                            "@precio_compra",
                            Convert.ToDecimal(txtPrecioCompra.Text));

                        cmd.Parameters.AddWithValue(
                            "@precio_venta",
                            Convert.ToDecimal(txtPrecioVenta.Text));

                        cmd.Parameters.AddWithValue(
                            "@codigo_barras",
                            string.IsNullOrWhiteSpace(txtCodigoBarras.Text)
                                ? (object)DBNull.Value
                                : txtCodigoBarras.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@fecha_compra",
                            dtpFechaCompra.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@id_socio",
                            cmbSocio.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@id_proveedor",
                            cmbProveedor.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@id_categoria",
                            cmbCategoria.SelectedValue);

                        cmd.Parameters.AddWithValue(
                            "@stock_minimo",
                            Convert.ToDecimal(txtStockMinimo.Text));

                        cmd.Parameters.AddWithValue(
                            "@observaciones",
                            txtObservaciones.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@id_producto",
                            idProducto);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al actualizar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        private bool CambiarEstadoProducto(bool activo)
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE productos
SET activo = @activo
WHERE id_producto = @idProducto";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@activo",
                            activo ? 1 : 0);

                        cmd.Parameters.AddWithValue(
                            "@idProducto",
                            idProducto);

                        cmd.ExecuteNonQuery();
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

        

        private void CargarProducto()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT *
FROM productos
WHERE id_producto = @idProducto";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@idProducto",
                            idProducto);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                                return;

                            txtProducto.Text =
                                dr["nombre"]?.ToString() ?? "";

                            if (dr["id_categoria"] != DBNull.Value)
                                cmbCategoria.SelectedValue =
                                    Convert.ToInt32(dr["id_categoria"]);
                            else
                                cmbCategoria.SelectedIndex = -1;

                            if (dr["id_marca"] != DBNull.Value)
                                cmbMarca.SelectedValue =
                                    Convert.ToInt32(dr["id_marca"]);
                            else
                                cmbMarca.SelectedIndex = -1;

                            txtModelo.Text =
                                dr["modelo"]?.ToString() ?? "";

                            if (dr["id_medida"] != DBNull.Value)
                                cmbUnidad.SelectedValue =
                                    Convert.ToInt32(dr["id_medida"]);
                            else
                                cmbUnidad.SelectedIndex = -1;

                            chkPermiteVentaImporte.Checked =
                                dr["permite_venta_importe"] != DBNull.Value &&
                                Convert.ToBoolean(dr["permite_venta_importe"]);

                            if (dr["id_proveedor"] != DBNull.Value)
                                cmbProveedor.SelectedValue =
                                    Convert.ToInt32(dr["id_proveedor"]);
                            else
                                cmbProveedor.SelectedIndex = -1;

                            if (dr["id_socio"] != DBNull.Value)
                                cmbSocio.SelectedValue =
                                    Convert.ToInt32(dr["id_socio"]);
                            else
                                cmbSocio.SelectedIndex = -1;

                            txtStockActual.Text =
                                dr["stock_actual"] != DBNull.Value
                                ? Convert.ToDecimal(dr["stock_actual"])
                                    .ToString("N3")
                                : "0.000";

                            txtStockMinimo.Text =
                                dr["stock_minimo"] != DBNull.Value
                                ? Convert.ToDecimal(dr["stock_minimo"])
                                    .ToString("N3")
                                : "0.000";

                            if (dr["fecha_compra"] != DBNull.Value)
                            {
                                dtpFechaCompra.Value =
                                    Convert.ToDateTime(
                                        dr["fecha_compra"]);
                            }
                            else
                            {
                                dtpFechaCompra.Value =
                                    DateTime.Today;
                            }

                            txtCodigoCompra.Text =
                                dr["codigo_compra"]?.ToString() ?? "";

                            txtPrecioCompra.Text =
                                dr["precio_compra"] != DBNull.Value
                                ? Convert.ToDecimal(dr["precio_compra"])
                                    .ToString("N2")
                                : "0.00";

                            txtPrecioVenta.Text =
                                dr["precio_venta"] != DBNull.Value
                                ? Convert.ToDecimal(dr["precio_venta"])
                                    .ToString("N2")
                                : "0.00";

                            txtCodigoBarras.Text =
                                dr["codigo_barras"]?.ToString() ?? "";

                            txtObservaciones.Text =
                                dr["observaciones"]?.ToString() ?? "";

                            bool activo =
                                dr["activo"] != DBNull.Value &&
                                Convert.ToBoolean(dr["activo"]);

                            cmbActivo.SelectedIndex =
                                activo ? 0 : 1;

                            btnDesactivarItem.Text =
                                activo
                                ? "Desactivar"
                                : "Activar";

                            modoEdicion = true;

                            btnDesactivarItem.Enabled = true;
                            btnKardexItem.Enabled = true;

                            CalcularGanancia();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPorcentajeGanancia.Text) &&
       txtPorcentajeGanancia.Text != "0")
            {
                CalcularPrecioVenta();
            }
            else
            {
                CalcularGanancia();
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            CalcularGanancia();
        }

        private void txtPorcentajeGanancia_Leave(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        }

        

        private void btnCerrarItem_Click_1(object sender, EventArgs e)
        {

            if (hayCambios)
            {
                DialogResult r =
                    MessageBox.Show(
                        "Existen cambios sin guardar. ¿Desea salir?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (r != DialogResult.Yes)
                    return;
            }

            this.Close();
        }

        private void btnDesactivarItem_Click(
    object sender,
    EventArgs e)
        {
            if (idProducto <= 0)
            {
                MessageBox.Show(
                    "Debe guardar el producto antes de cambiar su estado.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool activoActual =
                cmbActivo.SelectedIndex == 0;

            string mensaje =
                activoActual
                ? "¿Desea desactivar este producto?"
                : "¿Desea activar este producto?";

            DialogResult respuesta =
                MessageBox.Show(
                    mensaje,
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            bool nuevoEstado = !activoActual;

            if (CambiarEstadoProducto(nuevoEstado))
            {
                cmbActivo.SelectedIndex =
                    nuevoEstado ? 0 : 1;

                MessageBox.Show(
                    "Estado actualizado correctamente.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategorias frm =
        new FrmCategorias();

            frm.ShowDialog();

            CargarCategorias();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            FrmMarcas frm =
        new FrmMarcas();

            frm.ShowDialog();

            CargarMarcas();
        }

        private void btnUnidad_Click(object sender, EventArgs e)
        {
            FrmUnidadesMedida frm =
        new FrmUnidadesMedida();

            frm.ShowDialog();

            CargarUnidades();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores frm =
        new FrmProveedores();

            frm.ShowDialog();

            CargarProveedores();
        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
            FrmSocios frm =
        new FrmSocios();

            frm.ShowDialog();

            CargarSocios();
        }

        private void btnHabilitarEdicion_Click(object sender, EventArgs e)
        {
            HabilitarEdicion();

            btnHabilitarEdicion.Enabled = false;
        }
    }
}
