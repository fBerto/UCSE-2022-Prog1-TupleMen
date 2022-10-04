using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal class AdministradorIngredientes : Archivos{
        List<Ingrediente> Ingredientes = new List<Ingrediente>();

        public void CargarIngrediente(Ingrediente nuevoIngrediente) { }
        public void EliminarIngrediente(int codigo) { }
        public void ModificarIngrediente(Ingrediente ingredienteModificado) { }
    }
}
