using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Aplicacion_de_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdministradorComidas administradorComidas = new AdministradorComidas();
            AdministradorCompras administradorCompras = new AdministradorCompras();
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();

            Bebida bebida1 = new Bebida();
            Bebida bebida2 = new Bebida();
            Solido solido1 = new Solido();
            Solido solido2 = new Solido();

            Bebida bebida3 = new Bebida(); // para compras 
            Solido solido3 = new Solido();
            
            Comida comida1 = new Comida();
            Comida comida2 = new Comida();
            Comida comida3 = new Comida();  
            
            Receta receta1 = new Receta();
            Receta receta2 = new Receta();
            Receta receta3 = new Receta();


            administradorIngredientes.CargarIngrediente(bebida1);
            administradorIngredientes.CargarIngrediente(bebida2);
            administradorIngredientes.CargarIngrediente(solido1);
            administradorIngredientes.CargarIngrediente(solido2);

            administradorCompras.ActualizarIngredientesAComprar(bebida3);
            administradorCompras.ActualizarIngredientesAComprar(solido3);

            administradorComidas.RegistrarComida(comida1);
            administradorComidas.RegistrarComida(comida2);
            administradorComidas.RegistrarComida(comida3);

            administradorRecetas.CargarReceta(receta1);
            administradorRecetas.CargarReceta(receta2);
            administradorRecetas.CargarReceta(receta3);

        }
    }
}
