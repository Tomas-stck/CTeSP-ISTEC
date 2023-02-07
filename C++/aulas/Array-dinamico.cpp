/**************************************************************************
 Este exemplo mostra como se cria uma array durante a execu��o do programa
 Note-se que, quando se est� a escrever o programa, n�o se sabe qual vai
 ser a dimens�o para o array.
 � este o interesse das vari�veis din�micas (criadas em runtime)
 Veja-se as 3 formas de aceso aos elementos do array (comentadas no c�digo)
**************************************************************************/

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;

int main(int argc, char** argv) {
	int tot;
	int *pNum, *paux;
	
	cout << "Total de numeros: "; cin >> tot;
	
	//aloca��o de mem�ria para o array de n�meros
	pNum = (int *) malloc( tot * sizeof(int) );
	
	//testar se conseguiu alocar
	if( !pNum ){
		cout << "Mem�ria insuficiente\n";
		return 0;
	}

	// n�o perder a refer�ncia para o in�cio do array
	paux = pNum;
	
	// ler valores para o array
	for( int i=0; i<tot; i++){
		cout << "\nNumero " << i+1 << ": ";
		cin >> *paux++; // podemos tirar partido da aritm�tica de pointers
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

	// libertar a mem�ria alocada
	free( pNum );
	
	return 0;
}
