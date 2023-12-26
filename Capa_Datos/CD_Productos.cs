using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;

namespace Capa_Datos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Productos()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from v_MostrarProductos";

            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ListarCategoriaProducto()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Categoria_Producto";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarMarcaProducto()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Marca_Producto";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

       
        public DataTable BuscarProductos(string valor)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_Producto";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", valor);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        //REGISTRAR NUEVA MARCA DE PRODUCTO

        public void InsertarMarcaProductos(CE_Productos obj)
        {

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarMarcaProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcionMP", obj.descripcionMP);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void InsertarProductos(CE_Productos obj)
        {

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idCategoriaProducto", obj.idCategoriaProducto);
            comando.Parameters.AddWithValue("@idMarcaProducto", obj.idMarcaProducto);
            comando.Parameters.AddWithValue("@precioUnidad", obj.precioUnidad);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EditarProductos(CE_Productos obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EditarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idProducto", obj.idProducto);
            comando.Parameters.AddWithValue("@idCategoriaProducto", obj.idCategoriaProducto);
            comando.Parameters.AddWithValue("@idMarcaProducto", obj.idMarcaProducto);
            comando.Parameters.AddWithValue("@precioUnidad", obj.precioUnidad);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarProductos(CE_Productos obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idProducto", obj.idProducto);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
