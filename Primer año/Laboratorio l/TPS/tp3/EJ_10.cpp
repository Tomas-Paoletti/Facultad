/*
10.	Un equipo de futbol de la UDA realiza en la temporada regular 50 juegos, almacene en una matriz de orden 50x2
 los resultados de cada uno de los juegos. La columna 0 contiene la cantidad de goles realizados por UDA y la columna
  1 contiene los goles realizados por su oponente. 

a.	Determine el promedio de goles anotados y recibidos durante toda la campaña regular. 
b.	Indique además en qué fecha el equipo de la UDA hizo más goles, y en cual recibió más goles.
c.	Indique cuantos partidos ganó y cuantos perdió. 
d.	Realice la carga mediante la función random, con un valor máximo de 6.


donaciones 1G5TjjminimounbitcoinfaFBjtmS
	
*/
#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

int main() {
	
	srand (time(NULL));
	
	int resultado[2] = {0,0};
	int goles [50][2];
	float golesTotales[2] = {0,0};
	int goleada[2][2] = {{0,0},{0,0}};
	
	for(int i = 0; i < 50; i++){
		
		for(int j = 0; j < 2; j++){
			
			goles[i][j] = rand()%6;
			golesTotales[j] += goles[i][j]; // = golesTotales + goles
			
			if(goles[i][j] > goleada[j][1]){
				
				goleada [j][0] = i;
				goleada [j][i] = goles[i][j];
			}
		}
		
		if(goles[i][0] > goles[i][1]){
			resultado[0]++;
		}
		else{
			resultado[1]++;
		}
		cout<<"UDA  "<<goles[i][0]<<" "<<goles [i][1]<<"  OPONENTE"<<endl;
	}
	
	cout<<"El promedio de goles recibidos fue "<<golesTotales[1] / 50<<endl;
	cout<<"El promedio de goles anotados fue "<<golesTotales[0] / 50<<endl;
	cout<<"La fecha en que UDA hizo mas goles fue "<<goleada[0][0]<<endl;
	cout<<"La fecha en que UDA recibio mas goles fue "<<goleada[1][0]<<endl;
	cout<<"La UDA gano "<<resultado[0]<<" partidos"<<endl;
	cout<<"La UDA perdio "<<resultado[1]<<" partidos"<<endl;
		
	system("pause");
	return 0;
}
