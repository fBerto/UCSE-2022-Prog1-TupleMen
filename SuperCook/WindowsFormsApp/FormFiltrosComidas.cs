using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormFiltrosComidas : Form
    {
        public FormFiltrosComidas()
        {
            InitializeComponent();
        }

        private void FormFiltrosComidas_Load(object sender, EventArgs e)
        {
            groupBoxFiltroSaludable.Visible = false;
            comboBoxFiltroMomentoComida.Visible = false;
            grillaSeleccionRecetas.Visible = false;
            ModificarVisibilidadFechas(false);

            dateTimeFechaFinal.MaxDate = DateTime.Today.Date;
            dateTimeFechaInicial.MaxDate = dateTimeFechaFinal.Value;

            comboBoxFiltroMomentoComida.DataSource = Enum.GetValues(typeof(MomentosComida));
            CargarGrillaRecetas();

            comboBoxFiltroMomentoComida.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGrillaRecetas()
        {
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();

            grillaSeleccionRecetas.AutoGenerateColumns = false;
            grillaSeleccionRecetas.DataSource = null;
            grillaSeleccionRecetas.DataSource = administradorRecetas.GetLibroRecetas();
        }

        private void checkBoxFiltroSaludable_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxFiltroSaludable.Visible = checkBoxFiltroSaludable.Checked;
        }

        private void checkBoxFiltroPorMomentoComida_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFiltroMomentoComida.Visible = checkBoxFiltroPorMomentoComida.Checked;
        }

        private void checkBoxFiltroPorReceta_CheckedChanged(object sender, EventArgs e)
        {
            grillaSeleccionRecetas.Visible = checkBoxFiltroPorReceta.Checked;
        }

        private void checkBoxFiltroPorFecha_CheckedChanged(object sender, EventArgs e)
        {
            ModificarVisibilidadFechas(checkBoxFiltroPorFecha.Checked);
        }

        private void ModificarVisibilidadFechas(bool visible)
        {
            lblFechaInicial.Visible = visible;
            lblFechaFinal.Visible = visible;
            dateTimeFechaInicial.Visible = visible;
            dateTimeFechaFinal.Visible = visible;
        }

        private void dateTimeFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            dateTimeFechaInicial.MaxDate = dateTimeFechaFinal.Value;
        }

        private void botonConfirmarFiltrosComidas_Click(object sender, EventArgs e)
        {
            IActualizarGrillaComidas padre = this.Owner as IActualizarGrillaComidas;
            if (padre != null)
            {
                padre.ActualizarGrillaComidas(FiltrarComidas());
            }

            this.Close();
        }

        private List<Comida> FiltrarComidas()
        {
            bool porSaludable = checkBoxFiltroSaludable.Checked;
            bool porMomentoComida = checkBoxFiltroPorMomentoComida.Checked;
            bool porFecha = checkBoxFiltroPorFecha.Checked;
            bool porReceta = checkBoxFiltroPorReceta.Checked;

            bool esSaludable = radioButtonSaludables.Checked;
            MomentosComida momento = (MomentosComida)comboBoxFiltroMomentoComida.SelectedItem;
            DateTime fechaMenor = dateTimeFechaInicial.Value.Date;
            DateTime fechaMayor = dateTimeFechaFinal.Value.Date;

            Receta receta = new Receta();

            if (grillaSeleccionRecetas.SelectedRows.Count > 0)
            {
                receta = grillaSeleccionRecetas.SelectedRows[0].DataBoundItem as Receta;
            }

            SeleccionFiltrosComidas filtros = new SeleccionFiltrosComidas(porSaludable, porMomentoComida, porFecha,
                porReceta, esSaludable, momento, fechaMenor, fechaMayor, receta);

            AdministradorComidas administradorComidas = new AdministradorComidas();

            return administradorComidas.FiltrarHistorialComidas(filtros);
        }
    }
}
