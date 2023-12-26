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
    public class CD_Colaboradores
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Colaboradores()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarColaborador";
                                                                   
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ListarCargoColaborador()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Cargo_Colaborador";
            comando.CommandType = CommandType.Text;

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

        

        public DataTable BuscarColaboradores(string valor)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_Colaborador";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", valor);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }



        public void InsertarColaboradores(CE_Colaboradores obj)
        {

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarColaborador";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idCargoColaborador", obj.idCargoColaborador);
            comando.Parameters.AddWithValue("@idTipoDoc", obj.idTipoDoc);
            comando.Parameters.AddWithValue("@nroDocColaborador", obj.nroDocColaborador);
            comando.Parameters.AddWithValue("@idTipoGenero", obj.idTipoGenero);
            comando.Parameters.AddWithValue("@nombresColaborador", obj.nombresColaborador);
            comando.Parameters.AddWithValue("@apellidosColaborador", obj.apellidosColaborador);
            comando.Parameters.AddWithValue("@direccionColaborador", obj.direccionColaborador);
            comando.Parameters.AddWithValue("@nroCelularColaborador", obj.nroCelularColaborador);
            comando.Parameters.AddWithValue("@nroFijoColaborador", obj.nroFijoColaborador);
            comando.Parameters.AddWithValue("@salarioColaborador", obj.salarioColaborador);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }


        public void EditarColaboradores(CE_Colaboradores obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EditarColaborador";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idColaborador", obj.idColaborador);
            comando.Parameters.AddWithValue("@idCargoColaborador", obj.idCargoColaborador);
            comando.Parameters.AddWithValue("@idTipoDoc", obj.idTipoDoc);
            comando.Parameters.AddWithValue("@nroDocColaborador", obj.nroDocColaborador);
            comando.Parameters.AddWithValue("@idTipoGenero", obj.idTipoGenero);
            comando.Parameters.AddWithValue("@nombresColaborador", obj.nombresColaborador);
            comando.Parameters.AddWithValue("@apellidosColaborador", obj.apellidosColaborador);
            comando.Parameters.AddWithValue("@direccionColaborador", obj.direccionColaborador);
            comando.Parameters.AddWithValue("@nroCelularColaborador", obj.nroCelularColaborador);
            comando.Parameters.AddWithValue("@nroFijoColaborador", obj.nroFijoColaborador);
            comando.Parameters.AddWithValue("@salarioColaborador", obj.salarioColaborador);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }



        public void EliminarColaboradores(CE_Colaboradores obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EliminarColaborador";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idColaborador", obj.idColaborador);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }


}
