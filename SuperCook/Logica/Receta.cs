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
        private static int CodigoAnterior { get; set; }
        public int Codigo { get; set; }
        public MomentosComida MomentoComida { get; set; }
        public string Nombre { get; set; }
        public bool EsSaludable { get; set; }
        public List<Bebida> Bebidas { get; set; }
        public List<Solido> Solidos { get; set; }

        public Receta(int codigo, MomentosComida momentoComida, string nombre, bool esSaludable,
            List<Bebida> bebidas, List<Solido> solidos)
        {
            this.Codigo = codigo;
            this.MomentoComida = momentoComida;
            this.Nombre = nombre;
            this.EsSaludable = esSaludable;
            this.Bebidas = bebidas;
            this.Solidos = solidos;
        }

        private int GetNuevoCodigo()
        {
            CodigoAnterior = CodigoAnterior + 1;
            return CodigoAnterior;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public List<Bebida> GetBebidasReceta()
        {
            return this.Bebidas;
        }

        public List<Solido> GetSolidosReceta()
        {
            return this.Solidos;
        }
    }
}

    
