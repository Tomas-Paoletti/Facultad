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
///Herencia relacion jerarquica Generalizacion Espècialización
//Modela la relacion es un.. es una...

public abstract class Figura {
    protected String color;

    public Figura(String color) {
        this.color = color;
    }
    //public abstract String Tipo();
    public abstract double Perimetro();
    public abstract double Superficie();
    public void Mostrar(){
        System.out.println("El color de la figura es"+color);
    }
    
}
