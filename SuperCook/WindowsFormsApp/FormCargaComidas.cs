using Logica;
using System;
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

            MomentosComida momentoSeleccionado = (MomentosComida)comboBoxMomentoComida.SelectedItem;

            grillaSeleccionRecetas.DataSource = null;
            grillaSeleccionRecetas.DataSource = adminRecetas.GetRecetasDisponiblesPorMomentoComida(momentoSeleccionado);
        }

        private void FormCargaComidas_Load(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.Value = DateTime.Today;

            comboBoxMomentoComida.DataSource = Enum.GetValues(typeof(MomentosComida));
            comboBoxMomentoComida.DropDownStyle = ComboBoxStyle.DropDownList;

            grillaSeleccionRecetas.AutoGenerateColumns = false;
            ActualizarGrillaSeleccionRecetas();
        }

        private void botonConfirmarCargaComida_Click(object sender, EventArgs e)
        {
            AdministradorComidas administradorComidas = new AdministradorComidas();

            //Si la grilla no esta vacia cargo
            if (grillaSeleccionRecetas.RowCount > 0)
            {
                Receta recetaSeleccionada = grillaSeleccionRecetas.SelectedRows[0].DataBoundItem as Receta;

                int codigo = administradorComidas.GetNuevoCodigo();
                DateTime fecha = dateTimePicker.Value;

                Comida nuevaComida = new Comida(codigo, recetaSeleccionada, fecha);
                administradorComidas.CargarComida(nuevaComida);

                IActualizarGrillaComidas padre = this.Owner as IActualizarGrillaComidas;
                if (padre != null)
                {
                    padre.ActualizarGrillaComidas(administradorComidas.GetHistorialComidas());
                }

                this.Close();
            } else
            {
                MessageBox.Show("No hay recetas disponibles para el momento elegido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxMomentoComida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActualizarGrillaSeleccionRecetas();
        }
    }
}
