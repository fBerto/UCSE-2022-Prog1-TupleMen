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
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();

            Bebida bebida1 = new Bebida(1, "Coca", TiposIngredientes.Bebida, 5, 200, 1, TiposBebidas.AltaEnAzucar);
            Bebida bebida2 = new Bebida(2, "Agua", TiposIngredientes.Bebida, 3, 150, 1, TiposBebidas.Normal);
            Solido solido1 = new Solido(3, "Pechuga", TiposIngredientes.Carne, 3, 700, 2);
            Solido solido2 = new Solido(4, "Tomate", TiposIngredientes.Fruta, 2, 300, 1);

            Bebida bebida3 = new Bebida(5, "Vodka", TiposIngredientes.Bebida, 6, 2000, 1, TiposBebidas.Alcoholica); // para compras 
            Solido solido3 = new Solido(6, "Yogurth", TiposIngredientes.Lacteo, 8, 350, 2);

            List<int> listaIngredientesParaReceta = new List<int> { bebida1.Codigo, solido2.Codigo, solido3.Codigo };
            List<int> listaIngredientesParaReceta2 = new List<int> { bebida3.Codigo, solido2.Codigo, bebida1.Codigo };
            List<int> listaIngredientesParaReceta3 = new List<int> { bebida2.Codigo, solido1.Codigo, bebida3.Codigo };

            //List<Ingrediente> listaIngredientesParaReceta = new List<Ingrediente> { bebida1, solido2, bebida3 };
            //List<Ingrediente> listaIngredientesParaReceta2 = new List<Ingrediente> { bebida3, solido2, bebida1 };
            //List<Ingrediente> listaIngredientesParaReceta3 = new List<Ingrediente> { bebida2, solido1, bebida3 };

            Receta receta1 = new Receta(123, MomentosComida.Merienda, "Panchos", false , listaIngredientesParaReceta);
            Receta receta2 = new Receta(1234, MomentosComida.Desayuno, "PANKEKES PROTEICOS", true, listaIngredientesParaReceta2);
            Receta receta3 = new Receta(12345, MomentosComida.Cena, "Pollo con pan", true, listaIngredientesParaReceta3);

            Comida comida1 = new Comida(receta1, DateTime.Today);
            Comida comida2 = new Comida(receta2, DateTime.Today);
            Comida comida3 = new Comida(receta3, DateTime.Today);

            List<Ingrediente> IngredientesEnDespensa = administradorIngredientes.GetIngredientesEnDespensa();
            List<Comida> HistorialComidas = administradorComidas.GetHistorialComidas(); //Lo programamos para que si el ingrediente no esta en despensa no lo cargue 
            List<Receta> LibroRecetas = administradorRecetas.GetLibroRecetas(); //no carga los elemenots q no esten en despensa 

            administradorIngredientes.CargarIngrediente(bebida1);
            administradorIngredientes.CargarIngrediente(bebida2);
            administradorIngredientes.CargarIngrediente(solido1);
            administradorIngredientes.CargarIngrediente(solido2);

            administradorRecetas.CargarReceta(receta1);
            administradorRecetas.CargarReceta(receta2);
            administradorRecetas.CargarReceta(receta3);

            administradorComidas.RegistrarComida(comida1);
            administradorComidas.RegistrarComida(comida2);
            administradorComidas.RegistrarComida(comida3);

            AdministradorCompras administradorCompras = new AdministradorCompras();

            Console.ReadKey();
        }
    }
}
