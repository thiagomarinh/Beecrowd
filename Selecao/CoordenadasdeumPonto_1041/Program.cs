using System;

namespace CoordenadasdeumPonto_1041
{
	class Program
	{
		public static void Main(string[] args) 
		{
			double x, y;

			string[] vetorEntradas = Console.ReadLine().Split();

			x = double.Parse(vetorEntradas[0]);
			y = double.Parse(vetorEntradas[1]);

			if (x == 0.0 && y == 0.0)
			{
				Console.WriteLine("Origem");
			}
			else if (x == 0.0)
			{
				Console.WriteLine("Eixo Y");
			}
			else if (y == 0.0)
			{
				Console.WriteLine("Eixo X");
			}
			else if (x > 0.0 && y > 0.0)
			{
				Console.WriteLine("Q1");
			}
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
			else if (x > 0.0 && y < 0.0)
			{
				Console.WriteLine("Q4");
			}

        }


	}

}
