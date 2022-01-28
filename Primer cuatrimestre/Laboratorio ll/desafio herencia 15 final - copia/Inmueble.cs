using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_herencia_15_final
{
      abstract class  Inmueble 
    {

        //declaramos los atributos padres
        protected double  Superficie ;
        protected double PrecioBase;
        protected int Antiguedad;
        protected String Direccion;
        //constructor
        public Inmueble(double Cant_metros, int Antiguedad, String Direccion, double PrecioBase)
        {
            this.Superficie = Cant_metros;
            this.Antiguedad = Antiguedad;
            this.PrecioBase = PrecioBase;
            this.Direccion = Direccion;
        }
        //metodos

        public abstract double calcularPrecio();
    }
}
