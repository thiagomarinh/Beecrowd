﻿using System;

namespace Multiplosde13_1132
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());

			int soma = 0;

			if (x > y)
			{
				int aux = y;
				y = x;
				x = aux;

                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
                Console.WriteLine(soma);
            }
			else
			{
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
                Console.WriteLine(soma);
            }
        }
			
	}
}