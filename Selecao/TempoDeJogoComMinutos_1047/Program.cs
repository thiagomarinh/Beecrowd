using System;

namespace TempoDeJogoComMinutos_1047
{
	class Program
	{
		public static void Main(string[] args)
		{
			int horaInicial, horaFinal, minutoInicial, minutoFinal, tempoJogo;
			

            string[] vetor = Console.ReadLine().Split();

			horaInicial = int.Parse(vetor[0]);
			minutoInicial = int.Parse(vetor[1]);
			horaFinal = int.Parse(vetor[2]);
			minutoFinal = int.Parse(vetor[3]);

			minutoInicial += horaInicial * 60;
			minutoFinal += horaFinal * 60;
			tempoJogo = minutoFinal - minutoInicial;

			if (tempoJogo <=0)
			{
				tempoJogo += 24 * 60;
			}

			int hora = tempoJogo / 60;
			int minuto = tempoJogo % 60;
			Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minuto} MINUTO(S)");
        }
	}
}