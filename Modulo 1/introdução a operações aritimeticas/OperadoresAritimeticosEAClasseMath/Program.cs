using ClasseCalculadora.models;

Calculadora Calculadora = new Calculadora();
Console.WriteLine("Digite um numero: ");
string r1 = Console.ReadLine();
int n1 = Convert.ToInt32(r1);
Console.WriteLine("Digite outro numero: ");
string r2 = Console.ReadLine();
int n2 = Convert.ToInt32(r2);

Calculadora.somar(n1,n2);
Calculadora.subtrair(n1,n2);
Calculadora.multiplicar(n1,n2);
Calculadora.dividir(n1,n2);
Calculadora.resto(n1,n2);
Calculadora.esponencialisar(n1,n2);
Calculadora.seno(n1);
Calculadora.seno(n2);
Calculadora.cosseno(n1);
Calculadora.cosseno(n2);
Calculadora.tangente(n1);
Calculadora.tangente(n2);
Calculadora.raizquadrada(n1);
Calculadora.raizquadrada(n2);