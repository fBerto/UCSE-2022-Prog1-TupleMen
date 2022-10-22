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
        private List<Receta> LibroRecetas = new List<Receta>();

        public AdministradorRecetas()
        {
            //this.LibroRecetas = LeerLibroRecetas();
        }

        //-----------------BORRAR--------------------------
        public List<Receta> GetLibroRecetas()
        {
            return LibroRecetas;
        }

        public void CargarReceta(Receta nuevaReceta)
        {
            LibroRecetas.Add(nuevaReceta);
            GuardarLista(SerializarLista(ConvertirLibroRecetasALibroRecetasArchivos()), nombreArchivoLibroRecetas);
        }

        public void EliminarReceta(int codigoReceta)
        {
            int indiceRecetaAEliminar = LibroRecetas.FindIndex(x => x.Codigo == codigoReceta);
            LibroRecetas.RemoveAt(indiceRecetaAEliminar);
        }

        public void ModificarReceta(Receta recetaModificada)
        {
            int IndiceRecetaModificar = LibroRecetas.FindIndex(x => x.Codigo == recetaModificada.Codigo);
            LibroRecetas[IndiceRecetaModificar] = recetaModificada;
        }

        public List<RecetaArchivo> ConvertirLibroRecetasALibroRecetasArchivos()
        {
            List<RecetaArchivo> LibroRecetasArchivos = new List<RecetaArchivo>();

            foreach (Receta receta in LibroRecetas)
            {
                LibroRecetasArchivos.Add(receta.ConvertirRecetaARecetaArchivo());
            }
            return LibroRecetasArchivos;
        }

        private string SerializarLista(List<RecetaArchivo> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }
    }
}
