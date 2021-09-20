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
//clase padre
public abstract class Persona {
    String Nombre, Apellido, Estado_civil;
    int Dni;
    public Persona(String nombre, String apellido, String estado_civil, int Dni) {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Estado_civil = estado_civil;
        this.Dni = Dni;
    }
   
    
}
