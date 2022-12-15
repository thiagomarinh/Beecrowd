using System;

namespace Lanche_1038
{
	class Program
	{
		public static void Main(string[] args)
		{
			int codigoItem, quantidade;
			double preco, total;

			string[] vetor = Console.ReadLine().Split();
			codigoItem = int.Parse(vetor[0]);
			quantidade = int.Parse(vetor[1]);

			if (codigoItem == 1)
			{
				preco = 4.00;
				total = preco * quantidade;
				Console.WriteLine($"Total: R$ {total:F2}");
			}
			else if (codigoItem == 2)
			{
				preco = 4.50;
                total = preco * quantidade;
                Console.WriteLine($"Total: R$ {total:F2}");


            }
            else if (codigoItem == 3)
			{
				preco = 5.00;
                total = preco * quantidade;
                Console.WriteLine($"Total: R$ {total:F2}");


            }
            else if (codigoItem == 4)
			{
				preco = 2.00;
                total = preco * quantidade;
                Console.WriteLine($"Total: R$ {total:F2}");


            }
            else if (codigoItem == 5)
			{
				preco = 1.50;
                total = preco * quantidade;
                Console.WriteLine($"Total: R$ {total:F2}");

            }
        }
	}
}