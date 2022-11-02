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
    public partial class FormCargaComidas : Form
    {
        public FormCargaComidas()
        {
            InitializeComponent();
        }

        private void ActualizarGrillaSeleccionRecetas()
        {
            AdministradorRecetas adminRecetas = new AdministradorRecetas();

            grillaSeleccionRecetas.DataSource = null;
            grillaSeleccionRecetas.DataSource = adminRecetas.GetLibroRecetas();
        }

        private void FormCargaComidas_Load(object sender, EventArgs e)
        {
            grillaSeleccionRecetas.AutoGenerateColumns = false;
            ActualizarGrillaSeleccionRecetas();

            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.Value = DateTime.Today;
        }

        private void botonConfirmarCargaComida_Click(object sender, EventArgs e)
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            AdministradorComidas administradorComidas = new AdministradorComidas();

            //Busco la receta que corresponde a la fila seleccionada
            Receta recetaSeleccionada = grillaSeleccionRecetas.SelectedRows[0].DataBoundItem as Receta;

            List<Ingrediente> ingredientesReceta = recetaSeleccionada.GetIngredientesReceta();

            //TODO: De esto se debe encargar la logica
            if (administradorIngredientes.ConsultarStockIngredientesDeReceta(ingredientesReceta))
            {
                int codigo = administradorComidas.GetNuevoCodigo();
                DateTime fecha = dateTimePicker.Value;

                Comida nuevaComida = new Comida(codigo, recetaSeleccionada, fecha);

                administradorIngredientes.ActualizarStockIngredientes(ingredientesReceta);

                IActualizarGrillaComidas padre = this.Owner as IActualizarGrillaComidas;
                if (padre != null)
                {
                    padre.ActualizarGrillaComidas(administradorComidas.GetHistorialComidas());
                }

                this.Close();
            } else
            {
                MessageBox.Show("No hay suficientes ingredientes en despensa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
