using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class AdministradorRecetas : Archivos
    {
        private static List<Receta> LibroRecetas = new List<Receta>();

        private const int codigoInicial = 1;

        public Resultado CargarModificarReceta(Receta nuevaReceta)
        {
            if (string.IsNullOrEmpty(nuevaReceta.Nombre))
            {
                return new Resultado(false, "La receta debe tener un nombre");
            }
            if (nuevaReceta.GetIngredientesReceta().Count == 0)
            {
                return new Resultado(false, "Debe cargarle ingredientes a la receta");
            }
            if (HayCantidadesDeIngredienteNulas(nuevaReceta))
            {
                return new Resultado(false, "Las cantidades de los ingredientes no pueden ser negativas ni iguales a cero");
            }
            if (nuevaReceta.Codigo == 0)
            {
                nuevaReceta.Codigo = GetNuevoCodigo();
                LibroRecetas.Add(nuevaReceta);
            } else
            {
                SobreescribirReceta(nuevaReceta);
            }
            GuardarLista(SerializarLista(LibroRecetas), nombreArchivoLibroRecetas);
            return new Resultado(true, "Carga exitosa");
        }

        private bool HayCantidadesDeIngredienteNulas(Receta receta)
        {
            List<Ingrediente> ingredientes = receta.GetIngredientesReceta();
            foreach (Ingrediente ingrediente in ingredientes)
            {
                if (ingrediente.Cantidad <= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void SobreescribirReceta(Receta nuevaReceta)
        {
            int IndiceRecetaModificar = LibroRecetas.FindIndex(x => x.Codigo == nuevaReceta.Codigo);
            LibroRecetas[IndiceRecetaModificar] = nuevaReceta;
        }

        public void EliminarReceta(int codigoReceta)
        {
            int indiceRecetaAEliminar = LibroRecetas.FindIndex(x => x.Codigo == codigoReceta);
            LibroRecetas.RemoveAt(indiceRecetaAEliminar);
            GuardarLista(SerializarLista(LibroRecetas), nombreArchivoLibroRecetas);
        }

        private int GetNuevoCodigo()
        {
            if (LibroRecetas.Count == 0)
            {
                return codigoInicial;
            } else
            {
                return GetCodigoSiguiente();
            }
        }

        private int GetCodigoSiguiente()
        {
            int codigoMaximo = LibroRecetas.Max(x => x.Codigo);
            return codigoMaximo + 1;
        }

        private string SerializarLista(List<Receta> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }

        public List<Receta> GetLibroRecetas()
        {
            return LibroRecetas;
        }

        public void BuscarRecetasEnArchivos()
        {
            LibroRecetas = LeerLibroRecetas();
        }

        public Receta BuscarCodigoReceta(int codigoRecibido)
        {
            Receta receta= LibroRecetas.Find(x => x.Codigo == codigoRecibido);
            return receta;
        }

        public List<Receta> GetRecetasDisponiblesPorMomentoComida(MomentosComida momento)
        {
            return GetRecetasDisponibles().Where(x => x.MomentoComida == momento).ToList();
        }

        private List<Receta> GetRecetasDisponibles()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            List<Receta> RecetasDisponibles = new List<Receta>();

            RecetasDisponibles = LibroRecetas.Where(x => administradorIngredientes.ConsultarStockIngredientesDeReceta(x.GetIngredientesReceta())).ToList();

            return RecetasDisponibles;
        }
    }
}
