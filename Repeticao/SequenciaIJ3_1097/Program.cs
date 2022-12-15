using System;

namespace SquenciaIJ3_1097
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            int j = 7;

            while (i<=9)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");

                j += 4;
                i += 2;

            }
        }
    }
}
