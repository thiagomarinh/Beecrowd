using System;

namespace Esfera
{
	class Program
	{
		public static void Main(string[] args)
		{
			double raio, volume;
			double pi = 3.14159;

			raio = double.Parse(Console.ReadLine());

			volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

			Console.WriteLine($"VOLUME = {volume:F3}");
		}
	}
}