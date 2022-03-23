/*
2.	Una Agencia de viajes ha implementado un nuevo sistema de regalos a los clientes que contraten sus servicios.
  Se desea un programa que indique, dado el pedido del cliente, cu�l es regalo asignado por la empresa.  
   Si se trata de un viaje a alg�n lugar dentro de la provincia; para 1 o 2 personas, se le regalar� entradas a un espect�culo;
    si fueran 3 o m�s personas, 2 d�as m�s de estad�a.
	 Si en cambio fuera un viaje fuera de la provincia (pero dentro de Argentina); para 1 o 2 personas; menos de 7 d�as, 1 d�a m�s de estad�a; caso contrario, excursiones gratis. 
	 Si fueran 3 o m�s personas, y menos de 7 d�as, descuentos a espect�culos, para m�s d�as, ser�n excursiones gratis. 
	  Si el viaje fuera al exterior; para 1 o 2 personas, hasta 7 d�as se le dar� 1 un juego completo de valijas; para m�s d�as, excursiones gratis.
	   Para el resto de los viajes al extranjero; 7 o m�s d�as se les dar�n cupones de descuento; menos de 7 d�as se les entregar� un juego completo de valijas.
*/



#include  <iostream>
using namespace std;

int main(){

int personas, dias, viaje;

cout<<"Ingrese que viaje ha hecho el cliente para ver los regalos disponibles"<<endl;
cout<<"1: Viajes dentro de la provincia"<<endl;
cout<<"2: viajes dentro del interior del pais"<<endl;
cout<<"3: viajes al exterior"<<endl;
cin>>viaje;

cout<<"ingrese la cantidad de personas por cliente"<<endl;
cin>>personas;




switch (viaje)
{
// Si se trata de un viaje a algún lugar dentro de la provincia; para 1 o 2 personas, se le regalará entradas a un espectácul
//si fueran 3 o más personas, 2 días más de estadía
case 1:
{
    if (personas<=2 && personas>0)
    {
        cout<<"Le corresponde el regalo : Entradas a un espectaculo"<<endl;
    }
    else if (personas>2)
    {
        cout<<"Le corresponde el regalo : 2 dias mas de estadia"<<endl;
    }
    
    
    break;
}
// Si en cambio fuera un viaje fuera de la provincia (pero dentro de Argentina); para 1 o 2 personas; menos de 7 días, 1 día más de estadía; caso contrario, excursiones gratis
//Si fueran 3 o más personas, y menos de 7 días, descuentos a espectáculos, para más días, serán excursiones gratis
case 2:
{
    cout<<"ingrese la cantidad de dias"<<endl;
    cin>>dias;

    if (personas<=2 && personas >0)
    {
        if (dias<7 && dias>0)
        {
            cout<<"Le corresponde el regalo : 1 dia de estadia"<<endl;
        }
        else
        {
            cout<<"Le corresponde el regalo : excursiones gratis"<<endl;
        }
        
    }
  
    //Si fueran 3 o más personas, y menos de 7 días, descuentos a espectáculos, para más días, serán excursiones gratis
    else
    {
       if (dias<7)
       {
           cout<<"Le corresponde el regalo : descuentos a espectaculos"<<endl;
       }
        else
        {
            cout<<"Le corresponde el regalo : excursiones gratis"<<endl;
        }
        
    }
    
    
    break;
}
//Si el viaje fuera al exterior; para 1 o 2 personas, hasta 7 días se le dará 1 un juego completo de valijas; para más días, excursiones gratis
//Para el resto de los viajes al extranjero; 7 o más días se les darán cupones de descuento; menos de 7 días se les entregará un juego completo de valijas.
case 3:
{
    cout<<"ingrese la cantidad de dias"<<endl;
    cin>>dias;
    if (personas<3 && personas>0)
    {
        if (dias<=7 && dias>0)
        {
            cout<<"Le corresponde el regalo : juego completo de valijas"<<endl;
            
        }
        else 
        {
            cout<<"Le corresponde el regalo : excursiones gratis"<<endl;
        }
        
    }
    else
    {
        if (dias>7)
        {
            cout<<"Le corresponde el regalo : cupones de descuento"<<endl;
        }
        else 
        {
            cout<<"Le corresponde el regalo : juego completo de valijas";
        }
        
        
    }

    break;
}
default:
    break;
}
system("pause");


}
