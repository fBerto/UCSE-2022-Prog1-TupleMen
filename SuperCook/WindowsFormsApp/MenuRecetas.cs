using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;


namespace WindowsFormsApp
{
    public partial class MenuRecetas : Form, IActualizarGrillaIngredientes
    {
        public MenuRecetas()
        {
            InitializeComponent();          
            
        }
        private void MenuRecetas_Load(object sender, EventArgs e)
        {
            grillaRecetas.AutoGenerateColumns = false;
            ActualizarGrillaRecetas();
        }

        private void ActualizarGrillaRecetas()
        {
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();

            grillaRecetas.DataSource = null;
            grillaRecetas.DataSource = administradorRecetas.GetLibroRecetas();

        }

        public void CargarGrillaIngredientes()
        {
            ActualizarGrillaRecetas();
        }
        private void cargarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargaRecetas cargaRecetas = new FormCargaRecetas();
            cargaRecetas.ShowDialog(this);
        }

        private void btnNuevaReceta_Click(object sender, EventArgs e)
        {
            FormCargaRecetas formCargaRecetas = new FormCargaRecetas();
            formCargaRecetas.ShowDialog(this);
        }

        
    }
}
