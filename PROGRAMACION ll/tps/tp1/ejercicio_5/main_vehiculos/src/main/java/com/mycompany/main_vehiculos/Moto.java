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
public class Moto extends Vehiculos {
     private final double demora_carga=0.5;
    protected  int cap_personas= 2;
    
    public Moto(double vel_maxima, double cap_tanque) {
        super(vel_maxima, cap_tanque);
       
    }
    

public double tiempo_recorrido(double recorrido){
       double tiempo, tiempo_demora;
       tiempo=recorrido/Vel_maxima;
       tiempo_demora= Math.floor(recorrido) /Cap_tanque*demora_carga;
       
       
       tiempo= tiempo+tiempo_demora;
      
       return  tiempo;
}
}

