// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que solicite ao usuário um número e exiba na tela a tabuada desse número, de 1 a 10.");

Console.Write("Digite um numero para tabuada: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
    Console.Write($"{n} x {i} = {n * i}\n");
