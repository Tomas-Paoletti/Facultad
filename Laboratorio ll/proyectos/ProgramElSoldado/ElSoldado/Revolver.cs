using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Revolver :Arma
    {
       
        public override void GetNombre()
        {
            _nombre = "Revolver M686 Magnum";
            Console.WriteLine("El arma equipadas es: una  " + _nombre);
        }
        public override void Disparar()
        {
            Console.WriteLine("PUM!");
        }
    }
}
