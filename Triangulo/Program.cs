using System;

namespace Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo T = new Triangulo(1, 2, 1);

            Console.WriteLine(T.Avalia());

        }
    }
}
