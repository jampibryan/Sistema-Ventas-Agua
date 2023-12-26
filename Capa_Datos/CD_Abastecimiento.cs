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
    public class CD_Abastecimiento
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Almacen()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from v_MostrarAlmacén";

            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Abastecimiento()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarAbastecimiento";

            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable Listar_Marca_Producto()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_cmbMarca_idProducto";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ListarProveedor()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_cmbProveedor";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable BuscarAbastecimiento(string valor)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_Abastecimiento";

            comando.CommandType = CommandType.StoredProcedure;

            DateTime fecha = Convert.ToDateTime(valor);
            comando.Parameters.AddWithValue("@valor", fecha);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public void InsertarAbastecimiento(CE_Abastecimiento obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarAbastecimiento";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idProducto", obj.idProducto);
            comando.Parameters.AddWithValue("@idProveedor", obj.idProveedor);
            comando.Parameters.AddWithValue("@cantidadAbastecida", obj.cantidadAbastecida);
            comando.Parameters.AddWithValue("@costoUnidad", obj.costoUnidad);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EditarAbastecimiento(CE_Abastecimiento obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EditarAbastecimiento";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idAbastecimiento", obj.idAbastecimiento);
            comando.Parameters.AddWithValue("@idProducto", obj.idProducto);
            comando.Parameters.AddWithValue("@idProveedor", obj.idProveedor);
            comando.Parameters.AddWithValue("@cantidadAbastecida", obj.cantidadAbastecida);
            comando.Parameters.AddWithValue("@costoUnidad", obj.costoUnidad);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EliminarAbastecimiento(CE_Abastecimiento obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EliminarAbastecimiento";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idAbastecimiento", obj.idAbastecimiento);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


    }
}
