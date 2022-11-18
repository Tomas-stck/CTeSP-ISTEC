using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Nov18
{
	public class Program
	{
		static void Main(string[] args)
		{
			Action<String> action = (str) => { System.Console.WriteLine("Olá {0}", str); };
			action("José Neves");
			System.Console.ReadLine();

			Util util = new Util();
			int opcao, arg1, arg2;
			for ( ; ; )
			{
				try
				{
					opcao = util.menu();
					if (opcao == 0) break;
					switch (opcao)
					{
						case 1:
							System.Console.WriteLine("Soma dois nums");
							System.Console.Write("arg1");
							arg1 = int.Parse(System.Console.ReadLine());
							System.Console.Write("arg2");
							arg2 = int.Parse(System.Console.ReadLine());
							System.Console.WriteLine("A soma = {0}", util.soma(arg1, arg2));
							break;
						case 2:
							System.Console.WriteLine("Troca de dois inteiros");
							System.Console.Write("arg1");
							arg1 = int.Parse(System.Console.ReadLine());
							System.Console.Write("arg2");
							arg2 = int.Parse(System.Console.ReadLine());
							System.Console.WriteLine("arg1: {0} - arg2: {1}", arg1, arg2);
							util.troca(ref arg1, ref arg2);
							System.Console.WriteLine("arg1: {0} - arg2: {1}", arg1, arg2);
							System.Console.ReadLine();
							break;
						case 3:
							float media;
							int minimo, maximo, soma;
							util.estatistica(out media, out soma, out maximo, 17, 18, 16, 10);
							System.Console.WriteLine("Soma {0} Média:{1} Max:{2} Min:{3}", soma, media, maximo, minimo);
						case 4:
							System.Console.WriteLine("Metodos anónimos");// !!!!!!!!!!!!!!!!!!!!
							System.Console.Write("arg1");
							arg1 = int.Parse(System.Console.ReadLine());
							System.Console.Write("arg2");
							arg2 = int.Parse(System.Console.ReadLine());
							opera func = util.soma;
							System.Console.WriteLine("Soma: {0}", func(arg1, arg2));
							func = delegate(int a, int b) {return a - b;};
							System.Console.WriteLine("Subtração: {0}", func(arg1, arg2));
							func = (x, y) => x * y;
							System.Console.WriteLine("Multiplicação por arrow function: {0}", func(arg1, arg2));
							System.Console.ReadLine();
						case 5:
							System.Console.WriteLine("IEnumerable");// !!!!!!!!!!!!!!!!!!!!
							System.Console.Write("Limite");
							arg1 = int.Parse(System.Console.ReadLine());
							System.Console.Write("arg2");
							var numeros = util.SacaNumeros(arg1, util.isPrime);
							foreach (int i in numeros) ConsoleApp1.Write("{0}::", i);
							System.Console.ReadLine();
						default:
							System.Console.WriteLine("Opcao errada");
							System.Console.ReadLine();
							break;
					}
				}
				catch (Exception erro)
				{
					System.Console.WriteLine(erro.Message);
					System.Console.ReadLine();
				}
				finally
				{

				}
				
			}

		}
	}
}
