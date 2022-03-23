using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacion.Admin
{
    public partial class AdministrarObras : Form
    {
        private int tipo;
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=museo; Uid=root; Pwd=1qazzaq1;");
        BDAdmin baseDatos = new BDAdmin();

       // private static AdministrarObras instance;

       // public static AdministrarObras Instance { get => instance; set => instance = value; }

        public AdministrarObras(int tipo)
        {
            InitializeComponent();

            this.tipo = tipo;
           

           String instruccion;
            if (tipo == 2)
            {
               
                labelSubtitulo.Text = "Datos Esculturas:";
            }
            else
            {
                instruccion = "SELECT * FROM obras WHERE tipo=1";
                labelSubtitulo.Text = "Datos Cuadros:";
            }



            try
            {
              
                baseDatos.PrenderBase();
               
            }
            catch (Exception )
            {
                MessageBox.Show( "ERROR");
            }
           
            dataGridView1.DataSource = baseDatos.CargarDatos(tipo);

            baseDatos.ApagarBase();

        }
       

        private void AdministrarObras_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            
            try

            {
               /* String Nombre = textBoxnombre.Text;
                String creador = textBoxCreador.Text;
                String Descripcion = textBoxDescripcion.Text;
                int aniocereacion = Convert.ToInt32(textBoxAñoCreacion.Text);
                int id = Convert.ToInt32(textBoxid.Text);*/

                baseDatos.PrenderBase();
                /* MySqlCommand comando = new MySqlCommand();
                 comando.Connection = conexion;
                 comando.CommandText= ("INSERT INTO obras(AñoCreacion,Creador,Descripcion,NombreDeLaObra,tipo) VALUES('" + aniocereacion + "','" + creador + "','" + Descripcion + "', '" + Nombre + "','" + this.tipo + "');");
                 comando.ExecuteNonQuery();*/
                baseDatos.AgregarDatos(textBoxnombre.Text,Convert.ToInt32( textBoxAñoCreacion.Text) , textBoxCreador.Text, textBoxDescripcion.Text,Convert.ToInt32( textBoxid.Text), tipo);
                baseDatos.ApagarBase();
                MessageBox.Show("Datos guardados");           }
            catch(Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Error: ");
            }
           
            if (tipo == 2)
            {
              
                labelSubtitulo.Text = "Datos Esculturas:";
            }
            else
            {
              
                labelSubtitulo.Text = "Datos Cuadros:";
            }



            try
            {
                baseDatos.PrenderBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
           
            dataGridView1.DataSource = baseDatos.CargarDatos(tipo);
            baseDatos.ApagarBase();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

            baseDatos.PrenderBase();
          
            if (textBoxid.Text == "") MessageBox.Show("Error: Ingrese el id");
            
            baseDatos.BorrarDatos(Convert.ToInt32(textBoxid.Text));



       
          
            MessageBox.Show("Eliminado Correctamente");
            textBoxAñoCreacion.Text = " ";
            textBoxCreador.Text = "";
            textBoxDescripcion.Text = "";
            textBoxid.Text = "";
            textBoxnombre.Text = "";
           
            if (tipo == 2)
            {
                labelSubtitulo.Text = "Datos Esculturas:";
            }
            else
            {
                labelSubtitulo.Text = "Datos Cuadros:";
            }
            dataGridView1.DataSource = baseDatos.CargarDatos(tipo);
            baseDatos.ApagarBase();

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            baseDatos.PrenderBase();
            /* String actualizar = "UPDATE obras SET idObras='" + textBoxid.Text + "',AñoCreacion='" + textBoxAñoCreacion.Text + "',Creador='" + textBoxCreador.Text+ "',Descripcion='" + textBoxDescripcion.Text + "',NombreDeLaObra='" + textBoxnombre.Text + "'WHERE idObras='" + textBoxid.Text + "';";
             MySqlCommand comando = new MySqlCommand(actualizar, conexion);
             comando.ExecuteNonQuery();*/
            baseDatos.ModificarDatos(Convert.ToInt32(textBoxid.Text), Convert.ToInt32(textBoxAñoCreacion.Text), textBoxnombre.Text, textBoxDescripcion.Text, textBoxCreador.Text);

            textBoxAñoCreacion.Text = " ";
            textBoxCreador.Text="";
            textBoxDescripcion.Text = "";
            textBoxid.Text = "";
            textBoxnombre.Text="";

            String instruccion;
            if (tipo == 2)
            {
               
                labelSubtitulo.Text = "Datos Esculturas:";
            }
            else
            {
               
                labelSubtitulo.Text = "Datos Cuadros:";
            }
          
            dataGridView1.DataSource = baseDatos.CargarDatos(tipo);
            baseDatos.ApagarBase();


            MessageBox.Show("Los datos se actualizaron correctamente");

                }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                textBoxid.Text = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                textBoxAñoCreacion.Text = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
                textBoxDescripcion.Text = (string)dataGridView1.SelectedRows[0].Cells[2].Value;
                textBoxnombre.Text = (string)dataGridView1.SelectedRows[0].Cells[3].Value;
            }
            catch (Exception)
            {
                return;
            }
            }

       
    }
}
