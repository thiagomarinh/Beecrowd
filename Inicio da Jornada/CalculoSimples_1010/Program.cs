using System;

namespace CalculoSimples_1010
{
	class Program
	{
		public static void Main(string[] args)
		{
			int codigoPeca1, numeroPeca1, codigoPeca2, numeroPeca2;
			double valorPeca1, valorPeca2, totalPagar;

			string[] vetor1 = Console.ReadLine().Split();
			string[] vetor2 = Console.ReadLine().Split();

			codigoPeca1 = int.Parse(vetor1[0]);
			numeroPeca1 = int.Parse(vetor1[1]);
			valorPeca1 = double.Parse(vetor1[2]);
			codigoPeca2 = int.Parse(vetor2[0]);
			numeroPeca2 = int.Parse(vetor2[1]);
			valorPeca2 = double.Parse(vetor2[2]);
			totalPagar = (numeroPeca1 * valorPeca1) + (numeroPeca2 * valorPeca2);

			Console.WriteLine($"VALOR A PAGAR: R$ {totalPagar:F2}");
		}
	}
}