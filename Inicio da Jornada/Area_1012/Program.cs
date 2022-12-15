using System;

namespace Area_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            double pi = 3.14159;

            string[] vetor = Console.ReadLine().Split();
            
            A = double.Parse(vetor[0]);
            B = double.Parse(vetor[1]);
            C = double.Parse(vetor[2]);

            areaTriangulo = (A * C) / 2;
            areaCirculo = pi * Math.Pow(C, 2);
            areaTrapezio = ((A + B) * C) / 2;
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");


        }

    }
}