using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class AdministradorCompras
    {
        private static List<Ingrediente> IngredientesAComprar = new List<Ingrediente>();

        public void BuscarIngredientesAComprar()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            IngredientesAComprar = administradorIngredientes.GetIngredientesAComprar();
        }

        public List<Ingrediente> FiltrarIngredientesAComprar(SeleccionFiltrosCompras filtros)
        {
            List<Ingrediente> comprasFiltradas = IngredientesAComprar;
            
            if (filtros.PorTipoIngrediente)
            {
                if (filtros.PorTipoBebida)
                {
                    comprasFiltradas = FiltrarPorTipoDeBebida(filtros.TipoBebida);
                } else
                {
                    comprasFiltradas = FiltrarPorTipoDeIngrediente(filtros.TipoIngrediente);
                }
            }

            if (filtros.PorEscasez)
            {
                List<Ingrediente> comprasFiltradasPorEscasez = FiltrarPorEscasez(filtros.GradoDeEscasez);
                comprasFiltradas = CombinarFiltros(comprasFiltradas, comprasFiltradasPorEscasez);
            }

            if (filtros.PorCosto)
            {
                List<Ingrediente> comprasFiltradasPorCosto = filtros.EsCostoMaximo ?
                    FiltrarPorCostoMaximo(filtros.Costo) : FiltrarPorCostoMinimo(filtros.Costo);

                comprasFiltradas = CombinarFiltros(comprasFiltradas, comprasFiltradasPorCosto);
            }

            if (filtros.PorUnidadDeMedida)
            {
                List<Ingrediente> comprasFiltradasPorUnidadMedida = FiltrarPorUnidadDeMedida(filtros.UnidadDeMedida);
                comprasFiltradas = CombinarFiltros(comprasFiltradas, comprasFiltradasPorUnidadMedida);
            }
            return comprasFiltradas;
        }

        private List<Ingrediente> CombinarFiltros(List<Ingrediente> comprasFiltradoPrevio, List<Ingrediente> comprasFiltradoNuevo)
        {
            if (comprasFiltradoPrevio.Count > 0)
            {
                comprasFiltradoPrevio = comprasFiltradoPrevio.Intersect(comprasFiltradoNuevo).ToList();
            } else
            {
                comprasFiltradoPrevio = comprasFiltradoNuevo;
            }
            return comprasFiltradoPrevio;
        }

        private List<Ingrediente> FiltrarPorTipoDeIngrediente(TiposIngredientes tipoDeIngrediente)
        {
            return IngredientesAComprar.Where(x => x.TipoIngrediente == tipoDeIngrediente).ToList();
        }

        private List<Ingrediente> FiltrarPorTipoDeBebida(TiposBebidas tipoDeBebida)
        {
            List<Bebida> BebidasAComprar = IngredientesAComprar.Where(x => x is Bebida).Select(x => x as Bebida).ToList();
            return BebidasAComprar.Where(x => x.TipoBebida == tipoDeBebida).Select(x => x as Ingrediente).ToList();
        }

        private List<Ingrediente> FiltrarPorCostoMinimo(decimal costoMinimo)
        {
            return IngredientesAComprar.Where(x => x.GetCosto() >= costoMinimo).ToList();
        }

        private List<Ingrediente> FiltrarPorCostoMaximo(decimal costoMaximo)
        {
            return IngredientesAComprar.Where(x => x.GetCosto() <= costoMaximo).ToList();
        }

        private List<Ingrediente> FiltrarPorUnidadDeMedida(UnidadesDeMedida unidad)
        {
            return IngredientesAComprar.Where(x => x.GetUnidadMedida() == unidad).ToList();
        }

        private List<Ingrediente> FiltrarPorEscasez(GradosDeEscasez escasez)
        {
            return IngredientesAComprar.Where(x => x.GetGradoDeEscasez() == escasez).ToList();
        }

        public decimal CalcularTotalCompra(List<Ingrediente> ingredientesFiltrados)
        {
            decimal totalCompra = 0;
            foreach (Ingrediente ingrediente in ingredientesFiltrados)
            {
                totalCompra += ingrediente.GetCosto();
            }
            return totalCompra;
        }
    }
}
