public  class Matematica {

    public static int fibonacci(int nro) {
        if (nro == 1){
            return 1;
    }else if(nro==0){
            return 0;
        }
        else return fibonacci(nro-1)+fibonacci(nro-2);
}
}
