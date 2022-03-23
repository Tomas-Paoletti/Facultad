/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.rectangulos;

import java.util.Scanner;

/**
 *
 * @author tomia_n55eokc
 */
public class Main {
   
    public static void main(String[] args) {
        double b,a;
        
        Scanner sc = new Scanner(System.in);
        Rectangulos figura[] = new Rectangulos[4];
     
        for (int i = 1; i <= 3; i++) {
            System.out.println("Ingrese la altura del rectangulo "+(i));
            a=sc.nextDouble();
            System.out.println("Ingrese la base del rectangulo "+(i));
            b=sc.nextDouble();
            figura[i]= new Rectangulos(b,a);
           figura[i].getArea();
           figura[i].getPerimetro();
            
           }
        Rectangulos.comparar(figura);
        
     
        
    }
   
    
        
    }

