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
    public partial class FormCargaRecetas : Form
    {
        List<Ingrediente> ingredientesSeleccionados = new List<Ingrediente>();
        public FormCargaRecetas()
        {
            InitializeComponent();
            comboBoxMomentosComida.DataSource = Enum.GetValues(typeof(MomentosComida));
        }

        private void ActualizarGrillaCargaIngredientes()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            grillaCargaRecetas.DataSource = null;
            grillaCargaRecetas.DataSource = administradorIngredientes.GetIngredientesEnDespensa();
        }

        private void ActualizarGrillaIngredientesSeleccionados(List<Ingrediente> ingredientesSeleccionados)
        {
            grillaIngredientesSeleccionados.AutoGenerateColumns = false;
            grillaIngredientesSeleccionados.DataSource = null;
            grillaIngredientesSeleccionados.DataSource = ingredientesSeleccionados;
        }
        private void FormCargaRecetas_Load(object sender, EventArgs e)
        {
            grillaCargaRecetas.AutoGenerateColumns = false;
            ActualizarGrillaCargaIngredientes();
        }

        private void buttonAceptarCargaRecetas_Click(object sender, EventArgs e)
        {
            if (NoHayCamposNulos())
            {
                foreach (DataGridViewRow row in grillaCargaRecetas.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                    if (chk.Value == chk.TrueValue)
                    {
                        var codigoIngrediente = int.Parse(grillaCargaRecetas.Rows[row.Index].Cells[0].Value.ToString());
                        AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                        Ingrediente ingredienteSeleccionado = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);
                        ingredientesSeleccionados.Add(ingredienteSeleccionado);
                    }
                }
                //TODO: Buscar si el ingrediente chequeado ya esta en la grilla, sino lo puedo repetir 
                ActualizarGrillaIngredientesSeleccionados(ingredientesSeleccionados);

                IActualizarGrillaIngredientes padre = this.Owner as IActualizarGrillaIngredientes;
                if (padre != null)
                {
                    padre.CargarGrillaIngredientes();
                }

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

            //Obtengo propiedades de la receta
            int codigo = administradorRecetas.GetNuevoCodigo();
            MomentosComida momentoComida = (MomentosComida)comboBoxMomentosComida.SelectedItem;
            string nombre = textBoxNombreRecetas.Text;
            bool esSaludable = checkBoxRecetaSaludable.Checked;

            Receta nuevaReceta = new Receta(codigo, momentoComida, nombre, esSaludable, ingredientesSeleccionados);
            administradorRecetas.CargarReceta(nuevaReceta);

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

            /*
             * 
             * editar solo cantidad 
             * label de cantidad kilo 
             */
        }

        private void grillaIngredientesSeleccionados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = ObtenerIndice(grillaIngredientesSeleccionados, "Editar");
            //int indiceEditar = 3;
            if (indiceEditar == e.ColumnIndex)
            {
                var indiceIdentificador = ObtenerIndice(grillaIngredientesSeleccionados, "Codigo");
                int codigoIngrediente = int.Parse(grillaIngredientesSeleccionados.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString()); //accede tipo matris 

                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                Ingrediente ingredienteAEditar = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);

                EdicionIngredientesEnRecetas edicionIngredientesEnRecetas = new EdicionIngredientesEnRecetas(ingredienteAEditar, ingredientesSeleccionados);
                edicionIngredientesEnRecetas.ShowDialog(this);

                ActualizarGrillaIngredientesSeleccionados(ingredientesSeleccionados);

            }
        }
    }






}
