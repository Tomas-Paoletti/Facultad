/*2.	Cargar un arreglo de 20 números en un procedimiento y realizar el cálculo de 
promedio de los números en una función pasando el arreglo al mismo.
*/
#include <iostream>

using namespace std;
void cargar_notas(int x[20]);
int promedio(int y[20]);

int main(){
int notas[20];
cout<<"Este programa Carga 20 notas  y calcula su promedio"<<endl;
cargar_notas(notas);

}

void cargar_notas(int x[20]){

    for (int i = 0; i < 20; i++)
    {
         cout<<"Nota nro "<<i+1<<endl;
         cin>>x[i];
    }
    cout<<"El promedio total es: "<<promedio(x)<<endl;
    
}

promedio(int y[20]){
    float promedio_total;
    int total_notas;

    for (int i = 0; i < 20; i++)
    {
    total_notas= y[i]+ total_notas;
    }
    promedio_total= total_notas/20;
    return promedio_total;

}
