using System;

namespace Consumo_1014
{
    class Program
    {
        public static void Main(string[] args)
        {
            int X;
            double Y;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            double consumoMedio = X / Y;

            Console.WriteLine($"{consumoMedio:F3} km/l");

        }
    }
}