/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp2_ej2;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;
import oracle.jrockit.jfr.ProducerDescriptor;

/*
Ejercicio 2 - ArrayList
Programa que permite insertar N datos de Productos en un ArrayList (los datos
de cada Producto son
Nombre, código, stock). Posteriormente visualice los datos de los productos
cuyo stock sea menor a 10.
/*

/**
 *
 * @author tomia_n55eokc
 */
public class TP2_EJ2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner at = new Scanner(System.in);
        ArrayList<Producto> conjuntoProductos = new ArrayList<Producto>();
      int terminar= 1, opc;
        do {            
            System.out.println("Menu");
            System.out.println("1: Cargar Producto");
            System.out.println("2:Listar productos");
            opc=at.nextInt();
            switch(opc){
                case 1:
                    Producto a = new Producto(".", 0, 0);
                    System.out.println("ingrese el nombre del producto");
                    a.setNombre(at.nextLine());
                    System.out.println("Ingrese el codigo del producto");
                    a.setCodigo(at.nextInt(opc));
                    System.out.println("Ingrese el stock del producto");
                    a.setStock(at.nextInt());
                    conjuntoProductos.add(a);
                    break;
                case 2:
            for (Producto i : conjuntoProductos) {
                try {
                    
               
                
                if (i.getStock()<10);
                System.out.println(i.getNombre());
                } catch (Exception e) {
                    System.out.println("Ha ocurrido un error no hay productos a listar con stock de 10 o mas");
            }
                    break;
            }
                case 3:
                    terminar=0;
                    default: System.out.println("Error... /n ingrese un numero del 1 al 3");
                    break;
            }
            
        } while (terminar ==1);
        System.out.println("Saliendo...");
        
    }
    
}
