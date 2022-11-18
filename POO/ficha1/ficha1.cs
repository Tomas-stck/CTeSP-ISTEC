using System;
using System.Globalization;
using System.Linq.Expressions;

namespace ConsoleApp1
{
	public class Ficha1
	{
		public void Dobro(float num)
		{
			//while (!float.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número! Volte a tentar: ");
			Console.Write("Dobro de " + num);
			num *= 2;
			Console.WriteLine(" é " + num);
		}
		public void Par(float num)
		{
			//while (!float.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número! Volte a tentar: ");
			if (num % 2 == 0) Console.WriteLine("Número " + num + " é par");
			else Console.WriteLine("Número " + num + "não é par!");
		}
		public void Soma(int num)
		{
			//while (!int.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número! Volte a tentar: ");
			int total = 0;
			for (int i = 0; i < num; i++) total += i;
			Console.WriteLine("Total= " + total);
		}
		public int Soma2()
		{
			int num, total = 0;
			Console.WriteLine("Introduza números inteiros para somar.");
			Console.WriteLine("Para terminar, introduza '-1'.");
			while (true)
			{
				Console.Write("Input: ");
				while (!int.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro! Volte a tentar: ");
				if (num != 0 && num == -1)
				{
					Console.WriteLine("Total da soma = {0}", total);
					Console.Read();
					return 0;
				}
				total += num;
			}
		}
		public void Inverter1()
		{
			int num;
			Console.Write("Introduza um número inteiro entre 100 e 999 para inverter: ");
			while (!int.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro! Volte a tentar: ");
			if (num >= 100 && num <= 999)
			{
				string numI = num.ToString();
				char[] arr = numI.ToCharArray();
				Array.Reverse(arr);
				Console.WriteLine(arr);
				Console.Read();
			}
			else
			{
				Console.WriteLine("Input inválido!");
				Console.Read();
			}
		}
		public void Inverter2()
		{
			uint num;
			Console.Write("Introduza um número inteiro positivo para inverter: ");
			while (!uint.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro positivo! Volte a tentar: ");
			string numI = num.ToString();
			char[] arr = numI.ToCharArray();
			Array.Reverse(arr);
			Console.WriteLine(arr);
		}

		public void DigitControl()
		{
			int num, dc, uni, dez, cent;
			Console.WriteLine("Introduza um número com 3 algarismos.");
			while (true)
			{
				if (!(int.TryParse(Console.ReadLine(), out num)))
					Console.Write("Não é um número inteiro com 3 algarismos! Volte a tentar: ");
				else if (num < 100 || num > 999)
					Console.Write("Não é um número inteiro com 3 algarismos! Volte a tentar: ");
				else break;
			}
			uni = num % 10;
			dez = num / 10 % 10;
			cent = num / 100;
			dc = (5 * uni + 3 * dez + cent) % 7;
			Console.WriteLine("Digito de Controlo = {0}", num * 10 + dc);
		}

		public void Ordenar()
		{
			int temp, i = 0;
			int[] num = new int[3];
			Console.WriteLine("Introduza 3 números para listar em ordem crescente: ");
			while (i < 3)
			{
				Console.Write("[{0}] = ", i + 1);
				while (!int.TryParse(Console.ReadLine(), out num[i]))
					Console.WriteLine("Não é um número inteiro! Volte a tentar: ");
				i++;
			}
			if (num[0] > num[1])
			{
				temp = num[0];
				num[0] = num[1];
				num[1] = temp;
			}
			else if (num[1] > num[2])
			{
				temp = num[1];
				num[1] = num[2];
				num[2] = temp;
			}
			else if (num[0] > num[1])
			{
				temp = num[0];
				num[0] = num[1];
				num[1] = temp;
			}
			Console.Write("1º {0} \n2º {1} \n3º {2}\n", num[0], num[1], num[2]);
		}
		public void IntToBin()
		{
			int num, resto;
			Console.Write("Introduza um número inteiro para coverter em binário: ");
			while (!int.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro! Volte a tentar: ");
			if (num < 0) Console.WriteLine('-');
			while (num != 0)
			{
				resto = num % 2;
				num /= 2;
				Console.Write(resto);
			}
			Console.WriteLine();
		}
		public void SomaMediaMaxMin()
		{
			int n, i = 0;
			float med = 0, max = 0, min = 0;
			Console.WriteLine("Introduza quantos números vai introduzir: ");
			while (!int.TryParse(Console.ReadLine(), out n)) Console.Write("Não é um número inteiro! Volte a tentar: ");
			float[] num = new float[n];
			while (i < n)
			{
				Console.WriteLine("[{0}] : ", i + 1);
				while (!float.TryParse(Console.ReadLine(), out num[i]))
					Console.Write("Não é um número!\nVolte a tentar [{0}] : ", i + 1);
				med += num[i];
				if (max < num[i]) max = num[i];
				if (min > num[i]) min = num[i];
				i++;
			}
			Console.WriteLine("Soma = {0}\nMedia = {1}\nMax = {2}\nMin = {3}", med, med / n, max, min);
		}
		public void Primos()
		{   //algoritmo mais eficiente para numeros PRIMOS
			// enquanto o Quociente for menor que o DIVISOR, ele incrementa
			//poupa-se n iterações/divisoes
			uint num;
			Console.WriteLine("Primos: Introduza um número inteiro positivo: ");
			while (!uint.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro positivo! Volte a tentar: ");
			uint resto, quociente, div = 2;
			do
			{
				resto = num % div;
				quociente = num / div;
				div++;
			}
			while (quociente >= div && resto != 0);
			if (resto != 0 || num == 2) Console.WriteLine("É primo!");
			else Console.WriteLine("Não é primo");
		}
		public void Capicua()
		{
			int num;
			Console.WriteLine("Capicua: Introduza um número inteiro positivo: ");
			while (!int.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro positivo! Volte a tentar: ");
			int i = 0;
			string n = num.ToString();
			while (i < n.Length)
			{
				if (n[i] == n[n.Length - i]) i++;
				else Console.WriteLine("Não é capicua");
			}
			Console.WriteLine("É capicua");
		}
		public void factorial()
		{
			long num, f = 1;
			Console.WriteLine("Capicua: Introduza um número inteiro positivo: ");
			while (!long.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro positivo! Volte a tentar: ");
			while (num > 1)
				f *= num--;
			System.Console.WriteLine("Factorial de {0} é {1}", num, f);
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

		static void Main()
		{
			Ficha1 ficha1 = new();
			ficha1.Dobro(8);
			ficha1.Par(8);
			ficha1.Soma(3);
			ficha1.Soma2();
			ficha1.Inverter1();
			ficha1.Inverter2();
			ficha1.DigitControl();
			ficha1.Ordenar();
			ficha1.IntToBin();
			ficha1.SomaMediaMaxMin();
			ficha1.Primos();
			ficha1.Capicua();
			Console.Read();

		}
	}
}