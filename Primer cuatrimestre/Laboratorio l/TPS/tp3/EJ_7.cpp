#include <iostream>
#include <stdlib.h>
#include "conio.h" 
#include <string.h>
#include <stdio.h>
using namespace std;


int main () {
    
    //Declaramos las cadenas 
    char palabra_1[] = "palanca";
    char palabra_2[] = "pala";
    bool encontrado;
    //Mostramos el nombre de las cadenas al usuario 
    cout << "La cadena uno se llama: " << palabra_1<<endl;;
    cout << "La cadena dos se llama: " << palabra_2<<endl;;
   
    //Comparando cadenas con la función strncmp
    if ( strncmp(palabra_1, palabra_2, 4)== 0)
    {
        encontrado= true;
        cout<<"Verdadero";
    }
    else
    {
        encontrado=false;
    }
    
   
    
    //El numero que esta después de las cadenas a comparar indica hasta que caracter se van a comparar 
 
    return 0;
}
