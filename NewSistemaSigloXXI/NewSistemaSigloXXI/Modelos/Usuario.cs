using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string emailUsuario { get; set; }
        public string passUsuario { get; set; }
        public string estadoUsuario { get; set; }
        public int perfil { get; set; }
    }
}
