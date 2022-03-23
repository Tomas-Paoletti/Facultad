/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pacial1programacion;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author tomia_n55eokc
 */
public class Empresa {
    Scanner at = new Scanner(System.in);
   private  ArrayList<Celular> celulares  = new ArrayList<Celular>();
     Celular c1 = new Celular(0);
     
   public void Agregar(){
       Integer nSerie;
       
       System.out.println("ingrese el numero de serie del celular");
       c1.setNroserie(at.nextInt());
      
      celulares.add(c1);
   }
   
   public void alistar(){
       Integer nro;
       System.out.println("Ingrese el nro de serie del clular que quiere ver la info");
       nro=at.nextInt();
       
       for (Celular celulare : celulares) {
           if (nro==celulares.getNumeroserie()) {
               c1.mostrarInfo();
               
           }
       }
      
   }
}
