using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Execoes_Excecao.Models
{
    public class exemploExcecao
    {
        public void metodo1()
        {
            try
            {
                metodo2();
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção tratada");
            }
        }
        public void metodo2()
        {
            metodo3();
        }
        public void metodo3()
        {
            metodo4();
        }
        public void metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
    
}