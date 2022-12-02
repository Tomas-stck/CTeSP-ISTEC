using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//private - protected - internal -public
namespace Casino
{

    public enum FICHAS:int
    {
           VERMELHA=10,
           VERDE=15,
           AZUL=25,
           PRATA=125,
           OURO=500
    }
    public abstract class Jogo : IJogo, IComparable<Jogo>
    {
        //elementos estáticos
        public const int MAXAPOSTA = 1000;
        public static int total;
        public static void Inicia()
        {
            Console.WriteLine("CASINO DO ISTEC");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("VALOR DA APOSTA MÁXIMA:{0}",Jogo.MAXAPOSTA );
            Console.WriteLine("FICHAS DISPONÍVEIS");
          
        }
 
        //campos
        private string _jogador;
        protected int _montante;
        //properties
        #region properties
        public string Jogador
        {
            get { return _jogador; }
        }
        public int Montante
        {
            get { return _montante; }
            set {
                if (value >= 0) this._montante = value;
            }
        }
        #endregion

        #region construtores
        //overloading
        public Jogo(string jogador)
        {
            this._jogador = jogador;
            Jogo.total++;
        }

        public Jogo(String jogador, int montante):this(jogador)
        {
            this.Montante = montante;
        }

         ~Jogo()
        {
            Console.WriteLine("Destrutor desreferenciando o {0}", this._jogador);
            Jogo.total--;
        }
        #endregion
		//metodos da Interface
		// VIRTUAL permite fazer override ao método
        public virtual void ver()
        {
            Console.WriteLine("--------------------------< "+ this._jogador +" >----------------------------");
            Console.WriteLine("Montante disponível: {0}", this._montante);
            Console.WriteLine("Total de jogadores no casino:{0}", Jogo.total);
        }
		public void comprarFichas(FICHAS[] fichas)
		{
			int euros = 0;
			foreach (FICHAS f in fichas)
			{
				euros += (int)f;
			}
			this._montante += euros;
		}
		//método abstracto ( algo que tem de ser desenvolvido e ainda nao está pronto)
		//obriga a que a classe seja abstrata também
		public abstract void jogar(FICHAS[] fichas);
		public int CompareTo(Jogo other)
		{
			return other.Montante - this.Montante;
		}
    }
}
