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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class FormCargaRecetas : Form
    {
        public FormCargaRecetas()
        {
            InitializeComponent();
            comboBoxMomentosComida.DataSource = Enum.GetValues(typeof(MomentosComida));
        }

        private void ActualizarGrillaSeleccionIngredientes()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            grillaCargaRecetas.DataSource = null;
            grillaCargaRecetas.DataSource = administradorIngredientes.GetIngredientesEnDespensa();
        }
        private void FormCargaRecetas_Load(object sender, EventArgs e)
        {
            grillaCargaRecetas.AutoGenerateColumns = false;
            ActualizarGrillaSeleccionIngredientes();
        }

        private void buttonAceptarCargaRecetas_Click(object sender, EventArgs e) 
        {
            if (NoHayCamposNulos())
            {
                AdministradorRecetas administradorRecetas = new AdministradorRecetas();

                //Obtengo propiedades de la receta
                int codigo = administradorRecetas.GetNuevoCodigo();
                MomentosComida momentoComida = (MomentosComida)comboBoxMomentosComida.SelectedItem;
                string nombre = textBoxNombreRecetas.Text;
                bool esSaludable = checkBoxRecetaSaludable.Checked;
                List<Ingrediente> ingredientesSeleccionados = new List<Ingrediente>();

                //TODO: Agregar columna con check, sino va a ser muy dificil seleccionar (tiene que apretar ctrl)
                //foreach (DataGridViewRow fila in grillaIngredientesSeleccionados.SelectedRows)
                //{
                //    Ingrediente ingrediente = fila.DataBoundItem as Ingrediente;
                //    ingredientesSeleccionados.Add(ingrediente);
                //}

                Receta nuevaReceta = new Receta(codigo, momentoComida, nombre, esSaludable, ingredientesSeleccionados);

                IActualizarGrillaIngredientes padre = this.Owner as IActualizarGrillaIngredientes;
                if (padre != null)
                {
                    padre.CargarGrillaIngredientes();
                    IActualizarGrillaRecetas padre2 = this.Owner as IActualizarGrillaRecetas;
                    if (padre2 != null)
                    {
                        padre2.CargarGrillaRecetas();
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad, Precio y Unidad son campos numericos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool NoHayCamposNulos()
        {
            bool resultado = true;
            if ((string.IsNullOrEmpty(comboBoxMomentosComida.Text)) || string.IsNullOrEmpty(textBoxNombreRecetas.Text) || grillaCargaRecetas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Falta de informacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = false;
            }
            return resultado;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // no me estaria entrando cuando hago click
        {
            int indiceEditar = ObtenerIndice(grillaCargaRecetas, "Editar");
            if (indiceEditar == e.ColumnIndex)
            {
                var indiceIdentificador = ObtenerIndice(grillaCargaRecetas, "Codigo"); 
                int codigoIngrediente = int.Parse(grillaCargaRecetas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString()); //accede tipo matris 

                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                Ingrediente ingredienteAEditar= administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);

                EdicionIngredientesEnRecetas edicionIngredientesEnRecetas = new EdicionIngredientesEnRecetas(ingredienteAEditar);
                edicionIngredientesEnRecetas.ShowDialog(this);
                
            }
        }

        private int  ObtenerIndice(DataGridView grilla, string nombreColumna)
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
    }



       

    
}
