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
public class Locales extends Inmueble{
    //declaracion de atributos
    private int cant_ventanas;
//constructor
    public Locales(int cant_ventanas, double Cant_metros, int Antiguedad,  String Direccion) {
        super(Cant_metros, Antiguedad, Direccion);
        this.cant_ventanas = cant_ventanas;
    }
    //metodos
    public void calc_local(double precio){
        double porcentaje_vent, aum_metros;
        if (cant_ventanas<2) {
            porcentaje_vent=precio*0.02;
            precio-=porcentaje_vent;
                if (Cant_metros>50) {precio=0.01*precio+precio;}   
            }
        else if (cant_ventanas>4) {
            porcentaje_vent=precio*0.02;
            precio+=porcentaje_vent;  
            }
            System.out.println("El precio del local es: "+ precio);
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


    
    
    