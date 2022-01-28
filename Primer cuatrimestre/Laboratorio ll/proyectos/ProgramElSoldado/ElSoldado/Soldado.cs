using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Soldado
    {
        private Arma _miArma;
        private int _armaEquipada;
       
        public Soldado()
        {
            _armaEquipada = 0;
        }

        public void AgarrarArma(Arma arm)
        {
            if (_armaEquipada == 0)
            {
                Console.WriteLine("Arma equipada!");
                _armaEquipada = 1;
                _miArma = arm;
                _miArma.GetNombre();

            }
            else
            {
                Console.WriteLine(" Ya tienes un arma equipada");

            }
        }
            public void DejarArma()
            {
                if (_armaEquipada == 1)
                {
                Console.WriteLine(" Se soltó el arma: "); _miArma.GetNombre();
                    _armaEquipada = 0;
                }
                else
                {
                    Console.WriteLine("No hay nada que soltar.");
                }
            }


        public void IdentificarArma()
        {
            if (_armaEquipada == 0)
            {
                Console.WriteLine(" El soldado no tiene ningun arma equipada.");
            }
            else
            {
                Console.WriteLine(" Arma actual: ");
                _miArma.GetNombre();
            }
        }




        public void Gatillar()
            {
                if (_armaEquipada == 0)
                {
                    Console.WriteLine("No hay arma equipada");
                }
                else
                {
                Console.WriteLine(" Se disparó: "); _miArma.GetNombre();
                    _miArma.Disparar();
                }
            }


        }





    
}
