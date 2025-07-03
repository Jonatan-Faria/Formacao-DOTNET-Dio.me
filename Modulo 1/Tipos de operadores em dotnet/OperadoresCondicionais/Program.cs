////////////////////////////////////////////////////////////////////////////////////////
///                               if | else | elseif                                 ///
/// ////////////////////////////////////////////////////////////////////////////////////


int quantidadeEstoque = 10;
int quantidadeCompra = 5;
bool possivelvenda = quantidadeEstoque > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a encomenda? {possivelvenda}");


if (quantidadeCompra == 0)
{
    Console.WriteLine("Não há vendas disponiveis");
}
else if (possivelvenda == true)
{
    Console.WriteLine("Venda feita com sucesso!");
}
else
{
    Console.WriteLine("Infelizmente não temos estoque para realizarmos a sua compra.");
}


////////////////////////////////////////////////////////////////////////////////////////
///                               Switch Case                                        ///
/// ////////////////////////////////////////////////////////////////////////////////////
 
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch(letra)
{
    case "a":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
    Console.WriteLine("Consoante");
    break;

}
