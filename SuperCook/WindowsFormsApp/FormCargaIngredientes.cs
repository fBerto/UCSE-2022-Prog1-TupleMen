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
    public partial class FormCargaIngredientes : Form
    {
        public FormCargaIngredientes()
        {
            InitializeComponent();
            comboBoxTipoIngrediente.DataSource = Enum.GetValues(typeof(TiposIngredientes));
        }

        public void BotonConfirmarCargaIngredientes_Click(object sender, EventArgs e)
        {
            //TODO: Limpiar esto, es asqueroso
            if(NoHayCamposNulos())
            {
                bool ingresoCorrectoCantidad = Int32.TryParse(textBoxCantidadIngrediente.Text, out int cantidad);
                bool ingresoCorrectoPrecio = Decimal.TryParse(textBoxPrecioPorUnidadIngrediente.Text, out decimal precioPorUnidad);
                bool ingresoCorrectoUnidad = Int32.TryParse(textBoxUnidadMinimaIngrediente.Text, out int unidadMinima);

                if (ingresoCorrectoCantidad && ingresoCorrectoPrecio && ingresoCorrectoUnidad)
                {
                    string nombre = textBoxNombreIngrediente.Text;
                    TiposIngredientes tipoIngrediente = (TiposIngredientes)comboBoxTipoIngrediente.SelectedItem;

                    AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

                    if (tipoIngrediente is TiposIngredientes.Bebida)
                    {
                        //TODO:
                        //Crear formulario o combobox que se dispare para ingresar el tipo de bebida.
                        //Bebida nuevaBebida = new Bebida(nombre, tipoIngrediente, cantidad, precioPorUnidad, unidadMinima, tipoBebida);
                        //administradorIngredientes.CargarIngrediente(nuevaBebida);
                    } else
                    {
                        Solido nuevoSolido = new Solido(nombre, tipoIngrediente, cantidad, precioPorUnidad, unidadMinima);
                        administradorIngredientes.CargarIngrediente(nuevoSolido);
                    }

                    IActualizarGrillaIngredientes padre = this.Owner as IActualizarGrillaIngredientes; 
                    if (padre != null)
                    {
                        padre.CargarGrillaIngredientes();
                    }

                    this.Close();
                } else
                {
                    MessageBox.Show("Cantidad, Precio y Unidad son campos numericos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //TODO: Funcion a limpiar
        private bool IngresoCorrectoDeNumeros()
        {
            if (Int32.TryParse(textBoxCantidadIngrediente.Text, out int cantidad) == false)
            {
                MessageBox.Show("La cantidad debe ser numerica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Decimal.TryParse(textBoxPrecioPorUnidadIngrediente.Text, out decimal precioPorUnidad) == false)
            {
                MessageBox.Show("El Precio por Unidad debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Int32.TryParse(textBoxUnidadMinimaIngrediente.Text, out int unidadMinima) == false)
            {
                MessageBox.Show("La Unidad Minima debe ser numerica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool NoHayCamposNulos()
        {
            List<TextBox> textBoxes = new List<TextBox>() { textBoxNombreIngrediente, textBoxCantidadIngrediente, textBoxPrecioPorUnidadIngrediente, textBoxUnidadMinimaIngrediente };
            if (textBoxes.Exists(x => string.IsNullOrEmpty(x.Text)) || string.IsNullOrEmpty(comboBoxTipoIngrediente.Text))
            {
                MessageBox.Show("Campos sin informacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else
            {
                return true;
            }
        }
    }
}
