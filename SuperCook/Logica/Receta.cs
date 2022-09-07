using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal class Receta {
        public HorasComida HoraComida { get; set; }
        public string NombreReceta { get; set; }
        public bool EsSaludable { get; set; }
        public List<int> Ingredientes { get; set; }
    }

    internal class Comida : Receta {
        public DateTime FechaComida { get; set; }
    }
}
