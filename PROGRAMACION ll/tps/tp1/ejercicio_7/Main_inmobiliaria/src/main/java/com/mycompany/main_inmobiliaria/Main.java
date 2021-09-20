/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.main_inmobiliaria;

import java.util.Scanner;

/**
 *
 * @author tomia_n55eokc
 */
public class Main {
    public static void main(String[] args) {
        //declaracion de variables
          int opc, ant, pis, ventanas;
          double c_metros, precio_subtotal;
          String dir;
          Scanner at= new Scanner(System.in);
          
   
          //asiganacion de variables 
          System.out.println("Ingrese la cantidad de metros de la propiedad");
          c_metros=at.nextDouble();
          System.out.println("Ingrece la antigüedad de la propiedad");
          ant=at.nextInt();
          System.out.println("Ingrese la direccion de la propiedad");
          dir=at.nextLine();
          
          //Menu
          System.out.println("Que es la propiedad");
          System.out.println("1. Piso");
          System.out.println("2. Local");
          opc=at.nextInt();
          
          switch(opc){
              case 1:{
                  System.out.println("Ingrese el piso del inmueble");
                    pis=at.nextInt();
                    Pisos piso1 =new Pisos(c_metros, ant,dir, pis );
                    precio_subtotal=piso1.Calcular_ant();
                    piso1.calc_valor(precio_subtotal);
                    break;
              }
              case 2:{
                  System.out.println("Ingrese la cantidad de ventanas");
                  ventanas=at.nextInt();
                  Locales local1 =new Locales(ventanas,c_metros, ant,dir);
                  precio_subtotal=local1.Calcular_ant();
                  local1.calc_local(precio_subtotal);
                  break;
              }
                  
          }

          
          }
    }
  
    
 
    
    

