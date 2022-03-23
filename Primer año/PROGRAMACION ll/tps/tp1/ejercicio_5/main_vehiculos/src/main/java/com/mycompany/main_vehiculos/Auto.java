/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.main_vehiculos;

/**
 *
 * @author tomia_n55eokc
 */
public class Auto extends  Vehiculos{
  //declaramos las variales exclusivas de esta clase
   private final int cap_personas=4;
   private final double demora_carga=1;
//Constructor
    public Auto(double vel_maxima, double cap_tanque) {
        super(vel_maxima, cap_tanque);
        
        
    }
   public double tiempo_recorrido(double recorrido){
       double tiempo, tiempo_demora;
       tiempo=recorrido/Vel_maxima;
       tiempo_demora= Math.floor(recorrido) /Cap_tanque;
       
       
       tiempo= tiempo+tiempo_demora;
    
       return  tiempo;
     
       
       
   }
}
  
