/*9.	Realizar un algoritmo que permita a una máquina expendedora de gaseosas realizar
 su venta diaria. La máquina se carga con una cierta cantidad latas de gaseosa de distintos 
 tipos para poder venderlas a un determinado precio (3.50$). Permite recibir monedas de 1$ y 
 50 centavos y da el vuelto cuando corresponda. Tiene un visor en donde va informando los distintos 
 momentos: "Ingrese monedas para recibir la bebida", "Elija la bebida", "Retire su bebida", "Retire su vuelto", 
 "Disculpe, no hay más bebidas".*/
 
#include <iostream>
#include <string.h>
using namespace std;

int main (){

	float monedas,dinero_introducido=0,vuelto=0,debe=0; 
	int gaseosa,siono,cant_gaseosa=28,siono_final, coca, pritty, fanta, sprite; 
	
	do {
		cout<<"Ingrese monedas para recibir la bebida (3.50$)"<<endl;
		cout<<endl;
		do { 
			do{ 
				cout<<"Ingrese los valores de las monedas correspondientes"<<endl;
				cout<<"(Solo se aceptan monedas de 1$ y de 0.50$)"<<endl;
				cin>>monedas;
				if (monedas==1 || monedas==0.50) break; 
				cout<<"Error: mal introducido el numero"<<endl;
				cout<<endl;
			} while (1);
			
			
			dinero_introducido=dinero_introducido+monedas; 
			cout<<"dinero introducido:$"<<dinero_introducido<<endl;
			do {
				cout<<"Desea agregar otra moneda?"<<endl;
				cout<<"1. si"<<endl;
				cout<<"2. no"<<endl;
				cin>>siono;
				cout<<endl;
				if (siono==1) break; 
				if (siono==2) break; 
			
				if (siono!=1 && siono!=2) { 
				cout<<"Error: mal introducido el numero"<<endl;	
				}
			} while (1);
			
			if (siono==2) break; 
		} while (1);
		
		cout<<"Elija la bebida que desee"<<endl;
		cout<<"1. Coca-Cola"<<endl;
		cout<<"2. Pritty"<<endl;
		cout<<"3. Sprite"<<endl;
		cout<<"4. Fanta"<<endl;
		cin>>gaseosa;
        coca= 10;
        pritty= 8;
        sprite=6;
        fanta=4;
		
		switch (gaseosa) { 
			case 1:
				cout<<endl;
				cout<<"Usted eligio Coca-Cola"<<endl;
                coca--;
				break;
			case 2:
				cout<<endl;
				cout<<"Usted eligio Pritty"<<endl;
                pritty--;
				break;
			case 3:
				cout<<endl;
				cout<<"Usted eligio Sprite"<<endl;
                sprite--;
				break;
			case 4:
				cout<<endl;
				cout<<"Usted eligio Fanta"<<endl;
                fanta--;
				break;	
			default:
			cout<<"Error: mal introducido el numero"<<endl;	
		}
		
		if (dinero_introducido>=3.50) {
			cant_gaseosa--;
			vuelto=dinero_introducido-3.50;
			cout<<"Retira la gaseosa"<<endl;
			if (vuelto>=0) {
				cout<<"Retire su vuelto "<<"($"<<vuelto<<")"<<endl; 
				cout<<"Y disfrute su bebida"<<endl;
			}
			cout<<endl;
			cout<<endl;
			cout<<"Quiere otra gaseosa?"<<endl;
			 cout<<"las bebidas restantes son:"<<endl;
             cout<<"Coca-Cola: "<<coca<<endl;
             cout<<"Pritty: "<<pritty<<endl;
             cout<<"Sprite: "<<sprite<<endl;
        	 cout<<"Fanta: "<<fanta<<endl;
			cout<<"1. si"<<endl;
			cout<<"2. no"<<endl;
			cin>>siono_final;
			cout<<endl;	
			if (siono_final==2) break; 
		}
		else {
			debe=3.50-dinero_introducido;
			cout<<"Le falta pagar $"<<debe<<" para el total ($3.50)"<<endl; 
		}
		if (cant_gaseosa<1) {
			cout<<"Disculpe, no hay más bebidas"<<endl;
			break; 
		}
		if (siono_final==2) break; 
	} while (1);
	
	cout<<"Gracias por tu compra!"<<endl;
    
    cout<<"las bebidas restantes son:";
    cout<<"Coca-Cola: "<<coca<<endl;
    cout<<"Pritty: "<<pritty<<endl;
    cout<<"Sprite: "<<sprite<<endl;
	cout<<"Fanta: "<<fanta<<endl;
system ("pause");
}


