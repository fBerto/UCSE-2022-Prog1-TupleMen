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
            this.groupBoxFiltroSaludable = new System.Windows.Forms.GroupBox();
            this.radioButtonConvencionales = new System.Windows.Forms.RadioButton();
            this.radioButtonSaludables = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionRecetas)).BeginInit();
            this.groupBoxFiltroSaludable.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonConfirmarFiltrosComidas
            // 
            this.botonConfirmarFiltrosComidas.Location = new System.Drawing.Point(265, 630);
            this.botonConfirmarFiltrosComidas.Margin = new System.Windows.Forms.Padding(4);
            this.botonConfirmarFiltrosComidas.Name = "botonConfirmarFiltrosComidas";
            this.botonConfirmarFiltrosComidas.Size = new System.Drawing.Size(100, 28);
            this.botonConfirmarFiltrosComidas.TabIndex = 0;
            this.botonConfirmarFiltrosComidas.Text = "Aceptar";
            this.botonConfirmarFiltrosComidas.UseVisualStyleBackColor = true;
            this.botonConfirmarFiltrosComidas.Click += new System.EventHandler(this.botonConfirmarFiltrosComidas_Click);
            // 
            // checkBoxFiltroSaludable
            // 
            this.checkBoxFiltroSaludable.AutoSize = true;
            this.checkBoxFiltroSaludable.Location = new System.Drawing.Point(16, 33);
            this.checkBoxFiltroSaludable.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFiltroSaludable.Name = "checkBoxFiltroSaludable";
            this.checkBoxFiltroSaludable.Size = new System.Drawing.Size(115, 20);
            this.checkBoxFiltroSaludable.TabIndex = 1;
            this.checkBoxFiltroSaludable.Text = "Por Saludable";
            this.checkBoxFiltroSaludable.UseVisualStyleBackColor = true;
            this.checkBoxFiltroSaludable.CheckedChanged += new System.EventHandler(this.checkBoxFiltroSaludable_CheckedChanged);
            // 
            // checkBoxFiltroPorReceta
            // 
            this.checkBoxFiltroPorReceta.AutoSize = true;
            this.checkBoxFiltroPorReceta.Location = new System.Drawing.Point(16, 295);
            this.checkBoxFiltroPorReceta.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFiltroPorReceta.Name = "checkBoxFiltroPorReceta";
            this.checkBoxFiltroPorReceta.Size = new System.Drawing.Size(97, 20);
            this.checkBoxFiltroPorReceta.TabIndex = 2;
            this.checkBoxFiltroPorReceta.Text = "Por Receta";
            this.checkBoxFiltroPorReceta.UseVisualStyleBackColor = true;
            this.checkBoxFiltroPorReceta.CheckedChanged += new System.EventHandler(this.checkBoxFiltroPorReceta_CheckedChanged);
            // 
            // checkBoxFiltroPorFecha
            // 
            this.checkBoxFiltroPorFecha.AutoSize = true;
            this.checkBoxFiltroPorFecha.Location = new System.Drawing.Point(16, 176);
            this.checkBoxFiltroPorFecha.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFiltroPorFecha.Name = "checkBoxFiltroPorFecha";
            this.checkBoxFiltroPorFecha.Size = new System.Drawing.Size(91, 20);
            this.checkBoxFiltroPorFecha.TabIndex = 3;
            this.checkBoxFiltroPorFecha.Text = "Por Fecha";
            this.checkBoxFiltroPorFecha.UseVisualStyleBackColor = true;
            this.checkBoxFiltroPorFecha.CheckedChanged += new System.EventHandler(this.checkBoxFiltroPorFecha_CheckedChanged);
            // 
            // checkBoxFiltroPorMomentoComida
            // 
            this.checkBoxFiltroPorMomentoComida.AutoSize = true;
            this.checkBoxFiltroPorMomentoComida.Location = new System.Drawing.Point(361, 33);
            this.checkBoxFiltroPorMomentoComida.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFiltroPorMomentoComida.Name = "checkBoxFiltroPorMomentoComida";
            this.checkBoxFiltroPorMomentoComida.Size = new System.Drawing.Size(178, 20);
            this.checkBoxFiltroPorMomentoComida.TabIndex = 4;
            this.checkBoxFiltroPorMomentoComida.Text = "Por Momento de Comida";
            this.checkBoxFiltroPorMomentoComida.UseVisualStyleBackColor = true;
            this.checkBoxFiltroPorMomentoComida.CheckedChanged += new System.EventHandler(this.checkBoxFiltroPorMomentoComida_CheckedChanged);
            // 
            // dateTimeFechaInicial
            // 
            this.dateTimeFechaInicial.CustomFormat = "dd/mm/yyyy";
            this.dateTimeFechaInicial.Location = new System.Drawing.Point(16, 224);
            this.dateTimeFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaInicial.Name = "dateTimeFechaInicial";
            this.dateTimeFechaInicial.Size = new System.Drawing.Size(265, 22);
            this.dateTimeFechaInicial.TabIndex = 5;
            // 
            // dateTimeFechaFinal
            // 
            this.dateTimeFechaFinal.CustomFormat = "dd/mm/yyyy";
            this.dateTimeFechaFinal.Location = new System.Drawing.Point(361, 224);
            this.dateTimeFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFechaFinal.Name = "dateTimeFechaFinal";
            this.dateTimeFechaFinal.Size = new System.Drawing.Size(265, 22);
            this.dateTimeFechaFinal.TabIndex = 6;
            this.dateTimeFechaFinal.ValueChanged += new System.EventHandler(this.dateTimeFechaFinal_ValueChanged);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(16, 201);
            this.lblFechaInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(82, 16);
            this.lblFechaInicial.TabIndex = 7;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(357, 201);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(77, 16);
            this.lblFechaFinal.TabIndex = 8;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // grillaSeleccionRecetas
            // 
            this.grillaSeleccionRecetas.AllowUserToAddRows = false;
            this.grillaSeleccionRecetas.AllowUserToDeleteRows = false;
            this.grillaSeleccionRecetas.AllowUserToResizeColumns = false;
            this.grillaSeleccionRecetas.AllowUserToResizeRows = false;
            this.grillaSeleccionRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSeleccionRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Receta,
            this.EsSaludable,
            this.MomentoComida});
            this.grillaSeleccionRecetas.Location = new System.Drawing.Point(16, 324);
            this.grillaSeleccionRecetas.Margin = new System.Windows.Forms.Padding(4);
            this.grillaSeleccionRecetas.MultiSelect = false;
            this.grillaSeleccionRecetas.Name = "grillaSeleccionRecetas";
            this.grillaSeleccionRecetas.RowHeadersWidth = 51;
            this.grillaSeleccionRecetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaSeleccionRecetas.Size = new System.Drawing.Size(612, 286);
            this.grillaSeleccionRecetas.TabIndex = 11;
            // 
            // Receta
            // 
            this.Receta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Receta.DataPropertyName = "Nombre";
            this.Receta.HeaderText = "Nombre";
            this.Receta.MinimumWidth = 6;
            this.Receta.Name = "Receta";
            // 
            // EsSaludable
            // 
            this.EsSaludable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EsSaludable.DataPropertyName = "EsSaludable";
            this.EsSaludable.HeaderText = "Es Saludable?";
            this.EsSaludable.MinimumWidth = 6;
            this.EsSaludable.Name = "EsSaludable";
            // 
            // MomentoComida
            // 
            this.MomentoComida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MomentoComida.DataPropertyName = "MomentoComida";
            this.MomentoComida.HeaderText = "Momento del Dia";
            this.MomentoComida.MinimumWidth = 6;
            this.MomentoComida.Name = "MomentoComida";
            // 
            // comboBoxFiltroMomentoComida
            // 
            this.comboBoxFiltroMomentoComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroMomentoComida.FormattingEnabled = true;
            this.comboBoxFiltroMomentoComida.Location = new System.Drawing.Point(361, 62);
            this.comboBoxFiltroMomentoComida.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFiltroMomentoComida.Name = "comboBoxFiltroMomentoComida";
            this.comboBoxFiltroMomentoComida.Size = new System.Drawing.Size(160, 24);
            this.comboBoxFiltroMomentoComida.TabIndex = 12;
            // 
            // groupBoxFiltroSaludable
            // 
            this.groupBoxFiltroSaludable.Controls.Add(this.radioButtonConvencionales);
            this.groupBoxFiltroSaludable.Controls.Add(this.radioButtonSaludables);
            this.groupBoxFiltroSaludable.Location = new System.Drawing.Point(16, 63);
            this.groupBoxFiltroSaludable.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFiltroSaludable.Name = "groupBoxFiltroSaludable";
            this.groupBoxFiltroSaludable.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFiltroSaludable.Size = new System.Drawing.Size(139, 90);
            this.groupBoxFiltroSaludable.TabIndex = 13;
            this.groupBoxFiltroSaludable.TabStop = false;
            this.groupBoxFiltroSaludable.Text = "Filtrar...";
            // 
            // radioButtonConvencionales
            // 
            this.radioButtonConvencionales.AutoSize = true;
            this.radioButtonConvencionales.Location = new System.Drawing.Point(9, 54);
            this.radioButtonConvencionales.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonConvencionales.Name = "radioButtonConvencionales";
            this.radioButtonConvencionales.Size = new System.Drawing.Size(125, 20);
            this.radioButtonConvencionales.TabIndex = 1;
            this.radioButtonConvencionales.Text = "Convencionales";
            this.radioButtonConvencionales.UseVisualStyleBackColor = true;
            // 
            // radioButtonSaludables
            // 
            this.radioButtonSaludables.AutoSize = true;
            this.radioButtonSaludables.Checked = true;
            this.radioButtonSaludables.Location = new System.Drawing.Point(9, 25);
            this.radioButtonSaludables.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSaludables.Name = "radioButtonSaludables";
            this.radioButtonSaludables.Size = new System.Drawing.Size(97, 20);
            this.radioButtonSaludables.TabIndex = 0;
            this.radioButtonSaludables.TabStop = true;
            this.radioButtonSaludables.Text = "Saludables";
            this.radioButtonSaludables.UseVisualStyleBackColor = true;
            // 
            // FormFiltrosComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 673);
            this.Controls.Add(this.groupBoxFiltroSaludable);
            this.Controls.Add(this.comboBoxFiltroMomentoComida);
            this.Controls.Add(this.grillaSeleccionRecetas);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.dateTimeFechaFinal);
            this.Controls.Add(this.dateTimeFechaInicial);
            this.Controls.Add(this.checkBoxFiltroPorMomentoComida);
            this.Controls.Add(this.checkBoxFiltroPorFecha);
            this.Controls.Add(this.checkBoxFiltroPorReceta);
            this.Controls.Add(this.checkBoxFiltroSaludable);
            this.Controls.Add(this.botonConfirmarFiltrosComidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormFiltrosComidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltrosComidas";
            this.Load += new System.EventHandler(this.FormFiltrosComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionRecetas)).EndInit();
            this.groupBoxFiltroSaludable.ResumeLayout(false);
            this.groupBoxFiltroSaludable.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxFiltroSaludable;
        private System.Windows.Forms.RadioButton radioButtonConvencionales;
        private System.Windows.Forms.RadioButton radioButtonSaludables;
    }
}