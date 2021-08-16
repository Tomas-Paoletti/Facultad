//3.	Cree un programa que permita cargar un array de 15 números. Luego ordenar los ascendente y descendentemente
#include<iostream>
#include<stdlib.h>
#include<stdio.h>
using namespace std;

int main(void){

    int numeros[15]= {0};
    int i, j, aux;

    cout <<"ESTE ES UN PROGRAMA QUE CARGAMOS 15 NUMEROS Y LOS ORDENA DE FORMA ASCENDENTE Y DESCENDENTE "<<endl;

    for ( i = 0; i < 15; i++)
    {
    cout <<"INGRESE UN NUMERO"<<endl;
    cin>>numeros[i];

    }
    
    for ( i = 0; i < 15; i++)
    {
        for ( j = 0; j < 15; j++)
        {
            if (numeros[j] > numeros [j+1])
            {
                aux= numeros[j];
                numeros[j] = numeros[j+1];
                numeros[j+1]= aux;
            }
            
        }
        
    }
    
    cout<<"ORDENADOS DE FORMA ASCENDENTE: "<<endl;
    for ( i = 0; i <= 15; i++)
    {
        cout<<numeros[i]<<endl;
    }
    
    cout<<"ORDENADOS DE FORMA DESCENDEnTE: "<<endl;
    for ( i = 15; i > 0; i--)
    {
        cout<<numeros[i]<<endl;
    }



}
