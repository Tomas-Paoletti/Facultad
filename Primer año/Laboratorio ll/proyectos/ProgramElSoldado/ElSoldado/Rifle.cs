using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Rifle : Arma
    {
        public override void GetNombre()
        {
            _nombre = "Rifle MKII";
            Console.WriteLine("El arma equipadas es: una  " + _nombre);
        }
        public override void Disparar()
        {
            Console.WriteLine("PUM! PUM! PUM!");
        }
    }
}
