using System;

namespace SalarioComBonus_1009
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nomeVendedor;
			double salarioFixo, vendasEfetuadas, totalReceber;

			nomeVendedor = Console.ReadLine();
			salarioFixo = double.Parse(Console.ReadLine());
			vendasEfetuadas = double.Parse(Console.ReadLine());
			totalReceber = salarioFixo + (vendasEfetuadas * 15/100);

			Console.WriteLine($"TOTAL = R$ {totalReceber:F2}");
		}
	}
}