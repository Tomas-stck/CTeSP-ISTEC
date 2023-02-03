#include <iostream>
#include <stdlib.h>

using namespace std;

int	main( int ac, char **av ) {

	int tot;
	int	*pNum, *paux;

	cout << "Total de numeros: "; cin >> tot;

	pNum = (int*) malloc( tot * sizeof(int) );

	if (!pNum)
		return 0;

	paux = pNum;

	for (int i = 0; i < tot; i++){
		cout << "\nNumero " << i+1 << ": ";
		cin >> *paux++;
		// ou fazer: *(pNum + i) ou pNum[i] // ambos dispensam a utilização de *paux
		//
	}

/* Numa stuct se tiveremos um camp tipo STRING não podemos usar malloc*/

	return 0;
}
