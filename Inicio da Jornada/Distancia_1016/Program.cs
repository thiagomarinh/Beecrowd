using System;

namespace Distancia_1016
{
    class Program
    {
        public static void Main(string[] args)
        {
            int distancia, tempo;

            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * 2;

            Console.WriteLine($"{tempo} minutos");
        }
    }
}