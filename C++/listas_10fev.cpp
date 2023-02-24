#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;

struct pes{

	char	nome[81];
	int		idade;
	pes		*next; 		// pointer que aponta para o tipo 'pes'

} *pHead = NULL; 		// aqui fica já declarado a var pointer pHead que aponta para structs 'pes'

void	mostraMenu(){
	cout << "\n 'i' - Inserir\n";
	cout << "\n 'z' - Inserir Tail\n";
	cout << "\n 'a' - Apagar\n";
	cout << "\n 'o' - Apagar Tail\n";
	cout << "\n 'l' - Listar\n";
	cout << "\n 'p' - Listar por Idade\n";
	cout << "\n 't' - Terminar\n";
}

bool	inserirHead(){
	pes	*pNovo;

	pNovo = (pes*) malloc (sizeof(pes));
	if (!pNovo)
		return false;
	//pedir dados
	cout<< "\nNome: ";
	cin.clear();cin.sync();cin.ignore();
	cin.getline(pNovo->nome, 81);
	cout<< "\nIdade: ";
	cin >> pNovo->idade;
	//
	//posicionar Pointers:
	pNovo->next = pHead;
	pHead = pNovo;
	return true;
}

bool	inserirTail(){
	pes	*pNovo, *pAux;

	pNovo = (pes*) malloc (sizeof(pes));
	if (!pNovo)
		return false;
	//pedir dados
	cout<< "\nNome: ";
	cin.clear();cin.sync();cin.ignore();
	cin.getline(pNovo->nome, 81);
	cout<< "\nIdade: ";
	cin >> pNovo->idade;
	//
	//posicionar Pointers:
	pNovo->next = NULL;

	if (!pHead)
		pHead = pNovo;
	else //tem 1 ou mais items
	{
		pAux = pHead;
		while(pAux->next)
			pAux = pAux->next;
		pAux->next = pNovo;//no fim do while, pAux aponta para o ultimo
	}
	return true;
}

bool	listar(){
	pes	*paux;

	if(!pHead) return false;
	cout << "Lista de Pessoas"<< "------------------"<< endl<<endl;
	paux = pHead;
	while(paux){
		cout << "nome: "<< paux->nome << endl;
		cout << "idade: "<< paux->idade << endl << endl;
		paux = paux->next;
	}
	cout << "--------"<<endl;
	cout << "Fim da listagem"<< endl;
	return true;
}

bool	listarIdade(){
	int		idade;
	pes		*paux;
	bool	listou = false;

	if(!pHead) return false;

	paux = pHead;
	cout << "Listar por Idade " << "--------------------"<< endl;
	cout << "Introduza a idade: \n";
	cin >> idade;

	do{
		if(paux->idade == idade){
			listou = true;
			cout<< "--------------------"<< endl;
			cout << "---"<< paux->nome << endl;
			cout << "---"<< paux->idade << endl;
		}
		paux = paux->next;
	} while (paux);

	if(!listou) cout << "Não há pessoas com essa idade.\n";
	cout << "--------------------"<< endl;
	return true;
}

bool	apagarHead(){
	pes	*paux;

	if(!pHead) return false;
	paux = pHead;
	pHead = pHead->next;
	cout << "Goodbye Maria Ivone: "<< paux->nome << endl;
	free(paux);
	return true;
}

bool	apagarTail(){
	pes	*paux;

	if(!pHead) return false;

	paux = pHead;
	if(!paux->next){
		pHead = NULL;
		free(paux);
		return true;
	}

	while(paux->next->next)
		paux = paux->next;
	
	free(paux->next);
	paux->next = NULL;
	return true;
}

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
		cin >> op;
		switch (op){

		case 'i': //inserir
			if(!inserirHead()) cout << "\nMemória insuf!\n\n";
			break;
		case 'z': //inserir tail
			if(!inserirTail()) cout << "\nMemória insuf!\n\n";
			break;
		case 'a': // apagar
			if(!apagarHead()) cout << "\nLista vazia!\n\n";
			break;
		case 'o': // apagar
			if(!apagarTail()) cout << "\nLista vazia!\n\n";
			break;
		case 'l': // listar
			if(!listar()) cout << "\nLista vazia!\n\n";
			break;
		case 'p': // listar
			if(!listarIdade()) cout << "\nLista vazia!\n\n";
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
