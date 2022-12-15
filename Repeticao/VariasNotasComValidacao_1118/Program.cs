using System;

namespace VariasNotasComValidacao_1118
{
	class Program
	{
		public static void Main(string[] args)
		{
			double nota1 = 0.0;
			double nota2 = 0.0;
            int novoCalculo = 0;

            do
            {
                do
                {
                    nota1 = double.Parse(Console.ReadLine());

                    if (nota1 <= 0 || nota1 > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }

                } while (nota1 <= 0 || nota1 > 10);

                do
                {
                    nota2 = double.Parse(Console.ReadLine());

                    if (nota2 <= 0 || nota2 > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }

                } while (nota2 <= 0 || nota2 > 10);

                double media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media:F2}");

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());

                    if (novoCalculo == 2)
                    {
                        return;
                    }

                } while (novoCalculo != 1);
                
            } while (true);		
        }
	}
}