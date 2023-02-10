#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;

struct pes{

	char	nome[81];
	int		idade;
	pes		*next; 		// pointer que aponta para o tipo 'pes'

} *pHead = NULL; 		// aqui fica já declarado a var pointer pHead que aponta para structs 'pes'

void	mostraMenu();

int main(int argc, char** argv) {

	//cabeça da lista é uma var estática
	//cauda da lista também é estática.
	//São ambas pointers.

	//Lista Simples (com TAIL) ################

	//testar se a lista está vazia
	// if(!pHead) então lista vazia

	//condição para testar se a lista tem apenas um elemento:
	// if (pHead == pTail && (!pHead && !pTail))

	//Lista Simples (sem TAIL) ################

	//testar se está vazio
	// if(!pHead)

	//testar se só tem 1 elemento
	// if(!pHead->next)

	//ler o campo do proximo elemento
	// pHead->next->campo

	//Lista Bidireccional
	//contém 2 pointers, ->next / ->prev

	char	op;

	do {
		mostraMenu();
		op = lerOpcao();
		switch (op)
		{
		case 'i': //inserir
			inserirHead();
			break;
		case 'a': // apagar
			apagarHead();
			break;
		case 'l': // listar
			listar();
			break;
		case 't': // terminar
			cout << "Adeus!";
			break;
		default:
			cout << "Opção inválida!\n";
			break;
		}
	} while(op != 't');
	return 0;
}

void	mostraMenu(){
	cout << "\n 'i' - Inserir\n";
	cout << "\n 'a' - Apagar\n";
	cout << "\n 'l' - Listar\n";
	cout << "\n 't' - Terminar\n";
}

bool	inserirHead(){
	pes	*pNovo;

	pNovo = (pes*) malloc (sizeof(pes));
	if (!pNovo)
		return false;
	//pedir dados
	cout<< "\nNome: ";
	cin.clear();cin.sync();
	cin.getline(pNovo->nome, 81);
	cout<< "\nIdade: ";
	cin.clear();cin.sync();
	cin >> pNovo->idade;
	//
	//posicionar Pointers:
	pNovo->next = pHead;
	pHead = pNovo;
	return true;
}

void	apagarHead(){

}