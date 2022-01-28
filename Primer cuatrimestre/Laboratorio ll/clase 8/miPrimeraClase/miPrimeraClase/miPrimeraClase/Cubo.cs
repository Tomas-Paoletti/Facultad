using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    class Cubo
    {
        // atributos
        private int lado;
        private int area;
        private int volumen;

        // constructores
        public Cubo()
        {
            lado = 5;
            area = 0;
            volumen = 0;
        }

        public Cubo(string lado)
        {
            int numero = 0;
            try
            {
                numero = Convert.ToInt32(lado);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR: asignó un valor incorrecto");
            }
            this.lado = numero;
        }

        // propiedades
        public int Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        public int Area
        {
            get { return area; }
        }
        public int Volumen
        {
            get { return volumen; }
        }

        // métodos
        public void calcularArea()
        {
            area = (Lado * Lado) * 6;
        }

        public void calcularVolumen()
        {
            volumen = Lado * Lado * Lado;
        }
    }
}
