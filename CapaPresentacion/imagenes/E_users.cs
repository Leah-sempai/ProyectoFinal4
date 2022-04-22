using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_sesion
    {
        public int IdUser { get; set; }
        public string LoginName { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Apellido { get; set; }
        public string Posicion { get; set; }
        public string Email { get; set; }

    }
}
