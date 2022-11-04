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
            this.buttonConfirmarIngredientesSeleccionados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grillaSeleccionarIngredientes = new System.Windows.Forms.DataGridView();
            this.CodigoIngredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.FinalizarCargaRecetas = new System.Windows.Forms.Button();
            this.grillaIngredientesSeleccionados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.administradorRecetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMomentosComida = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionarIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaIngredientesSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorRecetasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // checkBoxRecetaSaludable
            // 
            this.checkBoxRecetaSaludable.AutoSize = true;
            this.checkBoxRecetaSaludable.Location = new System.Drawing.Point(466, 195);
            this.checkBoxRecetaSaludable.Name = "checkBoxRecetaSaludable";
            this.checkBoxRecetaSaludable.Size = new System.Drawing.Size(73, 17);
            this.checkBoxRecetaSaludable.TabIndex = 2;
            this.checkBoxRecetaSaludable.Text = "Saludable";
            this.checkBoxRecetaSaludable.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreRecetas
            // 
            this.textBoxNombreRecetas.Location = new System.Drawing.Point(466, 76);
            this.textBoxNombreRecetas.Name = "textBoxNombreRecetas";
            this.textBoxNombreRecetas.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreRecetas.TabIndex = 3;
            // 
            // buttonConfirmarIngredientesSeleccionados
            // 
            this.buttonConfirmarIngredientesSeleccionados.Location = new System.Drawing.Point(47, 318);
            this.buttonConfirmarIngredientesSeleccionados.Name = "buttonConfirmarIngredientesSeleccionados";
            this.buttonConfirmarIngredientesSeleccionados.Size = new System.Drawing.Size(263, 23);
            this.buttonConfirmarIngredientesSeleccionados.TabIndex = 5;
            this.buttonConfirmarIngredientesSeleccionados.Text = "Confirmar Ingredientes para receta";
            this.buttonConfirmarIngredientesSeleccionados.UseVisualStyleBackColor = true;
            this.buttonConfirmarIngredientesSeleccionados.Click += new System.EventHandler(this.buttonConfirmarIngredientesSeleccionados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Momento de la comida";
            // 
            // grillaSeleccionarIngredientes
            // 
            this.grillaSeleccionarIngredientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grillaSeleccionarIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSeleccionarIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoIngredientes,
            this.Nombre_Ingrediente,
            this.Check});
            this.grillaSeleccionarIngredientes.Location = new System.Drawing.Point(20, 25);
            this.grillaSeleccionarIngredientes.Name = "grillaSeleccionarIngredientes";
            this.grillaSeleccionarIngredientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grillaSeleccionarIngredientes.Size = new System.Drawing.Size(343, 290);
            this.grillaSeleccionarIngredientes.TabIndex = 8;
            // 
            // CodigoIngredientes
            // 
            this.CodigoIngredientes.DataPropertyName = "Codigo";
            this.CodigoIngredientes.HeaderText = "Codigo";
            this.CodigoIngredientes.Name = "CodigoIngredientes";
            // 
            // Nombre_Ingrediente
            // 
            this.Nombre_Ingrediente.DataPropertyName = "Nombre";
            this.Nombre_Ingrediente.HeaderText = "Nombre";
            this.Nombre_Ingrediente.Name = "Nombre_Ingrediente";
            // 
            // Check
            // 
            this.Check.FalseValue = "false";
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.TrueValue = "true";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccionar Ingredientes para la Receta";
            // 
            // FinalizarCargaRecetas
            // 
            this.FinalizarCargaRecetas.Location = new System.Drawing.Point(839, 318);
            this.FinalizarCargaRecetas.Name = "FinalizarCargaRecetas";
            this.FinalizarCargaRecetas.Size = new System.Drawing.Size(75, 23);
            this.FinalizarCargaRecetas.TabIndex = 10;
            this.FinalizarCargaRecetas.Text = "Finalizar";
            this.FinalizarCargaRecetas.UseVisualStyleBackColor = true;
            this.FinalizarCargaRecetas.Click += new System.EventHandler(this.FinalizarCargaRecetas_Click);
            // 
            // grillaIngredientesSeleccionados
            // 
            this.grillaIngredientesSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaIngredientesSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Editar});
            this.grillaIngredientesSeleccionados.Location = new System.Drawing.Point(654, 34);
            this.grillaIngredientesSeleccionados.Name = "grillaIngredientesSeleccionados";
            this.grillaIngredientesSeleccionados.Size = new System.Drawing.Size(429, 278);
            this.grillaIngredientesSeleccionados.TabIndex = 11;
            this.grillaIngredientesSeleccionados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarCantidad_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Editar
            // 
            this.Editar.HeaderText = " ";
            this.Editar.LinkColor = System.Drawing.Color.Fuchsia;
            this.Editar.Name = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingresar cantidad por cada ingrediente";
            // 
            // administradorRecetasBindingSource
            // 
            this.administradorRecetasBindingSource.DataSource = typeof(Logica.AdministradorRecetas);
            // 
            // comboBoxMomentosComida
            // 
            this.comboBoxMomentosComida.FormattingEnabled = true;
            this.comboBoxMomentosComida.Location = new System.Drawing.Point(445, 150);
            this.comboBoxMomentosComida.Name = "comboBoxMomentosComida";
            this.comboBoxMomentosComida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMomentosComida.TabIndex = 14;
            // 
            // FormCargaRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 353);
            this.Controls.Add(this.comboBoxMomentosComida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grillaIngredientesSeleccionados);
            this.Controls.Add(this.FinalizarCargaRecetas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grillaSeleccionarIngredientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConfirmarIngredientesSeleccionados);
            this.Controls.Add(this.textBoxNombreRecetas);
            this.Controls.Add(this.checkBoxRecetaSaludable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargaRecetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Recetas";
            this.Load += new System.EventHandler(this.FormCargaRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionarIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaIngredientesSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorRecetasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRecetaSaludable;
        private System.Windows.Forms.TextBox textBoxNombreRecetas;
        private System.Windows.Forms.Button buttonConfirmarIngredientesSeleccionados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grillaSeleccionarIngredientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FinalizarCargaRecetas;
        private System.Windows.Forms.DataGridView grillaIngredientesSeleccionados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource administradorRecetasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoIngredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Ingrediente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.ComboBox comboBoxMomentosComida;
    }
}