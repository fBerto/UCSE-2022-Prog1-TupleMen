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
    public partial class MenuCompras : Form, IActualizarGrillaCompras
    {
        public MenuCompras()
        {
            InitializeComponent();
        }

        private void MenuCompras_Load(object sender, EventArgs e)
        {
            grillaCompras.AutoGenerateColumns = false;

            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            ActualizarGrillaCompras(administradorIngredientes.GetIngredientesAComprar());

            AdministradorCompras administradorCompras = new AdministradorCompras();
            lblCostoTotalCompra.Text = administradorCompras.CalcularTotalCompra().ToString();
        }

        public void ActualizarGrillaCompras(List<Ingrediente> dataSource)
        {
            grillaCompras.DataSource = null;
            grillaCompras.DataSource = dataSource;
        }

        private void filtrarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiltrosCompras formFiltrosCompras = new FormFiltrosCompras();
            formFiltrosCompras.ShowDialog(this);
        }
    }
}
