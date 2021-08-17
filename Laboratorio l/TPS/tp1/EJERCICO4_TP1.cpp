#include <iostream>
using namespace std;

int main(){
int entrada_50,  entrada_25, ganancias, recaudacion, gastos_entrada_50, gastos_entrada_25;

cout <<"ingrese la cantidad de entradas de $50:  ";
cin >>entrada_50;


cout<<"imgrese la cantidad de entradas de $25:  ";
cin>>entrada_25;

//valor entrdad $25-$9 costo//valor de entradas $50 -costo $12
gastos_entrada_25 = 9* entrada_25;
gastos_entrada_50= 12* entrada_50;


recaudacion=entrada_50*50 +entrada_25 *25;
ganancias= (entrada_50 *50 +entrada_25* 25)- (gastos_entrada_25 +gastos_entrada_50);
cout<<endl;
cout<<"La recaudacion de la noche es:  $"<<recaudacion<<endl; 
cout<<"Las ganacias son:  $" <<ganancias<<endl;
cout<<"los gastos de las entradas de 25 son:  $" <<gastos_entrada_25<<endl;
cout<<"los gastos de las entradas de 50 son:  $" <<gastos_entrada_50<<endl ;

 system("pause");



}
