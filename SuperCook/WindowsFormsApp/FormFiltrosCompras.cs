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
        //TODO: Validaciones en logica
        // Validaciones de negocios: ingresos de nulos o campos obligatorios
        // Validaciones de tipo: en winform (parseos)
        //Probar maskedTextbox para obligar ingresos

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
            if (IngresoCorrecto())
            {
                IActualizarGrillaCompras padre = this.Owner as IActualizarGrillaCompras;
                if (padre != null)
                {
                    padre.ActualizarGrillaCompras(FiltrarIngredientesAComprar());
                }
                this.Close();
            }
        }

        private bool IngresoCorrecto()
        {
            if (checkBoxFiltroPorCosto.Checked)
            {
                if (decimal.TryParse(textBoxCostoIngresado.Text, out decimal precio) == false)
                {
                    MessageBox.Show("El precio debe ser numerico y no puede ser 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        //TODO: tiene que estar en la logica gran parte de esto, dificil
        //Ya probe pasar un objeto con los datos de los filtros pero los enum no pueden ser nulos,
        //En otro caso crearia 50 constructores distintos para las diferentes combinaciones de filtros,
        //La otra termina siendo descartar lo de filtros en simultaneo, y modificar el form.
        private List<Ingrediente> FiltrarIngredientesAComprar()
        {
            AdministradorCompras administradorCompras = new AdministradorCompras();
            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

            //Asigno la lista por si no se aplica ningun filtro
            List<Ingrediente> comprasFiltradas = administradorIngredientes.GetIngredientesAComprar();

            if (checkBoxFiltroTipoIngrediente.Checked)
            {
                TiposIngredientes tipoSeleccionado = (TiposIngredientes)comboBoxFiltroTipoIngrediente.SelectedItem;
                comprasFiltradas = administradorCompras.FiltrarPorTipoDeIngrediente(tipoSeleccionado);

                if (tipoSeleccionado is TiposIngredientes.Bebida)
                {
                    TiposBebidas tipoBebidaSeleccionado = (TiposBebidas)comboBoxFiltroTipoBebida.SelectedItem;
                    comprasFiltradas = administradorCompras.FiltrarPorTipoDeBebida(tipoBebidaSeleccionado);
                }
            }

            if (checkBoxFiltroEscasez.Checked)
            {
                GradosDeEscasez escasez = (GradosDeEscasez)comboBoxFiltroEscasez.SelectedItem;
                List<Ingrediente> comprasFiltradasPorEscasez = administradorCompras.FiltrarPorEscasez(escasez);

                if (comprasFiltradas.Count > 0)
                {
                    comprasFiltradas = comprasFiltradas.Intersect(comprasFiltradasPorEscasez).ToList();
                } else
                {
                    comprasFiltradas = comprasFiltradasPorEscasez;
                }
            }

            if (checkBoxFiltroPorCosto.Checked)
            {
                decimal costo = decimal.Parse(textBoxCostoIngresado.Text);
                List<Ingrediente> comprasFiltradasPorCosto = new List<Ingrediente>();

                if (radioButtonCostoMaximo.Checked)
                {
                    comprasFiltradasPorCosto = administradorCompras.FiltrarPorCostoMaximo(costo);
                } else
                {
                    comprasFiltradasPorCosto = administradorCompras.FiltrarPorCostoMinimo(costo);
                }

                if (comprasFiltradas.Count > 0)
                {
                    comprasFiltradas = comprasFiltradas.Intersect(comprasFiltradasPorCosto).ToList();
                } else
                {
                    comprasFiltradas = comprasFiltradasPorCosto;
                }
            }

            if (checkBoxFiltroPorUnidadDeMedida.Checked)
            {
                UnidadesDeMedida unidadDeMedida = (UnidadesDeMedida)comboBoxFiltroUnidadMedida.SelectedItem;
                List<Ingrediente> comprasFiltradasPorUnidadMedida = administradorCompras.FiltrarPorUnidadDeMedida(unidadDeMedida);

                if (comprasFiltradas.Count > 0)
                {
                    comprasFiltradas = comprasFiltradas.Intersect(comprasFiltradasPorUnidadMedida).ToList();
                } else
                {
                    comprasFiltradas = comprasFiltradasPorUnidadMedida;
                }
            }

            return comprasFiltradas;
        }


    }
}
