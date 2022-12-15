using System;

namespace SquenciadeNumeroseSoma_1101
{
	class Program
	{
		public static void Main(string[] args)
		{
			do
			{
				string[] vetor = Console.ReadLine().Split();

				int m = int.Parse(vetor[0]);
				int n = int.Parse(vetor[1]);

				if (m <= 0 || n <= 0)
				{
					break;
				}

				// troca de valores caso o primeiro valor for maior que o segundo
				if (m > n)
				{
					int aux = m;
					m = n;
					n = aux;
				}

				int soma = 0;
				//laço for primeiro até o segundo, ja que a troca ja foi feita la em cima no if
				for (int i = m; i <= n; i++)
				{
					Console.Write($"{i} ");
					soma += i;
				}
				Console.Write($"Sum={soma}");
				Console.WriteLine();
				
			} while (true);
		}
	}
}