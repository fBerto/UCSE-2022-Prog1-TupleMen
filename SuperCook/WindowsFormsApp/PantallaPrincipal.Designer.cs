namespace WindowsFormsApp
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.BotonIngredientes = new System.Windows.Forms.Button();
            this.BotonCompras = new System.Windows.Forms.Button();
            this.BotonRecetas = new System.Windows.Forms.Button();
            this.BotonComidas = new System.Windows.Forms.Button();
            this.EtiquetaBotonIngredientes = new System.Windows.Forms.Label();
            this.EtiquetaBotonRecetas = new System.Windows.Forms.Label();
            this.EtiquetaBotonComidas = new System.Windows.Forms.Label();
            this.EtiquetaBotonSuper = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonIngredientes
            // 
            this.BotonIngredientes.AutoSize = true;
            this.BotonIngredientes.BackColor = System.Drawing.Color.SaddleBrown;
            this.BotonIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonIngredientes.Image = global::WindowsFormsApp.Properties.Resources.Sin_título_1;
            this.BotonIngredientes.Location = new System.Drawing.Point(47, 138);
            this.BotonIngredientes.Name = "BotonIngredientes";
            this.BotonIngredientes.Size = new System.Drawing.Size(60, 60);
            this.BotonIngredientes.TabIndex = 0;
            this.BotonIngredientes.UseVisualStyleBackColor = false;
            this.BotonIngredientes.Click += new System.EventHandler(this.BotonIngredientes_Click);
            // 
            // BotonCompras
            // 
            this.BotonCompras.AutoSize = true;
            this.BotonCompras.BackColor = System.Drawing.Color.SaddleBrown;
            this.BotonCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCompras.Image = global::WindowsFormsApp.Properties.Resources.dsa;
            this.BotonCompras.Location = new System.Drawing.Point(47, 336);
            this.BotonCompras.Name = "BotonCompras";
            this.BotonCompras.Size = new System.Drawing.Size(60, 60);
            this.BotonCompras.TabIndex = 1;
            this.BotonCompras.UseVisualStyleBackColor = false;
            this.BotonCompras.Click += new System.EventHandler(this.BotonCompras_Click);
            // 
            // BotonRecetas
            // 
            this.BotonRecetas.AutoSize = true;
            this.BotonRecetas.BackColor = System.Drawing.Color.SaddleBrown;
            this.BotonRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRecetas.Image = global::WindowsFormsApp.Properties.Resources.dasds;
            this.BotonRecetas.Location = new System.Drawing.Point(47, 204);
            this.BotonRecetas.Name = "BotonRecetas";
            this.BotonRecetas.Size = new System.Drawing.Size(60, 60);
            this.BotonRecetas.TabIndex = 2;
            this.BotonRecetas.UseVisualStyleBackColor = false;
            this.BotonRecetas.Click += new System.EventHandler(this.BotonRecetas_Click);
            // 
            // BotonComidas
            // 
            this.BotonComidas.AutoSize = true;
            this.BotonComidas.BackColor = System.Drawing.Color.SaddleBrown;
            this.BotonComidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonComidas.Image = global::WindowsFormsApp.Properties.Resources.Sin_título_12;
            this.BotonComidas.Location = new System.Drawing.Point(47, 270);
            this.BotonComidas.Name = "BotonComidas";
            this.BotonComidas.Size = new System.Drawing.Size(60, 60);
            this.BotonComidas.TabIndex = 3;
            this.BotonComidas.UseVisualStyleBackColor = false;
            this.BotonComidas.Click += new System.EventHandler(this.BotonComidas_Click);
            // 
            // EtiquetaBotonIngredientes
            // 
            this.EtiquetaBotonIngredientes.AutoSize = true;
            this.EtiquetaBotonIngredientes.BackColor = System.Drawing.Color.Beige;
            this.EtiquetaBotonIngredientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EtiquetaBotonIngredientes.Location = new System.Drawing.Point(113, 162);
            this.EtiquetaBotonIngredientes.Name = "EtiquetaBotonIngredientes";
            this.EtiquetaBotonIngredientes.Size = new System.Drawing.Size(65, 13);
            this.EtiquetaBotonIngredientes.TabIndex = 5;
            this.EtiquetaBotonIngredientes.Text = "Ingredientes";
            // 
            // EtiquetaBotonRecetas
            // 
            this.EtiquetaBotonRecetas.AutoSize = true;
            this.EtiquetaBotonRecetas.Location = new System.Drawing.Point(113, 228);
            this.EtiquetaBotonRecetas.Name = "EtiquetaBotonRecetas";
            this.EtiquetaBotonRecetas.Size = new System.Drawing.Size(47, 13);
            this.EtiquetaBotonRecetas.TabIndex = 6;
            this.EtiquetaBotonRecetas.Text = "Recetas";
            // 
            // EtiquetaBotonComidas
            // 
            this.EtiquetaBotonComidas.AutoSize = true;
            this.EtiquetaBotonComidas.Location = new System.Drawing.Point(113, 294);
            this.EtiquetaBotonComidas.Name = "EtiquetaBotonComidas";
            this.EtiquetaBotonComidas.Size = new System.Drawing.Size(47, 13);
            this.EtiquetaBotonComidas.TabIndex = 7;
            this.EtiquetaBotonComidas.Text = "Comidas";
            // 
            // EtiquetaBotonSuper
            // 
            this.EtiquetaBotonSuper.AutoSize = true;
            this.EtiquetaBotonSuper.Location = new System.Drawing.Point(113, 360);
            this.EtiquetaBotonSuper.Name = "EtiquetaBotonSuper";
            this.EtiquetaBotonSuper.Size = new System.Drawing.Size(35, 13);
            this.EtiquetaBotonSuper.TabIndex = 8;
            this.EtiquetaBotonSuper.Text = "Super";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.Captura_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(204, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApp.Properties.Resources.si__1_;
            this.ClientSize = new System.Drawing.Size(749, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EtiquetaBotonSuper);
            this.Controls.Add(this.EtiquetaBotonComidas);
            this.Controls.Add(this.EtiquetaBotonRecetas);
            this.Controls.Add(this.EtiquetaBotonIngredientes);
            this.Controls.Add(this.BotonComidas);
            this.Controls.Add(this.BotonRecetas);
            this.Controls.Add(this.BotonCompras);
            this.Controls.Add(this.BotonIngredientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Cook";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonIngredientes;
        private System.Windows.Forms.Button BotonCompras;
        private System.Windows.Forms.Button BotonRecetas;
        private System.Windows.Forms.Button BotonComidas;
        private System.Windows.Forms.Label EtiquetaBotonIngredientes;
        private System.Windows.Forms.Label EtiquetaBotonRecetas;
        private System.Windows.Forms.Label EtiquetaBotonComidas;
        private System.Windows.Forms.Label EtiquetaBotonSuper;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

