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
         * Alternativa de ingredientes clase unica con atributos cargados y otros no
         * Como diferenciar metodos de sobrecarga (caso unidadNueva y unidadMinimaNueva)?
         * Los filtros son de comida.
         */

        List<IngredienteCompleto> Despensa = new List<IngredienteCompleto>();
        List<Receta> Recetas = new List<Receta>();
        List<Comida> Comidas = new List<Comida>();
        List<IngredienteCompleto> Super = new List<IngredienteCompleto>();

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

        //
        public void ModificarIngrediente(int codigo, string nombreNuevo) { }
        public void ModificarIngrediente(int codigo, TiposIngredientes nuevoTipoIngrediente) { }
        public void ModificarIngrediente(int codigo, decimal precioNuevo) { }
        public void ModificarIngrediente(int codigo, int nuevaUnidadMedida) { }
        public void ModificarIngrediente(int codigo, uint nuevaUnidadMinimo) { }

        //----------------------------------------------------------------------------------------------------------------
        //RECETA

        public void CargarReceta(string nombreReceta, bool esSaludable, MomentosComida momentoComida) { }

        public void EliminarReceta(int codigoReceta) { }

        public void ModificarReceta(int codigoReceta, MomentosComida momentoComida) { }
        public void ModificarReceta(int codigoReceta, string nombreReceta) { }
        public void ModificarReceta(int codigoReceta, bool esSaludable) { }

        //Devuelve true si lo encuentra en la lista de la receta y false si no
        //Si encuentra el ingrediente, modifica su cantidad con la que le hayamos pasado como parametro
        public bool ModificarReceta(int codigoReceta, int codigoIngrediente, int cantidadIngrediente) { return false; }

        //----------------------------------------------------------------------------------------------------------------
        //COMIDA

        public void RegistrarComida(int codigoReceta, DateTime FechaComida) { }
        /*Filtros:
         * Saludable o no
         * Momento de la comida
         * Fecha Comida
         * -
         */

        //Dentro de registrar comida tendria que buscar la receta en la lista, y comprobar que los ingredientes
        //de esta se encuentren en la despensa, sino no debe permitir registrar la comida.

        //----------------------------------------------------------------------------------------------------------------
        //LISTA SUPER

        private void ActualizarListaSuper(int codigoIngrediente) {
            //Cargar ingrediente del que me quede sin a la lista del super
        }

        /* Filtros:
         * Por tipo de ingrediente
         * -
         * -
         * -
         */

        private decimal CalcularTotalCompra () { return 0; }
    }
}
