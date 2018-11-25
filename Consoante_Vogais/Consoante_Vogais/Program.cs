using System;
using System.Linq;

namespace Consoante_Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um caractere:");

            var caractere = Console.ReadLine().ToArray();

            bool evogal = false;
            bool umaletra = true;
            string[] vogais = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U", "y", "Y" };

            //Para escrever array
            //foreach (var item in resultado)
            //{
            //    Console.WriteLine(item);
            //}
            Console.Clear();

            if (caractere.Length >= 2)
            {
                Console.WriteLine("Entrada rejeitada!");
                umaletra = false;
            }

            if (umaletra)
            {
                for (int i = 0; i < vogais.Length; i++)
                {

                    if (caractere[0].ToString() == vogais[i])
                    {
                        evogal = true;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                if (evogal)
                {
                    Console.WriteLine("O caracter informado é uma vogal.");
                }
                else
                {
                    Console.WriteLine("O caracter informado é uma consoante.");
                }
            }

            Console.ReadKey();
            
        }
    }
}
