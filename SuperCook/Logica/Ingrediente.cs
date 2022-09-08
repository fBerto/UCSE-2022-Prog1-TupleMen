using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal abstract class Ingrediente {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }

    internal abstract class PorPeso : Ingrediente {
        public float Peso { get; set; }
        public decimal PrecioPorPeso { get; set; }
        public float PesoMinimo { get; set; }
    }

    internal abstract class PorVolumen : Ingrediente {
        public int Volumen { get; set; }
        public decimal PrecioPorVolumen { get; set; }
        public int VolumenMinimo { get; set; }
    }

    internal abstract class PorCantidad : Ingrediente {
        public int Cantidad { get; set; }
        public decimal PrecioPorUnidad { get; set; }
        public int CantidadMinima { get; set; }
    }

    internal class Carne : PorPeso {

    }

    internal class Pescado : PorPeso {

    }

    internal class Panaderia : PorPeso {

    }

    internal class Queso : PorPeso {

    }

    internal class Lacteo : PorVolumen {

    }

    internal class Bebida : PorCantidad {
        public TiposBebidas TipoBebida { get; set; }
    }

    internal class Fruta : PorCantidad {

    }

    internal class HortalizaVerdura : PorCantidad {

    }
}
