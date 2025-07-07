using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança_na_prática.classes
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }


        public override void apresentar()
        {
            Console.WriteLine($"Boa tarde! Meu nome é {nome}, tenho {idade} anos e serei o professor de vocês.");
        }
    }
}