using System;

namespace SomadeImparesConsecutivosl_1071
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());

			int soma = 0;

			if (x>y)
			{
				int aux = x;
				x = y;
				y = aux;


                for (int i = x + 1; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }

                Console.WriteLine(soma);

            }
			else
			{
                for (int i = x + 1; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }

                Console.WriteLine(soma);

            }
        }
	}
}