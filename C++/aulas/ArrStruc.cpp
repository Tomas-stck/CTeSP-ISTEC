/**********************************************************
* Com base numa estrutura de 3 elementos (pessoas),
* utilizando ciclos de repetição:
*	- Ler os dados das pessoas
*	- Escrever os dados lidos
*
* Ordenar as pessoas por ordem crescente das idades
*
***********************************************************/
#include <iostream>
#include <string.h>
using namespace std;

// Definição da estrutura. Não implica reserva de espaço
// Criar um tipo novo chamado "pes"
struct pes {
	char nome[81];	//campo nome
	int idade;		//campo idade
};

int main(int argc, char** argv) {
	pes turma[3]; // array de estruturas
	pes aux; // para as trocas

	// ler, usando um ciclo de repetição, os nomes e idades para cada pessoa
	cout << endl << "Dados para as 3 pessoas" << endl;
	cout << "-----------------------" << endl;
	// escreva aqui o código :-)
	for(int i=0; i<3; i++){
		cout << "Nome " << i+1 << ": ";

		// com isto pode-se misturar cin com cin.getline()
		cin.clear(); cin.sync();
		// usar sempre antes de cada cin.getline()

		cin.getline(turma[i].nome, 81);
		cout << "Idade " << i+1 << ": ";
		cin >> turma[i].idade;
	}
	
	//	Escrever, usando um ciclo de repetição, os nomes e idades para cada pessoa
	cout << endl << "Dados lidos das 3 pessoas" << endl;
	cout << "-------------------------" << endl;
	// escreva aqui o código :-)
	for(int i=0; i<3; i++){
		cout << "Nome " << i+1 << ": " << turma[i].nome << endl;
		cout << "Idade " << i+1 << ": " << turma[i].idade << endl;
	}
	
	cout << endl << "Listagem por ordem de idade" << endl;
	cout << "---------------------------" << endl;
	// Pai de todos os desafios
	// escrever os dados das 3 pessoas, ordenados por idade
	
	// Ordenar
	if( turma[0].idade > turma[1].idade ){
		aux = turma[0];
		turma[0] = turma[1];
		turma[1] = aux;
	}
	// chegado aqui, n1 tem o menor dos 2
	
	if( turma[1].idade > turma[2].idade ){
		aux = turma[1];
		turma[1] = turma[2];
		turma[2] = aux;
	}
	// chegado aqui, n3 tem o maior dos 3
	
	if( turma[0].idade > turma[1].idade ){
		aux = turma[0];
		turma[0] = turma[1];
		turma[1] = aux;
	}
	// estão ordenados

	// também podíamos ter usado o Bubble Sort (com ou sem flag) para ordenar
	// experimente fazer isso, em vez de usar o método dos 3 if
		
	// Listar
	for(int i=0; i<3; i++){
		cout << "Nome " << i+1 << ": " << turma[i].nome << endl;
		cout << "Idade " << i+1 << ": " << turma[i].idade << endl;
	}

	return 0;
}
