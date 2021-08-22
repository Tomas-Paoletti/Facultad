using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace Juego_obstaculos_segunda_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int mov_enemigos;
            int x = new Random().Next(5, 20), y = 12;
            int xo1 = 20, yo1 = 15;
            int xo2 = 25, yo2 = 5;
            int xo3 = 62, yo3 = 21;
          

            int fin = 0;


            while (fin == 0)
            {
                try
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write("A");
                    Console.SetCursorPosition(xo1, yo1);
                    Console.Write("o");
                    Console.SetCursorPosition(xo2, yo2);
                    Console.Write("o");
                    Console.SetCursorPosition(xo3, yo3);
                    Console.Write("o");
                }
                catch (ArgumentOutOfRangeException)
                {
                    mov_enemigos = 5;
                }
                finally
                {
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow) y -= 1;
                else if (key.Key == ConsoleKey.DownArrow) y += 1;
                else if (key.Key == ConsoleKey.LeftArrow) x -= 1;
                else if (key.Key == ConsoleKey.RightArrow) x += 1;
                

                if (x == xo1 && y == yo1)
                {
                    fin = 1;
                }
                else if (x == xo2 && y == yo2)
                {
                    fin = 1;
                }
                else if (x == xo3 && y == yo3)
                {
                    fin = 1;
                }
                mov_enemigos= new Random().Next(0, 5);

                if (mov_enemigos==1)
                {
                    xo1 += 1;
                    yo2 += 1;
                    xo3 -= 1;
                }else if (mov_enemigos == 2){
                    xo1 -= 1;
                    yo2 -= 1;
                    xo3 += 1;
                }else if (mov_enemigos == 3)
                {
                    yo1 += 1;
                    xo2 += 1;
                    yo3 -= 1;
                }
                else
                {
                    yo1 -= 1;
                    xo2 -= 1;
                    yo3 += 1;
                }


                Thread.Sleep(20);

            }
        }
    }
}
    

