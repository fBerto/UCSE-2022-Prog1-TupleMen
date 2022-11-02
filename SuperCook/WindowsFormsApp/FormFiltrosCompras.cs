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

            textBoxPrecioIngresado.Visible = false;
            groupBoxPrecioMinimoMaximo.Visible = false;

            comboBoxFiltroEscasez.DataSource = Enum.GetValues(typeof(GradosDeEscasez));
            comboBoxFiltroTipoBebida.DataSource = Enum.GetValues(typeof(TiposBebidas));
            comboBoxFiltroTipoIngrediente.DataSource = Enum.GetValues(typeof(TiposIngredientes));
            comboBoxFiltroUnidadMedida.DataSource = Enum.GetValues(typeof(UnidadesDeMedida));

            comboBoxFiltroEscasez.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroTipoBebida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroTipoIngrediente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroUnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList;

            radioButtonPrecioMaximo.Checked = true;
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
            bool condicion = checkBoxFiltroPorPrecio.Checked;
            textBoxPrecioIngresado.Visible = condicion;
            groupBoxPrecioMinimoMaximo.Visible = condicion;
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
            if (checkBoxFiltroPorPrecio.Checked)
            {
                if (string.IsNullOrEmpty(textBoxPrecioIngresado.Text))
                {
                    MessageBox.Show("Ingrese un precio o desmarque la casilla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } else
                {
                    if (decimal.TryParse(textBoxPrecioIngresado.Text, out decimal precio) == false)
                    {
                        MessageBox.Show("El precio debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

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

            if (checkBoxFiltroPorPrecio.Checked)
            {
                decimal precio = decimal.Parse(textBoxPrecioIngresado.Text);
                List<Ingrediente> comprasFiltradasPorPrecio = new List<Ingrediente>();

                if (radioButtonPrecioMaximo.Checked)
                {
                    comprasFiltradasPorPrecio = administradorCompras.FiltrarPorPrecioMaximo(precio);
                } else
                {
                    comprasFiltradasPorPrecio = administradorCompras.FiltrarPorPrecioMinimo(precio);
                }

                if (comprasFiltradas.Count > 0)
                {
                    comprasFiltradas = comprasFiltradas.Intersect(comprasFiltradasPorPrecio).ToList();
                } else
                {
                    comprasFiltradas = comprasFiltradasPorPrecio;
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
