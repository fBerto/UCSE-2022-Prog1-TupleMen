using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AdministradorComidas : Archivos
    {
        private List<Comida> HistorialComidas = new List<Comida>();

        public AdministradorComidas()
        {
            //this.HistorialComidas = LeerHistorialComidas();
        }

        Logica.AdministradorIngredientes administradorIngredientes = new Logica.AdministradorIngredientes();

        //-----------------BORRAR--------------------------
        public List<Comida> GetHistorialComidas()
        {
            return HistorialComidas;
        }
        //--------------------------------------------

        //TODO: Devolver algun error , no lo podemos hacer con un try catch?
        public void RegistrarComida(Comida nuevaComida)
        {
            if (administradorIngredientes.RevisarExistenciaIngredientesDeReceta(nuevaComida.Receta))
            {
                HistorialComidas.Add(nuevaComida);
                GuardarLista(SerializarLista(HistorialComidas), nombreArchivoHistorialComidas);
            }
        }

        private List<Comida> FiltroSaludable(bool condicion) //dado por un chekbox de winfrom 
        {
            return HistorialComidas.Where(x => x.Receta.EsSaludable == condicion).ToList();
        }

        private List<Comida> FiltroMomentoComida(MomentosComida momento)
        {
            return HistorialComidas.Where(x => x.Receta.MomentoComida == momento).ToList();
        }

        private List<Comida> FlitroFecha(DateTime FechaMenor, DateTime FechaMayor)
        {
            return HistorialComidas.Where(x => x.Fecha >= FechaMenor && x.Fecha <= FechaMayor).ToList();
        }

        private List<Comida> FlitroPorRecetas(Receta receta)
        {
            return HistorialComidas.Where(x => x.Receta.Codigo == receta.Codigo).ToList();
        }

        private string SerializarLista(List<Comida> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }
    }
}
