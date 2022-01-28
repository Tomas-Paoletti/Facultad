
namespace ProyectoFinalProgramacion.Admin
{
    partial class AdministrarObras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxCreador = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxAñoCreacion = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelArtista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAñoCreacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBoxCreador
            // 
            this.textBoxCreador.Location = new System.Drawing.Point(28, 105);
            this.textBoxCreador.Multiline = true;
            this.textBoxCreador.Name = "textBoxCreador";
            this.textBoxCreador.Size = new System.Drawing.Size(153, 36);
            this.textBoxCreador.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(381, 55);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(180, 86);
            this.textBoxDescripcion.TabIndex = 2;
            // 
            // textBoxAñoCreacion
            // 
            this.textBoxAñoCreacion.Location = new System.Drawing.Point(207, 105);
            this.textBoxAñoCreacion.Multiline = true;
            this.textBoxAñoCreacion.Name = "textBoxAñoCreacion";
            this.textBoxAñoCreacion.Size = new System.Drawing.Size(153, 36);
            this.textBoxAñoCreacion.TabIndex = 3;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(207, 32);
            this.textBoxnombre.Multiline = true;
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(153, 36);
            this.textBoxnombre.TabIndex = 4;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(28, 32);
            this.textBoxid.Multiline = true;
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(153, 36);
            this.textBoxid.TabIndex = 5;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(768, 32);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(88, 36);
            this.buttonBorrar.TabIndex = 6;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(624, 105);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(88, 36);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(624, 32);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(88, 36);
            this.buttonModificar.TabIndex = 8;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(768, 105);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(88, 36);
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(204, 12);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(138, 17);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre de la obra:  ";
            // 
            // labelArtista
            // 
            this.labelArtista.AutoSize = true;
            this.labelArtista.Location = new System.Drawing.Point(25, 85);
            this.labelArtista.Name = "labelArtista";
            this.labelArtista.Size = new System.Drawing.Size(52, 17);
            this.labelArtista.TabIndex = 11;
            this.labelArtista.Text = "Artista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id:";
            // 
            // labelAñoCreacion
            // 
            this.labelAñoCreacion.AutoSize = true;
            this.labelAñoCreacion.Location = new System.Drawing.Point(204, 85);
            this.labelAñoCreacion.Name = "labelAñoCreacion";
            this.labelAñoCreacion.Size = new System.Drawing.Size(58, 17);
            this.labelAñoCreacion.TabIndex = 13;
            this.labelAñoCreacion.Text = "Creada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripcion:";
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Location = new System.Drawing.Point(28, 172);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(49, 17);
            this.labelSubtitulo.TabIndex = 15;
            this.labelSubtitulo.Text = "Datos:";
            // 
            // AdministrarObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 471);
            this.Controls.Add(this.labelSubtitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAñoCreacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelArtista);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxAñoCreacion);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxCreador);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdministrarObras";
            this.Text = "AdministrarObras";
            this.Load += new System.EventHandler(this.AdministrarObras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCreador;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxAñoCreacion;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAñoCreacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSubtitulo;
    }
}