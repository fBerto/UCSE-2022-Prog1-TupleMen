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
        //CONSULTA PARA MAXI:
        //Guardamos la carpeta JSON con las listas modificando el gitignore?
        //O guardamos una carpeta JSON fuera de la solucion para que el usuario
        //pueda elegir si usarla como su base de datos o comenzar de cero???

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
            return AppDomain.CurrentDomain.BaseDirectory;
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

            List<Comida> HistorialComidasDesdeArchivo = new List<Comida>();

            if (ArchivoYaExisteOCrearlo(pathComidas))
            {
                using (StreamReader reader = new StreamReader(pathComidas))
                {
                    string json = reader.ReadToEnd();
                    HistorialComidasDesdeArchivo = JsonConvert.DeserializeObject<List<Comida>>(json);
                }
            }
            return HistorialComidasDesdeArchivo;
        }

        private List<Ingrediente> LeerBebidasDespensa()
        {
            string pathBebidas = GetPathDominio() + nombreArchivoBebidasDespensa;

            List<Ingrediente> HistorialBebidasComoIngredientes = new List<Ingrediente>();

            if (ArchivoYaExisteOCrearlo(pathBebidas))
            {
                using (StreamReader reader = new StreamReader(pathBebidas))
                {
                    string json = reader.ReadToEnd();
                    List<Bebida> HistorialBebidasDesdeArchivo = JsonConvert.DeserializeObject<List<Bebida>>(json);
                    HistorialBebidasComoIngredientes = HistorialBebidasDesdeArchivo.Select(x => x as Ingrediente).ToList();
                }
            }
            return HistorialBebidasComoIngredientes;
        }

        private List<Ingrediente> LeerSolidosDespensa()
        {
            string pathSolidos = GetPathDominio() + nombreArchivoSolidosDespensa;

            List<Ingrediente> HistorialSolidosComoIngredientes = new List<Ingrediente>();

            if (ArchivoYaExisteOCrearlo(pathSolidos))
            {
                using (StreamReader reader = new StreamReader(pathSolidos))
                {
                    string json = reader.ReadToEnd();
                    List<Solido> HistorialSolidosDesdeArchivo = JsonConvert.DeserializeObject<List<Solido>>(json);
                    HistorialSolidosComoIngredientes = HistorialSolidosDesdeArchivo.Select(x => x as Ingrediente).ToList();
                }
            }
            return HistorialSolidosComoIngredientes;
        }

        private List<Ingrediente> LeerBebidasAComprar()
        {
            string pathBebidas = GetPathDominio() + nombreArchivoBebidasAComprar;

            List<Ingrediente> HistorialBebidasComoIngredientes = new List<Ingrediente>();

            if (ArchivoYaExisteOCrearlo(pathBebidas))
            {
                using (StreamReader reader = new StreamReader(pathBebidas))
                {
                    string json = reader.ReadToEnd();
                    List<Bebida> HistorialBebidasDesdeArchivo = JsonConvert.DeserializeObject<List<Bebida>>(json);
                    HistorialBebidasComoIngredientes = HistorialBebidasDesdeArchivo.Select(x => x as Ingrediente).ToList();
                }
            }
            return HistorialBebidasComoIngredientes;
        }

        private List<Ingrediente> LeerSolidosAComprar()
        {
            string pathSolidos = GetPathDominio() + nombreArchivoSolidosAComprar;

            List<Ingrediente> HistorialSolidosComoIngredientes = new List<Ingrediente>();

            if (ArchivoYaExisteOCrearlo(pathSolidos))
            {
                using (StreamReader reader = new StreamReader(pathSolidos))
                {
                    string json = reader.ReadToEnd();
                    List<Solido> HistorialSolidosDesdeArchivo = JsonConvert.DeserializeObject<List<Solido>>(json);
                    HistorialSolidosComoIngredientes = HistorialSolidosDesdeArchivo.Select(x => x as Ingrediente).ToList();
                }
            }
            return HistorialSolidosComoIngredientes;
        }

        private List<Ingrediente> UnificarBebidasYSolidos(List<Ingrediente> Bebidas, List<Ingrediente> Solidos)
        {
            Solidos.AddRange(Bebidas);
            return Solidos;
        }

        private bool ArchivoYaExisteOCrearlo(string path)
        {
            if (File.Exists(path))
            {
                return true;
            } else
            {
                File.Create(path);
                return false;
            }
        }
    }
}
