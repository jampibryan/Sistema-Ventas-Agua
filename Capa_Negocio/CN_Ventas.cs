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
    public class CN_Ventas
    {
        CD_Ventas objetoCD = new CD_Ventas();

        public DataTable Listar_Almacen()
        {
            CD_Ventas objetoCD = new CD_Ventas();
            return objetoCD.Almacen();
        }

        public DataTable Listar_Clientes()
        {
            return objetoCD.Clientes();
        }

        public DataTable Listar_Colaborador()
        {
            CD_Ventas objetoCD = new CD_Ventas();
            return objetoCD.ListarColaborador();
        }

        public DataTable Listar_Marca_Producto()
        {
            CD_Ventas objetoCD = new CD_Ventas();
            return objetoCD.Listar_Marca_Producto();
        }
        public DataTable Listar_VentaDiaActual()
        {
            CD_Ventas objetoCD = new CD_Ventas();
            return objetoCD.VentaDiaActual();
        }

        public DataTable Buscar_Clientes(string valorCliente)
        {
            return objetoCD.BuscarClientes(valorCliente);
        }

        public DataTable Buscar_Ventas_Fecha(string valor)
        {
            CD_Ventas objetoCD = new CD_Ventas();
            //CE_Abastecimiento obj = new CE_Abastecimiento();

            return objetoCD.BuscarVentaFecha(valor);
        }

        public DataTable Buscar_Detalle_Venta(string idVenta)
        {
            return objetoCD.BuscarDetalleVenta(idVenta);
        }


        public void insertar_Venta(string idColaborador, string idCliente,
                                    string idProducto, string cantidadVP)
        {

            CD_Ventas objetoCD = new CD_Ventas();
            CE_Ventas obj = new CE_Ventas();

            obj.idColaborador = Convert.ToInt32(idColaborador);
            obj.idCliente = Convert.ToInt32(idCliente);
            obj.idProducto = Convert.ToInt32(idProducto);
            obj.CantidadVP = Convert.ToInt32(cantidadVP);

            objetoCD.InsertarVentas(obj);
        }


        public void Editar_Venta(string idVenta, string idColaborador, string idCliente,
                                    string idProducto, string cantidadVP)

        {
            CD_Ventas objetoCD = new CD_Ventas();
            CE_Ventas obj = new CE_Ventas();

            obj.idVenta = Convert.ToInt32(idVenta);
            obj.idColaborador = Convert.ToInt32(idColaborador);
            obj.idCliente = Convert.ToInt32(idCliente);
            obj.idProducto = Convert.ToInt32(idProducto);
            obj.CantidadVP = Convert.ToInt32(cantidadVP);

            objetoCD.EditarVentas(obj);
        }


        public void Eliminar_Venta(string idVenta)
        {
            CD_Ventas objetoCD = new CD_Ventas();
            CE_Ventas obj = new CE_Ventas();

            obj.idVenta = Convert.ToInt32(idVenta);

            objetoCD.EliminarVentas(obj);
        }

    }
}
