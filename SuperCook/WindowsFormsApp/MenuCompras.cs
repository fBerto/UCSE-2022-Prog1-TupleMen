using Logica;
using System;
using System.Collections.Generic;
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
            administradorCompras.BuscarIngredientesAComprar();
        }

        public void ActualizarGrillaCompras(List<Ingrediente> dataSource)
        {
            AdministradorCompras administradorCompras = new AdministradorCompras();

            grillaCompras.DataSource = null;
            grillaCompras.DataSource = dataSource;

            lblCostoTotalCompra.Text = administradorCompras.CalcularTotalCompra(dataSource).ToString();
        }

        private void filtrarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiltrosCompras formFiltrosCompras = new FormFiltrosCompras();
            formFiltrosCompras.ShowDialog(this);
        }

        private void buttonFiltrarCompras_Click(object sender, EventArgs e)
        {
            FormFiltrosCompras formFiltrosCompras = new FormFiltrosCompras();
            formFiltrosCompras.ShowDialog(this);
        }

        private void eliminarFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            ActualizarGrillaCompras(administradorIngredientes.GetIngredientesAComprar());
        }
    }
}
