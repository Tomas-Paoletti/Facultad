/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.main_inmobiliaria;

/**
 *
 * @author tomia_n55eokc
 */
public abstract class Inmueble {
    //declaramos los atributos padres
    double Precio_x_metro=150, Cant_metros;
    int Antiguedad;
    String  Direccion;
    //constructor
    public Inmueble(double Cant_metros, int Antiguedad, String Direccion) {
        this.Cant_metros = Cant_metros;
        this.Antiguedad = Antiguedad;
   
        this.Direccion = Direccion;
    }
    //metodos
    
    public double Calcular_ant(){
        double precio_final, rebaja_ant;
        
        precio_final=Cant_metros*Precio_x_metro;
        if (Antiguedad<15 && Antiguedad!=0) {
            rebaja_ant=precio_final*0.01;
            precio_final-=rebaja_ant;
            
        }else if(Antiguedad>15) {
             rebaja_ant=precio_final*0.02;
             precio_final-=rebaja_ant;
            
            
        }
         return precio_final;
    }
}

    
    


