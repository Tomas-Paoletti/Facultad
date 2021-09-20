/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.main_gestion_facultad;

/**
 *
 * @author tomia_n55eokc
 */
public class Personal_serv extends Persona{
    private int Incorporacion;
    String Seccion;
//constructor
    public Personal_serv(String nombre, String apellido, String estado_civil, int Dni) {
        super(nombre, apellido, estado_civil, Dni);
    }
    //metodos

    public int getIncorporacion(int inc) {
        return this.Incorporacion=inc;
    }

    public String getSeccion(String sc) {
        
        return this.Seccion=sc;
    }
    
    public void Mostrar_Datos(){
       
        System.out.println("Los datos del personal son:");
        System.out.println("Apellido: "+ Apellido);
        System.out.println("Nombre. "+ Nombre);
        System.out.println("Dni: "+Dni);
        System.out.println("Estado civil. "+ Estado_civil);
        System.out.println("Departamento donde pertenece: "+Seccion);
        System.out.println("año de incorporacion: "+Incorporacion);
        System.out.println("---------------------------------------");
    }
    
    
}
