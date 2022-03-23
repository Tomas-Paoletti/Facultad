package ejercicio4;
import java.util.Scanner;
public class Ejercicio4 {

    public static void main(String[] args) {
        
        Scanner entrada=new Scanner(System.in);
        
        persona persona1=new persona();
        
        int menu;
        String nombre; // No se utiliza
        int dni;        
        double monto;
        int opc;
        
        System.out.println("Ingrese su nombre");
        nombre=entrada.nextLine();
        
        System.out.println("Ingrese su DNI");
        dni=entrada.nextInt(); 
        
        //Menu
        do{
            do{
                System.out.println("-----------------------------------------");
                System.out.println("Ingrese el numero de la opcion deseada");
                System.out.println("");
                System.out.println("1- Consultar saldo");
                System.out.println("2- Recibos");
                System.out.println("3- Pagar cuentas");
                System.out.println("4- Transferir");
                System.out.println("5- Salir");
                System.out.println(""); 
                
                menu=entrada.nextInt();
            }while(menu<1 && menu>5);
            
            switch(menu){
                case 1:{
                    System.out.println("Cuenta 1:");
                    persona1.cuenta1.saldo();
                    System.out.println("Cuenta 2:");
                    persona1.cuenta2.saldo();
                    System.out.println("");
                    persona1.morosidad();
                    break;
                }
                case 2:{
                    System.out.println("Ingrese el monto a cobrar");
                    monto=entrada.nextDouble();
                    System.out.println("Indique la cuenta en la que quiere depositar el recibo");
                    opc=entrada.nextInt();
                    switch(opc){
                        case 1:{
                            persona1.cuenta1.recibo(monto);
                            break;
                        }
                        case 2:{
                            persona1.cuenta2.recibo(monto);
                            break;
                        }
                    }
                    break;
                }
                case 3:{
                    System.out.println("Ingrese el monto a abonar");
                    monto=entrada.nextDouble();
                    System.out.println("Indique la cuenta con la quiere quiere realizar el pago");
                    opc=entrada.nextInt();
                    switch(opc){
                        case 1:{
                            persona1.cuenta1.abono(monto);
                            break;
                        }
                        case 2:{
                            persona1.cuenta2.abono(monto);
                            break;
                        }
                    }
                    break;
                }
                case 4:{
                    persona1.transferencia();
                    break;
                }
            }
        }while(menu!=5);
    }
}


