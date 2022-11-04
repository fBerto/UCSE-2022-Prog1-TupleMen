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

namespace WindowsFormsApp
{
    public partial class FormCargaRecetas : Form, IActualizarGrillaIngredientesSeleccionados
    {
        private int codigoReceta;

        public FormCargaRecetas(int codigoReceta)
        {
            InitializeComponent();

            this.codigoReceta = codigoReceta;
        }

        private void FormCargaRecetas_Load(object sender, EventArgs e)
        {
            comboBoxMomentosComida.DataSource = Enum.GetValues(typeof(MomentosComida));
            comboBoxMomentosComida.DropDownStyle = ComboBoxStyle.DropDownList;

            grillaIngredientesSeleccionados.AutoGenerateColumns = false;
            grillaSeleccionarIngredientes.AutoGenerateColumns = false;
            ActualizarGrillaSeleccionarIngredientes();

            if (EstaEditando())
            {
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

        private void CargarContenidosRecetasAEditar(Receta recetaRecibida)
        {
            textBoxNombreRecetas.Text = recetaRecibida.Nombre;
            comboBoxMomentosComida.Text = recetaRecibida.MomentoComida.ToString();
            checkBoxRecetaSaludable.Checked = recetaRecibida.EsSaludable;
            ActualizarGrillaIngredientesSeleccionados(recetaRecibida.GetIngredientesReceta());
        }

        private void ActualizarGrillaSeleccionarIngredientes()
        {
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

            grillaSeleccionarIngredientes.DataSource = null;
            grillaSeleccionarIngredientes.DataSource = administradorIngredientes.GetIngredientesEnDespensa();
        }

        public void ActualizarGrillaIngredientesSeleccionados(List<Ingrediente> ingredientesSeleccionados)
        {
            grillaIngredientesSeleccionados.DataSource = null;
            grillaIngredientesSeleccionados.DataSource = ingredientesSeleccionados;
        }

        private void buttonConfirmarIngredientesSeleccionados_Click(object sender, EventArgs e)
        {
            List<Ingrediente> ingredientesSeleccionados = ObtenerIngredientesSeleccionados();

            ActualizarGrillaIngredientesSeleccionados(ingredientesSeleccionados);
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

        private int ObtenerIndice(DataGridView grilla, string nombreColumna)
        {
            foreach (DataGridViewColumn column in grilla.Columns)
            {
                if (column.Name == nombreColumna)
                {
                    return column.Index;
                }
            }
            return -1;
        }

        private void FinalizarCargaRecetas_Click(object sender, EventArgs e)
        {
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();

            MomentosComida momentoComida = (MomentosComida)comboBoxMomentosComida.SelectedItem;
            string nombre = textBoxNombreRecetas.Text;
            bool esSaludable = checkBoxRecetaSaludable.Checked;
            List<Ingrediente> ingredientesReceta = ObtenerIngredientesConfirmados();

            Receta nuevaReceta = new Receta(this.codigoReceta, momentoComida, nombre, esSaludable, ingredientesReceta);

            Resultado resultadoCarga = administradorRecetas.CargarModificarReceta(nuevaReceta);

            if (resultadoCarga.Ok == false)
            {
                MessageBox.Show(resultadoCarga.Mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                IActualizarGrillaRecetas padre = this.Owner as IActualizarGrillaRecetas;
                if (padre != null)
                {
                    padre.ActualizarGrillaRecetas();
                    this.Close();
                }
            }
        }

        private void EditarCantidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = ObtenerIndice(grillaIngredientesSeleccionados, "Editar");
            
            if (indiceEditar >= 0)
            {
                if (indiceEditar == e.ColumnIndex && e.RowIndex >= 0)
                {
                    int columnaCodigo = ObtenerIndice(grillaIngredientesSeleccionados, "Codigo");

                    int codigoIngrediente = int.Parse(grillaIngredientesSeleccionados.Rows[e.RowIndex].Cells[columnaCodigo].Value.ToString()); //accede tipo matris 

                    List<Ingrediente> ingredientesConfirmados = ObtenerIngredientesConfirmados();
                    Ingrediente ingredienteAEditar = ingredientesConfirmados.Find(x => x.Codigo == codigoIngrediente);

                    EdicionIngredientesEnRecetas edicionIngredientesEnRecetas = new EdicionIngredientesEnRecetas(ingredienteAEditar, ingredientesConfirmados);
                    edicionIngredientesEnRecetas.ShowDialog(this);
                }
            }
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
    }
}
