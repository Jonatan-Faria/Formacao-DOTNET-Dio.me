using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor_por_herança.classes
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base (nome, idade)
        {

        }
        
    }
}