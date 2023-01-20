#include <iostream>

using namespace std;

void	bubbleSort(int array[], int max)
{
	int	aux;

	for (int i = 0; i < max - 1; i++)
	{
		for (int j = 0; j < max - 1 - i; j++)
		{
			cout << '*';
			if (array[j] > array[j + 1])
			{
				aux = array[j];
				array[j] = array[j + 1];
				array[j + 1] = aux;
			}
		}
	}
}

void	flagBubbleSort(int array[], int max)
{
	int		aux;

	for (int i = 0, flag = true; i < max - 1 and flag; i++)
	{
		flag = false;
		for (int j = 0; j < max - 1 - i; j++)
		{
			cout << '+';
			if (array[j] > array[j + 1])
			{
				flag = true;
				aux = array[j];
				array[j] = array[j + 1];
				array[j + 1] = aux;
			}
		}
	}
}

int	main(int ac, char **av)
{
	const int max = 5;
	int num[max] = {3, 5, 6, 12, 20};
//	int num[max] = {20, 5, 12, 3, 6};
//	int num[max] = {6, 12, 5, 3, 20};

	bubbleSort(num, max);
	flagBubbleSort(num, max);

	for (int i = 0; i < max; i ++)
		cout << num[i] << ' ';

	return (0);
}