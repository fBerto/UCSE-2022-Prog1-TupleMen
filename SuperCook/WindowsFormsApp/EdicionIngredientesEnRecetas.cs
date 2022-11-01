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
        List<Ingrediente> ingredientesSeleccionados = new List<Ingrediente>();
        public EdicionIngredientesEnRecetas()
        {
            InitializeComponent();
        }

        public EdicionIngredientesEnRecetas(Ingrediente ingrediente, List<Ingrediente> ingredientesSeleccionados)
        {
            this.ingrediente = ingrediente;          
            this.ingredientesSeleccionados = ingredientesSeleccionados;
            InitializeComponent();
        }

        private void EdicionIngredientesEnRecetas_Load(object sender, EventArgs e)
        {
            NombreIngredienteAEditar.Text = ingrediente.Nombre;
            UnidadMedidaAEditar.Text = ingrediente.UnidadDeMedida.ToString();
        }

        private void buttonConfirmarNuevaCantidad_Click(object sender, EventArgs e)
        {  
            int nuevaCantidad = 0;
            if (!string.IsNullOrEmpty(textBoxNuevaCantidadIngrediente.Text ))
            {
                nuevaCantidad = int.Parse(textBoxNuevaCantidadIngrediente.Text);
                if (nuevaCantidad <= 0)
                {
                    MessageBox.Show("che pero mayor a 0 banana", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                int indice = ingredientesSeleccionados.FindIndex(x => x.Codigo == ingrediente.Codigo);

                if (ingrediente is Solido)
                {
                    Solido solidoModificado = new Solido(ingrediente.Codigo, ingrediente.Nombre, ingrediente.TipoIngrediente, nuevaCantidad, ingrediente.PrecioPorUnidad, ingrediente.UnidadMinima);
                    ingredientesSeleccionados[indice] = solidoModificado;
                }
                else
                {   //TODO: como se que tipo de bebida es?
                    //Bebida bebidaModificada = new Bebida(ingrediente.Codigo, ingrediente.Nombre, ingrediente.TipoIngrediente, ingrediente.Cantidad, ingrediente.PrecioPorUnidad, ingrediente.UnidadMinima);
                    //ingredientesSeleccionados[indice] = bebidaModificada;
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

