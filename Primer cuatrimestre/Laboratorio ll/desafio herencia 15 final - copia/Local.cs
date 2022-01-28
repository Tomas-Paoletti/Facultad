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
        
            this.Superficie = Cant_metros;
            this.Direccion = direccion;
            this.Antiguedad = antiguedad;
            this.PrecioBase = precio;
            this.nroVentanas = ventanas;
        }
       

        public override double calcularPrecio()
        {
            if (Antiguedad < 15 && Antiguedad > 0)
            {


                if (Superficie > 50)
                {
                    if (nroVentanas == 0 || nroVentanas == 1)
                    {
                        PrecioBase = PrecioBase - (PrecioBase * 0.01);
                    }
                    else if (nroVentanas >= 4)
                    {
                        PrecioBase *= 1.03;
                    }
                    else PrecioBase = PrecioBase * 1.01;
                }
                else PrecioBase -= (PrecioBase * 0.01);
                

            }else if (Antiguedad > 15)
            {

                if (Superficie > 50)
                {
                    if (nroVentanas == 0 || nroVentanas == 1)
                    {
                        PrecioBase = PrecioBase - (PrecioBase * 0.01);
                    }
                    else if (nroVentanas >= 4)
                    {
                        PrecioBase *= 1.03;
                    }
                    else PrecioBase = PrecioBase * 1.01;
                }
                else PrecioBase -= (PrecioBase * 0.02);
            }
            else {
                if (Superficie > 50)
                {
                    if (nroVentanas == 0 || nroVentanas == 1)
                    {
                        PrecioBase = PrecioBase - (PrecioBase * 0.01);
                    }
                    else if (nroVentanas >= 4)
                    {
                        PrecioBase *= 1.03;
                    }
                    else PrecioBase = PrecioBase * 1.01;
                }

            }
            return PrecioBase;
            }
        }

    }

