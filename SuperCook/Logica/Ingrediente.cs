using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Ingrediente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public TiposIngredientes TipoIngrediente { get; set; }
        //TODO: podria pasar la cantidad a decimal, ver si no rompe y se muestra bien en grillas
        public int Cantidad { get; set; }
        public decimal PrecioPorUnidad { get; set; }
        public int UnidadMinima { get; set; }
        [JsonIgnore]
        public UnidadesDeMedida UnidadDeMedida { get { return GetUnidadMedida(); } }
        [JsonIgnore]
        public decimal Costo { get { return GetCosto(); } }
        [JsonIgnore]
        public int CantidadAComprar { get { return GetCantidadAComprar(); } }

        private int GetCantidadAComprar()
        {
            return UnidadMinima * 5;
        }

        public decimal GetCosto()
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
            float relacion = (float)this.Cantidad / (float)this.UnidadMinima;
            if (relacion > 3)
            {
                return GradosDeEscasez.Sobra;
            } else
            {
                if (relacion > 0.9)
                {
                    return GradosDeEscasez.Normal;
                } else
                {
                    if (relacion > 0.5)
                    {
                        return GradosDeEscasez.Bajo;
                    } else
                    {
                        if (relacion > 0.1)
                        {
                            return GradosDeEscasez.Escaso;
                        } else
                        {
                            return GradosDeEscasez.Vacio;
                        }
                    }
                }
            }
        }

        public bool NoHaySuficienteIngrediente()
        {
            return this.Cantidad < this.UnidadMinima;
        }
    }

    public class Solido : Ingrediente
    {
        public Solido(int codigo, string nombre, TiposIngredientes tipoIngrediente, int cantidad,
            decimal precioPorUnidad, int unidadMinima)
        {
            this.Codigo = codigo;
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

        public Bebida(int codigo, string nombre, TiposIngredientes tipoIngrediente, int cantidad,
            decimal precioPorUnidad, int unidadMinima, TiposBebidas tipoBebida)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.TipoIngrediente = tipoIngrediente;
            this.Cantidad = cantidad;
            this.PrecioPorUnidad = precioPorUnidad;
            this.UnidadMinima = unidadMinima;
            this.TipoBebida = tipoBebida;
        }
    }
}
