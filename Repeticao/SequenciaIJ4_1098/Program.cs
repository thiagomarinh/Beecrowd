using System;

namespace SquenciaIJ3_1097
{
    class Program
    {
        public static void Main(string[] args)
        {
            double i = 0;
            double j = 1;

            Console.WriteLine($"I={i} J={j}");
            j++;
            Console.WriteLine($"I={i} J={j}");
            j++;
            Console.WriteLine($"I={i} J={j}");

            j = 1;

            while (i <= 2)
            {

                
                i += 0.2;
                j += 0.2;

                Console.WriteLine($"I={i:F1} J={j:F1}");
                j += 0.2;
                Console.WriteLine($"I={i:F1} J={j:F1}");
                j += 0.2;
                Console.WriteLine($"I={i:F1} J={j:F1}");
    
            }
        }
    }
}