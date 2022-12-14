namespace WindowsFormsApp
{
    partial class MenuRecetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRecetas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grillaRecetas = new System.Windows.Forms.DataGridView();
            this.administradorRecetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevaReceta = new System.Windows.Forms.Button();
            this.CodigoReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Momento_Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Es_Saludable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorRecetasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarRecetaToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // cargarRecetaToolStripMenuItem
            // 
            this.cargarRecetaToolStripMenuItem.Name = "cargarRecetaToolStripMenuItem";
            this.cargarRecetaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cargarRecetaToolStripMenuItem.Text = "Cargar Receta";
            this.cargarRecetaToolStripMenuItem.Click += new System.EventHandler(this.cargarRecetaToolStripMenuItem_Click);
            // 
            // grillaRecetas
            // 
            this.grillaRecetas.AllowUserToAddRows = false;
            this.grillaRecetas.AllowUserToDeleteRows = false;
            this.grillaRecetas.AllowUserToResizeColumns = false;
            this.grillaRecetas.AllowUserToResizeRows = false;
            this.grillaRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoReceta,
            this.NombreReceta,
            this.Momento_Comida,
            this.Es_Saludable,
            this.Editar,
            this.Eliminar});
            this.grillaRecetas.Location = new System.Drawing.Point(12, 76);
            this.grillaRecetas.Name = "grillaRecetas";
            this.grillaRecetas.ReadOnly = true;
            this.grillaRecetas.RowHeadersWidth = 51;
            this.grillaRecetas.Size = new System.Drawing.Size(573, 334);
            this.grillaRecetas.TabIndex = 1;
            this.grillaRecetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaRecetas_CellClick);
            this.grillaRecetas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grillaRecetas_DataBindingComplete);
            // 
            // administradorRecetasBindingSource
            // 
            this.administradorRecetasBindingSource.DataSource = typeof(Logica.AdministradorRecetas);
            // 
            // btnNuevaReceta
            // 
            this.btnNuevaReceta.Location = new System.Drawing.Point(225, 37);
            this.btnNuevaReceta.Name = "btnNuevaReceta";
            this.btnNuevaReceta.Size = new System.Drawing.Size(149, 23);
            this.btnNuevaReceta.TabIndex = 2;
            this.btnNuevaReceta.Text = "Nueva Receta";
            this.btnNuevaReceta.UseVisualStyleBackColor = true;
            this.btnNuevaReceta.Click += new System.EventHandler(this.btnNuevaReceta_Click);
            // 
            // CodigoReceta
            // 
            this.CodigoReceta.DataPropertyName = "Codigo";
            this.CodigoReceta.HeaderText = "Codigo";
            this.CodigoReceta.MinimumWidth = 6;
            this.CodigoReceta.Name = "CodigoReceta";
            this.CodigoReceta.ReadOnly = true;
            this.CodigoReceta.Width = 50;
            // 
            // NombreReceta
            // 
            this.NombreReceta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreReceta.DataPropertyName = "Nombre";
            this.NombreReceta.HeaderText = "Nombre";
            this.NombreReceta.MinimumWidth = 6;
            this.NombreReceta.Name = "NombreReceta";
            this.NombreReceta.ReadOnly = true;
            // 
            // Momento_Comida
            // 
            this.Momento_Comida.DataPropertyName = "MomentoComida";
            this.Momento_Comida.HeaderText = "Momento de la Comida";
            this.Momento_Comida.MinimumWidth = 6;
            this.Momento_Comida.Name = "Momento_Comida";
            this.Momento_Comida.ReadOnly = true;
            this.Momento_Comida.Width = 140;
            // 
            // Es_Saludable
            // 
            this.Es_Saludable.DataPropertyName = "EsSaludable";
            this.Es_Saludable.FalseValue = "false";
            this.Es_Saludable.HeaderText = "Es Saludable?";
            this.Es_Saludable.MinimumWidth = 6;
            this.Es_Saludable.Name = "Es_Saludable";
            this.Es_Saludable.ReadOnly = true;
            this.Es_Saludable.TrueValue = "true";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // MenuRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 422);
            this.Controls.Add(this.btnNuevaReceta);
            this.Controls.Add(this.grillaRecetas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuRecetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Recetas";
            this.Load += new System.EventHandler(this.MenuRecetas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradorRecetasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarRecetaToolStripMenuItem;
        private System.Windows.Forms.DataGridView grillaRecetas;
        private System.Windows.Forms.BindingSource administradorRecetasBindingSource;
        private System.Windows.Forms.Button btnNuevaReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Momento_Comida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Es_Saludable;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}