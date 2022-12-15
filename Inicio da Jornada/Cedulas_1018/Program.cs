using System;

namespace Cedulas_1018
{
    class Program
    {

        static void Main(string[] args)
        {
            int valor, cedula;

            
            valor = int.Parse(Console.ReadLine());

            if (0 < valor && valor < 1000000)
            {
                Console.WriteLine(valor);

                cedula = valor / 100;
                Console.WriteLine($"{cedula} nota(s) de R$ 100,00");
                valor = valor % 100;

                cedula = valor / 50;
                Console.WriteLine($"{cedula} nota(s) de R$ 50,00");
                valor = valor % 50;

                cedula = valor / 20;
                Console.WriteLine($"{cedula} nota(s) de R$ 20,00");
                valor = valor % 20;

                cedula = valor / 10;
                Console.WriteLine($"{cedula} nota(s) de R$ 10,00");
                valor = valor % 10;

                cedula = valor / 5;
                Console.WriteLine($"{cedula} nota(s) de R$ 5,00");
                valor = valor % 5;

                cedula = valor / 2;
                Console.WriteLine($"{cedula} nota(s) de R$ 2,00");
                valor = valor % 2;

                cedula = valor / 1;
                Console.WriteLine($"{cedula} nota(s) de R$ 1,00");


            }


        }

    }
}