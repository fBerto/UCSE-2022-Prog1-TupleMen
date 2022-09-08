using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal abstract class Ingrediente {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public TiposIngredientes TipoIngrediente { get; set; }

        public abstract decimal CalcularCostoIngrediente();
    }

    internal abstract class PorPeso : Ingrediente {
        public int Peso { get; set; }
        public decimal PrecioPorPeso { get; set; }
        public int PesoMinimo { get; set; }

        public override decimal CalcularCostoIngrediente() { return 0; }
    }

    internal abstract class PorVolumen : Ingrediente {
        public int Volumen { get; set; }
        public decimal PrecioPorVolumen { get; set; }
        public int VolumenMinimo { get; set; }

        public override decimal CalcularCostoIngrediente() {return 0;}
    }

    internal abstract class PorCantidad : Ingrediente {
        public int Cantidad { get; set; }
        public decimal PrecioPorUnidad { get; set; }
        public int CantidadMinima { get; set; }
        public override decimal CalcularCostoIngrediente() {return 0; }
    }

    internal class Bebida : PorCantidad {
        public TiposBebidas TipoBebida { get; set; }
    }
}
