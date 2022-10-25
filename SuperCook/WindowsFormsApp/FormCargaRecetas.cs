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
    public partial class FormCargaRecetas : Form
    {
        public FormCargaRecetas()
        {
            InitializeComponent();
        }

        private void buttonAceptarCargaRecetas_Click(object sender, EventArgs e)
        {
            if (!checkBoxRecetaSaludable.Checked || string.IsNullOrEmpty(textBoxNombreRecetas.Text))
            {
                MessageBox.Show("Campos sin informacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
