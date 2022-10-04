using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal class AdministradorComidas : Archivos {
        List<Comida> HistorialComidas = new List<Comida>();

        public void RegistrarComida(int codigoReceta, DateTime FechaComida) { }
        /*Filtros:
         * Saludable o no
         * Momento de la comida
         * Fecha Comida
         * Veces que se preparo una comida
         */

        //Dentro de registrar comida tendria que buscar la receta en la lista, y comprobar que los ingredientes
        //de esta se encuentren en la despensa, sino no debe permitir registrar la comida.
    }
}
