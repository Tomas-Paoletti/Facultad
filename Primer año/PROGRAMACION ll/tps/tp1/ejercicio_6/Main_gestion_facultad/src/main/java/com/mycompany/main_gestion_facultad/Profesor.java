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
public class Profesor extends Persona{
   private String Departamento;
    private int Anio_incorporacion;
    public Profesor(String nombre, String apellido, String estado_civil, int Dni, int anio_incorporacion, String departamento) {
        super(nombre, apellido, estado_civil, Dni);
        this.Anio_incorporacion=anio_incorporacion;
        this.Departamento= departamento;
        
    }
    public void Mostrar_datos(){
        System.out.println("Los datos del profesor son:");
        System.out.println("Apellido: "+ Apellido);
        System.out.println("Nombre. "+ Nombre);
        System.out.println("Dni: "+Dni);
        System.out.println("Estado civil. "+ Estado_civil);
        System.out.println("Departamento donde pertenece: "+Departamento);
        System.out.println("año de incorporacion: "+Anio_incorporacion);
        System.out.println("-------------------------------------------");
    }

    public void setDepartamento(String Departamento) {
        this.Departamento = Departamento;
    }

    public void setAnio_incorporacion(int Anio_incorporacion) {
        this.Anio_incorporacion = Anio_incorporacion;
    }
    
}
