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

        public List<Receta> LeerLibroRecetas()
        {
            string pathRecetas = GetPathDominio() + nombreArchivoLibroRecetas;

            List<Receta> LibroRecetasDesdeArchivo = new List<Receta>();

            if (ArchivoYaExisteOCrearlo(pathRecetas))
            {
                using (StreamReader reader = new StreamReader(pathRecetas))
                {
                    string json = reader.ReadToEnd();
                    LibroRecetasDesdeArchivo = JsonConvert.DeserializeObject<List<Receta>>(json);
                }
            }
            return LibroRecetasDesdeArchivo;
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

        public List<Ingrediente> LeerIngredientesEnDespensa()
        {
            List<Bebida> BebidasDespensa = LeerBebidasDesdeArchivo(nombreArchivoBebidasDespensa);
            List<Solido> SolidosDespensa = LeerSolidosDesdeArchivo(nombreArchivoSolidosDespensa);

            return UnificarBebidasYSolidos(BebidasDespensa, SolidosDespensa);
        }

        private List<Bebida> LeerBebidasDesdeArchivo(string nombreArchivo)
        {
            string pathBebidas = GetPathDominio() + nombreArchivo;

            List<Bebida> BebidasDesdeArchivo = new List<Bebida>();

            if (ArchivoYaExisteOCrearlo(pathBebidas))
            {
                using (StreamReader reader = new StreamReader(pathBebidas))
                {
                    string json = reader.ReadToEnd();
                    BebidasDesdeArchivo = JsonConvert.DeserializeObject<List<Bebida>>(json);
                }
            }
            return BebidasDesdeArchivo;
        }

        private List<Solido> LeerSolidosDesdeArchivo(string nombreArchivo)
        {
            string pathSolidos = GetPathDominio() + nombreArchivo;

            List<Solido> SolidosDesdeArchivo = new List<Solido>();

            if (ArchivoYaExisteOCrearlo(pathSolidos))
            {
                using (StreamReader reader = new StreamReader(pathSolidos))
                {
                    string json = reader.ReadToEnd();
                    SolidosDesdeArchivo = JsonConvert.DeserializeObject<List<Solido>>(json);
                }
            }
            return SolidosDesdeArchivo;
        }

        public List<Ingrediente> UnificarBebidasYSolidos(List<Bebida> Bebidas, List<Solido> Solidos) //TODO: deberiamos hacer lo mismo con los solidos 
        {
            List<Ingrediente> SolidosCasteados = Solidos.Select(x => x as Ingrediente).ToList();
            if (Bebidas != null)
            {
                List<Ingrediente> BebidasCasteadas = Bebidas.Select(x => x as Ingrediente).ToList();
                SolidosCasteados.AddRange(BebidasCasteadas);
            }          
            
            return SolidosCasteados;
        }

        private bool ArchivoYaExisteOCrearlo(string path)
        {
            if (File.Exists(path))
            {
                return true;
            } else
            {
                File.WriteAllText(path, "[]");
                return false;
            }
        }
    }
}
