namespace Proyecto_de_investigacion
{
    partial class Form2
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
            this.lblHistoria = new System.Windows.Forms.Label();
            this.txtHistoria = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistoria
            // 
            this.lblHistoria.AutoSize = true;
            this.lblHistoria.Location = new System.Drawing.Point(349, 52);
            this.lblHistoria.Name = "lblHistoria";
            this.lblHistoria.Size = new System.Drawing.Size(128, 16);
            this.lblHistoria.TabIndex = 0;
            this.lblHistoria.Text = "Historia del Hip Hop";
            // 
            // txtHistoria
            // 
            this.txtHistoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHistoria.Location = new System.Drawing.Point(0, 0);
            this.txtHistoria.Multiline = true;
            this.txtHistoria.Name = "txtHistoria";
            this.txtHistoria.ReadOnly = true;
            this.txtHistoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistoria.Size = new System.Drawing.Size(800, 450);
            this.txtHistoria.TabIndex = 1;
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::Proyecto_de_investigacion.Properties.Resources._71thVqDMSnL;
            this.pbImagen.Location = new System.Drawing.Point(228, 162);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(293, 183);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(589, 294);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(106, 51);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver al incio";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txtHistoria);
            this.Controls.Add(this.lblHistoria);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistoria;
        private System.Windows.Forms.TextBox txtHistoria;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnVolver;
    }
}