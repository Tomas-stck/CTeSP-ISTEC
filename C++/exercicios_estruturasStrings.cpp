#include <iostream>
#include <string.h>
using namespace std;

// Defini��o da estrutura. N�o implica reserva de espa�o
// Criar um tipo novo chamado "pes"
struct pes {
	char nome[81];	//campo nome
	int idade;		//campo idade
};

int main(int argc, char** argv) {
	pes pessoa; // criar a vari�vel "pessoa" que � do tipo "pes"
	pes outraPessoa;
	
	// para fazer um conjunto de pessoas
	pes turma[3]; // array de estruturas
	
	// escrever no campo "idade" da vari�vel "pessoa"
	pessoa.idade = 20; // dizer que a pessoa tem 20 anos;
	
	// escrever no campo "nome" da vari�vel "pes"
	strcpy(pessoa.nome, "Jorge");
	
	// escrever no ecr� os dados da pessoa
	cout << "nome: " << pessoa.nome << endl;
	cout << "idade: " << pessoa.idade << endl;

	cout << "---------------------" << endl;
		
	// indique o nome para a 2� pessoa
	cout << "nome da outra pessoa: ";
	cin.getline(outraPessoa.nome,81);
	
	// indique o nome para a 2� pessoa
	cout << "idade da outra pessoa: ";
	cin >> outraPessoa.idade;
	
	// escrever no ecr� os dados da pessoa
	cout << "nome do outro: " << outraPessoa.nome << endl;
	cout << "idade do outro: " << outraPessoa.idade << endl;

	// ler, usando um ciclo de repeti��o, os nomes e idades para cada pessoa
	cout << endl << "Dados para as 3 pessoas" << endl;
	cout << "-----------------------" << endl;
	// escreva aqui o c�digo :-)
	for ( int i = 0; i < 3; i++){
		cout << "Nome: \n";
		cin.ignore();
		cin.getline(turma[i].nome, 81);
		cout << "\nIdade: ";
		cin >> turma[i].idade;
		cout << endl;
	}
	
	//	Escrever, usando um ciclo de repeti��o, os nomes e idades para cada pessoa
	cout << endl << "Dados lidos das 3 pessoas" << endl;
	cout << "-------------------------" << endl;
	// escreva aqui o c�digo :-)
	for ( int i = 0; i < 3; i++){
		cout << "Nome: ";
		cout << turma[i].nome;
		cout << "\nIdade: ";
		cout << turma[i].idade << endl;
	}
	
	cout << endl << "Listagem por ordem de idade" << endl;
	cout << "---------------------------" << endl;
	// Pai de todos os desafios:
	// escrever os dados das 3 pessoas, ordenados por idade
	
	int		aux;
	char	buff[81];
	for (int i = 0, flag = true; i < 3 - 1 and flag; i++)
	{
		flag = false;
		for (int j = 0; j < 3 - 1 - i; j++)
		{
			if (turma[j].idade > turma[j + 1].idade)
			{
				flag = true;
				strcpy(buff, turma[j].nome);
				strcpy(turma[j].nome, turma[j + 1].nome);
				strcpy(turma[j + 1].nome, buff);
				aux = turma[j].idade;
				turma[j].idade = turma[j + 1].idade;
				turma[j + 1].idade = aux;
			}
		}
	}
	for ( int i = 0; i < 3; i++){
		cout << "Nome: ";
		cout << turma[i].nome;
		cout << "\nIdade: ";
		cout << turma[i].idade << endl;
	}

	
	return 0;
}
