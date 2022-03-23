import java.util.Scanner;

public class main {
    public static void main (String args[]) throws ExceptioNroNrgativo {
        Scanner at = new Scanner(System.in);
        int numero;
        try {

            System.out.println("ingrese el orden de numero que desea ver");
            numero=at.nextInt();
            if (numero<0){
                throw new ExceptioNroNrgativo("Error: ah ingresado un nro negativo");
            }
            System.out.println(Matematica.fibonacci(numero));

        }catch(java.lang.Exception e){
            System.out.println(e.getMessage());
        }
    }
}
