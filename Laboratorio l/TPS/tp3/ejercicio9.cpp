/*Los alumnos de una clase desean celebrar una cena de confraternización un día del presente mes
 en el que puedan asistir todos.  Se pide realizar un programa que recoja de cada alumno los días
  que le vendrían bien para ir a la cena e imprima las fechas concordantes para todos los alumnos. 
  Los datos se introducirán por teclado y cada alumno escribirá una única línea con los días separados por espacios en blanco. 
Los días se expresan entre el 1 y el 30 del mes.*/
#include <iostream>

using namespace std;
int main (){

    int dias_posibles[100][2], i,j,k,l, alumnos, aux ,contador_dias[100], mayor;
    mayor=0;
    cout<<"INGRESE LA CANTIDAD DE ALUMNOS"<<endl;
    cin>>alumnos;
    cout<<"ingrese los dias que puede cada alumno(2 dias separados por espacio)"<<endl;
    for (i = 0; i < alumnos ; i++)
    {
    	  
     cout<<"INGRESE LOS POSIBLES DIAS DEL ALUMNO NRO: " << i+1 <<endl;
        for ( j = 0; j < 2; j++)
        {
            
            
             cin>>aux;
             if (aux<32 && aux>0)
             {
               aux= dias_posibles[i][j];
             }
             else
             {
                 cout<<"ERROR INTENTE NUEVAMENTE"<<endl;
                 j=j-2;
             }
        }
             
    }
          
          for ( i = 0; i < alumnos; i++)
          {
              for ( j = 0; j < alumnos; j++)
              {
                  for (k = 0; k < alumnos; k++)
                  {
                    
                    
                        if (dias_posibles[i][j]== dias_posibles[k][l])
                        {
                            dias_posibles[i][j]=contador_dias[i]++;
                            if (mayor<contador_dias[i])
                            {
                                contador_dias[i] = mayor;
                            }
                            
                        }
                        
                    
                    
                  }
                  
              }
              
              
          }
         
          
          cout<<"El dia de la juntada es: "<<mayor;
          
       
        
        
    
    




    system("pause");
    return 0;
}
