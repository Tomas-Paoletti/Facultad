/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp2_ej3;



import java.util.Scanner;



/**
 *
 * @author tomia_n55eokc
 */
public class Buscamina {
    Scanner at = new Scanner(System.in);
    int[][] Tablero = new int[10][10];
    private boolean terminarJuego=false;//lo utilizamos para salir 
    
    public void llenarArreglo(){
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                Tablero[i][j]=(int) (Math.random()*3 );
              
            }
            
        }
    }
    
    public void jugarTurno(){
        int columna, fila;
        System.out.println("Los numeros a ingresar son entre 1 y 10");
        System.out.println("Ingrese la fila del tablero del turno");
        fila=(at.nextInt())-1;
        System.out.println("Ingrese la columna del tablero del turno");
        columna=(at.nextInt())-1;
        try {
            if (Tablero[fila][columna]!=0) {
            System.out.println("No es una mina puede segur jugando");
        }
            else {
            System.out.println("Juego terminado");
            terminarJuego=true;
            
        }
        } catch (Exception e) {
            System.out.println("Debe elegir entre 1 y 10 para las filas y columnas");
        }
        
        
    }
    public boolean GameOver(boolean a){
        return terminarJuego;
    }
    
    public void mostrarArreglo(){
         for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                System.out.println("|"+Tablero[i][j] +"|"); 
              
            }
            
        }
    }
    
    
    
    
    
}
