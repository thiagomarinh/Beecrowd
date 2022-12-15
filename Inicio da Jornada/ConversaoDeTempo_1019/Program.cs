using System;

namespace ConversaoDeTempo_1019
{
    class Program
    {

        static void Main(string[] args)
        {
            int entradaEmSegundos, horas, resto, minutos, segundos;

            entradaEmSegundos = int.Parse(Console.ReadLine());

            horas = entradaEmSegundos / 3600;
            resto = entradaEmSegundos % 3600;

            minutos = resto / 60;
            resto = resto % 60;

            segundos = resto;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
            
        }

    }

}
