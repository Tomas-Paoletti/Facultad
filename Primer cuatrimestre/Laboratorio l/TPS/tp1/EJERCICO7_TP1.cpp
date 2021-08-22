#include  <iostream>
using namespace std;
int main(){

int edad;

cout<<"ingrese la edad de la persona:  ";
cin>>edad;

if(edad>=0 && edad<1)
{
    cout<<"La persona es un recien nacido";
}
    else if (edad>=1 && edad<=5)
    {
        cout<<"La persona es un infante";
    }
    else if (edad>5 && edad<=12)
    {
        cout<< "La persona es un ninio";
    }
    else if (edad>12 && edad<=18)
    {
        cout<<"La persona es un pre-adolescente";
    }
    else if (edad>18 && edad<=25)
    {
        cout<<"La persona es un adulto adolescente";
    }
    else if (edad>25 && edad<=35)
    {
        cout<<"La persona es un adulto joven";
    }

    else if (edad>35 && edad<=50)
    {
        cout<<"La persona es un adulto";
    }
    else if (edad>50)
	{

        cout<<"La persona es adulto mayor";
        
    }
    
    
    
    





}
