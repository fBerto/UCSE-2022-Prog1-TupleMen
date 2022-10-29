using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    //Ingrediente incompleto para la receta
    public abstract class Ingrediente
    {
        private static int CodigoAnterior { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public TiposIngredientes TipoIngrediente { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioPorUnidad { get; set; }
        public int UnidadMinima { get; set; }


        //Redundante, pero si no no hay forma de mostrarlo en la grilla
        public UnidadesDeMedida UnidadDeMedida { get { return GetUnidadMedida(); } }


        public decimal CalcularCosto()
        {
            return PrecioPorUnidad * UnidadMinima;
        }

        public UnidadesDeMedida GetUnidadMedida()
        {
            switch (this.TipoIngrediente)
            {
                case TiposIngredientes.Carne:
                    return UnidadesDeMedida.Kg;
                case TiposIngredientes.Pescado:
                    return UnidadesDeMedida.Kg;
                case TiposIngredientes.Panaderia:
                    return UnidadesDeMedida.Kg;
                case TiposIngredientes.Queso:
                    return UnidadesDeMedida.Kg;
                case TiposIngredientes.Lacteo:
                    return UnidadesDeMedida.Litro;
                case TiposIngredientes.Bebida:
                    return UnidadesDeMedida.Unidad;
                case TiposIngredientes.Fruta:
                    return UnidadesDeMedida.Unidad;
                case TiposIngredientes.HortalizaVerdura:
                    return UnidadesDeMedida.Unidad;
                default:
                    return UnidadesDeMedida.Unidad;
            }
        }

        public GradosDeEscasez GetGradoDeEscasez()
        {
            float relacion = this.Cantidad / this.UnidadMinima;
            if (relacion > 10)
            {
                return GradosDeEscasez.Sobra;
            } else
            {
                if (relacion > 3)
                {
                    return GradosDeEscasez.Normal;
                } else
                {
                    if (relacion > 0.3)
                    {
                        return GradosDeEscasez.Bajo;
                    } else
                    {
                        return GradosDeEscasez.Vacio;
                    }
                }
            }
        }

        public bool NoHaySuficienteIngrediente()
        {
            return this.Cantidad < this.UnidadMinima;
        }

        protected int GetNuevoCodigo()
        {
            CodigoAnterior += 1;
            return CodigoAnterior;
        }
    }

    public class Solido : Ingrediente
    {
        public Solido(string nombre, TiposIngredientes tipoIngrediente, int cantidad,
            decimal precioPorUnidad, int unidadMinima)
        {
            this.Codigo = GetNuevoCodigo();
            this.Nombre = nombre;
            this.TipoIngrediente = tipoIngrediente;
            this.Cantidad = cantidad;
            this.PrecioPorUnidad = precioPorUnidad;
            this.UnidadMinima = unidadMinima;
        }
    }

    public class Bebida : Ingrediente
    {
        public TiposBebidas TipoBebida { get; set; }

        public Bebida(string nombre, TiposIngredientes tipoIngrediente, int cantidad,
            decimal precioPorUnidad, int unidadMinima, TiposBebidas tipoBebida)
        {
            this.Codigo = GetNuevoCodigo();
            this.Nombre = nombre;
            this.TipoIngrediente = tipoIngrediente;
            this.Cantidad = cantidad;
            this.PrecioPorUnidad = precioPorUnidad;
            this.UnidadMinima = unidadMinima;
            this.TipoBebida = tipoBebida;
        }
    }
}
