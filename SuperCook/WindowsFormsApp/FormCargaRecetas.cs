using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class FormCargaRecetas : Form, IActualizarGrillaIngredientesSeleccionados
    {
        /*TODO:
         *verificar que existan elementos checkeados al confirmar la carga de estos 
         */

        //TODO: Validaciones en logica
        // Validaciones de negocios: ingresos de nulos o campos obligatorios
        // Validaciones de tipo: en winform (parseos)
        //Probar maskedTextbox para obligar ingresos

        List<Ingrediente> ingredientesAEditar = new List<Ingrediente>();
        Receta recetaAEditar;
        int codigoReceta;
        public FormCargaRecetas(int codigoReceta)
        {
            
            InitializeComponent();
            this.codigoReceta = codigoReceta;

            comboBoxMomentosComida.DataSource = Enum.GetValues(typeof(MomentosComida));
            if (codigoReceta > 0)
            {
                HacerVisibleIngredientes();
                HacerVisibleIngredientesSeleccionadosYFinCarga();

                AdministradorRecetas administradorRecetas = new AdministradorRecetas();
                recetaAEditar = administradorRecetas.BuscarCodigoReceta(codigoReceta);


                CargarContenidosRecetasAEditar(recetaAEditar);
               
            }
        }

        private void ActualizarGrillaCargaIngredientes()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            grillaCargaRecetas.DataSource = null;
            grillaCargaRecetas.DataSource = administradorIngredientes.GetIngredientesEnDespensa();
        }

        public void ActualizarGrillaIngredientesSeleccionados(List<Ingrediente> ingredientesSeleccionadosPorBox)
        {
            grillaIngredientesSeleccionados.AutoGenerateColumns = false;
            grillaIngredientesSeleccionados.DataSource = null;
            grillaIngredientesSeleccionados.DataSource = ingredientesSeleccionadosPorBox;

        }


        private void FormCargaRecetas_Load(object sender, EventArgs e)
        {
            grillaCargaRecetas.AutoGenerateColumns = false;
            ActualizarGrillaCargaIngredientes();
            if (codigoReceta > 0)
            {
                List<Ingrediente> ingredientesRecetaAEditar = recetaAEditar.GetIngredientesReceta();
                ActualizarGrillaIngredientesSeleccionados(ingredientesRecetaAEditar);

            }

        }

        private void buttonAceptarCargaRecetas_Click(object sender, EventArgs e)
        {
            this.ingredientesAEditar = ObtenerListaIngredientesSeleccionadosEnGrillaCargaRecetas();

            if (ingredientesAEditar.Count() == 0)
            {
                MessageBox.Show("Seleccionar ingredientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HacerVisibleIngredientesSeleccionadosYFinCarga();
            ActualizarGrillaIngredientesSeleccionados(ingredientesAEditar);

        }
        private List<Ingrediente> ComprobarElementosNoSeleccionadosAnteriormente(List<Ingrediente> NuevasSelecciones)
        {
            List<Ingrediente> ValidosACargar = new List<Ingrediente>();
            foreach (Ingrediente element in NuevasSelecciones)
            {
                ValidosACargar.Add(ingredientesAEditar.Find(x => x.Codigo != element.Codigo));
            }
            return ValidosACargar;
        }
        private void HacerVisibleIngredientes()
        {
            label3.Visible = true;
            grillaCargaRecetas.Visible = true;
            buttonAceptarCargaRecetas.Visible = true;

        }
        private void HacerVisibleIngredientesSeleccionadosYFinCarga()
        {
            label4.Visible = true;
            grillaIngredientesSeleccionados.Visible = true;
            FinalizarCargaRecetas.Visible = true;
        }
        private int ObtenerIndice(DataGridView grilla, string nombreColumna)
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

        private void FinalizarCargaRecetas_Click(object sender, EventArgs e)
        {
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();          

            MomentosComida momentoComida = (MomentosComida)comboBoxMomentosComida.SelectedItem;
            string nombre = textBoxNombreRecetas.Text;
            bool esSaludable = checkBoxRecetaSaludable.Checked;

            Receta nuevaReceta = new Receta(this.codigoReceta, momentoComida, nombre, esSaludable, ObtenerListaIngredientesSeleccionadosEnGrillaIngredientesSeleccionados());
            administradorRecetas.CargarModificarReceta(nuevaReceta);

            IActualizarGrillaRecetas padre = this.Owner as IActualizarGrillaRecetas;
            if (padre != null)
            {
                padre.CargarGrillaRecetas();
                this.Close();
            }
            else
            {
                MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grillaIngredientesSeleccionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = ObtenerIndice(grillaIngredientesSeleccionados, "Editar");
            if (indiceEditar == e.ColumnIndex)
            {
                var indiceIdentificador = ObtenerIndice(grillaIngredientesSeleccionados, "Codigo");
                int codigoIngrediente = int.Parse(grillaIngredientesSeleccionados.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString()); //accede tipo matris 
                //TODO: ver si accedo con receta o no 
                this.ingredientesAEditar = ObtenerListaIngredientesSeleccionadosEnGrillaIngredientesSeleccionados();

                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                Ingrediente ingredienteAEditar = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);
                EdicionIngredientesEnRecetas edicionIngredientesEnRecetas = new EdicionIngredientesEnRecetas(ingredienteAEditar, codigoReceta,ingredientesAEditar);
                edicionIngredientesEnRecetas.ShowDialog(this);

            }
        }

        private void CargarContenidosRecetasAEditar(Receta recetaRecibida)
        {
            textBoxNombreRecetas.Text = recetaRecibida.Nombre;
            comboBoxMomentosComida.Text = recetaRecibida.MomentoComida.ToString();
            checkBoxRecetaSaludable.Checked = recetaRecibida.EsSaludable;
            ActualizarGrillaIngredientesSeleccionados(recetaRecibida.GetIngredientesReceta());
        }
        private List<Ingrediente> ObtenerListaIngredientesSeleccionadosEnGrillaCargaRecetas()
        {
            foreach (DataGridViewRow row in grillaCargaRecetas.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                if (chk.Value == chk.TrueValue)
                {
                    var codigoIngrediente = int.Parse(grillaCargaRecetas.Rows[row.Index].Cells[0].Value.ToString());
                    AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                    Ingrediente ingredienteSeleccionado = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);
                    ingredientesAEditar.Add(ingredienteSeleccionado);
                }
            }
            return ingredientesAEditar;
        }

        private List<Ingrediente> ObtenerListaIngredientesSeleccionadosEnGrillaIngredientesSeleccionados()
        {
            List<Ingrediente> ingredientesObtenidos = new List<Ingrediente>();
            foreach (DataGridViewRow row in grillaIngredientesSeleccionados.Rows)
            {
                var codigoIngrediente = int.Parse(grillaIngredientesSeleccionados.Rows[row.Index].Cells[0].Value.ToString());
                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                Ingrediente ingredienteSeleccionado = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);

                ingredienteSeleccionado.Cantidad = int.Parse(grillaIngredientesSeleccionados.Rows[row.Index].Cells[2].Value.ToString());
                ingredientesObtenidos.Add(ingredienteSeleccionado);
            }
            return ingredientesObtenidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NoHayCamposNulos())
            {
                HacerVisibleIngredientes();
            }

        }
        private bool NoHayCamposNulos()
        {
            bool resultado = true;
            if ((string.IsNullOrEmpty(comboBoxMomentosComida.Text)) || string.IsNullOrEmpty(textBoxNombreRecetas.Text))
            {
                MessageBox.Show("Falta de informacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = false;
            }
            return resultado;
        }
    }
}
