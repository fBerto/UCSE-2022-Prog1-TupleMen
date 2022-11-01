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
        //TODO: Agregar columnas editar y eliminar
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

        private void CargarCamposAcciones(DataGridView grilla)
        {
            int indiceColumnaEditar = ObtenerIndice(grilla, "Editar");
            int indiceColumnaEliminar = ObtenerIndice(grilla, "Eliminar");

            foreach (DataGridViewRow row in grilla.Rows) //en este caso recorremos filas 
            {
                //le asignamos valores a las celdas 
                row.Cells[indiceColumnaEliminar].Value = "Eliminar";
                row.Cells[indiceColumnaEditar].Value = "Editar";
            }
        }

        private int ObtenerIndice(DataGridView grilla, string nombreColumna) //para poder usarlo desde cualquier formulario 
        {
            foreach (DataGridViewColumn column in grilla.Columns)
            {
                if (column.Name == nombreColumna)
                {
                    return column.Index;
                }
            }

            throw new Exception("No hay una columna con nombre solicitado en la grilla");
        }

        private void grillaIngredientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CargarCamposAcciones(grillaIngredientes);
        }

        private void grillaIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = ObtenerIndice(grillaIngredientes, "Editar");
            int indiceEliminar = ObtenerIndice(grillaIngredientes, "Eliminar");

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
