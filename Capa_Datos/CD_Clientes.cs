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
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Clientes()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarCliente";

            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarTipoDoc()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Tipo_Documento";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ListarTipoGenero()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Tipo_Genero";
            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable BuscarClientes(string valor)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_Cliente";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", valor);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public void InsertarClientes(CE_Clientes obj)
        {

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idTipoDoc", obj.idTipoDoc);
            comando.Parameters.AddWithValue("@nroDocCliente", obj.nroDocCliente);
            comando.Parameters.AddWithValue("@idTipoGenero", obj.idTipoGenero);
            comando.Parameters.AddWithValue("@nombresCliente", obj.nombresCliente);
            comando.Parameters.AddWithValue("@apellidosCliente", obj.apellidosCliente);
            comando.Parameters.AddWithValue("@direccionCliente", obj.direccionCliente);
            comando.Parameters.AddWithValue("@nroCelularCliente", obj.nroCelularCliente);
            comando.Parameters.AddWithValue("@nroFijoCliente", obj.nroFijoCliente);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EditarClientes(CE_Clientes obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idCliente", obj.idCliente);
            comando.Parameters.AddWithValue("@idTipoDoc", obj.idTipoDoc);
            comando.Parameters.AddWithValue("@nroDocCliente", obj.nroDocCliente);
            comando.Parameters.AddWithValue("@idTipoGenero", obj.idTipoGenero);
            comando.Parameters.AddWithValue("@nombresCliente", obj.nombresCliente);
            comando.Parameters.AddWithValue("@apellidosCliente", obj.apellidosCliente);
            comando.Parameters.AddWithValue("@direccionCliente", obj.direccionCliente);
            comando.Parameters.AddWithValue("@nroCelularCliente", obj.nroCelularCliente);
            comando.Parameters.AddWithValue("@nroFijoCliente", obj.nroFijoCliente);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EliminarClientes(CE_Clientes obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idCliente", obj.idCliente);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}

