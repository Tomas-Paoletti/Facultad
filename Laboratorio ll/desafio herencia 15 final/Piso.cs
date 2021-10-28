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
            this.Cant_metros = Cant_metros;
            this.Antiguedad = Antiguedad;
            this.Direccion = Direccion;
            this.PrecioBase = PrecioBase;
            this.nroPiso = nroPiso;
        }

        public override double calcularPrecio()
        {
            double precioFinal=0;
            if (this.Cant_metros < 50 && this.nroPiso >= 3)
            {
                precioFinal = (double)(this.PrecioBase + (this.PrecioBase * 0.04));
                if (this.Antiguedad < 15 & this.Antiguedad > 0)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.01));

                }
                else if (this.Antiguedad > 15)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.02));

                }
                else precioFinal = PrecioBase;


                
            }
            return precioFinal;
        }
    }
}
