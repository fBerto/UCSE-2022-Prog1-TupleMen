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
        private static List<Comida> HistorialComidas = new List<Comida>();

        const int codigoInicial = 1;

        public void CargarComida(Comida nuevaComida)
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

            List<Ingrediente> IngredientesUsados = nuevaComida.Receta.GetIngredientesReceta();

            administradorIngredientes.ActualizarStockIngredientes(IngredientesUsados);

            HistorialComidas.Add(nuevaComida);
            GuardarLista(SerializarLista(HistorialComidas), nombreArchivoHistorialComidas);
        }

        public List<Comida> FiltrarHistorialComidas (SeleccionFiltrosComidas filtros)
        {
            List<Comida> comidasFiltradas = HistorialComidas;

            if (filtros.PorSaludable)
            {
                comidasFiltradas = FiltroSaludable(filtros.EsSaludable);
            }

            if (filtros.PorMomentoComida)
            {
                List<Comida> comidasFiltradasPorMomento = FiltroMomentoComida(filtros.Momento);

                CombinarFiltros(comidasFiltradas, comidasFiltradasPorMomento);
            }

            if (filtros.PorFecha)
            {
                //TODO: contemplar error fecha menor es mayor a fecha mayor

                List<Comida> comidasFiltradasPorFecha = FiltroFecha(filtros.FechaMenor, filtros.FechaMayor);

                CombinarFiltros(comidasFiltradas, comidasFiltradasPorFecha);
            }
            if (filtros.PorReceta)
            {
                List<Comida> comidasFiltradasPorReceta = FiltroPorRecetas(filtros.Receta);

                CombinarFiltros(comidasFiltradas, comidasFiltradasPorReceta);
            }
            return comidasFiltradas;
        }

        private List<Comida> CombinarFiltros(List<Comida> comidasFiltradoPrevio, List<Comida> comidasFiltradoNuevo)
        {
            if (comidasFiltradoPrevio.Count > 0)
            {
                comidasFiltradoPrevio = comidasFiltradoPrevio.Intersect(comidasFiltradoNuevo).ToList();
            } else
            {
                comidasFiltradoPrevio = comidasFiltradoNuevo;
            }
            return comidasFiltradoPrevio;
        }

        public List<Comida> FiltroSaludable(bool saludable)
        {
            return HistorialComidas.Where(x => x.Receta.EsSaludable == saludable).ToList();
        }

        public List<Comida> FiltroMomentoComida(MomentosComida momento)
        {
            return HistorialComidas.Where(x => x.Receta.MomentoComida == momento).ToList();
        }

        public List<Comida> FiltroFecha(DateTime FechaMenor, DateTime FechaMayor)
        {
            return HistorialComidas.Where(x => x.Fecha >= FechaMenor && x.Fecha <= FechaMayor).ToList();
        }

        public List<Comida> FiltroPorRecetas(Receta receta)
        {
            return HistorialComidas.Where(x => x.Receta.Codigo == receta.Codigo).ToList();
        }

        private string SerializarLista(List<Comida> listaASerializar)
        {
            return JsonConvert.SerializeObject(listaASerializar);
        }

        public int GetNuevoCodigo()
        {
            if (HistorialComidas.Count == 0)
            {
                return codigoInicial;
            } else
            {
                return GetCodigoSiguiente();
            }
        }

        private int GetCodigoSiguiente()
        {
            int codigoMaximo = HistorialComidas.Max(x => x.Codigo);
            return codigoMaximo + 1;
        }

        public List<Comida> GetHistorialComidas()
        {
            return HistorialComidas;
        }

        public void BuscarComidasEnArchivos()
        {
            HistorialComidas = LeerHistorialComidas();
        }
    }
}
