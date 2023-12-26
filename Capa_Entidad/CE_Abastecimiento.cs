using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Abastecimiento
    {
        public int idAbastecimiento { get; set; }
        public int idProducto { get; set; }
        public int idProveedor { get; set; }
        public int cantidadAbastecida { get; set; }
        public double costoUnidad { get; set; }

        //public double PagoTotal { get; set; }

    }
}
