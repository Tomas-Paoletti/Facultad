#include  <iostream>
using namespace std;

int main()
{
float precio;
char g, c, l;
int ubicacion, casa, depto, propiedad, cochera;



cout<<"En que ubicacion quiere buscar "<<endl;
cout<<"g: Godoy Cruz"<<endl;
cout<<"c: Ciudad"<<endl;
cout<<"l: Las Heras"<<endl;
cin<<ubicacion;

cout<<"Ingrese el valor de la propiedad"<<endl;
cin >>precio;

if (propiedad==1)
 {
     propiedad=casa;
 }
else if(propiedad==2)
 {
    propiedad= depto;
 }
switch (ubicacion)
{
case g:

    if (precio=< 70000 )

    cout<<"SE DEBE IR A INVESTIGAR MAS DATOS DE LA  PROPIEDAD"<<endl;
    
    else if (precio>70000 )
        cout<<"Es una casa o un departamento (1:casa, 2:depto)";
        cin>>propiedad;

            if (casa)
            cout<< funciona;
    







    break;
case c:

    break;

case l:

    break;

default:
 cout<<"EL VALOR INGRESADO ES INCORRECTO"
    break;
}





    
}