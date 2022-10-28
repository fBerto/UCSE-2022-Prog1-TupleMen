namespace WindowsFormsApp
{
    partial class MenuIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuIngredientes));
            this.grillaIngredientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administradorIngredientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarIngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevoIngrediente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorIngredientesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaIngredientes
            // 
            this.grillaIngredientes.AutoGenerateColumns = false;
            this.grillaIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.TipoIngrediente,
            this.Cantidad,
            this.UnidadMinima,
            this.Medida,
            this.PrecioPorUnidad});
            this.grillaIngredientes.DataSource = this.administradorIngredientesBindingSource;
            this.grillaIngredientes.Location = new System.Drawing.Point(12, 78);
            this.grillaIngredientes.Name = "grillaIngredientes";
            this.grillaIngredientes.Size = new System.Drawing.Size(653, 211);
            this.grillaIngredientes.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // TipoIngrediente
            // 
            this.TipoIngrediente.DataPropertyName = "TipoIngrediente";
            this.TipoIngrediente.HeaderText = "Tipo";
            this.TipoIngrediente.Name = "TipoIngrediente";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 60;
            // 
            // UnidadMinima
            // 
            this.UnidadMinima.DataPropertyName = "UnidadMinima";
            this.UnidadMinima.HeaderText = "Minimo en Despensa";
            this.UnidadMinima.Name = "UnidadMinima";
            this.UnidadMinima.Width = 130;
            // 
            // Medida
            // 
            this.Medida.DataPropertyName = "UnidadDeMedida";
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.Width = 50;
            // 
            // PrecioPorUnidad
            // 
            this.PrecioPorUnidad.DataPropertyName = "PrecioPorUnidad";
            this.PrecioPorUnidad.HeaderText = "Precio por Unidad";
            this.PrecioPorUnidad.Name = "PrecioPorUnidad";
            this.PrecioPorUnidad.Width = 120;
            // 
            // administradorIngredientesBindingSource
            // 
            this.administradorIngredientesBindingSource.DataSource = typeof(Logica.AdministradorIngredientes);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarIngredientesToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // cargarIngredientesToolStripMenuItem
            // 
            this.cargarIngredientesToolStripMenuItem.Name = "cargarIngredientesToolStripMenuItem";
            this.cargarIngredientesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cargarIngredientesToolStripMenuItem.Text = "Cargar Ingredientes";
            this.cargarIngredientesToolStripMenuItem.Click += new System.EventHandler(this.cargarIngredientesToolStripMenuItem_Click);
            // 
            // btnNuevoIngrediente
            // 
            this.btnNuevoIngrediente.Location = new System.Drawing.Point(272, 36);
            this.btnNuevoIngrediente.Name = "btnNuevoIngrediente";
            this.btnNuevoIngrediente.Size = new System.Drawing.Size(126, 23);
            this.btnNuevoIngrediente.TabIndex = 2;
            this.btnNuevoIngrediente.Text = "Nuevo Ingrediente";
            this.btnNuevoIngrediente.UseVisualStyleBackColor = true;
            this.btnNuevoIngrediente.Click += new System.EventHandler(this.btnNuevoIngrediente_Click);
            // 
            // MenuIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 301);
            this.Controls.Add(this.btnNuevoIngrediente);
            this.Controls.Add(this.grillaIngredientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuIngredientes";
            this.Text = "Menu Ingredientes";
            this.Load += new System.EventHandler(this.MenuIngredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorIngredientesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaIngredientes;
        private System.Windows.Forms.BindingSource administradorIngredientesBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarIngredientesToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevoIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPorUnidad;
    }
}