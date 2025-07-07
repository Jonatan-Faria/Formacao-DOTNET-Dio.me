using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using Herança_na_prática.classes;

Professor P1 = new Professor(); 
Aluno A1 = new Aluno();

A1.nome = "Diego"; A1.idade = 15; A1.nota = 10;
A1.apresentar();

P1.nome = "Pedro"; P1.idade = 40;
P1.apresentar();