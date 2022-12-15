using System;

namespace Medi_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			double N1, N2, N3, N4;

			string[] vetor = Console.ReadLine().Split();

			N1 = double.Parse(vetor[0]);
			N2 = double.Parse(vetor[1]);
			N3 = double.Parse(vetor[2]);
			N4 = double.Parse(vetor[3]);

			double media = Math.Truncate((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10;

			Console.WriteLine($"Media: {media:F1}");

			if (media >= 7.0)
			{
				Console.WriteLine("Aluno aprovado.");
			}
			else if (media < 5.0)
			{
                Console.WriteLine("Aluno reprovado.");
            }
			else if (media >= 5.0 && media < 7.0)
			{
				Console.WriteLine("Aluno em exame.");

                double notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaExame:F1}");

				double notaFinal = (notaExame + media) / 2;

                if (notaFinal >= 5.0)
				{
					Console.WriteLine("Aluno aprovado.");
					Console.WriteLine($"Media final: {notaFinal:F1}");
				}
				else if (notaFinal < 5.0)
				{
					Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {notaFinal:F1}");

                }
            }
        }
    }
}