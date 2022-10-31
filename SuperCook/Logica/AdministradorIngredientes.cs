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
        private static List<Ingrediente> IngredientesEnDespensa = new List<Ingrediente>();

        const int codigoInicial = 1;

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

        public List<Bebida> ExtraerBebidasDe(List<Ingrediente> Ingredientes)
        {
            return Ingredientes.Where(x => x is Bebida).Select(x => x as Bebida).ToList();
        }

        public List<Solido> ExtraerSolidosDe(List<Ingrediente> Ingredientes)
        {
            return Ingredientes.Where(x => x is Solido).Select(x => x as Solido).ToList();
        }

        private string SerializarLista(List<Bebida> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }

        private string SerializarLista(List<Solido> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }

        public bool ConsultarStockIngredientesDeReceta(List<Ingrediente> ingredientesReceta)
        {
            foreach (Ingrediente ingredienteReceta in ingredientesReceta)
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

        public void ActualizarStockIngredientes(List<Ingrediente> ingredientesUsados)
        {
            foreach (Ingrediente ingredienteUsado in ingredientesUsados)
            {
                Ingrediente ingredienteDespensa = IngredientesEnDespensa.Find(x => x.Codigo == ingredienteUsado.Codigo);

                ingredienteDespensa.Cantidad -= ingredienteUsado.Cantidad;
            }
            GuardarIngredientesEnDespensa();
        }

        public List<Ingrediente> GetIngredientesAComprar()
        {
            return IngredientesEnDespensa.FindAll(x => x.NoHaySuficienteIngrediente() == true);
        }

        public List<Ingrediente> GetIngredientesEnDespensa()
        {
            return IngredientesEnDespensa;
        }

        public int GetNuevoCodigo()
        {
            if (IngredientesEnDespensa.Count == 0)
            {
                return codigoInicial;
            }
            else
            {
                return GetCodigoSiguiente();
            }
        }

        private int GetCodigoSiguiente()
        {
            int codigoMaximo = IngredientesEnDespensa.Max(x => x.Codigo);
            return codigoMaximo + 1;
        }

        public void BuscarIngredientesEnArchivos()
        {
            IngredientesEnDespensa = LeerIngredientesEnDespensa();
        }

        public Ingrediente BuscarCodigoIngrediente(int codigoPasado)
        {
            Ingrediente ingredienteEncontrado = IngredientesEnDespensa.Find(x => x.Codigo == codigoPasado);
            return ingredienteEncontrado;
        }


    }
}
