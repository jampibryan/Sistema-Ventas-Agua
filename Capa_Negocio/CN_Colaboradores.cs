using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Colaboradores
    {
        public DataTable Listar_Colaboradores()
        {
            CD_Colaboradores objetoCD = new CD_Colaboradores();
            return objetoCD.Colaboradores();
        }

        public DataTable Listar_CargoColaborador()
        {
            CD_Colaboradores objetoCD = new CD_Colaboradores();
            return objetoCD.ListarCargoColaborador();
        }

        public DataTable Listar_TipoDoc()
        {
            CD_Colaboradores objetoCD = new CD_Colaboradores();
            return objetoCD.ListarTipoDoc();
        }

        public DataTable Listar_TipoGenero()
        {
            CD_Colaboradores objetoCD = new CD_Colaboradores();
            return objetoCD.ListarTipoGenero();
        }


        public DataTable Buscar_Colaboradores(string valor)
        {
            CD_Colaboradores objetoCD = new CD_Colaboradores();
            return objetoCD.BuscarColaboradores(valor);
        }


        public void Insertar_Colaborador(string idCargoColaborador, string idTipoDoc, string nroDocColaborador, 
                                    string idTipoGenero, string nombresColaborador, string apellidosColaborador,
                                    string direccionColaborador, string nroCelularColaborador,
                                    string nroFijoColaborador, string salarioColaborador)
        {

            CD_Colaboradores objetoCD = new CD_Colaboradores();
            CE_Colaboradores obj = new CE_Colaboradores();

            obj.idCargoColaborador      = Convert.ToInt32(idCargoColaborador);
            obj.idTipoDoc               = Convert.ToInt32(idTipoDoc);
            obj.nroDocColaborador       = nroDocColaborador;
            obj.idTipoGenero            = Convert.ToInt32(idTipoGenero);
            obj.nombresColaborador      = nombresColaborador;
            obj.apellidosColaborador    = apellidosColaborador;
            obj.direccionColaborador    = direccionColaborador;
            obj.nroCelularColaborador   = nroCelularColaborador;
            obj.nroFijoColaborador      = nroFijoColaborador;
            obj.salarioColaborador      = Convert.ToDouble(salarioColaborador);

            objetoCD.InsertarColaboradores(obj);
        }



        public void Editar_Colaborador(string idColaborador, string idCargoColaborador, string idTipoDoc, 
                                    string nroDocColaborador, string idTipoGenero, string nombresColaborador, 
                                    string apellidosColaborador, string direccionColaborador, 
                                    string nroCelularColaborador, string nroFijoColaborador, 
                                    string salarioColaborador)

        {
            CD_Colaboradores objetoCD = new CD_Colaboradores();
            CE_Colaboradores obj = new CE_Colaboradores();

            obj.idColaborador           = Convert.ToInt32(idColaborador);
            obj.idCargoColaborador      = Convert.ToInt32(idCargoColaborador);
            obj.idTipoDoc               = Convert.ToInt32(idTipoDoc);
            obj.nroDocColaborador       = nroDocColaborador;
            obj.idTipoGenero            = Convert.ToInt32(idTipoGenero);
            obj.nombresColaborador      = nombresColaborador;
            obj.apellidosColaborador    = apellidosColaborador;
            obj.direccionColaborador    = direccionColaborador;
            obj.nroCelularColaborador   = nroCelularColaborador;
            obj.nroFijoColaborador      = nroFijoColaborador;
            obj.salarioColaborador      = Convert.ToDouble(salarioColaborador);

            objetoCD.EditarColaboradores(obj);
        }


        public void Eliminar_Colaborador(string idColaborador)
        {
            CD_Colaboradores objetoCD = new CD_Colaboradores();
            CE_Colaboradores obj = new CE_Colaboradores();

            obj.idColaborador = Convert.ToInt32(idColaborador);

            objetoCD.EliminarColaboradores(obj);
        }

    }
}
