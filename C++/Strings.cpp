#include <iostream>
#include <string.h>

//#include <stdlib.h>

using namespace std;

int	main(int ac, char **av){

	//##########################################
	//       Char [ ]  - Array de caracteres
	/////////////////////////////////////////////////
	char st1[81], st1final[81], res1[161];

	cout << "Escreva uma STRING: \n";
	cin.getline(st1, 81);

	cout << "\nEu li: "<< st1 << endl;

	cout << "Comprimento da string: "<< strlen(st1) << endl;

	for (int i = 0; i < strlen(st1); i++)
		cout << st1[i];
	cout << endl;
	for (int i = 0; st1[i] != 0; i++)
		cout << st1[i];

	//##############################
	//       Objecto STRING
	/////////////////////////////////////

	cout << "\n\n OBJECTOS string \n\n";

	string st2, st2final, res2;

	cout <<  "\n Escreva uma string: \n";
	getline(cin, st2); // função para ler strings

	cout << "\nEu li: "<< st2 << endl;

	cout << "Comprimento da string: " << st2.size() << endl;

	cout << "Comprimento da string: " << st2.length() << endl;

	// nao se itera uma string com --> !='\0' como se fosse char[]!!!
	for (int i = 0; i < st2.size(); i++)
		cout << st2[i];

	cout << endl;

	//copiar strings
	st2final = st2;
	cout << "Comprimento da string: " << st2final.size() << endl;
	cout << "st2final = " << st2final << endl;

	//juntar / concatenar strings
	res2 = st2 + st2final;
	cout << "Comprimento da string: " << res2.size() << endl;
	cout << "st2final = " << res2 << endl;



	return (0);
}

