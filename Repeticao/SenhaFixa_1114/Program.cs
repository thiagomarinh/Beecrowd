using System;

namespace SenhaFixa_1014
{
    class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                int senha = int.Parse(Console.ReadLine());
                if (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    return;

                }
            } while (true);
            
        }
    }
}
