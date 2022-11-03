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
    public partial class FormFiltrosCompras : Form
    {
        public FormFiltrosCompras()
        {
            InitializeComponent();
        }

        private void FormFiltrosCompras_Load(object sender, EventArgs e)
        {
            comboBoxFiltroEscasez.Visible = false;

            comboBoxFiltroUnidadMedida.Visible = false;

            comboBoxFiltroTipoIngrediente.Visible = false;
            comboBoxFiltroTipoBebida.Visible = false;
            checkBoxFiltroTipoBebida.Visible = false;

            textBoxCostoIngresado.Visible = false;
            groupBoxCostoMinimoMaximo.Visible = false;

            comboBoxFiltroEscasez.DataSource = Enum.GetValues(typeof(GradosDeEscasez));
            comboBoxFiltroTipoBebida.DataSource = Enum.GetValues(typeof(TiposBebidas));
            comboBoxFiltroTipoIngrediente.DataSource = Enum.GetValues(typeof(TiposIngredientes));
            comboBoxFiltroUnidadMedida.DataSource = Enum.GetValues(typeof(UnidadesDeMedida));

            comboBoxFiltroEscasez.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroTipoBebida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroTipoIngrediente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroUnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList;

            radioButtonCostoMaximo.Checked = true;
        }

        private void checkBoxFiltroPorUnidadDeMedida_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFiltroUnidadMedida.Visible = checkBoxFiltroPorUnidadDeMedida.Checked;
        }

        private void checkBoxFiltroEscasez_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFiltroEscasez.Visible = checkBoxFiltroEscasez.Checked;
        }

        private void checkBoxFiltroTipoIngrediente_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFiltroTipoIngrediente.Visible = checkBoxFiltroTipoIngrediente.Checked;
        }

        private void checkBoxFiltroTipoBebida_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFiltroTipoBebida.Visible = checkBoxFiltroTipoBebida.Checked;
        }

        private void checkBoxFiltroPorPrecio_CheckedChanged(object sender, EventArgs e)
        {
            bool condicion = checkBoxFiltroPorCosto.Checked;
            textBoxCostoIngresado.Visible = condicion;
            groupBoxCostoMinimoMaximo.Visible = condicion;
        }

        private void comboBoxFiltroTipoIngrediente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TiposIngredientes tipoSeleccionado = (TiposIngredientes)comboBoxFiltroTipoIngrediente.SelectedItem;
            bool condicion = tipoSeleccionado is TiposIngredientes.Bebida;

            checkBoxFiltroTipoBebida.Visible = condicion;
            comboBoxFiltroTipoBebida.Visible = condicion && checkBoxFiltroTipoBebida.Checked;
        }

        private void botonConfirmarFiltrosCompras_Click(object sender, EventArgs e)
        {
            if (PrecioEsNumerico())
            {
                IActualizarGrillaCompras padre = this.Owner as IActualizarGrillaCompras;
                if (padre != null)
                {
                    padre.ActualizarGrillaCompras(FiltrarIngredientesAComprar());
                }
                this.Close();
            }
        }

        private bool PrecioEsNumerico()
        {
            if (checkBoxFiltroPorCosto.Checked)
            {
                if (decimal.TryParse(textBoxCostoIngresado.Text, out decimal precio) == false)
                {
                    MessageBox.Show("El precio debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private List<Ingrediente> FiltrarIngredientesAComprar()
        {
            bool porTipoIngrediente = checkBoxFiltroTipoIngrediente.Checked;
            bool porTipoBebida = checkBoxFiltroTipoBebida.Checked;
            bool porEscasez = checkBoxFiltroEscasez.Checked;
            bool porCosto = checkBoxFiltroPorCosto.Checked;
            bool porUnidadDeMedida = checkBoxFiltroPorUnidadDeMedida.Checked;
            bool esCostoMaximo = radioButtonCostoMaximo.Checked;

            TiposIngredientes tipoIngrediente = (TiposIngredientes)comboBoxFiltroTipoIngrediente.SelectedItem;
            TiposBebidas tipoBebida = (TiposBebidas)comboBoxFiltroTipoBebida.SelectedItem;
            GradosDeEscasez escasez = (GradosDeEscasez)comboBoxFiltroEscasez.SelectedItem;
            UnidadesDeMedida unidadDeMedida = (UnidadesDeMedida)comboBoxFiltroUnidadMedida.SelectedItem;

            decimal costo = 0;
            decimal.TryParse(textBoxCostoIngresado.Text, out costo);

            SeleccionFiltrosCompras filtros = new SeleccionFiltrosCompras(
                porTipoIngrediente, porTipoBebida, porEscasez, porCosto, esCostoMaximo, porUnidadDeMedida,
                tipoIngrediente, tipoBebida, escasez, costo, unidadDeMedida);

            AdministradorCompras administradorCompras = new AdministradorCompras();

            return administradorCompras.FiltrarIngredientesAComprar(filtros);
        }
    }
}
