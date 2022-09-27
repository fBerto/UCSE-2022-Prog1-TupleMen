using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal class Receta {
        public int Codigo { get; set; }
        public MomentosComida MomentoComida { get; set; }
        public string Nombre { get; set; }
        public bool EsSaludable { get; set; }
        //Guardamos una lista de Ingredientes por la necesidad de guardar la cantidad/peso/volumen.
        public List<IngredienteParcial> Ingredientes { get; set; }
    }
}
