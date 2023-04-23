// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa que calcule a média de um conjunto de números informados pelo usuário. O usuário deve informar quantos números deseja informar.");

Console.WriteLine("Quantos numeros voce ira informar? ");
int n = int.Parse(Console.ReadLine());

double soma = 0;
int[] max = new int[n];

for (int i = 0; i < max.Length; i++)
{
    Console.Write("Informe um numero para soma: ");
    max[i] = int.Parse(Console.ReadLine());
    soma += max[i];
}
double media = soma / n;
Console.WriteLine($"O Valor da média entre os números informados é {media}");