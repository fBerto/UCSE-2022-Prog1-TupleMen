using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AdministradorIngredientes : Archivos
    {
        private List<Ingrediente> IngredientesEnDespensa;

        public AdministradorIngredientes()
        {
            this.IngredientesEnDespensa = LeerIngredientesEnDespensa();
        }

        //-----------------BORRAR--------------------------
        public List<Ingrediente> GetIngredientesEnDespensa()
        {
            return IngredientesEnDespensa;
        }

        public void CargarIngrediente(Ingrediente nuevoIngrediente)
        {
            IngredientesEnDespensa.Add(nuevoIngrediente);
            GuardarIngredientesEnDespensa();
        }

        public void EliminarIngrediente(int codigo)
        {
            int indiceAEliminar = IngredientesEnDespensa.FindIndex(x => x.Codigo == codigo);
            IngredientesEnDespensa.RemoveAt(indiceAEliminar);
            GuardarIngredientesEnDespensa();
        }

        public void ModificarIngrediente(Ingrediente ingredienteModificado)
        {
            int indiceAModificar = IngredientesEnDespensa.FindIndex(x => x.Codigo == ingredienteModificado.Codigo);
            IngredientesEnDespensa[indiceAModificar] = ingredienteModificado;
            GuardarIngredientesEnDespensa();
        }

        private void GuardarIngredientesEnDespensa()
        {
            List<Bebida> Bebidas = ExtraerBebidasDe(IngredientesEnDespensa);
            List<Solido> Solidos = ExtraerSolidosDe(IngredientesEnDespensa);

            GuardarLista(SerializarLista(Bebidas), nombreArchivoBebidasDespensa);
            GuardarLista(SerializarLista(Solidos), nombreArchivoSolidosDespensa);
        }

        public bool RevisarExistenciaIngredientesDeReceta(Receta RecetaUtilizada)
        {
            bool FueEncontrado = true;
            int i = 0;

            while (!FueEncontrado && i < RecetaUtilizada.Ingredientes.Count())
            {
                Ingrediente ingredienteParticular = RecetaUtilizada.Ingredientes[i];
                FueEncontrado = IngredientesEnDespensa.Exists(x => x.Codigo == ingredienteParticular.Codigo);
                i++;
            }
            return FueEncontrado;
        }
    }
}
