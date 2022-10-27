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

        private void BotonConfirmarCargaIngredientes_Click(object sender, EventArgs e)
        {
            if(NoHayCamposNulos())
            {
                //TODO: Corroborar ingresos del usuario
                string nombre = textBoxNombreIngrediente.Text;
                TiposIngredientes tipoIngrediente = (TiposIngredientes)comboBoxTipoIngrediente.SelectedItem;
                if(Int32.TryParse(textBoxCantidadIngrediente.Text, out int cantidad) == false){
                    //No puede ingresar una cantidad string
                }
                if (Decimal.TryParse(textBoxPrecioPorUnidadIngrediente.Text, out decimal precioPorUnidad) == false)
                {
                    //No puede ingresar una cantidad string
                }
                if (Int32.TryParse(textBoxUnidadMinimaIngrediente.Text, out int unidadMinima) == false)
                {
                    //No puede ingresar una cantidad string
                }

                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

                if (tipoIngrediente is TiposIngredientes.Bebida)
                {
                    //Crear formulario o combobox que se dispare para ingresar el tipo de bebida.
                    //Bebida nuevaBebida = new Bebida(nombre, tipoIngrediente, cantidad, precioPorUnidad, unidadMinima, tipoBebida);
                    //administradorIngredientes.CargarIngrediente(nuevaBebida);
                } else
                {
                    Solido nuevoSolido = new Solido(nombre, tipoIngrediente, cantidad, precioPorUnidad, unidadMinima);
                    administradorIngredientes.CargarIngrediente(nuevoSolido);
                }

                //TODO: Actualizar lista
            }
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
