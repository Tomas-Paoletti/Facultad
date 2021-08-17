#include  <iostream>
using namespace std;
int main()
{
float multa, recargo, cuotas, total;
int adicional,anio_multa, financiado;

cout<<"Ingrese el valor de la multa:  ";
cin>>multa;

cout<<"Ingrese el valor recargo:  ";
cin>>recargo;

cout<<"Ingrese la cantidad de cuotas en el cual quiere abonarlo:  "	;
cin>>cuotas;

cout<<endl;

	adicional= 45;
	total= (multa + recargo);
	
cout<<"La multa es del anio anterior (si=1/no=2):  ";
        cin>>anio_multa;
    cout<<endl;
if(anio_multa<3 && anio_multa>0)
{

    switch (anio_multa)
    {
    case 1 :
	    {
	
        cout<<"Usted ya esta siendo financiado ?(si=1/n0=2):  ";
        cin>>financiado;
    
    
       cout<<endl;
    
            if (financiado==2)
              {
     
             total= (total +adicional)/cuotas;
            cout<<"El valor de cada cuota es:  "<<total;
   	        }
    
               else  if(financiado==1)
              {
                 
                     cout<<"NO SE LE PERMITE ACCEDER AL FINANCIAMIENTO";
           
              }
                   else
                   {
                      cout<<"EL VALOR INGRESADO NO ES VALIDO";
                 }
            
      
      
        break;
		
	    }
	case 2  :
		    {
		
 	        total=total/cuotas;
 		    cout<<"El valor de cada cuota es:  "<<total;
 
    	    break;
    	    }
        default :
   	         cout<<"EL VALOR INGRESADO NO ES VALIDO";
    	break;


    }
}
    	else 
    	{
        cout<<"EL VALOR INGRESADO NO ES VALIDO";
    	}



}



