using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPV_Client.Models;


namespace SPV_Client
{
    public partial class FrmBuscarProducto : Form

    {
        private bool _cerrando = false;
        public ProductoSeleccionado ProductoSeleccionado { get; private set; }

        public FrmBuscarProducto()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_cerrando) return;

            _cerrando = true;

            if (this.DialogResult == DialogResult.None)
                this.DialogResult = DialogResult.Cancel;

            base.OnFormClosing(e);
        }

       

        private void btnCancelarBp_Click(object sender, EventArgs e)
        {
            
            if (_cerrando) return;
            _cerrando = true;

            ProductoSeleccionado = null;
            this.DialogResult = DialogResult.Cancel;
            base.Close();

        }

        private void SeleccionarProducto()
        {
            if (_cerrando) return;

            if (dgvResultados.CurrentRow == null)
                return;

            var row = dgvResultados.CurrentRow;

            DataRowView drv = row.DataBoundItem as DataRowView;

            // 🔥 VALIDACIÓN CLAVE
            if (row.Cells["idProducto"].Value == null)
            {
                MessageBox.Show("Error al obtener datos del producto.");
                return;
            }

            _cerrando = true;

            
            ProductoSeleccionado = new ProductoSeleccionado
            {
                IdProducto = Convert.ToInt32(row.Cells["idProducto"].Value),
                Nombre = row.Cells["Nombre"].Value?.ToString(),
                Marca = row.Cells["Marca"].Value?.ToString(),
                Modelo = row.Cells["Modelo"].Value?.ToString(),
                PrecioCompra = Convert.ToDecimal(row.Cells["precio_compra"].Value ?? 0),
                PrecioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value ?? 0),
                StockActual = Convert.ToDecimal(row.Cells["StockActual"].Value ?? 0),
                CodigoBarras = row.Cells["CodigoBarras"].Value?.ToString(),
                CodigoCompra = row.Cells["CodigoCompra"].Value?.ToString(),
                Proveedor = row.Cells["proveedor"].Value?.ToString(),
                
                IdMedida = Convert.ToInt32(drv["id_medida"]),
                Abreviatura = drv["abreviatura"].ToString(),
                PermiteDecimal = Convert.ToBoolean(drv["permite_decimal"]),
                PermiteImporte = Convert.ToBoolean(drv["permite_importe"]),
                Decimales = Convert.ToInt32(drv["decimales"]),
                
            };

            this.DialogResult = DialogResult.OK;
            base.Close();
        }



        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            // 🔴 IMPORTANTE
            dgvResultados.AutoGenerateColumns = false;

            // 🔧 Mapear columnas (ESTO ES LO QUE TE FALTABA)
            dgvResultados.Columns["idProducto"].DataPropertyName = "id_producto";
            dgvResultados.Columns["Nombre"].DataPropertyName = "nombre";
            dgvResultados.Columns["Marca"].DataPropertyName = "nombre_marca";
            dgvResultados.Columns["proveedor"].DataPropertyName = "proveedor";
            dgvResultados.Columns["Modelo"].DataPropertyName = "modelo";
            dgvResultados.Columns["PrecioVenta"].DataPropertyName = "precio_venta";
            dgvResultados.Columns["StockActual"].DataPropertyName = "stock_actual";
            dgvResultados.Columns["CodigoBarras"].DataPropertyName = "codigo_barras";
            dgvResultados.Columns["CodigoCompra"].DataPropertyName = "codigo_compra";

            // 🔧 Asegurar columna precio_compra
            if (!dgvResultados.Columns.Contains("precio_compra"))
            {
                dgvResultados.Columns.Add("precio_compra", "Precio Compra");
            }

            dgvResultados.Columns["precio_compra"].DataPropertyName = "precio_compra";
            dgvResultados.Columns["precio_compra"].Visible = false;

            // Otros controles
            cboFiltro.SelectedIndex = 0;
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarProducto();
        }

        private void dgvResultados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SeleccionarProducto();
            }
        }

        private void FrmBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ProductoSeleccionado = null;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }
        private void CargarProductos(string textoBusqueda)
        {
            if (textoBusqueda.Length < 2)
            {
                dgvResultados.DataSource = null; // 🔥 ya no usamos Rows.Clear()
                return;
            }

            string filtro = cboFiltro.SelectedItem.ToString();
            string whereClause = "";

            switch (filtro)
            {
                case "Nombre":
                    whereClause = "p.nombre LIKE @filtro";
                    break;

                case "Modelo":
                    whereClause = "p.modelo LIKE @filtro";
                    break;

                case "Marca":
                    whereClause = "IFNULL(m.nombre_marca, 'SIN MARCA') LIKE @filtro";
                    break;

                case "Codigo":
                    whereClause = "p.codigo_barras LIKE @filtro";
                    break;

                case "Todos":
                    whereClause = @"(
                p.nombre LIKE @filtro OR
                p.modelo LIKE @filtro OR
                IFNULL(m.nombre_marca, 'SIN MARCA') LIKE @filtro OR
                p.codigo_barras LIKE @filtro
            )";
                    break;
            }

            string sql = $@"
    SELECT
    p.id_producto,
    p.nombre,
    IFNULL(m.nombre_marca, 'SIN MARCA') AS nombre_marca,
    IFNULL(pr.nombre, 'SIN PROVEEDOR') AS proveedor,
    p.modelo,

    p.precio_compra,
    p.precio_venta,
    p.stock_actual,

    p.codigo_barras,
    p.codigo_compra,

    p.id_medida,

    um.abreviatura,
    um.permite_decimal,
    um.permite_importe,
    um.decimales

    FROM productos p

    LEFT JOIN marcas m ON p.id_marca = m.id_marca

    LEFT JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor

    INNER JOIN unidades_medida um ON p.id_medida = um.id_medida

    WHERE {whereClause}

    ORDER BY p.nombre

    LIMIT 50;
    ";

            try
            {
                using (var conn = DB.GetConnection())
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@filtro", $"%{textoBusqueda}%");

                    conn.Open();

                    DataTable dt = new DataTable(); // ✅ FUERA del while

                    dt.Columns.Add("id_producto", typeof(int));
                    dt.Columns.Add("nombre", typeof(string));
                    dt.Columns.Add("nombre_marca", typeof(string));
                    dt.Columns.Add("proveedor", typeof(string));
                    dt.Columns.Add("modelo", typeof(string));
                    dt.Columns.Add("precio_compra", typeof(decimal));
                    dt.Columns.Add("precio_venta", typeof(decimal));
                    dt.Columns.Add("stock_actual", typeof(decimal));
                    dt.Columns.Add("codigo_barras", typeof(string));
                    dt.Columns.Add("codigo_compra", typeof(string));
                    dt.Columns.Add("id_medida", typeof(int));
                    dt.Columns.Add("abreviatura", typeof(string));
                    dt.Columns.Add("permite_decimal", typeof(bool));
                    dt.Columns.Add("permite_importe", typeof(bool));
                    dt.Columns.Add("decimales", typeof(int));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dt.Rows.Add(
                                reader.GetInt32("id_producto"),
                                reader.GetString("nombre"),
                                reader.GetString("nombre_marca"),
                                reader.GetString("proveedor"),
                                reader.GetString("modelo"),
                                reader.GetDecimal("precio_compra"),
                                reader.GetDecimal("precio_venta"),
                                reader.GetDecimal("stock_actual"),
                                reader.GetString("codigo_barras"),
                                reader.GetString("codigo_compra"),

                                reader.GetInt32("id_medida"),
                                reader.GetString("abreviatura"),
                                reader.GetBoolean("permite_decimal"),
                                reader.GetBoolean("permite_importe"),
                                reader.GetInt32("decimales")
                            );
                            
                        }
                    }

                    dgvResultados.DataSource = dt; // ✅ AQUÍ se asigna al grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar productos:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtBuscarPopup_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscarPopup.Text.Trim());
        }

        private void FrmBuscarProducto_Shown(object sender, EventArgs e)
        {
            txtBuscarPopup.Focus();
            txtBuscarPopup.SelectAll();
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeleccionarBp_Click(object sender, EventArgs e)
        {
            SeleccionarProducto();
            
        }
    }
}
