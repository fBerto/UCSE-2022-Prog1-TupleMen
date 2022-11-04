using Logica;
using System;
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

        private void AbrirFormularioParaCarga()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            FormCargaIngredientes formCargaIngredientes = new FormCargaIngredientes(0);
            formCargaIngredientes.ShowDialog(this);
        }

        private void cargarIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioParaCarga();
        }

        private void btnNuevoIngrediente_Click(object sender, EventArgs e)
        {
            AbrirFormularioParaCarga();
        }

        private void grillaIngredientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UtilidadesGrilla utilidad = new UtilidadesGrilla();
            utilidad.CargarCamposAcciones(grillaIngredientes);
        }

        private void grillaIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UtilidadesGrilla utilidad = new UtilidadesGrilla();

            int indiceEditar = utilidad.ObtenerIndice(grillaIngredientes, "Editar");
            int indiceEliminar = utilidad.ObtenerIndice(grillaIngredientes, "Eliminar");

            if (e.RowIndex >= 0)
            {
                Ingrediente ingredienteSeleccionado = grillaIngredientes.Rows[e.RowIndex].DataBoundItem as Ingrediente;
                int codigoIngrediente = ingredienteSeleccionado.Codigo;

                if (indiceEditar == e.ColumnIndex)
                {
                    FormCargaIngredientes formCargaIngredientes = new FormCargaIngredientes(codigoIngrediente);
                    formCargaIngredientes.ShowDialog(this);
                }

                if (indiceEliminar == e.ColumnIndex)
                {
                    //Hizo clic en eliminar
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el ingrediente?", "Eliminar ingrediente", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                        administradorIngredientes.EliminarIngrediente(codigoIngrediente);

                        ActualizarGrillaIngredientes();
                    }
                }
            }
        }
    }
}
