using Logica;
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
    public partial class MenuIngredientes : Form, IActualizarGrillaIngredientes
    {
        public MenuIngredientes()
        {
            InitializeComponent();
        }

        private void MenuIngredientes_Load(object sender, EventArgs e)
        {
            grillaIngredientes.AutoGenerateColumns = false;
            ActualizarGrillaIngredientes();
        }

        private void ActualizarGrillaIngredientes()
        {
            AdministradorIngredientes adminIngredientes = new AdministradorIngredientes();

            grillaIngredientes.DataSource = null;
            grillaIngredientes.DataSource = adminIngredientes.GetIngredientesEnDespensa();
        }

        public void CargarGrillaIngredientes()
        {
            ActualizarGrillaIngredientes();
        }

        private void cargarIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargaIngredientes formCargaIngredientes = new FormCargaIngredientes();
            formCargaIngredientes.ShowDialog(this);
        }

        private void btnNuevoIngrediente_Click(object sender, EventArgs e)
        {
            FormCargaIngredientes formCargaIngredientes = new FormCargaIngredientes();
            formCargaIngredientes.ShowDialog(this);
        }
    }
}
