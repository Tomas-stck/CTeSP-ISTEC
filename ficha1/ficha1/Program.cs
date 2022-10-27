using System.Globalization;
using System.Linq.Expressions;

public class Ficha1
{
    public void Dobro(float num)
    {
		//while (!float.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número! Volte a tentar: ");
		Console.Write("Dobro de " + num);
		num *= 2;
        Console.WriteLine(" é " + num);
    }
    public void Par(float num)
    {
		//while (!float.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número! Volte a tentar: ");
		if (num % 2 == 0) Console.WriteLine("Número " + num + " é par");
        else Console.WriteLine("Número " + num + "não é par!");
    }
    public void Soma(int num)
    {
		//while (!int.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número! Volte a tentar: ");
		int total = 0;
        for (int i = 0; i < num; i++) total += i;
        Console.WriteLine("Total= " + total);
    }
    public int Soma2()
    {
        int num, total = 0;

		Console.WriteLine("Introduza números inteiros para somar.");
		Console.WriteLine("Para terminar, introduza ´-1´.");
		while (true)
        {
            Console.Write("Input: ");
            while (!int.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro! Volte a tentar: ");
            if (num != 0 && num == -1)
            {
                Console.WriteLine("Total da soma = {0}", total);
                Console.Read();
                return 0;
            }
            total += num;
        }
    }
    public void Inverter1(int num)
    {
		/*char temp;
		numI = num.ToString();
		char temp = '\0';
		string numI = num.ToString();
		temp = numI[0];
		numI[0] = numI[2];
		numI[2] = temp;
		 */
		if (num >= 100 && num <= 999)
        {
			string numI = num.ToString();
            char[] arr = numI.ToCharArray();
            Array.Reverse(arr);
            numI = arr.ToString();
            num = int.Parse(arr);
            Console.WriteLine(arr);
			Console.Read();
		}
		else
        {
            Console.WriteLine("Input inválido!");
            Console.Read();
        }
	}
    static void Main(string[] args)
    {
        Ficha1 ficha1 = new();
		ficha1.Dobro(8);
		ficha1.Par(8);
		ficha1.Soma(3);
		ficha1.Soma2();
        ficha1.Inverter1(100);
    }
}
