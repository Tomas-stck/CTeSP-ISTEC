#include <iostream>

using namespace std;

/*
	Estruturas:
Conjunto de variáveis (campos) com tipos diferentes.

		"pes" é o nome do novo tipo de variável */
struct pes
{
	int		idade;
	char	nome[80];
};


int	main(int ac, char **av)
{
	pes pessoa;
	pessoa.idade = 20;

	pes turma[3]; //array de structs

	return (0);
}