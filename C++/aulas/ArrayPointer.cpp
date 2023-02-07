#include <iostream>
using namespace std;

/*********************************************
* Utiliza��o de pointers para arrays
*
* Nota: o NOME DE UM ARRAY � o endere�o do
*		primeiro elemento desse array, ou
*		seja: arr � o mesmo que &arr[0]
*			  ---				-------
*
* Nota: incrementar um pointer N�O � somar 1
*		a esse pointer, mas sim somar uma
*		quantidade igual ao n�mero de bytes
*		do TIPO para o qual o pointer aponta
*
* Nota: se parr apontar para o in�cio de arr, a
*		express�o "*(parr+2)" � igual a "arr[2]"
*		aten��o que os par�ntesis n�o s�o opcionais
*
*********************************************/

int main(int argc, char** argv) {
	int arr[4] = { 23, 34, 45, 56 };
	int* parr; // criar um pointer para um int
	// note-se que n�o estamos a criar um pointer para um tipo
	// array, mas sim para uma "coisa" que � do tipo int
	
	// colocar parr a apontar para o array
	parr = &arr[0]; // parr fica com o endere�o do arr
					// podia ter escrito parr = arr;

	cout << "elem 1: " << arr[0] << endl;
	cout << "elem 1 (usando pointer): " << *parr << endl;
	cout << "Endereco do arr[0]: " << parr << endl << endl;
	
	parr++; // passar a apontar para o pr�ximo elemento
	
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
	
	// De acordo com a 3� nota da introdu��o,
	// a linha onde est�
	// << *parr++
	// podia ter sido substitu�da por
	// << *(parr+i)
	// Embora o output seja o mesmo, neste caso
	// o pointer nunca deixou de apontar para o
	// in�cio (1� elemento) do array,
	// j� que nunca foi incrementado
	
	return 0;
}
