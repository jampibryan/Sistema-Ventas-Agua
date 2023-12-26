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
    public partial class Colaboradores : Form
    {
        CN_Colaboradores objetoCN = new CN_Colaboradores();

        private string idColaborador = null;
        private string valor = null;

        public Colaboradores()
        {
            InitializeComponent();
        }

        private void Colaboradores_Load(object sender, EventArgs e)
        {
            ListarCargosColaborador();
            ListarTipoDoc();
            ListarTipoGenero();

            btn_eliminarColaborador.Enabled = false;
        }

        private void MostrarColaboradores()
        {
            CN_Colaboradores objetoCN = new CN_Colaboradores();
            dataGrid_Colaboradores.DataSource = objetoCN.Listar_Colaboradores();

            dataGrid_Colaboradores.Columns["Salario"].DefaultCellStyle.Format = "0.##";

        }


        private void btn_listarColaboradores_Click(object sender, EventArgs e)
        {
            MostrarColaboradores();
        }

        private void ListarCargosColaborador()
        {
            cmb_cargoColaborador.DataSource = objetoCN.Listar_CargoColaborador();
            cmb_cargoColaborador.DisplayMember = "descripcionCargoColaborador";
            cmb_cargoColaborador.ValueMember = "idCargoColaborador";
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


        private void btnBuscarColaborador_Click(object sender, EventArgs e)
        {
            CN_Colaboradores objetoCN = new CN_Colaboradores();
            valor = txt_buscarColaborador.Text;
            dataGrid_Colaboradores.DataSource = objetoCN.Buscar_Colaboradores(valor);
        }
        private void txt_buscarColaborador_TextChanged(object sender, EventArgs e)
        {
            CN_Colaboradores objetoCN = new CN_Colaboradores();
            valor = txt_buscarColaborador.Text;
            dataGrid_Colaboradores.DataSource = objetoCN.Buscar_Colaboradores(valor);
        }

        private void btn_buscarColaborador_Click(object sender, EventArgs e)
        {

        }


        private string borrarEspacios(string palabraEspacios)
        {
            char[] charsToTrim = { '*', '(', ')', ' ', '\'' };

            string Texto = palabraEspacios.Trim(charsToTrim);

            return Texto;
        }

        private void btn_registrarColaborador_Click(object sender, EventArgs e)
        {
            try
                {
                    objetoCN.Insertar_Colaborador(cmb_cargoColaborador.SelectedValue.ToString(),
                                        cmb_tipoDoc.SelectedValue.ToString(),
                                        borrarEspacios(txt_nroDocColaborador.Text),
                                        cmb_tipoGenero.SelectedValue.ToString(),
                                        borrarEspacios(txt_nombresColaborador.Text),
                                        borrarEspacios(txt_apellidosColaborador.Text),
                                        borrarEspacios(txt_direccionColaborador.Text),
                                        borrarEspacios(txt_celularColaborador.Text),
                                        borrarEspacios(txt_fijoColaborador.Text),
                                        borrarEspacios(txt_salarioColaborador.Text));

                    MessageBox.Show("Se registró exitosamente al Colaborador");
                    MostrarColaboradores();
                    limpiarForm();
                }
            catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar al Colaborador" + ex);
                }
        }

        private void btn_editarColaborador_Click_1(object sender, EventArgs e)
        {
            if (dataGrid_Colaboradores.SelectedRows.Count > 0)
            {
                idColaborador = dataGrid_Colaboradores.CurrentRow.Cells["Id"].Value.ToString();

                cmb_cargoColaborador.Text = dataGrid_Colaboradores.CurrentRow.Cells["Cargo"].Value.ToString();
                cmb_tipoDoc.Text = dataGrid_Colaboradores.CurrentRow.Cells["Tipo Documento"].Value.ToString();
                txt_nroDocColaborador.Text = dataGrid_Colaboradores.CurrentRow.Cells["Nro Documento"].Value.ToString();
                cmb_tipoGenero.Text = dataGrid_Colaboradores.CurrentRow.Cells["Genero"].Value.ToString();
                txt_nombresColaborador.Text = dataGrid_Colaboradores.CurrentRow.Cells["Nombres"].Value.ToString();
                txt_apellidosColaborador.Text = dataGrid_Colaboradores.CurrentRow.Cells["Apellidos"].Value.ToString();
                txt_direccionColaborador.Text = dataGrid_Colaboradores.CurrentRow.Cells["dirección"].Value.ToString();
                txt_celularColaborador.Text = dataGrid_Colaboradores.CurrentRow.Cells["Celular"].Value.ToString();
                txt_fijoColaborador.Text = dataGrid_Colaboradores.CurrentRow.Cells["Fijo"].Value.ToString();

                decimal valor = Convert.ToDecimal(dataGrid_Colaboradores.CurrentRow.Cells["Salario"].Value.ToString());
                txt_salarioColaborador.Text = valor.ToString("0.##");

                btn_registrarColaborador.Visible = false;
                btn_actualizarColaborador.Visible = true;
            }

            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a editar
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        

        private void btn_actualizarColaborador_Click_1(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Editar_Colaborador(idColaborador, 
                                        cmb_cargoColaborador.SelectedValue.ToString(),
                                        cmb_tipoDoc.SelectedValue.ToString(),
                                        borrarEspacios(txt_nroDocColaborador.Text),
                                        cmb_tipoGenero.SelectedValue.ToString(),
                                        borrarEspacios(txt_nombresColaborador.Text),
                                        borrarEspacios(txt_apellidosColaborador.Text),
                                        borrarEspacios(txt_direccionColaborador.Text),
                                        borrarEspacios(txt_celularColaborador.Text),
                                        borrarEspacios(txt_fijoColaborador.Text),
                                        borrarEspacios(txt_salarioColaborador.Text));

                MessageBox.Show("Se actualizó correctamente al Colaborador");

                btn_registrarColaborador.Visible = true;
                btn_actualizarColaborador.Visible = false;
                MostrarColaboradores();
                limpiarForm();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex);
            }
        }


        private void btn_eliminarColaborador_Click(object sender, EventArgs e)
        {
            if (dataGrid_Colaboradores.SelectedRows.Count > 0)
            {
                idColaborador = dataGrid_Colaboradores.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.Eliminar_Colaborador(idColaborador);
                MessageBox.Show("Colaborador eliminado exitosamente");
                MostrarColaboradores();
            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a eliminar
            {
                MessageBox.Show("Seleccione una fila para eliminar por favor");
            }
        }


        private void btn_limpiarColaborador_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void limpiarForm()
        {
            txt_nroDocColaborador.Clear();
            txt_nombresColaborador.Clear();
            txt_apellidosColaborador .Clear();
            txt_direccionColaborador.Clear();
            txt_celularColaborador.Clear();
            txt_fijoColaborador .Clear();
            txt_salarioColaborador.Clear();

            btn_registrarColaborador.Visible = true;
            btn_actualizarColaborador.Visible = false;
        }

    }
}
