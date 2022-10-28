using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class Comida {
        public Receta Receta { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreReceta { get { return this.Receta.GetNombre(); } }

        public Comida(Receta receta, DateTime fecha) {
            this.Receta = receta;
            this.Fecha = fecha;
        }
    }
}
