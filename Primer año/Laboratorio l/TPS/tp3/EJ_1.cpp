//1.	Cargue un arreglo de 20 números y promedie los mismos.
#include <iostream>
#include <stdlib.h>
#include <time.h>
using namespace std;
int main(){
	
	float numero [20], promedio;
	float contador=0;
	srand(time(NULL));
	
	for (int i=0; i<20; i++){
		numero[i] = rand() % 100;
		cout<<numero[i]<<endl;
		contador += numero[i];//contador = contador + numero[i]
		
	}
	promedio = contador /20;
	cout <<"el promedio es "<<promedio<<endl;
}
