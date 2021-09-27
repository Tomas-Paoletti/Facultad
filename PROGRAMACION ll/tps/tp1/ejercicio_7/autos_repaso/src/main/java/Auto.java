/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author tomia_n55eokc
 */
public class Auto extends Vehiculo{
 

    /**
     *
     */
    @Override
    public void calcularTiempo() {
        super.calcularTiempo(); //To change body of generated methods, choose Tools | Templates.
    }
        
    public Auto(double km_recorrer, double vel_automovil, double autonomia, double tiempo_carga_comb, double tiempo_recorrido) {
        super(km_recorrer, vel_automovil=220, autonomia=600, (tiempo_carga_comb=1.0), tiempo_recorrido);
       
    }

    public Auto() {
        super(0, 0, 0, 0, 0);
    }

    
   

    @Override
    public void setTiempo_recorrido(double tiempo_recorrido) {
        super.setTiempo_recorrido(tiempo_recorrido); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public double getTiempo_recorrido() {
        return super.getTiempo_recorrido(); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void setTiempo_carga_comb(double tiempo_carga_comb) {
        super.setTiempo_carga_comb(tiempo_carga_comb); //To change body of generated methods, choose Tools | Templates.
    }

    

    @Override
    public void setAutonomia(double autonomia) {
        super.setAutonomia(autonomia); //To change body of generated methods, choose Tools | Templates.
    }

    

    @Override
    public void setVel_automovil(double vel_automovil) {
        super.setVel_automovil(vel_automovil); //To change body of generated methods, choose Tools | Templates.
    }

   

    @Override
    public void setKm_recorrer(double km_recorrer) {
        super.setKm_recorrer(km_recorrer); //To change body of generated methods, choose Tools | Templates.
    }
    
   
   

   
    
    
}
