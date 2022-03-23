import java.util.Scanner;
import java.util.Stack;

public class Persona {
    Scanner entrada = new Scanner(System.in);
    Scanner et= new Scanner(System.in);
    private String Apellido;
    private Integer DNI;

    public String getApellido() {
        return Apellido;
    }

    public Integer getDNI() {
        return DNI;
    }

    public Persona() {

    }
    public void llenarDatos(){
        System.out.println("ingrese el nombre");
        Apellido=entrada.nextLine();
        System.out.println("Ingrese el Dni");
        DNI= et.nextInt();
    }
}
