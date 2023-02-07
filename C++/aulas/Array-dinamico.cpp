/**************************************************************************
 Este exemplo mostra como se cria uma array durante a execução do programa
 Note-se que, quando se está a escrever o programa, não se sabe qual vai
 ser a dimensão para o array.
 É este o interesse das variáveis dinâmicas (criadas em runtime)
 Veja-se as 3 formas de aceso aos elementos do array (comentadas no código)
**************************************************************************/

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;

int main(int argc, char** argv) {
	int tot;
	int *pNum, *paux;
	
	cout << "Total de numeros: "; cin >> tot;
	
	//alocação de memória para o array de números
	pNum = (int *) malloc( tot * sizeof(int) );
	
	//testar se conseguiu alocar
	if( !pNum ){
		cout << "Memória insuficiente\n";
		return 0;
	}

	// não perder a referência para o início do array
	paux = pNum;
	
	// ler valores para o array
	for( int i=0; i<tot; i++){
		cout << "\nNumero " << i+1 << ": ";
		cin >> *paux++; // podemos tirar partido da aritmética de pointers
		//ou fazer: cin >> *(pNum+i); // dispensa paux
		//ou ainda: cin >> pNum[i]; // dispensa paux
	}

	// listar o array
	paux = pNum;
	for( int i=0; i<tot; i++){
		cout << *paux++ << endl;
		//ou fazer: cout << *(pNum+i) << endl; // dispensa paux
		//ou ainda: cout << pNum[i] << endl; // dispensa paux
	}

	// libertar a memória alocada
	free( pNum );
	
	return 0;
}
