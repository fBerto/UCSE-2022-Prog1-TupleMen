﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class AdministradorCompras : Archivos {
        List<Ingrediente> IngredientesAComprar = new List<Ingrediente>();

        public void ActualizarIngredientesAComprar(Ingrediente nuevoIngrediente) {
            IngredientesAComprar.Add(nuevoIngrediente);
            GuardarIngredientesAComprar();
        }

        public void GuardarIngredientesAComprar() {
            List<Bebida> Bebidas = ExtraerBebidasDe(IngredientesAComprar);
            List<Solido> Solidos = ExtraerSolidosDe(IngredientesAComprar);

            GuardarLista(SerializarLista(Bebidas), "serialBebidasAComprar");
            GuardarLista(SerializarLista(Solidos), "serialSolidosAComprar");
        }

        public List<Ingrediente> FiltrarPorTipoDeIngrediente(TiposIngredientes tipoDeIngrediente) {
            return IngredientesAComprar.Where(x => x.TipoIngrediente == tipoDeIngrediente).ToList();
        }

        public List<Ingrediente> FiltrarPorTipoDeBebida(TiposBebidas tipoDeBebida) {
            return ExtraerBebidasDe(IngredientesAComprar).Where(x => x.TipoBebida == tipoDeBebida).Select(x => x as Ingrediente).ToList();
        }

        public List<Ingrediente> FiltrarPorPrecioMinimoOMaximo(decimal precio, bool esMinimo) {
            if (esMinimo) {
                return IngredientesAComprar.Where(x => x.PrecioPorUnidad >= precio).ToList();
            } else {
                return IngredientesAComprar.Where(x => x.PrecioPorUnidad <= precio).ToList();
            }
        }

        public List<Ingrediente> FiltrarPorUnidadDeMedida(UnidadesDeMedida unidad) {
            return IngredientesAComprar.Where(x => x.GetUnidadMedida() == unidad).ToList();
        }

        public List<Ingrediente> FiltrarPorEscasez(GradosDeEscasez escasez) {
            return IngredientesAComprar.Where(x => x.GetGradoDeEscasez() == escasez).ToList();
        }

        private decimal CalcularTotalCompra() {
            decimal totalCompra = 0;
            foreach (Ingrediente ingrediente in IngredientesAComprar) {
                totalCompra += ingrediente.CalcularCostoIngrediente();
            }
            return totalCompra;
        }          
    }
}
