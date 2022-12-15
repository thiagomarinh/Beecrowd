using System;

namespace Quadrantes_1115
{
	class Program
	{
		public static void Main(string[] args)
		{

			do
			{
				string[] vetor = Console.ReadLine().Split();

				int x = int.Parse(vetor[0]);
				int y = int.Parse(vetor[1]);

				if (x > 0 && y > 0)
				{
					Console.WriteLine("primeiro");
				}
				else if (x < 0 && y > 0)
				{
					Console.WriteLine("segundo");
				}
                else if (x < 0 && y < 0)
                {
					Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
					Console.WriteLine("quarto");
                }
				else if (x == 0 || y == 0)
				{
					return;
				}

            } while (true);
		}
	}

}