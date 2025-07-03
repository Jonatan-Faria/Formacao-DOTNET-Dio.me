//////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////

using System.Reflection.Metadata;

///                   Operdor OR                           ///
bool Dinheiro = true;
bool Cartao = false;

if (Dinheiro || Cartao)
{
    Console.WriteLine("Consigo pegar ônibus!");
}
else
{
    Console.WriteLine("Vou ter que ir a pé!");
}

//////////////////////////////////////////////////////////////
///                   Operdor AND                          ///
//////////////////////////////////////////////////////////////

bool visto = true;
bool passagem = true;

if (visto && passagem)
{
    Console.WriteLine("Consigo viajar");
}
else
{
    Console.WriteLine("Vou ter que ficar em casa essas férias");
}

//////////////////////////////////////////////////////////////
///                   Operdor NOT                          ///
//////////////////////////////////////////////////////////////

bool Vontade = true;
bool Dinheiro2 = true;

if (!Vontade && !Dinheiro2)
{
    Console.WriteLine("Que vontade de ficar em casa em... mas tenho que pagar as contas");
}
else 
{
    Console.WriteLine("Vou ficar em casa e tomar um café passado no filtro 2 vezes"); 
}