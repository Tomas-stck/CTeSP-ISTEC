using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
	/* 
	Passos para criar eventos:
		1º Criar o Delegate = estrutura que aponta para um método, tem de ser void (?) *
		2º Declarar o Evento. Sender - classe que dispara o evento -> Declaração do evento
		3º Disparo do evento (premio sempre que os dados forem iguais)
		4º Registo do evento no cliente - em Program.cs Main
		5º Implementar o Event Handler no Cliente
	*/
	public delegate void OnFalencia_Handler(Jogo sender);
	public delegate void OnPremio_Handler(JogoDosDados sender, int aposta);
    public class JogoDosDados : Jogo
    {
		Random r = new Random();
		public int[] Dados = new int[] {1, 2};
		//base -> referencia que aponta para a classe mãe
		public JogoDosDados(String jogador):base(jogador)
		{

		}
		public JogoDosDados(String jogador, int montante):base(jogador, montante)
		{
			
		}
		/* Declaração do Evento */
		public event OnPremio_Handler OnPremio;
		public event OnFalencia_Handler OnFalencia;
        public override jogar(FICHAS[] fichas)
		{
			int aposta = 0;
			foreach (FICHAS f in fichas)
			{
				aposta += (int)f;
			}
			if (this.Montante > aposta)
			{
				this.Montante -= aposta;
			}
			else if (this.Montante > 0){
				aposta = this.Montante;
				this.Montante = 0;
			}
			else aposta = 0;
			if (aposta > 0)
			{
				Dados[0] = r.Next(1,7);
				Dados[1] = r.Next(1,7);
				if (Dados[0] == Dados[1]) {
					OnPremio(this, aposta); // disparo do Evento
				}
				ver();
			}
		}
		public override void ver()
        {
            base.ver(); // chama o metodo tal como está na classe mãe
			System.Console.WriteLine("Dado1: {0}  Dado2:{1}", this.Dados[0], this.Dados[1]);
			System.Console.WriteLine("--------------------------------------------\n\n");
        }
    }
}