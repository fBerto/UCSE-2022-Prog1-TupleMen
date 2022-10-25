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
    public partial class MenuIngredientes : Form
    {
        public MenuIngredientes()
        {
            InitializeComponent();
        }

        private void cargarIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargaIngredientes formCargaIngredientes = new FormCargaIngredientes();
            formCargaIngredientes.ShowDialog();
        }
    }
}
