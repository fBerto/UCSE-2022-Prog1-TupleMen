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
        public List<int> CodigosIngredientes { get; set; }
        public List<int> CantidadesIngredientes { get; set; }

        public Receta(int codigo, MomentosComida momentoComida, string nombre, bool esSaludable,
            List<int> codigosIngredientes, List<int> cantidadesIngredientes)
        {
            this.Codigo = codigo;
            this.MomentoComida = momentoComida;
            this.Nombre = nombre;
            this.EsSaludable = esSaludable;
            this.CodigosIngredientes = codigosIngredientes;
            this.CantidadesIngredientes = cantidadesIngredientes;
            this.Ingredientes = GetIngredientesConCantidad();
        }

        private List<Ingrediente> GetIngredientesConCantidad()
        {
            AdministradorIngredientes adminIngredientes = new AdministradorIngredientes();

            List<Ingrediente> IngredientesReceta = adminIngredientes.GetIngredientesRecetaPorCodigo(this.CodigosIngredientes);

            int indice = 0;
            foreach (Ingrediente ingrediente in IngredientesReceta)
            {
                ingrediente.Cantidad = this.CantidadesIngredientes[indice];
                indice++;
            }
            return IngredientesReceta;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }
}

    
