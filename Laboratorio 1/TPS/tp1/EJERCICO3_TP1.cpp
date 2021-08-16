#include <iostream>
using namespace std;

int main(){
float iva, km_recorrido;
int bulto, honorario;
cout <<"ingrese la cantidad de km recorridos:  ";
cin >> km_recorrido;
km_recorrido= km_recorrido *20;
cout<< "ingrese la cantidad de bultos que se llevan al cliente:  ";
cin >>bulto;
bulto= bulto*40;
iva= 1.21;

honorario= (km_recorrido+ bulto) *iva;

cout<< "Los honorarios a cobrar con iva son:  $" <<honorario<<endl;

system("pause");




}
