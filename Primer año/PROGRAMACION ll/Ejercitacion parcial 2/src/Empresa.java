import java.util.ArrayList;
import java.util.Scanner;

public class Empresa {
    ArrayList<Celular> ListCel = new ArrayList<Celular>();
    Scanner as = new Scanner(System.in);
    int nro;
    public void Agregar(){
        Celular cel = new Celular();
        ListCel.add(cel);

    }

    public void Listar (){
        for (Celular c:ListCel
             ) {
            System.out.println("ingrese el numero de serie");
            if(nro==c.NroSerie){
                c.MostrarInfo();
            }

        }
    }
}
