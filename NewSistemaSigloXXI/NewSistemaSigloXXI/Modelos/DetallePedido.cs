using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NewSistemaSigloXXI.Modelos.RestHelperProveedorProducto;

namespace NewSistemaSigloXXI.Modelos
{
    public class DetallePedido
    {
        public int idDetPed { get; set; }
        public double cantidadDetPed { get; set; }
        public ProveedorProducto provProd { get; set; }
        public Pedido pedido { get; set; }
    }
}
