#include  <iostream>
#include <string>
#include <conio.h>
using namespace std;

struct usuarios
{
 string nombre_usuario;
 char contrasena[10]; 
}usuario;

void crear_usuario(int x){


cout<<"cual es el nombre del usuario"<<endl;
cin>>usuario.nombre_usuario;
fflush(stdin);/*para hjacer que no haya espacios en blanco*/
cout<<"Ingrese su contraseña (8 caracteres)"<<endl;
cin.getline(usuario.contrasena,10, '/n');


cout<<"El usuario creado es: "<<usuario.nombre_usuario<<endl;
cout<<"La contraseña es : "<<usuario.contrasena<<endl;



}

int main(){
int cant_usuarios;

cout<<"Cuantos usuarios quiere crear"<<endl;
cin>>cant_usuarios;
crear_usuario(cant_usuarios);



}
