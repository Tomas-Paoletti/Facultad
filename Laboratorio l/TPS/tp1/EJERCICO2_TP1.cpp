#include <iostream>
using namespace std;
int main(){
int dos_pesos, un_peso, cincuenta_cents, veinticindo_cents, diez_cents, cinco_cents;
float  dinero_disponible ;

cout<<"ingresar la cantidad de monedas de 2 pesos:  ";
cin>>dos_pesos;
		dos_pesos= dos_pesos * 2;
cout<<"ingresar la cantidad de monedas de 1 peso:  ";
cin>>un_peso;
cout<<"ingresar la cantidad de monedas de 50 centavos:  ";
cin>>cincuenta_cents;
	cincuenta_cents= cincuenta_cents* 0.5;
cout<<"ingresar la cantidad de monedas de 25 centavos:  ";
cin>>veinticindo_cents;
	veinticindo_cents= veinticindo_cents* 0.25;
cout<<"ingresar la cantidad de monedas de 10 centavos:  ";
cin>>diez_cents;
	diez_cents= diez_cents *0.1;
cout<<"ingresar la cantidad de monedas de 5 centavos:  ";
cin>>cinco_cents;
	cinco_cents= cinco_cents *0.05;
 
 dinero_disponible= dos_pesos+ un_peso+cincuenta_cents + veinticindo_cents + diez_cents +cinco_cents;
cout<<endl;
cout<<"La cantidad disponible en la sucursal de GUAYMALLEN es $:  "<<dinero_disponible;
cout<<endl;
system("pause");
}
