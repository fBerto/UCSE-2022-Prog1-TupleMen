﻿using System;
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
    public partial class MenuComidas : Form
    {
        public MenuComidas()
        {
            InitializeComponent();
        }

        private void cargarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargaComidas formCargaComidas = new FormCargaComidas();
            formCargaComidas.ShowDialog();
        }
    }
}
