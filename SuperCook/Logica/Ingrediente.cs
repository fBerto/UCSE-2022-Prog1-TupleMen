using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    //Ingrediente incompleto para la receta
    internal class IngredienteParcial {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public TiposIngredientes TipoIngrediente { get; set; }
        public int Cantidad { get; set; }
    }

    internal class IngredienteCompleto : IngredienteParcial {
        public decimal PrecioPorUnidad { get; set; }
        public uint UnidadMinima { get; set; }
        public decimal CalcularCostoIngrediente() {
            return PrecioPorUnidad * UnidadMinima;
        }
    }

    internal class Bebida : IngredienteParcial {
        public TiposBebidas TipoBebida { get; set; }
    }

    internal class BebidaCompleta : Bebida {
        public decimal PrecioPorUnidad { get; set; }
        public uint UnidadMinima { get; set; }
        public decimal CalcularCostoIngrediente() {
            return PrecioPorUnidad * UnidadMinima;
        }
    }
}
