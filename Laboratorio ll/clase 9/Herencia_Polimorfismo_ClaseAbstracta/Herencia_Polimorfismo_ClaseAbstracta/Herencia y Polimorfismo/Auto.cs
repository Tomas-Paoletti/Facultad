using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_Polimorfismo
{
    class Auto : Vehiculo
    {
        public override void Estacionarse() //implementación del método abstracto de la superclase
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1) Los sensores del auto miden el espacio para estacionar.");
            Console.WriteLine("2) El auto se coloca en posición paralela a su espacio de estacionamiento.");
            Console.WriteLine("3) El sistema automático del auto realiza manioba de estacionamiento.");
            Console.WriteLine("4) Los sensores del auto corrigen la posición final.");
            Console.WriteLine("5) El auto " + this.Nombre + " se estacionó con éxito.");
        }
    }
}
