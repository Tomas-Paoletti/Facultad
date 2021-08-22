//Crear un programa que cree un array con 100 letras may�sculas aleatorias y que cuenta cu�ntas veces aparece cada letra en el array
#include<iostream>
#include<stdlib.h>
#include<time.h>
#include<stdio.h>
#include<conio.h>
using namespace std;
int main(void){
   char letras[100]; 
   char c;
   int mayuscula[26]= {0};
   int r, i;
   
    cout<< "LETRAS ALEATORIAS"<<endl;

   srand(time(NULL));
   for (int i = 0; i < 100; i++)
   {
       r= rand() % 26;
       c= 'A' + r;//conversion de nro nro a letra
       letras[i]= r;
	   mayuscula[r]++;
       cout <<i<< " . "<< c << endl;
      
   }

   cout<< "MOSTRANDO CANTIDAD DE APARICIONES"<<endl;
   
   for (int i = 0; i < 26; i++)
   {
       c= 'A'+i;
       cout<<c << " . "<< mayuscula[i] << endl;
   }
   
}
