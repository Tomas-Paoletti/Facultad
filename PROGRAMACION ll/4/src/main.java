public class main {/*
Crear una clase Cuenta la cual se caracteriza por tener asociado un número de
cuenta y un saldo disponible. Además, se puede consultar el saldo disponible
en cualquier momento, recibir abonos y pagar recibos. Crear además una clase
Persona, que se caracteriza por un DNI y una cuenta bancaria. La clase
Persona debe contener un método que devuelva si la persona es morosa, y si
tiene alguna cuenta con saldo negativo. Hacer un sistema que instancie un
objeto Persona con un DNI cualquiera, así como dos objetos cuenta, una sin
saldo inicial y otra con $1200. La persona recibe el sueldo, por lo que ingresa
$5500 en la primera cuenta, pero tiene que pagar el primer alquiler de $2500
con la segunda. Imprimir en pantalla si la persona es morosa. Posteriormente
hacer una transferencia de una cuenta a la otra y comprobar mostrándolo por
pantalla que cambia el estado de la persona*/
    public static  void main (String[] args){
        Cuenta c[]= new Cuenta[2];
        c[1]= new Cuenta(100, )
        c[2]=new Cuenta(102, 1200);
        Persona p = new Persona(4354562,c[1], c[2]);

        p.cta[1].Recargar(5500);
        p.cta[1].pagar(1300);
        p.cta[2].Recargar(1300);
        p.cta[2].pagar()(1300);
        p.VerificarSaldo();
    }
}
