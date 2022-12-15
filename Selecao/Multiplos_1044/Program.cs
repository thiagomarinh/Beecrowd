using System;

namespace Multiplos_1044
{
	class Program
	{
		public static void Main(string[] args) 
		{
			int num1, num2;

			string[] entradasVetor = Console.ReadLine().Split();

			num1 = int.Parse(entradasVetor[0]);
			num2 = int.Parse(entradasVetor[1]);

			if (0 == num1 % num2 || 0 == num2 % num1)
			{
				Console.WriteLine("Sao Multiplos");
			}
			else
			{
				Console.WriteLine("Nao sao Multiplos");
			}
		}


	}

}