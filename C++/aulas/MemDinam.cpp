/*****************************************************************************
* Para utilização dinâmica de memória, há 4 funções
* malloc()
* calloc()
* realloc()
* free()
*
* As variáveis são criadas durante a execução do programa.
* Na altura em que se escreve o código, ainda não se sabe qual a dimensão
* que se pretende para as variáveis (sobretudo se forem arrays).
* Este conceitos são importantes para perceber as LISTAS, que irão ser
* leccionadas mais à frente.
*
* Neste exemplo vamos:
* 1- alocar espaço para guardar o número
* 2- testar se foi possível alocar o espaço
* 3- ler o valor e guardá-lo
* 4- somar 4 ao valor lido
* 5- escrever o resultado
* 6- libertar o espaço alocado
*****************************************************************************/

#include <stdlib.h> // aqui estão as funções para alocação dinâmica
#include <iostream>
using namespace std;

int main(int argc, char** argv) {
	// criar apontador para um inteiro
	int *pNum;
	
	// alocar memória para guardar o número inteiro
	pNum = (int *) malloc( sizeof(int) );
	
	// testar se conseguiu alocar a memória
	if( !pNum ) return 0;
	// pNum fica com o endereço da memória alocada (se estiver tudo OK)
	// pNum fica vazio (se o Sistema Operativo não deixou alocar memória)
	
	// em "C"	ZERO (vazio) significa FALSO
	//			DIFERENTE DE ZERO significa VERDADEIRO
	
	// ler o número
	cout << "Escreva o valor: ";
	cin >> *pNum;
	
	// por exemplo, somar 4 ao número lido
	*pNum += 4;
	
	// escrever o resultado no ecrã
	cout << "Resultado da soma: ";
	cout << *pNum;
	
	//libertar a memória alocada
	free( pNum );

	return 0;
}
