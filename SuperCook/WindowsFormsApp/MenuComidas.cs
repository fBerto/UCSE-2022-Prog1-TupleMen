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
    public partial class MenuComidas : Form, IActualizarGrillaComidas
    {
        public MenuComidas()
        {
            InitializeComponent();
        }

        private void MenuComidas_Load(object sender, EventArgs e)
        {
            AdministradorComidas adminComidas = new AdministradorComidas();

            grillaComidas.AutoGenerateColumns = false;
            ActualizarGrillaComidas(adminComidas.GetHistorialComidas());
        }

        public void ActualizarGrillaComidas(List<Comida> dataSource)
        {
            grillaComidas.DataSource = null;
            grillaComidas.DataSource = dataSource;
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
            formCargaComidas.ShowDialog(this);
        }

        private void botonFiltrarComidas_Click(object sender, EventArgs e)
        {
            FormFiltrosComidas formFiltrosComidas = new FormFiltrosComidas();
            formFiltrosComidas.ShowDialog(this);
        }
    }
}
