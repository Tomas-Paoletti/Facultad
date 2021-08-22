/*4.	Desarrollar un programa que solicite la carga de 10 notas en un procedimiento.
 Luego otro procedimiento que devuelva todas las notas mayores al número que se le pase al procedimiento.*/

 
#include <iostream>

using namespace std;
void carga_notas(int x[10], int comp);
void notas_mayores(int y[10], int c);

int main(){
    int notas[10], nro_comparacion;

    cout<<"Este programa carga 10 notas y nos muestra cuales notas son amyores a un numero ingresado"<<endl;

    cout<<"Ingrese el numero que quiere comparar"<<endl;
    cin>>nro_comparacion;
    carga_notas(notas, nro_comparacion);


system("pause");

}

void carga_notas(int x[], int comp){

    for (int i = 0; i < 10; i++)
    {
        cout<<"cargando numero "<<i+1<<endl;
        cin>>x[i];
    }
    notas_mayores(x, comp);
}

void notas_mayores(int y[], int c){
	cout<<"Los notas mayores al numero ingresado son:"<<endl;
    for (int i = 0; i < 10; i++)
    {
    
        if (c<y[i])
        {
            cout<<"La nota nro "<<i+1<<" : "<<y[i]<<endl;
        }
        
    }
    
system("pause");
}
