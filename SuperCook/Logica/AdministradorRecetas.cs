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
            //List<RecetaArchivo> LibroRecetasArchivos = LibroRecetas.Where(x => x is Receta).Select(x => x as RecetaArchivo).ToList();
            foreach (Receta receta in LibroRecetas)
            {
                LibroRecetasArchivos.Add(receta as RecetaArchivo);
            }
            foreach (RecetaArchivo receta in LibroRecetasArchivos)
            {
                int indiceingrediente = 0;

                foreach (Ingrediente ingrediente in receta.Ingredientes)
                {
                    receta.CodigosIngredientes[indiceingrediente] = ingrediente.Codigo;
                    indiceingrediente++;
                }
            }
            return LibroRecetasArchivos;
        }

        //TODO: codear
        public List<Receta> ConvertirRecetasArchivoARecetas()
        {
            return null;
        }

        private string SerializarLista(List<RecetaArchivo> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }
    }
}
