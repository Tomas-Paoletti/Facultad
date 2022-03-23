using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    abstract class   Arma
    {
        public string _nombre;
        public string _sonido;



        public abstract void Disparar();
        public abstract void  GetNombre();
    }
   
}
