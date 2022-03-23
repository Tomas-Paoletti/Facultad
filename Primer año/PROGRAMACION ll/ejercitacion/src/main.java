import java.util.Scanner;

public class main {
    public static void main (String args[]){
        Scanner at = new Scanner(System.in);
        int numero;

        System.out.println("ingrese el  orden de fibonacci que desea ver");
        numero=at.nextInt();
        System.out.println("el numero en fibonacci es: "+recursivo.fibonacci(numero));
    }
}
