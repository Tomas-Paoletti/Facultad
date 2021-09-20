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
public class Estudiante extends Persona{
    private String Curso;
//constructor
    public Estudiante(String nombre, String apellido, String estado_civil, int Dni) {
        super(nombre, apellido, estado_civil, Dni);
    }
    //metodos

    public String getCurso(String curso) {
        return this.Curso= curso;
    }
    public void Mostrar_datos(){
        
        System.out.println("Los datos del estudiante son:");
        System.out.println("Apellido: "+ Apellido);
        System.out.println("Nombre. "+ Nombre);
        System.out.println("Dni: "+Dni);
        System.out.println("Estado civil. "+ Estado_civil);
        System.out.println("El estudiante pertenece al curso de:"+Curso);
        System.out.println("-----------------------------------------");
    }    
    
}
