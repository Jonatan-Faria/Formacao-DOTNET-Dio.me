using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_abstrata_na_prática.Classes
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void exibirSaldo()
        {
            Console.WriteLine($"O seu saldo é de: {saldo}");
        }
    }
}