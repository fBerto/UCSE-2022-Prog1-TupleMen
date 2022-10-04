using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal class AdministradorRecetas : Archivos {
        List<Receta> LibroRecetas = new List<Receta>();
        
        public void CargarReceta(Receta nuevaReceta) { }
        public void EliminarReceta(int codigoReceta) { }
        public void ModificarReceta(Receta recetaModificada) { }
    }
}
