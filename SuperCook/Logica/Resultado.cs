using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Resultado
    {
        public bool Ok { get; set; }
        public string Mensaje { get; set; }

        public Resultado() { }

        public Resultado(bool ok, string mensaje)
        {
            this.Ok = ok;
            this.Mensaje = mensaje;
        }
    }
}
