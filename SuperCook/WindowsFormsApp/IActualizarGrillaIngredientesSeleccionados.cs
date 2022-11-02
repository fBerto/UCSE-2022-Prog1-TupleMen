using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace WindowsFormsApp
{
    public interface IActualizarGrillaIngredientesSeleccionados
    {
        void ActualizarGrillaIngredientesSeleccionados(List<Ingrediente> ingredientesSeleccionados);
        
    }
}
