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
public class Tren  extends Vehiculos{
    protected  int cap_personas =500;
    
   
    public Tren(double vel_maxima, double cap_tanque) {
        super(vel_maxima, cap_tanque);
       
        
    }
    public double tiempo_viaje(double recorrido){
        double tiempo;
        tiempo= recorrido/ Vel_maxima;
        return tiempo; 
        
    }
   
    
}
