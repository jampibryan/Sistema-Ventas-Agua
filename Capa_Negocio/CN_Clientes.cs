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
    public class CN_Clientes
    {
        CD_Clientes objetoCD = new CD_Clientes();

        public DataTable Listar_Clientes()
        {
            return objetoCD.Clientes();
        }

        public DataTable Listar_TipoDoc()
        {
            return objetoCD.ListarTipoDoc();
        }

        public DataTable Listar_TipoGenero()
        {
            return objetoCD.ListarTipoGenero();
        }

        public DataTable Buscar_Clientes(string valor)
        {
            return objetoCD.BuscarClientes(valor);
        }


        public void insertar_Cliente(string idTipoDoc, string nroDocCliente, string idTipoGenero,
                                    string nombresCliente, string apellidosCliente, string direccionCliente,
                                    string nroCelularCliente, string nroFijoCliente)
        {

            CD_Clientes objetoCD = new CD_Clientes();
            CE_Clientes obj = new CE_Clientes();

            obj.idTipoDoc           = Convert.ToInt32(idTipoDoc);
            obj.nroDocCliente       = nroDocCliente;
            obj.idTipoGenero        = Convert.ToInt32(idTipoGenero);
            obj.nombresCliente      = nombresCliente;
            obj.apellidosCliente    = apellidosCliente;
            obj.direccionCliente    = direccionCliente;
            obj.nroCelularCliente   = nroCelularCliente;
            obj.nroFijoCliente      = nroFijoCliente;

            objetoCD.InsertarClientes(obj);
        }


        public void Editar_Cliente(string idCliente, string idTipoDoc, string nroDocCliente, string idTipoGenero,
                                    string nombresCliente, string apellidosCliente, string direccionCliente,
                                    string nroCelularCliente, string nroFijoCliente)

        {
            CD_Clientes objetoCD = new CD_Clientes();
            CE_Clientes obj = new CE_Clientes();

            obj.idCliente = Convert.ToInt32(idCliente);
            obj.idTipoDoc = Convert.ToInt32(idTipoDoc);
            obj.nroDocCliente = nroDocCliente;
            obj.idTipoGenero = Convert.ToInt32(idTipoGenero);
            obj.nombresCliente = nombresCliente;
            obj.apellidosCliente = apellidosCliente;
            obj.direccionCliente = direccionCliente;
            obj.nroCelularCliente = nroCelularCliente;
            obj.nroFijoCliente = nroFijoCliente;

            objetoCD.EditarClientes(obj);
        }

        public void Eliminar_Cliente(string idCliente)
        {
            CD_Clientes objetoCD = new CD_Clientes();
            CE_Clientes obj = new CE_Clientes();

            obj.idCliente = Convert.ToInt32(idCliente);

            objetoCD.EliminarClientes(obj);
        }

    }
}
