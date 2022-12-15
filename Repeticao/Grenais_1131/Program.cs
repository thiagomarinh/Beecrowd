using System;

namespace Grenais_1131
{
	class Program
	{
		public static void Main(string[] args)
		{
			int contaGrenais = 0;
			int vitoriaInter = 0;
			int vitoriaGremio = 0;
			int empates = 0;

            do
			{
				string[] vetorGols = Console.ReadLine().Split();
				
				int golsInter = int.Parse(vetorGols[0]);
				int golsGremio = int.Parse(vetorGols[1]);

				contaGrenais++;

                if (golsInter > golsGremio)
				{
					vitoriaInter++;
				}
				else if (golsGremio > golsInter)
				{
                    vitoriaGremio++;
                }
				else
				{
					empates++;
				}

				Console.WriteLine("Novo grenal (1-sim 2-nao)");
				int novoGrenal = int.Parse(Console.ReadLine());

				if (novoGrenal == 2)
				{
					break;
				}		

			}while(true);

			Console.WriteLine($"{contaGrenais} grenais");
            Console.WriteLine($"Inter:{vitoriaInter}");
            Console.WriteLine($"Gremio:{vitoriaGremio}");
            Console.WriteLine($"Empates:{empates}");

			if (vitoriaInter > vitoriaGremio)
			{
				Console.WriteLine("Inter venceu mais");
			}
			else if (vitoriaGremio > vitoriaInter)
			{
				Console.WriteLine("Gremio venceu mais");
			}

        }
    }
}