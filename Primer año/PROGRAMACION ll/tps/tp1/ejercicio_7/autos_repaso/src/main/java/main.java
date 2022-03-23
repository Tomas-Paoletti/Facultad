
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author tomia_n55eokc
 */
public class main {
   
    
    
    public static void main(String[] args) {
        Auto  Automovil= new Auto(0,0,0,0,0);        
        Scanner at= new Scanner(System.in);
        Moto motocicleta = new Moto(0,0,0,0,0);
        Tren roca =new Tren(0,0,0,0,0);
        
        System.out.println("Ingrese la cantidad de kilometros a recorrer en el auto");
        Automovil.setKm_recorrer(at.nextDouble());
        Automovil.calcularTiempo();
        System.out.println(Automovil.getTiempo_recorrido());
        
        System.out.println("Ingrese la cantidad de kilometros a recorrer en la moto");
        motocicleta.setKm_recorrer(at.nextDouble());
        motocicleta.calcularTiempo();
        System.out.println(motocicleta.getTiempo_recorrido());
        
        System.out.println("Ingrese la cantidad de kilometros a recorrer en el tren ");
        roca.setKm_recorrer(at.nextDouble());
        roca.calcularTiempo();
        System.out.println(roca.getTiempo_recorrido());
        
        
        
    }
    
}
