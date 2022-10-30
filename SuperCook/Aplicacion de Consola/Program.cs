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

            Bebida bebida1 = new Bebida(administradorIngredientes.GetNuevoCodigo(), "Coca", TiposIngredientes.Bebida, 5, 200, 1, TiposBebidas.AltaEnAzucar);
            Bebida bebida2 = new Bebida(administradorIngredientes.GetNuevoCodigo(), "Agua", TiposIngredientes.Bebida, 3, 150, 1, TiposBebidas.Normal);
            Solido solido1 = new Solido(administradorIngredientes.GetNuevoCodigo(), "Pechuga", TiposIngredientes.Carne, 3, 700, 2);
            Solido solido2 = new Solido(administradorIngredientes.GetNuevoCodigo(), "Tomate", TiposIngredientes.Fruta, 2, 300, 1);
            Bebida bebida3 = new Bebida(administradorIngredientes.GetNuevoCodigo(), "Vodka", TiposIngredientes.Bebida, 6, 2000, 1, TiposBebidas.Alcoholica); // para compras 
            Solido solido3 = new Solido(administradorIngredientes.GetNuevoCodigo(), "Yogurth", TiposIngredientes.Lacteo, 8, 350, 2);

            //List<int> listaIngredientesParaReceta = new List<int> { bebida1.Codigo, solido2.Codigo, solido3.Codigo };
            //List<int> listaIngredientesParaReceta2 = new List<int> { bebida3.Codigo, solido2.Codigo, bebida1.Codigo };
            //List<int> listaIngredientesParaReceta3 = new List<int> { bebida2.Codigo, solido1.Codigo, bebida3.Codigo };

            List<Solido> listaSolidosReceta1 = new List<Solido> { solido2, solido3 };
            List<Bebida> listaBebidasReceta1 = new List<Bebida> { bebida1, bebida2 };

            List<Solido> listaSolidosReceta2 = new List<Solido> { solido1, solido2 };
            List<Bebida> listaBebidasReceta2 = new List<Bebida> { bebida3, bebida2 };
            
            List<Solido> listaSolidosReceta3 = new List<Solido> { solido1, solido3 };
            List<Bebida> listaBebidasReceta3 = new List<Bebida> { bebida1, bebida3 };

            //List<Ingrediente> listaIngredientesParaReceta = new List<Ingrediente> { bebida1, solido2, bebida3 };
            //List<Ingrediente> listaIngredientesParaReceta2 = new List<Ingrediente> { bebida3, solido2, bebida1 };
            //List<Ingrediente> listaIngredientesParaReceta3 = new List<Ingrediente> { bebida2, solido1, bebida3 };

            Receta receta1 = new Receta(administradorRecetas.GetNuevoCodigo(), MomentosComida.Merienda, "Panchos", false, listaBebidasReceta1, listaSolidosReceta1);
            Receta receta2 = new Receta(administradorRecetas.GetNuevoCodigo(), MomentosComida.Desayuno, "PANKEKES PROTEICOS", true, listaBebidasReceta2, listaSolidosReceta2);
            Receta receta3 = new Receta(administradorRecetas.GetNuevoCodigo(), MomentosComida.Cena, "Pollo con pan", true, listaBebidasReceta3, listaSolidosReceta3);

            Comida comida1 = new Comida(administradorComidas.GetNuevoCodigo(), receta1, DateTime.Today);
            Comida comida2 = new Comida(administradorComidas.GetNuevoCodigo(), receta2, DateTime.Today);
            Comida comida3 = new Comida(administradorComidas.GetNuevoCodigo(), receta3, DateTime.Today);

            administradorIngredientes.CargarIngrediente(bebida1);
            administradorIngredientes.CargarIngrediente(bebida2);
            administradorIngredientes.CargarIngrediente(bebida3);
            administradorIngredientes.CargarIngrediente(solido1);
            administradorIngredientes.CargarIngrediente(solido2);
            administradorIngredientes.CargarIngrediente(solido3);

            administradorRecetas.CargarReceta(receta1);
            administradorRecetas.CargarReceta(receta2);
            administradorRecetas.CargarReceta(receta3);

            administradorComidas.RegistrarComida(comida1);
            administradorComidas.RegistrarComida(comida2);
            administradorComidas.RegistrarComida(comida3);

            List<Ingrediente> IngredientesEnDespensa = administradorIngredientes.GetIngredientesEnDespensa();
            List<Comida> HistorialComidas = administradorComidas.GetHistorialComidas(); //Lo programamos para que si el ingrediente no esta en despensa no lo cargue 
            List<Receta> LibroRecetas = administradorRecetas.GetLibroRecetas(); //no carga los elemenots q no esten en despensa 

            AdministradorCompras administradorCompras = new AdministradorCompras();

            Console.ReadKey();
        }
    }
}
