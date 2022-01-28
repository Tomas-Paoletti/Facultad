using ProyectoFinalProgramacion.Objetos;
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
    public partial class EXCuadrosTitulos : Form
    {
        public EXCuadrosTitulos(int id)
        {
            InitializeComponent();
            if (id <= 3) { }

            Cuadro cuadros = new Cuadro();
            cuadros.Exhibir(id);
            labelnomb.Text = cuadros.NObra1;
            labelCreacion.Text = cuadros.Anio1;
            groupBoxDescripcion.Text = cuadros.Descripcion1;
            labelCreador.Text = cuadros.Pintor1;
            

            if (id == 1) {
                pictureBox1.Image = ProyectoFinalProgramacion.Properties.Resources.Mona_lisa;
            } else if (id == 2)
            {
                pictureBox1.Image = ProyectoFinalProgramacion.Properties.Resources.La_balsa_de_la_medusa;
            } else if (id == 3)
            {
                pictureBox1.Image = ProyectoFinalProgramacion.Properties.Resources.La_Libertad_Guiando_Al_Pueblo;
            }
            else {
                Escultura esculturas = new Escultura();
                esculturas.Exhibir(id);
                labelnomb.Text = esculturas.NObra1;
                labelCreacion.Text = esculturas.Anio1;
                groupBoxDescripcion.Text = esculturas.Descripcion1;
                labelCreador.Text = esculturas.Escultor1;
            } if (id == 4)
            {
                labelArtista.Text = "Escultor: ";
                pictureBox1.Image = ProyectoFinalProgramacion.Properties.Resources.tumba_de_philippe_1;
            }else if (id == 5)
            {
                labelArtista.Text = "Escultor: ";
                pictureBox1.Image = ProyectoFinalProgramacion.Properties.Resources.Victoria_de_samotracia_1_768x1024;
            }else if (id == 6)
            {
                labelArtista.Text = "Escultor: ";
                pictureBox1.Image = ProyectoFinalProgramacion.Properties.Resources.Tríada_de_Osorkon_II
                    ;
            }
        }

        private void EXCuadros_Load(object sender, EventArgs e)
        {

        }
    }

       

       
    }

