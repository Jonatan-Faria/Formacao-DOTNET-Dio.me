using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseCalculadora.models
{
    public class Calculadora
    {
        public void somar(int x, int y )
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
         public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
         public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
         public void dividir(decimal x, decimal y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
         public void resto(int x, int y)
        {
            Console.WriteLine($"O resto de {x} / {y} = {x % y}");
        }
         public void esponencialisar(int x, int y)
        {
            double pot = Math.Pow(x , y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        } 
        public void seno (double angulo)
        {
           double radiano = angulo * Math.PI / 180;
           double seno = Math.Sin(radiano);
           Console.WriteLine($"seno de {angulo} é igual a {Math.Round( seno, 4)}");
        }
        public void cosseno (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
           double cosseno = Math.Cos(radiano);
           Console.WriteLine($"seno de {angulo} é igual a {Math.Round( cosseno, 4)}");
        }
        public void tangente(double angulo)
        {
           double radiano = angulo * Math.PI / 180;
           double tangente = Math.Tan(radiano);
           Console.WriteLine($"Tangente de {angulo} é igual a {Math.Round( tangente, 4)}"); 
        }
        public void raizquadrada (double x)
        {
          double raiz = Math.Sqrt(x);
          Console.WriteLine($"A raiz quadrada de {x} = {Math.Round(raiz, 4)}");
        }
            
        
        

        

    }
}