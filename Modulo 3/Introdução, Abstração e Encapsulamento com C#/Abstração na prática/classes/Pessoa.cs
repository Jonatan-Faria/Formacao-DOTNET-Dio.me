using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstração_na_prática.classes
{
    public class Pessoa
    {
        public string nome { get; set;}
        public int idade{ get; set;}

        public void apresentar()
        {
            Console.WriteLine($"Olá eu me chamo {nome} e tenho {idade} anos");
        }
    }
}