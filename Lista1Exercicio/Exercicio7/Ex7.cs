// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa que calcule o fatorial de um número informado pelo usuário.");

int n;
int fatorial = 1;
Console.Write("Informe o número que que deseja fatorar: ");
n = int.Parse(Console.ReadLine());

for (int i = n; i >= 1; i--)
{
    fatorial *= i;

}
Console.WriteLine(fatorial);