using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Comida
    {
        private static int CodigoAnterior { get; set; }
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

        private int GetNuevoCodigo()
        {
            CodigoAnterior = CodigoAnterior + 1;
            return CodigoAnterior;
        }
    }
}
