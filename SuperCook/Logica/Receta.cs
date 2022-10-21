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
    }

    public class RecetaArchivo : Receta
    {
        //TODO: constructor innecesario pero no compila si lo sacamos
        public RecetaArchivo(int codigo, MomentosComida momentoComida, string nombre, bool esSaludable, List<Ingrediente> ingredientes) : base(codigo, momentoComida, nombre, esSaludable, ingredientes)
        {
        }

        public List<int> CodigosIngredientes { get; set; }
    }
}

    
