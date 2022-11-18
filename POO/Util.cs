using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Nov18
{
	public delegate int opera(int a, int b);// metodo abestrato, apontador de métodos
	class Util
	{
		public IEnumerable<int>SacaNumeros(int limite, Predicate<int> predicado)
		{
			for (int i = 0; i <= limite; i++)
			{
				if (predicado(i)) yield return i;
			}
		}
		public bool isPrime(int n) // Metodo BOOL para Predicates!!!!
		{
			int div = 2, resto, quoc;
			do
			{
				resto = n % div;
				quoc = n / div++;
			} while ( resto != 0 && quoc >= div);
			return resto != 0 || n == 2;
		}
		public void estatistica( out float media, out int soma, out int max, params int[] notas)
		{//Metodo OUT !!!!!
			soma = min = max = notas[0];
			media = (float)notas[0];
			for(int i = 1; i < notas.Length; i++)
			{
				soma += notas[i];
				media += (float)notas[i];
				if ( max < notas[i]) max = notas[i];
				if ( min < notas[i]) min = notas[i];
			}
			media = media / (float)notas.Length;
			Array.Sort(notas);
			foreach (int pass in notas) System.Console.WriteLine("{0}::", pass);
		}
		public long factorial_r(int n)
		{
			if (n == 1) return 1;
			return n * factorial_r(n - 1);
		}
		public long potencia_r(int n, int exp)
		{
			if (exp == 0) return 1;
			return n * factorial_r(n, exp - 1);
		}
		public long fibonnacci_r(int n)
		{
			if (n < 1) return 0;
			if (n == 1 || n == 2) return 1;
			return fibonnacci_r(n - 2) + fibonnacci_r(n - 1);
		}
		public void troca(ref int a, ref int b) //!!!!!!!!!!!!!!!! APONTADORES!!!!!!!!!!
		{
			int pivot = a;
			a = b;
			b = pivot;
		}
		public int soma(int a, int b)
		{
			return a + b;
		}
		public int menu()
		{
			int op;
			System.Console.WriteLine("0 - sair");
			System.Console.WriteLine("1 - soma");
			System.Console.WriteLine("2 - troca");
			System.Console.WriteLine("3 - Outs?");
			System.Console.WriteLine("4 - Delegates");
			System.Console.WriteLine("5 - IEnumerable");
			System.Console.Write("\tEscolha opção:");
			if (int.TryParse(ConsoleApp1.ReadLine(), out op))
			{
				return op;
			}
			else return -1;
		}
	}
}
