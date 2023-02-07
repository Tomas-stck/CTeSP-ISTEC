/*****************************************************************************
* Para utiliza��o din�mica de mem�ria, h� 4 fun��es
* malloc()
* calloc()
* realloc()
* free()
*
* As vari�veis s�o criadas durante a execu��o do programa.
* Na altura em que se escreve o c�digo, ainda n�o se sabe qual a dimens�o
* que se pretende para as vari�veis (sobretudo se forem arrays).
* Este conceitos s�o importantes para perceber as LISTAS, que ir�o ser
* leccionadas mais � frente.
*
* Neste exemplo vamos:
* 1- alocar espa�o para guardar o n�mero
* 2- testar se foi poss�vel alocar o espa�o
* 3- ler o valor e guard�-lo
* 4- somar 4 ao valor lido
* 5- escrever o resultado
* 6- libertar o espa�o alocado
*****************************************************************************/

#include <stdlib.h> // aqui est�o as fun��es para aloca��o din�mica
#include <iostream>
using namespace std;

int main(int argc, char** argv) {
	// criar apontador para um inteiro
	int *pNum;
	
	// alocar mem�ria para guardar o n�mero inteiro
	pNum = (int *) malloc( sizeof(int) );
	
	// testar se conseguiu alocar a mem�ria
	if( !pNum ) return 0;
	// pNum fica com o endere�o da mem�ria alocada (se estiver tudo OK)
	// pNum fica vazio (se o Sistema Operativo n�o deixou alocar mem�ria)
	
	// em "C"	ZERO (vazio) significa FALSO
	//			DIFERENTE DE ZERO significa VERDADEIRO
	
	// ler o n�mero
	cout << "Escreva o valor: ";
	cin >> *pNum;
	
	// por exemplo, somar 4 ao n�mero lido
	*pNum += 4;
	
	// escrever o resultado no ecr�
	cout << "Resultado da soma: ";
	cout << *pNum;
	
	//libertar a mem�ria alocada
	free( pNum );

	return 0;
}
