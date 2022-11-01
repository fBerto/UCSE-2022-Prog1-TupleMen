namespace WindowsFormsApp
{
    partial class MenuCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCompras));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grillaCompras = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administradorComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTituloTotalCompra = new System.Windows.Forms.Label();
            this.lblCostoTotalCompra = new System.Windows.Forms.Label();
            this.buttonFiltrarCompras = new System.Windows.Forms.Button();
            this.eliminarFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorComprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrarComprasToolStripMenuItem,
            this.eliminarFiltrosToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // filtrarComprasToolStripMenuItem
            // 
            this.filtrarComprasToolStripMenuItem.Name = "filtrarComprasToolStripMenuItem";
            this.filtrarComprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtrarComprasToolStripMenuItem.Text = "Filtrar Compras";
            this.filtrarComprasToolStripMenuItem.Click += new System.EventHandler(this.filtrarComprasToolStripMenuItem_Click);
            // 
            // grillaCompras
            // 
            this.grillaCompras.AutoGenerateColumns = false;
            this.grillaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo,
            this.Cantidad,
            this.Medida});
            this.grillaCompras.DataSource = this.administradorComprasBindingSource;
            this.grillaCompras.Location = new System.Drawing.Point(12, 27);
            this.grillaCompras.Name = "grillaCompras";
            this.grillaCompras.Size = new System.Drawing.Size(486, 242);
            this.grillaCompras.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TipoIngrediente";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Medida
            // 
            this.Medida.DataPropertyName = "UnidadDeMedida";
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            // 
            // administradorComprasBindingSource
            // 
            this.administradorComprasBindingSource.DataSource = typeof(Logica.AdministradorCompras);
            // 
            // lblTituloTotalCompra
            // 
            this.lblTituloTotalCompra.AutoSize = true;
            this.lblTituloTotalCompra.Location = new System.Drawing.Point(12, 290);
            this.lblTituloTotalCompra.Name = "lblTituloTotalCompra";
            this.lblTituloTotalCompra.Size = new System.Drawing.Size(88, 13);
            this.lblTituloTotalCompra.TabIndex = 2;
            this.lblTituloTotalCompra.Text = "Total Compra ($):";
            // 
            // lblCostoTotalCompra
            // 
            this.lblCostoTotalCompra.AutoSize = true;
            this.lblCostoTotalCompra.Location = new System.Drawing.Point(106, 290);
            this.lblCostoTotalCompra.Name = "lblCostoTotalCompra";
            this.lblCostoTotalCompra.Size = new System.Drawing.Size(39, 13);
            this.lblCostoTotalCompra.TabIndex = 3;
            this.lblCostoTotalCompra.Text = "[costo]";
            // 
            // buttonFiltrarCompras
            // 
            this.buttonFiltrarCompras.Location = new System.Drawing.Point(423, 282);
            this.buttonFiltrarCompras.Name = "buttonFiltrarCompras";
            this.buttonFiltrarCompras.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrarCompras.TabIndex = 4;
            this.buttonFiltrarCompras.Text = "Filtrar";
            this.buttonFiltrarCompras.UseVisualStyleBackColor = true;
            this.buttonFiltrarCompras.Click += new System.EventHandler(this.buttonFiltrarCompras_Click);
            // 
            // eliminarFiltrosToolStripMenuItem
            // 
            this.eliminarFiltrosToolStripMenuItem.Name = "eliminarFiltrosToolStripMenuItem";
            this.eliminarFiltrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarFiltrosToolStripMenuItem.Text = "Eliminar Filtros";
            this.eliminarFiltrosToolStripMenuItem.Click += new System.EventHandler(this.eliminarFiltrosToolStripMenuItem_Click);
            // 
            // MenuCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 317);
            this.Controls.Add(this.buttonFiltrarCompras);
            this.Controls.Add(this.lblCostoTotalCompra);
            this.Controls.Add(this.lblTituloTotalCompra);
            this.Controls.Add(this.grillaCompras);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuCompras";
            this.Text = "Menu Compras";
            this.Load += new System.EventHandler(this.MenuCompras_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorComprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.DataGridView grillaCompras;
        private System.Windows.Forms.BindingSource administradorComprasBindingSource;
        private System.Windows.Forms.ToolStripMenuItem filtrarComprasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.Label lblTituloTotalCompra;
        private System.Windows.Forms.Label lblCostoTotalCompra;
        private System.Windows.Forms.Button buttonFiltrarCompras;
        private System.Windows.Forms.ToolStripMenuItem eliminarFiltrosToolStripMenuItem;
    }
}