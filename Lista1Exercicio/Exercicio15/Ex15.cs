// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que solicite ao usuário um número e exiba na tela se esse número é positivo, negativo ou zero.");

Console.Write("Digite um numero: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
    Console.WriteLine($"O numero {n} eh negativo");
else if (n > 0)
    Console.WriteLine($"O numero {n} eh positivo");
else
    Console.WriteLine("Seu numero eh zero");