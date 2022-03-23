/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp2_ej3;

/**
 *
 * @author tomia_n55eokc
 */
public class TP2_EJ3 {

    /**
 Realizar el juego busca minas, el cual debe tener un arreglo multidimensional
estático de 10 x 10, deberán buscar e investigar la clase Random, para poder
asignar en donde van ha estar posicionadas las minas dentro de la matriz.
Luego permitir al usuario que pueda ir seleccionando algún espacio del arreglo
hasta que encuentre una mina o descubra todos los lugares.
 */
    public static void main(String[] args) {
        // TODO code application logic here/*
        
        Buscamina juego = new Buscamina();
        boolean terminado= false;
        juego.llenarArreglo();
        
        
        do {            
            juego.jugarTurno();
            juego.GameOver(terminado);
            
        } while (terminado== false);
 


    }
    
}
