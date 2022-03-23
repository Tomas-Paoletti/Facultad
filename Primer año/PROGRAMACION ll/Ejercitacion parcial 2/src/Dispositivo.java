public abstract class Dispositivo {
   protected  Integer NroSerie;

   public Dispositivo(){

   }

    public Dispositivo(Integer nroSerie) {
        NroSerie = nroSerie;
    }


    public abstract void Encender(){
        System.out.println("Encendiendo dispositivo");
    }
    public abstract void Apagar(){
        System.out.println("Apagando dispositivo");
    }
    public abstract void MostrarInfo(){
        System.out.println("El numero de serie es : "+NroSerie);
    }

}
