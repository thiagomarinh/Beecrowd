using System;

namespace Salario_1008
{
	class Program
	{
		public static void Main()
		{
			int numFuncionario, quantidadeHoras;
			double valorHora, salario;

			numFuncionario = int.Parse(Console.ReadLine());
            quantidadeHoras = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());
			salario = valorHora * quantidadeHoras;

			Console.WriteLine($"NUMBER = {numFuncionario}");
			Console.WriteLine($"SALARY = U$ {salario:F2}");

        }
    }
}