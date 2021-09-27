/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author tomia_n55eokc
 */
public abstract class Vehiculo {
    // atributos
    private double km_recorrer;
    private  double vel_automovil;
    private double autonomia;
    private double tiempo_carga_comb;
    private double tiempo_recorrido;

    public double getKm_recorrer() {
        return km_recorrer;
    }

    public void setKm_recorrer(double km_recorrer) {
        this.km_recorrer = km_recorrer;
    }

    public void setTiempo_recorrido(double tiempo_recorrido) {
        this.tiempo_recorrido = tiempo_recorrido;
    }

    
    

    public void setVel_automovil(double vel_automovil) {
        this.vel_automovil = vel_automovil;
    }

    

    public void setAutonomia(double autonomia) {
        this.autonomia = autonomia;
    }


    public void setTiempo_carga_comb(double tiempo_carga_comb) {
        this.tiempo_carga_comb = tiempo_carga_comb;
    }

    public double getTiempo_recorrido() {
        return tiempo_recorrido;
    }

    public Vehiculo(double km_recorrer, double vel_automovil, double autonomia, double tiempo_carga_comb, double tiempo_recorrido) {
        this.km_recorrer = km_recorrer;
        this.vel_automovil = vel_automovil;
        this.autonomia = autonomia;
        this.tiempo_carga_comb = tiempo_carga_comb;
        this.tiempo_recorrido = tiempo_recorrido;
    }

    

   
    public void calcularTiempo(){
        tiempo_recorrido= (km_recorrer/vel_automovil)+(Math.round(km_recorrer/autonomia)*tiempo_carga_comb);
        System.out.println("El tiempo del recorrido es de:");
    }

    
    
    
}
