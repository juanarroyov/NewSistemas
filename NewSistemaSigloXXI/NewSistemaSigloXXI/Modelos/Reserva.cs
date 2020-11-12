using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public class Reserva
    {
        public int idReserva { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaTermino { get; set; }
        public string rutReserva { get; set; }
        public int mesa { get; set; }
        public int usuario { get; set; }
    }
}
