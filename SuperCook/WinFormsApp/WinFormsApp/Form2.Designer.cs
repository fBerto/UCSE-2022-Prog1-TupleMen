namespace WinFormsApp
{
    partial class PantallaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicial));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BRecetas = new System.Windows.Forms.Button();
            this.BCompras = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(253, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BRecetas
            // 
            this.BRecetas.AutoSize = true;
            this.BRecetas.BackColor = System.Drawing.Color.SaddleBrown;
            this.BRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRecetas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BRecetas.Image = ((System.Drawing.Image)(resources.GetObject("BRecetas.Image")));
            this.BRecetas.Location = new System.Drawing.Point(149, 249);
            this.BRecetas.Name = "BRecetas";
            this.BRecetas.Size = new System.Drawing.Size(60, 60);
            this.BRecetas.TabIndex = 5;
            this.BRecetas.UseVisualStyleBackColor = false;
            // 
            // BCompras
            // 
            this.BCompras.AutoSize = true;
            this.BCompras.BackColor = System.Drawing.Color.SaddleBrown;
            this.BCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCompras.Image = ((System.Drawing.Image)(resources.GetObject("BCompras.Image")));
            this.BCompras.Location = new System.Drawing.Point(149, 124);
            this.BCompras.Name = "BCompras";
            this.BCompras.Size = new System.Drawing.Size(60, 60);
            this.BCompras.TabIndex = 6;
            this.BCompras.UseVisualStyleBackColor = false;
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.SaddleBrown;
            this.B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B.Image = ((System.Drawing.Image)(resources.GetObject("B.Image")));
            this.B.Location = new System.Drawing.Point(39, 249);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(60, 60);
            this.B.TabIndex = 7;
            this.B.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(39, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(149, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recetas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(149, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Super";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(39, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Comidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Olive;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingredientes";
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.B);
            this.Controls.Add(this.BCompras);
            this.Controls.Add(this.BRecetas);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaInicial";
            this.Text = "SuperCook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox2;
        private Button BRecetas;
        private Button BCompras;
        private Button B;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}