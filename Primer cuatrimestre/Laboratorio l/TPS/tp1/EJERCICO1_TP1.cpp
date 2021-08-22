//VARIABLES:IVA,CANT DIAS, valor dias, cta frigobar

#include <iostream>
using namespace std;

int main(){
	float iva, val_dia, cta_frigobar, total_a_pagar, precio_neto ;
	int  cant_dias;
	cout<< "ingrese la cantidad de dias:  ";
	cin>>cant_dias;
	cout<<"ingrese el valor por dia:  ";
	cin>>val_dia;
	
	precio_neto=val_dia*cant_dias;
	cta_frigobar= precio_neto /3;
	iva= 0.21 * precio_neto;
 	total_a_pagar= precio_neto + iva + cta_frigobar;
 	
 	cout<<"El precio neto es: " <<precio_neto<<endl;
 	
 	cout<<"El precio del iva es " <<iva<<endl ;
 	cout<< "La cuenta del frigobar es :" <<cta_frigobar<<endl ;

	cout<< "El total a pagar es " <<total_a_pagar<<endl;
 	
 	system("pause");
 	
	 	
		
}
