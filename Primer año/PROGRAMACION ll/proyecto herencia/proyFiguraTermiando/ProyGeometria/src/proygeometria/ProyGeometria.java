package proygeometria;

///Tipos de variables
/*
a) de instancia: son los atributos de la clase
b) de referencia: cuando contiene la direccion del objeto al que apunta. Es un puntero
c) locales
d) de clase: son calificadas como static y existe una sola copia para todos los objetos de laclase
e) de solo lectura o constantes son calificadas como final


*/



public class ProyGeometria {


    public static void main(String[] args) {
        
        //Figura x=new Figura("verde");
        /*
        Punto x1,x2,x3;//declaracion de variables
        double medida;
        x1=new Punto(3.2,7.8);//instanciacion de la clase
        x2=new Punto(0.5,-8.6);
        
        x3=new Punto();
        
       // x3.Leer();
        
         medida=Punto.Distancia(x1, x2);
         System.out.println("La distancia entre x1 y x2 es"+medida);
         
        x1.Mostrar();
        x2.Mostrar();
        System.out.println("La componente x es"+x1.getX());
        System.out.println("La componente y es"+x1.getY());
        x2.setX(-3.33);
        x2.Mostrar();
        
        System.out.println("La distancia entre x1 y x2 es");
       // x1.Distancia(x2);
        System.out.println("La distancia entre x1 y x2 es"+Punto.Distancia(x1,x2));
       */
        //Figura t; //es una referencia amplia de tipo figura 
        //new Figura("verde")
        Triangulo t=new Triangulo(new Punto(0,0),new Punto(-9,5),new Punto (4,3),"verde");
        Triangulo x=new Triangulo(new Punto(0,0),new Punto(-9,5),new Punto (4,3),"violeta");
        Triangulo j=new Triangulo(new Punto(0,0),new Punto(-9,5),new Punto (4,3),"amarillo");

        
        //t=new Cuadrado();
        t.Mostrar();
        System.out.println("La superficie es"+t.Superficie());
        System.out.println("El perimetro es"+t.Perimetro());
        
        System.out.println("El triangulo es"+t.Tipo());
        System.out.println("La cantidad de triangulos creados es"+Triangulo.DarCantidad());
        
       
        
        //.Mostrar();
        
        
                
                
                
                
        
        
        
        
    }
    
}
