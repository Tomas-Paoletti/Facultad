/*
3.	Desarrolle un programa que le informe al farmacéutico el porcentaje de descuento a aplicar a los afiliados a una Obra Social.
 Sabiendo que si el afiliado tiene Plan A, todas las recetas que presente tendrán un descuento del 100%.
  En el caso que se trate de un Plan B o C, el afiliado tendrá un descuento del 90%; 
  y si es Plan D un 50%. Para el resto de los planes, sólo tendrá el 25%. 
  Si el afiliado paga en efectivo, la farmacia lo beneficia con el descuento del 5% más el descuento antes citado.
*/

#include  <iostream>
using namespace std;

int main()
{
float precio;
char g, c, l,ubicacion;
int  propiedad, cochera;

cout<<"En que ubicacion quiere buscar "<<endl;
cout<<"g: Godoy Cruz"<<endl;
cout<<"c: Ciudad"<<endl;
cout<<"l: Las Heras"<<endl;
cin>>ubicacion;

cout<<"Ingrese el valor de la propiedad"<<endl;
cin >>precio;


switch (ubicacion)
{
case 'g':
{
    if (precio==70000 )
    {
    cout<<"COMPRAR PROPIEDAD"<<endl;
    }
    else if(precio>70000)
    {
            cout<<"Es una casa o un departamento ?(1:casa, 2:depto)"<<endl;
        cin>>propiedad;
         

            if (propiedad ==1)
           {
                cout<< "Tiene cochera ? (1:si,2:no)"<<endl;
                 cin>>cochera;
           
                if (cochera ==1)
                {
                    cout<<"INVERTIR EN ESTA PROPIEDAD"<<endl;
                }
                else
                {
                    cout<<"NO INVERTIR EN ESTA PROPIEDAD"<<endl;
                }
		}
            else 
            {
                cout<<"NO INVERTIR EN ESTA PROPIEDAD"<<endl;
   			 }
   	}
    else
	{
	
    cout<<"VISITAR PROPIEDAD PARA OBTENER MAYOR INFORMACION"<<endl;
	}
    
    }
    break;

case 'c':
{
    if (precio>100000)
    {
        cout<<"NO INVERTIR EN ESTA PROPIEDAD"<<endl;
    }
    else if (precio<=100000)
    {
        cout<<"Es una casa o un departamento ?(1:casa, 2:depto)"<<endl;
        cin>>propiedad;
        if (propiedad==1)
        {
            cout<<"INVERTIR EN ESTA PROPIEDAD"<<endl;
        }
        else if (propiedad==2)
        {
            cout<< "Tiene cochera (1:si,2:no)?"<<endl;
                 cin>>cochera;
           
                if (cochera ==1)
                {
                    cout<<"INVERTIR EN ESTA PROPIEDAD"<<endl;
                }
                else
                {
                    cout<<"AVERIGUAR SI HAY COCHERAS CERCA"<<endl;
                }
        }
        
        else
        {
            cout<<"El VALOR INGRESADO NO ES VALIDO"<<endl;
        }
        
    }

    break;
}
case 'l':
{
   
        cout<<"Es una casa o un departamento ?(1:casa, 2:depto)"<<endl;
        cin>>propiedad;

        if (propiedad==2)
        {
             cout<< "Tiene cochera (1:si,2:no)?"<<endl;
                 cin>>cochera;
           
                if (cochera ==1)
                {
                    cout<<"INVERTIR EN ESTA PROPIEDAD"<<endl;
                }
                else
                {
                    cout<<"NO INVERTIR EN ESTA PROPIEDAD"<<endl;
                }
        }
        
        else
        {
            cout<<"NO INVERTIR EN ESTA PROPIEDAD"<<endl;
        }
    break;
}
default:
 cout<<"EL VALOR INGRESADO ES INCORRECTO"<<endl;
    break;
}
system("pause");




    
}
