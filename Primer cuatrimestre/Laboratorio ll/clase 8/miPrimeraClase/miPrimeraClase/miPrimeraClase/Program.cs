using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número entero que represente al atributo LADO: ");
            string entrada = Console.ReadLine();

            Cubo miCubo = new Cubo(entrada); // instanciamos un objeto de la clase Cubo

            miCubo.calcularArea();
            miCubo.calcularVolumen();

            Console.WriteLine("Área = {0}, Volumen = {1}.", miCubo.Area, miCubo.Volumen);
        }
    }
}
