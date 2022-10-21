using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Logica
{
    public abstract class Archivos
    {
        //recibe las recetas comunes, no las recetas archivo
        public const string nombreArchivoLibroRecetas = "LibroRecetas.txt";
        public const string nombreArchivoHistorialComidas = "HistorialComidas.txt";
        public const string nombreArchivoBebidasDespensa = "BebidasDespensa.txt";
        public const string nombreArchivoSolidosDespensa = "SolidosDespensa.txt";
        public const string nombreArchivoBebidasAComprar = "BebidasAComprar.txt";
        public const string nombreArchivoSolidosAComprar = "SolidosAComprar.txt";

        public void GuardarLista(string listaSerializada, string nombreArchivoAGuardar)
        {
            string pathArchivo = GetPathDominio() + nombreArchivoAGuardar;

            using (StreamWriter writer = new StreamWriter(pathArchivo, false))
            {
                writer.Write(listaSerializada);
            }
        }

        private string GetPathDominio()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "\\JSON\\";
        }

        protected List<Bebida> ExtraerBebidasDe(List<Ingrediente> Ingredientes)
        {
            return Ingredientes.Where(x => x is Bebida).Select(x => x as Bebida).ToList();
        }

        protected List<Solido> ExtraerSolidosDe(List<Ingrediente> Ingredientes)
        {
            return Ingredientes.Where(x => x is Solido).Select(x => x as Solido).ToList();
        }

        protected string SerializarLista(List<Bebida> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }

        protected string SerializarLista(List<Solido> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }

        public List<Ingrediente> LeerIngredientesAComprar()
        {
            return UnificarBebidasYSolidos(LeerBebidasAComprar(), LeerSolidosAComprar());
        }

        public List<Ingrediente> LeerIngredientesEnDespensa()
        {
            return UnificarBebidasYSolidos(LeerBebidasDespensa(), LeerSolidosDespensa());
        }

        public List<Receta> LeerLibroRecetas()
        {
            string pathRecetas = GetPathDominio() + nombreArchivoLibroRecetas;
            using (StreamReader reader = new StreamReader(pathRecetas))
            {
                string json = reader.ReadToEnd(); //por cada receta leida llamamos al amdmin ingredientes y buscamos los ingredientes , les pasamos ingredientes (o codigo???), leer lista receta archivo 
                List<Receta> LibroRecetasDesdeArchivo = JsonConvert.DeserializeObject<List<Receta>>(json);
                return LibroRecetasDesdeArchivo;
            }
        }

        public List<Comida> LeerHistorialComidas()
        {
            string pathComidas = GetPathDominio() + nombreArchivoHistorialComidas;
            using (StreamReader reader = new StreamReader(pathComidas))
            {
                string json = reader.ReadToEnd();
                List<Comida> HistorialComidasDesdeArchivo = JsonConvert.DeserializeObject<List<Comida>>(json);
                return HistorialComidasDesdeArchivo;
            }
        }

        private List<Ingrediente> LeerBebidasDespensa()
        {
            string pathBebidas = GetPathDominio() + nombreArchivoBebidasDespensa;
            using (StreamReader reader = new StreamReader(pathBebidas))
            {
                string json = reader.ReadToEnd();
                List<Bebida> HistorialBebidasDesdeArchivo = JsonConvert.DeserializeObject<List<Bebida>>(json);
                List<Ingrediente> HistorialBebidasComoIngredientes = HistorialBebidasDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialBebidasComoIngredientes;
            }
        }
        private List<Ingrediente> LeerSolidosDespensa()
        {
            string pathIngredientesSolidos = GetPathDominio() + nombreArchivoSolidosDespensa;
            using (StreamReader reader = new StreamReader(pathIngredientesSolidos))
            {
                string json = reader.ReadToEnd();
                List<Solido> HistorialSolidosDesdeArchivo = JsonConvert.DeserializeObject<List<Solido>>(json);
                List<Ingrediente> HistorialSolidosComoIngredientes = HistorialSolidosDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialSolidosComoIngredientes;
            }
        }

        private List<Ingrediente> LeerBebidasAComprar()
        {
            string pathBebidas = GetPathDominio() + nombreArchivoBebidasAComprar;
            using (StreamReader reader = new StreamReader(pathBebidas))
            {
                string json = reader.ReadToEnd();
                List<Bebida> HistorialBebidasDesdeArchivo = JsonConvert.DeserializeObject<List<Bebida>>(json);
                List<Ingrediente> HistorialBebidasComoIngredientes = HistorialBebidasDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialBebidasComoIngredientes;
            }
        }
        private List<Ingrediente> LeerSolidosAComprar()
        {
            string pathIngredientesSolidos = GetPathDominio() + nombreArchivoSolidosAComprar;
            using (StreamReader reader = new StreamReader(pathIngredientesSolidos))
            {
                string json = reader.ReadToEnd();
                List<Solido> HistorialSolidosDesdeArchivo = JsonConvert.DeserializeObject<List<Solido>>(json);
                List<Ingrediente> HistorialSolidosComoIngredientes = HistorialSolidosDesdeArchivo.Select(x => x as Ingrediente).ToList();
                return HistorialSolidosComoIngredientes;
            }
        }

        private List<Ingrediente> UnificarBebidasYSolidos(List<Ingrediente> Bebidas, List<Ingrediente> Solidos)
        {
            Solidos.AddRange(Bebidas);
            return Solidos;
        }

        /* TODO:
         * Hago todo aca e instancio en los administradores los metodos que necesito
         * Comida archivos tmb y tiene que tener un codigo de receta 
         */
    }
}
