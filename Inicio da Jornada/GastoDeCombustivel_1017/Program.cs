using System;

namespace GastoDeCombustivel_1017
{
    class Program
    {
        public static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia;
            double quantidadeLitros, litrosNecessarios;

            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia= int.Parse(Console.ReadLine());
            quantidadeLitros = tempoGasto * velocidadeMedia;
            litrosNecessarios = quantidadeLitros / 12;

            Console.WriteLine($"{litrosNecessarios:F3}");
        }
    }
}