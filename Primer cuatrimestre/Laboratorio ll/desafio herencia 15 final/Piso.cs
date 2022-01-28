using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_herencia_15_final
{
    class Piso : Inmueble
    {
        private int nroPiso;

        public Piso(double Cant_metros, int Antiguedad, string Direccion, double PrecioBase, int nroPiso) : base(Cant_metros, Antiguedad, Direccion, PrecioBase)
        {
            this.Superficie = Cant_metros;
            this.Antiguedad = Antiguedad;
            this.Direccion = Direccion;
            this.PrecioBase = PrecioBase;
            this.nroPiso = nroPiso;
        }
        public String mostrar()
        {
            return Convert.ToString(PrecioBase);
        }
        public override double calcularPrecio()
        {
           
           if (Antiguedad<15 && Antiguedad > 0)
            {
                
                if (nroPiso >= 3)
                {
                    PrecioBase=(PrecioBase*1.02);
                }
                else PrecioBase =  PrecioBase-(PrecioBase * 0.01) ;

            }
           else if (Antiguedad > 15)
            {
                if (nroPiso >= 3)
                {
                    PrecioBase = PrecioBase * 1.01;
                }
                else PrecioBase =  PrecioBase-(PrecioBase * 0.02) ;
            }else if (nroPiso >= 3)
            {
                PrecioBase = PrecioBase * 1.03;
            }
           
            return PrecioBase;
        }
    }
}
