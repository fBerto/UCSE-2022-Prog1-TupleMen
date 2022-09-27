using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    internal class Despensa : Archivos{
        List<Ingrediente> Ingredientes = new List<Ingrediente>();

        public void CargarIngrediente(int codigo, string nombre, TiposIngredientes tipoIngrediente, int magnitud, decimal precio, int minimo) { }

        ////Sobrecarga para carga de lista de ingredientes de la receta, que no requieren Precio ni PrecioMinimo
        //public void CargarIngrediente(int codigo, string nombre, int tipoIngrediente, int PesoVolumenCantidad, decimal) {
        //}

        public void EliminarIngrediente(int codigo) { }

        //
        public void ModificarIngrediente(int codigo, string nombreNuevo) { }
        public void ModificarIngrediente(int codigo, TiposIngredientes nuevoTipoIngrediente) { }
        public void ModificarIngrediente(int codigo, decimal precioNuevo) { }
        public void ModificarIngrediente(int codigo, int nuevaMagnitud) { }
        public void ModificarIngrediente(int codigo, uint nuevaCantidadMinima) { }
    }
}
