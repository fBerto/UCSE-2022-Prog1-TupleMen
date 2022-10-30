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

        public string GetNombre()
        {
            return Nombre;
        }

        public List<Ingrediente> GetIngredientesReceta()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            return administradorIngredientes.UnificarBebidasYSolidos(this.Bebidas, this.Solidos);
        }
    }
}

    
