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
        public EdicionIngredientesEnRecetas()
        {
            InitializeComponent();
        }

        public EdicionIngredientesEnRecetas(Ingrediente ingrediente)
        {
            this.ingrediente = ingrediente;
            InitializeComponent();
        }

        private void EdicionIngredientesEnRecetas_Load(object sender, EventArgs e)
        {
            NombreIngredienteAEditar.Text = ingrediente.Nombre;
            UnidadMedidaAEditar.Text = ingrediente.UnidadDeMedida.ToString();
            textBoxNuevaCantidadIngrediente.Text =ingrediente.Cantidad.ToString();
        }

        private void buttonConfirmarNuevaCantidad_Click(object sender, EventArgs e)
        {   //TODO:
            //validar datos
            //generar el objeto 
            //guardarlo con el mismo metodo que crear, con la difeencai que aca ya tengo un codigo 
            //Llamar al owner para actualizar grilla
        }
    }
}

