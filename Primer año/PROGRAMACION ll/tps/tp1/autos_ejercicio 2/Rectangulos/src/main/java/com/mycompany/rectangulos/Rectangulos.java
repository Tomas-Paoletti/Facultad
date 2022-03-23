/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.rectangulos;

/**
 *
 * @author tomia_n55eokc
 */
public class Rectangulos {
    private double Base,Altura, Area, Perimetro;

    public Rectangulos(double Base, double Altura) {
        this.Base = Base;
        this.Altura = Altura;
    }

   
    
    public double getArea(){
        Area=Base*Altura;
         System.out.println("El Area del rectangulo es:" +Area);
         return this.Area;
    }
        public double getPerimetro(){
  
        Perimetro=Base*2+Altura*2;
        System.out.println("El perimetro del rectangulo es:" +Perimetro);
        return this.Perimetro;
    }
        //Usamos este metodo para saber que rectangulo tiene mayor area y perimetro
  
        public static void comparar( Rectangulos figura[]){
            //comparacion de perimetro
            if(figura[2].Perimetro<figura[1].Perimetro && figura[3].Perimetro<figura[1].Perimetro){
                System.out.println("El rectangulo con mayor perimetro es el rectangulo 1");
            }else if(figura[1].Perimetro<figura[2].Perimetro && figura[3].Perimetro<figura[2].Perimetro){
                System.out.println("El rectangulo con mayor perimetro es el rectangulo 2");
            }else if(figura[1].Perimetro<figura[3].Perimetro && figura[2].Perimetro<figura[3].Perimetro){
                System.out.println("El rectangulo con mayor perimetro es el rectangulo 3");
            }else System.out.println("Error al menos 2 rectangulos comparten el mismo Perimetro ");
            
            
            //Comparacion de area
            if(figura[1].Area<figura[2].Area && figura[3].Area<figura[2].Area){
                System.out.println("El rectangulo con mayor area es el rectangulo 2");
            }else if(figura[2].Area<figura[1].Area && figura[3].Area<figura[1].Area){
                System.out.println("El rectangulo con mayor area es el rectangulo 1");
            }else if (figura[1].Area<figura[3].Area && figura[2].Area<figura[3].Area) {
                System.out.println("El rectangulo con mayor area es el rectangulo 3");
            }else System.out.println("Error 2 rectangulos comparten la misma longitud de area");
            
            
            
        }
}
   
