using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class AdministradorCompras : Archivos {
        List<Ingrediente> IngredientesAComprar = new List<Ingrediente>();

        private void ActualizarIngredientesAComprar(Ingrediente nuevoIngrediente) {
            IngredientesAComprar.Add(nuevoIngrediente);
            GuardarEnDisco();
        }

        private void GuardarEnDisco() {
            GuardarLista(SerializarLista(ExtraerBebidasDe(IngredientesAComprar)), "serialBebidasEnDespensa");
            GuardarLista(SerializarLista(ExtraerSolidosDe(IngredientesAComprar)), "serialSolidosEnDespensa");
        }

        //TODO: Duplicacion de codigo con administrador ingrediente
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

        /* Filtros:
         * Por tipo de ingrediente
         *  - Por tipo de bebida
         * Por precio
         * Por magnitud medida (kg, l, o unidades)
         * Por cantidad en la despensa en relacion a la unidad minima
         */

        private decimal CalcularTotalCompra() {
            decimal totalCompra = 0;
            foreach (Ingrediente ingrediente in IngredientesAComprar) {
                totalCompra += ingrediente.CalcularCostoIngrediente();
            }
            return totalCompra;
        }          
    }
}
