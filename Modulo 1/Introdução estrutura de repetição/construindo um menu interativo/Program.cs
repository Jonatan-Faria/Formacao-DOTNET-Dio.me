using construindo_um_menu_interativo.classes;

Cadatro cad = new Cadatro();
int opcao;
bool LigaDesliga = true;
while(LigaDesliga)
{
    Console.WriteLine ("================================");
    Console.WriteLine ("||    Digite a sua opção:     ||");
    Console.WriteLine ("================================");
    Console.WriteLine ("||   1 - Cadastrar cliente    ||");
    Console.WriteLine ("||   2 - Visualizar cliente   ||");
    Console.WriteLine ("||   3 - Apagar cliente       ||");
    Console.WriteLine ("||   4 - Encerrar             ||");
    Console.WriteLine ("================================");

    opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao)
    {
        case 0:
        break;
        case 1:
        Console.WriteLine ("================================");
        Console.WriteLine ("||        Digite o nome       ||");
        Console.WriteLine ("================================");

        cad.nome = Console.ReadLine();

        Console.WriteLine ("================================");
        Console.WriteLine ("||        Digite a idade      ||");
        Console.WriteLine ("================================");
        
        cad.idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("================================");
        Console.WriteLine ("||       Digite o endereço     ||");
        Console.WriteLine ("================================");

        cad.endereco = Console.ReadLine();

        cad.ResultadoCadastro();

        Console.WriteLine ("================================");
        Console.WriteLine ("||  Deseja fazer algo mais?   ||");
        Console.WriteLine ("================================");
        Console.WriteLine ("||  0 = SIM         4 = NÃO   ||");
        Console.WriteLine ("================================");

        opcao = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if(opcao == 4)
        {
            LigaDesliga = false;
        }
        break;

        case 2:
         cad.ResultadoCadastro();
         Console.WriteLine ("================================");
        Console.WriteLine ("||  Deseja fazer algo mais?   ||");
        Console.WriteLine ("================================");
        Console.WriteLine ("||  0 = SIM         4 = NÃO   ||");
        Console.WriteLine ("================================");

        opcao = Convert.ToInt32(Console.ReadLine());
        if(opcao == 4)
        {
            LigaDesliga = false;
        }
        break;

        case 3:
        cad.nome = "";
        cad.idade = 0;
        cad. endereco = "";
        break;

        case 4:
        LigaDesliga = false;
        break;
    }
}