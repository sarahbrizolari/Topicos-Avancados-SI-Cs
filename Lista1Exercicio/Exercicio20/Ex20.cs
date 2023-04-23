// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que solicite ao usuário um número e exiba na tela a sua tabuada de multiplicação e de divisão, de 1 a 10.");

Console.WriteLine("Hello, World!");

Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Tabuada de Multiplicação:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.WriteLine("Tabuada de Divisão:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} ÷ {i} = {numero / i}");
}
