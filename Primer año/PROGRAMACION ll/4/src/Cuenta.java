public class Cuenta {
    private int NroCuenta;
    private float saldo;

    public Cuenta(int nroCuenta, float saldo) {
        NroCuenta = nroCuenta;
        this.saldo = saldo;
    }

    public Float MostrarSaldo(){
       return saldo;
    }

    public void Recargar (int x){
        saldo+=x;
    }
    public void pagar(int x){
        saldo-=x;
    }
}
