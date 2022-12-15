using System;

namespace NumerosImpares_1067
{
	class Program
	{
		public static void Main(string[] args)
		{
			int X = int.Parse(Console.ReadLine());

			if (1 <= X && X <=1000)
			{
				for (int i = 0; i <= X; i++)
				{
					if (i % 2 != 0)
					{
						Console.WriteLine(i);
					}

				}
			}
		}
	}
}
