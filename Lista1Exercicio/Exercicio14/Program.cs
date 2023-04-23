// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que solicite ao usuário um número e exiba na tela se esse número é par ou ímpar.");

Console.Write("Digite um numero: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n % 2 == 0 ? "Seu número é par" : "Seu número é impar");
