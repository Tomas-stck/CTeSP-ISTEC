#include <iostream>
using namespace std;

int main(int argc, char** argv)
{
	int a, b, ar, p;

	cout << "Introduza a largura \n";
	cin >> a;
	cout << "Introduza a comprimento \n";
	cin >> b;
	ar = a * b;
	p = (a * 2) + (b * 2);
	cout << "Perimetro:" << p << endl;
	cout << "Area:" << ar << endl;
	return 0;
}
