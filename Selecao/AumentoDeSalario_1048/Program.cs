using System;

namespace AumentoDeSalario_1048
{
	class Program
	{
		public static void Main(string[] args)
		{
			double salario, reajuste, novoSalario;
			int percentual;
			
			salario = double.Parse(Console.ReadLine());

			if(salario >= 0 && salario <= 400.00)
			{
				percentual = 15;
				reajuste = salario * percentual / 100;
				novoSalario = salario + reajuste;
		
				Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Em percentual: {percentual} %");

            }
			else if (salario > 400.00 && salario <= 800.00)
			{
                percentual = 12;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Em percentual: {percentual} %");

            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                percentual = 10;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Em percentual: {percentual} %");

            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                percentual = 7;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Em percentual: {percentual} %");

            }
            else if (salario > 2000.00)
            {
                percentual = 4;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Em percentual: {percentual} %");

            }


        }
	}

}
