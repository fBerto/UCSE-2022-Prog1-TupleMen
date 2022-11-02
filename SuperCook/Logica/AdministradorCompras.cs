using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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

        public List<Ingrediente> FiltrarPorTipoDeIngrediente(TiposIngredientes tipoDeIngrediente)
        {
            return IngredientesAComprar.Where(x => x.TipoIngrediente == tipoDeIngrediente).ToList();
        }

        public List<Ingrediente> FiltrarPorTipoDeBebida(TiposBebidas tipoDeBebida)
        {
            List<Bebida> BebidasAComprar = IngredientesAComprar.Where(x => x is Bebida).Select(x => x as Bebida).ToList();
            return BebidasAComprar.Where(x => x.TipoBebida == tipoDeBebida).Select(x => x as Ingrediente).ToList();
        }

        public List<Ingrediente> FiltrarPorCostoMinimo(decimal costoMinimo)
        {
            return IngredientesAComprar.Where(x => x.GetCosto() >= costoMinimo).ToList();
        }

        public List<Ingrediente> FiltrarPorCostoMaximo(decimal costoMaximo)
        {
            return IngredientesAComprar.Where(x => x.GetCosto() <= costoMaximo).ToList();
        }

        public List<Ingrediente> FiltrarPorUnidadDeMedida(UnidadesDeMedida unidad)
        {
            return IngredientesAComprar.Where(x => x.GetUnidadMedida() == unidad).ToList();
        }

        public List<Ingrediente> FiltrarPorEscasez(GradosDeEscasez escasez)
        {
            return IngredientesAComprar.Where(x => x.GetGradoDeEscasez() == escasez).ToList();
        }

        //public List<Ingrediente> FiltrarIngredientesAComprar(EleccionFiltro)
        //{
        //    List<Ingrediente> ingredientesFiltrados = new List<Ingrediente>();
        //}

        public decimal CalcularTotalCompra()
        {
            decimal totalCompra = 0;
            foreach (Ingrediente ingrediente in IngredientesAComprar)
            {
                totalCompra += ingrediente.GetCosto();
            }
            return totalCompra;
        }
    }
}
