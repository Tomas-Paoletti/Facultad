/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.main_gestion_facultad;

import java.util.Scanner;

/**
 *
 * @author tomia_n55eokc
 */
public class Main {
    public static void main(String[] args) {
        //declaraciones de variables y objetos
        Scanner at = new Scanner(System.in);
        String apell, nomb, seccion_perteneciente, estado_civ, curso; 
        int dni, opc, anio_incorporacion;
         Profesor profesor1 = new Profesor("Carlos", "Gonzalez","Casado", 32658974,2004,"Matematicas");
        Personal_serv empleado1= new Personal_serv("Juan", "Perez","Soltero", 25654789);
        empleado1.getIncorporacion(1996);
        empleado1.getSeccion("Limpieza");
        Estudiante estudiante1 = new Estudiante("Ramiro", "Saez", "soltero", 42356968);
        estudiante1.getCurso("Desarollo de software");
        //pedimos datos 
        System.out.println("Ingrese el apellido");
        apell=at.nextLine();
         System.out.println("Ingrese el nombre");
        nomb=at.nextLine();
        System.out.println("Ingrese el DNI");
        dni=at.nextInt();
        System.out.println("Ingrese el estado civil");
        estado_civ=at.nextLine();//repito esta linea de codigo por que a veces no la lee la consola
        
        estado_civ=at.nextLine();
        
        //menu para definir que a que tipo de clase pertenece
        System.out.println("-----------------------------");
        System.out.println("Que es la persona?");
        System.out.println("1. Profesor");
        System.out.println("2.Personal de servicio");
        System.out.println("3.Estudiante");
        opc=at.nextInt();
       
        
        
        switch(opc){
            case 1 ->             {
                
                System.out.println("Ingrese el departamento donde pertenece");
                seccion_perteneciente=at.nextLine();
                seccion_perteneciente=at.nextLine();
                System.out.println("Ingrese el año de incorporacion");
                anio_incorporacion=at.nextInt();
                
             
               Profesor  profesor_opc = new Profesor(apell, nomb, estado_civ, dni, anio_incorporacion, seccion_perteneciente);
               System.out.println("Los datos de los empleados cargados son:");
                profesor_opc.Mostrar_datos();
                System.out.println("------------------------------------------");
            }

            case 2 ->             {
                System.out.println("Ingrese el seccion donde pertenece");
                seccion_perteneciente=at.nextLine();
                seccion_perteneciente=at.nextLine();
                System.out.println("Ingrese el año de incorporacion");
                anio_incorporacion=at.nextInt();
                Personal_serv empleado_opc = new Personal_serv(apell, nomb, estado_civ, dni);
                empleado_opc.getIncorporacion(anio_incorporacion);
                empleado_opc.getSeccion(seccion_perteneciente);
                System.out.println("Los datos de los empleados cargados son:");
                empleado_opc.Mostrar_Datos();
                System.out.println("------------------------------------------");
               
            }
            case 3 -> {
                System.out.println("Ingrese el curso donde el pertenece");
                curso=at.nextLine();
                curso=at.nextLine();
                Estudiante estudiante_opc= new Estudiante(apell, nomb, estado_civ, 40323635);
                estudiante_opc.getCurso(curso);
                System.out.println("Los datos de los empleados cargados son:");
                estudiante_opc.Mostrar_datos();
                System.out.println("------------------------------------------");
                
            }
            default -> System.out.println("ERROR");
            
            
        }
        empleado1.Mostrar_Datos();
        profesor1.Mostrar_datos();
        estudiante1.Mostrar_datos();
        
    }
    
}
