/*3.	Desarrolle un programa que le informe al farmacéutico el porcentaje de descuento a aplicar a los afiliados a una Obra Social. 
Sabiendo que si el afiliado tiene Plan A, todas las recetas que presente tendrán un descuento del 100%. 
En el caso que se trate de un Plan B o C, el afiliado tendrá un descuento del 90%; y si es Plan D un 50%. 
Para el resto de los planes, sólo tendrá el 25%. Si el afiliado paga en efectivo, la farmacia lo beneficia con el descuento del 5% más el descuento antes citado.
*/
#include  <iostream>
using namespace std;
int main()
{


char plan,a ,b, c,d, A, B, C, D, s, S ,N, n, efectivo;

cout<<"ingrese la letra del plan del cliente"<<endl;
cout<<"A: Plan A"<<endl;
cout<<"B: Plan B"<<endl;
cout<<"C: Plan C"<<endl;
cout<<"D: Plan D"<<endl;
cout<<"Para cualquier otro plan presione cualquier letra"<<endl;
cin>>plan ;


if (plan=='A' or plan =='a')
{
    cout<<"El descuento de la receta es del 100%";
}
else  
    cout<<"Paga con efectivo S/N"<<endl;
    cin>>efectivo;

    switch (plan)
    {
    case'B' :
       { if (efectivo =='S' or efectivo=='s')
        {
           cout<<"El descuento de la receta es del 95%"<<endl;
        }
        
        cout<<"El descuento de la receta es del 90%"<<endl;
        break;
       } 
    case'b' :
      {if (efectivo =='S' or efectivo=='s')
        {
           cout<<"El descuento de la receta es del 95%"<<endl;
        }
        cout<<"El descuento de la receta es del 90%"<<endl;
        break;
      }
    case'C' :
      {if (efectivo =='S'or efectivo=='s')
        {
           cout<<"El descuento de la receta es del 95%"<<endl;
        }
        cout<<"El descuento de la receta es del 90%"<<endl;
        break;
      }
    case'c' :
      {if (efectivo =='S' or efectivo=='s')
        {
           cout<<"El descuento de la receta es del 95%"<<endl;
        }
        cout<<"El descuento de la receta es del 90%"<<endl;
        break;
      }
        case'D' :
        {
          if (efectivo =='S' or efectivo=='s')
        {
           cout<<"El descuento de la receta es del 55%"<<endl;
        }
        cout<<"El descuento de la receta es del 50%"<<endl;
        break;
        }
        case'd' :
         { if (efectivo =='S' or efectivo=='s')
        {
           cout<<"El descuento de la receta es del 55%"<<endl;
        }
        cout<<"El descuento de la receta es del 50%"<<endl;
        break;
         }
    default:
      {if (efectivo =='S' or efectivo=='s')
        {
           cout<<"El descuento de la receta es del 30%"<<endl;
        }
        cout<<"Para el resto de los planes el descuento de la receta es 25%"<<endl;
       
         break;
    
    }
}
}








