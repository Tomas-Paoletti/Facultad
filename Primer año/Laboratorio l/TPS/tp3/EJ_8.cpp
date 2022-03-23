/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <iostream>
b) Diseña una función booleana que dados dos registros de tipo Vector como parámetros, devuelva TRUE si son iguales y FALSE en otro caso. Dos vectores son iguales si contienen los mismos elementos y en el mismo orden relativo, suponiendo que el primer elemento sigue al último.
#include <iostream>
using namespace std;

const unsigned MAX=50;
typedef char Componentes[MAX];
struct Vector {
 Componentes datos; // array de caracteres
 unsigned tam; // numero de celdas ocupadas
};

bool vectoresIguales(Vector& vector1, Vector& vector2){
 bool iguales = false;
 if(vector1.tam == vector2.tam){

 iguales = true;
 unsigned i=0;

 bool encontrado=false;
 unsigned j=0;
  while(j < vector2.tam && !encontrado){
   if(vector1.datos[0] == vector2.datos[j]){
    encontrado = true;
   }else{
    j++;
   }
  }

 while(i < vector1.tam && iguales){
  iguales = false;
   if(vector1.datos[i] == vector2.datos[j]){
    i++;
    if(j == vector2.tam -1){
     j = 0;
    }else{
     j++;
    }
    iguales = true;
   }

 }

 }
 return iguales;

}


void leerVector(Vector& vector){
 vector.tam = 0;
 char a;
 cout << "Introduce cadena: ";
 cin >> a;
 while(a != '.'){
  vector.datos[vector.tam]= a;
  vector.tam++;
  cin >> a;
 }
}


int main() {
 Vector v1, v2;
 leerVector(v1);
 leerVector(v2);
 if(vectoresIguales(v1,v2)){
  cout << "Los vectores son iguales.";
 }else{
  cout << "No son iguales";
 }

 return 0;
}

