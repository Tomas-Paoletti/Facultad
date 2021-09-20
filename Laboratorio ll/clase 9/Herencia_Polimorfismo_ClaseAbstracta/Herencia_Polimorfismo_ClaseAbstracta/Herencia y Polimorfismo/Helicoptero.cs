using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_Polimorfismo
{
    class Helicoptero:Vehiculo
    {
        public override void Estacionarse() //implementación del método abstracto de la superclase
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1) El piloto acomoda el helicóptero sobre el espacio de estacionamiento.");
            Console.WriteLine("2) El piloto realiza maniobra de aterrizaje.");
            Console.WriteLine("3) El piloto apaga los motores.");
            Console.WriteLine("4) El Helicóptero " + this.Nombre + " se estacionó con éxito.");
        }
    }
}
