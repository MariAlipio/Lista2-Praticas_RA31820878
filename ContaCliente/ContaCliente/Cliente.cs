using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCliente
{
    class Cliente
    {
        private int conta;
        private int saldoI;
        private int cobrancas;
        private int creditos;
        private int limite;

        public Cliente() { }
        public Cliente(int conta, int saldoI, int cobrancas, int creditos, int limite)
        {
            this.conta = conta;
            this.saldoI = saldoI;
            this.cobrancas = cobrancas;
            this.creditos = creditos;
            this.limite = limite;
                      
        }

        public int Limite()
        {
            return limite;
        }

        public int SaldoI()
        {
            return saldoI;
        }

        public int NovoSaldo()
        {
            return this.saldoI + this.cobrancas - this.creditos; 
        }

        public void AtualizarSaldo()
        {
            this.saldoI = NovoSaldo();
        }

        public bool UltrapassouLimite()
        {
            //condição para ultrapassou o limite
            return this.saldoI > this.limite;
        }

        


       


    }
}
