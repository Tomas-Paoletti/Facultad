/*<1.	Realizar una calculadora que realice suma, resta, multiplicación y división. Cada cálculo se debe realizar en 

funciones pasando los números por valor.

*/

#include <iostream>

using namespace std;

int suma(float x, float y);
int resta (float x, float y);
int multiplicacion(float x, float y);
int division(float x, float y);

int main(){
float nro_1, nro_2 ;
int calculo;

cout<<"Que tipo de calculo desea realizar: "<<endl;
cout<<"1: Suma"<<endl;
cout<<"2: Resta"<<endl;
cout<<"3: Multiplicacion"<<endl;
cout<<"4: Division"<<endl;
cin>> calculo;
switch (calculo)
{
case 1:
    cout<<"Usted eligio la Suma"<<endl;
    cout<<"ingrese el primer numero"<<endl;
    cin>>nro_1;
    cout<<"ingrese el segundo numero"<<endl;
    cin>>nro_2;
    cout<<"El resultado es: "<<suma(nro_1, nro_2)<<endl;
    break;

case 2:
   cout<<"Usted eligio la Resta"<<endl;
    cout<<"ingrese el primer numero"<<endl;
    cin>>nro_1;
    cout<<"ingrese el segundo numero"<<endl;
    cin>>nro_2;
    cout<<"El resultado es: "<<resta(nro_1, nro_2)<<endl;
    break;
case 3:
    cout<<"Usted eligio la Multiplicacion"<<endl;
    cout<<"ingrese el primer numero"<<endl;
    cin>>nro_1;
    cout<<"ingrese el segundo numero"<<endl;
    cin>>nro_2;
    cout<<"El resultado es: "<<multiplicacion(nro_1, nro_2)<<endl;
    break;
case 4:
    cout<<"Usted eligio la division"<<endl;
    cout<<"ingrese el primer numero"<<endl;
    cin>>nro_1;
    cout<<"ingrese el segundo numero"<<endl;
    cin>>nro_2;
    cout<<"El resultado es: "<<division(nro_1, nro_2)<<endl;
    break;

default:
    break;
}


system("pause");

}
suma(float x, float y){
float sumar;
sumar= x + y;

return sumar;
}

resta(float x, float y){
    float restar;
    if (x>y)
    {
        restar= x-y;
    }
    else{
        do
        {
            cout<<"ERROR VUELVA A INGRESAR LOS DATOS "<<endl;
        cout<<"Ingrese el primer numero"<<endl;
        cin>>x;
        cout<<"ingrese el segundo numero"<<endl;
        cin>>y;
        } while (x>y);
        restar= x - y;
    }
    return restar;

}

multiplicacion(float x, float y){
    float multiplicar;

    multiplicar= x*y;

    return multiplicar;
}

division(float x, float y){
    float dividir;
    if (x!=0 and y!=0)
    {
    dividir= x/y; 
    }
    else{
       	 do
        {
            cout<<"ERROR VUELVA A INGRESAR LOS DATOS "<<endl;
        cout<<"Ingrese el primer numero"<<endl;
        cin>>x;
        cout<<"ingrese el segundo numero"<<endl;
        cin>>y;
        } while (x!=0 and y!=0);
        dividir= x / y;
	   }
    
    

    return dividir;
}

    
    
