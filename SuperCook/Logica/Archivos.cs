using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Logica {
    public abstract class Archivos {
        public bool GuardarLista(List<object> listaAGuardar, string nombreArchivo) {
            string pathListaAGuardar = AppDomain.CurrentDomain.BaseDirectory + "\\JSON";
            pathListaAGuardar += nombreArchivo;

            using (StreamWriter writer = new StreamWriter(pathListaAGuardar, false)) {
                string serialIngredientesEnDespensa = JsonConvert.SerializeObject(listaAGuardar);
                writer.Write(serialIngredientesEnDespensa);
                return true;
            }
        }

        private List<Camiones> leerListaCamiones()
        {
            using (StreamReader reader = new StreamReader(pathCamiones))
            {
                string json = reader.ReadToEnd();
                List<Camiones> CamionesDesdeArchivo = JsonConvert.DeserializeObject<List<Camiones>>(json);
                return CamionesDesdeArchivo;
            }
        }
        /*TODO: CREARLISTAS 
         * EnDespensa
         * AComprar
         * LibroRecetas
         * HistorialComidas
         */
    }
}
