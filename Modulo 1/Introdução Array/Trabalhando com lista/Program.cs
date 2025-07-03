using System.Diagnostics.Contracts;

List<string> listString = new List<string>();
listString.Add("SP");
listString.Add("BA");
listString.Add("MG");

for(int Contador = 0; Contador < listString.Count; Contador++)
{
    Console.WriteLine($"Posição Nº{Contador} - {listString[Contador]}");
}

int contInt = 0;
foreach(string lista in listString)
{
    Console.WriteLine($"Posição Nº{contInt} - {listString[contInt]}");
    contInt++;
}