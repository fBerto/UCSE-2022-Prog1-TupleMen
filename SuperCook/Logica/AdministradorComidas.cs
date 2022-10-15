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

        public void RegistrarComida(int codigoReceta, DateTime FechaComida) {
            //Dentro de registrar comida tendria que buscar la receta en la lista, y comprobar que los ingredientes
            //de esta se encuentren en la despensa, sino no debe permitir registrar la comida.
            AdministradorRecetas. //no nos faltan las relaciones?
            /* Como accedo a las listas, por metodos no puedo, debo hacer una isntanciade ellas?*/
        }
        
        private List<Comida> FiltroSaludable()
        {
            return HistorialComidas.Where(x=>x.Receta.EsSaludable == true).ToList();
        }
        private List<Comida> FiltroNoSaludable()
        {
            return HistorialComidas.Where(x => x.Receta.EsSaludable == false).ToList();
        }
        private List<Comida> FiltroMomentoComidaDesayuno()
        {
            return HistorialComidas.Where(x => x.Receta.MomentoComida== MomentosComida.Desayuno).ToList();
        }
        private List<Comida> FiltroMomentoComidaAlmuerzo()
        {
            return HistorialComidas.Where(x => x.Receta.MomentoComida == MomentosComida.Almuerzo).ToList();
        }
        private List<Comida> FiltroMomentoComidaMerienda()
        {
            return HistorialComidas.Where(x => x.Receta.MomentoComida == MomentosComida.Merienda).ToList();
        }
        private List<Comida> FiltroMomentoComidaCena()
        {
            return HistorialComidas.Where(x => x.Receta.MomentoComida == MomentosComida.Cena).ToList();
        }
        private List<Comida> FlitroFecha(DateTime FechaMenor, DateTime FechaMayor)
        {
            return HistorialComidas.Where(x => x.Fecha>= FechaMenor && x.Fecha <= FechaMayor).ToList();
        }

        private List<Comida> FiltroVecesPreparoComidaDia(DateTime Fecha, Receta recetaRealizada) //no podriamos cambiarlo por lo q mas comiste en una semana?
        {
            List<Comida> Comidas HistorialComidas.Where(x => x.Fecha == Fecha && x.Receta.Codigo == recetaRealizada.Codigo).ToList();
        }

        private string SerializarLista(List<Comida> listaASerializar) {
            return JsonConvert.SerializeObject(listaASerializar);
        }
    }
}
