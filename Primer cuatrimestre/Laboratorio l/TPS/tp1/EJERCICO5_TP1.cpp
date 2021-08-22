#include  <iostream>
using namespace std;
 int main(){
 int nro1, nro2, nro3;
 
 

 cout<<"ingrese el primer nro:  ";
 cin>>nro1;
 cout<<"ingrese el segundo nro:  ";
 cin>>nro2;
 cout<<"ingrese el tercer nro:  ";
 cin>>nro3;
 cout<<endl;
  if(nro1>nro3 && nro1>nro2)
  {
   cout<<"el numero mayor es : "<<nro1<<"(primer numero)"<<endl;

}
   else if (nro2>nro1 && nro2>nro3)
    {
        cout<<"el numero mayor es:  "<<nro2<<"(segundo numero)"<<endl;
    }
        else 
        {
            cout<<"el numero mayor es: "<<nro3<<"(tercer numero)"<<endl;
        }

	cout<<endl;
if (nro1<nro2 && nro1<nro3) 
{
    cout<<"el numero menor es:  " <<nro1<<"(primer numero)"<<endl;
}
     else if(nro2<nro1 && nro2<nro3)
     {
        cout<<"el numero menor es:  "<<nro2<<"(segundo numero)"<<endl;
    }
        else 
        {
            cout<<"el numero menor es: "<<nro3<<"(tercer numero)" <<endl;
        }






 }
