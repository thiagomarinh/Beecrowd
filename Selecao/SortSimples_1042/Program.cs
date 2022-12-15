using System;

namespace SorteSimples_1042
{

	class Program
	{
		public static void Main(string[] args)
		{
			int a, b, c;

			string[] vetor = Console.ReadLine().Split();

			a = int.Parse(vetor[0]);
			b = int.Parse(vetor[1]);
			c = int.Parse(vetor[2]);

			int d = a;
			int e = b;
			int f = c;

			if (a > b && b > c)
			{
				int aux = a;
				a = c;
				c = aux;

			}
			else if (a > b && c > b && c < a)
			{
				int aux = a;
				a = b;
				b = c;
				c = aux;

			}
			else if (b > a && a > c)
			{
				int aux = a;
				a = c;
				c = b;
				b = aux;

			}
			else if (b > c && c > a)
			{
				int aux = b;
				b = c;
				c = aux;

			}
			else if (c > a && a > b)
			{
				int aux = a;
				a = b;
				b = aux;

			}
			
			Console.WriteLine($"{a}\n{b}\n{c}\n\n{d}\n{e}\n{f}");


		}

	}

}
