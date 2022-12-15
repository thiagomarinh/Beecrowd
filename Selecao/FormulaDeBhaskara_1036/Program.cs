using System;

namespace FormulaDeBhaskara_1036
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double a,b,c, delta, x1, x2;

			string[] vetor  = Console.ReadLine().Split();

			a = double.Parse(vetor[0]);
			b = double.Parse(vetor[1]);
			c = double.Parse(vetor[2]);


			delta = Math.Pow(b, 2) - 4 * a * c;
			
			x1 = (-b + Math.Sqrt(delta)) / (2 * a);
			x2 = (-b - Math.Sqrt(delta))/ (2 * a);

			if (delta < 0 || a == 0 )
			{
                Console.WriteLine("Impossivel calcular");
            }
			else
			{
                Console.WriteLine($"R1 = {x1:F5}");
                Console.WriteLine($"R2 = {x2:F5}");
            }
			
        }

    }

}