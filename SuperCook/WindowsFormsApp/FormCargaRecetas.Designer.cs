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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargaRecetas));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRecetaSaludable = new System.Windows.Forms.CheckBox();
            this.textBoxNombreRecetas = new System.Windows.Forms.TextBox();
            this.buttonAceptarCargaRecetas = new System.Windows.Forms.Button();
            this.comboBoxMomentosComida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grillaCargaRecetas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grillaIngredientesSeleccionados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.administradorRecetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nombre_Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCargaRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaIngredientesSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorRecetasBindingSource)).BeginInit();
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
            this.checkBoxRecetaSaludable.Location = new System.Drawing.Point(26, 122);
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
            this.buttonAceptarCargaRecetas.Location = new System.Drawing.Point(224, 318);
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
            this.comboBoxMomentosComida.SelectionChangeCommitted += new System.EventHandler(this.FormCargaRecetas_Load);
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
            // grillaCargaRecetas
            // 
            this.grillaCargaRecetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grillaCargaRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCargaRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Ingrediente});
            this.grillaCargaRecetas.Location = new System.Drawing.Point(198, 25);
            this.grillaCargaRecetas.Name = "grillaCargaRecetas";
            this.grillaCargaRecetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grillaCargaRecetas.Size = new System.Drawing.Size(127, 290);
            this.grillaCargaRecetas.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccionar Ingredientes para la Receta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grillaIngredientesSeleccionados
            // 
            this.grillaIngredientesSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaIngredientesSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Editar});
            this.grillaIngredientesSeleccionados.Location = new System.Drawing.Point(395, 47);
            this.grillaIngredientesSeleccionados.Name = "grillaIngredientesSeleccionados";
            this.grillaIngredientesSeleccionados.Size = new System.Drawing.Size(413, 150);
            this.grillaIngredientesSeleccionados.TabIndex = 11;
            this.grillaIngredientesSeleccionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingresar cantidad por cada ingrediente";
            // 
            // administradorRecetasBindingSource
            // 
            this.administradorRecetasBindingSource.DataSource = typeof(Logica.AdministradorRecetas);
            // 
            // Nombre_Ingrediente
            // 
            this.Nombre_Ingrediente.DataPropertyName = "Nombre";
            this.Nombre_Ingrediente.HeaderText = "Nombre";
            this.Nombre_Ingrediente.Name = "Nombre_Ingrediente";
            // 
            // FormCargaRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grillaIngredientesSeleccionados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grillaCargaRecetas);
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
            this.Load += new System.EventHandler(this.FormCargaRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCargaRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaIngredientesSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorRecetasBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView grillaCargaRecetas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grillaIngredientesSeleccionados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.BindingSource administradorRecetasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Ingrediente;
    }
}