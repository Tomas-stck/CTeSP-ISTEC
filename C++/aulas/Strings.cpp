/************************************************************************
* esta sequ�ncia de exemplos mostra as diferen�as entre usar strings
* 	- no formato de array de caracteres
* 	ou
*	- no formato string (objecto)
************************************************************************/
#include <iostream>
//#include <stdlib.h>
#include <string.h>  // para o array de caracteres
#include <windows.h> // para a fun��o Sleep(miliseconds);
using namespace std; // para o objecto string (e para o cin e cout)

int main(int argc, char** argv) {
	/*********************************
	 array de char (termina com '\0')
	**********************************/
	cout << "******************* Array de char *************\n\n";
	char st1[81], st1final[81], res1[161];
	
	cout << "Escreva uma string: ";
	// para ler deve-se usar a fun��o cin.getline()
	cin.getline(st1,81); // � obrigat�rio especificar a dimens�o do array
	cout << "\nEu li:" << st1 << endl;
	
	cout << "Comprimento da string: " << strlen(st1) << endl;
	
	// percorrer uma string
	for(int i=0; i<strlen(st1); i++){
		cout << st1[i]; // escrever a string, caracter a caracter
		Sleep(100); // para ir escrevendo devagar
	}
	cout << endl;
	
	// outra forma de percorrer a string
	for(int i=0; st1[i]!='\0'; i++){
		cout << st1[i]; // escrever a string, caracter a caracter
		Sleep(100); // para ir escrevendo devagar
	}
	cout << endl;
	
	// copiar strings
	// se tentarmos "st1final = st1;" o compilador d� erro
	// n�o se podem fazer atribui��es tal como se fazem para os tipos simples
	// em vez disso, ou se faz um "for" para percorrer a string,
	// ou se usa a fun��o strcpy(destino, origem)
	strcpy(st1final, st1);
	cout << "Comprimento da string st1final = " << strlen(st1final) << endl;
	cout << "st1final=" << st1final << endl;
	
	// juntar (concatenar) strings
	strcpy(res1, st1);
	strcat(res1, st1final); // acrescentar no fim da string
	cout << "Comprimento da string res1 = " << strlen(res1) << endl;
	cout << "res1=" << res1 << endl;
	
	/***************************************************
	 objecto string ('\0' � um caracter como os outros)
	****************************************************/
	cout << "\n\n\n******************* objecto string *************\n\n";
	string st2, st2final, res2;
	
	cout << "Escreva outra string: ";
	getline(cin, st2); //fun��o para ler strings
	
	cout << "\nEu li:" << st2 << endl;
	
	cout << "Comprimento da string: " << st2.size() << endl;
	// tamb�m se pode usar
	cout << "Comprimento da string: " << st2.length() << endl;
	
	// percorrer uma string
	// N�o se deve usar o teste "st2[i]!='\0'" como se faz no array de char
	for(int i=0; i < st2.size(); i++){
		cout << st2[i]; // escrever a string, caracter a caracter
		Sleep(100); // para ir escrevendo devagar
	}
	cout << endl;
	
	// copiar strings
	// com o ojecto string, podem-se fazer atribui��es usando o =
	// tal como se faz para os outros tipos
	st2final = st2;
	cout << "Comprimento da string st2final = " << st2final.size() << endl;
	cout << "st2final=" << st2final << endl;
	
	// juntar (concatenar) strings
	res2 = st2 + st2final;
	cout << "Comprimento da string res2 = " << res2.size() << endl;
	cout << "res2=" << res2 << endl;

	return 0;
}
