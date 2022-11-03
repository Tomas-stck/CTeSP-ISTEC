
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

	public void DigitControl()
	{
		int num, dc, uni, dez, cent;
		Console.WriteLine("Introduza um número com 3 algarismos.");
		while (!int.TryParse(Console.ReadLine(), out num) && (num <100 || num > 999))
			Console.Write("Não é um número inteiro com 3 algarismos! Volte a tentar: ");
		uni = num % 10;
		dez = (num / 10) % 10;
		cent = num / 100;
		dc = (5*uni + 3*dez + cent) % 7;
		Console.WriteLine("Digito de Controlo = {0}", ((num*10) + dc));
	}

	public void Ordenar()
	{
		int temp, i = 0;
		int[] num;
		Console.WriteLine("Introduza 3 números.");
		while (i++ < 3)
		{
			while (!int.TryParse(Console.ReadLine(), out num[i]))
				Console.Write("Não é um número inteiro! Volte a tentar: ");
		}
		if (num[1] > num[2])
		{
			temp = num[1];
			num[1] = num[2];
			num[2] = temp;
		}
		else if (num[2] > num[3])
		{
			temp = num[2];
			num[2] = num[3];
			num[3] = temp;
		}
		else if (num[1] > num[2])
		{
			temp = num[1];
			num[1] = num[2];
			num[2] = temp;
		}
		Console.Write("1º {0} \n2º {1} \n3º {2}", num[0], num[1],num[2]);
	}
	public void IntToBin()
	{
		int num, resto;
		while (!int.TryParse(Console.ReadLine(), out num)) Console.Write("Não é um número inteiro! Volte a tentar: ");
		if (num < 0) Console.WriteLine('-');
		while (num != 0)
		{
			resto = num % 2;
			num /= 2;
			Console.Write(resto);
		}
	}

	public void SomaMediaMaxMin()
	{
		int n, i = 0;
		float med = 0, max = 0, min = 0;
		Console.WriteLine("Introduza quantos números vai introduzir: ");
		while (!int.TryParse(Console.ReadLine(), out n)) Console.Write("Não é um número inteiro! Volte a tentar: ");
		float[] num = new float[n];
		while (i++ < n)
		{
			while (!float.TryParse(Console.ReadLine(), out num[i]))
				Console.Write("Não é um número! Volte a tentar: ");
			med += num[i];
			if (max < num[i]) max = num[i];
			if (min > num[i]) min = num[i];
		}
		Console.WriteLine("Soma = {0}\nMedia = {1}\nMax = {2}\nMin = {3}", med, med/n, max, min);
	}
	public bool Primos(int num)
	{ 	//algoritmo mais eficiente para numeros PRIMOS
		// enquanto o Quociente for menor que o DIVISOR, ele incrementa
		//poupa-se n iterações/divisoes
		int resto, quociente, div = 2;
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
		for ( x = 1; x > 5; x++) y = x;
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
		ficha1.DigitControl();
		ficha1.Ordenar();
		ficha1.IntToBin();
		ficha1.SomaMediaMaxMin();
		ficha1.Primos(45);
	}	
}