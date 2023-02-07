/*****************************************************************
 Algoritmo de ordena��o Bubble Sort melhorado
 Quando se faz uma passagem em que n�o h� trocas, assinala-se com
 uma flag e o loop termina
/*****************************************************************

� desnecess�ria a linha
 cout << ".";
S� foi inserida para poder verificar que o total de testes
feitos varia de acordo com a ordena��o do array inicial

Para fazer v�rias experi�ncias,
retire o coment�rio de apenas um dos testes*/

#include <iostream>
using namespace std;

const int nElem=5; //total de elementos do array

int main(int argc, char** argv) {
	int a[nElem] = {3,5,1,2,4}; // array para ordenar: teste 1
//	int a[nElem] = {5,4,3,2,1}; // array para ordenar: teste 2
//	int a[nElem] = {1,2,3,4,5}; // array para ordenar: teste 3
//	int a[nElem] = {1,2,4,3,5}; // array para ordenar: teste 4
//	int a[nElem] = {3,2,1,4,5}; // array para ordenar: teste 5
	int tmp,j;
	
	// ordenar
	for( int i=0, flag=true; i<nElem-1 and flag; i++ ){
		flag=false;
		for(int j=0; j<nElem-i-1; j++ ){
			cout << "."; // desnecess�rio. S� para contar o n� de testes feitos
			if( a[j]>a[j+1] ){// est�o desordenados
				// trocar
				tmp = a[j];
				a[j] = a[j+1];
				a[j+1] = tmp;
				flag = true;
			}
		}
	}
	
	// escrever array
	for(int i=0; i<nElem; i++){
		cout << a[i] << " ";
	}
	
	return 0;
}
