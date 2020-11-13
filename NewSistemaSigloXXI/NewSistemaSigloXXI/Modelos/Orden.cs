using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public class Orden
    {
        public int idOrden { get; set; }
        public DateTime fechaIni { get; set; }
        public DateTime fechaEnt { get; set; }
        public int totalOrden { get; set; }
        public string estadoOrden { get; set; }
        public Mesa mesa{ get; set; }
        public TipoOrden tipo { get; set; }
    }
}
