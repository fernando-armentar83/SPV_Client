using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace SPV_Client
{
    public partial class FrmImportacionProductos : Form
    {
        private class ProductoImportar
        {
            public int Fila;
            public string Nombre;
            public int? IdMarca;
            public string Modelo;
            public string CodigoCompra;
            public int? IdMedida;
            public bool PermiteVentaImporte;
            public decimal PrecioCompra;
            public decimal PrecioVenta;
            public string CodigoBarras;
            public DateTime? FechaCompra;
            public int IdSocio;
            public int? IdProveedor;
            public int? IdCategoria;
            public decimal StockMinimo;
            public decimal StockInicial;
            public string Observaciones;
            public string Estado;
            public bool EsValido;
        }

        private List<ProductoImportar> filasValidadas = new List<ProductoImportar>();

        private Dictionary<string, int> catMarcas;
        private Dictionary<string, int> catUnidades;
        private Dictionary<string, int> catProveedores;
        private Dictionary<string, int> catSocios;
        private Dictionary<string, int> catCategorias;

        public FrmImportacionProductos()
        {
            InitializeComponent();
        }

        private void FrmImportacionProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarPlantilla_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "plantilla_productos.xlsx";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Productos");

                    string[] encabezados = {
                        "nombre", "marca", "modelo", "codigo_compra", "unidad_medida",
                        "permite_venta_importe", "precio_compra", "precio_venta",
                        "codigo_barras", "fecha_compra", "socio", "proveedor",
                        "departamento", "categoria", "stock_minimo", "stock_inicial",
                        "observaciones"
                    };

                    for (int i = 0; i < encabezados.Length; i++)
                    {
                        ws.Cell(1, i + 1).Value = encabezados[i];
                        ws.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    ws.Columns().AdjustToContents();

                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show(
                    "Plantilla generada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnBuscarExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel (*.xlsx)|*.xlsx";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtRutaExcel.Text = ofd.FileName;
                    btnImportar.Enabled = false;
                    dgvPreviewImportacion.DataSource = null;
                    lblResumenImportacion.Text = "";
                }
            }
        }

        private void CargarCatalogos()
        {
            catMarcas = new Dictionary<string, int>();
            catUnidades = new Dictionary<string, int>();
            catProveedores = new Dictionary<string, int>();
            catSocios = new Dictionary<string, int>();
            catCategorias = new Dictionary<string, int>();

            using (var conn = DB.GetConnection())
            {
                conn.Open();

                CargarDiccionario(conn, "SELECT id_marca, nombre_marca FROM marcas WHERE activo = 1", catMarcas);
                CargarDiccionario(conn, "SELECT id_medida, nombre_medida FROM unidades_medida WHERE activo = 1", catUnidades);
                CargarDiccionario(conn, "SELECT id_proveedor, nombre FROM proveedores WHERE estado = 'ACTIVO'", catProveedores);
                CargarDiccionario(conn, "SELECT id_socio, nombre_socio FROM socios WHERE activo = 1", catSocios);

                string sqlCat = @"
SELECT c.id_categoria, CONCAT(d.nombre, '|', c.nombre) AS clave
FROM categorias c
INNER JOIN departamentos d ON c.id_departamento = d.id_departamento
WHERE c.activo = 1 AND d.activo = 1;";

                using (var cmd = new MySqlCommand(sqlCat, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string clave = reader["clave"].ToString().Trim().ToUpper();
                        catCategorias[clave] = Convert.ToInt32(reader["id_categoria"]);
                    }
                }
            }
        }

        private void CargarDiccionario(MySqlConnection conn, string sql, Dictionary<string, int> destino)
        {
            using (var cmd = new MySqlCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nombre = reader.GetString(1).Trim().ToUpper();
                    int id = Convert.ToInt32(reader[0]);
                    destino[nombre] = id;
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRutaExcel.Text))
            {
                MessageBox.Show(
                    "Seleccione un archivo Excel.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            CargarCatalogos();

            filasValidadas = new List<ProductoImportar>();
            HashSet<string> nombresEnArchivo = new HashSet<string>();
            int errores = 0;

            try
            {
                using (var wb = new XLWorkbook(txtRutaExcel.Text))
                {
                    var ws = wb.Worksheet(1);
                    var filas = ws.RowsUsed();

                    int numFila = 1;

                    foreach (var fila in filas)
                    {
                        numFila++;

                        if (fila.RowNumber() == 1)
                            continue;

                        string nombre = fila.Cell(1).GetString().Trim();

                        if (string.IsNullOrWhiteSpace(nombre))
                            continue;

                        var item = new ProductoImportar { Fila = fila.RowNumber() };
                        List<string> erroresFila = new List<string>();

                        item.Nombre = nombre;

                        string claveNombre = nombre.ToUpper();
                        if (nombresEnArchivo.Contains(claveNombre))
                        {
                            erroresFila.Add("producto repetido dentro del archivo");
                        }
                        nombresEnArchivo.Add(claveNombre);

                        string marca = fila.Cell(2).GetString().Trim();
                        if (!string.IsNullOrWhiteSpace(marca))
                        {
                            if (catMarcas.TryGetValue(marca.ToUpper(), out int idMarca))
                                item.IdMarca = idMarca;
                            else
                                erroresFila.Add($"marca '{marca}' no encontrada");
                        }

                        item.Modelo = fila.Cell(3).GetString().Trim();
                        item.CodigoCompra = fila.Cell(4).GetString().Trim();

                        string unidad = fila.Cell(5).GetString().Trim();
                        if (!string.IsNullOrWhiteSpace(unidad))
                        {
                            if (catUnidades.TryGetValue(unidad.ToUpper(), out int idMedida))
                                item.IdMedida = idMedida;
                            else
                                erroresFila.Add($"unidad '{unidad}' no encontrada");
                        }

                        string permiteImporte = fila.Cell(6).GetString().Trim().ToUpper();
                        item.PermiteVentaImporte = permiteImporte == "SI" || permiteImporte == "1";

                        if (!decimal.TryParse(fila.Cell(7).GetString().Trim(), out decimal precioCompra) || precioCompra <= 0)
                            erroresFila.Add("precio_compra inválido o vacío");
                        else
                            item.PrecioCompra = precioCompra;

                        if (!decimal.TryParse(fila.Cell(8).GetString().Trim(), out decimal precioVenta) || precioVenta <= 0)
                            erroresFila.Add("precio_venta inválido o vacío");
                        else
                            item.PrecioVenta = precioVenta;

                        item.CodigoBarras = fila.Cell(9).GetString().Trim();

                        string fechaTexto = fila.Cell(10).GetString().Trim();
                        if (!string.IsNullOrWhiteSpace(fechaTexto))
                        {
                            if (DateTime.TryParse(fechaTexto, out DateTime fecha))
                                item.FechaCompra = fecha;
                            else
                                erroresFila.Add("fecha_compra con formato inválido");
                        }

                        string socio = fila.Cell(11).GetString().Trim();
                        if (string.IsNullOrWhiteSpace(socio))
                        {
                            erroresFila.Add("socio es obligatorio");
                        }
                        else if (catSocios.TryGetValue(socio.ToUpper(), out int idSocio))
                        {
                            item.IdSocio = idSocio;
                        }
                        else
                        {
                            erroresFila.Add($"socio '{socio}' no encontrado");
                        }

                        string proveedor = fila.Cell(12).GetString().Trim();
                        if (!string.IsNullOrWhiteSpace(proveedor))
                        {
                            if (catProveedores.TryGetValue(proveedor.ToUpper(), out int idProveedor))
                                item.IdProveedor = idProveedor;
                            else
                                erroresFila.Add($"proveedor '{proveedor}' no encontrado");
                        }

                        string departamento = fila.Cell(13).GetString().Trim();
                        string categoria = fila.Cell(14).GetString().Trim();

                        if (!string.IsNullOrWhiteSpace(categoria))
                        {
                            if (string.IsNullOrWhiteSpace(departamento))
                            {
                                erroresFila.Add("categoria capturada sin departamento");
                            }
                            else
                            {
                                string clave = (departamento + "|" + categoria).ToUpper();
                                if (catCategorias.TryGetValue(clave, out int idCategoria))
                                    item.IdCategoria = idCategoria;
                                else
                                    erroresFila.Add($"categoria '{categoria}' no encontrada en departamento '{departamento}'");
                            }
                        }

                        string stockMinTexto = fila.Cell(15).GetString().Trim();
                        if (!string.IsNullOrWhiteSpace(stockMinTexto))
                        {
                            if (decimal.TryParse(stockMinTexto, out decimal stockMin))
                                item.StockMinimo = stockMin;
                            else
                                erroresFila.Add("stock_minimo inválido");
                        }

                        string stockInicialTexto = fila.Cell(16).GetString().Trim();
                        if (!string.IsNullOrWhiteSpace(stockInicialTexto))
                        {
                            if (decimal.TryParse(stockInicialTexto, out decimal stockIni) && stockIni >= 0)
                                item.StockInicial = stockIni;
                            else
                                erroresFila.Add("stock_inicial inválido");
                        }

                        item.Observaciones = fila.Cell(17).GetString().Trim();

                        if (erroresFila.Count > 0)
                        {
                            item.EsValido = false;
                            item.Estado = "ERROR: " + string.Join("; ", erroresFila);
                            errores++;
                        }
                        else
                        {
                            item.EsValido = true;
                            item.Estado = "OK";
                        }

                        filasValidadas.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible leer el archivo:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Fila", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Estado", typeof(string));

            foreach (var f in filasValidadas)
                dt.Rows.Add(f.Fila, f.Nombre, f.Estado);

            dgvPreviewImportacion.DataSource = dt;

            if (filasValidadas.Count == 0)
            {
                lblResumenImportacion.Text = "El archivo no tiene filas con datos.";
                btnImportar.Enabled = false;
                return;
            }

            if (errores > 0)
            {
                lblResumenImportacion.Text =
                    $"{errores} fila(s) con error de {filasValidadas.Count}. Corrija el archivo y vuelva a validar.";
                btnImportar.Enabled = false;
            }
            else
            {
                lblResumenImportacion.Text =
                    $"{filasValidadas.Count} fila(s) validada(s) correctamente. Listo para importar.";
                btnImportar.Enabled = true;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (Session.IdUsuario == 0)
            {
                MessageBox.Show(
                    "No hay una sesión activa.",
                    "Sesión requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (filasValidadas.Count == 0 || filasValidadas.Exists(f => !f.EsValido))
            {
                MessageBox.Show(
                    "Debe validar el archivo sin errores antes de importar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show(
                $"¿Confirma importar {filasValidadas.Count} producto(s)?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No)
                return;

            btnImportar.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();

                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (var p in filasValidadas)
                            {
                                string sqlInsert = @"
INSERT INTO productos
(nombre, id_marca, modelo, codigo_compra, id_medida, permite_venta_importe,
 precio_compra, precio_venta, codigo_barras, fecha_compra, id_socio,
 stock_actual, id_proveedor, id_categoria, activo, stock_minimo, observaciones)
VALUES
(@nombre, @id_marca, @modelo, @codigo_compra, @id_medida, @permite_venta_importe,
 @precio_compra, @precio_venta, @codigo_barras, @fecha_compra, @id_socio,
 0, @id_proveedor, @id_categoria, 1, @stock_minimo, @observaciones);";

                                int idProductoNuevo;

                                using (var cmd = new MySqlCommand(sqlInsert, conn, trans))
                                {
                                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                                    cmd.Parameters.AddWithValue("@id_marca", (object)p.IdMarca ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@modelo", string.IsNullOrWhiteSpace(p.Modelo) ? (object)DBNull.Value : p.Modelo);
                                    cmd.Parameters.AddWithValue("@codigo_compra", string.IsNullOrWhiteSpace(p.CodigoCompra) ? (object)DBNull.Value : p.CodigoCompra);
                                    cmd.Parameters.AddWithValue("@id_medida", (object)p.IdMedida ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@permite_venta_importe", p.PermiteVentaImporte);
                                    cmd.Parameters.AddWithValue("@precio_compra", p.PrecioCompra);
                                    cmd.Parameters.AddWithValue("@precio_venta", p.PrecioVenta);
                                    cmd.Parameters.AddWithValue("@codigo_barras", string.IsNullOrWhiteSpace(p.CodigoBarras) ? (object)DBNull.Value : p.CodigoBarras);
                                    cmd.Parameters.AddWithValue("@fecha_compra", (object)p.FechaCompra ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@id_socio", p.IdSocio);
                                    cmd.Parameters.AddWithValue("@id_proveedor", (object)p.IdProveedor ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@id_categoria", (object)p.IdCategoria ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@stock_minimo", p.StockMinimo);
                                    cmd.Parameters.AddWithValue("@observaciones", string.IsNullOrWhiteSpace(p.Observaciones) ? (object)DBNull.Value : p.Observaciones);

                                    cmd.ExecuteNonQuery();
                                    idProductoNuevo = Convert.ToInt32(cmd.LastInsertedId);
                                }

                                if (p.StockInicial > 0)
                                {
                                    string sqlMov = @"
INSERT INTO movimientos_stock (id_producto, id_usuario, tipo_movimiento, cantidad, descripcion)
VALUES (@id_producto, @id_usuario, 'ENTRADA', @cantidad, 'Carga inicial - migración SPV anterior');";

                                    using (var cmdMov = new MySqlCommand(sqlMov, conn, trans))
                                    {
                                        cmdMov.Parameters.AddWithValue("@id_producto", idProductoNuevo);
                                        cmdMov.Parameters.AddWithValue("@id_usuario", Session.IdUsuario);
                                        cmdMov.Parameters.AddWithValue("@cantidad", p.StockInicial);
                                        cmdMov.ExecuteNonQuery();
                                    }
                                }
                            }

                            trans.Commit();
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    $"{filasValidadas.Count} producto(s) importado(s) correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                filasValidadas.Clear();
                dgvPreviewImportacion.DataSource = null;
                lblResumenImportacion.Text = "";
                txtRutaExcel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible importar. No se guardó ningún producto.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnImportar.Enabled = true;
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"IMPORTACIÓN MASIVA DE PRODUCTOS

GENERAR PLANTILLA
Crea un Excel en blanco con los encabezados correctos.
Úsalo como base para llenar los productos a importar.

Antes de llenar la plantilla, asegúrate de que ya existan
en el sistema: marcas, unidades de medida, proveedores,
socios, y departamentos/categorías (si aplica). La
importación busca estos datos POR NOMBRE, no los crea.

VALIDAR ARCHIVO
Lee el Excel y revisa cada fila SIN guardar nada todavía.
Si hay errores, se listan por fila para que corrijas el
Excel (o des de alta lo que falte) y vuelvas a validar.

IMPORTAR
Solo se habilita cuando TODAS las filas pasan la
validación. Si algo falla durante la importación, no se
guarda ningún producto (todo o nada).

El stock inicial se registra como un movimiento de
ENTRADA en el Kardex de cada producto, no se escribe
directo - queda la trazabilidad completa.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCerrarImportacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
