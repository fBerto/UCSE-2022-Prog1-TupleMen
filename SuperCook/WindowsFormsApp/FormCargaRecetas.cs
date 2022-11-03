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

        int codigoReceta;

        public FormCargaRecetas(int codigoReceta)
        {
            InitializeComponent();

            this.codigoReceta = codigoReceta;
        }

        private void FormCargaRecetas_Load(object sender, EventArgs e)
        {
            comboBoxMomentosComida.DataSource = Enum.GetValues(typeof(MomentosComida));
            comboBoxMomentosComida.DropDownStyle = ComboBoxStyle.DropDownList;

            grillaSeleccionarIngredientes.AutoGenerateColumns = false;
            ActualizarGrillaSeleccionarIngredientes();

            if (EstaEditando())
            {
                HacerVisibleSeleccionIngredientes();
                HacerVisibleIngredientesSeleccionadosYFinCarga();

                AdministradorRecetas administradorRecetas = new AdministradorRecetas();
                Receta recetaAEditar = administradorRecetas.BuscarCodigoReceta(codigoReceta);

                CargarContenidosRecetasAEditar(recetaAEditar);

                List<Ingrediente> ingredientesRecetaAEditar = recetaAEditar.GetIngredientesReceta();
                ActualizarGrillaIngredientesSeleccionados(ingredientesRecetaAEditar);
            }
        }

        private bool EstaEditando()
        {
            return codigoReceta > 0;
        }

        private void ActualizarGrillaSeleccionarIngredientes()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

            grillaSeleccionarIngredientes.DataSource = null;
            grillaSeleccionarIngredientes.DataSource = administradorIngredientes.GetIngredientesEnDespensa();
        }

        public void ActualizarGrillaIngredientesSeleccionados(List<Ingrediente> ingredientesSeleccionados)
        {
            grillaIngredientesSeleccionados.AutoGenerateColumns = false;
            grillaIngredientesSeleccionados.DataSource = null;
            grillaIngredientesSeleccionados.DataSource = ingredientesSeleccionados;
        }

        private void buttonConfirmarIngredientesSeleccionados_Click(object sender, EventArgs e)
        {
            List<Ingrediente> ingredientesSeleccionados = ObtenerIngredientesSeleccionados();

            if (ingredientesSeleccionados.Count == 0)
            {
                MessageBox.Show("Seleccionar ingredientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                HacerVisibleIngredientesSeleccionadosYFinCarga();
                ActualizarGrillaIngredientesSeleccionados(ingredientesSeleccionados);
            }
        }

        private List<Ingrediente> ObtenerIngredientesSeleccionados()
        {
            List<Ingrediente> ingredientesSeleccionados = new List<Ingrediente>();

            foreach (DataGridViewRow row in grillaSeleccionarIngredientes.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                if (chk.Value == chk.TrueValue)
                {
                    Ingrediente ingredienteSeleccionado = grillaSeleccionarIngredientes.Rows[row.Index].DataBoundItem as Ingrediente;
                    ingredientesSeleccionados.Add(ingredienteSeleccionado);
                }
            }
            return ingredientesSeleccionados;
        }

        private void HacerVisibleSeleccionIngredientes()
        {
            label3.Visible = true;
            grillaSeleccionarIngredientes.Visible = true;
            buttonConfirmarIngredientesSeleccionados.Visible = true;
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
            List<Ingrediente> ingredientesReceta = ObtenerIngredientesConfirmados();

            Receta nuevaReceta = new Receta(this.codigoReceta, momentoComida, nombre, esSaludable, ingredientesReceta);
            
            administradorRecetas.CargarModificarReceta(nuevaReceta);

            IActualizarGrillaRecetas padre = this.Owner as IActualizarGrillaRecetas;
            if (padre != null)
            {
                padre.ActualizarGrillaRecetas();
                this.Close();
            }
            else
            {
                MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarCantidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = ObtenerIndice(grillaIngredientesSeleccionados, "Editar");

            if (indiceEditar == e.ColumnIndex)
            {
                int columnaCodigo = ObtenerIndice(grillaIngredientesSeleccionados, "Codigo");
                int codigoIngrediente = int.Parse(grillaIngredientesSeleccionados.Rows[e.RowIndex].Cells[columnaCodigo].Value.ToString()); //accede tipo matris 
                
                List<Ingrediente> ingredientesConfirmados = ObtenerIngredientesConfirmados();
                Ingrediente ingredienteAEditar = ingredientesConfirmados.Find(x => x.Codigo == codigoIngrediente);

                EdicionIngredientesEnRecetas edicionIngredientesEnRecetas = new EdicionIngredientesEnRecetas(ingredienteAEditar, ingredientesConfirmados);
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

        private List<Ingrediente> ObtenerIngredientesConfirmados()
        {
            List<Ingrediente> ingredientesConfirmados = new List<Ingrediente>();

            foreach (DataGridViewRow row in grillaIngredientesSeleccionados.Rows)
            {
                Ingrediente ingredienteConfirmado = grillaIngredientesSeleccionados.Rows[row.Index].DataBoundItem as Ingrediente;
                ingredientesConfirmados.Add(ingredienteConfirmado);
            }
            return ingredientesConfirmados;
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (NoHayCamposNulos())
            {
                HacerVisibleSeleccionIngredientes();
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
