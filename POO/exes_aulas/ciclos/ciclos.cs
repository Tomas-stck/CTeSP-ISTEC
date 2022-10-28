
namespace ciclos
{
	public class Program
	{
		public string Soma()
		{
			int soma = 0, limite, i = 1;

			Console.Write("Limite: ");
			limite = int.Parse(Console.ReadLine());
			while (limite-- != 0) // ou -> do {} while()
			{
				Console.Write("Introduza o valor [{0}]: ", i++);
				soma += int.Parse(Console.ReadLine());
			}
			return soma.ToString(); // é permitido ??
		}
		public void Main(string[] args)
		{
			Console.WriteLine(Soma()); // ou só Soma() ???
			Console.ReadLine();

			// int a, b, c, soma;
			// Console.WriteLine("a: ");
			// a = Console.ReadLine();
			// Console.WriteLine("b: ");
			// b = Console.ReadLine();
			// Console.WriteLine("c: ");
			// c = Console.ReadLine();
			// soma = a + b + c;
			// Console.WriteLine(soma.ToString());
			// Console.ReadLine();
		}
	}
}



