// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa que leia um número inteiro e informe se ele é par ou ímpar.");

Console.WriteLine("Digite um numero inteiro: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine("Este numero eh par! ");
}else if (n % 2 == 1)
{
    Console.WriteLine("Este numero eh impar! ");
}
