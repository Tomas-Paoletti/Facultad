
using System;

namespace ProyectoFinalProgramacion
{
    partial class EXCuadrosTitulos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelaño = new System.Windows.Forms.Label();
            this.labelArtista = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelnomb = new System.Windows.Forms.Label();
            this.labelCreacion = new System.Windows.Forms.Label();
            this.labelCreador = new System.Windows.Forms.Label();
            this.groupBoxDescripcion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalProgramacion.Properties.Resources.Mona_lisa;
            this.pictureBox1.Location = new System.Drawing.Point(139, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 240);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(130, 17);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre de la obra:";
            // 
            // labelaño
            // 
            this.labelaño.AutoSize = true;
            this.labelaño.Location = new System.Drawing.Point(20, 278);
            this.labelaño.Name = "labelaño";
            this.labelaño.Size = new System.Drawing.Size(41, 17);
            this.labelaño.TabIndex = 2;
            this.labelaño.Text = "Año: ";
            // 
            // labelArtista
            // 
            this.labelArtista.AutoSize = true;
            this.labelArtista.Location = new System.Drawing.Point(12, 317);
            this.labelArtista.Name = "labelArtista";
            this.labelArtista.Size = new System.Drawing.Size(49, 17);
            this.labelArtista.TabIndex = 3;
            this.labelArtista.Text = "Pintor:";
            this.labelArtista.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(13, 355);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelnomb
            // 
            this.labelnomb.AutoSize = true;
            this.labelnomb.Location = new System.Drawing.Point(164, 240);
            this.labelnomb.Name = "labelnomb";
            this.labelnomb.Size = new System.Drawing.Size(0, 17);
            this.labelnomb.TabIndex = 5;
            // 
            // labelCreacion
            // 
            this.labelCreacion.AutoSize = true;
            this.labelCreacion.Location = new System.Drawing.Point(164, 278);
            this.labelCreacion.Name = "labelCreacion";
            this.labelCreacion.Size = new System.Drawing.Size(0, 17);
            this.labelCreacion.TabIndex = 6;
            // 
            // labelCreador
            // 
            this.labelCreador.AutoSize = true;
            this.labelCreador.Location = new System.Drawing.Point(164, 317);
            this.labelCreador.Name = "labelCreador";
            this.labelCreador.Size = new System.Drawing.Size(0, 17);
            this.labelCreador.TabIndex = 7;
            // 
            // groupBoxDescripcion
            // 
            this.groupBoxDescripcion.Location = new System.Drawing.Point(154, 355);
            this.groupBoxDescripcion.Name = "groupBoxDescripcion";
            this.groupBoxDescripcion.Size = new System.Drawing.Size(266, 83);
            this.groupBoxDescripcion.TabIndex = 10;
            this.groupBoxDescripcion.TabStop = false;
            // 
            // EXCuadrosTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.groupBoxDescripcion);
            this.Controls.Add(this.labelCreador);
            this.Controls.Add(this.labelCreacion);
            this.Controls.Add(this.labelnomb);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelArtista);
            this.Controls.Add(this.labelaño);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EXCuadrosTitulos";
            this.Text = "Obra";
            this.Load += new System.EventHandler(this.EXCuadros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelaño;
        private System.Windows.Forms.Label labelArtista;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelnomb;
        private System.Windows.Forms.Label labelCreacion;
        private System.Windows.Forms.Label labelCreador;
        private System.Windows.Forms.GroupBox groupBoxDescripcion;
    }
}