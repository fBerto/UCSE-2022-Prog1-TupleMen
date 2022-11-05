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
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarIngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevoIngrediente = new System.Windows.Forms.Button();
            this.administradorIngredientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grillaIngredientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administradorIngredientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaIngredientes
            // 
            this.grillaIngredientes.AllowUserToAddRows = false;
            this.grillaIngredientes.AllowUserToDeleteRows = false;
            this.grillaIngredientes.AllowUserToResizeColumns = false;
            this.grillaIngredientes.AllowUserToResizeRows = false;
            this.grillaIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Editar,
            this.Eliminar,
            this.Nombre,
            this.TipoIngrediente,
            this.Cantidad,
            this.UnidadMinima,
            this.Medida,
            this.PrecioPorUnidad});
            this.grillaIngredientes.Location = new System.Drawing.Point(12, 78);
            this.grillaIngredientes.Name = "grillaIngredientes";
            this.grillaIngredientes.ReadOnly = true;
            this.grillaIngredientes.Size = new System.Drawing.Size(764, 369);
            this.grillaIngredientes.TabIndex = 0;
            this.grillaIngredientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaIngredientes_CellClick);
            this.grillaIngredientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grillaIngredientes_DataBindingComplete);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // TipoIngrediente
            // 
            this.TipoIngrediente.DataPropertyName = "TipoIngrediente";
            this.TipoIngrediente.HeaderText = "Tipo";
            this.TipoIngrediente.Name = "TipoIngrediente";
            this.TipoIngrediente.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // UnidadMinima
            // 
            this.UnidadMinima.DataPropertyName = "UnidadMinima";
            this.UnidadMinima.HeaderText = "Minimo en Despensa";
            this.UnidadMinima.Name = "UnidadMinima";
            this.UnidadMinima.ReadOnly = true;
            this.UnidadMinima.Width = 130;
            // 
            // Medida
            // 
            this.Medida.DataPropertyName = "UnidadDeMedida";
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            this.Medida.Width = 50;
            // 
            // PrecioPorUnidad
            // 
            this.PrecioPorUnidad.DataPropertyName = "PrecioPorUnidad";
            this.PrecioPorUnidad.HeaderText = "Precio por Unidad";
            this.PrecioPorUnidad.Name = "PrecioPorUnidad";
            this.PrecioPorUnidad.ReadOnly = true;
            this.PrecioPorUnidad.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
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
            this.cargarIngredientesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cargarIngredientesToolStripMenuItem.Text = "Cargar Ingrediente";
            this.cargarIngredientesToolStripMenuItem.Click += new System.EventHandler(this.cargarIngredientesToolStripMenuItem_Click);
            // 
            // btnNuevoIngrediente
            // 
            this.btnNuevoIngrediente.Location = new System.Drawing.Point(338, 37);
            this.btnNuevoIngrediente.Name = "btnNuevoIngrediente";
            this.btnNuevoIngrediente.Size = new System.Drawing.Size(126, 23);
            this.btnNuevoIngrediente.TabIndex = 2;
            this.btnNuevoIngrediente.Text = "Nuevo Ingrediente";
            this.btnNuevoIngrediente.UseVisualStyleBackColor = true;
            this.btnNuevoIngrediente.Click += new System.EventHandler(this.btnNuevoIngrediente_Click);
            // 
            // administradorIngredientesBindingSource
            // 
            this.administradorIngredientesBindingSource.DataSource = typeof(Logica.AdministradorIngredientes);
            // 
            // MenuIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 459);
            this.Controls.Add(this.btnNuevoIngrediente);
            this.Controls.Add(this.grillaIngredientes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuIngredientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Ingredientes";
            this.Load += new System.EventHandler(this.MenuIngredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaIngredientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administradorIngredientesBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPorUnidad;
    }
}