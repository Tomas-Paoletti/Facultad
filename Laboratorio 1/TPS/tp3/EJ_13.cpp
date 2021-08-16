/*13.	Realizar un programa que procese un array de hasta 100 números reales realizando las siguientes tareas:
a) Lectura del array.
b) Impresión en pantalla del array introducido.
c) Determinación del número menor del array.
d) Cálculo de la suma de los elementos del array.
e) Cálculo de la media de los valores del array.
f) Cálculo de la varianza de los valores del array.
g) Cálculo de la desviación típica de los valores del array.

*/
#include <iostream>
#include <cstdlib>
#include <math.h>
using namespace std;
int main(){
float numeros[100], menor,suma_total, media_total,varianza, desviacion,aleatorio;
suma_total=0;
media_total=0;
menor=99999;
varianza=0;
desviacion=0;

for (int i = 0; i < 100; i++)//creando numeros aleatorios
{
    aleatorio= rand();
    numeros[i]= aleatorio/100;
    cout<<numeros[i]<<endl;
    aleatorio=0;
}

for (int i = 0; i < 100; i++)
{
    if (numeros[i]<menor)
    {
        menor=numeros[i];
    }
    
}

cout<<"El mumero menor del todo el array es : "<<menor<<endl;

for (int i = 0; i < 100; i++)//suma total del arreglo
{
    suma_total= suma_total+ numeros[i];
}
cout<<"La suma total es: "<<suma_total<<endl;


media_total=suma_total/100;
cout<<"La media total de los nuemros es: "<<media_total<<endl;


 
 
  for (int i = 0; i < 100; i++) {
    varianza = varianza + pow((numeros[i]-media_total),2);
  }
  cout<<"La varianza es: "<<varianza<<endl;

desviacion= sqrt(varianza/(100-1));

cout<<"La desviacion total es :"<<desviacion<<endl;






}
