#include<iostream>
#include<stdlib.h>
#include<stdio.h>
using namespace std;

int main(){

    int vector_a[1];
    int vector_b[1];
    int vector_c[1];

  cout<<"INGRESE LOS VALORES DEL  VECTOR A (UNO POR VES)"<<endl;
  cin>>vector_a[0];
  cin>>vector_a[1];

  cout<<"INGRESE LOS VALORES DEL VECTOR B (UNO POR VEZ)"<<endl;
  cin>>vector_b[0];
  cin>>vector_b[1];


vector_c[0]= vector_a[0]+ vector_b[0];
vector_c[1]= vector_a[1]+ vector_b[1];

cout<<"EL VECTOR RESULATNTE ES:"<<endl;
cout<<"("<< vector_c[0]<<","<<vector_c[1]<<")"<<endl;






}
