using System;

namespace SquenciaIJ1_1095
{
	class Program
	{
		public static void Main(string[] args)
		{
			int j = 60;
            int i = 1;
            do
			{
				Console.WriteLine($"I={i} J={j}");

				i += 3;
				j -= 5;

			} while (j >= 0);
		}
	}

}