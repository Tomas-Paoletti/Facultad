import java.util.Stack;

public class Pila  {
    public Stack<Persona> pila = new Stack<Persona>();

    public Pila() {

    }

    public void AgregarNuevo(Persona p){
        pila.push(p);
    }
    public void ListarDni(int nro) {
        System.out.println("Las personas que superan el numero de dni "+ nro+" son:");

        for (Persona p:pila
             ) {
            if (nro<p.getDNI()){
                System.out.println("Dni: "+p.getDNI());
                System.out.println("Apellido: "+p.getApellido());
                System.out.println("----------------------");
            }

        }

    }

    public void  DsapilarDni(int nro) {
        System.out.println("Las personas que superan el numero de dni "+ nro+" son:");

        for (Persona p:pila
        ) {
            if (nro<p.getDNI()){
                System.out.println("Dni: "+p.getDNI());
                System.out.println("Apellido: "+p.getApellido());
                System.out.println("----------------------");
                pila.remove(p);
            }

        }

    }

}
