
/*
5.	Ingresar un número natural n e indicar si es primo.


*/
#include<iostream>
using namespace std;

int main(){
	
	int nro, i;
		
	cout<<"Ingrese el numero: ";
	cin>>nro;
	
		for (i = 2; i < nro; i++)
	{

    	if (nro % i == 0)
    	{
        	cout << "El numero no es primo"<<endl;
        	break;
    	}
    	
	}
	if (nro == 1){
	
		cout<< "El numero no es primo"<<endl;
		

	}
	else if (i == nro)
		cout<< "El numero es primo"<<endl;

    else
    {
        cout<<"EL VALOR INGRESADO NO ES VALIDO";
    }
    
	
	
system("pause");
	
	
	
}
