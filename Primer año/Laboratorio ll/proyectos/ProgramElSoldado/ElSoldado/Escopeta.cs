using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class  Escopeta : Arma
    {

        public override void Disparar()
        {
            Console.WriteLine("PAAA!");
        }
        public override void GetNombre()
        {
            _nombre = "Escopeta SPAS-12";
            Console.WriteLine("El arma equipadas es: una  " + _nombre);
        }
    }
}
