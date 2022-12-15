using System;

namespace Intervalo_1072
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cont = 0;
			int cont2= 0;

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				int x = int.Parse(Console.ReadLine());

				if (x >= 10 && x <= 20)
				{
					cont++;
				}
				else
				{
					cont2++;
				}
			}
			Console.WriteLine($"{cont} in");
			Console.WriteLine($"{cont2} out");
		}
	}
}