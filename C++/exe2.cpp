#include <iostream>
#include <math.h>
using namespace std;

int main(int argc, char** argv)
{
	float r, b, ar, p;

	cout << "Introduza o raio da circunfrencia \n";
	cin >> r;
	ar = pow(r, 2) * M_PI;
	p = 2 * M_PI * r;
	cout << "Perimetro:" << p << endl;
	cout << "Area:" << ar << endl << endl;
	return 0;
}
