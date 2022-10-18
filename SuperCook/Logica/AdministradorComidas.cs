using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AdministradorComidas : Archivos {
        List<Comida> HistorialComidas = new List<Comida>();

        Logica.AdministradorRecetas administradorRecetas = new Logica.AdministradorRecetas();
        Logica.AdministradorIngredientes administradorIngredientes = new Logica.AdministradorIngredientes();

        public void RegistrarComida(Comida nuevaComida) {
            List<Ingrediente> IngredientesEnDespensa = administradorIngredientes.getIngredientesEnDespensa();

            if (RevisarIngredienteExisteEnDespensa(nuevaComida.Receta, IngredientesEnDespensa)) //TODO: Devolver algun error , no lo podemos hacer con un try catch?
            {
                HistorialComidas.Add(nuevaComida);
                GuardarLista(SerializarLista(HistorialComidas), nombreArchivoHistorialComidas);
            }
        }
        private bool RevisarIngredienteExisteEnDespensa(Receta RecetaUtilizada, List<Ingrediente> IngredientesEnDespensa)
        {
            bool FueEncontrado = true;
            int i = 0;

            while (!FueEncontrado && i < RecetaUtilizada.Ingredientes.Count())
            {
                Ingrediente ingredienteParticular = RecetaUtilizada.Ingredientes[i];
                FueEncontrado = IngredientesEnDespensa.Exists(x => x.Codigo == ingredienteParticular.Codigo);
                i++;
            }
            return FueEncontrado;
        }

        private List<Comida> FiltroSaludable(bool condicion) //dadoo por un chekbox de winfrom 
        {
            return HistorialComidas.Where(x => x.Receta.EsSaludable == condicion).ToList();
        }

        private List<Comida> FiltroMomentoComida(MomentosComida momento)
        {
            return HistorialComidas.Where(x => x.Receta.MomentoComida == momento).ToList();
        }
        
        private List<Comida> FlitroFecha(DateTime FechaMenor, DateTime FechaMayor)
        {
            return HistorialComidas.Where(x => x.Fecha>= FechaMenor && x.Fecha <= FechaMayor).ToList();
        }

        private List<Comida> FlitroPorRecetas(Receta receta)
        {
            return HistorialComidas.Where(x => x.Receta.Codigo == receta.Codigo).ToList();
        }

        private string SerializarLista(List<Comida> listaASerializar) {
            return JsonConvert.SerializeObject(listaASerializar);
        }
        
    }
}
