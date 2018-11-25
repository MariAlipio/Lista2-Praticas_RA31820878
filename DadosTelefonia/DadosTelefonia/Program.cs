using System;

namespace DadosTelefonia
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int unidade = 0;
            int dezena = 0;
            int centena = 0;
            int unidademilhar = 0;
            int quociente = 0;

            const int DECIMAL = 10;

            Console.Write("Escreva um numero de 4 digitos: ");
            int numero4digitos = Int32.Parse(Console.ReadLine());

            //Digito da unidade
            int restodiv = numero4digitos % DECIMAL;
            quociente = numero4digitos / DECIMAL;
            unidade = (restodiv+7)%10;

            //Digito da dezena
            restodiv = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            dezena = (restodiv + 7) % 10;

            //Digito da centena
            restodiv = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            centena = (restodiv + 7) % 10;


            //Digito da unidade de milhar
            unidademilhar = (quociente + 7) % 10;

            //Console.WriteLine("{0} {1} {2} {3}", unidademilhar, centena, dezena, unidade);

            int[] vet = new int[] { unidademilhar, centena, dezena, unidade };

            int aux = vet[0];
            vet[0] = vet[2];
            vet[2] = aux;
            aux = vet[1];
            vet[1] = vet[3];
            vet[3] = aux;

            Console.WriteLine("O Identificador codificado é: {0} {1} {2} {3}", vet[0], vet[1], vet[2], vet[3]);
            Console.ReadKey();
            
        }
    }
}
