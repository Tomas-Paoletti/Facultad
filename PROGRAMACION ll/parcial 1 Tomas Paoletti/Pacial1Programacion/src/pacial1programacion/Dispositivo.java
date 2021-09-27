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
public abstract class Dispositivo {
    protected Integer nroserie;

    public Integer getNroserie() {
        return nroserie;
    }

    public Dispositivo(Integer nroserie) {
        this.nroserie = nroserie;
    }

   public void encender(){
       System.out.println("Encendiendo dispositivo");
       
   }
   public void apagar(){
       System.out.println("Apagandodispositivo");
       
   }
   public void mostrarInfo(){
       System.out.println("El numero de serie es " +nroserie);
   }

    public void setNroserie(Integer nroserie) {
        this.nroserie = nroserie;
    }
   
}
