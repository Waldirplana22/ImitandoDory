using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("----Imitando Dory----");
  string frase, baleeis;

Console.WriteLine();

Console.WriteLine("Vamos escrever uma frase e traduzir em Baleeis? Escreva uma frase:\n");
frase = Console.ReadLine()!;

baleeis = frase
.Replace("a", "aaa") // replace troca o primeiro valor para o segundo
.Replace("A", "AAA")
.Replace("e", "eee")
.Replace("E", "EEE")
.Replace("i", "iii")
.Replace("I", "III")
.Replace("o", "ooo")
.Replace("O", "OOO")
.Replace("u", "uuu")
.Replace("U", "UUU");

Console.WriteLine();
Console.WriteLine("Em Baleeis a frase fica assim:\n");
Console.WriteLine(baleeis);
  }
}

