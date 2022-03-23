/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.main_vehiculos;
 import java.lang.Math;
import java.text.DecimalFormat;
import java.util.Scanner;

/**
 *
 * @author tomia_n55eokc
 */
public class main {
    public static void main(String[] args) {
        //declaracion de variables y objetos
        Scanner sc = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("#.00");
        double kilometros_a_recorrer;
        Tren Roca= new Tren(80, 0);
        Auto automovil = new Auto(220, 600);
        Moto motocicleta= new Moto(150,700);
        //pedimos datos
        System.out.println("Ingrese los kilometros a recorrer");
        kilometros_a_recorrer=sc.nextDouble();
        
        
        //Mostramos resultados
        System.out.println("El tiempo que tarda en recorrer el viaje  el auto es:");
        System.out.println(df.format(automovil.tiempo_recorrido(kilometros_a_recorrer))+"Horas");
        System.out.println("El tiempo que tarda en recorrer el viaje  el Tren Roca es:");
        System.out.println(df.format(Roca.tiempo_viaje(kilometros_a_recorrer))+"Horas");
         System.out.println("El tiempo que tarda en recorrer el viaje  en moto es:");
        System.out.println(df.format(motocicleta.tiempo_recorrido(kilometros_a_recorrer))+"Horas");
        //mostramosla comparacion
        if (motocicleta.tiempo_recorrido(kilometros_a_recorrer)<automovil.tiempo_recorrido(kilometros_a_recorrer)&& motocicleta.tiempo_recorrido(kilometros_a_recorrer)<Roca.tiempo_viaje(kilometros_a_recorrer)) {
            System.out.println("El vehiculo que menos tarda en hacer el viaje es la moto");
        }else if (motocicleta.tiempo_recorrido(kilometros_a_recorrer)>automovil.tiempo_recorrido(kilometros_a_recorrer)&& automovil.tiempo_recorrido(kilometros_a_recorrer)<Roca.tiempo_viaje(kilometros_a_recorrer)) {
             System.out.println("El vehiculo que menos tarda en hacer el viaje es el auto");
        }else  System.out.println("El vehiculo que menos tarda en hacer el viaje es el tren");
        
    }
    
}
