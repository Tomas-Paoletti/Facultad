/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.main_inmobiliaria;

import java.util.logging.Logger;

/**
 *
 * @author tomia_n55eokc
 */
public class Pisos extends Inmueble{
    //atributos
    private int Piso_inmueble;
//constructor
    public Pisos(double Cant_metros, int Antiguedad,  String Direccion, int piso_inmueble) {
        super(Cant_metros, Antiguedad,  Direccion);
        this.Piso_inmueble=piso_inmueble;
    }

    //metodos
    public void calc_valor(double precio){
         double aumento_piso;
        if (Piso_inmueble>3) {
           precio=precio/0.03;
        System.out.println("El precio del piso es: "+precio);
        }
    }
    //metodo herenciado
    @Override
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
   
    
    

