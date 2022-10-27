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
        private List<Ingrediente> IngredientesEnDespensa = new List<Ingrediente>();

        public AdministradorIngredientes()
        {
            this.IngredientesEnDespensa = LeerIngredientesEnDespensa();
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

        public bool ConsultarStockIngredientesDeReceta(Receta recetaAPreparar)
        {
            foreach (Ingrediente ingredienteReceta in recetaAPreparar.Ingredientes)
            {
                Ingrediente ingredienteDespensa = IngredientesEnDespensa.Find(x => x.Codigo == ingredienteReceta.Codigo);
                
                int cantidadEnStock = ingredienteDespensa.Cantidad;
                int cantidadRequerida = ingredienteReceta.Cantidad;

                if (cantidadEnStock < cantidadRequerida)
                {
                    //Si no hay stock para hacer la receta (en el ingrediente que sea) automaticamente corta el codigo y devuelve false
                    return false;
                }
            }
            return true;
        }

        public void ActualizarStockIngredientes(Receta recetaPreparada)
        {
            foreach (Ingrediente ingredienteReceta in recetaPreparada.Ingredientes)
            {
                Ingrediente ingredienteDespensa = IngredientesEnDespensa.Find(x => x.Codigo == ingredienteReceta.Codigo);

                ingredienteDespensa.Cantidad -= ingredienteReceta.Cantidad;
            }
            GuardarIngredientesEnDespensa();
        }

        public List<Ingrediente> GetIngredientesRecetaPorCodigo(List<int> codigosIngredientes)
        {
            return IngredientesEnDespensa.FindAll(x => codigosIngredientes.Contains(x.Codigo));
        }

        public List<Ingrediente> GetIngredientesAComprar()
        {
            return IngredientesEnDespensa.FindAll(x => x.NoHaySuficienteIngrediente() == true);
        }

        public List<Ingrediente> GetIngredientesEnDespensa()
        {
            return IngredientesEnDespensa;
        }

        public int GetCodigoNuevo()
        {
            return IngredientesEnDespensa.Count + 1;
        }
    }
}
