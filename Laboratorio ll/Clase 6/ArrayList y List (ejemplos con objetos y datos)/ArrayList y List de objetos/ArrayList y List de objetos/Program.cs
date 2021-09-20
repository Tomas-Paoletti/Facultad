using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_y_List_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {

            // ARRAYLIST
            // Un arraylist de objetos lo podemos usar cuando tenemos que guardar
            // objetos de distinto tipo en la colección.
            // A diferencia de los arreglos unidimensionales, el arraylist es una estructura dinámica,
            // es decir que puede contener una cantidad variable de elementos en cada momento.
            #region ARRAYLIST DE OBJETOS
            Console.WriteLine("- - - - - - ARRAYLIST DE OBJETOS Y DATOS DE DISTINTO TIPO - - - - - -");
            
            // Primero creamos un arraylist
            ArrayList arrayDeObjetos = new ArrayList();

            // Creamos un objeto de cada clase y asignamos un valor a su atributo
            Clase1 objeto1 = new Clase1();
            objeto1.atributo1 = "Objeto de la clase 1";
            Clase2 objeto2 = new Clase2();
            objeto2.atributo1 = "Objeto de la clase 2";

            // Agregamos los objetos al arraylist
            arrayDeObjetos.Add(objeto1);
            arrayDeObjetos.Add(objeto2);

            // Como en un arraylist podemos guardar objetos de distinto tipo, vamos a
            // guardar un número de tipo float y una cadena.
            arrayDeObjetos.Add(2.5f);
            arrayDeObjetos.Add("Otro tipo de dato almacenado en el arraylist.");

            // Recorremos el arraylist
            foreach (object objetoDeTipoDesconocido in arrayDeObjetos)
            {
                // Como no sabemos de qué Clase es el objeto que se encuentra
                // en el arraylist, necesitamos obtener el Type (tipo de objeto)
                Type tipo = objetoDeTipoDesconocido.GetType();

                // Y luego sólo nos falta escribir el código
                // según el tipo de objeto que estamos leyendo en el arraylist
                switch (tipo.Name)
                {
                    // Si el objeto es de tipo Clase1
                    case "Clase1":
                        // Creamos un objeto del tipo Clase1 y le asignamos el objeto que estamos leyendo en el arraylist
                        Clase1 objetoDeClase1 = (Clase1)objetoDeTipoDesconocido;
                        // Mostramos su atributo1
                        Console.WriteLine(objetoDeClase1.atributo1);
                        break;

                    // Si el objeto es de tipo Clase2
                    case "Clase2":
                        // Creamos un objeto del tipo Clase2 y le asignamos el objeto que estamos leyendo en el arraylist
                        Clase2 objetoDeClase2 = (Clase2)objetoDeTipoDesconocido;
                        // Mostramos su atributo
                        Console.WriteLine(objetoDeClase2.atributo1);
                        break;

                    case "Single":
                        Console.WriteLine(objetoDeTipoDesconocido.ToString());
                        break;

                    case "String":
                        Console.WriteLine(objetoDeTipoDesconocido.ToString());
                        break;

                    // Si el objeto es de cualquier otro tipo
                    default:
                        break; // Lo ignoramos y pasamos al siguiente objeto
                }
                #endregion
            }

                // LIST DE OBJETOS
                // Una list de objetos la podemos utilizar cuando tenemos que guardar
                // objetos del mismo tipo en la colección.
                #region LIST DE OBJETOS
                Console.WriteLine("\n\n");
                Console.WriteLine("- - - - - - LIST DE OBJETOS - - - - - -");
                
                // Primero creamos una List de un tipo de objeto determinado
                List<Clase1> objetosDeTipoClase1 = new List<Clase1>();

                // Ahora podemos crear algunos objetos de tipo Clase1
                Clase1 objeto3 = new Clase1();
                objeto3.atributo1 = "Objeto de la clase 1";
                Clase1 objeto4 = new Clase1();
                objeto4.atributo1 = "Otro objeto de la clase 1";
                Clase1 objeto5 = new Clase1();
                objeto5.atributo1 = "Otro más...";

                // Y los agregamos a la lista
                objetosDeTipoClase1.Add(objeto3);
                objetosDeTipoClase1.Add(objeto4);
                objetosDeTipoClase1.Add(objeto5);

                // Si intentáramos agregar un objeto que no sea de tipo Clase1
                // tendríamos un error de compilación
                // objetosDeTipoClase1.Add(objeto2);

                // Ahora sólo nos queda recorrer la lista y mostrar los atributos
                foreach (Clase1 objeto in objetosDeTipoClase1)
                {
                    Console.WriteLine(objeto.atributo1);
                }


                Console.WriteLine("\n\n");
                Console.WriteLine("- - - - - - LIST DE NÚMEROS ENTEROS - - - - - -");
                // Si quisiéramos crear una list de números enteros
                List<int> listaDeTipoInt = new List<int>();
                // Agregamos algunos valores a nuestra list
                listaDeTipoInt.Add(25);
                listaDeTipoInt.Add(83);
                listaDeTipoInt.Add(-25);
                // Recorremos la lista y mostrar los elementos
                foreach (int numero in listaDeTipoInt)
                {
                    Console.WriteLine(numero.ToString());
                }
            #endregion

            Console.ReadKey();
        }
    }
    class Clase1
    {
        public string atributo1;
    }
    class Clase2
    {
        public string atributo1;
    }
}
