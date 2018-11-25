using System;

namespace N_Primos
{
    class Program
    {

        static public bool NPrimo(int numero)
        {
            for (int x = 2; x < numero; x++)
            {
                if (numero % x == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Insira um numero:");
            int n_informado = Int32.Parse(Console.ReadLine());


            if (NPrimo(n_informado) == true)
            {
                Console.WriteLine( n_informado + " É um número primo");
            }
            else
            {
                Console.WriteLine( n_informado + " NÃO é um número primo");
            }







            Console.ReadKey();


        }
    }
}
