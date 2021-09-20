/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proygeometria;

/**
 *
 * @author Pablo
 */
import java.io.*;

public class Punto {
    private double x,y;//variables de instancia

    public Punto() {
    }
    
    
    public Punto(double x, double y) {//parametros formales
        this.x = x;
        this.y = y;
    }
    public void Mostrar(){
        System.out.println("El punto se encuentra en la coord. X= "+this.x);
        System.out.println("El punto se encuentra en la coord Y="+this.y);
        
        
    }

    /*public void Leer(){
        Scanner l=new Scanner(System.in);
        ....
        
    } 
*/
    
    public double getX() {
        return x;
    }

    public double getY() {
        return y;
    }

    public void setX(double x) {
        this.x = x;
    }

    public void setY(double y) {
        this.y = y;
    }
    
   public static double Distancia(Punto x1, Punto x2){ 
    //La norma de un vector o distancia 
   
    double resul;
    
    resul=Math.sqrt(Math.pow((x2.getX()-x1.getX()),2.0)+Math.pow((x2.getY()-x1.getY()),2.0));
    
    return resul;
    
   } 
    
}
