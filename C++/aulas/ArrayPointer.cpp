#include <iostream>
using namespace std;

/*********************************************
* Utilização de pointers para arrays
*
* Nota: o NOME DE UM ARRAY é o endereço do
*		primeiro elemento desse array, ou
*		seja: arr é o mesmo que &arr[0]
*			  ---				-------
*
* Nota: incrementar um pointer NÃO É somar 1
*		a esse pointer, mas sim somar uma
*		quantidade igual ao número de bytes
*		do TIPO para o qual o pointer aponta
*
* Nota: se parr apontar para o início de arr, a
*		expressão "*(parr+2)" é igual a "arr[2]"
*		atenção que os parêntesis não são opcionais
*
*********************************************/

int main(int argc, char** argv) {
	int arr[4] = { 23, 34, 45, 56 };
	int* parr; // criar um pointer para um int
	// note-se que não estamos a criar um pointer para um tipo
	// array, mas sim para uma "coisa" que é do tipo int
	
	// colocar parr a apontar para o array
	parr = &arr[0]; // parr fica com o endereço do arr
					// podia ter escrito parr = arr;

	cout << "elem 1: " << arr[0] << endl;
	cout << "elem 1 (usando pointer): " << *parr << endl;
	cout << "Endereco do arr[0]: " << parr << endl << endl;
	
	parr++; // passar a apontar para o próximo elemento
	
	cout << "elem 2: " << arr[1] << endl;
	cout << "elem 2 (usando pointer): " << *parr << endl;
	cout << "Endereco do arr[1]: " << parr << endl << endl;
	
	// usando um for para mostrar o array inteiro
	parr = arr; // parr aponta para arr
	cout << "*****************" << endl;
	for(int i=0; i<4; i++){
		cout << "elem "
			 << i+1
			 << ": "
			 << *parr++
			 << endl;
	}
	
	// De acordo com a 3ª nota da introdução,
	// a linha onde está
	// << *parr++
	// podia ter sido substituída por
	// << *(parr+i)
	// Embora o output seja o mesmo, neste caso
	// o pointer nunca deixou de apontar para o
	// início (1º elemento) do array,
	// já que nunca foi incrementado
	
	return 0;
}
