int n1 = 1;

Console.WriteLine($"{n1} X 1 = {n1 * 1}");
// primeiro você cria uma unidade contavel(variavel) |contador|
// Depois o periodo que vais se repetir |contador <= 10|
// o que vai mudar toda vez que se repetir |contador ++| 
for (int contador = 0; contador <= 2; contador++)

{
   Console.WriteLine($"{n1} X {contador} = {n1 * contador}"); 
}

int fator1 = 10;
int fator2 = 10;
int auxiliar = 0;

while (auxiliar <= 2)
{
   Console.WriteLine($"{auxiliar + 1}  | {fator1} X {fator2} = {fator1 * fator2}");
   fator2++;
   auxiliar++;
}


int numero1 = 0;
int numero2 = 0;
do
{

   Console.WriteLine("Digite um numero! (0 para parar)");
   numero2 = Convert.ToInt32 (Console.ReadLine());
   
   numero1 += numero2;
} while (numero2 != 0);

Console.WriteLine($"Total da soma do numero digitado é igual a {numero1}");