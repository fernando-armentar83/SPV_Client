using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace SPV_Client.Services
{
    internal class DetalleCompraPdf
    {
        public string Folio { get; set; }

        public DateTime Fecha { get; set; }

        public string Proveedor { get; set; }

        public string Usuario { get; set; }

        public string Producto { get; set; }

        public string Modelo { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal Subtotal { get; set; }
    }

    internal class HistorialCompraPdf
    {
        public int IdCompra { get; set; }

        public string Folio { get; set; }

        public string Fecha { get; set; }

        public string Proveedor { get; set; }

        public string Usuario { get; set; }

        public decimal Total { get; set; }

        public string Estado { get; set; }
    }

    public static class ExportService
    {
        private static IContainer EstiloEncabezado(IContainer container)
        {
            return container
                .Background("#D9EAF7")
                .Border(1)
                .BorderColor("#808080")
                .Padding(5)
                .DefaultTextStyle(x => x.Bold());
        }

        private static IContainer EstiloCelda(IContainer container)
        {
            return container
                .BorderBottom(1)
                .BorderColor("#D0D0D0")
                .Padding(5);
        }
        public static void ExportarHistorialComprasExcel(DataGridView dgv)
        {
            if (dgv == null)
                throw new ArgumentNullException(nameof(dgv));

            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay datos para exportar.",
                    "Exportar a Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
                dialogo.Title = "Guardar archivo de Excel";
                dialogo.FileName = "Exportacion_" +
                                   DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                                   ".xlsx";

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                using (XLWorkbook libro = new XLWorkbook())
                {
                    IXLWorksheet hoja = libro.Worksheets.Add("Datos");

                    int columnaExcel = 1;

                    foreach (DataGridViewColumn columna in dgv.Columns)
                    {
                        if (!columna.Visible)
                            continue;

                        hoja.Cell(1, columnaExcel).Value =
                            columna.HeaderText;

                        columnaExcel++;
                    }

                    int filaExcel = 2;

                    foreach (DataGridViewRow fila in dgv.Rows)
                    {
                        if (fila.IsNewRow)
                            continue;

                        columnaExcel = 1;

                        foreach (DataGridViewColumn columna in dgv.Columns)
                        {
                            if (!columna.Visible)
                                continue;

                            object valor =
                                fila.Cells[columna.Index].Value;

                            hoja.Cell(filaExcel, columnaExcel).Value =
                                valor == null || valor == DBNull.Value
                                    ? ""
                                    : valor.ToString();

                            columnaExcel++;
                        }

                        filaExcel++;
                    }

                    hoja.Row(1).Style.Font.Bold = true;
                    hoja.Columns().AdjustToContents();

                    libro.SaveAs(dialogo.FileName);
                }

                MessageBox.Show(
                    "El archivo de Excel se generó correctamente.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public static void ExportarDetalleCompraExcel(int idCompra)
        {
            using (var conexion = DB.GetConnection())
            {
                conexion.Open();

                string query = @"
SELECT
    c.folio,
    c.fecha_compra,
    pr.nombre AS proveedor,
    u.nombre AS usuario,
    p.nombre AS producto,
    p.modelo,
    cd.cantidad,
    cd.precio_compra,
    cd.subtotal
FROM compras c
INNER JOIN compras_detalle cd
    ON c.id_compra = cd.id_compra
INNER JOIN productos p
    ON cd.id_producto = p.id_producto
LEFT JOIN proveedores pr
    ON c.id_proveedor = pr.id_proveedor
LEFT JOIN usuarios u
    ON c.id_usuario = u.id_usuario
WHERE c.id_compra = @idCompra
ORDER BY cd.id_detalle;";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(
                    query,
                    conexion))
                {
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show(
                                "La compra seleccionada no tiene productos para exportar.",
                                "Exportar detalle",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            return;
                        }

                        using (SaveFileDialog dialogo = new SaveFileDialog())
                        {
                            dialogo.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
                            dialogo.Title = "Guardar detalle de compra";

                            string folio = "";

                            if (reader.Read())
                            {
                                folio = reader["folio"].ToString();
                            }

                            reader.Close();

                            dialogo.FileName = "Detalle_" +
                                               folio +
                                               "_" +
                                               DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                                               ".xlsx";

                            if (dialogo.ShowDialog() != DialogResult.OK)
                                return;

                            using (var readerDatos = cmd.ExecuteReader())
                            using (var libro = new XLWorkbook())
                            {
                                var hoja = libro.Worksheets.Add("Detalle compra");

                                // TÍTULO
                                hoja.Cell(1, 1).Value = "DETALLE DE COMPRA";
                                hoja.Range("A1:E1").Merge();

                                hoja.Cell(1, 1).Style.Font.Bold = true;
                                hoja.Cell(1, 1).Style.Font.FontSize = 14;
                                hoja.Cell(1, 1).Style.Alignment.Horizontal =
                                    XLAlignmentHorizontalValues.Center;

                                // ENCABEZADOS DE LA COMPRA
                                hoja.Cell(2, 1).Value = "Folio";
                                hoja.Cell(2, 2).Value = "Fecha";
                                hoja.Cell(2, 3).Value = "Proveedor";
                                hoja.Cell(2, 4).Value = "Usuario";

                                hoja.Range("A2:D2").Style.Font.Bold = true;

                                int fila = 3;

                                string folioCompra = "";
                                DateTime fechaCompra = DateTime.MinValue;
                                string proveedor = "";
                                string usuario = "";

                                while (readerDatos.Read())
                                {
                                    if (fila == 3)
                                    {
                                        folioCompra = readerDatos["folio"].ToString();

                                        if (readerDatos["fecha_compra"] != DBNull.Value)
                                        {
                                            fechaCompra = Convert.ToDateTime(
                                                readerDatos["fecha_compra"]);
                                        }

                                        proveedor = readerDatos["proveedor"] == DBNull.Value
                                            ? ""
                                            : readerDatos["proveedor"].ToString();

                                        usuario = readerDatos["usuario"] == DBNull.Value
                                            ? ""
                                            : readerDatos["usuario"].ToString();

                                        hoja.Cell(3, 1).Value = folioCompra;

                                        hoja.Cell(3, 2).Value =
                                            fechaCompra == DateTime.MinValue
                                                ? ""
                                                : fechaCompra.ToString("dd/MM/yyyy HH:mm");

                                        hoja.Cell(3, 3).Value = proveedor;
                                        hoja.Cell(3, 4).Value = usuario;

                                        // ENCABEZADOS DEL DETALLE
                                        hoja.Cell(5, 1).Value = "Producto";
                                        hoja.Cell(5, 2).Value = "Modelo";
                                        hoja.Cell(5, 3).Value = "Cantidad";
                                        hoja.Cell(5, 4).Value = "Precio compra";
                                        hoja.Cell(5, 5).Value = "Subtotal";

                                        hoja.Range("A5:E5").Style.Font.Bold = true;

                                        fila = 6;
                                    }

                                    hoja.Cell(fila, 1).Value =
                                        readerDatos["producto"].ToString();

                                    hoja.Cell(fila, 2).Value =
                                        readerDatos["modelo"] == DBNull.Value
                                            ? ""
                                            : readerDatos["modelo"].ToString();

                                    hoja.Cell(fila, 3).Value =
                                        Convert.ToDecimal(
                                            readerDatos["cantidad"]);

                                    hoja.Cell(fila, 4).Value =
                                        Convert.ToDecimal(
                                            readerDatos["precio_compra"]);

                                    hoja.Cell(fila, 5).Value =
                                        Convert.ToDecimal(
                                            readerDatos["subtotal"]);

                                    fila++;
                                }

                                // Formato numérico
                                hoja.Column(3).Style.NumberFormat.Format = "0.###";
                                hoja.Column(4).Style.NumberFormat.Format = "$#,##0.00";
                                hoja.Column(5).Style.NumberFormat.Format = "$#,##0.00";

                                // Ajustar columnas
                                hoja.Columns().AdjustToContents();

                                // Congelar encabezado de productos
                                hoja.SheetView.FreezeRows(5);

                                libro.SaveAs(dialogo.FileName);
                            }

                            MessageBox.Show(
                                "El detalle de la compra se exportó correctamente.",
                                "Exportación completada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        public static void ExportarDetalleCompraPdf(int idCompra)
        {
            using (var conexion = DB.GetConnection())
            {
                conexion.Open();

                string query = @"
SELECT
    c.folio,
    c.fecha_compra,
    pr.nombre AS proveedor,
    u.nombre AS usuario,
    p.nombre AS producto,
    p.modelo,
    cd.cantidad,
    cd.precio_compra,
    cd.subtotal
FROM compras c
INNER JOIN compras_detalle cd
    ON c.id_compra = cd.id_compra
INNER JOIN productos p
    ON cd.id_producto = p.id_producto
LEFT JOIN proveedores pr
    ON c.id_proveedor = pr.id_proveedor
LEFT JOIN usuarios u
    ON c.id_usuario = u.id_usuario
WHERE c.id_compra = @idCompra
ORDER BY cd.id_detalle;";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show(
                                "La compra seleccionada no tiene productos para exportar.",
                                "Exportar PDF",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            return;
                        }

                        var datos = new List<DetalleCompraPdf>();

                        while (reader.Read())
                        {
                            datos.Add(new DetalleCompraPdf
                            {
                                Folio = reader["folio"].ToString(),

                                Fecha = Convert.ToDateTime(
                                    reader["fecha_compra"]),

                                Proveedor = reader["proveedor"] == DBNull.Value
                                    ? ""
                                    : reader["proveedor"].ToString(),

                                Usuario = reader["usuario"] == DBNull.Value
                                    ? ""
                                    : reader["usuario"].ToString(),

                                Producto = reader["producto"].ToString(),

                                Modelo = reader["modelo"] == DBNull.Value
                                    ? ""
                                    : reader["modelo"].ToString(),

                                Cantidad = Convert.ToDecimal(
                                    reader["cantidad"]),

                                PrecioCompra = Convert.ToDecimal(
                                    reader["precio_compra"]),

                                Subtotal = Convert.ToDecimal(
                                    reader["subtotal"])
                            });
                        }

                        if (datos.Count == 0)
                            return;

                        string folio = datos[0].Folio;

                        using (SaveFileDialog dialogo = new SaveFileDialog())
                        {
                            dialogo.Filter =
                                "Archivo PDF (*.pdf)|*.pdf";

                            dialogo.Title =
                                "Guardar detalle de compra en PDF";

                            dialogo.FileName =
                                "Detalle_" +
                                folio +
                                "_" +
                                DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                                ".pdf";

                            if (dialogo.ShowDialog() != DialogResult.OK)
                                return;

                            Document.Create(document =>
                            {
                                document.Page(page =>
                                {
                                    page.Size(PageSizes.A4);
                                    page.Margin(30);

                                    page.Header()
                                        .Text("DETALLE DE COMPRA")
                                        .Bold()
                                        .FontSize(18)
                                        .AlignCenter();

                                    page.Content()
                                        .PaddingVertical(15)
                                        .Column(columna =>
                                        {
                                            columna.Spacing(10);

                                            columna.Item()
                                                .Row(fila =>
                                                {
                                                    fila.RelativeItem()
                                                        .Text(texto =>
                                                        {
                                                            texto.Span("Folio: ")
                                                                .Bold();

                                                            texto.Span(
                                                                datos[0].Folio);
                                                        });

                                                    fila.RelativeItem()
                                                        .Text(texto =>
                                                        {
                                                            texto.Span("Fecha: ")
                                                                .Bold();

                                                            texto.Span(
                                                                datos[0]
                                                                    .Fecha
                                                                    .ToString(
                                                                        "dd/MM/yyyy HH:mm"));
                                                        });
                                                });

                                            columna.Item()
                                                .Row(fila =>
                                                {
                                                    fila.RelativeItem()
                                                        .Text(texto =>
                                                        {
                                                            texto.Span("Proveedor: ")
                                                                .Bold();

                                                            texto.Span(
                                                                datos[0].Proveedor);
                                                        });

                                                    fila.RelativeItem()
                                                        .Text(texto =>
                                                        {
                                                            texto.Span("Usuario: ")
                                                                .Bold();

                                                            texto.Span(
                                                                datos[0].Usuario);
                                                        });
                                                });

                                            columna.Item()
                                                .PaddingTop(10)
                                                .Table(tabla =>
                                                {
                                                    tabla.ColumnsDefinition(
                                                        columnas =>
                                                        {
                                                            columnas.RelativeColumn(3);
                                                            columnas.RelativeColumn(2);
                                                            columnas.RelativeColumn(1);
                                                            columnas.RelativeColumn(1.5f);
                                                            columnas.RelativeColumn(1.5f);
                                                        });

                                                    tabla.Header(encabezado =>
                                                    {
                                                        encabezado.Cell()
                                                            .Element(EstiloEncabezado)
                                                            .Text("Producto");

                                                        encabezado.Cell()
                                                            .Element(EstiloEncabezado)
                                                            .Text("Modelo");

                                                        encabezado.Cell()
                                                            .Element(EstiloEncabezado)
                                                            .AlignRight()
                                                            .Text("Cantidad");

                                                        encabezado.Cell()
                                                            .Element(EstiloEncabezado)
                                                            .AlignRight()
                                                            .Text("Precio compra");

                                                        encabezado.Cell()
                                                            .Element(EstiloEncabezado)
                                                            .AlignRight()
                                                            .Text("Subtotal");
                                                    });

                                                    foreach (var item in datos)
                                                    {
                                                        tabla.Cell()
                                                            .Element(EstiloCelda)
                                                            .Text(item.Producto);

                                                        tabla.Cell()
                                                            .Element(EstiloCelda)
                                                            .Text(item.Modelo);

                                                        tabla.Cell()
                                                            .Element(EstiloCelda)
                                                            .AlignRight()
                                                            .Text(
                                                                item.Cantidad
                                                                    .ToString("N2"));

                                                        tabla.Cell()
                                                            .Element(EstiloCelda)
                                                            .AlignRight()
                                                            .Text(
                                                                "$" +
                                                                item.PrecioCompra
                                                                    .ToString("N2"));

                                                        tabla.Cell()
                                                            .Element(EstiloCelda)
                                                            .AlignRight()
                                                            .Text(
                                                                "$" +
                                                                item.Subtotal
                                                                    .ToString("N2"));
                                                    }
                                                });

                                            decimal total = datos.Sum(
                                                x => x.Subtotal);

                                            columna.Item()
                                                .PaddingTop(10)
                                                .AlignRight()
                                                .Text(texto =>
                                                {
                                                    texto.Span("TOTAL: ")
                                                        .Bold();

                                                    texto.Span(
                                                        "$" +
                                                        total.ToString("N2"));
                                                });
                                        });

                                    page.Footer()
                                        .AlignCenter()
                                        .Text(texto =>
                                        {
                                            texto.Span("Página ");
                                            texto.CurrentPageNumber();
                                            texto.Span(" de ");
                                            texto.TotalPages();
                                        });
                                });
                            })
                            .GeneratePdf(dialogo.FileName);

                            MessageBox.Show(
                                "El detalle de la compra se exportó correctamente.",
                                "Exportación completada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        public static void ExportarHistorialComprasPdf(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay compras para exportar.",
                    "Exportar PDF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dialogo.Title = "Guardar historial de compras en PDF";

                dialogo.FileName =
                    "Historial_Compras_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                    ".pdf";

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                var compras = new List<HistorialCompraPdf>();

                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    if (fila.Cells.Count < 7)
                        continue;

                    int idCompra = Convert.ToInt32(fila.Cells[0].Value);

                    string folio = fila.Cells[1].Value?.ToString() ?? "";
                    string fecha = fila.Cells[2].Value?.ToString() ?? "";
                    string proveedor = fila.Cells[3].Value?.ToString() ?? "";
                    string usuario = fila.Cells[4].Value?.ToString() ?? "";
                    decimal total = Convert.ToDecimal(fila.Cells[5].Value);
                    string estado = fila.Cells[6].Value?.ToString() ?? "";

                    compras.Add(new HistorialCompraPdf
                    {
                        IdCompra = idCompra,
                        Folio = folio,
                        Fecha = fecha,
                        Proveedor = proveedor,
                        Usuario = usuario,
                        Total = total,
                        Estado = estado
                    });
                }

                if (compras.Count == 0)
                {
                    MessageBox.Show(
                        "No hay registros válidos para exportar.",
                        "Exportar PDF",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                decimal totalGeneral = compras.Sum(x => x.Total);

                Document.Create(document =>
                {
                    document.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(30);

                        page.Header()
                            .Text("HISTORIAL DE COMPRAS")
                            .Bold()
                            .FontSize(18)
                            .AlignCenter();

                        page.Content()
                            .PaddingVertical(15)
                            .Column(columna =>
                            {
                                columna.Spacing(10);

                                columna.Item()
                                    .Text(texto =>
                                    {
                                        texto.Span("Fecha de generación: ")
                                            .Bold();

                                        texto.Span(
                                            DateTime.Now.ToString(
                                                "dd/MM/yyyy HH:mm"));
                                    });

                                columna.Item()
                                    .Table(tabla =>
                                    {
                                        tabla.ColumnsDefinition(columnas =>
                                        {
                                            columnas.RelativeColumn(1.5f);
                                            columnas.RelativeColumn(1.7f);
                                            columnas.RelativeColumn(2.5f);
                                            columnas.RelativeColumn(2);
                                            columnas.RelativeColumn(1.5f);
                                            columnas.RelativeColumn(1.5f);
                                        });

                                        tabla.Header(encabezado =>
                                        {
                                            encabezado.Cell()
                                                .Element(EstiloEncabezado)
                                                .Text("Folio");

                                            encabezado.Cell()
                                                .Element(EstiloEncabezado)
                                                .Text("Fecha");

                                            encabezado.Cell()
                                                .Element(EstiloEncabezado)
                                                .Text("Proveedor");

                                            encabezado.Cell()
                                                .Element(EstiloEncabezado)
                                                .Text("Usuario");

                                            encabezado.Cell()
                                                .Element(EstiloEncabezado)
                                                .AlignRight()
                                                .Text("Total");

                                            encabezado.Cell()
                                                .Element(EstiloEncabezado)
                                                .Text("Estado");
                                        });

                                        foreach (var compra in compras)
                                        {
                                            tabla.Cell()
                                                .Element(EstiloCelda)
                                                .Text(compra.Folio);

                                            tabla.Cell()
                                                .Element(EstiloCelda)
                                                .Text(compra.Fecha);

                                            tabla.Cell()
                                                .Element(EstiloCelda)
                                                .Text(compra.Proveedor);

                                            tabla.Cell()
                                                .Element(EstiloCelda)
                                                .Text(compra.Usuario);

                                            tabla.Cell()
                                                .Element(EstiloCelda)
                                                .AlignRight()
                                                .Text(
                                                    "$" +
                                                    compra.Total.ToString("N2"));

                                            tabla.Cell()
                                                .Element(EstiloCelda)
                                                .Text(compra.Estado);
                                        }
                                    });

                                columna.Item()
                                    .PaddingTop(10)
                                    .AlignRight()
                                    .Text(texto =>
                                    {
                                        texto.Span("TOTAL GENERAL: ")
                                            .Bold();

                                        texto.Span(
                                            "$" +
                                            totalGeneral.ToString("N2"));
                                    });

                                columna.Item()
                                    .Text(texto =>
                                    {
                                        texto.Span("Compras mostradas: ")
                                            .Bold();

                                        texto.Span(
                                            compras.Count.ToString());
                                    });
                            });

                        page.Footer()
                            .AlignCenter()
                            .Text(texto =>
                            {
                                texto.Span("Página ");
                                texto.CurrentPageNumber();
                                texto.Span(" de ");
                                texto.TotalPages();
                            });
                    });
                })
                .GeneratePdf(dialogo.FileName);

                MessageBox.Show(
                    "El historial de compras se exportó correctamente.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        //aquí empieza exportar ventas

        public static void ExportarHistorialVentasExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay ventas para exportar.",
                    "Exportar a Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
                dialogo.Title = "Guardar historial de ventas";

                dialogo.FileName =
                    "Historial_Ventas_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                    ".xlsx";

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                using (var libro = new ClosedXML.Excel.XLWorkbook())
                {
                    var hoja = libro.Worksheets.Add("Historial de ventas");

                    hoja.Cell(1, 1).Value = "HISTORIAL DE VENTAS";
                    hoja.Range(1, 1, 1, 8).Merge();

                    hoja.Cell(1, 1).Style.Font.Bold = true;
                    hoja.Cell(1, 1).Style.Font.FontSize = 16;
                    hoja.Cell(1, 1).Style.Alignment.Horizontal =
                        ClosedXML.Excel.XLAlignmentHorizontalValues.Center;

                    string[] encabezados =
                    {
                "ID Venta",
                "Folio",
                "Fecha",
                "Usuario",
                "Socio",
                "Productos",
                "Total",
                "Estado"
            };

                    for (int i = 0; i < encabezados.Length; i++)
                    {
                        hoja.Cell(3, i + 1).Value = encabezados[i];
                    }

                    var encabezado = hoja.Range(3, 1, 3, 8);

                    encabezado.Style.Font.Bold = true;
                    encabezado.Style.Fill.BackgroundColor =
                        ClosedXML.Excel.XLColor.LightBlue;
                    encabezado.Style.Border.OutsideBorder =
                        ClosedXML.Excel.XLBorderStyleValues.Thin;
                    encabezado.Style.Border.InsideBorder =
                        ClosedXML.Excel.XLBorderStyleValues.Thin;

                    int filaExcel = 4;

                    decimal totalGeneral = 0;
                    int ventasExportadas = 0;

                    foreach (DataGridViewRow fila in dgv.Rows)
                    {
                        if (fila.IsNewRow)
                            continue;

                        if (fila.Cells.Count < 8)
                            continue;

                        hoja.Cell(filaExcel, 1).Value =
                            fila.Cells[0].Value?.ToString();

                        hoja.Cell(filaExcel, 2).Value =
                            fila.Cells[1].Value?.ToString();

                        hoja.Cell(filaExcel, 3).Value =
                            fila.Cells[2].Value?.ToString();

                        hoja.Cell(filaExcel, 4).Value =
                            fila.Cells[3].Value?.ToString();

                        hoja.Cell(filaExcel, 5).Value =
                            fila.Cells[4].Value?.ToString();

                        hoja.Cell(filaExcel, 6).Value =
                            fila.Cells[5].Value?.ToString();

                        decimal total = Convert.ToDecimal(
                            fila.Cells[6].Value);

                        hoja.Cell(filaExcel, 7).Value = total;

                        hoja.Cell(filaExcel, 8).Value =
                            fila.Cells[7].Value?.ToString();

                        totalGeneral += total;
                        ventasExportadas++;

                        filaExcel++;
                    }

                    if (ventasExportadas == 0)
                    {
                        MessageBox.Show(
                            "No hay registros válidos para exportar.",
                            "Exportar a Excel",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }

                    var rangoDatos =
                        hoja.Range(3, 1, filaExcel - 1, 8);

                    rangoDatos.Style.Border.OutsideBorder =
                        ClosedXML.Excel.XLBorderStyleValues.Thin;

                    rangoDatos.Style.Border.InsideBorder =
                        ClosedXML.Excel.XLBorderStyleValues.Thin;

                    hoja.Cell(filaExcel + 1, 6).Value =
                        "TOTAL GENERAL:";

                    hoja.Cell(filaExcel + 1, 6).Style.Font.Bold = true;

                    hoja.Cell(filaExcel + 1, 7).Value =
                        totalGeneral;

                    hoja.Cell(filaExcel + 1, 7).Style.Font.Bold = true;

                    hoja.Cell(filaExcel + 2, 6).Value =
                        "VENTAS MOSTRADAS:";

                    hoja.Cell(filaExcel + 2, 6).Style.Font.Bold = true;

                    hoja.Cell(filaExcel + 2, 7).Value =
                        ventasExportadas;

                    hoja.Columns().AdjustToContents();

                    hoja.Column(1).Width = 12;
                    hoja.Column(2).Width = 18;
                    hoja.Column(3).Width = 20;
                    hoja.Column(4).Width = 20;
                    hoja.Column(5).Width = 20;
                    hoja.Column(6).Width = 12;
                    hoja.Column(7).Width = 15;
                    hoja.Column(8).Width = 15;

                    hoja.SheetView.FreezeRows(3);

                    libro.SaveAs(dialogo.FileName);
                }

                MessageBox.Show(
                    "El historial de ventas se exportó correctamente.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public static void ExportarHistorialVentasPdf(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay ventas para exportar.",
                    "Exportar a PDF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dialogo.Title = "Guardar historial de ventas";

                dialogo.FileName =
                    "Historial_Ventas_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                    ".pdf";

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                var documento = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4.Landscape());
                        page.Margin(30);

                        page.Header()
                            .AlignCenter()
                            .Text("HISTORIAL DE VENTAS")
                            .Bold()
                            .FontSize(18);

                        page.Content()
                            .PaddingTop(20)
                            .Column(columna =>
                            {
                                columna.Item().Table(tabla =>
                                {
                                    tabla.ColumnsDefinition(columnas =>
                                    {
                                        columnas.ConstantColumn(45);
                                        columnas.ConstantColumn(75);
                                        columnas.ConstantColumn(85);
                                        columnas.RelativeColumn();
                                        columnas.RelativeColumn();
                                        columnas.ConstantColumn(55);
                                        columnas.ConstantColumn(75);
                                        columnas.ConstantColumn(70);
                                    });

                                    string[] encabezados =
                                    {
                                "ID Venta",
                                "Folio",
                                "Fecha",
                                "Usuario",
                                "Socio",
                                "Productos",
                                "Total",
                                "Estado"
                                    };

                                    foreach (string encabezado in encabezados)
                                    {
                                        tabla.Cell()
                                            .Background(Colors.Blue.Lighten4)
                                            .Border(1)
                                            .Padding(5)
                                            .Text(encabezado)
                                            .Bold()
                                            .FontSize(8);
                                    }

                                    decimal totalGeneral = 0;
                                    int ventasExportadas = 0;

                                    foreach (DataGridViewRow fila in dgv.Rows)
                                    {
                                        if (fila.IsNewRow)
                                            continue;

                                        if (fila.Cells.Count < 8)
                                            continue;

                                        string[] datos =
                                        {
                                    fila.Cells[0].Value?.ToString() ?? "",
                                    fila.Cells[1].Value?.ToString() ?? "",
                                    fila.Cells[2].Value?.ToString() ?? "",
                                    fila.Cells[3].Value?.ToString() ?? "",
                                    fila.Cells[4].Value?.ToString() ?? "",
                                    fila.Cells[5].Value?.ToString() ?? "",
                                    fila.Cells[6].Value?.ToString() ?? "",
                                    fila.Cells[7].Value?.ToString() ?? ""
                                        };

                                        decimal total =
                                            Convert.ToDecimal(fila.Cells[6].Value);

                                        totalGeneral += total;
                                        ventasExportadas++;

                                        foreach (string dato in datos)
                                        {
                                            tabla.Cell()
                                                .Border(1)
                                                .Padding(4)
                                                .Text(dato)
                                                .FontSize(7);
                                        }
                                    }

                                    tabla.Cell()
                                        .ColumnSpan(6)
                                        .AlignRight()
                                        .Padding(5)
                                        .Text("TOTAL GENERAL:")
                                        .Bold()
                                        .FontSize(9);

                                    tabla.Cell()
                                        .Border(1)
                                        .Padding(5)
                                        .Text("$" + totalGeneral.ToString("N2"))
                                        .Bold()
                                        .FontSize(9);

                                    tabla.Cell()
                                        .Border(1)
                                        .Padding(5)
                                        .Text(ventasExportadas.ToString())
                                        .Bold()
                                        .FontSize(9);
                                });
                            });

                        page.Footer()
                            .AlignCenter()
                            .Text(text =>
                            {
                                text.Span("Generado: ");
                                text.Span(
                                    DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                            });
                    });
                });

                documento.GeneratePdf(dialogo.FileName);

                MessageBox.Show(
                    "El historial de ventas se exportó correctamente a PDF.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public static void ExportarDetalleVentaExcel(int idVenta)
        {
            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
                dialogo.Title = "Guardar detalle de venta";

                dialogo.FileName =
                    "Detalle_Venta_" +
                    idVenta +
                    "_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                    ".xlsx";

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                using (var conexion = DB.GetConnection())
                {
                    conexion.Open();

                    string query = @"
SELECT
    v.folio,
    v.fecha_venta,
    u.nombre AS usuario,
    COALESCE(s.nombre_socio, 'MOSTRADOR') AS socio,
    p.nombre AS producto,
    dv.cantidad,
    dv.precio_unitario,
    dv.descuento,
    dv.subtotal
FROM ventas v
LEFT JOIN usuarios u
    ON v.id_usuario = u.id_usuario
LEFT JOIN socios s
    ON v.id_socio = s.id_socio
INNER JOIN detalle_ventas dv
    ON v.id_venta = dv.id_venta
INNER JOIN productos p
    ON dv.id_producto = p.id_producto
WHERE v.id_venta = @idVenta
ORDER BY dv.id_detalle";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show(
                                "No se encontró el detalle de la venta seleccionada.",
                                "Exportar a Excel",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            return;
                        }

                        using (var libro = new ClosedXML.Excel.XLWorkbook())
                        {
                            var hoja = libro.Worksheets.Add("Detalle de venta");

                            // ENCABEZADO
                            hoja.Cell(1, 1).Value = "DETALLE DE VENTA";
                            hoja.Range(1, 1, 1, 5).Merge();

                            hoja.Cell(1, 1).Style.Font.Bold = true;
                            hoja.Cell(1, 1).Style.Font.FontSize = 16;
                            hoja.Cell(1, 1).Style.Alignment.Horizontal =
                                ClosedXML.Excel.XLAlignmentHorizontalValues.Center;

                            reader.Read();

                            string folio = reader["folio"].ToString();
                            string fecha = Convert.ToDateTime(
                                reader["fecha_venta"]).ToString("dd/MM/yyyy HH:mm");
                            string usuario = reader["usuario"].ToString();
                            string socio = reader["socio"].ToString();

                            hoja.Cell(3, 1).Value = "Folio:";
                            hoja.Cell(3, 2).Value = folio;

                            hoja.Cell(4, 1).Value = "Fecha:";
                            hoja.Cell(4, 2).Value = fecha;

                            hoja.Cell(5, 1).Value = "Usuario:";
                            hoja.Cell(5, 2).Value = usuario;

                            hoja.Cell(6, 1).Value = "Socio:";
                            hoja.Cell(6, 2).Value = socio;

                            hoja.Range(3, 1, 6, 1).Style.Font.Bold = true;

                            // ENCABEZADOS DEL DETALLE
                            string[] encabezados =
                            {
                        "Producto",
                        "Cantidad",
                        "Precio unitario",
                        "Descuento",
                        "Subtotal"
                    };

                            for (int i = 0; i < encabezados.Length; i++)
                            {
                                hoja.Cell(8, i + 1).Value = encabezados[i];
                            }

                            var encabezado = hoja.Range(8, 1, 8, 5);

                            encabezado.Style.Font.Bold = true;
                            encabezado.Style.Fill.BackgroundColor =
                                ClosedXML.Excel.XLColor.LightBlue;

                            encabezado.Style.Border.OutsideBorder =
                                ClosedXML.Excel.XLBorderStyleValues.Thin;

                            encabezado.Style.Border.InsideBorder =
                                ClosedXML.Excel.XLBorderStyleValues.Thin;

                            int filaExcel = 9;

                            decimal total = 0;
                            decimal cantidadProductos = 0;

                            do
                            {
                                decimal cantidad = Convert.ToDecimal(
                                    reader["cantidad"]);

                                decimal precioUnitario = Convert.ToDecimal(
                                    reader["precio_unitario"]);

                                decimal descuento = Convert.ToDecimal(
                                    reader["descuento"]);

                                decimal subtotal = Convert.ToDecimal(
                                    reader["subtotal"]);

                                hoja.Cell(filaExcel, 1).Value =
                                    reader["producto"].ToString();

                                hoja.Cell(filaExcel, 2).Value =
                                    cantidad;

                                hoja.Cell(filaExcel, 3).Value =
                                    precioUnitario;

                                hoja.Cell(filaExcel, 4).Value =
                                    descuento;

                                hoja.Cell(filaExcel, 5).Value =
                                    subtotal;

                                cantidadProductos += cantidad;
                                total += subtotal;

                                filaExcel++;
                            }
                            while (reader.Read());

                            // FORMATOS NUMÉRICOS
                            hoja.Range(9, 2, filaExcel - 1, 2)
                                .Style.NumberFormat.Format = "0.00";

                            hoja.Range(9, 3, filaExcel - 1, 5)
                                .Style.NumberFormat.Format = "$#,##0.00";

                            // BORDES
                            var rangoDetalle =
                                hoja.Range(8, 1, filaExcel - 1, 5);

                            rangoDetalle.Style.Border.OutsideBorder =
                                ClosedXML.Excel.XLBorderStyleValues.Thin;

                            rangoDetalle.Style.Border.InsideBorder =
                                ClosedXML.Excel.XLBorderStyleValues.Thin;

                            // RESUMEN
                            hoja.Cell(filaExcel + 1, 4).Value =
                                "TOTAL:";

                            hoja.Cell(filaExcel + 1, 4).Style.Font.Bold = true;

                            hoja.Cell(filaExcel + 1, 5).Value =
                                total;

                            hoja.Cell(filaExcel + 1, 5).Style.Font.Bold = true;

                            hoja.Cell(filaExcel + 2, 4).Value =
                                "PRODUCTOS:";

                            hoja.Cell(filaExcel + 2, 4).Style.Font.Bold = true;

                            hoja.Cell(filaExcel + 2, 5).Value =
                                cantidadProductos;

                            hoja.Cell(filaExcel + 2, 5).Style.Font.Bold = true;

                            // AJUSTE DE COLUMNAS
                            hoja.Columns().AdjustToContents();

                            hoja.Column(1).Width = 35;
                            hoja.Column(2).Width = 15;
                            hoja.Column(3).Width = 18;
                            hoja.Column(4).Width = 15;
                            hoja.Column(5).Width = 18;

                            hoja.SheetView.FreezeRows(8);

                            libro.SaveAs(dialogo.FileName);
                        }
                    }
                }

                MessageBox.Show(
                    "El detalle de la venta se exportó correctamente.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public static void ExportarDetalleVentaPdf(int idVenta)
        {
            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dialogo.Title = "Guardar detalle de venta";

                dialogo.FileName =
                    "Detalle_Venta_" +
                    idVenta +
                    "_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                    ".pdf";

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                using (var conexion = DB.GetConnection())
                {
                    conexion.Open();

                    string query = @"
SELECT
    v.folio,
    v.fecha_venta,
    u.nombre AS usuario,
    COALESCE(s.nombre_socio, 'MOSTRADOR') AS socio,
    p.nombre AS producto,
    dv.cantidad,
    dv.precio_unitario,
    dv.descuento,
    dv.subtotal
FROM ventas v
LEFT JOIN usuarios u
    ON v.id_usuario = u.id_usuario
LEFT JOIN socios s
    ON v.id_socio = s.id_socio
INNER JOIN detalle_ventas dv
    ON v.id_venta = dv.id_venta
INNER JOIN productos p
    ON dv.id_producto = p.id_producto
WHERE v.id_venta = @idVenta
ORDER BY dv.id_detalle";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show(
                                "No se encontró el detalle de la venta seleccionada.",
                                "Exportar a PDF",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            return;
                        }

                        string folio = "";
                        string fecha = "";
                        string usuario = "";
                        string socio = "";

                        var productos = new List<(string Producto,
                                                   decimal Cantidad,
                                                   decimal Precio,
                                                   decimal Descuento,
                                                   decimal Subtotal)>();

                        decimal total = 0;
                        decimal cantidadProductos = 0;

                        while (reader.Read())
                        {
                            if (string.IsNullOrEmpty(folio))
                            {
                                folio = reader["folio"].ToString();

                                fecha = Convert.ToDateTime(
                                    reader["fecha_venta"])
                                    .ToString("dd/MM/yyyy HH:mm");

                                usuario = reader["usuario"].ToString();
                                socio = reader["socio"].ToString();
                            }

                            decimal cantidad =
                                Convert.ToDecimal(reader["cantidad"]);

                            decimal precio =
                                Convert.ToDecimal(reader["precio_unitario"]);

                            decimal descuento =
                                Convert.ToDecimal(reader["descuento"]);

                            decimal subtotal =
                                Convert.ToDecimal(reader["subtotal"]);

                            productos.Add((
                                reader["producto"].ToString(),
                                cantidad,
                                precio,
                                descuento,
                                subtotal
                            ));

                            cantidadProductos += cantidad;
                            total += subtotal;
                        }

                        var documento = Document.Create(container =>
                        {
                            container.Page(page =>
                            {
                                page.Size(PageSizes.A4);
                                page.Margin(35);

                                page.Header()
                                    .AlignCenter()
                                    .Text("DETALLE DE VENTA")
                                    .Bold()
                                    .FontSize(18);

                                page.Content()
                                    .PaddingTop(20)
                                    .Column(columna =>
                                    {
                                        columna.Item()
                                            .Table(tabla =>
                                            {
                                                tabla.ColumnsDefinition(columnas =>
                                                {
                                                    columnas.ConstantColumn(55);
                                                    columnas.RelativeColumn();
                                                });

                                                tabla.Cell()
                                                    .Padding(4)
                                                    .Text("Folio:")
                                                    .Bold();

                                                tabla.Cell()
                                                    .Padding(4)
                                                    .Text(folio);

                                                tabla.Cell()
                                                    .Padding(4)
                                                    .Text("Fecha:")
                                                    .Bold();

                                                tabla.Cell()
                                                    .Padding(4)
                                                    .Text(fecha);

                                                tabla.Cell()
                                                    .Padding(4)
                                                    .Text("Usuario:")
                                                    .Bold();

                                                tabla.Cell()
                                                    .Padding(4)
                                                    .Text(usuario);

                                                tabla.Cell()
                                                    .Padding(4)
                                                    .Text("Socio:")
                                                    .Bold();

                                                tabla.Cell()
                                                    .Padding(4)
                                                    .Text(socio);
                                            });

                                        columna.Item()
                                            .PaddingTop(20)
                                            .Table(tabla =>
                                            {
                                                tabla.ColumnsDefinition(columnas =>
                                                {
                                                    columnas.RelativeColumn(3);
                                                    columnas.ConstantColumn(65);
                                                    columnas.ConstantColumn(85);
                                                    columnas.ConstantColumn(70);
                                                    columnas.ConstantColumn(85);
                                                });

                                                string[] encabezados =
                                                {
                                            "Producto",
                                            "Cantidad",
                                            "Precio unitario",
                                            "Descuento",
                                            "Subtotal"
                                                };

                                                foreach (string encabezado in encabezados)
                                                {
                                                    tabla.Cell()
                                                        .Background(Colors.Blue.Lighten4)
                                                        .Border(1)
                                                        .Padding(5)
                                                        .Text(encabezado)
                                                        .Bold()
                                                        .FontSize(8);
                                                }

                                                foreach (var producto in productos)
                                                {
                                                    tabla.Cell()
                                                        .Border(1)
                                                        .Padding(4)
                                                        .Text(producto.Producto)
                                                        .FontSize(8);

                                                    tabla.Cell()
                                                        .Border(1)
                                                        .Padding(4)
                                                        .AlignRight()
                                                        .Text(
                                                            producto.Cantidad
                                                                .ToString("N2"))
                                                        .FontSize(8);

                                                    tabla.Cell()
                                                        .Border(1)
                                                        .Padding(4)
                                                        .AlignRight()
                                                        .Text(
                                                            "$" +
                                                            producto.Precio
                                                                .ToString("N2"))
                                                        .FontSize(8);

                                                    tabla.Cell()
                                                        .Border(1)
                                                        .Padding(4)
                                                        .AlignRight()
                                                        .Text(
                                                            producto.Descuento
                                                                .ToString("N2"))
                                                        .FontSize(8);

                                                    tabla.Cell()
                                                        .Border(1)
                                                        .Padding(4)
                                                        .AlignRight()
                                                        .Text(
                                                            "$" +
                                                            producto.Subtotal
                                                                .ToString("N2"))
                                                        .FontSize(8);
                                                }

                                                tabla.Cell()
                                                    .ColumnSpan(4)
                                                    .AlignRight()
                                                    .Padding(6)
                                                    .Text("TOTAL:")
                                                    .Bold()
                                                    .FontSize(10);

                                                tabla.Cell()
                                                    .Padding(6)
                                                    .AlignRight()
                                                    .Text(
                                                        "$" +
                                                        total.ToString("N2"))
                                                    .Bold()
                                                    .FontSize(10);
                                            });

                                        columna.Item()
                                            .PaddingTop(10)
                                            .AlignRight()
                                            .Text(
                                                "Productos: " +
                                                cantidadProductos.ToString("N2"))
                                            .Bold();
                                    });

                                page.Footer()
                                    .AlignCenter()
                                    .Text(text =>
                                    {
                                        text.Span("Generado: ");
                                        text.Span(
                                            DateTime.Now.ToString(
                                                "dd/MM/yyyy HH:mm:ss"));
                                    });
                            });
                        });

                        documento.GeneratePdf(dialogo.FileName);
                    }
                }

                MessageBox.Show(
                    "El detalle de la venta se exportó correctamente a PDF.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
