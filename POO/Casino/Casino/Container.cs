using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public static  class Container
    {
        public static void cumprimenta(this JogoDosDados eu, String frase)
        {
            Console.WriteLine("Eu {0} digo {1}", eu.Jogador, frase);
        }
        public static int inc(this  int alfa, int delta) {
            return  alfa + delta;
        }
    }
}
