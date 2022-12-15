using System;

namespace IdadeEmDias_1020
{
	class Program
	{
		public static void Main(string[] args)
		{
			int entradaEmDias, ano, resto, mes, dia;

			entradaEmDias = int.Parse(Console.ReadLine());

			ano = entradaEmDias / 365;
			Console.WriteLine($"{ano} ano(s)");
			resto = entradaEmDias % 365;

			mes = resto / 30;
			Console.WriteLine($"{mes} mes(es)");
			resto = resto % 30;

			dia = resto;
			Console.WriteLine($"{dia} dia(s)");

		}
	}

}