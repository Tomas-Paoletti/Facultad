/*
8.	Crear el programa asteriscos5 en el que se introduce un n�mero entero y se crea una pir�mide de asteriscos. Por ejemplo si se introduce el 6, el resultado ser�a:
*/

#include  <iostream>
using namespace std;
int main()
{
int escalones,asterisco,i;


cout << "ingrese la cantidad de escalones de la piramide"<<endl;
cin>>escalones;
for ( i = 0; i <= escalones; i++)
{
    for (asterisco = 1; asterisco <= escalones-i; asterisco++)
    {
    cout<<(" ");
    }
    for (asterisco = 1; asterisco <= 2*i-1; asterisco++)
    {
     cout<<"*";
     }
        cout<<endl;
    


}
}






