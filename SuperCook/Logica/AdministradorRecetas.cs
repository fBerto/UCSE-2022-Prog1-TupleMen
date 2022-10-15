using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class AdministradorRecetas : Archivos {
        List<Receta> LibroRecetas = new List<Receta>();
        
        public void CargarReceta(Receta nuevaReceta)
        {
            LibroRecetas.Add(nuevaReceta);
            GuardarLista(SerializarLista(LibroRecetas), "\\serialLibroRecetas.txt");
        }
        public void EliminarReceta(int codigoReceta) {
            LibroRecetas.Remove(LibroRecetas[LibroRecetas.FindIndex(x => x.Codigo == codigoReceta)]);
        }
        public void ModificarReceta(Receta recetaModificada)  
        {
            int IndiceRecetaModificar = LibroRecetas.FindIndex(x => x.Codigo == recetaModificada.Codigo);
            LibroRecetas[IndiceRecetaModificar] = recetaModificada;
        } 

        private string SerializarLista(List<Receta> listaASerializar) {
            return JsonConvert.SerializeObject(listaASerializar);
        }
        
        public List<Receta> getLibroRecetas()
        {
            return LibroRecetas;
        }
    }
}
