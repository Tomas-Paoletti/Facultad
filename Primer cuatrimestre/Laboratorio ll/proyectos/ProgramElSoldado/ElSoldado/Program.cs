using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado miSoldado = new Soldado();
            Revolver magnum = new Revolver();
            Rifle mkll = new Rifle();
            Escopeta spas = new Escopeta();
            int opc = 0;
            int armaEquipada;

            Console.WriteLine("Este es el progrmama del soldado");

            do
            {
                Console.WriteLine("--MENU--");
                Console.WriteLine("1: ELEGIR ARMA");
                Console.WriteLine("2: DEJAR ARMA");
                Console.WriteLine("3: DISPARAR ARMA ");
                Console.WriteLine("4: MOSTRAR ARMA");
               

                try
                {
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc) {
                        case 1:
                            {
                                try
                                {
                                    Console.WriteLine("Elija su arma:");
                                    Console.WriteLine("1 M686  Magnum");
                                    Console.WriteLine("2 Rifle MKII");
                                    Console.WriteLine("3 Escopeta SPAS");
                                    Console.WriteLine("4 Cancelar. ");
                                    armaEquipada = Convert.ToInt32(Console.ReadLine());
                                    switch (armaEquipada)
                                    {
                                        case 1:
                                            miSoldado.AgarrarArma(magnum);
                                            break;
                                        case 2:
                                            miSoldado.AgarrarArma(mkll);
                                            break;
                                        case 3:
                                            miSoldado.AgarrarArma(spas);
                                            break;
                                    }

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR");
                                }
                                break;
                            }

                                case 2:
                                 miSoldado.DejarArma();
                                 break;
                                  case 3:
                                  miSoldado.Gatillar();
                                  break;
                                 case 4:
                                 miSoldado.IdentificarArma();
                                  break;

                            }
                    }
                     catch(Exception)
                {
                    Console.WriteLine("ERROR");
                }
                if (opc != 5) continue;
                Console.WriteLine("Saliendo....");
                    opc= 5;


                
            } while (opc != 5);
        }
    }
}
