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
        }

        private void BotonConfirmarCargaIngredientes_Click(object sender, EventArgs e)
        {
           List<TextBox> textBoxes = new List<TextBox>() { textBoxNombreIngrediente , textBoxCantidadIngrediente, textBoxPrecioPorUnidadIngrediente, textBoxUnidadMinimaIngrediente};
            if(textBoxes.Exists(x=> string.IsNullOrEmpty(x.Text)) || string.IsNullOrEmpty(comboBoxAceptarIngredientes.Text))
            {
                MessageBox.Show("Campos sin informacion","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

           
        }
    }
}
