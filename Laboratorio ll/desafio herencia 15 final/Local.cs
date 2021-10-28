using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_herencia_15_final
{
    class Local : Inmueble

    {

        private int nroVentanas;
        public Local(int Cant_metros, String direccion, int antiguedad, double precio, int ventanas) : base(Cant_metros, antiguedad, direccion,  precio)
        {
        
            this.Cant_metros = Cant_metros;
            this.Direccion = direccion;
            this.Antiguedad = antiguedad;
            this.PrecioBase = precio;
            this.nroVentanas = ventanas;
        }
        

        public override double calcularPrecio()
        {
            double precioFinal=0;
            if (this.Cant_metros < 50 && this.nroVentanas <= 1)
            {
                precioFinal = (double)(this.PrecioBase + (this.PrecioBase * 0.02));
                if (this.Antiguedad < 15 & this.Antiguedad > 0)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.01));

                }
                else if (this.Antiguedad > 15)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.02));

                }
                else;
            
            }
            else if (this.Cant_metros < 50 && this.nroVentanas >= 4)
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
                else
                    precioFinal = (double)(this.PrecioBase + (this.PrecioBase * 0.02));

                if (this.Antiguedad < 15 & this.Antiguedad > 0)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.01));
                    

                }
                else if (this.Antiguedad > 15)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.02));
                   

                }
                else;
               
            }
            else if (this.Cant_metros >= 50 && this.nroVentanas <= 1)
            {
                precioFinal = (double)((this.PrecioBase * 1.01) - (this.PrecioBase * 0.02));

                precioFinal = (double)(this.PrecioBase + (this.PrecioBase * 0.02));
                if (this.Antiguedad < 15 & this.Antiguedad > 0)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.01));
                  
                }
                else if (this.Antiguedad > 15)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.02));
                   
                }
            
            }
            else if (this.Cant_metros >= 50 && this.nroVentanas >= 1)
            {
                precioFinal = (double)((this.PrecioBase * 1.01) + (this.PrecioBase * 0.02));
                precioFinal = (double)(this.PrecioBase + (this.PrecioBase * 0.02));
                if (this.Antiguedad < 15 & this.Antiguedad > 0)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.01));
                    
                }
                else if (this.Antiguedad > 15)
                {
                    precioFinal = (double)(precioFinal - (precioFinal * 0.02));
                    
                }
            }

            return precioFinal;
            }
        }

    }

