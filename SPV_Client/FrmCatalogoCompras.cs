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

namespace SPV_Client
{
    public partial class FrmCatalogoCompras : Form
    {
        private void CargarCatalogoCompras()
        {
            dgvCatalogoCompras.Rows.Clear();

            using (MySqlConnection conn = DB.GetConnection())
            {
                conn.Open();

                string campoBusqueda = "p.nombre";

                switch (cmbFiltroCatalogo.Text)
                {
                    case "Código Compra":
                        campoBusqueda = "p.codigo_compra";
                        break;

                    case "Código Barras":
                        campoBusqueda = "p.codigo_barras";
                        break;

                    case "Marca":
                        campoBusqueda = "m.nombre_marca";
                        break;

                    case "Proveedor":
                        campoBusqueda = "pr.nombre";
                        break;

                    default:
                        campoBusqueda = "p.nombre";
                        break;
                }

                string sql = $@"
SELECT
    p.id_producto,
    p.codigo_compra,
    p.codigo_barras,
    p.nombre,
    m.nombre_marca AS marca,
    p.modelo,
    pr.nombre AS proveedor,
    p.precio_compra,
    (
        SELECT MAX(c.fecha_compra)
        FROM compras c
        INNER JOIN compras_detalle cd
            ON cd.id_compra = c.id_compra
        WHERE cd.id_producto = p.id_producto
    ) AS ultima_compra
FROM productos p
LEFT JOIN marcas m
    ON m.id_marca = p.id_marca
LEFT JOIN proveedores pr
    ON pr.id_proveedor = p.id_proveedor
WHERE (@buscar = '' OR {campoBusqueda} LIKE CONCAT('%', @buscar, '%'))
ORDER BY p.nombre;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@buscar", txtBuscarCatalogo.Text.Trim());

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvCatalogoCompras.Rows.Add(
                                dr["id_producto"],
                                dr["codigo_compra"],
                                dr["codigo_barras"],
                                dr["nombre"],
                                dr["marca"],
                                dr["modelo"],
                                dr["proveedor"],
                                Convert.ToDecimal(dr["precio_compra"]),
                                dr["ultima_compra"] == DBNull.Value
                                    ? ""
                                    : Convert.ToDateTime(dr["ultima_compra"]).ToString("dd/MM/yyyy")
                            );
                        }
                    }
                }
            }
        }
        public FrmCatalogoCompras()
        {
            InitializeComponent();
        }

        private void FrmCatalogoCompras_Load(object sender, EventArgs e)
        {
            cmbFiltroCatalogo.SelectedIndex = 0;
            CargarCatalogoCompras();
        }


        private void btnHistorialProducto_Click(object sender, EventArgs e)
        {
            if (dgvCatalogoCompras.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un producto.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int idProducto = Convert.ToInt32(
                dgvCatalogoCompras.CurrentRow.Cells["colIdProducto"].Value);

            FormManager.AbrirFormularioUnico<FrmConsultaProducto>(idProducto);
        }

        private void btnBuscarCatalogo_Click(object sender, EventArgs e)
        {
            CargarCatalogoCompras();
        }

        private void btnLimpiarCatalogo_Click(object sender, EventArgs e)
        {
            txtBuscarCatalogo.Clear();

            cmbFiltroCatalogo.SelectedIndex = 0;

            txtBuscarCatalogo.Focus();

            CargarCatalogoCompras();
        }

        private void txtBuscarCatalogo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarCatalogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarCatalogo.PerformClick();

                e.SuppressKeyPress = true;
            }
        }
    }
}
