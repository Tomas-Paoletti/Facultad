using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio_herencia_15_final
{
    public partial class Form1 : Form
    {
        double Precio_x_metro = 150, CantMetros;
        double PrecioBase;
        int Antiguedad, ventanas;
        String Direccion;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (btnCalcular.Enabled == true)
            {
                tbxPiso
            }
            Local local1 = new Local((int)CantMetros, Direccion,  Antiguedad, PrecioBase, ventanas);
        }
    }
}
