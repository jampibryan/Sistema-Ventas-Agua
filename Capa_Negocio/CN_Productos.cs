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
    public class CN_Productos
    {
        public DataTable Listar_Productos()
        {
            CD_Productos objetoCD = new CD_Productos();
            return objetoCD.Productos();
        }

        public DataTable Listar_CategoriaProducto()
        {
            CD_Productos objetoCD = new CD_Productos();
            return objetoCD.ListarCategoriaProducto();
        }

        public DataTable Listar_MarcaProducto()
        {
            CD_Productos objetoCD = new CD_Productos();
            return objetoCD.ListarMarcaProducto();
        }


        public DataTable Buscar_Productos(string valor)
        {
            CD_Productos objetoCD = new CD_Productos();
            return objetoCD.BuscarProductos(valor);
        }


        //REGISTRAR NUEVA MARCA DE PRODUCTO
        public void Insertar_MarcaProducto(string descripcionMP)
        {

            CD_Productos objetoCD = new CD_Productos();
            CE_Productos obj = new CE_Productos();

            obj.descripcionMP = descripcionMP;

            objetoCD.InsertarMarcaProductos(obj);
        }



        public void Insertar_Producto(string idCategoriaProducto,
                                    string idMarcaProducto, string precioUnidad)
        {

            CD_Productos objetoCD = new CD_Productos();
            CE_Productos obj = new CE_Productos();

            obj.idCategoriaProducto = Convert.ToInt32(idCategoriaProducto);
            obj.idMarcaProducto = Convert.ToInt32(idMarcaProducto);
            obj.precioUnidad = Convert.ToDouble(precioUnidad);

            objetoCD.InsertarProductos(obj);
        }


        public void Editar_Producto(string idProducto, string idCategoriaProducto,
                                    string idMarcaProducto, string precioUidad)

        {
            CD_Productos objetoCD = new CD_Productos();
            CE_Productos obj = new CE_Productos();

            obj.idProducto = Convert.ToInt32(idProducto);
            obj.idCategoriaProducto = Convert.ToInt32(idCategoriaProducto);
            obj.idMarcaProducto = Convert.ToInt32(idMarcaProducto);
            obj.precioUnidad = Convert.ToDouble(precioUidad);

            objetoCD.EditarProductos(obj);
        }


        public void Eliminar_Producto(string idProducto)
        {
            CD_Productos objetoCD = new CD_Productos();
            CE_Productos obj = new CE_Productos();

            obj.idProducto = Convert.ToInt32(idProducto);

            objetoCD.EliminarProductos(obj);
        }

    }
}
