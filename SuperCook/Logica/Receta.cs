using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Receta
    {
        public int Codigo { get; set; }
        public MomentosComida MomentoComida { get; set; }
        public string Nombre { get; set; }
        public bool EsSaludable { get; set; }

        [JsonIgnore]
        public List<Ingrediente> Ingredientes { get; set; }

        public Receta(int codigo, MomentosComida momentoComida, string nombre, bool esSaludable,
            List<Ingrediente> ingredientes)
        {
            this.Codigo = codigo;
            this.MomentoComida = momentoComida;
            this.Nombre = nombre;
            this.EsSaludable = esSaludable;
            this.Ingredientes = ingredientes;
        }

        public List<int> GetListaCodigosIngredientes()
        {
            List<int> codigosIngredientes = new List<int>();

            foreach (Ingrediente ingrediente in this.Ingredientes)
            {
                codigosIngredientes.Add(ingrediente.Codigo);
            }

            return codigosIngredientes;
        }

        public RecetaArchivo ConvertirRecetaARecetaArchivo()
        {
            RecetaArchivo recetaArchivo = new RecetaArchivo(
                this.GetListaCodigosIngredientes(),
                this.Codigo,
                this.MomentoComida,
                this.Nombre,
                this.EsSaludable,
                this.Ingredientes);

            return recetaArchivo;
        }
    }

    public class RecetaArchivo : Receta
    {
        public List<int> CodigosIngredientes { get; set; }

        public RecetaArchivo(List<int> codigosIngredientes, int codigo, MomentosComida momentoComida, string nombre, bool esSaludable, List<Ingrediente> ingredientes)
            : base(codigo, momentoComida, nombre, esSaludable, ingredientes)
        {
            CodigosIngredientes = codigosIngredientes;
        }
    }
}

    
