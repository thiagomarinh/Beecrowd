﻿using System;

namespace ParOuImpar_1074
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{

				int valor = int.Parse(Console.ReadLine());

				if (valor > 0 && valor % 2 == 0)
				{
					Console.WriteLine("EVEN POSITIVE");
				}
				else if (valor < 0 && valor % 2 == 0)
				{
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (valor > 0 && valor % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (valor < 0 && valor % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
				else if (valor == 0)
				{
					Console.WriteLine("NULL");
				}

            }
		}
	}
}