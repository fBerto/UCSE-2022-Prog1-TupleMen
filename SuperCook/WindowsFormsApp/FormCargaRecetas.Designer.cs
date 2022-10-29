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
            this.comboBoxMomentosComida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // comboBoxMomentosComida
            // 
            this.comboBoxMomentosComida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxMomentosComida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMomentosComida.FormattingEnabled = true;
            this.comboBoxMomentosComida.Location = new System.Drawing.Point(26, 82);
            this.comboBoxMomentosComida.Name = "comboBoxMomentosComida";
            this.comboBoxMomentosComida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMomentosComida.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Momento de la comida";
            // 
            // FormCargaRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMomentosComida);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRecetaSaludable;
        private System.Windows.Forms.TextBox textBoxNombreRecetas;
        private System.Windows.Forms.Button buttonAceptarCargaRecetas;
        private System.Windows.Forms.ComboBox comboBoxMomentosComida;
        private System.Windows.Forms.Label label2;
    }
}