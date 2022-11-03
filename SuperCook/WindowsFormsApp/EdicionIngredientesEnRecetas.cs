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
    public partial class EdicionIngredientesEnRecetas : Form
    {
        private Ingrediente ingrediente { get; set; }

        private List<Ingrediente> ingredientesAEditar { get; set; }

        public EdicionIngredientesEnRecetas()
        {
            InitializeComponent();
        }

        public EdicionIngredientesEnRecetas(Ingrediente ingrediente, List<Ingrediente> ingredientesConfirmados)
        {
            InitializeComponent();

            this.ingrediente = ingrediente;
            this.ingredientesAEditar = ingredientesConfirmados;
        }

        private void EdicionIngredientesEnRecetas_Load(object sender, EventArgs e)
        {
            NombreIngredienteAEditar.Text = ingrediente.Nombre;
            UnidadMedidaAEditar.Text = ingrediente.UnidadDeMedida.ToString();
        }

        private void buttonConfirmarNuevaCantidad_Click(object sender, EventArgs e)
        {
            int nuevaCantidad = 0;

            if (!string.IsNullOrEmpty(textBoxNuevaCantidadIngrediente.Text))
            {
                nuevaCantidad = int.Parse(textBoxNuevaCantidadIngrediente.Text);

                if (nuevaCantidad <= 0)
                {
                    MessageBox.Show("che pero mayor a 0 banana", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    int indice = ingredientesAEditar.FindIndex(x => x.Codigo == ingrediente.Codigo);

                    if (ingrediente is Solido)
                    {
                        Solido solidoModificado = new Solido(ingrediente.Codigo, ingrediente.Nombre, ingrediente.TipoIngrediente, nuevaCantidad, ingrediente.PrecioPorUnidad, ingrediente.UnidadMinima);
                        ingredientesAEditar[indice] = solidoModificado;
                    } else
                    {
                        Bebida bebidaAModificar = ingrediente as Bebida;
                        Bebida bebidaModificada = new Bebida(ingrediente.Codigo, ingrediente.Nombre, ingrediente.TipoIngrediente, nuevaCantidad, ingrediente.PrecioPorUnidad, ingrediente.UnidadMinima,bebidaAModificar.TipoBebida);
                        ingredientesAEditar[indice] = bebidaModificada;
                    }

                    IActualizarGrillaIngredientesSeleccionados padre = this.Owner as IActualizarGrillaIngredientesSeleccionados;
                    if (padre != null)
                    {
                        padre.ActualizarGrillaIngredientesSeleccionados(ingredientesAEditar);
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cargale numero papi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

