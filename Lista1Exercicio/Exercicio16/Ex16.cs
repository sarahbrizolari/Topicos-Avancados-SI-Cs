// See https://aka.ms/new-console-template for more information
Console.WriteLine("Crie um programa que solicite ao usuário um número e exiba na tela a sequência de Fibonacci até esse número.");

int n = 10; 
int p = 0, s = 1, prox;

Console.Write(p + " " + s + " ");

for (int i = 3; i <= n; i++)
{
    prox = p + s;
    Console.Write(prox + " ");

    p = s;
    s = prox;
}