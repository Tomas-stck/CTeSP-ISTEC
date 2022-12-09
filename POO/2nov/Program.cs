using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Casino
{
    class Program
    {
		public static void Jogo_OnPremio(JogoDosDados sender, int aposta)
		{
			int premio = sender.Dados[0] * 2 * aposta;
			sender.Montante += premio;
			System.Console.WriteLine("Parabéns {0} ganhou {1}!", sender.Jogador, premio);
		}
        static void Main(string[] args)
        {
			// Metodo Enxtensor a funcionar:
			int eco = 5;
			eco = eco.incremento(1);
			System.Console.WriteLine("Metodo extensao: eco = {0}", eco);
			//

            Jogo.Inicia();
            JogoDosDados ze = new JogoDosDados("Zé Maria",2000);
			ze.OnPremio += Jogo_OnPremio; // registo do evento, defenindo o Event Handler
			ze.cumprimenta("Bom dia");
			Thread.Sleep(2000);
			JogoDosDados maria = new JogoDosDados("Maria", 2000);
			maria.OnPremio += Jogo_OnPremio;
			ze.ver();
			maria.ver();
			for(int i = 0; i < 10; i++)
			{
			ze.jogar(new FICHAS[] {FICHAS.VERDE, FICHAS.OURO});
			maria.jogar(new FICHAS[] {FICHAS.VERDE, FICHAS.OURO});
			}

            /* Jogo maria = new Jogo("Maria das Dívidas", 2000);
            ze.ver();
            ze = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            maria.ver(); */
            Console.ReadLine();
        }
    }
}
