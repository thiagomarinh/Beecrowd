using System;

namespace DividindoXporY_1116
{
	class Program
	{
		public static void Main(string[] args)
		{
			//quantidade da Pares lidos
			double N = double.Parse(Console.ReadLine());

			for (int i = 0; i < N; i++)
			{
				string[] vetor = Console.ReadLine().Split();

				double x = int.Parse(vetor[0]);
				double y= int.Parse(vetor[1]);

				if (y == 0)
				{
                   Console.WriteLine("divisao impossivel");
                }
                else if (y !=0)
				{
                    double media = x / y;
                    Console.WriteLine($"{media:F1}");
				}
				
			}
		}
	}
}