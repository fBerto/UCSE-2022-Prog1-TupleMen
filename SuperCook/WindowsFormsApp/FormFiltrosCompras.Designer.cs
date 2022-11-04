namespace WindowsFormsApp
{
    partial class FormFiltrosCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxFiltroTipoIngrediente = new System.Windows.Forms.CheckBox();
            this.checkBoxFiltroPorCosto = new System.Windows.Forms.CheckBox();
            this.checkBoxFiltroEscasez = new System.Windows.Forms.CheckBox();
            this.checkBoxFiltroPorUnidadDeMedida = new System.Windows.Forms.CheckBox();
            this.comboBoxFiltroUnidadMedida = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltroEscasez = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltroTipoIngrediente = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltroTipoBebida = new System.Windows.Forms.ComboBox();
            this.textBoxCostoIngresado = new System.Windows.Forms.TextBox();
            this.groupBoxCostoMinimoMaximo = new System.Windows.Forms.GroupBox();
            this.radioButtonCostoMaximo = new System.Windows.Forms.RadioButton();
            this.radioButtonCostoMinimo = new System.Windows.Forms.RadioButton();
            this.checkBoxFiltroTipoBebida = new System.Windows.Forms.CheckBox();
            this.botonConfirmarFiltrosCompras = new System.Windows.Forms.Button();
            this.groupBoxCostoMinimoMaximo.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxFiltroTipoIngrediente
            // 
            this.checkBoxFiltroTipoIngrediente.AutoSize = true;
            this.checkBoxFiltroTipoIngrediente.Location = new System.Drawing.Point(12, 78);
            this.checkBoxFiltroTipoIngrediente.Name = "checkBoxFiltroTipoIngrediente";
            this.checkBoxFiltroTipoIngrediente.Size = new System.Drawing.Size(137, 17);
            this.checkBoxFiltroTipoIngrediente.TabIndex = 0;
            this.checkBoxFiltroTipoIngrediente.Text = "Por Tipo de Ingrediente";
            this.checkBoxFiltroTipoIngrediente.UseVisualStyleBackColor = true;
            this.checkBoxFiltroTipoIngrediente.CheckedChanged += new System.EventHandler(this.checkBoxFiltroTipoIngrediente_CheckedChanged);
            // 
            // checkBoxFiltroPorCosto
            // 
            this.checkBoxFiltroPorCosto.AutoSize = true;
            this.checkBoxFiltroPorCosto.Location = new System.Drawing.Point(198, 78);
            this.checkBoxFiltroPorCosto.Name = "checkBoxFiltroPorCosto";
            this.checkBoxFiltroPorCosto.Size = new System.Drawing.Size(72, 17);
            this.checkBoxFiltroPorCosto.TabIndex = 1;
            this.checkBoxFiltroPorCosto.Text = "Por Costo";
            this.checkBoxFiltroPorCosto.UseVisualStyleBackColor = true;
            this.checkBoxFiltroPorCosto.CheckedChanged += new System.EventHandler(this.checkBoxFiltroPorPrecio_CheckedChanged);
            // 
            // checkBoxFiltroEscasez
            // 
            this.checkBoxFiltroEscasez.AutoSize = true;
            this.checkBoxFiltroEscasez.Location = new System.Drawing.Point(198, 12);
            this.checkBoxFiltroEscasez.Name = "checkBoxFiltroEscasez";
            this.checkBoxFiltroEscasez.Size = new System.Drawing.Size(85, 17);
            this.checkBoxFiltroEscasez.TabIndex = 2;
            this.checkBoxFiltroEscasez.Text = "Por Escasez";
            this.checkBoxFiltroEscasez.UseVisualStyleBackColor = true;
            this.checkBoxFiltroEscasez.CheckedChanged += new System.EventHandler(this.checkBoxFiltroEscasez_CheckedChanged);
            // 
            // checkBoxFiltroPorUnidadDeMedida
            // 
            this.checkBoxFiltroPorUnidadDeMedida.AutoSize = true;
            this.checkBoxFiltroPorUnidadDeMedida.Location = new System.Drawing.Point(12, 12);
            this.checkBoxFiltroPorUnidadDeMedida.Name = "checkBoxFiltroPorUnidadDeMedida";
            this.checkBoxFiltroPorUnidadDeMedida.Size = new System.Drawing.Size(132, 17);
            this.checkBoxFiltroPorUnidadDeMedida.TabIndex = 3;
            this.checkBoxFiltroPorUnidadDeMedida.Text = "Por Unidad de Medida";
            this.checkBoxFiltroPorUnidadDeMedida.UseVisualStyleBackColor = true;
            this.checkBoxFiltroPorUnidadDeMedida.CheckedChanged += new System.EventHandler(this.checkBoxFiltroPorUnidadDeMedida_CheckedChanged);
            // 
            // comboBoxFiltroUnidadMedida
            // 
            this.comboBoxFiltroUnidadMedida.FormattingEnabled = true;
            this.comboBoxFiltroUnidadMedida.Location = new System.Drawing.Point(12, 35);
            this.comboBoxFiltroUnidadMedida.Name = "comboBoxFiltroUnidadMedida";
            this.comboBoxFiltroUnidadMedida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroUnidadMedida.TabIndex = 4;
            // 
            // comboBoxFiltroEscasez
            // 
            this.comboBoxFiltroEscasez.FormattingEnabled = true;
            this.comboBoxFiltroEscasez.Location = new System.Drawing.Point(195, 35);
            this.comboBoxFiltroEscasez.Name = "comboBoxFiltroEscasez";
            this.comboBoxFiltroEscasez.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroEscasez.TabIndex = 5;
            // 
            // comboBoxFiltroTipoIngrediente
            // 
            this.comboBoxFiltroTipoIngrediente.FormattingEnabled = true;
            this.comboBoxFiltroTipoIngrediente.Location = new System.Drawing.Point(12, 102);
            this.comboBoxFiltroTipoIngrediente.Name = "comboBoxFiltroTipoIngrediente";
            this.comboBoxFiltroTipoIngrediente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroTipoIngrediente.TabIndex = 6;
            this.comboBoxFiltroTipoIngrediente.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFiltroTipoIngrediente_SelectionChangeCommitted);
            // 
            // comboBoxFiltroTipoBebida
            // 
            this.comboBoxFiltroTipoBebida.FormattingEnabled = true;
            this.comboBoxFiltroTipoBebida.Location = new System.Drawing.Point(12, 168);
            this.comboBoxFiltroTipoBebida.Name = "comboBoxFiltroTipoBebida";
            this.comboBoxFiltroTipoBebida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroTipoBebida.TabIndex = 7;
            // 
            // textBoxCostoIngresado
            // 
            this.textBoxCostoIngresado.Location = new System.Drawing.Point(195, 178);
            this.textBoxCostoIngresado.Name = "textBoxCostoIngresado";
            this.textBoxCostoIngresado.Size = new System.Drawing.Size(100, 20);
            this.textBoxCostoIngresado.TabIndex = 8;
            // 
            // groupBoxCostoMinimoMaximo
            // 
            this.groupBoxCostoMinimoMaximo.Controls.Add(this.radioButtonCostoMaximo);
            this.groupBoxCostoMinimoMaximo.Controls.Add(this.radioButtonCostoMinimo);
            this.groupBoxCostoMinimoMaximo.Location = new System.Drawing.Point(198, 101);
            this.groupBoxCostoMinimoMaximo.Name = "groupBoxCostoMinimoMaximo";
            this.groupBoxCostoMinimoMaximo.Size = new System.Drawing.Size(97, 71);
            this.groupBoxCostoMinimoMaximo.TabIndex = 9;
            this.groupBoxCostoMinimoMaximo.TabStop = false;
            this.groupBoxCostoMinimoMaximo.Text = "Inserte el costo";
            // 
            // radioButtonCostoMaximo
            // 
            this.radioButtonCostoMaximo.AutoSize = true;
            this.radioButtonCostoMaximo.Location = new System.Drawing.Point(7, 44);
            this.radioButtonCostoMaximo.Name = "radioButtonCostoMaximo";
            this.radioButtonCostoMaximo.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCostoMaximo.TabIndex = 1;
            this.radioButtonCostoMaximo.TabStop = true;
            this.radioButtonCostoMaximo.Text = "Maximo";
            this.radioButtonCostoMaximo.UseVisualStyleBackColor = true;
            // 
            // radioButtonCostoMinimo
            // 
            this.radioButtonCostoMinimo.AutoSize = true;
            this.radioButtonCostoMinimo.Location = new System.Drawing.Point(7, 20);
            this.radioButtonCostoMinimo.Name = "radioButtonCostoMinimo";
            this.radioButtonCostoMinimo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCostoMinimo.TabIndex = 0;
            this.radioButtonCostoMinimo.TabStop = true;
            this.radioButtonCostoMinimo.Text = "Minimo";
            this.radioButtonCostoMinimo.UseVisualStyleBackColor = true;
            // 
            // checkBoxFiltroTipoBebida
            // 
            this.checkBoxFiltroTipoBebida.AutoSize = true;
            this.checkBoxFiltroTipoBebida.Location = new System.Drawing.Point(12, 145);
            this.checkBoxFiltroTipoBebida.Name = "checkBoxFiltroTipoBebida";
            this.checkBoxFiltroTipoBebida.Size = new System.Drawing.Size(117, 17);
            this.checkBoxFiltroTipoBebida.TabIndex = 10;
            this.checkBoxFiltroTipoBebida.Text = "Por Tipo de Bebida";
            this.checkBoxFiltroTipoBebida.UseVisualStyleBackColor = true;
            this.checkBoxFiltroTipoBebida.CheckedChanged += new System.EventHandler(this.checkBoxFiltroTipoBebida_CheckedChanged);
            // 
            // botonConfirmarFiltrosCompras
            // 
            this.botonConfirmarFiltrosCompras.Location = new System.Drawing.Point(128, 224);
            this.botonConfirmarFiltrosCompras.Name = "botonConfirmarFiltrosCompras";
            this.botonConfirmarFiltrosCompras.Size = new System.Drawing.Size(75, 23);
            this.botonConfirmarFiltrosCompras.TabIndex = 11;
            this.botonConfirmarFiltrosCompras.Text = "Aceptar";
            this.botonConfirmarFiltrosCompras.UseVisualStyleBackColor = true;
            this.botonConfirmarFiltrosCompras.Click += new System.EventHandler(this.botonConfirmarFiltrosCompras_Click);
            // 
            // FormFiltrosCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 259);
            this.Controls.Add(this.botonConfirmarFiltrosCompras);
            this.Controls.Add(this.checkBoxFiltroTipoBebida);
            this.Controls.Add(this.groupBoxCostoMinimoMaximo);
            this.Controls.Add(this.textBoxCostoIngresado);
            this.Controls.Add(this.comboBoxFiltroTipoBebida);
            this.Controls.Add(this.comboBoxFiltroTipoIngrediente);
            this.Controls.Add(this.comboBoxFiltroEscasez);
            this.Controls.Add(this.comboBoxFiltroUnidadMedida);
            this.Controls.Add(this.checkBoxFiltroPorUnidadDeMedida);
            this.Controls.Add(this.checkBoxFiltroEscasez);
            this.Controls.Add(this.checkBoxFiltroPorCosto);
            this.Controls.Add(this.checkBoxFiltroTipoIngrediente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormFiltrosCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFiltrosCompras";
            this.Load += new System.EventHandler(this.FormFiltrosCompras_Load);
            this.groupBoxCostoMinimoMaximo.ResumeLayout(false);
            this.groupBoxCostoMinimoMaximo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFiltroTipoIngrediente;
        private System.Windows.Forms.CheckBox checkBoxFiltroPorCosto;
        private System.Windows.Forms.CheckBox checkBoxFiltroEscasez;
        private System.Windows.Forms.CheckBox checkBoxFiltroPorUnidadDeMedida;
        private System.Windows.Forms.ComboBox comboBoxFiltroUnidadMedida;
        private System.Windows.Forms.ComboBox comboBoxFiltroEscasez;
        private System.Windows.Forms.ComboBox comboBoxFiltroTipoIngrediente;
        private System.Windows.Forms.ComboBox comboBoxFiltroTipoBebida;
        private System.Windows.Forms.TextBox textBoxCostoIngresado;
        private System.Windows.Forms.GroupBox groupBoxCostoMinimoMaximo;
        private System.Windows.Forms.RadioButton radioButtonCostoMaximo;
        private System.Windows.Forms.RadioButton radioButtonCostoMinimo;
        private System.Windows.Forms.CheckBox checkBoxFiltroTipoBebida;
        private System.Windows.Forms.Button botonConfirmarFiltrosCompras;
    }
}