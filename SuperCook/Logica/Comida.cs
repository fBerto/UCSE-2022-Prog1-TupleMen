using Newtonsoft.Json;
using System;

namespace Logica
{
    public class Comida
    {
        public int Codigo { get; set; }
        public Receta Receta { get; set; }
        public DateTime Fecha { get; set; }
        [JsonIgnore]
        public string NombreReceta { get { return this.Receta.GetNombre(); } }

        public Comida(int codigo, Receta receta, DateTime fecha)
        {
            this.Codigo = codigo;
            this.Receta = receta;
            this.Fecha = fecha;
        }
    }
}
