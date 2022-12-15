using System;

namespace TiposDeTriangulo_1045
{
	class Program
	{
		public static void Main(string[] args)
		{
			double A, B, C;

			string[] vetorEntrada = Console.ReadLine().Split();

			A = double.Parse(vetorEntrada[0]);
			B = double.Parse(vetorEntrada[1]);
			C = double.Parse(vetorEntrada[2]);

            if (C > A && C > B && B > A)
            {
                double aux = A;
                A = C;
                C = aux;

            }
            else if (B > A && B > C && C > A)
            {
                double aux = A;
                A = B;
                B = C;
                C = aux;

            }
            else if (B > A && B > C && B > C)
            {
                double aux = A;
                A = B;
                B = aux;

            }
            else if (C > A && C > B && A > B)
            {
                double aux = A;
                A = C;
                C = B;
                B = aux;

            }
            else if (A > B && A > C && C > B)
            {
                double aux = B;
                B = C;
                C = aux;

            }
            else if (A == B && C > A)
            {
                double aux = C;
                C = A;
                A = aux;

            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }

            if (A * A == B * B + C * C)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (A * A > B * B + C * C)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (A * A < B * B + C * C)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");

            }
        }
	}
}
