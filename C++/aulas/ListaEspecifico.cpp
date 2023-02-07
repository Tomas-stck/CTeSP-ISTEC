/***************************************************
*	Dado um array de estruturas do tipo "pes"
*   listar apenas as pessoas de uma
*	determinada idade (escolhida pelo utilizador)
***************************************************/
#include <iostream>
#include <string.h>
using namespace std;

const int MAX = 4;

// Definição da estrutura. não implica reserva de espaço
// criar um tipo novo chamado "pes"
struct pes {
	char nome[81];	//campo nome
	int idade;		//campo idade
};

int main(int argc, char** argv) {
	pes turma[MAX]; // array de estruturas
	int idade;
	bool achei=false;

	setlocale(LC_ALL, "");
	// ler, usando um ciclo de repetição, os nomes e idades para cada pessoa
	cout << endl << "Dados para as " << MAX << " pessoas" << endl;
	cout << "-----------------------" << endl;
	for(int i=0; i<MAX; i++){
		cout << "Nome " << i+1 << ": ";
		cin.clear(); cin.sync(); // com isto pode-se misturar cin com cin.getline()
		cin.getline(turma[i].nome, 81);
		cout << "Idade " << i+1 << ": ";
		cin >> turma[i].idade;
	}
	
	// pedir a idade para seleccionar as pessoas
	cout << "Idade das pessoas a listar: "; cin >> idade;
	//	Escrever, usando um ciclo de repetição, os nomes e idades para cada pessoa
	cout << endl
		 << "Dados das pessoas com " << idade << " anos\n"
		 << "-------------------------------\n";
	for(int i=0; i<MAX; i++){
		if(turma[i].idade == idade){
			cout << "Nome " << i+1 << ": " << turma[i].nome << endl;
			cout << "Idade " << i+1 << ": " << turma[i].idade << endl;
			achei = true;
		}
	}
	if(!achei) cout << "\nNão há ninguém com essa idade\n";
	
	return 0;
}
