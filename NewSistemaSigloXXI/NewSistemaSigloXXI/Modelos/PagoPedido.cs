using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public class PagoPedido
    {
        public int idPagoPedido { get; set; }
        public DateTime fechaPagoPedido { get; set; }
        public int montoPagoPedido { get; set; }
        public string descripcionPagoPedido { get; set; }
        public int pedido { get; set; }
    }
}
