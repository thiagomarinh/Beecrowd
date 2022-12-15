using System;

namespace ParesEntreCincoNumeros_1065
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cont = 0;

			for (int i = 0; i < 5; i++)
			{
				int numeros = int.Parse(Console.ReadLine());

				if (numeros % 2 == 0)
				{
					cont++;
				}
			}

			Console.WriteLine($"{cont} valores pares");
		}
	}
}

