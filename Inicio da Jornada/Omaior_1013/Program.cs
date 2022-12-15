using System;

namespace Omaior_1013
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a, b, c, valorAbsolutoab;

			string[] vetor = Console.ReadLine().Split();

			a = int.Parse(vetor[0]);
			b = int.Parse(vetor[1]);
			c = int.Parse(vetor[2]);

			valorAbsolutoab = (a + b + Math.Abs(a - b)) / 2;

			if (valorAbsolutoab > c)
			{
				Console.WriteLine($"{valorAbsolutoab} eh o maior");
			}
			else
			{
				Console.WriteLine($"{c} eh o maior");
			}



		}
	}
}