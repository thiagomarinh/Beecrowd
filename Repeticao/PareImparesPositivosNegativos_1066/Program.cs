using System;

namespace ParesImparesPositivosNegativos_1066
{
	class Program
	{
		public static void Main(string[] args)
		{

            int contPar = 0;
            int contImpar = 0;
            int contPositivo = 0;
            int contNegativo = 0;

            for (int i = 0; i < 5; i++)
			{
				int numero = int.Parse(Console.ReadLine());

				if (numero % 2 == 0)
				{
					contPar++;   //contador para numeros pares
				}
				else
				{
					contImpar++; //contador para numeros impares
				}

				if (numero > 0)
				{
					contPositivo++;
				}
				else if(numero < 0)
				{
					contNegativo++;
				}

			}

			Console.WriteLine($"{contPar} valor(es) par(es)");
            Console.WriteLine($"{contImpar} valor(es) impar(es)");
            Console.WriteLine($"{contPositivo} valor(es) positivo(s)");
			Console.WriteLine($"{contNegativo} valor(es) negativo(s)");

        }
    }
}