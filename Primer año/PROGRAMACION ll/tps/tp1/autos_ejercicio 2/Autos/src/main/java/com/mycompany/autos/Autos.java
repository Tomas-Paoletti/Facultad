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
public class Autos {
     Scanner at = new Scanner(System.in); 
     //declaramos los atributos de los autos
      private float kilometraje , combustible_por_kilometro, kilometraje_ingresado;
        private String Marca, Modelo;
        //declaramos el contructor para cada atributo
     public Autos(float km_inicial, float km_ing, float comb_km, String marca, String modelo){
       this.kilometraje= km_inicial;
       this.kilometraje_ingresado=km_ing;
       this.combustible_por_kilometro=comb_km;
       this.Marca=marca;
       this.Modelo=modelo;
        
        
        
    }

            //este metodo nos sirve para devolver el kilometraje final
                public  float km_final(){
                float final_k;
                final_k = kilometraje+kilometraje_ingresado ;
                return final_k;
                
            }
            
                
            //Este metodo devuelve el consumo del recorido
            public float consumo_recorrido(){
                float consumo;
                
                consumo=kilometraje_ingresado*combustible_por_kilometro;
                return consumo;
        
                }
            }
            
            
            
            
            
    
    
        
    

