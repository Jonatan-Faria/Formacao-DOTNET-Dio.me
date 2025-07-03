using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using veiculos.models;

namespace Estacionamentos.models
{
    public class Estacionamento
    {
        private decimal pInicial;
        private decimal pHora;

        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal pInicial, decimal pHora)
        {
            this.pInicial = pInicial;
            this.pHora = pHora;
        }

        public void addVeiculos()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Digite a placa do veículo para estacionar:");  string placa = Console.ReadLine();
            Console.WriteLine("Digite a cor do veículo para estacionar:");    string cor = Console.ReadLine();
            Console.WriteLine("Digite o modelo do veículo para estacionar:"); string modelo = Console.ReadLine();

            veiculos.Add(new Veiculo
            {
                Placa  = placa,
                Cor    = cor,
                Modelo = modelo
            });

            Console.WriteLine("Veículo adicionado com sucesso!");
            Console.WriteLine("========================================================================================");
        }

        public void rmVeiculos()
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            var veiculo = veiculos.FirstOrDefault(v => v.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));

            if (veiculo != null)
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = pInicial + pHora * horas;
                veiculos.Remove(veiculo);

                Console.WriteLine($"O veículo {veiculo.Placa}, cor {veiculo.Cor} e modelo {veiculo.Modelo} foi removido.");
                Console.WriteLine($"Preço total: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }

            Console.WriteLine("========================================================================================");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("========================================================================================");
                Console.WriteLine("      Lista de Veículos Estacionados");
                Console.WriteLine("========================================================================================");

                foreach (var v in veiculos)
                {
                    Console.WriteLine($"Placa: {v.Placa} | Modelo: {v.Modelo} | Cor: {v.Cor}");
                }

                Console.WriteLine("========================================================================================");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
                Console.WriteLine("========================================================================================");
            }
        }
    }
}