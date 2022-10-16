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

        public void RegistrarComida(Receta RecetaUtilizada, DateTime FechaComida) {
            List<Receta> Recetas = administradorRecetas.getLibroRecetas();
            List<Ingrediente> IngredientesEnDespensa = administradorIngredientes.getIngredientesEnDespensa();

            if (RevisarIngredienteExisteEnDespensa(RecetaUtilizada , Recetas, IngredientesEnDespensa))
            {
               Comida comida = new Comida(); //TODO:Constructor o no?
                comida.Receta = RecetaUtilizada;
                comida.Fecha = FechaComida;
                HistorialComidas.Add(comida);
                GuardarLista(SerializarLista(HistorialComidas), "\\serialHistorialComidas.txt");
            }
            else //TODO: Devolver algun error , no lo podemos hacer con un try catch?
            {

            }

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
        private bool RevisarIngredienteExisteEnDespensa(Receta RecetaUtilizada, List<Receta> Recetas, List<Ingrediente> IngredientesEnDespensa)
        {
            List<Ingrediente> IngredientesDeLaRecetaUtilizada = RecetaUtilizada.Ingredientes.Select(x => x as Ingrediente).ToList();

            bool FueEncontrado = true;
            while (!FueEncontrado)
            {
                int i = 0;
                Ingrediente ingredienteParticular = IngredientesDeLaRecetaUtilizada[i];
                FueEncontrado = IngredientesDeLaRecetaUtilizada.Exists(x => x.Codigo == ingredienteParticular.Codigo);
                i++;
            }
            return FueEncontrado;
        }
    }
}
