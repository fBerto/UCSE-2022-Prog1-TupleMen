using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal class Recetas : Archivos {
        List<Receta> LibroRecetas = new List<Receta>();
        
        public void CargarReceta(string nombreReceta, bool esSaludable, MomentosComida momentoComida) { }

        public void EliminarReceta(int codigoReceta) { }

        public void ModificarReceta(int codigoReceta, MomentosComida momentoComida) { }
        public void ModificarReceta(int codigoReceta, string nombreReceta) { }
        public void ModificarReceta(int codigoReceta, bool esSaludable) { }

        //Devuelve true si lo encuentra en la lista de la receta y false si no
        //Si encuentra el ingrediente, modifica su cantidad con la que le hayamos pasado como parametro
        public bool ModificarReceta(int codigoReceta, int codigoIngrediente, int cantidadIngrediente) { return false; }
    }
}
