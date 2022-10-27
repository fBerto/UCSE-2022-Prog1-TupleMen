namespace WindowsFormsApp
{
    partial class MenuComidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuComidas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porSaludableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMomentoDeComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grillaComidas = new System.Windows.Forms.DataGridView();
            this.nombreReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevaComida = new System.Windows.Forms.Button();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaComidas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarComidaToolStripMenuItem,
            this.filtrarToolStripMenuItem,
            this.eliminarFiltrosToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // cargarComidaToolStripMenuItem
            // 
            this.cargarComidaToolStripMenuItem.Name = "cargarComidaToolStripMenuItem";
            this.cargarComidaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cargarComidaToolStripMenuItem.Text = "Cargar Comida";
            this.cargarComidaToolStripMenuItem.Click += new System.EventHandler(this.cargarComidaToolStripMenuItem_Click);
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porSaludableToolStripMenuItem,
            this.porMomentoDeComidaToolStripMenuItem,
            this.porFechaToolStripMenuItem,
            this.porRecetaToolStripMenuItem});
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.filtrarToolStripMenuItem.Text = "Filtrar";
            // 
            // porSaludableToolStripMenuItem
            // 
            this.porSaludableToolStripMenuItem.Name = "porSaludableToolStripMenuItem";
            this.porSaludableToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.porSaludableToolStripMenuItem.Text = "Por Saludable";
            // 
            // porMomentoDeComidaToolStripMenuItem
            // 
            this.porMomentoDeComidaToolStripMenuItem.Name = "porMomentoDeComidaToolStripMenuItem";
            this.porMomentoDeComidaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.porMomentoDeComidaToolStripMenuItem.Text = "Por Momento de Comida";
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.porFechaToolStripMenuItem.Text = "Por Fecha";
            // 
            // porRecetaToolStripMenuItem
            // 
            this.porRecetaToolStripMenuItem.Name = "porRecetaToolStripMenuItem";
            this.porRecetaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.porRecetaToolStripMenuItem.Text = "Por Receta";
            // 
            // eliminarFiltrosToolStripMenuItem
            // 
            this.eliminarFiltrosToolStripMenuItem.Name = "eliminarFiltrosToolStripMenuItem";
            this.eliminarFiltrosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.eliminarFiltrosToolStripMenuItem.Text = "Eliminar Filtros";
            // 
            // grillaComidas
            // 
            this.grillaComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreReceta,
            this.fechaComida});
            this.grillaComidas.Location = new System.Drawing.Point(12, 149);
            this.grillaComidas.Name = "grillaComidas";
            this.grillaComidas.RowHeadersWidth = 51;
            this.grillaComidas.Size = new System.Drawing.Size(479, 326);
            this.grillaComidas.TabIndex = 1;
            // 
            // nombreReceta
            // 
            this.nombreReceta.DataPropertyName = "Receta.GetNombre()";
            this.nombreReceta.HeaderText = "Receta";
            this.nombreReceta.MinimumWidth = 6;
            this.nombreReceta.Name = "nombreReceta";
            this.nombreReceta.ReadOnly = true;
            this.nombreReceta.Width = 125;
            // 
            // fechaComida
            // 
            this.fechaComida.DataPropertyName = "Fecha";
            this.fechaComida.HeaderText = "Fecha";
            this.fechaComida.MinimumWidth = 6;
            this.fechaComida.Name = "fechaComida";
            this.fechaComida.ReadOnly = true;
            this.fechaComida.Width = 125;
            // 
            // btnNuevaComida
            // 
            this.btnNuevaComida.Location = new System.Drawing.Point(12, 53);
            this.btnNuevaComida.Name = "btnNuevaComida";
            this.btnNuevaComida.Size = new System.Drawing.Size(123, 23);
            this.btnNuevaComida.TabIndex = 2;
            this.btnNuevaComida.Text = "Nueva Comida";
            this.btnNuevaComida.UseVisualStyleBackColor = true;
            this.btnNuevaComida.Click += new System.EventHandler(this.btnNuevaComida_Click);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(201, 35);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(34, 13);
            this.lblFiltros.TabIndex = 3;
            this.lblFiltros.Text = "Filtros";
            // 
            // MenuComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 487);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.btnNuevaComida);
            this.Controls.Add(this.grillaComidas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuComidas";
            this.Text = "Menu Comidas";
            this.Load += new System.EventHandler(this.MenuComidas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaComidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarComidaToolStripMenuItem;
        private System.Windows.Forms.DataGridView grillaComidas;
        private System.Windows.Forms.Button btnNuevaComida;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porSaludableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMomentoDeComidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porRecetaToolStripMenuItem;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaComida;
    }
}