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
        //TODO: Que por defecto te aparezca la fecha de hoy en el textbox
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

            //No permito ingresar fechas futuras
            dateTimePicker.MaxDate = DateTime.Today;
        }

        private void botonConfirmarCargaComida_Click(object sender, EventArgs e)
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            AdministradorComidas administradorComidas = new AdministradorComidas();

            //Busco la receta que corresponde a la fila seleccionada
            Receta recetaSeleccionada = grillaSeleccionRecetas.SelectedRows[0].DataBoundItem as Receta;

            List<Ingrediente> ingredientesReceta = recetaSeleccionada.GetIngredientesReceta();

            if (administradorIngredientes.ConsultarStockIngredientesDeReceta(ingredientesReceta))
            {
                int codigo = administradorComidas.GetNuevoCodigo();
                DateTime fecha = dateTimePicker.Value;

                Comida nuevaComida = new Comida(codigo, recetaSeleccionada, fecha);

                administradorIngredientes.ActualizarStockIngredientes(ingredientesReceta);

                IActualizarGrillaComidas padre = this.Owner as IActualizarGrillaComidas;
                if (padre != null)
                {
                    padre.ActualizarGrillaComidas();
                }

                this.Close();
            } else
            {
                MessageBox.Show("No hay suficientes ingredientes en despensa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
