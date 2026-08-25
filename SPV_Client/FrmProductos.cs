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
    public partial class FrmProductos : Form
    {
        private int idProductoSeleccionado = 0;
        private bool cargandoFiltros = false;
        private bool productoActivo = true;
        private DataTable dtProductos = new DataTable();

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void ActualizarContadorProductos()
        {
            lblTotalProductos.Text =
                $"Total productos: {dgvProductos.Rows.Count}";
        }

        private void CargarCategoriasFiltro()
        {
            try
            {
                cargandoFiltros = true;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_categoria,
    nombre
FROM categorias
WHERE activo = 1
ORDER BY nombre";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        DataRow filaTodos = dt.NewRow();

                        filaTodos["id_categoria"] = 0;
                        filaTodos["nombre"] = "TODOS";

                        dt.Rows.InsertAt(filaTodos, 0);

                        cmbCategoriaFiltro.DataSource = dt;

                        cmbCategoriaFiltro.DisplayMember = "nombre";

                        cmbCategoriaFiltro.ValueMember = "id_categoria";

                        cmbCategoriaFiltro.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cargandoFiltros = false;
            }
        }

        private void CargarMarcasFiltro()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_marca,
    nombre_marca
FROM marcas
WHERE activo = 1
ORDER BY nombre_marca";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        DataRow filaTodos = dt.NewRow();

                        filaTodos["id_marca"] = 0;
                        filaTodos["nombre_marca"] = "TODOS";

                        dt.Rows.InsertAt(filaTodos, 0);

                        cmbMarcaFiltro.DataSource = dt;

                        cmbMarcaFiltro.DisplayMember = "nombre_marca";

                        cmbMarcaFiltro.ValueMember = "id_marca";

                        cmbMarcaFiltro.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarProveedoresFiltro()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_proveedor,
    nombre
FROM proveedores
WHERE estado = 'ACTIVO'
ORDER BY nombre";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        DataRow filaTodos = dt.NewRow();

                        filaTodos["id_proveedor"] = 0;
                        filaTodos["nombre"] = "TODOS";

                        dt.Rows.InsertAt(filaTodos, 0);

                        cmbProveedorFiltro.DataSource = dt;

                        cmbProveedorFiltro.DisplayMember = "nombre";

                        cmbProveedorFiltro.ValueMember = "id_proveedor";

                        cmbProveedorFiltro.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarSociosFiltro()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    id_socio,
    nombre_socio
FROM socios
WHERE activo = 1
ORDER BY nombre_socio";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        DataRow filaTodos = dt.NewRow();

                        filaTodos["id_socio"] = 0;
                        filaTodos["nombre_socio"] = "TODOS";

                        dt.Rows.InsertAt(filaTodos, 0);

                        cmbSocioFiltro.DataSource = dt;

                        cmbSocioFiltro.DisplayMember = "nombre_socio";

                        cmbSocioFiltro.ValueMember = "id_socio";

                        cmbSocioFiltro.SelectedIndex = 0;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT
    p.id_producto,
    p.nombre,

    c.nombre AS categoria,

    m.nombre_marca AS marca,

    p.modelo,

    pr.nombre AS proveedor,

    s.nombre_socio AS socio,

    p.stock_actual,

    p.stock_minimo,

    p.precio_compra,

    p.precio_venta,

    CASE
        WHEN p.activo = 1 THEN 'Activo'
        ELSE 'Inactivo'
    END AS activo

FROM productos p

LEFT JOIN categorias c
    ON p.id_categoria = c.id_categoria

LEFT JOIN marcas m
    ON p.id_marca = m.id_marca

LEFT JOIN proveedores pr
    ON p.id_proveedor = pr.id_proveedor

LEFT JOIN socios s
    ON p.id_socio = s.id_socio

ORDER BY p.nombre";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dtProductos = dt;

                        dgvProductos.DataSource = dtProductos;

                        ActualizarContadorProductos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FiltrarProductos()
        {
            try
            {
                if (cargandoFiltros)
                    return;

                if (dtProductos == null)
                    return;

                string filtro = "";

                // BUSQUEDA POR TEXTO
                if (!string.IsNullOrWhiteSpace(txtBuscarProducto.Text))
                {
                    string texto =
                        txtBuscarProducto.Text
                        .Trim()
                        .Replace("'", "''");

                    filtro =
                        $"nombre LIKE '%{texto}%'";
                }

                // CATEGORIA
                if (cmbCategoriaFiltro.SelectedIndex > 0)
                {
                    DataRowView drv =
                        (DataRowView)cmbCategoriaFiltro.SelectedItem;

                    string categoria =
                        drv["nombre"].ToString()
                        .Replace("'", "''");

                    if (filtro != "")
                        filtro += " AND ";

                    filtro +=
                        $"categoria = '{categoria}'";
                }

                // MARCA
                if (cmbMarcaFiltro.SelectedIndex > 0)
                {
                    DataRowView drv =
                        (DataRowView)cmbMarcaFiltro.SelectedItem;

                    string marca =
                        drv["nombre_marca"].ToString()
                        .Replace("'", "''");

                    if (filtro != "")
                        filtro += " AND ";

                    filtro +=
                        $"marca = '{marca}'";
                }

                // PROVEEDOR
                if (cmbProveedorFiltro.SelectedIndex > 0)
                {
                    DataRowView drv =
                        (DataRowView)cmbProveedorFiltro.SelectedItem;

                    string proveedor =
                        drv["nombre"].ToString()
                        .Replace("'", "''");

                    if (filtro != "")
                        filtro += " AND ";

                    filtro +=
                        $"proveedor = '{proveedor}'";
                }

                // SOCIO
                if (cmbSocioFiltro.SelectedIndex > 0)
                {
                    DataRowView drv =
                        (DataRowView)cmbSocioFiltro.SelectedItem;

                    string socio =
                        drv["nombre_socio"].ToString()
                        .Replace("'", "''");

                    if (filtro != "")
                        filtro += " AND ";

                    filtro +=
                        $"socio = '{socio}'";
                }

                // MOSTRAR INACTIVOS
                if (!chkMostrarInactivos.Checked)
                {
                    if (filtro != "")
                        filtro += " AND ";

                    filtro +=
                        "activo = 'Activo'";
                }

                dtProductos.DefaultView.RowFilter = filtro;

                ActualizarContadorProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al filtrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCategoriasFiltro();

            CargarMarcasFiltro();

            CargarProveedoresFiltro();

            CargarSociosFiltro();

            CargarProductos();

            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;

            cmbCategoriaFiltro.SelectedIndexChanged += cmbCategoriaFiltro_SelectedIndexChanged;

            cmbMarcaFiltro.SelectedIndexChanged += cmbMarcaFiltro_SelectedIndexChanged;

            cmbProveedorFiltro.SelectedIndexChanged += cmbProveedorFiltro_SelectedIndexChanged;

            cmbSocioFiltro.SelectedIndexChanged += cmbSocioFiltro_SelectedIndexChanged;

            chkMostrarInactivos.CheckedChanged += chkMostrarInactivos_CheckedChanged;

            btnActualizarProductos.Click += btnActualizarProductos_Click;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvProductos.Rows[e.RowIndex];

                idProductoSeleccionado =
                    Convert.ToInt32(
                        fila.Cells["colIdProducto"].Value);

                productoActivo =
                    fila.Cells["colActivo"].Value.ToString() == "Activo";

                btnDesactivarProducto.Enabled = true;

                btnDesactivarProducto.Text =
                    productoActivo
                        ? "Desactivar"
                        : "Activar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDesactivarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProductoSeleccionado == 0)
                {
                    MessageBox.Show(
                        "Seleccione un producto.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                bool nuevoEstado = !productoActivo;

                string mensaje =
                    nuevoEstado
                        ? "¿Desea activar este producto?"
                        : "¿Desea desactivar este producto?";

                DialogResult r =
                    MessageBox.Show(
                        mensaje,
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (r != DialogResult.Yes)
                    return;

                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    string sql = @"
UPDATE productos
SET activo = @activo
WHERE id_producto = @id";

                    using (var cmd =
                        new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@activo",
                            nuevoEstado);

                        cmd.Parameters.AddWithValue(
                            "@id",
                            idProductoSeleccionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Proceso realizado correctamente.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                idProductoSeleccionado = 0;

                btnDesactivarProducto.Enabled = false;

                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmItem frm = new FrmItem();

            frm.ShowDialog();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void dgvProductos_CellDoubleClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idProducto =
                Convert.ToInt32(
                    dgvProductos.Rows[e.RowIndex]
                    .Cells["colIdProducto"]
                    .Value);

            FrmItem frm = new FrmItem();

            frm.IdProducto = idProducto;

            frm.ShowDialog();
        }
        

        private void dgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (idProductoSeleccionado == 0)
                    return;

                FrmItem frm = new FrmItem();

                frm.IdProducto = idProductoSeleccionado;

                frm.ShowDialog();

                e.Handled = true;
            }
        }

        private void btnCerrarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarProducto_TextChanged(
    object sender,
    EventArgs e)
        {
            FiltrarProductos();
        }

        private void cmbCategoriaFiltro_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            FiltrarProductos();
        }

        private void cmbMarcaFiltro_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            FiltrarProductos();
        }

        private void cmbProveedorFiltro_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            FiltrarProductos();
        }

        private void cmbSocioFiltro_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            FiltrarProductos();
        }

        private void chkMostrarInactivos_CheckedChanged(
            object sender,
            EventArgs e)
        {
            FiltrarProductos();
        }

        private void btnActualizarProductos_Click(
            object sender,
            EventArgs e)
        {
            CargarProductos();

            FiltrarProductos();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
                
                cargandoFiltros = true;

                txtBuscarProducto.Clear();

                cmbCategoriaFiltro.SelectedIndex = 0;

                cmbMarcaFiltro.SelectedIndex = 0;

                cmbProveedorFiltro.SelectedIndex = 0;

                cmbSocioFiltro.SelectedIndex = 0;

                chkMostrarInactivos.Checked = false;

                cargandoFiltros = false;

                FiltrarProductos();
            }

        private void lblTotalProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
