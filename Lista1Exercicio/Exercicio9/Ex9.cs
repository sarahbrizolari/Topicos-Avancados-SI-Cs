// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faça um programa que leia um número inteiro e informe se ele é um número perfeito. Um número perfeito é aquele cuja soma dos seus divisores (exceto ele mesmo) é igual ao próprio número.\r\n");

Console.Write("Digite um numero: ");
int n = int.Parse(Console.ReadLine());

float soma = 0;
for (int i = 1; i < n; i++)
    if (n % i == 0)
        soma += i;

if (soma == n)
    Console.WriteLine($"O número {n} é perfeito!");
else
    Console.WriteLine($"O Numero {n} não é um numero perfeito!");