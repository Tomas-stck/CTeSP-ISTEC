namespace selos1
{
    //private protected internal public
    class Program
    {
		static void Main(string[] args)
		{
			Utilidades util = new Utilidades();
			int quantia;
			try
			{
				Console.WriteLine("Introduza euros: ");
				quantia = int.Parse(Console.ReadLine());
				Console.WriteLine(util.selosI(quantia));
			}
			catch (Exception erro)
			{
				Console.WriteLine(erro.Message);
			}
			Console.ReadLine();
		}
	}
}