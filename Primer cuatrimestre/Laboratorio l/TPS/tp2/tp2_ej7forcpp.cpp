/*
7.	Crear un programa que lea un n�mero y calcule la sucesi�n Fibonacci hasta el valor anterior m�s cercano al mismo y el valor posterior m�s pr�ximo. 
Realice este ejercicio utilizando primero un bucle for y posteriormente repita el ejercicio utilizando un bucle while.
*/

#include  <iostream>
using namespace std;
int main()
{
int i,n, num_print, n_1, n_2;
n_2=0;//numero anterior del anterior
n_1=1;//numero anterior 
num_print=1;

cout<<"ingrese el numero a ver su anterior y posterior en fibonacci"<<endl;
cin>>n;
cout<<1<<" ";
for(i=1; i<=n;i=n_2+n_1)
{
    num_print=n_2+n_1;
    cout<<num_print<<" ";
    n_2=n_1;
    n_1=num_print;
}
  num_print=n_2+n_1;
  cout<<num_print;
}
