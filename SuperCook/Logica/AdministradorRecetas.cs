using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AdministradorRecetas : Archivos
    {
        private static List<Receta> LibroRecetas = new List<Receta>();

        const int codigoInicial = 1;

        public void CargarReceta(Receta nuevaReceta)
        {
            LibroRecetas.Add(nuevaReceta);
            GuardarLista(SerializarLista(LibroRecetas), nombreArchivoLibroRecetas);
        }

        public void EliminarReceta(int codigoReceta)
        {
            int indiceRecetaAEliminar = LibroRecetas.FindIndex(x => x.Codigo == codigoReceta);
            LibroRecetas.RemoveAt(indiceRecetaAEliminar);
            GuardarLista(SerializarLista(LibroRecetas), nombreArchivoLibroRecetas);
        }

        public void ModificarReceta(Receta recetaModificada)
        {
            int IndiceRecetaModificar = LibroRecetas.FindIndex(x => x.Codigo == recetaModificada.Codigo);
            LibroRecetas[IndiceRecetaModificar] = recetaModificada;
            GuardarLista(SerializarLista(LibroRecetas), nombreArchivoLibroRecetas);
        }

        public int GetNuevoCodigo()
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

        private List<Receta> GetRecetasDisponibles()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            List<Receta> RecetasDisponibles = new List<Receta>();

            RecetasDisponibles = LibroRecetas.Where(x => administradorIngredientes.ConsultarStockIngredientesDeReceta(x.GetIngredientesReceta())).ToList();

            return RecetasDisponibles;
        }

        public List<Receta> GetRecetasDisponiblesPorMomentoComida(MomentosComida momento)
        {
            return GetRecetasDisponibles().Where(x => x.MomentoComida == momento).ToList();
        }
    }
}
