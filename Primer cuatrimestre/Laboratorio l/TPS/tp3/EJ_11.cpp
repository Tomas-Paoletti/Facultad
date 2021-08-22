/*	Crear un programa llamado vendedores que cree un array de 5 x 10 indicando que poseemos una empresa de 5 vendedores cada uno 
de los cuales vende 10 productos.
El array almacena los ingresos obtenidos por cada vendedor en cada producto, de modo que un menú permite almacenar los ingresos. Al final obtener:
•	Revisar el total de cada vendedor y obtener los ingresos totales. 
•	Determine qué persona fue la que más vendió y la que menos vendió.*/
#include <iostream>

using namespace std;

int main (){

float ventas[1][10];
float cant_ventas[5], acumulador_ventas,mayor  ,menor;
mayor=0;
menor=100000;


    for (int i = 0; i < 5; i++)
    {
        cout<<"ventas Vendedor: "<< i+1<<" "<<endl;
        for (int j = 0; j < 10; j++)
        {
            cout<<"producto "<<j+1<<endl;
            cin>>ventas[i][j];
        }

    }
        for ( int i = 0; i < 5; i++)
        {
        	 acumulador_ventas=0;
            
            for ( int j = 0; j < 10; j++)
            {
               acumulador_ventas= ventas[i][j]+acumulador_ventas;
            }
            cant_ventas[i] =acumulador_ventas;//guardamos las ventas totales en un arreglo para asi poderlo utilizar mas facilmente
           
            cout<<"El vendedor "<<i+1<<"vendio :"<<cant_ventas[i] <<endl;
            
        }

        for (int i = 0; i < 5; i++)
        {
            if (cant_ventas[i]>mayor)
            {
                mayor= cant_ventas[i];
            }
            
        }
       
        for (int i = 0; i < 5; i++)
        {
            if (cant_ventas[i]<menor)
            {
                menor= cant_ventas[i];
            }
            
        }
        for ( int i = 0; i < 5; i++)
        {
             if (mayor==cant_ventas[i])
             {
            cout<<"el vendedor que mas vendio es:  "<<i+1<<endl;
             }
        }
        
         for (int  i = 0; i < 5; i++)
        {
             if (menor==cant_ventas[i])
             {
            cout<<"el vendedor que menos vendio es:  "<<i+1<<endl;
             }
        }
       
        
        
        
    
    
    


 system ("pause");

}
