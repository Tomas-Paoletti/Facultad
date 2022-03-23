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
public class Celular extends Dispositivo{
    private boolean  encendido;
    Bateria bat = new Bateria(0, 0, ".");
    UnidadModular Um = new UnidadModular(1); 
    public Celular(Integer nroserie) {
        super(nroserie);
    }

    @Override
    public void mostrarInfo() {
        super.mostrarInfo(); //To change body of generated methods, choose Tools | Templates.
        System.out.println("El modelo de la bateria es  :"+bat.getNombreModelo());
        System.out.println("La bateria es de "+ bat.getAmperaje()+ "amperes ");
        System.out.println("La bateria es de "+ bat.getVoltaje()+ "voltajes ");
        System.out.println("La bateria es de "+ Um.getCantidadCircuitos()+ " circuitos ");
    }


    @Override
    public void apagar() {
        super.apagar(); //To change body of generated methods, choose Tools | Templates.
        encendido= false;
    }

    @Override
    public void encender() {
        super.encender(); //To change body of generated methods, choose Tools | Templates.
        encendido= true;
    }
    public void colocarBateria(Bateria bat){
        
    }
    
}
