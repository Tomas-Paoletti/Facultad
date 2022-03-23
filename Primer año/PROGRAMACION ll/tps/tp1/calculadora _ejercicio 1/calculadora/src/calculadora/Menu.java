/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculadora;

import java.io.InputStream;
import java.util.Scanner;

/**
 *
 * @author tomia_n55eokc
 */
public class Menu {
    Scanner op = new Scanner(System.in);
    private  int opcion;
    public String resultado;
    public void Menu(){
  
        
         
        System.out.println("MENU");
        System.out.println("1: Suma");
        System.out.println("2: Resta");
        System.out.println("3: Multiplicacíon");
        System.out.println("4: División");
        System.out.println("5: Salir...");
        opcion = op.nextInt();
    }
    /**
     *
     * @return
     */
    
    public void operacion( float nro1, float nro2){
        Op_calculadora calc = new  Op_calculadora(nro1, nro2);
        switch(opcion){
            case 1:
                 resultado=String.valueOf( calc.Sumar());
                 System.out.println("La suma es: "+resultado);
                
                break;
                
            case 2:
                 resultado= calc.Restar();
                 System.out.println("La Resta es: " +resultado);
               
                
                break;
            case 3:
                  resultado=String.valueOf(calc.Multiplicar());
                 System.out.println("La Multiplcacion es: "+ resultado);
               
             break;
            case 4:
                 resultado=String.valueOf(calc.Dividir());
                System.out.println("La Division  es: " +resultado);
                
                break;
                
            case 5:
                
                System.out.println("Saliendo....");
                
            default:
                System.out.println("El numero ingresado es incorrecto");
            }
 
        }
        
}
    
    
    

