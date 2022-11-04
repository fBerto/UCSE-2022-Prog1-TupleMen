using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;


namespace WindowsFormsApp
{
    public partial class MenuRecetas : Form, IActualizarGrillaRecetas
    {
        public MenuRecetas()
        {
            InitializeComponent();
        }

        private void MenuRecetas_Load(object sender, EventArgs e)
        {
            grillaRecetas.AutoGenerateColumns = false;
            ActualizarGrillaRecetas();
        }

        public void ActualizarGrillaRecetas()
        {
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();

            grillaRecetas.DataSource = null;
            grillaRecetas.DataSource = administradorRecetas.GetLibroRecetas();
        }
 
        private void cargarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargaRecetas cargaRecetas = new FormCargaRecetas(0);
            cargaRecetas.ShowDialog(this);
        }

        private void btnNuevaReceta_Click(object sender, EventArgs e) 
        {
            FormCargaRecetas formCargaRecetas = new FormCargaRecetas(0);
            formCargaRecetas.ShowDialog(this);
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

        private void grillaRecetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = ObtenerIndice(grillaRecetas, "Editar");
            int indiceEliminar = ObtenerIndice(grillaRecetas, "Eliminar");

            if (e.RowIndex >= 0)
            {
                Receta recetaSeleccionada = grillaRecetas.Rows[e.RowIndex].DataBoundItem as Receta;
                int codigoReceta = recetaSeleccionada.Codigo;

                if (indiceEditar == e.ColumnIndex)
                {
                    FormCargaRecetas formCargaRecetas = new FormCargaRecetas(codigoReceta);
                    formCargaRecetas.ShowDialog(this);
                }

                if (indiceEliminar == e.ColumnIndex)
                {
                    //Hizo clic en eliminar
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la receta?", "Eliminar receta", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        AdministradorRecetas administradorRecetas = new AdministradorRecetas();
                        administradorRecetas.EliminarReceta(codigoReceta);
                        ActualizarGrillaRecetas();
                    }
                }
            }
        }
    }
}
