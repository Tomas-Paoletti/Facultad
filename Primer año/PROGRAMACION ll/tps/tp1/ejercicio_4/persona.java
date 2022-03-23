package ejercicio4;
import java.util.Scanner;
public class persona {
    
    //Atributos
    private final int dni; //atributo "dni" está en la clase persona y en el main. La variable
    cuenta cuenta1=new cuenta();
    cuenta cuenta2=new cuenta(1,1200);
    //cuenta cuenta3=new cuenta(); en el caso de agregar una tercera cuenta
    
    //Constructores
    public persona(){
        this.dni=0;
    }
    
    //Metodos
    public void dni(){
        System.out.println("Su DNI es: "+this.dni);
    }
    public void transferencia(){
        Scanner entrada=new Scanner(System.in);
        int opc;
        double monto;
        System.out.println("Ingrese el monto a transferir");
        monto=entrada.nextDouble(); //Se ingresa el valor para operar
        
        System.out.println("Ingrese la opcion deseada");
        System.out.println("1- Transferir de la cuenta 1 a la cuenta 2.");
        System.out.println("2- Transferir de la cuenta 2 a la cuenta 1.");
        opc=entrada.nextInt();
        switch(opc){ //menu de operaciones 
            case 1:{
                //El usuario debería elegir entre qué cuentas quiere operar en el caso de una tercer cuenta con un if o switch
                cuenta1.abono(monto);
                cuenta2.recibo(monto);
                break;
            }   
            case 2:{
                //mismo caso que en el case anterior.
                cuenta2.abono(monto);
                cuenta1.recibo(monto);
                break;
            }
        }
    }
    public void morosidad(){
        System.out.println("Cuenta 1:");
        /*Sería conveniente estructurar este bloque con un "If" o con un "switch", de manera que el usuario pueda elegir qué 
        cuenta quiere chequear*/
        
        if(cuenta1.getSaldo()<0)
            System.out.println("La persona presenta deuda");
        else
            System.out.println("La persona no presenta deuda");
                                                                    //Imprime las dos cuentas por pantalla
        System.out.println("Cuenta 2:");
        if(cuenta2.getSaldo()<0)
            System.out.println("La persona presenta deuda");
        else
            System.out.println("La persona no presenta deuda");
    }
}