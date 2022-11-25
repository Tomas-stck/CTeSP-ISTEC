
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov25
{
    public struct aposta
	{
        public int id;
        public int[5] numeros;
        public int[2] estrelas;

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[,] { {1,2,3,4},{5,6,7,8},{9,10,11,12} };
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

        }
    }
}


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