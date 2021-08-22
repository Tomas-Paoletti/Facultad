/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.autos;

import java.util.Scanner;

/**
 *
 * @author tomia_n55eokc
 */
public class main {
    public static void main(String[] args) {
        //Declaramos objetos
       Scanner sc = new Scanner(System.in);
       Autos auto[] = new Autos[2];
       //Declaramos variables
      String marca, modelo;
       float final_km[]= new float[2],recorrido, kilometro_ingresado, consumo_litros;
        float kilometraje[]= new float[2];
        float consumo_autos[]= new float[2];  
        float consumo_paseo[]= new float[2];
      
        
        //ajustamos los kilometrajes que ya nos da el ejercicio
       kilometraje[0]=80000;
       kilometraje[1]=95000;
      
                
        //empezamos a cargar datos de los autos
       System.out.println("Ingrese la cantidad de kilometros a hacer");
       kilometro_ingresado=sc.nextFloat();  
        
       
        for (int i = 0; i < 2; i++) {

            System.out.println("Ingresando datos del auto"+(i));
            System.out.println("Ingrese la marca del auto");
            marca=sc.next();
            System.out.println("Ingrese la marca");
            modelo=sc.next();

            System.out.println("Ingrese la cantidad de litros que gastan por km");
            consumo_autos[i]=sc.nextFloat();
           
           
            auto[i]= new Autos(kilometraje[i], kilometro_ingresado, consumo_autos[i], marca, modelo);//le enviamos los datos al contructor
              //Ejecutamos los metodos para poder resolver los problemas dados
            consumo_paseo[i]=auto[i].consumo_recorrido();
            System.out.println("Los litros de combustible gastados son: "+consumo_autos[i]);
            final_km[i]= auto[i].km_final();
             
               System.out.println("----------------------------------");
        }
        //mostramos resultados
        System.out.println("----------------------------------");
        for (int i = 0; i < auto.length; i++) {
            System.out.println("Auto"+i);
            System.out.println("El combustible consumido  es: "+consumo_autos[i]);
            System.out.println("El kilometraje final es: "+ final_km[i]);
                System.out.println("----------------------------------");
        }
         

        
        System.out.println("----------------------------------");
        if (consumo_autos[0]<consumo_autos[1]) {
            System.out.println("El auto que mas gasta es: auto2 con  "+consumo_autos[0] );
        } else {
            System.out.println("El auto que mas gasta es: auto1 con "+consumo_autos[1]);
        }
        System.out.println("----------------------------------");
        
        
    }
    
}
