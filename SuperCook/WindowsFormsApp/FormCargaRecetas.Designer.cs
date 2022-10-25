namespace WindowsFormsApp
{
    partial class FormCargaRecetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargaRecetas));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRecetaSaludable = new System.Windows.Forms.CheckBox();
            this.textBoxNombreRecetas = new System.Windows.Forms.TextBox();
            this.buttonAceptarCargaRecetas = new System.Windows.Forms.Button();
            this.radioButtonDesayuno = new System.Windows.Forms.RadioButton();
            this.radioButtonAlmuerzo = new System.Windows.Forms.RadioButton();
            this.radioButtonMerienda = new System.Windows.Forms.RadioButton();
            this.radioButtonCena = new System.Windows.Forms.RadioButton();
            this.groupBoxMomentoComida = new System.Windows.Forms.GroupBox();
            this.groupBoxMomentoComida.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // checkBoxRecetaSaludable
            // 
            this.checkBoxRecetaSaludable.AutoSize = true;
            this.checkBoxRecetaSaludable.Location = new System.Drawing.Point(182, 25);
            this.checkBoxRecetaSaludable.Name = "checkBoxRecetaSaludable";
            this.checkBoxRecetaSaludable.Size = new System.Drawing.Size(73, 17);
            this.checkBoxRecetaSaludable.TabIndex = 2;
            this.checkBoxRecetaSaludable.Text = "Saludable";
            this.checkBoxRecetaSaludable.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreRecetas
            // 
            this.textBoxNombreRecetas.Location = new System.Drawing.Point(26, 25);
            this.textBoxNombreRecetas.Name = "textBoxNombreRecetas";
            this.textBoxNombreRecetas.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreRecetas.TabIndex = 3;
            // 
            // buttonAceptarCargaRecetas
            // 
            this.buttonAceptarCargaRecetas.Location = new System.Drawing.Point(104, 176);
            this.buttonAceptarCargaRecetas.Name = "buttonAceptarCargaRecetas";
            this.buttonAceptarCargaRecetas.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptarCargaRecetas.TabIndex = 5;
            this.buttonAceptarCargaRecetas.Text = "Aceptar";
            this.buttonAceptarCargaRecetas.UseVisualStyleBackColor = true;
            this.buttonAceptarCargaRecetas.Click += new System.EventHandler(this.buttonAceptarCargaRecetas_Click);
            // 
            // radioButtonDesayuno
            // 
            this.radioButtonDesayuno.AutoSize = true;
            this.radioButtonDesayuno.Checked = true;
            this.radioButtonDesayuno.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDesayuno.Name = "radioButtonDesayuno";
            this.radioButtonDesayuno.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDesayuno.TabIndex = 6;
            this.radioButtonDesayuno.TabStop = true;
            this.radioButtonDesayuno.Text = "Desayuno";
            this.radioButtonDesayuno.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlmuerzo
            // 
            this.radioButtonAlmuerzo.AutoSize = true;
            this.radioButtonAlmuerzo.Location = new System.Drawing.Point(6, 42);
            this.radioButtonAlmuerzo.Name = "radioButtonAlmuerzo";
            this.radioButtonAlmuerzo.Size = new System.Drawing.Size(68, 17);
            this.radioButtonAlmuerzo.TabIndex = 7;
            this.radioButtonAlmuerzo.Text = "Almuerzo";
            this.radioButtonAlmuerzo.UseVisualStyleBackColor = true;
            // 
            // radioButtonMerienda
            // 
            this.radioButtonMerienda.AutoSize = true;
            this.radioButtonMerienda.Location = new System.Drawing.Point(6, 65);
            this.radioButtonMerienda.Name = "radioButtonMerienda";
            this.radioButtonMerienda.Size = new System.Drawing.Size(69, 17);
            this.radioButtonMerienda.TabIndex = 8;
            this.radioButtonMerienda.Text = "Merienda";
            this.radioButtonMerienda.UseVisualStyleBackColor = true;
            // 
            // radioButtonCena
            // 
            this.radioButtonCena.AutoSize = true;
            this.radioButtonCena.Location = new System.Drawing.Point(6, 89);
            this.radioButtonCena.Name = "radioButtonCena";
            this.radioButtonCena.Size = new System.Drawing.Size(50, 17);
            this.radioButtonCena.TabIndex = 9;
            this.radioButtonCena.Text = "Cena";
            this.radioButtonCena.UseVisualStyleBackColor = true;
            // 
            // groupBoxMomentoComida
            // 
            this.groupBoxMomentoComida.Controls.Add(this.radioButtonDesayuno);
            this.groupBoxMomentoComida.Controls.Add(this.radioButtonCena);
            this.groupBoxMomentoComida.Controls.Add(this.radioButtonAlmuerzo);
            this.groupBoxMomentoComida.Controls.Add(this.radioButtonMerienda);
            this.groupBoxMomentoComida.Location = new System.Drawing.Point(88, 58);
            this.groupBoxMomentoComida.Name = "groupBoxMomentoComida";
            this.groupBoxMomentoComida.Size = new System.Drawing.Size(105, 112);
            this.groupBoxMomentoComida.TabIndex = 10;
            this.groupBoxMomentoComida.TabStop = false;
            this.groupBoxMomentoComida.Text = "Momento Comida";
            // 
            // FormCargaRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.groupBoxMomentoComida);
            this.Controls.Add(this.buttonAceptarCargaRecetas);
            this.Controls.Add(this.textBoxNombreRecetas);
            this.Controls.Add(this.checkBoxRecetaSaludable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargaRecetas";
            this.Text = "Carga de Recetas";
            this.groupBoxMomentoComida.ResumeLayout(false);
            this.groupBoxMomentoComida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRecetaSaludable;
        private System.Windows.Forms.TextBox textBoxNombreRecetas;
        private System.Windows.Forms.Button buttonAceptarCargaRecetas;
        private System.Windows.Forms.RadioButton radioButtonDesayuno;
        private System.Windows.Forms.RadioButton radioButtonAlmuerzo;
        private System.Windows.Forms.RadioButton radioButtonMerienda;
        private System.Windows.Forms.RadioButton radioButtonCena;
        private System.Windows.Forms.GroupBox groupBoxMomentoComida;
    }
}