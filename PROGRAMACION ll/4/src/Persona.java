public class Persona {
    private Integer DNI;
    Cuenta cta[]= new Cuenta[2];

    public Persona(Integer DNI, Cuenta x, Cuenta y) {
        cta[1]= new Cuenta(0,0);
        cta[2]= new Cuenta(0,0);
        this.DNI = DNI;
        cta[1]=x;
        cta[2]=y;
    }
    public void VerificarSaldo(){
        if (cta[1].MostrarSaldo()+cta[2].MostrarSaldo()>0){
            System.out.println("La cuenta no registra deuda");
        }else System.out.println("La cuenta es morosa ");

    }
}
