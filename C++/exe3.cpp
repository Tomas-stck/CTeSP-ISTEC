#include <iostream>
#include <math.h>
using namespace std;

int main(int argc, char** argv)
{
	int a, b, c;

	cout << "Introduza valor: \n";
	cin >> a;
	cout << "Introduza valor: \n";
	cin >> b;
	cout << "Introduza valor: \n";
	cin >> c;
	if ( (a + b) > c || (a + c) > b || (c + b) > a)
		cout << "É um triangulo \n";
	else
		cout << "Não é triangulo \n";
	return 0;
}
