using System;

namespace PositivoseMedia_1064
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cont = 0;
			double media = 0;

			for (int i = 0; i <= 5; i++)
			{
				double entrada = double.Parse(Console.ReadLine());

				if (entrada > 0)
				{
					media += entrada;
					cont++;
				}
			}
			media = media / cont;

			Console.WriteLine($"{cont} valores positivos");
			Console.WriteLine($"{media:F1}");


		}
	}
}