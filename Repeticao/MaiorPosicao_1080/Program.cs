using System;

namespace MaiorPosicao_1080
{
	class Program
	{
		public static void Main(string[] args)
		{
            int maior = 0;
			int cont = 0;

            for (int i = 0; i < 100;i++)
			{
				int valor = int.Parse(Console.ReadLine());

				
				if (valor > maior)
				{
					maior = valor;
					cont = i;
				}
			}

			Console.WriteLine(maior);
			Console.WriteLine($"{cont + 1}");


		}
	}
}
