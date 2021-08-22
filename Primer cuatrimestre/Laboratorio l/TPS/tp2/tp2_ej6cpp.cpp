/*
6.	Construya un programa que genere la siguiente serie: 1, 5, 3, 7, 5, 9, 7, ..., 23 hasta llegar al número más próximo al 100.

*/

#include  <iostream>
using namespace std;
int main()
{
int num;
num=1;
    for(num; num<96;num=num+0)

    {   
        num= num+4;
        cout<<num<<endl;
        num=num-2;
        cout<<num<<endl;

    }


}
