using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Productos
    {
        public int idProducto { get; set; }
        public int idCategoriaProducto { get; set; }
        public int idMarcaProducto { get; set; }
        public double precioUnidad { get; set; }


        public string descripcionMP { get; set; }
    }
}
