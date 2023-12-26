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
    public class CD_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Ventas()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "v_MostrarVenta";

            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Almacen()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from v_MostrarAlmacenPrecio";

            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable Clientes()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from SP_Mostrar_ClienteVenta";

            comando.CommandType = CommandType.Text;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable ListarColaborador()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from v_nombreCompletoColaborador";
            comando.CommandType = CommandType.Text;

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

        public DataTable BuscarClientes(string valorCliente)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_ClienteVenta";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", valorCliente);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarVentaFecha(string valor)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_Venta_Fecha";

            comando.CommandType = CommandType.StoredProcedure;

            DateTime fecha = Convert.ToDateTime(valor);
            comando.Parameters.AddWithValue("@valor", fecha);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable BuscarDetalleVenta(string idVenta)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_Buscar_DetalleVenta";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@valor", idVenta);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable VentaDiaActual()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MostrarVentasDiaActual";

            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public void InsertarVentas(CE_Ventas obj)
        {

            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_RegistrarVenta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idColaborador", obj.idColaborador);
            comando.Parameters.AddWithValue("@idCliente", obj.idCliente);
            comando.Parameters.AddWithValue("@idProducto", obj.idProducto);
            comando.Parameters.AddWithValue("@cantidadVP", obj.CantidadVP);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EditarVentas(CE_Ventas obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EditarVenta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idVenta", obj.idVenta);
            comando.Parameters.AddWithValue("@idColaborador", obj.idColaborador);
            comando.Parameters.AddWithValue("@idCliente", obj.idCliente);
            comando.Parameters.AddWithValue("@idProducto", obj.idProducto);
            comando.Parameters.AddWithValue("@cantidadVP", obj.CantidadVP);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void EliminarVentas(CE_Ventas obj)
        {
            comando.Parameters.Clear();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_EliminarVenta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idVenta", obj.idVenta);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
