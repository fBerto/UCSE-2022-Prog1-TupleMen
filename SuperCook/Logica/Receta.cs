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

        public Receta(int codigo, MomentosComida momentoComida, string nombre, bool esSaludable,
            List<int> codigosIngredientes)
        {
            AdministradorIngredientes adminIngredientes = new AdministradorIngredientes();

            this.Codigo = codigo;
            this.MomentoComida = momentoComida;
            this.Nombre = nombre;
            this.EsSaludable = esSaludable;
            this.CodigosIngredientes = codigosIngredientes;
            this.Ingredientes = adminIngredientes.GetIngredientesRecetaPorCodigo(codigosIngredientes);
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
    }
}

    
