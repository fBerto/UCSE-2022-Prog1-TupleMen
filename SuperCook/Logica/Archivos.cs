using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Logica {
    public abstract class Archivos {
        public bool GuardarLista(string listaSerializada, string nombreArchivoAGuardar) {
            string pathListaAGuardar = AppDomain.CurrentDomain.BaseDirectory + "\\JSON";
            pathListaAGuardar += nombreArchivoAGuardar;

            using (StreamWriter writer = new StreamWriter(pathListaAGuardar, false)) {
                writer.Write(listaSerializada);
                return true;
            }
        }

        public void LecturaArchivos() { }
        //2 metodos apra leer uno soldio y el otro bebidas , de lista de bebidas la puedo trasnformar a lista de ingredientes , hacerlo por instancias 
        private List<Ingrediente> LeerIngredientesEnDespensa() 
        {
            using (StreamReader reader = new StreamReader(pathIngredientesEnDespensa)) //TODO: cambiar path
            {
                string json = reader.ReadToEnd();
                List<Ingrediente> IngredientesEnDespensaDesdeArchivo = JsonConvert.DeserializeObject<List<Ingrediente>>(json);
                return IngredientesEnDespensaDesdeArchivo;
            }
        }
        private List<Ingrediente> LeerIngredientesAComprar()
        {
            using (StreamReader reader = new StreamReader(pathIngredientesEnDespensa))
            {
                string json = reader.ReadToEnd();
                List<Ingrediente> IngredientesAComprarDesdeArchivo = JsonConvert.DeserializeObject<List<Ingrediente>>(json);
                return IngredientesAComprarDesdeArchivo;
            }
        }
        private List<Receta> LeerListaLibroRecetas()
        {
            using (StreamReader reader = new StreamReader(pathIngredientesEnDespensa))
            {
                string json = reader.ReadToEnd();
                List<Receta> LibroRecetasDesdeArchivo = JsonConvert.DeserializeObject<List<Receta>>(json);
                return LibroRecetasDesdeArchivo;
            }
        }
        private List<Comida> LeerHistorialComidas()
        {
            using (StreamReader reader = new StreamReader(pathIngredientesEnDespensa))
            {
                string json = reader.ReadToEnd();
                List<Comida> HistorialComidasDesdeArchivo = JsonConvert.DeserializeObject<List<Comida>>(json);
                return HistorialComidasDesdeArchivo;
            }
        }
    }
}
