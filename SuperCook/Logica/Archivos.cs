using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Logica {
    public abstract class Archivos {
        public void GuardarLista(string listaSerializada, string nombreArchivoAGuardar) {
            string pathArchivo = GetPathDominio() + nombreArchivoAGuardar;

            using (StreamWriter writer = new StreamWriter(pathArchivo, false)) {
                writer.Write(listaSerializada);
            }
        }

        private string GetPathDominio() {
            return AppDomain.CurrentDomain.BaseDirectory + "\\JSON";
        }

        public void LecturaArchivosAlIniciar()
        {
            LeerIngredientesEnDespensa();
            LeerIngredientesAComprar();
            //string pathIngredientesEnDespensa = path + "\\serialCamiones.txt";
            //string pathIngredientesAComprar = path + "\\serialCamiones.txt";
            //string pathLibroRecetas = path + "\\serialCamiones.txt";
            //string pathHistorialComidas = path + "\\serialCamiones.txt";
        }
        //2 metodos para leer uno soldio y el otro bebidas , de lista de bebidas la puedo trasnformar a lista de ingredientes , hacerlo por instancias 
        private List<Ingrediente> LeerIngredientesEnDespensa()
        {
            string pathIngredientesEnDespensa = GetPathDominio() + "\\serialIngredientesEnDespensa.txt";
            using (StreamReader reader = new StreamReader(pathIngredientesEnDespensa))
            {
                string json = reader.ReadToEnd();
                List<Ingrediente> IngredientesEnDespensaDesdeArchivo = JsonConvert.DeserializeObject<List<Ingrediente>>(json);
                return IngredientesEnDespensaDesdeArchivo;
            }
        }
        private List<Ingrediente> LeerIngredientesAComprar()
        {
            string pathIngredientesAComprar = GetPathDominio() + "\\serialIngredientesAComprar.txt";
            using (StreamReader reader = new StreamReader(pathIngredientesAComprar))
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
        private List<Ingrediente> LeerIngredentesBebidas()
        {
            string pathBebidas = GetPathDominio() + "\\serialBebidas.txt";
            using (StreamReader reader = new StreamReader(pathBebidas))
            {
                string json = reader.ReadToEnd();
                List<Bebida> HistorialBebidasDesdeArchivo = JsonConvert.DeserializeObject<List<Bebida>>(json);
                List<Ingrediente> HistorialBebidasComoIngredientes = HistorialBebidasDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialBebidasComoIngredientes;
            }
        }
        private List<Ingrediente> LeerIngredeitnesSolidos()
        {
            string pathIngredientesSolidos = GetPathDominio() + "\\serialIngredientesSolidos.txt";
            using (StreamReader reader = new StreamReader(pathIngredientesSolidos))
            {
                string json = reader.ReadToEnd();
                List<Ingrediente> IngredientesEnDespensaDesdeArchivo = JsonConvert.DeserializeObject<List<Ingrediente>>(json);
                return IngredientesEnDespensaDesdeArchivo;
            }
        }

        /*Estoy seguro sobre el metodo de ingredientes bebidas, pero el de los solidos no me quedo claro, no enteindo si
        * Debo hacer un solo metodo de leer ingredeitnes solidos y dsp para trasnforar eso se hace por cada clase 
            o si hacer un metodo distinto por cada archivo 
        *Tampoco tengo claro a que se referia con lo de instancias, quiere que haga todo aca y que instance en los administradores los metodos que necesita?*/
    }
}
