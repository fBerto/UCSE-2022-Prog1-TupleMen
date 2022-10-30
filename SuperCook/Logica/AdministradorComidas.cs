﻿using Newtonsoft.Json;
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

        //TODO: Devolver algun error , no lo podemos hacer con un try catch?
        public void RegistrarComida(Comida nuevaComida)
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

            List<Bebida> BebidasComida = nuevaComida.Receta.GetBebidasReceta();
            List<Solido> SolidosComida = nuevaComida.Receta.GetSolidosReceta();

            List<Ingrediente> IngredientesComida = UnificarBebidasYSolidos(BebidasComida, SolidosComida);

            if (administradorIngredientes.ConsultarStockIngredientesDeReceta(IngredientesComida))
            {
                HistorialComidas.Add(nuevaComida);
                GuardarLista(SerializarLista(HistorialComidas), nombreArchivoHistorialComidas);

                administradorIngredientes.ActualizarStockIngredientes(IngredientesComida);
            }
        }

        private List<Comida> FiltroSaludable(bool saludable)
        {
            return HistorialComidas.Where(x => x.Receta.EsSaludable == saludable).ToList();
        }

        private List<Comida> FiltroMomentoComida(MomentosComida momento)
        {
            return HistorialComidas.Where(x => x.Receta.MomentoComida == momento).ToList();
        }

        private List<Comida> FiltroFecha(DateTime FechaMenor, DateTime FechaMayor)
        {
            return HistorialComidas.Where(x => x.Fecha >= FechaMenor && x.Fecha <= FechaMayor).ToList();
        }

        private List<Comida> FiltroPorRecetas(Receta receta)
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
