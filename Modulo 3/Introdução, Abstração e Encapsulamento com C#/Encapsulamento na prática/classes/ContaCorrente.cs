using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento_na_prática.classes
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;

        }
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; }
        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("O valor desejado é maior que o saldo disponivel. ");
            }
        }
        public void mostarSaldo()
        {
            Console.WriteLine(Saldo);
        }
    }
}