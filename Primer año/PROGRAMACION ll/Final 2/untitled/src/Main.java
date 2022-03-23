import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.Stack;

public class Main {
    public static void  main (String args[]) throws VaciaExcepcion {
        Scanner att = new Scanner(System.in);
        Scanner entrada = new Scanner(System.in);
        int dni;
        String Apellido;
        Pila pilaPersonas = new Pila();
        int opc, numero;
        try {

        for (int i=0 ; i<= condicion; i++ )
            do {
                System.out.println("Que desea hacer");
                opc = entrada.nextInt();
                System.out.println("1: Ingresar una nueva persona");
                Persona nuevo = new Persona();
                nuevo.llenarDatos();

                pilaPersonas.AgregarNuevo(nuevo);

                System.out.println("2: Listar Personas segun dni a numero");
                System.out.println("Ingrese el numero desde el cual quere listar los dni");
                numero = att.nextInt();
                if (pilaPersonas.pila.empty())  {
                    throw new VaciaExcepcion("Error pila vacia");
                }
                pilaPersonas.ListarDni(numero);
                System.out.println("3:  Mostrar y desapilar segun dni sea mayor a numero");
                if (pilaPersonas.pila.empty())  {
                    throw new VaciaExcepcion("Error pila vacia");
                }
                System.out.println("Ingrese el numero desde el cual quere listar los dni");
                numero = att.nextInt();
                pilaPersonas.DsapilarDni(numero);
                System.out.println("4: Salir");


            } while (opc != 4);
            System.out.println("SALIENDO.....");
        }catch (Exception e){
            System.out.println(e.getMessage());
        }


    }
        public static int RecorrerArregoloRecursivo(int arreglo[], int posicion){
        if(!=arreglo.length){
                System.out.println("Posicion "+posicion+" "+ arreglo[posicion]);
                RecorrerArregoloRecursivo(int Arreglo+ posicion+1)
            }
        }
}
