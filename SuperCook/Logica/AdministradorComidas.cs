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

        public void RegistrarComida(int codigoReceta, DateTime FechaComida) { //TODO: Terminar
            //Dentro de registrar comida tendria que buscar la receta en la lista, y comprobar que los ingredientes
            //de esta se encuentren en la despensa, sino no debe permitir registrar la comida.

            //AdministradorRecetas //no nos faltan las relaciones?
            /* Como accedo a las listas, por metodos no puedo, debo hacer una isntanciade ellas?*/
            
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

        // TODO: Pensar otro criterio para flitrar comidas 

        private string SerializarLista(List<Comida> listaASerializar) {
            return JsonConvert.SerializeObject(listaASerializar);
        }
    }
}
