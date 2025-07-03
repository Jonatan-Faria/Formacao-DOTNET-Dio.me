using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veiculos.models;
public class Veiculo
{
    public string Placa { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    private List<Veiculo> veiculos = new List<Veiculo>();
}