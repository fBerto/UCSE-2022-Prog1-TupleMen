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

        List<Ingrediente> ingredientesSeleccionados = new List<Ingrediente>();
        Receta recetaAEditar;
        bool edicion = false;
        public FormCargaRecetas()
        {
            InitializeComponent();
            comboBoxMomentosComida.DataSource = Enum.GetValues(typeof(MomentosComida));
        }
        public FormCargaRecetas(int codigoReceta)
        {
            InitializeComponent();

            this.edicion = true;
            HacerVisibleIngredientes();
            HacerVisibleIngredientesSeleccionadosYFinCarga();

            comboBoxMomentosComida.DataSource = Enum.GetValues(typeof(MomentosComida));
            AdministradorRecetas administradorRecetas = new AdministradorRecetas();
            this.recetaAEditar = administradorRecetas.BuscarCodigoReceta(codigoReceta);

            if (recetaAEditar != null)
            {
                CargarContenidosRecetasAEditar(recetaAEditar);
                this.ingredientesSeleccionados = recetaAEditar.GetIngredientesReceta();
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
            grillaIngredientesSeleccionados.DataSource = ingredientesSeleccionados;
            //this.ingredientesSeleccionados = ingredientesSeleccionados;
        }
       

        private void FormCargaRecetas_Load(object sender, EventArgs e)
        {
            grillaCargaRecetas.AutoGenerateColumns = false;
            ActualizarGrillaCargaIngredientes();
        }

        private void buttonAceptarCargaRecetas_Click(object sender, EventArgs e)
        {
            if (ingredientesSeleccionados.Count() == 0) //primer vez q cargo ingredientes 
            {
                this.ingredientesSeleccionados = ObtenerListaIngredientesSeleccionadosEnGrillaCargaRecetas();
                if (ingredientesSeleccionados.Count() == 0)
                {
                    MessageBox.Show("Seleccionar ingredientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
                List<Ingrediente> noRepetidos = ComprobarElementosNoSeleccionadosAnteriormente(ObtenerListaIngredientesSeleccionadosEnGrillaCargaRecetas());
                if(noRepetidos.Count() > 0)
                {
                    ingredientesSeleccionados.AddRange(noRepetidos);
                }
                
                
            }
            HacerVisibleIngredientesSeleccionadosYFinCarga();
            ActualizarGrillaIngredientesSeleccionados(ingredientesSeleccionados);

        }
        private List<Ingrediente> ComprobarElementosNoSeleccionadosAnteriormente(List < Ingrediente> NuevasSelecciones)
        {
            foreach (Ingrediente element in ingredientesSeleccionados)
            {
                int IndiceRepetido = NuevasSelecciones.FindIndex(x => x.Codigo == element.Codigo);
                if(IndiceRepetido > -1)
                {
                    NuevasSelecciones.RemoveAt(IndiceRepetido);
                }
            }
            return NuevasSelecciones;
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
            int codigo;
            if (edicion)
            {
                codigo = recetaAEditar.Codigo;

            }
            else
            {
                codigo = administradorRecetas.GetNuevoCodigo();
            }

            MomentosComida momentoComida = (MomentosComida)comboBoxMomentosComida.SelectedItem;
            string nombre = textBoxNombreRecetas.Text;
            bool esSaludable = checkBoxRecetaSaludable.Checked;

            this.ingredientesSeleccionados = ObtenerListaIngredientesSeleccionadosEnGrillaIngredientesSeleccionados();
            Receta nuevaReceta = new Receta(codigo, momentoComida, nombre, esSaludable, ingredientesSeleccionados);

            Receta recetaEditada = administradorRecetas.BuscarCodigoReceta(codigo);
            if (recetaEditada == null)
            {
                administradorRecetas.CargarReceta(nuevaReceta);
            }
            else
            {
                administradorRecetas.ModificarReceta(nuevaReceta);
            }

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

                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                Ingrediente ingredienteAEditar = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);
                EdicionIngredientesEnRecetas edicionIngredientesEnRecetas = new EdicionIngredientesEnRecetas(ingredienteAEditar, ingredientesSeleccionados);
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
            List<Ingrediente> ingredienteLista = new List<Ingrediente>();
            foreach (DataGridViewRow row in grillaCargaRecetas.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                if (chk.Value == chk.TrueValue)
                {
                    var codigoIngrediente = int.Parse(grillaCargaRecetas.Rows[row.Index].Cells[0].Value.ToString());
                    AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                    Ingrediente ingredienteSeleccionado = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);
                    ingredienteLista.Add(ingredienteSeleccionado);
                }
            }
            return ingredienteLista;
        }

        private List<Ingrediente> ObtenerListaIngredientesSeleccionadosEnGrillaIngredientesSeleccionados()
        {
            foreach (DataGridViewRow row in grillaIngredientesSeleccionados.Rows)
            {
                var codigoIngrediente = int.Parse(grillaIngredientesSeleccionados.Rows[row.Index].Cells[0].Value.ToString());
                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
                Ingrediente ingredienteSeleccionado = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);
                ingredienteSeleccionado.Cantidad = int.Parse(grillaIngredientesSeleccionados.Rows[row.Index].Cells[2].Value.ToString());

                int indice = ingredientesSeleccionados.FindIndex(x => x.Codigo == codigoIngrediente);
                ingredientesSeleccionados[indice] = ingredienteSeleccionado;

            }
            return ingredientesSeleccionados;
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
