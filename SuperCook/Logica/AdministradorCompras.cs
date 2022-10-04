using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal class AdministradorCompras : Archivos {
        List<Ingrediente> IngredientesAComprar = new List<Ingrediente>();

        private void ActualizarIngredientesAComprar(int codigoIngrediente) {
            //Cargar ingrediente del que me quede sin a la lista del super
        }

        /* Filtros:
         * Por tipo de ingrediente
         *  - Por tipo de bebida
         * Por precio
         * Por magnitud medida (kg, l, o unidades)
         * Por cantidad en la despensa en relacion a la unidad minima
         */

        private decimal CalcularTotalCompra() { return 0; }
    }
}
