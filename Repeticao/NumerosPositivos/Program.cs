using System;

namespace NumerosPositivos
{
	class Program
	{
		public static void Main(string[] args)
		{
            int cont = 0;

            for (int i = 0; i <= 5; i++)
            {
                double numero = double.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    cont++;
                }
            }
            Console.WriteLine($"{cont} valores positivos");

        }
    }

}