/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculadora;

/**
 *
 * @author tomia_n55eokc
 */
public class Op_calculadora {
    
    private final float n1;
    private final float n2;
    
    public  Op_calculadora(float nro1, float nro2){
        this.n1= nro1;
        this.n2= nro2;
    
    }
    
    public float Sumar(){
        return n1+n2;
    }
    public String Restar(){
        float condicion;
        String resta;
        condicion= n1-n2;
        if (condicion>=0) {
            resta = String.valueOf(condicion);
            return resta;
        }else  {
            resta= "Error numero negativo";
            return resta;
        }
        
    }
    public float Multiplicar(){
        return n1*n2;
    }
    public String Dividir(){
        String z;
        try {
            
           z = String.valueOf(n1/n2);
        } catch (Exception e) {
           z ="Error al Dividir";
        }
        return  z;
    }
    
    
}
