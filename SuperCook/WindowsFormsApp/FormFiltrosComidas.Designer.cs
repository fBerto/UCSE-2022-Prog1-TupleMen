namespace WindowsFormsApp
{
    partial class FormFiltrosComidas
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
            this.botonConfirmarFiltrosComidas = new System.Windows.Forms.Button();
            this.checkBoxFiltroSaludable = new System.Windows.Forms.CheckBox();
            this.checkBoxFiltroPorReceta = new System.Windows.Forms.CheckBox();
            this.checkBoxFiltroPorFecha = new System.Windows.Forms.CheckBox();
            this.checkBoxFiltroPorMomentoComida = new System.Windows.Forms.CheckBox();
            this.dateTimeFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.grillaSeleccionRecetas = new System.Windows.Forms.DataGridView();
            this.Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsSaludable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MomentoComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxFiltroMomentoComida = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltroSaludable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // botonConfirmarFiltrosComidas
            // 
            this.botonConfirmarFiltrosComidas.Location = new System.Drawing.Point(212, 457);
            this.botonConfirmarFiltrosComidas.Name = "botonConfirmarFiltrosComidas";
            this.botonConfirmarFiltrosComidas.Size = new System.Drawing.Size(75, 23);
            this.botonConfirmarFiltrosComidas.TabIndex = 0;
            this.botonConfirmarFiltrosComidas.Text = "Aceptar";
            this.botonConfirmarFiltrosComidas.UseVisualStyleBackColor = true;
            this.botonConfirmarFiltrosComidas.Click += new System.EventHandler(this.botonConfirmarFiltrosComidas_Click);
            // 
            // checkBoxFiltroSaludable
            // 
            this.checkBoxFiltroSaludable.AutoSize = true;
            this.checkBoxFiltroSaludable.Location = new System.Drawing.Point(12, 27);
            this.checkBoxFiltroSaludable.Name = "checkBoxFiltroSaludable";
            this.checkBoxFiltroSaludable.Size = new System.Drawing.Size(92, 17);
            this.checkBoxFiltroSaludable.TabIndex = 1;
            this.checkBoxFiltroSaludable.Text = "Por Saludable";
            this.checkBoxFiltroSaludable.UseVisualStyleBackColor = true;
            this.checkBoxFiltroSaludable.CheckedChanged += new System.EventHandler(this.checkBoxFiltroSaludable_CheckedChanged);
            // 
            // checkBoxFiltroPorReceta
            // 
            this.checkBoxFiltroPorReceta.AutoSize = true;
            this.checkBoxFiltroPorReceta.Location = new System.Drawing.Point(12, 186);
            this.checkBoxFiltroPorReceta.Name = "checkBoxFiltroPorReceta";
            this.checkBoxFiltroPorReceta.Size = new System.Drawing.Size(80, 17);
            this.checkBoxFiltroPorReceta.TabIndex = 2;
            this.checkBoxFiltroPorReceta.Text = "Por Receta";
            this.checkBoxFiltroPorReceta.UseVisualStyleBackColor = true;
            this.checkBoxFiltroPorReceta.CheckedChanged += new System.EventHandler(this.checkBoxFiltroPorReceta_CheckedChanged);
            // 
            // checkBoxFiltroPorFecha
            // 
            this.checkBoxFiltroPorFecha.AutoSize = true;
            this.checkBoxFiltroPorFecha.Location = new System.Drawing.Point(12, 99);
            this.checkBoxFiltroPorFecha.Name = "checkBoxFiltroPorFecha";
            this.checkBoxFiltroPorFecha.Size = new System.Drawing.Size(75, 17);
            this.checkBoxFiltroPorFecha.TabIndex = 3;
            this.checkBoxFiltroPorFecha.Text = "Por Fecha";
            this.checkBoxFiltroPorFecha.UseVisualStyleBackColor = true;
            this.checkBoxFiltroPorFecha.CheckedChanged += new System.EventHandler(this.checkBoxFiltroPorFecha_CheckedChanged);
            // 
            // checkBoxFiltroPorMomentoComida
            // 
            this.checkBoxFiltroPorMomentoComida.AutoSize = true;
            this.checkBoxFiltroPorMomentoComida.Location = new System.Drawing.Point(271, 27);
            this.checkBoxFiltroPorMomentoComida.Name = "checkBoxFiltroPorMomentoComida";
            this.checkBoxFiltroPorMomentoComida.Size = new System.Drawing.Size(142, 17);
            this.checkBoxFiltroPorMomentoComida.TabIndex = 4;
            this.checkBoxFiltroPorMomentoComida.Text = "Por Momento de Comida";
            this.checkBoxFiltroPorMomentoComida.UseVisualStyleBackColor = true;
            this.checkBoxFiltroPorMomentoComida.CheckedChanged += new System.EventHandler(this.checkBoxFiltroPorMomentoComida_CheckedChanged);
            // 
            // dateTimeFechaInicial
            // 
            this.dateTimeFechaInicial.Location = new System.Drawing.Point(12, 138);
            this.dateTimeFechaInicial.Name = "dateTimeFechaInicial";
            this.dateTimeFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaInicial.TabIndex = 5;
            // 
            // dateTimeFechaFinal
            // 
            this.dateTimeFechaFinal.Location = new System.Drawing.Point(271, 138);
            this.dateTimeFechaFinal.Name = "dateTimeFechaFinal";
            this.dateTimeFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaFinal.TabIndex = 6;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(12, 119);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(67, 13);
            this.lblFechaInicial.TabIndex = 7;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(268, 119);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lblFechaFinal.TabIndex = 8;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // grillaSeleccionRecetas
            // 
            this.grillaSeleccionRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSeleccionRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Receta,
            this.EsSaludable,
            this.MomentoComida});
            this.grillaSeleccionRecetas.Location = new System.Drawing.Point(12, 209);
            this.grillaSeleccionRecetas.MultiSelect = false;
            this.grillaSeleccionRecetas.Name = "grillaSeleccionRecetas";
            this.grillaSeleccionRecetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaSeleccionRecetas.Size = new System.Drawing.Size(459, 232);
            this.grillaSeleccionRecetas.TabIndex = 11;
            // 
            // Receta
            // 
            this.Receta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Receta.DataPropertyName = "Nombre";
            this.Receta.HeaderText = "Nombre";
            this.Receta.Name = "Receta";
            // 
            // EsSaludable
            // 
            this.EsSaludable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EsSaludable.DataPropertyName = "EsSaludable";
            this.EsSaludable.HeaderText = "Es Saludable?";
            this.EsSaludable.Name = "EsSaludable";
            // 
            // MomentoComida
            // 
            this.MomentoComida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MomentoComida.DataPropertyName = "MomentoComida";
            this.MomentoComida.HeaderText = "Momento del Dia";
            this.MomentoComida.Name = "MomentoComida";
            // 
            // comboBoxFiltroMomentoComida
            // 
            this.comboBoxFiltroMomentoComida.FormattingEnabled = true;
            this.comboBoxFiltroMomentoComida.Location = new System.Drawing.Point(271, 50);
            this.comboBoxFiltroMomentoComida.Name = "comboBoxFiltroMomentoComida";
            this.comboBoxFiltroMomentoComida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroMomentoComida.TabIndex = 12;
            // 
            // comboBoxFiltroSaludable
            // 
            this.comboBoxFiltroSaludable.FormattingEnabled = true;
            this.comboBoxFiltroSaludable.Items.AddRange(new object[] {
            "Saludables",
            "NO Saludables"});
            this.comboBoxFiltroSaludable.Location = new System.Drawing.Point(12, 50);
            this.comboBoxFiltroSaludable.Name = "comboBoxFiltroSaludable";
            this.comboBoxFiltroSaludable.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroSaludable.TabIndex = 9;
            // 
            // FormFiltrosComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 492);
            this.Controls.Add(this.comboBoxFiltroMomentoComida);
            this.Controls.Add(this.grillaSeleccionRecetas);
            this.Controls.Add(this.comboBoxFiltroSaludable);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.dateTimeFechaFinal);
            this.Controls.Add(this.dateTimeFechaInicial);
            this.Controls.Add(this.checkBoxFiltroPorMomentoComida);
            this.Controls.Add(this.checkBoxFiltroPorFecha);
            this.Controls.Add(this.checkBoxFiltroPorReceta);
            this.Controls.Add(this.checkBoxFiltroSaludable);
            this.Controls.Add(this.botonConfirmarFiltrosComidas);
            this.Name = "FormFiltrosComidas";
            this.Text = "FiltrosComidas";
            this.Load += new System.EventHandler(this.FormFiltrosComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmarFiltrosComidas;
        private System.Windows.Forms.CheckBox checkBoxFiltroSaludable;
        private System.Windows.Forms.CheckBox checkBoxFiltroPorReceta;
        private System.Windows.Forms.CheckBox checkBoxFiltroPorFecha;
        private System.Windows.Forms.CheckBox checkBoxFiltroPorMomentoComida;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicial;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFinal;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DataGridView grillaSeleccionRecetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsSaludable;
        private System.Windows.Forms.DataGridViewTextBoxColumn MomentoComida;
        private System.Windows.Forms.ComboBox comboBoxFiltroMomentoComida;
        private System.Windows.Forms.ComboBox comboBoxFiltroSaludable;
    }
}