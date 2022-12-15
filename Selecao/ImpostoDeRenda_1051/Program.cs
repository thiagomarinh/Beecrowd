using System;

namespace ImpostoDeRenda_1051
{
	class Program
	{
		public static void Main(string[] args) 
		{
			double desconto8, desconto18, descontoTotal, desconto28;

			double salario = double.Parse(Console.ReadLine());

			if (salario > 0.00 && salario <= 2000.00)
			{
				Console.WriteLine("Isento");
			}
			else if (salario > 2000.00 && salario <= 3000.00)
			{
				salario = salario - 2000.00;
				desconto8 = (salario * 8) / 100;
				Console.WriteLine($"R$ {desconto8:F2}");
			}
			else if (salario > 3000.00 && salario <= 4500.00)
			{
				salario = salario - 2000.00;
				desconto8 = (1000.00 * 8) / 100;
				salario = salario - 1000.00;
				desconto18 = (salario * 18) / 100;
				descontoTotal = desconto8 + desconto18;
				Console.WriteLine($"R$ {descontoTotal:F2}");
			}
			else if (salario > 4500.00)
			{
				salario = salario - 2000.00;
                desconto8 = (1000.00 * 8) / 100;
                salario = salario - 1000.00;
                desconto18 = (1500.00 * 18) / 100;
				salario = salario - 1500.00;
				desconto28 = (salario * 28) / 100;
				descontoTotal = desconto8 + desconto18 + desconto28;
				Console.WriteLine($"R$ {descontoTotal:F2}");



            }
        }

	}

}
