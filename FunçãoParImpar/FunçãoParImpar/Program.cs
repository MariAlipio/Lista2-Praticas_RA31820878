using System;

namespace FunçãoParImpar
{
    class Program
    {

        static bool verifica(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }


        static void Main(string[] args)
        {
            int n = 0;

            for (n = 0; n <= 10; n++)
            {
                Console.WriteLine(verifica(n));

            }
            Console.ReadKey();
                                                  
        }
    }
}
