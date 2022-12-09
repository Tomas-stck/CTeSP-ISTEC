using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//private - protected - internal -public
namespace Casino
{
	/* Quais a principais diferenças entre Struct e Class */
	public struct Xpto
	{
		int mesa;
		public Xpto(int n)
		{
			this.mesa = n;
		}
	}

	/* Enumeratores = !([Lista de constantes])!, nomes normalmente em maiúsculas */
    public enum FICHAS:int
    {
           VERMELHA=10,
           VERDE=15,
           AZUL=25,
           PRATA=125,
           OURO=500
    }
	/* Private - só é visivel na proprioa class
		Protected - visivel na propria classe e derivadas
		Internal - é visto dentro do Package
		Abstract - classe que tem pelo menos um metdo abstracto. Está impedida de instanciar objectos
		Herança -
	*/
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
			foreach (FICHAS f in Enum.GetValues(typeof(FICHAS)))
			{
				System.Console.WriteLine(f + "->" + (int)f + "€");
			}
        }
 
        //campos
        private string _jogador;
        protected int _montante;
        //properties - Métodos que permitem leitura ou escrita de campos.
		// Dá a possibilidade de criar regras
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

		//Destrutor
        ~Jogo()
        {
			// desconecta de Base Dados, desreferencia pointers...etc
            Console.WriteLine("Destrutor desreferenciando o {0}", this._jogador);
            Jogo.total--;
        }
        #endregion
		//metodos da Interface
		// VIRTUAL permite fazer override ao método na classe derivada
		// Override só é permitido por métodos Abstractos ou Virtuais
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
		//obriga derivadas a implementar, e a que a classe mãe seja abstrata
		public abstract void jogar(FICHAS[] fichas);
		public int CompareTo(Jogo other)
		{
			return other.Montante - this.Montante;
		}
    }
}
