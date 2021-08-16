/*3.	Desarrolle una Función que devuelva el salario mensual 
de un trabajador si se tienen como datos el número de horas
 trabajadas, el precio de la hora y además se sabe que se le
  descuenta el 10% por concepto de caja de ahorro. 
Pasar por valor las horas, el precio por hora y el descuento.*/

#include <iostream>

using namespace std;
int salario(float precio, int hora ,int ahorro);

int main(){
float precio_hora;
int horas_trabajadas, caja_ahorro, aux;

cout<<"Ingrese el valor del salario por hora"<<endl;
cin>>precio_hora;
cout<<"ingrese la cantidad de horas trabajadas"<<endl;
cin>>horas_trabajadas;
cout<<"Tiene caja de ahorro (1 :SI , 2:NO)"<<endl;
cin>>caja_ahorro;
if (caja_ahorro==1 || caja_ahorro==2)
{
    aux= caja_ahorro;
}
else{
    cout<<"ERROR INTENTE NUEVAMENTE"<<endl;
    cin>>aux;

}
cout<<"El salario es: "<<salario(precio_hora, horas_trabajadas, aux);
}

salario(float precio, int horas, int ahorro){
    float salario_total,subtotal;
    subtotal= precio* horas;

    if (ahorro==1)
    {
        salario_total= subtotal- (subtotal*0.10);
    }
    else{
        salario_total= subtotal;
    }
    return salario_total;



}
