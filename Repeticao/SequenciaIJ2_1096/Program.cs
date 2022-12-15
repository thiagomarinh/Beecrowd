using System;

namespace SquenciaIJ1_1095
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;

            while (i <= 9)
            {
                int j = 7;
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");

                i += 2;
            }
        }
    }
}
