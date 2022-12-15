using System;

namespace DistanciEntreDoisPontos_1015
{
    class Program
    {
        public static void Main()
        {
            double x1, x2, y1, y2, distancia;

            string[] v1 = Console.ReadLine().Split();
            string[] v2 = Console.ReadLine().Split();

            x1 = double.Parse(v1[0]);
            y1 = double.Parse(v1[1]);
            x2 = double.Parse(v2[0]);
            y2 = double.Parse(v2[1]);
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{distancia:F4}");

        }
    }
}