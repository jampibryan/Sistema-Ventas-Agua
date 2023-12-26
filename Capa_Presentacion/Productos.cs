using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Productos : Form
    {
        CN_Productos objetoCN = new CN_Productos();

        private string idProducto = null;
        private string valor = null;

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            listar_Categoria_Producto();
            listar_Marca_Producto();

            btn_eliminarProducto.Enabled = true;
        }

        private void MostrarProductos()
        {
            CN_Productos objetoCN = new CN_Productos();
            dataGrid_Productos.DataSource = objetoCN.Listar_Productos();
            dataGrid_Productos.Columns["Precio Unidad"].DefaultCellStyle.Format = "0.##";

            txt_buscarProducto.Clear();
        }

        private void btn_listarProductos_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void listar_Categoria_Producto()
        {
            cmb_CategoriaProducto.DataSource = objetoCN.Listar_CategoriaProducto();
            cmb_CategoriaProducto.DisplayMember = "descripcionCP";
            cmb_CategoriaProducto.ValueMember = "idCategoriaProducto";
        }

        private void listar_Marca_Producto()
        {
            cmb_MarcaProducto.DataSource = objetoCN.Listar_MarcaProducto();
            cmb_MarcaProducto.DisplayMember = "descripcionMP";
            cmb_MarcaProducto.ValueMember = "idMarcaProducto";
        }

        private void txt_buscarProducto_TextChanged(object sender, EventArgs e)
        {
            CN_Productos objetoCN = new CN_Productos();
            valor = txt_buscarProducto.Text;
            dataGrid_Productos.DataSource = objetoCN.Buscar_Productos(valor);
        }

        private string borrarEspacios(string palabraEspacios)
        {
            char[] charsToTrim = { '*', '(', ')', ' ', '\'' };

            string Texto = palabraEspacios.Trim(charsToTrim);

            return Texto;
        }

        //REGISTRAR NUEVA MARCA DE PRODUCTO
        private void btn_registrarNewMarca_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Insertar_MarcaProducto(borrarEspacios(txt_newMarcaProducto.Text));

                MessageBox.Show("Se registró exitosamente una nueva Marca");
                listar_Marca_Producto();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la Marca" + ex);
            }
        }

       

        private void btn_registrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Insertar_Producto(cmb_CategoriaProducto.SelectedValue.ToString(),
                                    cmb_MarcaProducto.SelectedValue.ToString(),
                                    txt_precioProducto.Text);

                MessageBox.Show("Se registró exitosamente al Producto");
                MostrarProductos();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar al Producto" + ex);
            }
        }


        private void btn_editarProducto_Click(object sender, EventArgs e)
        {
            if (dataGrid_Productos.SelectedRows.Count > 0)
            {
                idProducto = dataGrid_Productos.CurrentRow.Cells["Id"].Value.ToString();

                cmb_CategoriaProducto.Text = dataGrid_Productos.CurrentRow.Cells["Categoria"].Value.ToString();
                cmb_MarcaProducto.Text = dataGrid_Productos.CurrentRow.Cells["Marca"].Value.ToString();

                decimal valor = Convert.ToDecimal(dataGrid_Productos.CurrentRow.Cells["Precio Unidad"].Value.ToString());
                txt_precioProducto.Text = valor.ToString("0.##");

                btn_registrarProducto.Visible = false;
                btn_actualizarProducto.Visible = true;
            }

            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a editar
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btn_actualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Editar_Producto(idProducto, 
                                    cmb_CategoriaProducto.SelectedValue.ToString(),
                                    cmb_MarcaProducto.SelectedValue.ToString(),
                                    borrarEspacios(txt_precioProducto.Text));

                MessageBox.Show("Se actualizó correctamente al Producto");

                btn_registrarProducto.Visible = true;
                btn_actualizarProducto.Visible = false;
                MostrarProductos();
                limpiarForm();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex);
            }
        }


        private void btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGrid_Productos.SelectedRows.Count > 0)
            {
                idProducto = dataGrid_Productos.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.Eliminar_Producto(idProducto);
                MessageBox.Show("Producto eliminado exitosamente");
                MostrarProductos();
            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a eliminar
            {
                MessageBox.Show("Seleccione una fila para eliminar por favor");
            }
        }


        private void btn_limpiarProducto_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void limpiarForm()
        {
            txt_precioProducto.Clear();
            txt_newMarcaProducto.Clear();

            btn_registrarProducto.Visible = true;
            btn_actualizarProducto.Visible = false;
        }

    }
}
