int[] arrayinteiros = new int[5];
arrayinteiros[0] = 16; arrayinteiros[1] = 32; arrayinteiros[2] = 64; arrayinteiros[3] = 124; arrayinteiros[4] = 248;

int[] arrayInteirosDobrados = new int[arrayinteiros.Length *2];
Array.Copy(arrayinteiros, arrayInteirosDobrados, arrayinteiros.Length);









for(int contador = 0; contador < arrayinteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº{contador} - {arrayinteiros[contador]}");
};

int contadorForeach = 0;
foreach(int valor in arrayinteiros)
{
    Console.WriteLine($"Posição Nº{contadorForeach} - {valor}");
    contadorForeach++;
};