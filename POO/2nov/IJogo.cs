using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
	/* Todas as classes que implementam esta interface, têm de usar estes métodos.
		[Polimorfismo] acontece cada vez que esta interface seja implementada por classes diferentes,
		cujo estes métodos sejam desenvolvidos com corpos diferentes.
		[Interface: Conjunto de regras que obriga classes a desenvolver os métodos.] */
	interface IJogo
	{
		void comprarFichas(FICHAS[] fichas);
		void jogar(FICHAS[] fichas);
	}
	
}