/*15.	Diseña una función que, dados dos vectores ordenados 
devuelva otro vector sea la mezcla de ambos.

*/
#include <iostream>

using namespace std;
int main(){
int array_1[]={0, 1, 2 ,3 ,4 ,5 };
int array_2[]={6, 7, 8, 9 ,10 };
int array_final[10];

for (int i = 0; i < 6; i++)
{
    array_final[i]= array_1[i];
}
for (int i =6; i < 11; i++)
{
    array_final[i]=array_2[i-6];

}

for (int i = 0; i < 11; i++)
{
    cout<<array_final[i]<<endl;
}








}
