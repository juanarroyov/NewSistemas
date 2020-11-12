using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public class MovimientoDinero
    {
        public int idMovimiento { get; set; }
        public int montoMovimiento { get; set; }
        public string tipoMovimiento { get; set; }
        public string descripcionMovimiento { get; set; }
        public DateTime fechaMovimiento { get; set; }
    }
}
