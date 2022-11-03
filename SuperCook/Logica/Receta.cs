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

        [JsonConstructor]
        public Receta(int codigo, MomentosComida momentoComida, string nombre, bool esSaludable, List<Bebida> bebidas, List<Solido> solidos)
        {
            Codigo = codigo;
            MomentoComida = momentoComida;
            Nombre = nombre;
            EsSaludable = esSaludable;
            Bebidas = bebidas;
            Solidos = solidos;
        }

        public Receta(int codigo, MomentosComida momentoComida, string nombre, bool esSaludable,
            List<Ingrediente> ingredientes)
        {
            this.Codigo = codigo;
            this.MomentoComida = momentoComida;
            this.Nombre = nombre;
            this.EsSaludable = esSaludable;

            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

            if (ingredientes.Exists(x => x is Bebida))
            {
                this.Bebidas = administradorIngredientes.ExtraerBebidasDe(ingredientes);
            }
            if (ingredientes.Exists(x => x is Solido))
            {
                this.Solidos = administradorIngredientes.ExtraerSolidosDe(ingredientes);
            }
        }

        public Receta() { }

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

    
