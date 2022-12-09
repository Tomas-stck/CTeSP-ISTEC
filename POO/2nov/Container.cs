using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
	public static class Container
	{
		// Metodo de Extensão
		/* 
		-tem de ser estatico, 
		-tem de estar numa classe estática,
		-o primeiro parametro caracteriza este metodo ( this ......)
		-Não requer mexer no codigo fonte,
		-Não se necessita de drivar a classe
			-> sem mexer na classe consegue-se acrescentar um ou mais métodos
		*/

		public static void cumprimenta (this JogoDosDados eu, String frase)
		{
			System.Console.WriteLine("Eu {0} digo {1}", eu.Jogador, frase);
		}
		public static int incremento (this int alfa, int delta)
		{
			return alfa + delta;
		}
	}
}