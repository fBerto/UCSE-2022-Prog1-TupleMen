﻿using Logica;
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
        private int Codigo { get; set; }

        public FormCargaIngredientes(int codigoIngrediente)
        {
            this.Codigo = codigoIngrediente;

            InitializeComponent();
            comboBoxTipoIngrediente.DataSource = Enum.GetValues(typeof(TiposIngredientes));
            comboBoxTipoBebida.DataSource = Enum.GetValues(typeof(TiposBebidas));
            comboBoxTipoBebida.Visible = false;
            lblTipoBebida.Visible = false;

            comboBoxTipoBebida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoIngrediente.DropDownStyle = ComboBoxStyle.DropDownList;

            AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();
            Ingrediente ingredienteAEditar = administradorIngredientes.BuscarCodigoIngrediente(codigoIngrediente);

            if (ingredienteAEditar != null)
            {
                CargarContenidoIngredienteAEditar(ingredienteAEditar);
            }
        }
        
        public void BotonConfirmarCargaIngredientes_Click(object sender, EventArgs e)
        {
            if (NoHayLetrasEnCamposNumericos())
            {
                AdministradorIngredientes administradorIngredientes = new AdministradorIngredientes();

                string nombre = textBoxNombreIngrediente.Text;
                int cantidad = int.Parse(textBoxCantidadIngrediente.Text);
                decimal precioPorUnidad = decimal.Parse(textBoxPrecioPorUnidadIngrediente.Text);
                int unidadMinima = int.Parse(textBoxUnidadMinimaIngrediente.Text);

                TiposIngredientes tipoIngrediente = (TiposIngredientes)comboBoxTipoIngrediente.SelectedItem;

                Resultado resultado = new Resultado();

                if (tipoIngrediente is TiposIngredientes.Bebida)
                {
                    TiposBebidas tipoBebida = (TiposBebidas)comboBoxTipoBebida.SelectedItem;
                    Bebida nuevaBebida = new Bebida(GetCodigoCorrespondiente(), nombre, tipoIngrediente, cantidad, precioPorUnidad, unidadMinima, tipoBebida);
                    resultado = administradorIngredientes.CargarModificarIngrediente(nuevaBebida);
                } else
                {
                    Solido nuevoSolido = new Solido(GetCodigoCorrespondiente(), nombre, tipoIngrediente, cantidad, precioPorUnidad, unidadMinima);
                    resultado = administradorIngredientes.CargarModificarIngrediente(nuevoSolido);
                }

                if (resultado.Ok == false)
                {
                    MessageBox.Show(resultado.Mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    IActualizarGrillaIngredientes padre = this.Owner as IActualizarGrillaIngredientes;
                    if (padre != null)
                    {
                        padre.CargarGrillaIngredientes();
                    }
                    this.Close();
                } 
            }
        }

        private bool EstaEditando()
        {
            return this.Codigo == 0 ? false : true;
        }

        private int GetCodigoCorrespondiente()
        {
            AdministradorIngredientes admin = new AdministradorIngredientes();

            int codigo = 0;

            if (EstaEditando())
            {
                codigo = this.Codigo;
            } else
            {
                codigo = admin.GetNuevoCodigo();
            }
            return codigo;
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

            comboBoxTipoIngrediente.SelectedItem = ingredienteAEditar.TipoIngrediente;

            if (ingredienteAEditar.TipoIngrediente is TiposIngredientes.Bebida)
            {
                comboBoxTipoBebida.SelectedItem = (ingredienteAEditar as Bebida).TipoBebida;
            }
        }
    }
}
