namespace POO
{
    class Selos
    {
        public Selos (int euros)
        {
            string valor;
            int s5, s3, trouco;

            if (euros < 8) Console.WriteLine("Valor inválido, mínimo 8€!");
            else 
            {
                Console.WriteLine("Quantos selos de 3€?");
                valor = Console.ReadLine();
                s3 = int.Parse(valor);
                Console.WriteLine("Quantos selos de 5€?");
                valor = Console.ReadLine();
                s5 = int.Parse(valor);
                trouco = Verifica(euros, s3, s5);

                switch(trouco) 
                {
                    case -1:
                        Console.WriteLine("Valor inválido, núm. de selos não pode ser zero!");
                        break;
                    case 0:
                        Console.WriteLine("Valor inválido, núm. de selos excede o valor introduzido!");
                        break;
                    default:
                        Console.WriteLine("########################");
                        Console.WriteLine("Com {0} euros comprou: ", euros);
                        Console.WriteLine(" - {0} selos de 3 euros", s3);
                        Console.WriteLine(" - {0} selos de 5 euros", s5);
                        Console.WriteLine("Perdeu {0} de trouco", trouco);
                        Console.WriteLine("########################");
                        break;
                }
            }
        }

        public int Verifica (int valor, int num_selos3, int num_selos5)
        {
            int resto = 0;

            if ( num_selos3 <= 0 && num_selos5 <= 0) return -1; // erro de inputs
            
            else if ( num_selos3 == 0 && num_selos5 > 0)
            {
                if ( valor >= num_selos5 * 5)
                {
                    resto = valor - (5 * num_selos5);
                    return resto;
                }
                else return 0; // numero de selos superior aos euros 
            }
            
            else if ( num_selos3 > 0 && num_selos5 == 0)
            {
                if ( valor >= num_selos3 * 3)
                {
                    resto = valor - (3 * num_selos3);
                    return resto;
                }
                else return 0;
            }

            else if ( num_selos3 > 0 && num_selos5 > 0)
            {
                 if ( valor >= (num_selos3 * 3) + (num_selos5 * 5))
                {
                    resto = valor - ((3 * num_selos3) + (num_selos5 * 5)) ;
                    return resto;
                }
                else return 0;
            }
            else return 0;
        }
        
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Introduza o seu dinheiro: ");
            valor = int.Parse(Console.ReadLine());
            Selos var = new Selos(valor);
        }
    }
}