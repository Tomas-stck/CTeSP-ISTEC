
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
		Console.WriteLine("Para terminar, introduza '-1'.");
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
		if (num >= 100 && num <= 999)
        {
			string numI = num.ToString();
            char[] arr = numI.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
			Console.Read();
		}
		else
        {
            Console.WriteLine("Input inválido!");
            Console.Read();
        }
	}
	public void Inverter2(uint num)
	{
			string numI = num.ToString();
			char[] arr = numI.ToCharArray();
			Array.Reverse(arr);
			Console.WriteLine(arr);
			Console.Read();
	}

	public bool Primos(int num)
	{ //algoritmo mais eficiente para numeros PRIMOS
		// enquanto o Quociente for menor que o DIVISOR, ele incrementa
		//poupa-se n iterações/divisoes
		int resto, quociente, div = 2;
		Console.Write("Insira um numero:");
		int num = Console.ReadLine();
		do
		{
			resto = num % div;
			quociente = num / div;
			div++; 
		} 
		while (quociente >= div && resto !=0);
		return (resto != 0) || (num == 2);
	}
	public void Teste()
	{
		int x = 1, y = 2;
		for ( x , y; x > 5; x++) y = x;
		while (x++ < 5) y = x;
		Console.WriteLine("x = " + x + " | y = " + y);
	}
	static void Main()
    {
        Ficha1 ficha1 = new();
		ficha1.Dobro(8);
		ficha1.Par(8);
		ficha1.Soma(3);
		ficha1.Soma2();
        ficha1.Inverter1(100);
		ficha1.Inverter2(100);
	}
}