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
        /*TODO:
         *Hacer que si edito un ingrediente se sobreescriba en la grilla  
         */

        public FormCargaIngredientes(int codigoIngrediente)
        {
            InitializeComponent();
            comboBoxTipoIngrediente.DataSource = Enum.GetValues(typeof(TiposIngredientes));
            comboBoxTipoBebida.DataSource = Enum.GetValues(typeof(TiposBebidas));
            comboBoxTipoBebida.Visible = false;
            lblTipoBebida.Visible = false;

            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            Ingrediente ingredienteAEditar = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);

            if (ingredienteAEditar != null)
            {
                CargarContenidoIngredienteAEditar(ingredienteAEditar);
            }
        }
        
        public void BotonConfirmarCargaIngredientes_Click(object sender, EventArgs e)
        {
            if (NoHayCamposNulos() && NoHayLetrasEnCamposNumericos() && NoHayNumerosEnElNombre())
            {
                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

                int codigo = administradorIngredientes.GetNuevoCodigo();

                string nombre = textBoxNombreIngrediente.Text;
                int cantidad = int.Parse(textBoxCantidadIngrediente.Text);
                int precioPorUnidad = int.Parse(textBoxPrecioPorUnidadIngrediente.Text); //TODO: rompe
                int unidadMinima = int.Parse(textBoxUnidadMinimaIngrediente.Text);

                TiposIngredientes tipoIngrediente = (TiposIngredientes)comboBoxTipoIngrediente.SelectedItem;

                if (tipoIngrediente is TiposIngredientes.Bebida)
                {
                    TiposBebidas tipoBebida = (TiposBebidas)comboBoxTipoBebida.SelectedItem;
                    Bebida nuevaBebida = new Bebida(codigo, nombre, tipoIngrediente, cantidad, precioPorUnidad, unidadMinima, tipoBebida);
                    administradorIngredientes.CargarIngrediente(nuevaBebida);
                } else
                {
                    Solido nuevoSolido = new Solido(codigo, nombre, tipoIngrediente, cantidad, precioPorUnidad, unidadMinima);
                    administradorIngredientes.CargarIngrediente(nuevoSolido);
                }

                IActualizarGrillaIngredientes padre = this.Owner as IActualizarGrillaIngredientes;
                if (padre != null)
                {
                    padre.CargarGrillaIngredientes();
                }

                this.Close();
            }
        }

        private bool NoHayLetrasEnCamposNumericos()
        {
            bool ingresoCorrectoCantidad = Int32.TryParse(textBoxCantidadIngrediente.Text, out int cantidad);
            bool ingresoCorrectoPrecio = Decimal.TryParse(textBoxPrecioPorUnidadIngrediente.Text, out decimal precioPorUnidad);
            bool ingresoCorrectoUnidad = Int32.TryParse(textBoxUnidadMinimaIngrediente.Text, out int unidadMinima);

            if (ingresoCorrectoCantidad && ingresoCorrectoPrecio && ingresoCorrectoUnidad)
            {
                return true;
            } else
            {
                MessageBox.Show("Cantidad, Precio y Unidad son campos numericos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        private bool NoHayNumerosEnElNombre()
        {
            string nombre = textBoxNombreIngrediente.Text;
            if (NoContieneNumeros(nombre))
            {
                return true;
            } else
            {
                MessageBox.Show("No puede haber numeros en el nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool NoContieneNumeros(string strAVerificar)
        {
            return strAVerificar.All(Char.IsLetter);
        }

        private void comboBoxTipoIngrediente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TiposIngredientes tipoSeleccionado = (TiposIngredientes)comboBoxTipoIngrediente.SelectedItem;
            if (tipoSeleccionado is TiposIngredientes.Bebida)
            {
                MostrarSeleccionTipoBebida();
            } else
            {
                OcultarSeleccionTipoBebida();
            }
        }

        private void OcultarSeleccionTipoBebida()
        {
            comboBoxTipoBebida.Visible = false;
            lblTipoBebida.Visible = false;
        }

        private void MostrarSeleccionTipoBebida()
        {
            comboBoxTipoBebida.Visible = true;
            lblTipoBebida.Visible = true;
        }

        private void CargarContenidoIngredienteAEditar(Ingrediente ingredienteAEditar)
        {
            textBoxNombreIngrediente.Text = ingredienteAEditar.Nombre;
            textBoxUnidadMinimaIngrediente.Text = ingredienteAEditar.UnidadMinima.ToString();
            textBoxCantidadIngrediente.Text = ingredienteAEditar.Cantidad.ToString();
            textBoxPrecioPorUnidadIngrediente.Text = ingredienteAEditar.PrecioPorUnidad.ToString();
            //comboBoxTipoIngrediente.SelectedValue = ingredienteAEditar.TipoIngrediente;

            comboBoxTipoIngrediente.SelectedItem = ingredienteAEditar.TipoIngrediente;

            if (ingredienteAEditar.TipoIngrediente is TiposIngredientes.Bebida)
            {
                comboBoxTipoBebida.SelectedValue = (ingredienteAEditar as Bebida).TipoBebida;
            }
        }
    }
}
