#include <iostream>
using namespace std;

/********************************
 o que é uma estrutura e como a utilizar
*********************************/

// declaração de um novo tipo que se chama "pes"
struct pes{
	char nome[81];	// campo da estrutura
	int idade;		// campo da estrutura
};

int main(int argc, char** argv) {
	pes aluno; // criar a variável "aluno" do tipo "pes"
	pes turma[5];  // criar um array em que cada elemento é uma estrutura

	// ler a idade do aluno
	cout << "idade do aluno: ";
	cin >> aluno.idade; //usar o campo "idade" da variável "aluno"
	
	// Escrever o valor lido
	cout << "A idade do aluno e' " << aluno.idade << endl;
	
	// Guardar a idade do aluno no 1º elemento da turma
	turma[0].idade = aluno.idade;
	
	// Ler as idades dos 5 alunos
	for(int i=0; i<5; i++){
		cout << "Idade do aluno " << i+1 << ":";
		cin >> turma[i].idade;
	}
	
	// Escrever as idades dos 5 alunos
	for(int i=0; i<5; i++){
		cout << "Idade do aluno " << i+1 << ":"
			 << turma[i].idade << endl;
	}
	
	cout << endl << "bye bye" << endl;
	
	return 0;
}
