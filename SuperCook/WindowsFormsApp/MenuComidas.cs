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
    public partial class MenuComidas : Form
    {
        public MenuComidas()
        {
            InitializeComponent();
        }

        private void MenuComidas_Load(object sender, EventArgs e)
        {
            grillaComidas.AutoGenerateColumns = false;
            ActualizarGrillaComidas();
        }

        private void ActualizarGrillaComidas()
        {
            AdministradorComidas adminComidas = new AdministradorComidas();

            grillaComidas.DataSource = null;
            grillaComidas.DataSource = adminComidas.GetHistorialComidas();
        }

        private void cargarComidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormCargaComidas();
        }

        private void btnNuevaComida_Click(object sender, EventArgs e)
        {
            AbrirFormCargaComidas();
        }

        private void AbrirFormCargaComidas()
        {
            FormCargaComidas formCargaComidas = new FormCargaComidas();
            formCargaComidas.ShowDialog();
        }
    }
}
