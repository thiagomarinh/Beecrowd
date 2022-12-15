using System;

namespace NotasEMoedas_1021
{
    class Program
    {

        static void Main(string[] args)
        {
            double valor;
            int cedula, moeda, fracao;
            valor = double.Parse(Console.ReadLine());

            if (0 <= valor && valor <= 1000000.00)
            {
                Console.WriteLine("NOTAS:");

                cedula = (int)(valor / 100);
                Console.WriteLine($"{cedula} nota(s) de R$ 100.00");
                valor = valor % 100;

                cedula = (int)(valor / 50);
                Console.WriteLine($"{cedula} nota(s) de R$ 50.00");
                valor = valor % 50;

                cedula = (int)(valor / 20);
                Console.WriteLine($"{cedula} nota(s) de R$ 20.00");
                valor = valor % 20;

                cedula = (int)(valor / 10);
                Console.WriteLine($"{cedula} nota(s) de R$ 10.00");
                valor = valor % 10;

                cedula = (int)(valor / 5);
                Console.WriteLine($"{cedula} nota(s) de R$ 5.00");
                valor = valor % 5;

                cedula = (int)(valor / 2);
                Console.WriteLine($"{cedula} nota(s) de R$ 2.00");
                valor = valor % 2;

                Console.WriteLine("MOEDAS:");

                moeda = (int)(valor / 1);
                Console.WriteLine($"{moeda} moeda(s) de R$ 1.00");

                fracao = (int)Math.Truncate((valor - Math.Truncate(valor)) * 100);

                moeda = (int)(fracao / 50);
                Console.WriteLine($"{moeda} moeda(s) de R$ 0.50");
                fracao = fracao % 50;

                moeda = (int)(fracao / 25);
                Console.WriteLine($"{moeda} moeda(s) de R$ 0.25");
                fracao = fracao % 25;

                moeda = (int)(fracao / 10);
                Console.WriteLine($"{moeda} moeda(s) de R$ 0.10");
                fracao = fracao % 10;

                moeda = (int)(fracao / 5);
                Console.WriteLine($"{moeda} moeda(s) de R$ 0.05");
                fracao = fracao % 5;

                moeda = (int)(fracao / 1);
                Console.WriteLine($"{moeda} moeda(s) de R$ 0.01");


            }

        }

    }

}