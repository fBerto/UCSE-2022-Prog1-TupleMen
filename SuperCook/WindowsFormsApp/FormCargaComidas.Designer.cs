namespace WindowsFormsApp
{
    partial class FormCargaComidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargaComidas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonCargarComida = new System.Windows.Forms.Button();
            this.grillaSeleccionRecetas = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsSaludable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxMomentoComida = new System.Windows.Forms.ComboBox();
            this.lblMomentoComida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recetas disponibles para preparar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Preparacion";
            // 
            // botonCargarComida
            // 
            this.botonCargarComida.Location = new System.Drawing.Point(179, 456);
            this.botonCargarComida.Name = "botonCargarComida";
            this.botonCargarComida.Size = new System.Drawing.Size(75, 23);
            this.botonCargarComida.TabIndex = 3;
            this.botonCargarComida.Text = "Aceptar";
            this.botonCargarComida.UseVisualStyleBackColor = true;
            this.botonCargarComida.Click += new System.EventHandler(this.botonConfirmarCargaComida_Click);
            // 
            // grillaSeleccionRecetas
            // 
            this.grillaSeleccionRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSeleccionRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Receta,
            this.EsSaludable});
            this.grillaSeleccionRecetas.Location = new System.Drawing.Point(12, 36);
            this.grillaSeleccionRecetas.MultiSelect = false;
            this.grillaSeleccionRecetas.Name = "grillaSeleccionRecetas";
            this.grillaSeleccionRecetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaSeleccionRecetas.Size = new System.Drawing.Size(404, 307);
            this.grillaSeleccionRecetas.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(12, 373);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
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
            // comboBoxMomentoComida
            // 
            this.comboBoxMomentoComida.FormattingEnabled = true;
            this.comboBoxMomentoComida.Location = new System.Drawing.Point(256, 373);
            this.comboBoxMomentoComida.Name = "comboBoxMomentoComida";
            this.comboBoxMomentoComida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMomentoComida.TabIndex = 7;
            this.comboBoxMomentoComida.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMomentoComida_SelectionChangeCommitted);
            // 
            // lblMomentoComida
            // 
            this.lblMomentoComida.AutoSize = true;
            this.lblMomentoComida.Location = new System.Drawing.Point(253, 357);
            this.lblMomentoComida.Name = "lblMomentoComida";
            this.lblMomentoComida.Size = new System.Drawing.Size(89, 13);
            this.lblMomentoComida.TabIndex = 8;
            this.lblMomentoComida.Text = "Momento Comida";
            // 
            // FormCargaComidas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(428, 491);
            this.Controls.Add(this.lblMomentoComida);
            this.Controls.Add(this.comboBoxMomentoComida);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.grillaSeleccionRecetas);
            this.Controls.Add(this.botonCargarComida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargaComidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Comidas";
            this.Load += new System.EventHandler(this.FormCargaComidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonCargarComida;
        private System.Windows.Forms.DataGridView grillaSeleccionRecetas;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsSaludable;
        private System.Windows.Forms.ComboBox comboBoxMomentoComida;
        private System.Windows.Forms.Label lblMomentoComida;
    }
}