using System;

namespace Animal_1049
{
    class Program
    {
       public static void Main(string[] args) 
       {

            string entrada1 = Console.ReadLine();
            string entrada2 = Console.ReadLine();
            string entrada3 = Console.ReadLine();

            if (entrada1 == "vertebrado")
            {
                if (entrada2 == "ave")
                {
                    if (entrada3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }

                }
                else if (entrada2 == "mamifero")
                {
                    if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (entrada3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }

            }
            else if (entrada1 == "invertebrado")
            {
                if (entrada2 == "inseto")
                {
                    if (entrada3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (entrada3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }

                }
                else if (entrada2 == "anelideo")
                {
                    if (entrada3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
       }
    }
}