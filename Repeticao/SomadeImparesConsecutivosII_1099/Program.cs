using System;

namespace SomadeImparesConsecutivosII_1099
{
	class Program
	{
		public static void Main(string[] args)
		{
			int soma;

            int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				soma = 0;
				string[] vetor = Console.ReadLine().Split();

				int x = int.Parse(vetor[0]);
				int y = int.Parse(vetor[1]);

				if (x > y)
				{
					int aux = x;
					x = y;
					y = aux;
				}
				if (true)
				{
                    for (int cont = x + 1; cont < y; cont++)
                    {
                        if (cont % 2 != 0)
                        {
                            soma += cont;
                        }
                    }
                }                                   
                
                Console.WriteLine(soma);
            }
		}
	}
}
