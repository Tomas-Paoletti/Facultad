using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_y_Polimorfismo
{
    abstract class Vehiculo  // CLASE ABSTRACTA
    {
        // Atributo no abstracto
        private string nombre;

        // Propiedad no abstracta
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        // Métodos
        public Vehiculo() { } // Constructor
        public abstract void Estacionarse(); //Método abstracto (será implementado en clases hijas)
    }
}
