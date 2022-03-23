#include  <iostream>
using namespace std;
int main()
{
char nombre[50], apellido[50];
int mes_laboral, inasistencias , dias_trabajados;
float sueldo, valor_dia_trabajado;

cout<<"ingrese el nombre del empleado: ";
cin>>nombre;
cout<<"ingrese el apellido del empleado:   ";
cin>>apellido;

cout<<"ingrese el sueldo por dia:  ";
cin>>valor_dia_trabajado;
cout<<"ingrese los dias laborales:  ";
cin>>mes_laboral;
cout<<"ingrese la cantidad de dias inasistidos:  ";
cin>>inasistencias;

dias_trabajados= mes_laboral-inasistencias;

sueldo= dias_trabajados* valor_dia_trabajado;

cout<<"El sueldo del empleado "<<nombre<<" "<<apellido <<" es: "<<sueldo;
}
