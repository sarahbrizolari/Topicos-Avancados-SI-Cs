// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa que leia uma lista de números e informe qual é o segundo maior número da lista");
int[] numeros = { 6, 991, 12, 55, 89, 0, 21, 7  };

int maior = 0;
int sMaior = 0;

foreach (int i in numeros)
{
    Console.WriteLine(i);
    int n = i;
    if (n > maior)
    {
        sMaior = maior;
        maior = n;
    }
    else if (n > sMaior)
    {
        sMaior = n;
    }
}

Console.WriteLine($"\n \nO Segundo maior número é {sMaior}");