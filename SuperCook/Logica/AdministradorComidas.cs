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
        //TODO: Es necesario inicializar la lista???? ES una variable de instancia, no se inicializan
        //En tal caso corregir el resto de administradores.
        private List<Comida> HistorialComidas = new List<Comida>();

        public AdministradorComidas()
        {
            this.HistorialComidas = LeerHistorialComidas();
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
            List<Ingrediente> IngredientesEnDespensa = administradorIngredientes.getIngredientesEnDespensa();

            if (RevisarIngredienteExisteEnDespensa(nuevaComida.Receta, IngredientesEnDespensa))
            {
                HistorialComidas.Add(nuevaComida);
                GuardarLista(SerializarLista(HistorialComidas), nombreArchivoHistorialComidas);
            }
        }

        //TODO: Este metodo no pertenece a la clase AdministradorIngrediente???
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
