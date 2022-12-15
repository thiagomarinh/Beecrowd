using System;

namespace CrescenteEDecrescente_1113
{
	class Program
	{
		public static void Main(string[] args)
		{
            int x = 0;
            int y = 0;

			do
			{
                string[] vetor = Console.ReadLine().Split();

                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);

                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (y > x)
                {
                    Console.WriteLine("Crescente");
                }

            } while (x != y);
		}
	}
}