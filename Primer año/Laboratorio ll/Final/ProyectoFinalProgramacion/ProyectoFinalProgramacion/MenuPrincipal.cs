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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            IniciarSesionAdministrador Login = new IniciarSesionAdministrador();
            Login.Show();
            this.Hide();

        }

        private void buttonInvitado_Click(object sender, EventArgs e)
        {
            Visitante vs = new Visitante();
            vs.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
