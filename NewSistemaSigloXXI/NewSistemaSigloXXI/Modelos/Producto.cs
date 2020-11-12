using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public int stockProducto { get; set; }
        public int stockMinimo { get; set; }
        public int unidad { get; set; }

    }
}
