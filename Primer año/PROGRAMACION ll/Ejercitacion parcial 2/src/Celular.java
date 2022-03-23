public class Celular extends Dispositivo {
    private boolean Encendido;
    public Bateria bat ;
    public UnidadModular uModular;

    public Celular(boolean encendido, UnidadModular uModular) {
        Encendido = encendido;
        this.uModular = uModular;
    }

    public Celular(Integer nroSerie, boolean encendido, UnidadModular uModular) {
        super(nroSerie);
        Encendido = encendido;
        this.uModular = uModular;
    }

    public Celular() {
        super();
    }

    public Celular(Integer nroSerie) {
        super(nroSerie);
    }

    @Override
    public void Encender() {

    }

    @Override
    public void Apagar() {

    }

    @Override
    public void MostrarInfo() {

    }
    public void ColocarBateria(Bateria bat){
        this.bat=bat;
        System.out.println("La bateria se ha colocado correctamente");
    }
}
