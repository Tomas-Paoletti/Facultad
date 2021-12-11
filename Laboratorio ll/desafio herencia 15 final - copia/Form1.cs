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
      
        double PrecioB, spf,aux;
        int Antig, ventanas, piso;
        String Direc;
       
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void tbxVentanas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (btnCalcular.Enabled == true)
            {
                if (rbtPiso.Checked == true)
                    try { 
                piso = Convert.ToInt32(tbxPiso.Text);
                Direc = tbxDireccion.Text;
                PrecioB = Convert.ToSingle(tbxPreciobase.Text);
                spf = Convert.ToInt32(tbxSuperficie.Text);
                Antig = Convert.ToInt32(tbxAntiguedad.Text);
                Piso dpto = new Piso(spf, Antig, Direc, PrecioB, piso);
                MessageBox.Show("El Precio total es: " + dpto.calcularPrecio());

                    }
                    catch (Exception a)
            {
                        MessageBox.Show(Convert.ToString( a));
            }
          
               

            }
           // Local local1 = new Local((int)CantMetros, Direccion,  Antiguedad, PrecioBase, ventanas);
        }
    }
}
