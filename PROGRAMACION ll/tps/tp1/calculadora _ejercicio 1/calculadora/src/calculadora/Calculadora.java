/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculadora;

import java.util.Scanner;

/**
 *
 * @author tomia
 */
public class Calculadora {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        float nro1, nro2;
        
        Scanner sc = new Scanner(System.in);
        String nombre;
        
        System.out.println("Este programa es una calculadora");
        System.out.println("Ingrese su nombre");
        nombre= sc.nextLine();
        
        System.out.println("Ingrese el primer numero");
        nro1= sc.nextInt();
        System.out.println("Ingrese el segundo numero");
        nro2= sc.nextInt();
        Menu menu_calculadora = new Menu();
        menu_calculadora.Menu();
        menu_calculadora.operacion(nro1, nro2);
        
        System.out.println("Tu nombre es: " + nombre);
        
        System.out.println("...................................................");
       
    }
    
}
