#include <iostream>
using namespace std;

/********************************
 o que � uma estrutura e como a utilizar
*********************************/

// declara��o de um novo tipo que se chama "pes"
struct pes{
	char nome[81];	// campo da estrutura
	int idade;		// campo da estrutura
};

int main(int argc, char** argv) {
	pes aluno; // criar a vari�vel "aluno" do tipo "pes"
	pes turma[5];  // criar um array em que cada elemento � uma estrutura

	// ler a idade do aluno
	cout << "Idade do aluno: ";
	cin >> aluno.idade; //usar o campo "idade" da vari�vel "aluno"
	
	// Escrever o valor lido
	cout << "A idade do aluno e' " << aluno.idade << "\n";
	
	// Guardar a idade do aluno no 1� elemento da turma
	//turma[0].idade = aluno.idade;
	
	// Ler as idades dos 5 alunos
	for (int i = 0; i < 5; i++){
		cout << "\nIdade do aluno: "<< i + 1 << "\n";
		cin >> turma[i].idade;
	}
	// Escrever as idades dos 5 alunos
	for (int i = 0; i < 5; i++)
		cout << "\nIdade do aluno: " <<  i + 1 << " é " << turma[i].idade;

	
	cout << endl << "\nbye bye" << endl;
	
	return 0;
}
