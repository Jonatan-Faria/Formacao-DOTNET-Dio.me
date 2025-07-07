using System;
using Herança_na_prática.classes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança_na_prática.classes
{
  public class Aluno : Pessoa
  {
    public double nota { get; set; }

    public override void apresentar()
    {
      Console.WriteLine($"Olá eu sou {nome}, tenho {idade} e tirei {nota} em matemática");
    }
  }
}