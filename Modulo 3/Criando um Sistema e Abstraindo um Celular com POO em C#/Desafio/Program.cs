
using System.ComponentModel;
using Desafio.classes;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia("40028922", "Tijolão", "11111010000",126);
nokia.Ligar();
nokia.Detalhes();
nokia.InstalarAplicativo("Play store");

Console.WriteLine("");

Console.WriteLine("Smartphone Nokia:");

Smartphone iphone = new Iphone("97626856", "Iphone 4s", "11111011011",512);
iphone.Ligar();
iphone.Detalhes();
iphone.InstalarAplicativo("Apple Store");