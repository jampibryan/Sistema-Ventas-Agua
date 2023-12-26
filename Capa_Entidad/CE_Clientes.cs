using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Clientes
    {
        public int idCliente { get; set; }
        public int idTipoDoc { get; set; }
        public string nroDocCliente { get; set; }
        public int idTipoGenero { get; set; }
        public string nombresCliente { get; set; }
        public string apellidosCliente { get; set; }
        public string direccionCliente { get; set; }
        public string nroCelularCliente { get; set; }
        public string nroFijoCliente { get; set; }

    }
}
