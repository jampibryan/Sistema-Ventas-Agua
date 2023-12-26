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
    public class CN_Abastecimiento
    {

        public DataTable Listar_Almacen()
        {
            CD_Abastecimiento objetoCD = new CD_Abastecimiento();
            return objetoCD.Almacen();
        }

        public DataTable Listar_Abastecimiento()
        {
            CD_Abastecimiento objetoCD = new CD_Abastecimiento();
            return objetoCD.Abastecimiento();
        }

        public DataTable Listar_Marca_Producto()
        {
            CD_Abastecimiento objetoCD = new CD_Abastecimiento();
            return objetoCD.Listar_Marca_Producto();
        }


        public DataTable Listar_Proveedor()
        {
            CD_Abastecimiento objetoCD = new CD_Abastecimiento();
            return objetoCD.ListarProveedor();
        }


        public DataTable Buscar_Abastecimiento(string valor)
        {
            CD_Abastecimiento objetoCD = new CD_Abastecimiento();
            //CE_Abastecimiento obj = new CE_Abastecimiento();

            return objetoCD.BuscarAbastecimiento(valor);
        }


        public void Insertar_Abastecimiento(string idProducto, string idProveedor, 
                                            string cantidadAbastecida, string costoUnidad)
        {
            CD_Abastecimiento objetoCD = new CD_Abastecimiento();
            CE_Abastecimiento obj = new CE_Abastecimiento();

            obj.idProducto = Convert.ToInt32(idProducto);
            obj.idProveedor = Convert.ToInt32(idProveedor);
            obj.cantidadAbastecida = Convert.ToInt32(cantidadAbastecida);
            obj.costoUnidad = Convert.ToDouble(costoUnidad);

            objetoCD.InsertarAbastecimiento(obj);
        }


        public void Editar_Abastecimiento(string idAbastecimiento, string idProducto,
                                            string idProveedor, string cantidadAbastecida,
                                            string costoUnidad)

        {
            CD_Abastecimiento objetoCD = new CD_Abastecimiento();
            CE_Abastecimiento obj = new CE_Abastecimiento();

            obj.idAbastecimiento = Convert.ToInt32(idAbastecimiento);
            obj.idProducto = Convert.ToInt32(idProducto);
            obj.idProveedor = Convert.ToInt32(idProveedor);
            obj.cantidadAbastecida = Convert.ToInt32(cantidadAbastecida);
            obj.costoUnidad = Convert.ToDouble(costoUnidad);

            objetoCD.EditarAbastecimiento(obj);
        }


        public void Eliminar_Abastecimiento(string idAbastecimiento)
        {
            CD_Abastecimiento objetoCD = new CD_Abastecimiento();
            CE_Abastecimiento obj = new CE_Abastecimiento();

            obj.idAbastecimiento = Convert.ToInt32(idAbastecimiento);

            objetoCD.EliminarAbastecimiento(obj);
        }

    }
}
