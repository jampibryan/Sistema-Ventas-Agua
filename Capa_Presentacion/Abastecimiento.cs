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
    public partial class Abastecimiento : Form
    {
        CN_Abastecimiento objetoCN = new CN_Abastecimiento();

        private string idAbastecimiento = null;
        private string valor = null;

        public Abastecimiento()
        {
            InitializeComponent();
        }

        private void Abastecimiento_Load(object sender, EventArgs e)
        {
            ListarProductos();
            ListarProveedores();

            MostrarAlmacen();
        }

        private void MostrarAlmacen()
        {
            CN_Abastecimiento objetoCN = new CN_Abastecimiento();
            dataGrid_Almacen.DataSource = objetoCN.Listar_Almacen();
        }

        private void MostrarAbastecimientos()
        {
            CN_Abastecimiento objetoCN = new CN_Abastecimiento();
            dataGrid_Abastecimientos.DataSource = objetoCN.Listar_Abastecimiento();

            dataGrid_Abastecimientos.Columns["Costo"].DefaultCellStyle.Format = "0.##";
            dataGrid_Abastecimientos.Columns["Costo Total"].DefaultCellStyle.Format = "0.##";

        }


        private void btn_listarAbastecimientos_Click(object sender, EventArgs e)
        {
            MostrarAbastecimientos();
        }


        private void ListarProductos()
        {
            cmb_Producto.DataSource = objetoCN.Listar_Marca_Producto();
            cmb_Producto.DisplayMember = "descripcionMP";
            cmb_Producto.ValueMember = "idProducto";
        }

        private void ListarProveedores()
        {
            cmb_Proveedor.DataSource = objetoCN.Listar_Proveedor();
            cmb_Proveedor.DisplayMember = "Proveedor";
            cmb_Proveedor.ValueMember = "idProveedor";
        }


        private void txt_buscarAbastecimiento_TextChanged(object sender, EventArgs e)
        {
        }


        private void btnBuscarAbastecimiento_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Abastecimiento objetoCN = new CN_Abastecimiento();

                DateTime fecha = dateTimeP_Abastecimiento.Value;
                valor = fecha.ToShortDateString().ToString();

                dataGrid_Abastecimientos.DataSource = objetoCN.Buscar_Abastecimiento(valor);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar dicho Abastecimiento" + ex);

            }
        }

        private string borrarEspacios(string palabraEspacios)
        {
            char[] charsToTrim = { '*', '(', ')', ' ', '\'' };

            string Texto = palabraEspacios.Trim(charsToTrim);

            return Texto;
        }

        private void btn_registrarAbastecimiento_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Insertar_Abastecimiento(cmb_Producto.SelectedValue.ToString(),
                                    cmb_Proveedor.SelectedValue.ToString(),
                                    borrarEspacios(txt_cantidadPA.Text),
                                    borrarEspacios(txt_precioProducto.Text));

                MessageBox.Show("Se registró exitosamente el Abastecimiento");
                MostrarAbastecimientos();
                MostrarAlmacen();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el Abastecimiento" + ex);
            }
        }



        private void btn_editarAbastecimiento_Click(object sender, EventArgs e)
        {
            if (dataGrid_Abastecimientos.SelectedRows.Count > 0)
            {
                idAbastecimiento = dataGrid_Abastecimientos.CurrentRow.Cells["Id"].Value.ToString();

                cmb_Producto.Text = dataGrid_Abastecimientos.CurrentRow.Cells["Producto"].Value.ToString();
                cmb_Proveedor.Text = dataGrid_Abastecimientos.CurrentRow.Cells["Proveedor"].Value.ToString();
                txt_cantidadPA.Text = dataGrid_Abastecimientos.CurrentRow.Cells["Cantidad"].Value.ToString();
                //txt_precioProducto.Text = dataGrid_Abastecimientos.CurrentRow.Cells["Precio"].Value.ToString();

                decimal precio = Convert.ToDecimal(dataGrid_Abastecimientos.CurrentRow.Cells["Costo"].Value.ToString());
                txt_precioProducto.Text = precio.ToString("0.##");

                btn_registrarAbastecimiento.Visible = false;
                btn_actualizarAbastecimiento.Visible = true;
            }

            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a editar
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btn_actualizarAbastecimiento_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Editar_Abastecimiento(idAbastecimiento, cmb_Producto.SelectedValue.ToString(),
                                    cmb_Proveedor.SelectedValue.ToString(),
                                    borrarEspacios(txt_cantidadPA.Text),
                                    borrarEspacios(txt_precioProducto.Text));

                MessageBox.Show("Se actualizó correctamente el Abastecimiento");

                btn_registrarAbastecimiento.Visible = true;
                btn_actualizarAbastecimiento.Visible = false;
                MostrarAbastecimientos();
                MostrarAlmacen();
                limpiarForm();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex);
            }
        }

        private void btn_eliminarAbastecimiento_Click(object sender, EventArgs e)
        {
            if (dataGrid_Abastecimientos.SelectedRows.Count > 0)
            {
                idAbastecimiento = dataGrid_Abastecimientos.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.Eliminar_Abastecimiento(idAbastecimiento);
                MessageBox.Show("Colaborador eliminado exitosamente");
                MostrarAbastecimientos();
                MostrarAlmacen();
            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a eliminar
            {
                MessageBox.Show("Seleccione una fila para eliminar por favor");
            }
        }

        private void btn_limpiarAbastecimiento_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void limpiarForm()
        {
            txt_cantidadPA.Clear();
            
            btn_registrarAbastecimiento.Visible = true;
            btn_actualizarAbastecimiento.Visible = false;
        }

        private void txt_precioProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
