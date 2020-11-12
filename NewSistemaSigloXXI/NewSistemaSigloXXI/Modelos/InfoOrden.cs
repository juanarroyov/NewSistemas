using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public class InfoOrden
    {
        public int idInfOr { get; set; }
        public DateTime registroHora { get; set; }
        public int orden { get; set; }
        public int estadoOrden { get; set; }
        public int usuario { get; set; }
    }
}
