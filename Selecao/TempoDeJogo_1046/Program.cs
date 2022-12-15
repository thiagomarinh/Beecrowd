using System;

namespace TempoDeJogo_1046
{
	class Program
	{
		public static void Main(string[] args)
		{
			int horaInicial, horaFinal, tempoJogo;
			int total = 24;

			string[] vetor = Console.ReadLine().Split();

			horaInicial = int.Parse(vetor[0]);
			horaFinal = int.Parse(vetor[1]);

			if (horaFinal >= 0 && horaFinal <= horaInicial)
			{
				horaFinal = horaFinal - 0;
				horaInicial = (horaInicial - total) * (-1);
				tempoJogo = horaInicial + horaFinal;

				Console.WriteLine($"O JOGO DUROU {tempoJogo} HORA(S)");
			}
			else if (horaInicial >= 0 && horaInicial < horaFinal && horaFinal <= 24)
			{
				tempoJogo = horaFinal - horaInicial;
                Console.WriteLine($"O JOGO DUROU {tempoJogo} HORA(S)");
            }
			else if (horaInicial == horaFinal)
			{
				tempoJogo = total;
                Console.WriteLine($"O JOGO DUROU {tempoJogo} HORA(S)");

            }
        }
	}
}
