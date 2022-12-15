using System;

namespace Triangulo_1043
{
	class Program
	{
		public static void Main(string[] args)
		{

			double A, B, C;

			string[] entradasVetor = Console.ReadLine().Split();

			A = double.Parse(entradasVetor[0]);
			B = double.Parse(entradasVetor[1]);
			C = double.Parse(entradasVetor[2]);


            if (A < (B + C) && B < (A + C) && C < (A + B))
            {
                double perimetroTriangulo = A + B + C;
                Console.WriteLine($"Perimetro = {perimetroTriangulo:F1}");
            }

            else if (A <= (B + C) && B <= (A + C) && C <= (A + B))
			{
				double areaTrapezio = ((A + B) * C) / 2;
				Console.WriteLine($"Area = {areaTrapezio:F1}");

			}
			
		}
	}
}