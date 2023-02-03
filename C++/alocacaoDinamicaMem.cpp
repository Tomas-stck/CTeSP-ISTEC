#include <string.h>
#include <iostream>

using namespace std;
int	main( int ac, char **av ) {

//	malloc(sizeof(tipo)) // devolve um pointer para a zona de memória reservada.
			// se não tiver memória suficiente, devolve 0 ou NULL.

//	sizeof(tipo) // devolve o número de bytes ocupados por esse tipo 
				// (int,char,tipo de struct...)

//	free(pointer para memória a libertar)

	int	*p;

	p = (int*)malloc(sizeof(int)); // guarda o pointer do mesmo tipo do point criado, que aponta
								  // para a memória alocada.
	if (!p)
		return 0;

	*p = 44; // escreve 44 na memória alocada

	cout << *p << endl;

	free(p); // liberta o endereço de memória em p

	return 0;
}
