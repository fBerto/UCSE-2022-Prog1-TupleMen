﻿using Logica;
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
    public partial class FormFiltrosComidas : Form
    {
        public FormFiltrosComidas()
        {
            InitializeComponent();
        }

        private void FormFiltrosComidas_Load(object sender, EventArgs e)
        {
            comboBoxFiltroSaludable.Visible = false;
            comboBoxFiltroMomentoComida.Visible = false;
            grillaSeleccionRecetas.Visible = false;
            ModificarVisibilidadFechas(false);

            comboBoxFiltroMomentoComida.DataSource = Enum.GetValues(typeof(MomentosComida));
            CargarGrillaRecetas();
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
            comboBoxFiltroSaludable.Visible = checkBoxFiltroSaludable.Checked;
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
            AdministradorComidas administradorComidas = new AdministradorComidas();

            //Asigno el historial por si no se aplica ningun filtro
            List<Comida> comidasFiltradas = administradorComidas.GetHistorialComidas();

            if (checkBoxFiltroSaludable.Checked)
            {
                bool condicion = comboBoxFiltroSaludable.SelectedIndex == 0;
                comidasFiltradas = administradorComidas.FiltroSaludable(condicion);
            }
            if (checkBoxFiltroPorMomentoComida.Checked)
            {
                MomentosComida momento = (MomentosComida)comboBoxFiltroMomentoComida.SelectedItem;
                List<Comida> comidasFiltradasPorMomento = administradorComidas.FiltroMomentoComida(momento);

                if (comidasFiltradas.Count > 0)
                {
                    comidasFiltradas = comidasFiltradas.Intersect(comidasFiltradasPorMomento).ToList();
                } else
                {
                    comidasFiltradas = comidasFiltradasPorMomento;
                }
            }
            if (checkBoxFiltroPorFecha.Checked)
            {
                //TODO: contemplar error fecha menor es mayor a fecha mayor
                DateTime fechaMenor = dateTimeFechaInicial.Value;
                DateTime fechaMayor = dateTimeFechaFinal.Value;

                List<Comida> comidasFiltradasPorFecha = administradorComidas.FiltroFecha(fechaMenor, fechaMayor);

                if (comidasFiltradas.Count > 0)
                {
                    comidasFiltradas = comidasFiltradas.Intersect(comidasFiltradasPorFecha).ToList();
                } else
                {
                    comidasFiltradas = comidasFiltradasPorFecha;
                }
            }
            if (checkBoxFiltroPorReceta.Checked)
            {
                Receta receta = grillaSeleccionRecetas.SelectedRows[0].DataBoundItem as Receta;

                List<Comida> comidasFiltradasPorReceta = administradorComidas.FiltroPorRecetas(receta);

                if (comidasFiltradas.Count > 0)
                {
                    comidasFiltradas = comidasFiltradas.Intersect(comidasFiltradasPorReceta).ToList();
                } else
                {
                    comidasFiltradas = comidasFiltradasPorReceta;
                }
            }
            return comidasFiltradas;
        }
    }
}
