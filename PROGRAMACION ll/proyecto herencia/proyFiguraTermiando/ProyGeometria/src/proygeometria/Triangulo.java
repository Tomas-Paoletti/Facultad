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
public class Triangulo extends Figura {
    protected final int nlados=3;
    
    protected Punto p1,p2,p3;
    protected double l1,l2,l3;
    protected static int cantidadtriangulo=0;
    
    
    public Triangulo(Punto a,Punto b,Punto c, String col){
        super(col);//Figura(col)
        this.p1=a;
        this.p2=b;
        this.p3=c;
        this.l1=Punto.Distancia(p1, p2);
        this.l2=Punto.Distancia(p2, p3);
        this.l3=Punto.Distancia(p3, p1);
        cantidadtriangulo++;
        
        
    }
    
    public static int DarCantidad(){return cantidadtriangulo;}
    
    public void Mostrar(){
        super.Mostrar();//mostrar el color del triangulo
        System.out.println("El triangulo esta ubicado en las siguientes corordenadas");
        this.p1.Mostrar();
        this.p2.Mostrar();
        this.p3.Mostrar();
    }
    public double Perimetro(){
        return (this.l1+this.l2+this.l3);
    }
    
    public String Tipo(){
        if(this.l1==this.l2 && this.l2==this.l3)
            return "Equilatero";
        else if (this.l1!=this.l2&& this.l2!=this.l3&&this.l3!=this.l1)
           return "Escaleno";
        else
            return "Isosceles";
        
            
        
    }
    private double Semisuma(){
        return this.Perimetro()/2.0;
        
        //return (this.l1+this.l2+this.l3)/2.0;
    }
    public double Superficie(){
        //double s=this.Perimetro()/2.0;
        
        double s=this.Semisuma();
        
        return Math.sqrt(s*(s-this.l1)*(s-this.l2)*(s-this.l3));
        
        
    }
        
        
    
    
}
