/*12.	Cree un programa para comprar boletos de autobús, este marca los asientos ocupados con un "1" 
 * y los desocupados con "0". Mostrar por pantalla los asientos ocupados 
 
*/

#include <iostream>

using namespace std;
int main(){

int asientos_array[21], numero_asiento, comprados;

cout<<"Este colectivo teiene 21 asientos "<<endl;
cout<<"Para finalizar el programa escriba 0"<<endl;

for (int i = 1; i < 21; i++)
{
    asientos_array[i]=0;
}

do
{ 
    
    cout<<"ingrese el asiento que quiere comprar"<<endl;
    cin>>numero_asiento;
     for (int i = 1; i < 21; i++)
     {
        if (numero_asiento==i)
        {
        asientos_array[i]=1;
        }
     }

     
   
    
} while (numero_asiento!=0);
cout<<"|"<<asientos_array [1]<<"(1 )|"<<asientos_array[2]<<"(2) |Pasillo|"<<asientos_array[3]<<"(3)     |"<<endl;
cout<<"|"<<asientos_array[4]<<"(4 )|";cout<<asientos_array[5]<<"(5) |Pasillo|"<<asientos_array[6]<<"(6)     |"<<endl;
cout<<"|"<<asientos_array[7]<<"(7 )|"<<asientos_array[8]<<"(8) |Pasillo|"<<asientos_array[9]<<"(9)     |"<<endl;
cout<<"|"<<asientos_array[10]<<"(10)|"<<asientos_array[11]<<"(11)|Pasillo|"<<asientos_array[12]<<" (12)   |"<<endl;
cout<<"|"<<asientos_array[13]<<"(13)|"<<asientos_array[14]<<"(14)|Pasillo|Escalera |"<<endl;
cout<<"|"<<asientos_array[15]<<"(15)|"<<asientos_array[16]<<"(16)|Pasillo|Escalera |"<<endl;
cout<<"|"<<asientos_array[17]<<"(17)|"<<asientos_array[18]<<"(18)|Pasillo|Escalera |"<<endl;
cout<<"|"<<asientos_array[19]<<"(19)|"<<asientos_array[20]<<"(20)|Pasillo|"<<asientos_array[21]<<"(21)    |"<<endl;





   






system("pause");
}
