using System;

namespace Media2_1006
{
	class Program
	{
		public static void Main(string[] args)
		{
			double nota1, nota2, nota3, media;

			nota1 = double.Parse(Console.ReadLine());
			nota2= double.Parse(Console.ReadLine());
			nota3= double.Parse(Console.ReadLine());
			media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

			Console.WriteLine($"MEDIA = {media:F1}");
		}
	}
}