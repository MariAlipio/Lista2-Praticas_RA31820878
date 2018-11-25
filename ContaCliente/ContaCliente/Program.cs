using System;

namespace ContaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Cliente1 = new Cliente(1, 2200, 300, 400, 2000);

            Console.WriteLine("Seu saldo é de:" + Cliente1.NovoSaldo());

            Cliente1.AtualizarSaldo();

            if(Cliente1.UltrapassouLimite())
            {
                Console.WriteLine("Limite de creditor excedido!!");
            }
         

            


                     
            
        }
    }
}
