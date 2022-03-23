#include <iostream>
using namespace std;

main() {
	   float base, altura, superficie;
	//entrada
	cout<< "Ingrese la base";
	cin>>base;
	cout<<"ingrese la altura";
	cin>>altura;
	//Proceso
	superficie= base * altura; //asignacion
	//salida
	cout<<endl<< "la superficie del rectangulo es " <<superficie;
	system("pause");
	/*
	la pausa es para que no cierre la ventana
	*/
}
