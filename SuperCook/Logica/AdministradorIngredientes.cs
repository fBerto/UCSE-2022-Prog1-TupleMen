using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class AdministradorIngredientes : Archivos {
        public List<Ingrediente> IngredientesEnDespensa = new List<Ingrediente>();

        public void CargarIngrediente(Ingrediente nuevoIngrediente) {
            IngredientesEnDespensa.Add(nuevoIngrediente);
            GuardarEnDisco();
        }

        public void EliminarIngrediente(int codigo) {
            int indiceAEliminar = IngredientesEnDespensa.FindIndex(x => x.Codigo == codigo);
            IngredientesEnDespensa.RemoveAt(indiceAEliminar);
            GuardarEnDisco();
        }

        public void ModificarIngrediente(Ingrediente ingredienteModificado) {
            int indiceAModificar = IngredientesEnDespensa.FindIndex(x => x.Codigo == ingredienteModificado.Codigo);
            IngredientesEnDespensa.Insert(indiceAModificar, ingredienteModificado);
            GuardarEnDisco();
        }

        private void GuardarEnDisco() {
            GuardarLista(SerializarLista(ExtraerBebidasDe(IngredientesEnDespensa)), "serialBebidasEnDespensa");
            GuardarLista(SerializarLista(ExtraerSolidosDe(IngredientesEnDespensa)), "serialSolidosEnDespensa");
        }

        //TODO: Hay alguna forma de unir estos dos metodos en uno???
        private List<Bebida> ExtraerBebidasDe(List<Ingrediente> Ingredientes) {
            return Ingredientes.Where(x => x is Bebida).Select(x => x as Bebida).ToList();
        }

        private List<Solido> ExtraerSolidosDe(List<Ingrediente> Ingredientes) {
            return Ingredientes.Where(x => x is Solido).Select(x => x as Solido).ToList();
        }

        private string SerializarLista(List<Bebida> listaASerializar) {
            return JsonConvert.SerializeObject(listaASerializar);
        }

        private string SerializarLista(List<Solido> listaASerializar) {
            return JsonConvert.SerializeObject(listaASerializar);
        }
    }
}
