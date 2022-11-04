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
            this.eliminarFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grillaComidas = new System.Windows.Forms.DataGridView();
            this.nombreReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarComida = new System.Windows.Forms.Button();
            this.botonFiltrarComidas = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(398, 24);
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
            this.cargarComidaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cargarComidaToolStripMenuItem.Text = "Registrar Comida";
            this.cargarComidaToolStripMenuItem.Click += new System.EventHandler(this.registrarComidaToolStripMenuItem_Click);
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.filtrarToolStripMenuItem.Text = "Filtrar Comidas";
            this.filtrarToolStripMenuItem.Click += new System.EventHandler(this.filtrarToolStripMenuItem_Click);
            // 
            // eliminarFiltrosToolStripMenuItem
            // 
            this.eliminarFiltrosToolStripMenuItem.Name = "eliminarFiltrosToolStripMenuItem";
            this.eliminarFiltrosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminarFiltrosToolStripMenuItem.Text = "Eliminar Filtros";
            this.eliminarFiltrosToolStripMenuItem.Click += new System.EventHandler(this.eliminarFiltrosToolStripMenuItem_Click);
            // 
            // grillaComidas
            // 
            this.grillaComidas.AllowUserToResizeColumns = false;
            this.grillaComidas.AllowUserToResizeRows = false;
            this.grillaComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreReceta,
            this.fechaComida});
            this.grillaComidas.Location = new System.Drawing.Point(12, 82);
            this.grillaComidas.Name = "grillaComidas";
            this.grillaComidas.ReadOnly = true;
            this.grillaComidas.RowHeadersWidth = 51;
            this.grillaComidas.Size = new System.Drawing.Size(374, 338);
            this.grillaComidas.TabIndex = 1;
            // 
            // nombreReceta
            // 
            this.nombreReceta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreReceta.DataPropertyName = "NombreReceta";
            this.nombreReceta.HeaderText = "Receta";
            this.nombreReceta.MinimumWidth = 6;
            this.nombreReceta.Name = "nombreReceta";
            this.nombreReceta.ReadOnly = true;
            // 
            // fechaComida
            // 
            this.fechaComida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaComida.DataPropertyName = "Fecha";
            this.fechaComida.HeaderText = "Fecha";
            this.fechaComida.MinimumWidth = 6;
            this.fechaComida.Name = "fechaComida";
            this.fechaComida.ReadOnly = true;
            // 
            // btnRegistrarComida
            // 
            this.btnRegistrarComida.Location = new System.Drawing.Point(38, 38);
            this.btnRegistrarComida.Name = "btnRegistrarComida";
            this.btnRegistrarComida.Size = new System.Drawing.Size(123, 23);
            this.btnRegistrarComida.TabIndex = 2;
            this.btnRegistrarComida.Text = "Registrar Comida";
            this.btnRegistrarComida.UseVisualStyleBackColor = true;
            this.btnRegistrarComida.Click += new System.EventHandler(this.btnRegistrarComida_Click);
            // 
            // botonFiltrarComidas
            // 
            this.botonFiltrarComidas.Location = new System.Drawing.Point(222, 38);
            this.botonFiltrarComidas.Name = "botonFiltrarComidas";
            this.botonFiltrarComidas.Size = new System.Drawing.Size(120, 23);
            this.botonFiltrarComidas.TabIndex = 3;
            this.botonFiltrarComidas.Text = "Filtrar Comidas";
            this.botonFiltrarComidas.UseVisualStyleBackColor = true;
            this.botonFiltrarComidas.Click += new System.EventHandler(this.botonFiltrarComidas_Click);
            // 
            // MenuComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 432);
            this.Controls.Add(this.botonFiltrarComidas);
            this.Controls.Add(this.btnRegistrarComida);
            this.Controls.Add(this.grillaComidas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "MenuComidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnRegistrarComida;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFiltrosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaComida;
        private System.Windows.Forms.Button botonFiltrarComidas;
    }
}