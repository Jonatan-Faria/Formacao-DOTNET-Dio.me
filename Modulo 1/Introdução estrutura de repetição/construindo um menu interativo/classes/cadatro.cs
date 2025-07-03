using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construindo_um_menu_interativo.classes
{
    public class Cadatro
    {
      public string nome { get; set; }
      public int idade { get; set; }
      public string endereco { get; set; }

      public void ResultadoCadastro ()
      {
        Console.WriteLine ("================================");
        Console.WriteLine($"Nome:{nome}                 ");
        Console.WriteLine($"Idade:{idade}                ");
        Console.WriteLine($"Endereço:{endereco}             ");
        Console.WriteLine ("================================");
      }
    }
}