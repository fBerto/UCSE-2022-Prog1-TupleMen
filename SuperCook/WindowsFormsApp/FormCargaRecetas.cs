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
                List<Ingrediente> ingredientesSeleccionados = new List<Ingrediente>();

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

                IActualizarGrillaIngredientes padre = this.Owner as IActualizarGrillaIngredientes;
                if (padre != null)
                {
                    padre.CargarGrillaIngredientes();
                }
                /*
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
                }
                else
                {
                    MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
                /* actualizar la segunda grilla con ingredientes seleccioados 
                 * instanciar los objetos con su cantidad creada
                 * editar solo cantidad 
                 * label de cantidad kilo 
                 */
            }
        }

        private void grillaCargaRecetas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Int32 selectedRowCount = grillaCargaRecetas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            List<Ingrediente> SolidosSeleccionados = new List<Ingrediente>();
            List<Ingrediente> BebidasSeleccionados = new List<Ingrediente>();
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    var indice = (grillaCargaRecetas.SelectedRows[i].Index);
                    var codigoIngrediente = int.Parse(grillaCargaRecetas.Rows[indice].Cells[0].Value.ToString());
                    AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                    Ingrediente ingredienteSeleccionado = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);
                    if (ingredienteSeleccionado is Solido)
                    {
                        SolidosSeleccionados.Add(ingredienteSeleccionado);
                    }
                    else
                    {
                        BebidasSeleccionados.Add(ingredienteSeleccionado);
                    }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // no me estaria entrando cuando hago click
        {
            int indiceEditar = ObtenerIndice(grillaCargaRecetas, "Editar");
            if (indiceEditar == e.ColumnIndex)
            {
                var indiceIdentificador = ObtenerIndice(grillaCargaRecetas, "Codigo");
                int codigoIngrediente = int.Parse(grillaCargaRecetas.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString()); //accede tipo matris 

                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                Ingrediente ingredienteAEditar = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);

                EdicionIngredientesEnRecetas edicionIngredientesEnRecetas = new EdicionIngredientesEnRecetas(ingredienteAEditar);
                edicionIngredientesEnRecetas.ShowDialog(this);

            }
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

       
    }






}
