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
    public partial class Ventas : Form
    {
        CN_Ventas objetoCN = new CN_Ventas();

        private string idVenta = null;
        private string valorCliente = null;
        private string valorFecha = null;


        private string apellidosSeleccionado = null;


        public Ventas()
        {
            InitializeComponent();
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            ListarColaborador();
            ListarMarcaProducto();

            ListarAlmacen();
            ListarVentaDiaActual();
            MostrarClientes();
            BuscarDetalleVenta();
        }

        private void ListarAlmacen()
        {
            CN_Ventas objetoCN = new CN_Ventas();
            dataGrid_Almacen.DataSource = objetoCN.Listar_Almacen();
            dataGrid_Almacen.Columns["Precio"].DefaultCellStyle.Format = "0.##";
        }

        private void MostrarClientes()
        {
            CN_Ventas objetoCN = new CN_Ventas();
            dataGrid_ClienteVenta.DataSource = objetoCN.Listar_Clientes();
        }

        private void ListarColaborador()
        {
            cmb_Colaborador.DataSource = objetoCN.Listar_Colaborador();
            cmb_Colaborador.DisplayMember = "NombreCompletoColab";
            cmb_Colaborador.ValueMember = "IdColaborador";
        }


        private void ListarMarcaProducto()
        {
            cmb_Producto.DataSource = objetoCN.Listar_Marca_Producto();
            cmb_Producto.DisplayMember = "descripcionMP";
            cmb_Producto.ValueMember = "idProducto";
        }

        private void ListarVentaDiaActual()
        {
            CN_Ventas objetoCN = new CN_Ventas();
            dataGrid_Venta.DataSource = objetoCN.Listar_VentaDiaActual();
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Ventas objetoCN = new CN_Ventas();

                DateTime fecha = dateTimeP_Venta.Value;
                valorFecha = fecha.ToShortDateString().ToString();

                dataGrid_Venta.DataSource = objetoCN.Buscar_Ventas_Fecha(valorFecha);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar dicha Venta" + ex);

            }
        }


        private void BuscarDetalleVenta()
        {
            if (dataGrid_Venta.SelectedRows.Count > 0)
            {
                CN_Ventas objetoCN = new CN_Ventas();
                idVenta = dataGrid_Venta.CurrentRow.Cells["IdVenta"].Value.ToString();

                dataGrid_DetalleVenta.DataSource = objetoCN.Buscar_Detalle_Venta(idVenta);

                dataGrid_DetalleVenta.Columns["Pago Total"].DefaultCellStyle.Format = "0.##";
            }
        }

        private void txt_buscarClienteVenta_TextChanged(object sender, EventArgs e)
        {
            CN_Ventas objetoCN = new CN_Ventas();
            valorCliente = txt_buscarClienteVenta.Text;
            dataGrid_ClienteVenta.DataSource = objetoCN.Buscar_Clientes(valorCliente);
        }



        private void btn_registrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.insertar_Venta(cmb_Colaborador.SelectedValue.ToString(),
                                    dataGrid_ClienteVenta.CurrentRow.Cells["Id"].Value.ToString(),
                                    cmb_Producto.SelectedValue.ToString(),
                                    txt_cantidadP.Text);

                MessageBox.Show("Se registró exitosamente la Venta");
                ListarVentaDiaActual();
                ListarAlmacen();
                BuscarDetalleVenta();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la Venta" + ex);
            }
        }


        private void btn_editarVenta_Click(object sender, EventArgs e)
        {
            if (dataGrid_Venta.SelectedRows.Count > 0)
            {

                idVenta = dataGrid_Venta.CurrentRow.Cells["IdVenta"].Value.ToString();

                cmb_Colaborador.Text = dataGrid_Venta.CurrentRow.Cells["Colaborador"].Value.ToString();
                txt_buscarClienteVenta.Text = borrarEspacios(dataGrid_Venta.CurrentRow.Cells["Cliente"].Value.ToString());
                cmb_Producto.Text = dataGrid_Venta.CurrentRow.Cells["Producto"].Value.ToString();
                txt_cantidadP.Text = dataGrid_Venta.CurrentRow.Cells["Cantidad"].Value.ToString();

                btn_registrarVenta.Visible = false;
                btn_actualizarVenta.Visible = true;
            }

            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a editar
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private string borrarEspacios(string palabraEspacios)
        {
            char[] charsToTrim = { '*', '(', ')', ' ', '\'' };

            string Texto = palabraEspacios.Trim(charsToTrim);

            return countPalabras(Texto);
        }

        private string countPalabras(string Texto)
        {
            string[] palabras = Texto.Split(' ');

            int espacios = palabras.Length - 1;


            if (espacios == 1)
            {
                txt_buscarClienteVenta.Text = palabras[1];
                apellidosSeleccionado = txt_buscarClienteVenta.Text;
            }

            else if (espacios == 2)
            {
                txt_buscarClienteVenta.Text = palabras[1] + ' ' + palabras[2];
                apellidosSeleccionado = txt_buscarClienteVenta.Text;

            }

            else if (espacios == 3)
            {
                txt_buscarClienteVenta.Text = palabras[2] + ' ' + palabras[3];
                apellidosSeleccionado = txt_buscarClienteVenta.Text;

            }

            else if (espacios == 4)
            {
                txt_buscarClienteVenta.Text = palabras[3] + ' ' + palabras[4];
                apellidosSeleccionado = txt_buscarClienteVenta.Text;
            }

            return apellidosSeleccionado;
        }




        private void btn_actualizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Editar_Venta(idVenta, cmb_Colaborador.SelectedValue.ToString(),
                                    dataGrid_ClienteVenta.CurrentRow.Cells["Id"].Value.ToString(),
                                    cmb_Producto.SelectedValue.ToString(),
                                    txt_cantidadP.Text);

                MessageBox.Show("Se actualizó correctamente la Venta");

                ListarVentaDiaActual();
                ListarAlmacen();
                BuscarDetalleVenta();
                limpiarForm();

                btn_registrarVenta.Visible = true;
                btn_actualizarVenta.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos de la Venta por: " + ex);
            }
        }


        private void btn_eliminarVenta_Click(object sender, EventArgs e)
        {
            if (dataGrid_Venta.SelectedRows.Count > 0)
            {
                idVenta = dataGrid_Venta.CurrentRow.Cells["IdVenta"].Value.ToString();
                objetoCN.Eliminar_Venta(idVenta);
                MessageBox.Show("Venta eliminada exitosamente");

                limpiarForm();
                ListarAlmacen();
                ListarVentaDiaActual();

            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a eliminar
            {
                MessageBox.Show("Seleccione una fila para eliminar por favor");
            }
        }

        private void btn_limpiarVenta_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void limpiarForm()
        {
            txt_cantidadP.Clear();
            txt_buscarClienteVenta.Clear();

            btn_registrarVenta.Visible = true;
            btn_actualizarVenta.Visible = false;
        }

        private void dataGrid_ClienteVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGrid_Venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarDetalleVenta();
        }

        private void dataGrid_DetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
