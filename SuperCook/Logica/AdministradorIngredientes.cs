using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class AdministradorIngredientes : Archivos
    {
        private static List<Ingrediente> IngredientesEnDespensa = new List<Ingrediente>();

        private const int codigoInicial = 1;

        public Resultado CargarModificarIngrediente(Ingrediente nuevoIngrediente)
        {
            if (string.IsNullOrEmpty(nuevoIngrediente.Nombre))
            {
                return new Resultado(false, "El ingrediente debe tener un nombre");
            }
            if (IngresoValoresNegativos(nuevoIngrediente))
            {
                return new Resultado(false, "No puede ingresar valores negativos");
            }
            if (nuevoIngrediente.Codigo == 0)
            {
                nuevoIngrediente.Codigo = GetNuevoCodigo();
                IngredientesEnDespensa.Add(nuevoIngrediente);
            } else
            {
                SobreescribirIngrediente(nuevoIngrediente);
            }
            GuardarIngredientesEnDespensa();
            return new Resultado(true, "Carga exitosa");
        }

        private void SobreescribirIngrediente(Ingrediente ingrediente)
        {
            int indiceAModificar = IngredientesEnDespensa.FindIndex(x => x.Codigo == ingrediente.Codigo);
            IngredientesEnDespensa[indiceAModificar] = ingrediente;
        }

        private bool IngresoValoresNegativos(Ingrediente nuevoIngrediente)
        {
            return nuevoIngrediente.Cantidad < 0 || nuevoIngrediente.UnidadMinima < 0 || nuevoIngrediente.PrecioPorUnidad < 0;
        }

        public void EliminarIngrediente(int codigo)
        {
            int indiceAEliminar = IngredientesEnDespensa.FindIndex(x => x.Codigo == codigo);
            IngredientesEnDespensa.RemoveAt(indiceAEliminar);
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
            List<Bebida> bebidasExtraidas = new List<Bebida>();
            bebidasExtraidas.AddRange(Ingredientes.Where(x => x is Bebida).Select(x => x as Bebida).ToList());
            return bebidasExtraidas;
        }

        public List<Solido> ExtraerSolidosDe(List<Ingrediente> Ingredientes)
        {
            List<Solido> solidosExtraidos = new List<Solido>();
            solidosExtraidos.AddRange(Ingredientes.Where(x => x is Solido).Select(x => x as Solido).ToList());
            return solidosExtraidos;
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

                if (ingredienteDespensa is null)
                {
                    return false;
                }

                int cantidadEnStock = ingredienteDespensa.Cantidad;
                int cantidadRequerida = ingredienteReceta.Cantidad;

                if (cantidadEnStock < cantidadRequerida)
                {
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

        private int GetNuevoCodigo()
        {
            if (IngredientesEnDespensa.Count == 0)
            {
                return codigoInicial;
            } else
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
