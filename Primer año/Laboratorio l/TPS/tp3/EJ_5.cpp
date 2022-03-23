#include <iostream>
#include <stdlib.h>
#include "conio.h" 
using namespace std;

int main(){

    int numeros_array[12];
    int numero, i, n,mayor_repite=-999, repite=1, dato;

    cout<<"ESTE PrOGRAMA MUESTRA QUE NUMERO SE REPITE  MAS VECES"<<endl;

    cout<<"INGRESE 12 NUMEROS ENTEROS"<<endl;

    for ( i = 0; i < 12; i++)
    {
        cout<<i+1<<" : ";
     cin>>numeros_array[i];
     cout<<endl;
    }
    for ( i = 0; i < 12; i++)
    {
        if (numeros_array[i]== numeros_array[i+1])
        {
            repite = repite++;
        }
        else
        {
            if (repite> mayor_repite)
            {
                mayor_repite= repite;
                dato = numeros_array[i];
            }
            repite =1;
        }
        if (repite> mayor_repite)
            {
                mayor_repite= repite;
                dato = numeros_array[i];
            }
            repite =1;
    }
    
    cout <<"EL NUMERO QUE MAS SE REPITE ES : " <<dato<<  " LA CANTIDAD DE  : "<< mayor_repite<<" VECES\n";


    
        
     
        
    }
    
    







