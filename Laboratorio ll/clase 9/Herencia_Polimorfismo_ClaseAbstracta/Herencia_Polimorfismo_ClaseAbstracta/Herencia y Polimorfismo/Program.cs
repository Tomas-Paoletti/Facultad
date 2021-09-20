using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_Polimorfismo
{
    // VEMOS UN POCO DE POLIMORFISMO, HERENCIA Y CLASE ABSTRACTA
    class Program
    {
        static void Main(string[] args)
        {
            // Primero creamos dos vehículos distintos
            Auto auto = new Auto();
            auto.Nombre = "Chevrolet Onix";

            Helicoptero heli = new Helicoptero();
            heli.Nombre = "Bell AH - 1 Cobra";

            // Luego creamos un array que contendrá objetos de tipo vehículo
            Vehiculo[] vehiculos = new Vehiculo[2];

            // Y almacenamos dentro del array los objetos creados anteriormente
            vehiculos[0] = auto; //auto es un objeto de tipo Auto, que a su vez es un vehículo.
            vehiculos[1] = heli; //heli es un objeto de tipo Helicoptero, que a su vez es un vehículo.

            // Finalmente hacemos Polimorfismo
            foreach (Vehiculo vehiculo in vehiculos)
            {
                // No me importa si el vehiculo es un auto o un helicóptero, aquí estoy invocando
                // el método Estacionarse de cada tipo de vehículo.
                vehiculo.Estacionarse(); 
            }

        }
    }
}
