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
    public partial class Clientes : Form
    {

        CN_Clientes objetoCN = new CN_Clientes();

        private string idCliente = null;
        private string valor = null;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ListarTipoDoc();
            ListarTipoGenero();

            btn_eliminarCliente.Enabled = true;
        }

        private void MostrarClientes()
        {
            CN_Clientes objetoCN = new CN_Clientes();
            dataGrid_Clientes.DataSource = objetoCN.Listar_Clientes();
        }

        private void btn_listarClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void ListarTipoDoc()
        {
            cmb_tipoDoc.DataSource = objetoCN.Listar_TipoDoc();
            cmb_tipoDoc.DisplayMember = "descripcionTD";
            cmb_tipoDoc.ValueMember = "idTipoDoc";
        }

        private void ListarTipoGenero()
        {
            cmb_tipoGenero.DataSource = objetoCN.Listar_TipoGenero();
            cmb_tipoGenero.DisplayMember = "descripcionTG";
            cmb_tipoGenero.ValueMember = "idTipoGenero";
        }

        private void txt_buscarCliente_TextChanged(object sender, EventArgs e)
        {
            CN_Clientes objetoCN = new CN_Clientes();
            valor = txt_buscarCliente.Text;
            dataGrid_Clientes.DataSource = objetoCN.Buscar_Clientes(valor);
        }

        private string borrarEspacios(string palabraEspacios)
        {
            char[] charsToTrim = { '*', '(', ')', ' ', '\'' };

            string Texto = palabraEspacios.Trim(charsToTrim);

            return Texto;
        }

        private void btn_registrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.insertar_Cliente(cmb_tipoDoc.SelectedValue.ToString(),
                                    borrarEspacios(txt_nroDocCliente.Text),
                                    cmb_tipoGenero.SelectedValue.ToString(),
                                    borrarEspacios(txt_nombresCliente.Text),
                                    borrarEspacios(txt_apellidosCliente.Text),
                                    borrarEspacios(txt_direccionCliente.Text),
                                    borrarEspacios(txt_celularCliente.Text),
                                    borrarEspacios(txt_fijoCliente.Text));

                MessageBox.Show("Se registró exitosamente al Cliente");
                MostrarClientes();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar al Cliente" + ex);
            }
        }

        private void btn_editarCliente_Click(object sender, EventArgs e)
        {
            if (dataGrid_Clientes.SelectedRows.Count > 0)
            {
                idCliente = dataGrid_Clientes.CurrentRow.Cells["Id"].Value.ToString();

                cmb_tipoDoc.Text = dataGrid_Clientes.CurrentRow.Cells["Tipo Documento"].Value.ToString();
                txt_nroDocCliente.Text = dataGrid_Clientes.CurrentRow.Cells["Nro Documento"].Value.ToString();
                cmb_tipoGenero.Text = dataGrid_Clientes.CurrentRow.Cells["Genero"].Value.ToString();
                txt_nombresCliente.Text = dataGrid_Clientes.CurrentRow.Cells["Nombres"].Value.ToString();
                txt_apellidosCliente.Text = dataGrid_Clientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                txt_direccionCliente.Text = dataGrid_Clientes.CurrentRow.Cells["dirección"].Value.ToString();
                txt_celularCliente.Text = dataGrid_Clientes.CurrentRow.Cells["Celular"].Value.ToString();
                txt_fijoCliente.Text = dataGrid_Clientes.CurrentRow.Cells["Fijo"].Value.ToString();

                btn_registrarCliente.Visible = false;
                btn_actualizarCliente.Visible = true;
            }

            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a editar
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btn_actualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Editar_Cliente(idCliente, cmb_tipoDoc.SelectedValue.ToString(),
                                    borrarEspacios(txt_nroDocCliente.Text),
                                    cmb_tipoGenero.SelectedValue.ToString(),
                                    borrarEspacios(txt_nombresCliente.Text),
                                    borrarEspacios(txt_apellidosCliente.Text),
                                    borrarEspacios(txt_direccionCliente.Text),
                                    borrarEspacios(txt_celularCliente.Text),
                                    borrarEspacios(txt_fijoCliente.Text));

                MessageBox.Show("Se actualizó correctamente al Cliente");

                btn_registrarCliente.Visible = true;
                btn_actualizarCliente.Visible = false;
                MostrarClientes();
                limpiarForm();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex);
            }
        }

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGrid_Clientes.SelectedRows.Count > 0)
            {
                idCliente = dataGrid_Clientes.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.Eliminar_Cliente(idCliente);
                MessageBox.Show("Cliente eliminado exitosamente");
                MostrarClientes();
            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a eliminar
            {
                MessageBox.Show("Seleccione una fila para eliminar por favor");
            }
        }

        private void btn_limpiarCliente_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void limpiarForm()
        {
            txt_nroDocCliente.Clear();
            txt_nombresCliente.Clear();
            txt_apellidosCliente.Clear();
            txt_direccionCliente.Clear();
            txt_celularCliente.Clear();
            txt_fijoCliente.Clear();

            btn_registrarCliente.Visible = true;
            btn_actualizarCliente.Visible = false;
        }

    }
}
