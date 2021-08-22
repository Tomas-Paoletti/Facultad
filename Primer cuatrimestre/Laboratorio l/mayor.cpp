/*
	LABORATORIO I
	PROF. WILKINSON
	EJERCICIO: Para N valores reales ingresados en cualquier orden, 
			   informar el mayor y la posicion que ocupa
	AUTHOR: LIC. FRANCISCO GONZÁLEZ DEL SOLAR
*/

#include <iostream>
using namespace std;

main(){
	
	int cant_valores, posicion, mayor, numero, acumulador, i;
	float promedio;
	
	cout<<"Ingresar la cantidad de valores deseados"<<endl;
	cin>>cant_valores;
	
	//mayor = 0;
	posicion = 1;
	acumulador = 0;
	
	for (i = 1; i <= cant_valores; i++){
		cout<<"Ingrese el "<<i<<"o valor"<<endl;
		cin>>numero;
		
		// acumulador = acumulador + numero;
		acumulador += numero;
		
		if (i == 1)
			mayor = numero;
			
		if (numero > mayor)
		{
			mayor = numero;
			posicion = i;
		}						
	}
	
	promedio = (float) acumulador / cant_valores; // (float) -> conversion forzada de un int a float
	
	cout<<"El mayor número es "<<mayor<<" ingresado en la posición "<<posicion<<endl;
	cout<<"El promedio es "<<promedio;
	
}
