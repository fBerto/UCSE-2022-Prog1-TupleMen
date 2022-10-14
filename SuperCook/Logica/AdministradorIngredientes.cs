using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class AdministradorIngredientes : Archivos{
        public List<Ingrediente> IngredientesEnDespensa = new List<Ingrediente>();

        public void CargarIngrediente(Ingrediente nuevoIngrediente) { }
        public void EliminarIngrediente(int codigo) { }
        public void ModificarIngrediente(Ingrediente ingredienteModificado) { }

        private string SerializarLista(List<Ingrediente> listaASerializar) {
            return JsonConvert.SerializeObject(listaASerializar);
        }

        private void UnificarBebidasySolidos() { }
    }
}
