using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal {
        /*CONSULTAS:
         * Cargar los ingredientes como clase diferente o con parametros null?
         * Para eliminar un ingrediente, podemos usar uno tanto para los de la lista de cada receta como para la lista general?
         * Los filtros son de receta o de comida???
         */

        List<Ingrediente> Despensa = new List<Ingrediente>();
        List<Receta> Recetas = new List<Receta>();
        List<Comida> Comidas = new List<Comida>();
        List<Ingrediente> Super = new List<Ingrediente>();

        //---------------------------------------------------------------------------------------------------------------
        //DESPENSA

        public void CargarIngrediente(int codigo, string nombre, int tipoIngrediente, int PesoVolumenCantidad, decimal Precio, int Minimo) {
            //Usamos un solo metodo de carga para las 3 subclases,
            //y dentro de este preguntamos que tipo de ingrediente es,
            //en base a eso sabemos a que subclase asignarlo
        }

        ////Sobrecarga para carga de lista de ingredientes de la receta, que no requieren Precio ni PrecioMinimo
        //public void CargarIngrediente(int codigo, string nombre, int tipoIngrediente, int PesoVolumenCantidad, decimal) {
        //}

        public void EliminarIngrediente(int codigo) { }

        public void ModificarIngrediente(int codigo, string nombreNuevo) { }
        public void ModificarIngrediente(int codigo, TiposIngredientes nuevoTipoIngrediente) { }
        public void ModificarIngrediente(int codigo, decimal precioNuevo) { }

        //public void ModificarIngrediente(int PesoVolumenCantidad) { }

        //----------------------------------------------------------------------------------------------------------------
        //RECETA

        public void CargarReceta(string nombreReceta, bool esSaludable, MomentosComida momentoComida) { }

        public void EliminarReceta(int codigoReceta) { }

        public void ModificarReceta() { }

        //----------------------------------------------------------------------------------------------------------------
        //COMIDA

        public void RegistrarComida(int codigoReceta, DateTime FechaComida) { }
        /*Filtros:
         * Saludable o no
         * Momento de la comida
         * Fecha Comida
         */

        //----------------------------------------------------------------------------------------------------------------
        //LISTA SUPER

        private void ActualizarListaSuper(int codigoIngrediente) {
            //Cargar ingrediente del que me quede sin a la lista del super
        }

        /* Filtros:
         * Por tipo de ingrediente
         */

        private decimal CalcularTotalCompra () { return 0; }
    }
}
