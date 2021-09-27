/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pacial1programacion;

/**
 *
 * @author tomia_n55eokc
 */
public class Bateria {
    private double amperaje;
    private double voltaje;
    private String nombreModelo;

    public Bateria(double amperaje, double voltaje, String nombreModelo) {
        this.amperaje = amperaje;
        this.voltaje = voltaje;
        this.nombreModelo = nombreModelo;
    }

    public double getAmperaje() {
        return amperaje;
    }

    public double getVoltaje() {
        return voltaje;
    }

    public String getNombreModelo() {
        return nombreModelo;
    }
    
}
