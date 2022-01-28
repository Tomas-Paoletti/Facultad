using MySql.Data.MySqlClient;
using ProyectoFinalProgramacion.Admin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacion
{
    public partial class IniciarSesionAdministrador : Form
    {
        private Hashtable DatosUsuario = new Hashtable();

        Usuario iniciarSesion = new Usuario();
        public IniciarSesionAdministrador()
        {
            InitializeComponent();
            
            iniciarSesion.CargarUsuarios();
            
        }

      
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
           
            

            String Usuario = textBoxUsuario.Text;
            String Contraseña = textBoxContraseña.Text;
           



            int tipoSesion = iniciarSesion.VerificarUsuarioInicio(textBoxUsuario.Text, textBoxContraseña.Text);

            if (tipoSesion == 1)
            {
                AdministrarObras nn = new AdministrarObras(1);
                nn.Show();
            }else if (tipoSesion == 2)
            {
                AdministrarObras nn = new AdministrarObras(2);
                nn.Show();
            }else
            {
                MessageBox.Show("Usuario o contraseña incorrectos intente nuevamente");
                textBoxContraseña.Clear();
                textBoxContraseña.Focus();
            }
        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void IniciarSesionAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
            this.Close();
        }
    }
}
