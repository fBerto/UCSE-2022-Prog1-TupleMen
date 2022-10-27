namespace WindowsFormsApp
{
    partial class FormCargaIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargaIngredientes));
            this.textBoxNombreIngrediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxPrecioPorUnidadIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxUnidadMinimaIngrediente = new System.Windows.Forms.TextBox();
            this.comboBoxTipoIngrediente = new System.Windows.Forms.ComboBox();
            this.BotonConfirmarCargaIngredientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNombreIngrediente
            // 
            this.textBoxNombreIngrediente.Location = new System.Drawing.Point(15, 42);
            this.textBoxNombreIngrediente.Name = "textBoxNombreIngrediente";
            this.textBoxNombreIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreIngrediente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio Por Unidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Unidad Minima";
            // 
            // textBoxCantidadIngrediente
            // 
            this.textBoxCantidadIngrediente.Location = new System.Drawing.Point(15, 93);
            this.textBoxCantidadIngrediente.Name = "textBoxCantidadIngrediente";
            this.textBoxCantidadIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidadIngrediente.TabIndex = 6;
            // 
            // textBoxPrecioPorUnidadIngrediente
            // 
            this.textBoxPrecioPorUnidadIngrediente.Location = new System.Drawing.Point(155, 93);
            this.textBoxPrecioPorUnidadIngrediente.Name = "textBoxPrecioPorUnidadIngrediente";
            this.textBoxPrecioPorUnidadIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioPorUnidadIngrediente.TabIndex = 7;
            // 
            // textBoxUnidadMinimaIngrediente
            // 
            this.textBoxUnidadMinimaIngrediente.Location = new System.Drawing.Point(155, 42);
            this.textBoxUnidadMinimaIngrediente.Name = "textBoxUnidadMinimaIngrediente";
            this.textBoxUnidadMinimaIngrediente.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnidadMinimaIngrediente.TabIndex = 8;
            // 
            // comboBoxTipoIngrediente
            // 
            this.comboBoxTipoIngrediente.AutoCompleteCustomSource.AddRange(new string[] {
            "Carnes"});
            this.comboBoxTipoIngrediente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxTipoIngrediente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTipoIngrediente.FormattingEnabled = true;
            this.comboBoxTipoIngrediente.Location = new System.Drawing.Point(89, 134);
            this.comboBoxTipoIngrediente.Name = "comboBoxTipoIngrediente";
            this.comboBoxTipoIngrediente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoIngrediente.TabIndex = 10;
            // 
            // BotonConfirmarCargaIngredientes
            // 
            this.BotonConfirmarCargaIngredientes.Location = new System.Drawing.Point(101, 176);
            this.BotonConfirmarCargaIngredientes.Name = "BotonConfirmarCargaIngredientes";
            this.BotonConfirmarCargaIngredientes.Size = new System.Drawing.Size(75, 23);
            this.BotonConfirmarCargaIngredientes.TabIndex = 11;
            this.BotonConfirmarCargaIngredientes.Text = "Aceptar";
            this.BotonConfirmarCargaIngredientes.UseVisualStyleBackColor = true;
            this.BotonConfirmarCargaIngredientes.Click += new System.EventHandler(this.BotonConfirmarCargaIngredientes_Click);
            // 
            // FormCargaIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.BotonConfirmarCargaIngredientes);
            this.Controls.Add(this.comboBoxTipoIngrediente);
            this.Controls.Add(this.textBoxUnidadMinimaIngrediente);
            this.Controls.Add(this.textBoxPrecioPorUnidadIngrediente);
            this.Controls.Add(this.textBoxCantidadIngrediente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombreIngrediente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargaIngredientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carga de Ingredientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombreIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCantidadIngrediente;
        private System.Windows.Forms.TextBox textBoxPrecioPorUnidadIngrediente;
        private System.Windows.Forms.TextBox textBoxUnidadMinimaIngrediente;
        private System.Windows.Forms.ComboBox comboBoxTipoIngrediente;
        private System.Windows.Forms.Button BotonConfirmarCargaIngredientes;
    }
}