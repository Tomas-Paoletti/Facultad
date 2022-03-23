/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TP2_EJ1;

import java.util.ArrayDeque;  
import java.util.ArrayList;  
import java.util.Deque;  
import java.util.Iterator;  
import java.util.List;  
import java.util.ListIterator;  
//import java.util.ArrayList;
//import java.util.Iterator;
import java.util.Scanner;

/**
 *
 * @author javier
 */
public class ej1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      try {
        Scanner leer = new Scanner(System.in);
        int opciones,contador_a=0,contador_b=0,contador_c=0;
        int dni,año_incorporacion , num_despacho;
        String nombre,apellido,estado_civil,curso,departamento,seccion;
        
        // Declaración el ArrayList
        //ArrayList<Persona> personas = new ArrayList<Persona>();
        //ArrayList<String> nombres = new ArrayList<String>();

        ArrayList personas = new ArrayList();
        Iterator itrPersonas = personas.iterator();
        //Persona lista_alumnos[]=new Persona[100];
        //Persona lista_profesores[]=new Persona[100];
        //Persona lista_servicios[]=new Persona[100];
        
        do{
            System.out.println("-.Menu.-");
            System.out.println("1. Ingresar nuevo Alumno");
            System.out.println("2. Ingresar nuevo Docente");
            System.out.println("3. Ingresar nuevo Empleado");
            System.out.println("4. Mostrar Lista Completa");
            System.out.println("5. Mostrar siguiente");
            
            System.out.println("0. Salir");
            
            opciones=leer.nextInt();
            
            switch(opciones){
                
                case 1:
                case 2:
                case 3:
                    //agrego objeto nuevo Persona para luego agregarlo al Arraylist
                    Persona nuevaPers = new Persona();
                    nuevaPers.setTipo(0);
                    System.out.println("Nombre: ");
                    nuevaPers.setNombre(leer.next());
                    System.out.println("Apellido: ");
                    nuevaPers.setApellido(leer.next());
                    System.out.println("DNI: ");
                    nuevaPers.setDni(leer.nextInt());
                    System.out.println("Estado Civil: ");
                    nuevaPers.setEstado_civil(leer.next());
                    if(opciones>1 && opciones<4){
                        System.out.println("Año de Incorporacion: ");
                        nuevaPers.setAño_incorporacion(leer.nextInt());
                    }
                    if(opciones==2){
                        System.out.println("Numero de Despacho: ");
                        nuevaPers.setNum_despacho(leer.nextInt());
                        nuevaPers.setTipo(1);
                    }
                    if(opciones==3){
                        System.out.println("Departamento donde Trabaja: ");
                        nuevaPers.setDepartamento(leer.next());
                        nuevaPers.setTipo(2);
                    }
                  
                    //agregamos la persona al arraylist
                    personas.add(nuevaPers);
                    itrPersonas = personas.iterator();
                    break;
               
                case 4:
                    //listar las personas
                    System.out.println("Lista de integrantes de la universidad");
                    
                    while(itrPersonas.hasNext()){
                            //Persona pers=new Persona();
                            Persona pers = (Persona)itrPersonas.next();
                            System.out.println("Nombre: "+pers.getNombre()
                                    +" Ap.:"+pers.getApellido()
                                    +" Tipo:"+pers.getTipo());
                            
                            if (pers.getTipo()>=1){
                                System.out.println("Año de inc.: "+pers.getAño_incorporacion());
                            }
                            if (pers.getTipo()==2){
                                System.out.println("Numero de Despacho: "+pers.getNum_despacho());
                            }
                            if (pers.getTipo()==3){
                                System.out.println("Departamento donde Trabaja: "+pers.getDepartamento());
                            }
                    }
                    itrPersonas = personas.iterator();
                    break;
                case 5:
                    //listar las personas
                    System.out.println("Mostrar siguiente");
                    
                    if (itrPersonas.hasNext()){
                            //Persona pers=new Persona();
                            Persona pers = (Persona)itrPersonas.next();
                            System.out.println("Nombre: "+pers.getNombre()
                                    +" Ap.:"+pers.getApellido()
                                    +" Tipo:"+pers.getTipo());
                    }else
                        System.out.println("Es el último");
                         
                    
                    break; 
                
                case 0:
                    System.out.println("Usted ha salido con Exito");
                    break;
                default:
                    System.out.println("Opcion ingresada no existente, vuelva a intentarlo");
                    break;
            }
            
        }while(opciones!=0);
      
      } catch (Exception e) {
	e.printStackTrace();
      
      }
    }
}
