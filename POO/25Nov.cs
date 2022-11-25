
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Nov25
{
/* Struct:
	1 -Não inicializa campos
	2 -Não admite DEFAULT Constructor
	3 -É um VALUE type, e não um Reference Type. Não opera com base em apontadores
*/
	public struct aposta
	{
		public int id;
		public int[5] numeros;
		public int[2] estrelas;
		public Aposta(int id)
		{
			this.id = id;
			numeros = new int[5];
			estrelas = new int[2];
		}
		public void ver()
		{
			System.Console.WriteLine("----------------Aposta nº " + this.id + "----------------");
			System.Console.Write("Números: ");
			foreach (int n in numeros) System.Console.Write("{0}::", n);
			System.Console.WriteLine("\nEstrelas:");
			foreach (int e in estrelas) System.Console.Write("{0}::", e);
			System.Console.WriteLine("\n");
		}
		public void apostar()
		{
			Random r = new Random();
			int i, j;
			for (int i = 0; i < this.numeros.Length; i++)
			{
				numeros[i] = r.Next(50) + 1;
				for (int j = 0; j < i; j++)
				{
					if (numeros[j] == numeros[i])
					{
						i--;
						break;
					}
				}
			}
			Array.Sort(numeros);
			for (int i = 0; i < estrelas.Length; i++)
			{
				estrelas[i] = r.Next(12) + 1;
				for (int j = 0; j < i; j++)
				{
					if (estrelas[j] == estrelas[i])
					{
						i--;
						break;
					}
				}
			}
			Array.Sort(estrelas);
		}

    }
    class Program
    {
        static void Main(string[] args)
        {
			//LISTAS//
			List<int> valores = new List<int>();
			valores.Add(3);
			valores.Add(5);
			foreach ( int p in valores) System.Console.WriteLine("{0}, ", p);
			valores[0] = 123;
			for (int i = 0; i < valores.Count; i++)
			{
				System.Console.Write("{0}, ", valores[i]);
			}
			//
			Aposta[] apostas = new Aposta[10];
			for (int i = 0; i < apostas.Length; i++) 
			{
				apostas[i] = new Aposta(i);
				Thread.Sleep(100);
				apostas[i].apostar();
			}
			foreach (Aposta a in apostas) a.ver();
			System.Console.ReadLine();
        }
    }
}

 /* int[,] matriz = new int[,] { {1,2,3,4},{5,6,7,8},{9,10,11,12} };
            int i, j;
            for (i = 0; i < matriz.GetLength(0); i  ) {
                for (j = 0; j < matriz.GetLength(1); j  ) {
                    Console.Write("{0:D2}::" , matriz[i,j]);           
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Dentuças");

            int[][] dentucas = new int[3][];
            dentucas[0] = new int[] { 1, 2, 3 };
            dentucas[1] = new int[] { 5,};
            dentucas[2] = new int[] { 9,10,11 };

            for (i = 0; i < dentucas.Length; i  )
            {
                for (j = 0; j < dentucas[i].Length; j  )
                {
                    Console.Write("{0:D2}::", dentucas[i][j]);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
 */

/* int[] numeros = new int[] {1,2,3 };
              numeros[0] = 1;
              numeros[1] = 2;
              numeros[2] = 3;
              for(int i=0; i < numeros.Length; i  ) {
                  Console.Write("{0}::", numeros[i]);
              }
              Console.WriteLine("\n");

              numeros[1] = 50;
              foreach(int pass in numeros)
              {

                  Console.Write("{0}::", pass);
              }
              Console.WriteLine("\n\n"    numeros.GetUpperBound(0)   " "   numeros.GetLowerBound(0)    " ");
 */