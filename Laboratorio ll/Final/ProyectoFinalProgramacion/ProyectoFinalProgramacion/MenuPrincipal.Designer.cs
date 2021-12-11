
namespace ProyectoFinalProgramacion
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.Bienvenidos = new System.Windows.Forms.Label();
            this.buttonInvitado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdministrador = new System.Windows.Forms.Button();
            this.labelEstadodb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bienvenidos
            // 
            this.Bienvenidos.AutoSize = true;
            this.Bienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidos.Location = new System.Drawing.Point(20, 29);
            this.Bienvenidos.MaximumSize = new System.Drawing.Size(400, 300);
            this.Bienvenidos.Name = "Bienvenidos";
            this.Bienvenidos.Size = new System.Drawing.Size(292, 25);
            this.Bienvenidos.TabIndex = 0;
            this.Bienvenidos.Text = "Bienvenido Al Museo De Louvre";
            this.Bienvenidos.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonInvitado
            // 
            this.buttonInvitado.Location = new System.Drawing.Point(58, 339);
            this.buttonInvitado.Name = "buttonInvitado";
            this.buttonInvitado.Size = new System.Drawing.Size(192, 41);
            this.buttonInvitado.TabIndex = 1;
            this.buttonInvitado.Text = "Iniciar como invitado";
            this.buttonInvitado.UseVisualStyleBackColor = true;
            this.buttonInvitado.Click += new System.EventHandler(this.buttonInvitado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toque el boton para iniciar sesion";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalProgramacion.Properties.Resources.louvre_museum_night;
            this.pictureBox1.Location = new System.Drawing.Point(26, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdministrador
            // 
            this.buttonAdministrador.Location = new System.Drawing.Point(58, 403);
            this.buttonAdministrador.Name = "buttonAdministrador";
            this.buttonAdministrador.Size = new System.Drawing.Size(192, 41);
            this.buttonAdministrador.TabIndex = 4;
            this.buttonAdministrador.Text = "Administrador";
            this.buttonAdministrador.UseVisualStyleBackColor = true;
            this.buttonAdministrador.Click += new System.EventHandler(this.buttonAdministrador_Click);
            // 
            // labelEstadodb
            // 
            this.labelEstadodb.AutoSize = true;
            this.labelEstadodb.Location = new System.Drawing.Point(273, 476);
            this.labelEstadodb.Name = "labelEstadodb";
            this.labelEstadodb.Size = new System.Drawing.Size(0, 17);
            this.labelEstadodb.TabIndex = 5;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 493);
            this.Controls.Add(this.labelEstadodb);
            this.Controls.Add(this.buttonAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInvitado);
            this.Controls.Add(this.Bienvenidos);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenidos;
        private System.Windows.Forms.Button buttonInvitado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdministrador;
        private System.Windows.Forms.Label labelEstadodb;
    }
}

