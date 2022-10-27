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
                string nombre = textBoxNombreIngrediente.Text;
                string tipoIngrediente = comboBoxTipoIngrediente.Text;

                //if (comboBoxTipoIngrediente.Text == "Bebida")
                //{
                //    Bebida nuevaBebida = new Bebida(textBoxNombreIngrediente.Text, )
                //}
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
