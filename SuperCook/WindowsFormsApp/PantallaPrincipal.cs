using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
