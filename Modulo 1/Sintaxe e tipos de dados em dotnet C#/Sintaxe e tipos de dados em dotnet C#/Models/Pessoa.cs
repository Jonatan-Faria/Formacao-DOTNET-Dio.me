using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace humanos.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public void apresentar()
        {
            Console.WriteLine ($"Olá, seu nome é {nome} e sua idade é {idade}");
        }
    }
}