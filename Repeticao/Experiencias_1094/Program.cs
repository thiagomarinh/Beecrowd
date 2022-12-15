using System;

namespace Experiencias_1094
{
	class Program
	{
		public static void Main(string[] args)
		{
			double i = 0;
			while (i <= 2)
			{

				for (double j = 1; j <= 3; j++)
				{
                    double j1 = j + i;

                    Console.WriteLine($"I={Math.Round(i,1)} J={Math.Round(j1,1)}");
            				
                }
                i = i + 0.2;
            }
		}
	}

}