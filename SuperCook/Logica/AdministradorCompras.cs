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
            GuardarIngredientesAComprar();
        }

        private void GuardarIngredientesAComprar() {
            List<Bebida> Bebidas = ExtraerBebidasDe(IngredientesAComprar);
            List<Solido> Solidos = ExtraerSolidosDe(IngredientesAComprar);

            GuardarLista(SerializarLista(Bebidas), "serialBebidasAComprar");
            GuardarLista(SerializarLista(Solidos), "serialSolidosAComprar");
        }

        //TODO: Duplicacion de codigo con administrador ingrediente


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
