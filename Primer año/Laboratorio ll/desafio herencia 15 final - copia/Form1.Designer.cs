
namespace desafio_herencia_15_final
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtPiso = new System.Windows.Forms.RadioButton();
            this.rbtLocal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPiso = new System.Windows.Forms.TextBox();
            this.tbxVentanas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSuperficie = new System.Windows.Forms.TextBox();
            this.tbxAntiguedad = new System.Windows.Forms.TextBox();
            this.tbxPreciobase = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de inmueble";
            // 
            // rbtPiso
            // 
            this.rbtPiso.AutoSize = true;
            this.rbtPiso.Location = new System.Drawing.Point(67, 68);
            this.rbtPiso.Name = "rbtPiso";
            this.rbtPiso.Size = new System.Drawing.Size(56, 21);
            this.rbtPiso.TabIndex = 2;
            this.rbtPiso.TabStop = true;
            this.rbtPiso.Text = "Piso";
            this.rbtPiso.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            this.rbtLocal.AutoSize = true;
            this.rbtLocal.Location = new System.Drawing.Point(271, 68);
            this.rbtLocal.Name = "rbtLocal";
            this.rbtLocal.Size = new System.Drawing.Size(63, 21);
            this.rbtLocal.TabIndex = 3;
            this.rbtLocal.TabStop = true;
            this.rbtLocal.Text = "Local";
            this.rbtLocal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Piso Nro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nro de ventanas";
            // 
            // tbxPiso
            // 
            this.tbxPiso.Location = new System.Drawing.Point(67, 144);
            this.tbxPiso.Name = "tbxPiso";
            this.tbxPiso.Size = new System.Drawing.Size(100, 22);
            this.tbxPiso.TabIndex = 6;
            // 
            // tbxVentanas
            // 
            this.tbxVentanas.Location = new System.Drawing.Point(274, 143);
            this.tbxVentanas.Name = "tbxVentanas";
            this.tbxVentanas.Size = new System.Drawing.Size(100, 22);
            this.tbxVentanas.TabIndex = 7;
            this.tbxVentanas.TextChanged += new System.EventHandler(this.tbxVentanas_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direcciones";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(47, 244);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(373, 22);
            this.tbxDireccion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Superficie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Antiguedad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio base";
            // 
            // tbxSuperficie
            // 
            this.tbxSuperficie.Location = new System.Drawing.Point(67, 323);
            this.tbxSuperficie.Name = "tbxSuperficie";
            this.tbxSuperficie.Size = new System.Drawing.Size(78, 22);
            this.tbxSuperficie.TabIndex = 13;
            // 
            // tbxAntiguedad
            // 
            this.tbxAntiguedad.Location = new System.Drawing.Point(208, 322);
            this.tbxAntiguedad.Name = "tbxAntiguedad";
            this.tbxAntiguedad.Size = new System.Drawing.Size(83, 22);
            this.tbxAntiguedad.TabIndex = 14;
            // 
            // tbxPreciobase
            // 
            this.tbxPreciobase.Location = new System.Drawing.Point(337, 322);
            this.tbxPreciobase.Name = "tbxPreciobase";
            this.tbxPreciobase.Size = new System.Drawing.Size(83, 22);
            this.tbxPreciobase.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(44, 371);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(373, 39);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular Precio Final";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 497);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxPreciobase);
            this.Controls.Add(this.tbxAntiguedad);
            this.Controls.Add(this.tbxSuperficie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxVentanas);
            this.Controls.Add(this.tbxPiso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtLocal);
            this.Controls.Add(this.rbtPiso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtPiso;
        private System.Windows.Forms.RadioButton rbtLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPiso;
        private System.Windows.Forms.TextBox tbxVentanas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSuperficie;
        private System.Windows.Forms.TextBox tbxAntiguedad;
        private System.Windows.Forms.TextBox tbxPreciobase;
        private System.Windows.Forms.Button btnCalcular;
    }
}

