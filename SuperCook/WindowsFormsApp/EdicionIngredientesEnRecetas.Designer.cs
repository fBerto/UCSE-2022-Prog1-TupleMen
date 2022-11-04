namespace WindowsFormsApp
{
    partial class EdicionIngredientesEnRecetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionIngredientesEnRecetas));
            this.NombreIngredienteAEditar = new System.Windows.Forms.Label();
            this.textBoxNuevaCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnidadMedidaAEditar = new System.Windows.Forms.Label();
            this.buttonConfirmarNuevaCantidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreIngredienteAEditar
            // 
            this.NombreIngredienteAEditar.AllowDrop = true;
            this.NombreIngredienteAEditar.AutoSize = true;
            this.NombreIngredienteAEditar.Location = new System.Drawing.Point(16, 25);
            this.NombreIngredienteAEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreIngredienteAEditar.Name = "NombreIngredienteAEditar";
            this.NombreIngredienteAEditar.Size = new System.Drawing.Size(123, 16);
            this.NombreIngredienteAEditar.TabIndex = 0;
            this.NombreIngredienteAEditar.Text = "NombreIngrediente";
            // 
            // textBoxNuevaCantidadIngrediente
            // 
            this.textBoxNuevaCantidadIngrediente.Location = new System.Drawing.Point(118, 89);
            this.textBoxNuevaCantidadIngrediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNuevaCantidadIngrediente.Name = "textBoxNuevaCantidadIngrediente";
            this.textBoxNuevaCantidadIngrediente.Size = new System.Drawing.Size(132, 22);
            this.textBoxNuevaCantidadIngrediente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba la nueva cantidad";
            // 
            // UnidadMedidaAEditar
            // 
            this.UnidadMedidaAEditar.AutoSize = true;
            this.UnidadMedidaAEditar.Location = new System.Drawing.Point(258, 95);
            this.UnidadMedidaAEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnidadMedidaAEditar.Name = "UnidadMedidaAEditar";
            this.UnidadMedidaAEditar.Size = new System.Drawing.Size(94, 16);
            this.UnidadMedidaAEditar.TabIndex = 3;
            this.UnidadMedidaAEditar.Text = "unidadMedida";
            // 
            // buttonConfirmarNuevaCantidad
            // 
            this.buttonConfirmarNuevaCantidad.Location = new System.Drawing.Point(134, 162);
            this.buttonConfirmarNuevaCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirmarNuevaCantidad.Name = "buttonConfirmarNuevaCantidad";
            this.buttonConfirmarNuevaCantidad.Size = new System.Drawing.Size(116, 28);
            this.buttonConfirmarNuevaCantidad.TabIndex = 4;
            this.buttonConfirmarNuevaCantidad.Text = "Confirmar";
            this.buttonConfirmarNuevaCantidad.UseVisualStyleBackColor = true;
            this.buttonConfirmarNuevaCantidad.Click += new System.EventHandler(this.buttonConfirmarNuevaCantidad_Click);
            // 
            // EdicionIngredientesEnRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 203);
            this.Controls.Add(this.buttonConfirmarNuevaCantidad);
            this.Controls.Add(this.UnidadMedidaAEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNuevaCantidadIngrediente);
            this.Controls.Add(this.NombreIngredienteAEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "EdicionIngredientesEnRecetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion Cantidad Ingrediente";
            this.Load += new System.EventHandler(this.EdicionIngredientesEnRecetas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreIngredienteAEditar;
        private System.Windows.Forms.TextBox textBoxNuevaCantidadIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UnidadMedidaAEditar;
        private System.Windows.Forms.Button buttonConfirmarNuevaCantidad;
    }
}