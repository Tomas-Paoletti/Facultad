using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase_lab2_
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero ,vidas;
            vidas = 13;
            Random r = new Random();
            int aleatorio = r.Next(1, 10001);
            numero = 0;
            Console.WriteLine("Adivina el numero entre 1 y 10.000, tienes 13 vidas");
            while (vidas > 0 || numero != aleatorio)
            {
                Console.WriteLine("Indica el numero que creas: "); numero = Convert.ToInt32(Console.ReadLine());

                if (numero == aleatorio)
                    Console.WriteLine("Correcto, has acertado el numero");


                else
                {
                    if (numero < aleatorio)
                    {
                        Console.WriteLine("Prueba un numero mas alto");
                        vidas--;

                    }
                    else if (numero > aleatorio)
                    {
                        Console.WriteLine("Prueba un numero mas bajo");
                        vidas--;
                    }



                   
                    Console.WriteLine("Las vidas restantes son: " + vidas);
                    Console.WriteLine("Presione Enter para seguir intentando");
                    Console.ReadKey();
                    
                }
                
            }
            if (vidas == 0)
            {
                Console.WriteLine("El numero a adivinar era: " + aleatorio);
            }
            Console.WriteLine("FIN DEL JUEGO....");
            Console.ReadKey();
        }
    }
}
