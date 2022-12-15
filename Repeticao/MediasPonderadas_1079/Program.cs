using System;

namespace MediasPonderadas_1079
{
	class Program
	{
		public static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{

				string[] vetor = Console.ReadLine().Split();

				double primeiroValor = double.Parse(vetor[0]);
				double segundoValor = double.Parse(vetor[1]);
				double terceiroValor = double.Parse(vetor[2]);

				double mediaPonderada = ((primeiroValor * 2) + (segundoValor * 3) + (terceiroValor * 5)) / 10;

				Console.WriteLine($"{mediaPonderada:F1}");


			}
		}
	}
}
