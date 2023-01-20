// 6 de Janeiro 2023

#include <iostream>
using namespace std;

int	soma(int n1, int n2){
	return n1 + n2;
}

void soma1(int n1, int n2, int &res){
	res = n1 + n2;
}

void soma2(int n1, int n2, int *res){
	*res = n1 + n2;
}

int main(int argc, char** argv)
{
	int v1 = 5, v2 = 4, r;

	r = soma( v1, v2);
	cout << r << endl;

	soma1( v1, v2, r);
	cout << r << endl;

	soma2( v1, v2, &r);
	cout << r << endl;

//relaçaõ j = i + 1
	for (int i = 0; i < 4; i++){
		for (int j = 0; j < i + 1; j++)
			cout << '*';
		cout << endl;
	}
	
	cout << endl;

//relaçaõ j = 4 - i
	for (int i = 0; i < 4; i++){
		for (int j = 0; j < 4 - i; j++)
			cout << '*';
		cout << endl;
	}
	
	cout << endl;

//relação j = 4 - 1 - i
	for (int i = 0; i < 4; i++){
		for (int j = 0; j < 4 - 1 - i; j++)
			cout << ' ';
		for (int j = 0; j < i + 1; j++)
			cout << '*';
		cout << endl;
	}
	
	cout << endl;

//
	for (int i = 0; i < 4; i++){
		for (int j = 0; j < i; j++)
			cout << ' ';
		for (int j = 0; j < 4 - i; j++)
			cout << '*';
		cout << endl;
	}
	cout << endl;

//
	for (int i = 0; i < 4; i++){
		for (int j = 0; j < 4 - 1 - i; j++)
			cout << ' ';
		for (int j = 0; j < i + 1; j++)
			cout << '*';
		for (int j = 0; j < i; j++)
			cout << '*';
		cout << endl;
	}
	
	cout << endl;
// retirando o ultimo FOR da árvore anterior
	for (int i = 0; i < 4; i++){
		for (int j = 0; j < 4 - 1 - i; j++)
			cout << ' ';
		for (int j = 0; j < 2 * i + 1; j++)
			cout << '*';
		cout << endl;
	}
	
	cout << endl;

	for (int i = 0; i < 4; i++)
		cout << '*';
	cout << endl;
	for (int i = 0; i < 4 - 2; i++){
		cout << '*';
		for (int i = 0; i < 4 - 2; i++)
			cout << ' ';
		cout << '*' << endl;
	}
	for (int i = 0; i < 4; i++)
		cout << '*';
	cout << endl;


	const int c = 2;
	int arr[3] = {1, 2, 3};
	for (int i = 0; i < 3; i++)
		arr[i] *= c;

	return 0;
}
