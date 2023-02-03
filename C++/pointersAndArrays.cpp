#include <string.h>
#include <iostream>

using namespace std;

int	main( int ac, char **av ) {

	int	ar[10] = {1,2,3,4,5,6,7,8,9,0};
	int	*p;

	p = ar;
/*
	cout << *p << endl;

	p++;

	cout << *p << endl;

	p--;

	cout << *(p+3) << endl;

	cout << p[3] << endl;
*/

	cout << "*p++ = " << *p++ << endl;
	cout << *p << endl;
// são iguais em output. Mas no caso de p++ estamos a editar o point, em
// *(p+1) apenas mostramos a posição à frente, e o pointer mantem-se apontado para 
// a posição &arr[0] ou arr.
	cout << "*(p++) = " << *(p++) << endl;
	cout << *p << endl;

	cout << "*++p = " << *++p << endl;



}