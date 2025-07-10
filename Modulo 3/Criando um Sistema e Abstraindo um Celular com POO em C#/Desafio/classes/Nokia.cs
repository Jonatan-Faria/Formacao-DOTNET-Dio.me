using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.classes
{
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void Detalhes()
        {
            Console.WriteLine($"Especificações do dispositivo");
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memória: {Memoria}");
        } 

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Você instalou o app: {nomeApp} com sucesso");
        }
    }
}