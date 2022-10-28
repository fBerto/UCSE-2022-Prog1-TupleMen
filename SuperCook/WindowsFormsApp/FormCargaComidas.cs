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
        }
    }
}
