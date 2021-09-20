package ejercicio4;



public class cuenta {
    
    //Atributos
    private int nrocuenta; 
    private double saldo;
    
    //Constructores
    public cuenta(){
        this.saldo=0;
        this.nrocuenta=0;
    }

    public cuenta(int nrocuenta, double saldo) {
        this.nrocuenta = nrocuenta;
        this.saldo = saldo;
    }
    
    
    //Encapsulamientos
    public int getnrocuenta(){
        return nrocuenta;
    }                       
    public void setnrocuenta(int nrocuenta){
        this.nrocuenta=nrocuenta;
    }

    public double getSaldo() {
        return saldo;
    }
    
    //Metodos
    public void saldo(){
        System.out.println("El saldo de la cuenta es $"+this.saldo);
    }
    
    public double abono(double monto){
        return this.saldo=this.saldo-monto;
    }
    
    public double recibo(double monto){       
        return this.saldo=this.saldo+monto;     
    }
}