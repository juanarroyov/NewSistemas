using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public class PagoOrden
    {
        public int idPagOr { get; set; }
        public DateTime fechaPagOr { get; set; }
        public int montoPagOr { get; set; }
        public int propinaPagOr { get; set; }
        public int orden { get; set; }
        public int metodoPago { get; set; }

    }
}
