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
            LeerIngredientesAComprar();
            LeerListaLibroRecetas();
            LeerHistorialComidas();
            LeerIngredentesBebidasDespensa();
            LeerIngredeitnesSolidosDespensa();
            LeerIngredentesBebidasAComprar();
            LeerIngredeitnesSolidosAComprar();
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
            string pathRecetas = GetPathDominio() + "\\serialLibroRecetas.txt";
            using (StreamReader reader = new StreamReader(pathRecetas))
            {
                string json = reader.ReadToEnd();
                List<Receta> LibroRecetasDesdeArchivo = JsonConvert.DeserializeObject<List<Receta>>(json);
                return LibroRecetasDesdeArchivo;
            }
        }
        private List<Comida> LeerHistorialComidas()
        {
            string pathComidas = GetPathDominio() + "\\serialHistorialComidas.txt";
            using (StreamReader reader = new StreamReader(pathComidas))
            {
                string json = reader.ReadToEnd();
                List<Comida> HistorialComidasDesdeArchivo = JsonConvert.DeserializeObject<List<Comida>>(json);
                return HistorialComidasDesdeArchivo;
            }
        }
        private List<Ingrediente> LeerIngredentesBebidasDespensa()
        {
            string pathBebidas = GetPathDominio() + "\\serialBebidasDespensa.txt";
            using (StreamReader reader = new StreamReader(pathBebidas))
            {
                string json = reader.ReadToEnd();
                List<Bebida> HistorialBebidasDesdeArchivo = JsonConvert.DeserializeObject<List<Bebida>>(json);
                List<Ingrediente> HistorialBebidasComoIngredientes = HistorialBebidasDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialBebidasComoIngredientes;
            }
        }
        private List<Ingrediente> LeerIngredeitnesSolidosDespensa()
        {
            string pathIngredientesSolidos = GetPathDominio() + "\\serialIngredientesSolidosDespensa.txt";
            using (StreamReader reader = new StreamReader(pathIngredientesSolidos))
            {
                string json = reader.ReadToEnd();
                List<Solido> HistorialSolidosDesdeArchivo = JsonConvert.DeserializeObject<List<Solido>>(json);
                List<Ingrediente> HistorialSolidosComoIngredientes = HistorialSolidosDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialSolidosComoIngredientes;
            }
        }

        private List<Ingrediente> LeerIngredentesBebidasAComprar()
        {
            string pathBebidas = GetPathDominio() + "\\serialBebidasAComprar.txt";
            using (StreamReader reader = new StreamReader(pathBebidas))
            {
                string json = reader.ReadToEnd();
                List<Bebida> HistorialBebidasDesdeArchivo = JsonConvert.DeserializeObject<List<Bebida>>(json);
                List<Ingrediente> HistorialBebidasComoIngredientes = HistorialBebidasDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialBebidasComoIngredientes;
            }
        }
        private List<Ingrediente> LeerIngredeitnesSolidosAComprar()
        {
            string pathIngredientesSolidos = GetPathDominio() + "\\serialIngredientesSolidosAComprar.txt";
            using (StreamReader reader = new StreamReader(pathIngredientesSolidos))
            {
                string json = reader.ReadToEnd();
                List<Solido> HistorialSolidosDesdeArchivo = JsonConvert.DeserializeObject<List<Solido>>(json);
                List<Ingrediente> HistorialSolidosComoIngredientes = HistorialSolidosDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialSolidosComoIngredientes;
            }
        }

        private List<Ingrediente> UnificarBebidasYSolidos(List<Ingrediente> Bebidas, List<Ingrediente> Solidos) //El mismo metodo para compra y en despensa, cambia la lista que le esten pasando
        {
            Solidos.AddRange(Bebidas); //podria transformar dentro del metodo las listas en listas de ingredientes 
            return Solidos;
        }
            


        /* Hago todo aca e instancio en los administradores los metodos que necesito?
         * No puedo tener un solo metodo de lectura de listas que reciba el path?
         * Como vamos a hacer para saber si nuestro ingrediente es por ej carne?, no deberia trasnformarlo cuando leo?
         */
    }
}
