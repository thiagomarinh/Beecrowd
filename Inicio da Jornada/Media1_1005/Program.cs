using System;

namespace Media1_1005
{
	class Program
	{
		public static void Main(string[] args)
		{
			double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
			media = ((3.5 * nota1) + (7.5 * nota2)) / 11;

			Console.WriteLine($"MEDIA = {media:F5}");
		}
	}
}