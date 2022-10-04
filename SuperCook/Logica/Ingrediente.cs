using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    //Ingrediente incompleto para la receta
    internal class Ingrediente {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public TiposIngredientes TipoIngrediente { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioPorUnidad { get; set; }
        public int UnidadMinima { get; set; }
        public decimal CalcularCostoIngrediente() {
            return PrecioPorUnidad * UnidadMinima;
        }

        //Funcion que devuelve si le corresponde kilo, litro o unidad.
        public string GetUnidadMedida(TiposIngredientes tipoIngrediente) { return ""; }
    }

    internal class Bebida : Ingrediente {
        public TiposBebidas TipoBebida { get; set; }
    }
}
