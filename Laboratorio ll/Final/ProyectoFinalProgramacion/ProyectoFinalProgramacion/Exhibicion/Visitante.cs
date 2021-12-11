using System;
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
    public partial class Visitante : Form
    {
        public Visitante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EXCuadrosTitulos ml = new EXCuadrosTitulos(1);
            ml.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            EXCuadrosTitulos ml = new EXCuadrosTitulos(2);
            ml.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EXCuadrosTitulos ml = new EXCuadrosTitulos(3);
            ml.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            EXCuadrosTitulos ml = new EXCuadrosTitulos(4);
            ml.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EXCuadrosTitulos ml = new EXCuadrosTitulos(5);
            ml.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EXCuadrosTitulos ml = new EXCuadrosTitulos(11);
            ml.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
