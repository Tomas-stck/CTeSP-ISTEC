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
            Console.WriteLine("Parabéns {0} ganhou {1}",sender.Jogador,premio);
        }
        static void Main(string[] args)
        {
            int eco = 5;
            eco = eco.inc(12);

            Console.WriteLine("Valor de i:{0}", eco);
            Jogo.Inicia();
            JogoDosDados ze = new JogoDosDados("Zé Maria",2000);
            ze.OnPremio += Jogo_OnPremio;
            ze.ONFalencia += Ze_ONFalencia;
            ze.comprarFichas(new FICHAS[] { FICHAS.AZUL, FICHAS.OURO });
            Thread.Sleep(2000);
            JogoDosDados maria = new JogoDosDados("MAria", 2000);
            maria.OnPremio += new OnPremio_Handler(Jogo_OnPremio);
            maria.ONFalencia += Ze_ONFalencia;
            ze.ver();
           
            maria.ver();
            for (int i = 0; i < 10; i++)
            {
                ze.jogar(new FICHAS[] { FICHAS.VERDE, FICHAS.OURO });

                maria.jogar(new FICHAS[] { FICHAS.VERDE, FICHAS.OURO });
            }


            /*Jogo maria = new Jogo("Maria das Dívidas", 2000);
            ze.ver();
            ze = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            maria.ver();*/
            Console.ReadLine();
        }

        private static void Ze_ONFalencia(Jogo sender)
        {
            Console.WriteLine("Falência do {0}", sender.Jogador);
        }
    }
}
