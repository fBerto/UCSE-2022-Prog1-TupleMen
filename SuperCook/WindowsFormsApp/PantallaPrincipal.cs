using Logica;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class PantallaPrincipal : Form 
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void BotonIngredientes_Click(object sender, EventArgs e)
        {
            MenuIngredientes menuIngredientes = new MenuIngredientes();
            menuIngredientes.ShowDialog(this);
        }

        private void BotonRecetas_Click(object sender, EventArgs e)
        {
            MenuRecetas menuRecetas = new MenuRecetas();
            menuRecetas.ShowDialog(this);
        }

        private void BotonComidas_Click(object sender, EventArgs e)
        {
            MenuComidas menuComidas = new MenuComidas();
            menuComidas.ShowDialog(this);
        }

        private void BotonCompras_Click(object sender, EventArgs e)
        {
            MenuCompras menuCompras = new MenuCompras();
            menuCompras.ShowDialog(this);
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            LeerArchivosListasEnDisco();
        }

        private void LeerArchivosListasEnDisco()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();
            AdministradorComidas administradorComidas = new AdministradorComidas();

            administradorIngredientes.BuscarIngredientesEnArchivos();
            administradorRecetas.BuscarRecetasEnArchivos();
            administradorComidas.BuscarComidasEnArchivos();
        }
    }
}
