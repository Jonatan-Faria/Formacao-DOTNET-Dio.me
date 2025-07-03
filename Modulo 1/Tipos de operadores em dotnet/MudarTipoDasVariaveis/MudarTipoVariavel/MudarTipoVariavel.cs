


// cast e casting = converter um tipo de variavel

// primeira forma
int ale = Convert.ToInt32("5");
Console.WriteLine(ale);

//segunda forma
int sele = int.Parse("7");
Console.WriteLine(sele);

// convert é muito melhor que o parse

string texto = "6a";
int numero = 1;
int.TryParse( texto, out numero);
